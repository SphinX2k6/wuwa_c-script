using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002AA9 RID: 10921
internal class SubPackageDownLoadSubPackageItem : UiPanelBase
{
	// Token: 0x06016BCF RID: 93135 RVA: 0x005C48FC File Offset: 0x005C2AFC
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

	// Token: 0x06016BD0 RID: 93136 RVA: 0x005C4A8B File Offset: 0x005C2C8B
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshSubPackDownLoadState, new Action(this.OnRefreshSubPackDownLoadState));
	}

	// Token: 0x06016BD1 RID: 93137 RVA: 0x005C4AA9 File Offset: 0x005C2CA9
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshSubPackDownLoadState, new Action(this.OnRefreshSubPackDownLoadState));
	}

	// Token: 0x06016BD2 RID: 93138 RVA: 0x005C4AC8 File Offset: 0x005C2CC8
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

	// Token: 0x06016BD3 RID: 93139 RVA: 0x005C4B90 File Offset: 0x005C2D90
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

	// Token: 0x06016BD4 RID: 93140 RVA: 0x005C4D1C File Offset: 0x005C2F1C
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

	// Token: 0x06016BD5 RID: 93141 RVA: 0x005C4DAA File Offset: 0x005C2FAA
	public void RefreshDownLoadStateByTime()
	{
		if (this.State == ESubPackageDownLoadState.DownLoading)
		{
			this.RefreshProgressText();
		}
	}

	// Token: 0x06016BD6 RID: 93142 RVA: 0x005C4DBB File Offset: 0x005C2FBB
	[NullableContext(1)]
	public UUIItem GetBtnItem()
	{
		return base.GetItem(10);
	}

	// Token: 0x06016BD7 RID: 93143 RVA: 0x005C4DC5 File Offset: 0x005C2FC5
	private void OnClickStartBtn()
	{
		Action onClickBtn = this.OnClickBtn;
		if (onClickBtn != null)
		{
			onClickBtn();
		}
		SubPackageController.Instance.RestartSubPackageDownLoading(this.SubPackageId, new Action(this.RefreshDownLoadState));
	}

	// Token: 0x06016BD8 RID: 93144 RVA: 0x005C4DF8 File Offset: 0x005C2FF8
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

	// Token: 0x06016BD9 RID: 93145 RVA: 0x005C4E5E File Offset: 0x005C305E
	private void OnClickStopBtn()
	{
		Action onClickBtn = this.OnClickBtn;
		if (onClickBtn != null)
		{
			onClickBtn();
		}
		SubPackageController.Instance.StopSubPackageDownLoading(this.SubPackageId, new Action(this.RefreshDownLoadState));
	}

	// Token: 0x06016BDA RID: 93146 RVA: 0x005C4E8D File Offset: 0x005C308D
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

	// Token: 0x06016BDB RID: 93147 RVA: 0x005C4EB6 File Offset: 0x005C30B6
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

	// Token: 0x06016BDC RID: 93148 RVA: 0x005C4EF1 File Offset: 0x005C30F1
	private void RefreshDownLoadState()
	{
		EventSystem.Instance.Emit(EEventName.OnRefreshSubPackDownLoadState);
	}

	// Token: 0x06016BDD RID: 93149 RVA: 0x005C4F03 File Offset: 0x005C3103
	private void OnRefreshSubPackDownLoadState()
	{
		if (this.SubPackageId == 0)
		{
			return;
		}
		this.RefreshState();
		this.RefreshProgressText();
	}

	// Token: 0x0400A8C7 RID: 43207
	[Nullable(2)]
	public Action OnClickBtn;

	// Token: 0x0400A8C8 RID: 43208
	private int SubPackageId;

	// Token: 0x0400A8C9 RID: 43209
	private ESubPackageDownLoadState State = ESubPackageDownLoadState.None;
}
