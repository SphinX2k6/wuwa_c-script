using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002AA7 RID: 10919
[NullableContext(2)]
[Nullable(0)]
internal class SubPackageDownLoadVersionItem : UiPanelBase
{
	// Token: 0x06016BBC RID: 93116 RVA: 0x005C3D6C File Offset: 0x005C1F6C
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

	// Token: 0x06016BBD RID: 93117 RVA: 0x005C3FE9 File Offset: 0x005C21E9
	protected override void OnStart()
	{
		base.GetText(4).SetUIActive(false);
		EventSystem.Instance.Add(EEventName.OnRefreshSubPackDownLoadState, new Action(this.OnRefreshSubPackDownLoadVersionState));
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06016BBE RID: 93118 RVA: 0x005C4025 File Offset: 0x005C2225
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshSubPackDownLoadState, new Action(this.OnRefreshSubPackDownLoadVersionState));
		if (this.LevelSequencePlayer != null)
		{
			this.LevelSequencePlayer.Clear();
			this.LevelSequencePlayer = null;
		}
	}

	// Token: 0x06016BBF RID: 93119 RVA: 0x005C4060 File Offset: 0x005C2260
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

	// Token: 0x06016BC0 RID: 93120 RVA: 0x005C41EC File Offset: 0x005C23EC
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

	// Token: 0x06016BC1 RID: 93121 RVA: 0x005C4338 File Offset: 0x005C2538
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

	// Token: 0x06016BC2 RID: 93122 RVA: 0x005C4644 File Offset: 0x005C2844
	public void RefreshDownLoadStateByTime()
	{
		if (this.State == ESubPackageDownLoadState.DownLoading)
		{
			this.RefreshTipsText();
		}
	}

	// Token: 0x06016BC3 RID: 93123 RVA: 0x005C4655 File Offset: 0x005C2855
	[NullableContext(1)]
	public UUIItem GetToggleItem()
	{
		return base.GetExtendToggle(17).RootUIComp;
	}

	// Token: 0x06016BC4 RID: 93124 RVA: 0x005C4669 File Offset: 0x005C2869
	private void OnClickHelpBtn()
	{
		Action<int, UUIItem> onClickHelpBtnCallBack = this.OnClickHelpBtnCallBack;
		if (onClickHelpBtnCallBack == null)
		{
			return;
		}
		onClickHelpBtnCallBack(this.VersionId, base.GetButton(2).RootUIComp);
	}

	// Token: 0x06016BC5 RID: 93125 RVA: 0x005C4694 File Offset: 0x005C2894
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

	// Token: 0x06016BC6 RID: 93126 RVA: 0x005C471C File Offset: 0x005C291C
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

	// Token: 0x06016BC7 RID: 93127 RVA: 0x005C4780 File Offset: 0x005C2980
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

	// Token: 0x06016BC8 RID: 93128 RVA: 0x005C4804 File Offset: 0x005C2A04
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

	// Token: 0x06016BC9 RID: 93129 RVA: 0x005C482D File Offset: 0x005C2A2D
	private void OnClickPriorityBtn()
	{
		Action onClickBtn = this.OnClickBtn;
		if (onClickBtn != null)
		{
			onClickBtn();
		}
		SubPackageController.Instance.PrioritySubPackageDownLoading(this.SubPackageList, new Action(this.RefreshDownLoadState));
	}

	// Token: 0x06016BCA RID: 93130 RVA: 0x005C485D File Offset: 0x005C2A5D
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

	// Token: 0x06016BCB RID: 93131 RVA: 0x005C4882 File Offset: 0x005C2A82
	private void RefreshDownLoadState()
	{
		EventSystem.Instance.Emit(EEventName.OnRefreshSubPackDownLoadState);
	}

	// Token: 0x06016BCC RID: 93132 RVA: 0x005C4894 File Offset: 0x005C2A94
	private void OnRefreshSubPackDownLoadVersionState()
	{
		this.RefreshState();
		this.RefreshTipsText();
	}

	// Token: 0x0400A8B3 RID: 43187
	public Action OnClickBtn;

	// Token: 0x0400A8B4 RID: 43188
	public Action<int, bool> OnClickCallBack;

	// Token: 0x0400A8B5 RID: 43189
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, UUIItem> OnClickHelpBtnCallBack;

	// Token: 0x0400A8B6 RID: 43190
	public ESubPackageDownLoadVersionType Type = ESubPackageDownLoadVersionType.Key;

	// Token: 0x0400A8B7 RID: 43191
	private int VersionId;

	// Token: 0x0400A8B8 RID: 43192
	private bool IsSingleVersion;

	// Token: 0x0400A8B9 RID: 43193
	[Nullable(1)]
	private List<int> SubPackageList = new List<int>();

	// Token: 0x0400A8BA RID: 43194
	private ESubPackageDownLoadState State = ESubPackageDownLoadState.None;

	// Token: 0x0400A8BB RID: 43195
	private LevelSequencePlayer LevelSequencePlayer;
}
