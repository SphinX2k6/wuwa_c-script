using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002025 RID: 8229
internal class SubPackageDownLoadSubPackageItem : UiPanelBase
{
	// Token: 0x060145FE RID: 83454 RVA: 0x005F139C File Offset: 0x005EF59C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickStartBtn)),
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickDownLoadBtn)),
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickStopBtn)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickCancelBtn)),
			new ValueTuple<int, Delegate>(6, new Action(this.OnClickPriorityBtn))
		};
	}

	// Token: 0x060145FF RID: 83455 RVA: 0x005F152B File Offset: 0x005EF72B
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshSubPackDownLoadState, new Action(this.OnRefreshSubPackDownLoadState));
	}

	// Token: 0x06014600 RID: 83456 RVA: 0x005F1549 File Offset: 0x005EF749
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshSubPackDownLoadState, new Action(this.OnRefreshSubPackDownLoadState));
	}

	// Token: 0x06014601 RID: 83457 RVA: 0x005F1568 File Offset: 0x005EF768
	public void RefreshItem(int id, bool isDynamicRecall = false)
	{
		this.SubPackageId = id;
		if (isDynamicRecall)
		{
			RecallConfig? recallConfig;
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(((ConfigRecallConfigByRecallId.GetConfig(SubPackageDefine.RecallIdFromDynamic(id), true) != null) ? recallConfig.GetValueOrDefault().QuestName : null) ?? "", null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "SubPackageDownLoad_RecallVideoTitle", new <>z__ReadOnlySingleElementList<object>(localTextNew));
			this.RefreshState();
			this.RefreshProgressText();
			return;
		}
		DownLoadSubPackage? downLoadSubPackageById = SubPackageConfig.Instance.GetDownLoadSubPackageById(this.SubPackageId);
		if (downLoadSubPackageById == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), downLoadSubPackageById.Value.Title, Array.Empty<object>());
		this.RefreshState();
		this.RefreshProgressText();
	}

	// Token: 0x06014602 RID: 83458 RVA: 0x005F1630 File Offset: 0x005EF830
	public void RefreshState()
	{
		this.State = SubPackageDownLoadModel.Instance.GetSubPackageDownLoadItemStateById(this.SubPackageId);
		base.GetButton(2).RootUIComp.Get().SetUIActive(this.State == ESubPackageDownLoadState.Pause);
		base.GetButton(3).RootUIComp.Get().SetUIActive(this.State == ESubPackageDownLoadState.None);
		base.GetButton(4).RootUIComp.Get().SetUIActive(this.State == ESubPackageDownLoadState.DownLoading);
		base.GetButton(5).RootUIComp.Get().SetUIActive(this.State == ESubPackageDownLoadState.DownLoading || this.State == ESubPackageDownLoadState.Waiting || this.State == ESubPackageDownLoadState.Pause);
		base.GetButton(6).RootUIComp.Get().SetUIActive(this.State == ESubPackageDownLoadState.Waiting && SubPackageDownLoadModel.Instance.IsKeyPackageDownLoadingFinish());
		base.GetItem(7).SetUIActive(this.State == ESubPackageDownLoadState.Waiting && !SubPackageDownLoadModel.Instance.IsKeyPackageDownLoadingFinish());
		bool flag = this.State == ESubPackageDownLoadState.Finish;
		base.GetItem(8).SetUIActive(flag);
		UUIItem item = base.GetItem(9);
		UUIItem uuiitem = item;
		bool bUseChangeColor = flag;
		FColor? fcolor = new FColor?(item.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		UUIText text = base.GetText(0);
		UUIItem uuiitem2 = text;
		bool bUseChangeColor2 = flag;
		fcolor = new FColor?(text.changeColor);
		uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
		UUIText text2 = base.GetText(1);
		UUIItem uuiitem3 = text2;
		bool bUseChangeColor3 = flag;
		fcolor = new FColor?(text2.changeColor);
		uuiitem3.SetChangeColor(bUseChangeColor3, fcolor);
	}

	// Token: 0x06014603 RID: 83459 RVA: 0x005F17BC File Offset: 0x005EF9BC
	private void RefreshProgressText()
	{
		UUIText text = base.GetText(1);
		if (this.State == ESubPackageDownLoadState.Finish)
		{
			text.SetUIActive(false);
			return;
		}
		text.SetUIActive(true);
		long subPackageHaveDownLoadSpace = SubPackageDownLoadModel.Instance.GetSubPackageHaveDownLoadSpace(this.SubPackageId);
		long subPackageSpace = SubPackageDownLoadModel.Instance.GetSubPackageSpace(this.SubPackageId);
		if (subPackageHaveDownLoadSpace <= 0L)
		{
			text.SetText(SubPackageDownLoadModel.Instance.ByteConverter(subPackageSpace), true);
			return;
		}
		text.SetText(SubPackageDownLoadModel.Instance.ByteConverter(subPackageHaveDownLoadSpace) + "/" + SubPackageDownLoadModel.Instance.ByteConverter(subPackageSpace), true);
	}

	// Token: 0x06014604 RID: 83460 RVA: 0x005F184A File Offset: 0x005EFA4A
	public void RefreshDownLoadStateByTime()
	{
		if (this.State == ESubPackageDownLoadState.DownLoading)
		{
			this.RefreshProgressText();
		}
	}

	// Token: 0x06014605 RID: 83461 RVA: 0x005F185B File Offset: 0x005EFA5B
	[NullableContext(1)]
	public UUIItem GetBtnItem()
	{
		return base.GetItem(10);
	}

	// Token: 0x06014606 RID: 83462 RVA: 0x005F1865 File Offset: 0x005EFA65
	private void OnClickStartBtn()
	{
		Action onClickBtn = this.OnClickBtn;
		if (onClickBtn != null)
		{
			onClickBtn();
		}
		SubPackageController.Instance.RestartSubPackageDownLoading(this.SubPackageId, new Action(this.RefreshDownLoadState));
	}

	// Token: 0x06014607 RID: 83463 RVA: 0x005F1898 File Offset: 0x005EFA98
	private void OnClickDownLoadBtn()
	{
		Action onClickBtn = this.OnClickBtn;
		if (onClickBtn != null)
		{
			onClickBtn();
		}
		if (SubPackageDownLoadModel.Instance.IsKeyPackageDownLoading())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("SubPackageDownLoad_Des_WaitKeyItemDownLoad", Array.Empty<object>());
		}
		SubPackageController.Instance.PushSubPackageDownLoading(new List<int>
		{
			this.SubPackageId
		}, new Action(this.RefreshDownLoadState));
	}

	// Token: 0x06014608 RID: 83464 RVA: 0x005F18FE File Offset: 0x005EFAFE
	private void OnClickStopBtn()
	{
		Action onClickBtn = this.OnClickBtn;
		if (onClickBtn != null)
		{
			onClickBtn();
		}
		SubPackageController.Instance.StopSubPackageDownLoading(this.SubPackageId, new Action(this.RefreshDownLoadState));
	}

	// Token: 0x06014609 RID: 83465 RVA: 0x005F192D File Offset: 0x005EFB2D
	private void OnClickCancelBtn()
	{
		Action onClickBtn = this.OnClickBtn;
		if (onClickBtn != null)
		{
			onClickBtn();
		}
		SubPackageController.Instance.CancelSubPackageDownLoading(this.SubPackageId);
		this.RefreshDownLoadState();
	}

	// Token: 0x0601460A RID: 83466 RVA: 0x005F1956 File Offset: 0x005EFB56
	private void OnClickPriorityBtn()
	{
		Action onClickBtn = this.OnClickBtn;
		if (onClickBtn != null)
		{
			onClickBtn();
		}
		SubPackageController.Instance.PrioritySubPackageDownLoading(new List<int>
		{
			this.SubPackageId
		}, new Action(this.RefreshDownLoadState));
	}

	// Token: 0x0601460B RID: 83467 RVA: 0x005F1991 File Offset: 0x005EFB91
	private void RefreshDownLoadState()
	{
		EventSystem.Instance.Emit(EEventName.OnRefreshSubPackDownLoadState);
	}

	// Token: 0x0601460C RID: 83468 RVA: 0x005F19A3 File Offset: 0x005EFBA3
	private void OnRefreshSubPackDownLoadState()
	{
		if (this.SubPackageId == 0)
		{
			return;
		}
		this.RefreshState();
		this.RefreshProgressText();
	}

	// Token: 0x0400ACCD RID: 44237
	[Nullable(2)]
	public Action OnClickBtn;

	// Token: 0x0400ACCE RID: 44238
	private int SubPackageId;

	// Token: 0x0400ACCF RID: 44239
	private ESubPackageDownLoadState State = ESubPackageDownLoadState.None;
}
