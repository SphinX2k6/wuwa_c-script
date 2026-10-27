using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020017FA RID: 6138
[NullableContext(1)]
[Nullable(0)]
public class CommonRewardPopup : UiPanelBase
{
	// Token: 0x0600B3BC RID: 46012 RVA: 0x00289E2E File Offset: 0x0028802E
	public CommonRewardPopup(UUIItem parentItem)
	{
		base.CreateByResourceIdAsync("UiItem_RewardPopup", parentItem, false);
	}

	// Token: 0x0600B3BD RID: 46013 RVA: 0x00289E50 File Offset: 0x00288050
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

	// Token: 0x0600B3BE RID: 46014 RVA: 0x00289EE3 File Offset: 0x002880E3
	protected override void OnBeforeCreateImplement()
	{
		this.Sequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.Sequence);
	}

	// Token: 0x0600B3BF RID: 46015 RVA: 0x00289F00 File Offset: 0x00288100
	protected override void OnStart()
	{
		this.RewardPanel = new GenericLayout<RewardPanelItem, DailyActivityDefine.RewardTuple>(base.GetHorizontalLayout(0), new Func<RewardPanelItem>(this.CreateRewardItem), null, false, true);
		this.SetActive(false);
		foreach (Action action in this.OperationMap.Values)
		{
			action();
		}
	}

	// Token: 0x0600B3C0 RID: 46016 RVA: 0x00289F80 File Offset: 0x00288180
	protected override UniTask OnShowAsyncImplementImplement()
	{
		CommonRewardPopup.<OnShowAsyncImplementImplement>d__9 <OnShowAsyncImplementImplement>d__;
		<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnShowAsyncImplementImplement>d__.<>4__this = this;
		<OnShowAsyncImplementImplement>d__.<>1__state = -1;
		<OnShowAsyncImplementImplement>d__.<>t__builder.Start<CommonRewardPopup.<OnShowAsyncImplementImplement>d__9>(ref <OnShowAsyncImplementImplement>d__);
		return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x0600B3C1 RID: 46017 RVA: 0x00289FC4 File Offset: 0x002881C4
	protected override UniTask OnHideAsyncImplementImplement()
	{
		CommonRewardPopup.<OnHideAsyncImplementImplement>d__10 <OnHideAsyncImplementImplement>d__;
		<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHideAsyncImplementImplement>d__.<>4__this = this;
		<OnHideAsyncImplementImplement>d__.<>1__state = -1;
		<OnHideAsyncImplementImplement>d__.<>t__builder.Start<CommonRewardPopup.<OnHideAsyncImplementImplement>d__10>(ref <OnHideAsyncImplementImplement>d__);
		return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x0600B3C2 RID: 46018 RVA: 0x0028A007 File Offset: 0x00288207
	protected override void OnBeforeDestroy()
	{
		this.RewardPanel.ClearChildren();
		this.RewardPanel = null;
		this.PopUpData = null;
		this.OperationMap.Clear();
	}

	// Token: 0x0600B3C3 RID: 46019 RVA: 0x0028A02D File Offset: 0x0028822D
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

	// Token: 0x0600B3C4 RID: 46020 RVA: 0x0028A061 File Offset: 0x00288261
	private RewardPanelItem CreateRewardItem()
	{
		return new RewardPanelItem();
	}

	// Token: 0x0600B3C5 RID: 46021 RVA: 0x0028A068 File Offset: 0x00288268
	private void OnMaskBtnClick()
	{
		this.SetActive(false);
	}

	// Token: 0x0600B3C6 RID: 46022 RVA: 0x0028A074 File Offset: 0x00288274
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

	// Token: 0x0400515E RID: 20830
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RewardPanelItem, DailyActivityDefine.RewardTuple> RewardPanel;

	// Token: 0x0400515F RID: 20831
	[Nullable(2)]
	private RewardPopupData PopUpData;

	// Token: 0x04005160 RID: 20832
	private readonly Dictionary<string, Action> OperationMap = new Dictionary<string, Action>();

	// Token: 0x04005161 RID: 20833
	[Nullable(2)]
	private UiBehaviorLevelSequence Sequence;

	// Token: 0x02007DF5 RID: 32245
	[NullableContext(0)]
	private enum EPopupComponent
	{
		// Token: 0x04029391 RID: 168849
		PanelLayout,
		// Token: 0x04029392 RID: 168850
		RewardItem,
		// Token: 0x04029393 RID: 168851
		Panel,
		// Token: 0x04029394 RID: 168852
		MaskBtn
	}
}
