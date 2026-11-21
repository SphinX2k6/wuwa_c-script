using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000CB3 RID: 3251
[NullableContext(1)]
[Nullable(0)]
public class CommonRewardPopup : UiPanelBase
{
	// Token: 0x060087A6 RID: 34726 RVA: 0x0029452A File Offset: 0x0029272A
	public CommonRewardPopup(UUIItem parentItem)
	{
		base.CreateByResourceIdAsync("UiItem_RewardPopup", parentItem, false);
	}

	// Token: 0x060087A7 RID: 34727 RVA: 0x0029454C File Offset: 0x0029274C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnMaskBtnClick))
		};
	}

	// Token: 0x060087A8 RID: 34728 RVA: 0x002945DF File Offset: 0x002927DF
	protected override void OnBeforeCreateImplement()
	{
		this.Sequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.Sequence);
	}

	// Token: 0x060087A9 RID: 34729 RVA: 0x002945FC File Offset: 0x002927FC
	protected override void OnStart()
	{
		this.RewardPanel = new GenericLayout<RewardPanelItem, DailyActivityDefine.RewardTuple>(base.GetHorizontalLayout(0), new Func<RewardPanelItem>(this.CreateRewardItem), null, false, true);
		this.SetActive(false);
		foreach (Action action in this.OperationMap.Values)
		{
			action();
		}
	}

	// Token: 0x060087AA RID: 34730 RVA: 0x0029467C File Offset: 0x0029287C
	protected override UniTask OnShowAsyncImplementImplement()
	{
		CommonRewardPopup.<OnShowAsyncImplementImplement>d__9 <OnShowAsyncImplementImplement>d__;
		<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnShowAsyncImplementImplement>d__.<>4__this = this;
		<OnShowAsyncImplementImplement>d__.<>1__state = -1;
		<OnShowAsyncImplementImplement>d__.<>t__builder.Start<CommonRewardPopup.<OnShowAsyncImplementImplement>d__9>(ref <OnShowAsyncImplementImplement>d__);
		return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x060087AB RID: 34731 RVA: 0x002946C0 File Offset: 0x002928C0
	protected override UniTask OnHideAsyncImplementImplement()
	{
		CommonRewardPopup.<OnHideAsyncImplementImplement>d__10 <OnHideAsyncImplementImplement>d__;
		<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHideAsyncImplementImplement>d__.<>4__this = this;
		<OnHideAsyncImplementImplement>d__.<>1__state = -1;
		<OnHideAsyncImplementImplement>d__.<>t__builder.Start<CommonRewardPopup.<OnHideAsyncImplementImplement>d__10>(ref <OnHideAsyncImplementImplement>d__);
		return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x060087AC RID: 34732 RVA: 0x00294703 File Offset: 0x00292903
	protected override void OnBeforeDestroy()
	{
		this.RewardPanel.ClearChildren();
		this.RewardPanel = null;
		this.PopUpData = null;
		this.OperationMap.Clear();
	}

	// Token: 0x060087AD RID: 34733 RVA: 0x00294729 File Offset: 0x00292929
	public void Refresh(RewardPopupData data)
	{
		this.PopUpData = data;
		if (base.InAsyncLoading())
		{
			this.OperationMap.Add("Refresh", new Action(this.<Refresh>g__callback|12_0));
			return;
		}
		this.<Refresh>g__callback|12_0();
	}

	// Token: 0x060087AE RID: 34734 RVA: 0x0029475D File Offset: 0x0029295D
	private RewardPanelItem CreateRewardItem()
	{
		return new RewardPanelItem();
	}

	// Token: 0x060087AF RID: 34735 RVA: 0x00294764 File Offset: 0x00292964
	private void OnMaskBtnClick()
	{
		this.SetActive(false);
	}

	// Token: 0x060087B0 RID: 34736 RVA: 0x00294770 File Offset: 0x00292970
	[CompilerGenerated]
	private void <Refresh>g__callback|12_0()
	{
		if (this.PopUpData.RewardLists.Count == 0)
		{
			return;
		}
		FVector fvector = this.PopUpData.MountItem.GetLGUISpaceAbsolutePosition();
		if (this.PopUpData.PosBias != null)
		{
			FVector value = this.PopUpData.PosBias.Value;
			fvector = fvector + value;
		}
		base.GetItem(2).SetLGUISpaceAbsolutePosition(fvector);
		this.RewardPanel.RefreshByDataAsync(this.PopUpData.RewardLists, false, null).ContinueWith(delegate()
		{
			this.SetActive(true);
		});
	}

	// Token: 0x04005209 RID: 21001
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RewardPanelItem, DailyActivityDefine.RewardTuple> RewardPanel;

	// Token: 0x0400520A RID: 21002
	[Nullable(2)]
	private RewardPopupData PopUpData;

	// Token: 0x0400520B RID: 21003
	private readonly Dictionary<string, Action> OperationMap = new Dictionary<string, Action>();

	// Token: 0x0400520C RID: 21004
	[Nullable(2)]
	private UiBehaviorLevelSequence Sequence;

	// Token: 0x02006F7B RID: 28539
	[NullableContext(0)]
	private enum EPopupComponent
	{
		// Token: 0x040246BC RID: 149180
		PanelLayout,
		// Token: 0x040246BD RID: 149181
		RewardItem,
		// Token: 0x040246BE RID: 149182
		Panel,
		// Token: 0x040246BF RID: 149183
		MaskBtn
	}
}
