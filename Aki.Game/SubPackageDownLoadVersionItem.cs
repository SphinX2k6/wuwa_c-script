using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002023 RID: 8227
[NullableContext(2)]
[Nullable(0)]
internal class SubPackageDownLoadVersionItem : UiPanelBase
{
	// Token: 0x060145EB RID: 83435 RVA: 0x005F080C File Offset: 0x005EEA0C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(10, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(12, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(13, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(18, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickHelpBtn)),
			new ValueTuple<int, Delegate>(9, new Action(this.OnClickStartBtn)),
			new ValueTuple<int, Delegate>(10, new Action(this.OnClickAllDownLoadBtn)),
			new ValueTuple<int, Delegate>(11, new Action(this.OnClickStopBtn)),
			new ValueTuple<int, Delegate>(17, new Action<EToggleState>(this.OnClickToggle)),
			new ValueTuple<int, Delegate>(12, new Action(this.OnClickCancelBtn)),
			new ValueTuple<int, Delegate>(13, new Action(this.OnClickPriorityBtn))
		};
	}

	// Token: 0x060145EC RID: 83436 RVA: 0x005F0A89 File Offset: 0x005EEC89
	protected override void OnStart()
	{
		base.GetText(4).SetUIActive(false);
		EventSystem.Instance.Add(EEventName.OnRefreshSubPackDownLoadState, new Action(this.OnRefreshSubPackDownLoadVersionState));
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x060145ED RID: 83437 RVA: 0x005F0AC5 File Offset: 0x005EECC5
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshSubPackDownLoadState, new Action(this.OnRefreshSubPackDownLoadVersionState));
		if (this.LevelSequencePlayer != null)
		{
			this.LevelSequencePlayer.Clear();
			this.LevelSequencePlayer = null;
		}
	}

	// Token: 0x060145EE RID: 83438 RVA: 0x005F0B00 File Offset: 0x005EED00
	public void RefreshItem(int versionId, bool isShowSubItem)
	{
		this.VersionId = versionId;
		this.SubPackageList.Clear();
		DownLoadVersion? downLoadVersionByVersion = SubPackageConfig.Instance.GetDownLoadVersionByVersion(this.VersionId);
		if (downLoadVersionByVersion == null)
		{
			return;
		}
		foreach (DownLoadSubPackage downLoadSubPackage in (SubPackageConfig.Instance.GetDownLoadSubPackageListByVersion(this.VersionId) ?? new List<DownLoadSubPackage>()))
		{
			this.SubPackageList.Add(downLoadSubPackage.Id);
		}
		this.SubPackageList.AddRange(SubPackageDownLoadModel.Instance.GetDynamicRecallItemsByVersion(this.VersionId));
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), downLoadVersionByVersion.Value.Title, Array.Empty<object>());
		base.SetTextureByPath(downLoadVersionByVersion.Value.Pic, base.GetTexture(0), null, null);
		base.GetItem(7).SetUIActive(downLoadVersionByVersion.Value.IsRecommend);
		this.Type = (ESubPackageDownLoadVersionType)downLoadVersionByVersion.Value.Type;
		this.IsSingleVersion = !SubPackageDownLoadModel.Instance.GetVersionShowArrowByType(downLoadVersionByVersion.Value.Type);
		base.GetItem(6).SetUIActive(!this.IsSingleVersion);
		base.GetExtendToggle(17).SetToggleState(isShowSubItem ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		this.RefreshState();
		this.RefreshTipsText();
	}

	// Token: 0x060145EF RID: 83439 RVA: 0x005F0C8C File Offset: 0x005EEE8C
	public void RefreshState()
	{
		this.State = SubPackageDownLoadModel.Instance.GetSubPackageDownLoadVersionStateById(this.VersionId);
		base.GetButton(9).RootUIComp.Get().SetUIActive(this.State == ESubPackageDownLoadState.Pause);
		base.GetButton(10).RootUIComp.Get().SetUIActive(this.State == ESubPackageDownLoadState.None);
		base.GetButton(11).RootUIComp.Get().SetUIActive(this.State == ESubPackageDownLoadState.DownLoading);
		base.GetItem(14).SetUIActive(this.State == ESubPackageDownLoadState.Waiting && !SubPackageDownLoadModel.Instance.IsKeyPackageDownLoadingFinish());
		base.GetItem(15).SetUIActive(this.State == ESubPackageDownLoadState.Finish);
		base.GetButton(12).RootUIComp.Get().SetUIActive((this.State == ESubPackageDownLoadState.DownLoading || this.State == ESubPackageDownLoadState.Waiting || this.State == ESubPackageDownLoadState.Pause) && this.Type != ESubPackageDownLoadVersionType.Key);
		base.GetButton(13).RootUIComp.Get().SetUIActive(this.State == ESubPackageDownLoadState.Waiting && SubPackageDownLoadModel.Instance.IsKeyPackageDownLoadingFinish() && this.Type != ESubPackageDownLoadVersionType.Key);
	}

	// Token: 0x060145F0 RID: 83440 RVA: 0x005F0DD8 File Offset: 0x005EEFD8
	public void RefreshTipsText()
	{
		UUIText text = base.GetText(8);
		if (this.State == ESubPackageDownLoadState.DownLoading)
		{
			text.SetUIActive(true);
			text.SetText(SubPackageDownLoadModel.Instance.ByteConverter(SubPackageDownLoadModel.Instance.GetSubPackageDownLoadSpeed()) + "/s", true);
		}
		else if (this.State == ESubPackageDownLoadState.Pause)
		{
			text.SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(text, "Text_Pausing_Text", Array.Empty<object>());
		}
		else
		{
			text.SetUIActive(false);
		}
		long num = 0L;
		long num2 = 0L;
		foreach (int id in this.SubPackageList)
		{
			long subPackageSpace = SubPackageDownLoadModel.Instance.GetSubPackageSpace(id);
			if (subPackageSpace > 0L)
			{
				if (SubPackageDownLoadModel.Instance.GetSubPackageDownLoadItemStateById(id) != ESubPackageDownLoadState.Finish)
				{
					num += SubPackageDownLoadModel.Instance.GetSubPackageHaveDownLoadSpace(id);
				}
				else
				{
					num += subPackageSpace;
				}
				num2 += subPackageSpace;
			}
		}
		base.GetText(3).SetUIActive(num2 > 0L);
		if (num <= 0L)
		{
			base.GetText(3).SetText(SubPackageDownLoadModel.Instance.ByteConverter(num) + "/" + SubPackageDownLoadModel.Instance.ByteConverter(num2), true);
		}
		else if (this.State == ESubPackageDownLoadState.Finish || this.State == ESubPackageDownLoadState.None)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "ResDownLoadVersion_FinishTips", new <>z__ReadOnlySingleElementList<object>(SubPackageDownLoadModel.Instance.ByteConverter(num) + "/" + SubPackageDownLoadModel.Instance.ByteConverter(num2)));
		}
		else
		{
			long num3 = 0L;
			long num4 = 0L;
			foreach (int id2 in this.SubPackageList)
			{
				long subPackageSpace2 = SubPackageDownLoadModel.Instance.GetSubPackageSpace(id2);
				if (subPackageSpace2 > 0L)
				{
					ESubPackageDownLoadState subPackageDownLoadItemStateById = SubPackageDownLoadModel.Instance.GetSubPackageDownLoadItemStateById(id2);
					if (subPackageDownLoadItemStateById != ESubPackageDownLoadState.Finish && subPackageDownLoadItemStateById != ESubPackageDownLoadState.None)
					{
						num3 += SubPackageDownLoadModel.Instance.GetSubPackageHaveDownLoadSpace(id2);
						num4 += subPackageSpace2;
					}
				}
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "ResDownLoadVersion_DownLoadingTips", new <>z__ReadOnlyArray<object>(new object[]
			{
				SubPackageDownLoadModel.Instance.ByteConverter(num3) + "/" + SubPackageDownLoadModel.Instance.ByteConverter(num4),
				SubPackageDownLoadModel.Instance.ByteConverter(num2)
			}));
		}
		bool flag = base.GetItem(18).IsUIActiveSelf();
		if (this.State == ESubPackageDownLoadState.Finish || this.State == ESubPackageDownLoadState.None || num2 == 0L)
		{
			base.GetItem(18).SetUIActive(false);
			base.GetSprite(5).SetFillAmount(0f);
			return;
		}
		base.GetItem(18).SetUIActive(num > 0L);
		float fillAmount = (float)num / (float)num2;
		base.GetSprite(5).SetFillAmount(fillAmount);
		if (!flag && num > 0L)
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("Load", false, null, false);
		}
	}

	// Token: 0x060145F1 RID: 83441 RVA: 0x005F10E4 File Offset: 0x005EF2E4
	public void RefreshDownLoadStateByTime()
	{
		if (this.State == ESubPackageDownLoadState.DownLoading)
		{
			this.RefreshTipsText();
		}
	}

	// Token: 0x060145F2 RID: 83442 RVA: 0x005F10F5 File Offset: 0x005EF2F5
	[NullableContext(1)]
	public UUIItem GetToggleItem()
	{
		return base.GetExtendToggle(17).RootUIComp;
	}

	// Token: 0x060145F3 RID: 83443 RVA: 0x005F1109 File Offset: 0x005EF309
	private void OnClickHelpBtn()
	{
		Action<int, UUIItem> onClickHelpBtnCallBack = this.OnClickHelpBtnCallBack;
		if (onClickHelpBtnCallBack == null)
		{
			return;
		}
		onClickHelpBtnCallBack(this.VersionId, base.GetButton(2).RootUIComp);
	}

	// Token: 0x060145F4 RID: 83444 RVA: 0x005F1134 File Offset: 0x005EF334
	private void OnClickStartBtn()
	{
		Action onClickBtn = this.OnClickBtn;
		if (onClickBtn != null)
		{
			onClickBtn();
		}
		foreach (int id in this.SubPackageList)
		{
			if (SubPackageDownLoadModel.Instance.GetSubPackageDownLoadItemStateById(id) == ESubPackageDownLoadState.Pause)
			{
				SubPackageController.Instance.RestartSubPackageDownLoading(id, new Action(this.RefreshDownLoadState));
				break;
			}
		}
	}

	// Token: 0x060145F5 RID: 83445 RVA: 0x005F11BC File Offset: 0x005EF3BC
	private void OnClickAllDownLoadBtn()
	{
		Action onClickBtn = this.OnClickBtn;
		if (onClickBtn != null)
		{
			onClickBtn();
		}
		if (SubPackageDownLoadModel.Instance.IsKeyPackageDownLoading() && this.Type != ESubPackageDownLoadVersionType.Key)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("SubPackageDownLoad_Des_WaitKeyItemDownLoad", Array.Empty<object>());
		}
		SubPackageController.Instance.PushSubPackageDownLoading(this.SubPackageList, delegate
		{
			if (base.GetExtendToggle(17).ToggleState == EToggleState.ETT_Checked || this.IsSingleVersion)
			{
				this.RefreshDownLoadState();
				return;
			}
			Action<int, bool> onClickCallBack = this.OnClickCallBack;
			if (onClickCallBack == null)
			{
				return;
			}
			onClickCallBack(this.VersionId, true);
		});
	}

	// Token: 0x060145F6 RID: 83446 RVA: 0x005F1220 File Offset: 0x005EF420
	private void OnClickStopBtn()
	{
		Action onClickBtn = this.OnClickBtn;
		if (onClickBtn != null)
		{
			onClickBtn();
		}
		foreach (int id in this.SubPackageList)
		{
			if (SubPackageDownLoadModel.Instance.GetSubPackageDownLoadItemStateById(id) == ESubPackageDownLoadState.DownLoading)
			{
				SubPackageController.Instance.StopSubPackageDownLoading(id, new Action(this.RefreshDownLoadState));
			}
		}
	}

	// Token: 0x060145F7 RID: 83447 RVA: 0x005F12A4 File Offset: 0x005EF4A4
	private void OnClickCancelBtn()
	{
		Action onClickBtn = this.OnClickBtn;
		if (onClickBtn != null)
		{
			onClickBtn();
		}
		SubPackageController.Instance.CancelSubPackageDownLoadingList(this.SubPackageList);
		this.RefreshDownLoadState();
	}

	// Token: 0x060145F8 RID: 83448 RVA: 0x005F12CD File Offset: 0x005EF4CD
	private void OnClickPriorityBtn()
	{
		Action onClickBtn = this.OnClickBtn;
		if (onClickBtn != null)
		{
			onClickBtn();
		}
		SubPackageController.Instance.PrioritySubPackageDownLoading(this.SubPackageList, new Action(this.RefreshDownLoadState));
	}

	// Token: 0x060145F9 RID: 83449 RVA: 0x005F12FD File Offset: 0x005EF4FD
	private void OnClickToggle(EToggleState state)
	{
		if (this.IsSingleVersion)
		{
			return;
		}
		Action<int, bool> onClickCallBack = this.OnClickCallBack;
		if (onClickCallBack == null)
		{
			return;
		}
		onClickCallBack(this.VersionId, state == EToggleState.ETT_Checked);
	}

	// Token: 0x060145FA RID: 83450 RVA: 0x005F1322 File Offset: 0x005EF522
	private void RefreshDownLoadState()
	{
		EventSystem.Instance.Emit(EEventName.OnRefreshSubPackDownLoadState);
	}

	// Token: 0x060145FB RID: 83451 RVA: 0x005F1334 File Offset: 0x005EF534
	private void OnRefreshSubPackDownLoadVersionState()
	{
		this.RefreshState();
		this.RefreshTipsText();
	}

	// Token: 0x0400ACB9 RID: 44217
	public Action OnClickBtn;

	// Token: 0x0400ACBA RID: 44218
	public Action<int, bool> OnClickCallBack;

	// Token: 0x0400ACBB RID: 44219
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, UUIItem> OnClickHelpBtnCallBack;

	// Token: 0x0400ACBC RID: 44220
	public ESubPackageDownLoadVersionType Type = ESubPackageDownLoadVersionType.Key;

	// Token: 0x0400ACBD RID: 44221
	private int VersionId;

	// Token: 0x0400ACBE RID: 44222
	private bool IsSingleVersion;

	// Token: 0x0400ACBF RID: 44223
	[Nullable(1)]
	private List<int> SubPackageList = new List<int>();

	// Token: 0x0400ACC0 RID: 44224
	private ESubPackageDownLoadState State = ESubPackageDownLoadState.None;

	// Token: 0x0400ACC1 RID: 44225
	private LevelSequencePlayer LevelSequencePlayer;
}
