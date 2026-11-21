using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020022B0 RID: 8880
public class WeeklyRogueSelectArtifactView : UiViewBase
{
	// Token: 0x06015EDB RID: 89819 RVA: 0x0065BE4E File Offset: 0x0065A04E
	[NullableContext(1)]
	public WeeklyRogueSelectArtifactView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06015EDC RID: 89820 RVA: 0x0065BE58 File Offset: 0x0065A058
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnBtnConfirm))
		};
	}

	// Token: 0x06015EDD RID: 89821 RVA: 0x0065BEEC File Offset: 0x0065A0EC
	protected override UniTask OnBeforeStartAsync()
	{
		WeeklyRogueSelectArtifactView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeeklyRogueSelectArtifactView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015EDE RID: 89822 RVA: 0x0065BF2F File Offset: 0x0065A12F
	protected override void OnBeforeShow()
	{
		this.TokenLayout.PlayGridAnim();
	}

	// Token: 0x06015EDF RID: 89823 RVA: 0x0065BF3C File Offset: 0x0065A13C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.WeeklyRogueCycleRefresh, new Action(this.OnCycleRefresh));
	}

	// Token: 0x06015EE0 RID: 89824 RVA: 0x0065BF5A File Offset: 0x0065A15A
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.WeeklyRogueCycleRefresh, new Action(this.OnCycleRefresh));
	}

	// Token: 0x06015EE1 RID: 89825 RVA: 0x0065BF78 File Offset: 0x0065A178
	private void OnCycleRefresh()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.WeeklyRogueCycleRefresh);
		confirmBoxDataNew.FunctionMap.Add(1, new Action(WeeklyRogueSelectArtifactView.<OnCycleRefresh>g__ConfirmCallback|9_0));
		confirmBoxDataNew.FunctionMap.Add(0, new Action(WeeklyRogueSelectArtifactView.<OnCycleRefresh>g__ConfirmCallback|9_0));
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06015EE2 RID: 89826 RVA: 0x0065BFCC File Offset: 0x0065A1CC
	[NullableContext(1)]
	private WeeklyRogueArtifactItem CreateTokenItem()
	{
		return new WeeklyRogueArtifactItem
		{
			OnSelectedChange = new Action<int?>(this.OnSelectChange)
		};
	}

	// Token: 0x06015EE3 RID: 89827 RVA: 0x0065BFE8 File Offset: 0x0065A1E8
	private void OnSelectChange(int? selectIndex)
	{
		if (selectIndex == null)
		{
			GenericLayout<WeeklyRogueArtifactItem, RogueWeeklyEntry> tokenLayout = this.TokenLayout;
			if (tokenLayout != null)
			{
				tokenLayout.DeselectCurrentGridProxy();
			}
			base.GetButton(3).SetSelfInteractive(false);
			return;
		}
		GenericLayout<WeeklyRogueArtifactItem, RogueWeeklyEntry> tokenLayout2 = this.TokenLayout;
		if (tokenLayout2 != null)
		{
			tokenLayout2.SelectGridProxy(selectIndex.Value, false);
		}
		base.GetButton(3).SetSelfInteractive(true);
	}

	// Token: 0x06015EE4 RID: 89828 RVA: 0x0065C044 File Offset: 0x0065A244
	private void OnBtnConfirm()
	{
		UiLayer.Instance.SetShowMaskLayer("WeeklyRogueSelectArtifactView.SelectArtifactRequest", true);
		WeeklyRogueController.Instance.SelectArtifactRequest().ContinueWith(delegate(bool success)
		{
			if (success)
			{
				List<int> selectRoleIdList = WeeklyRogueModel.Instance.SelectRoleIdList;
				WeeklyRogueController.Instance.RogueWeeklyStartRequest(selectRoleIdList);
			}
			UiLayer.Instance.SetShowMaskLayer("WeeklyRogueSelectArtifactView.SelectArtifactRequest", false);
		});
	}

	// Token: 0x06015EE5 RID: 89829 RVA: 0x0065C090 File Offset: 0x0065A290
	private void OnBtnBack()
	{
		base.CloseMe(null);
	}

	// Token: 0x06015EE6 RID: 89830 RVA: 0x0065C099 File Offset: 0x0065A299
	[CompilerGenerated]
	internal static void <OnCycleRefresh>g__ConfirmCallback|9_0()
	{
		UiManager.Instance.ResetToBattleView(null);
	}

	// Token: 0x0400B869 RID: 47209
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WeeklyRogueArtifactItem, RogueWeeklyEntry> TokenLayout;

	// Token: 0x0400B86A RID: 47210
	[Nullable(2)]
	private WeeklyRogueCaptionItem CaptionItem;

	// Token: 0x02008516 RID: 34070
	private enum EWeeklyRogueSelectTokenDefine
	{
		// Token: 0x0402AE67 RID: 175719
		CaptionItem,
		// Token: 0x0402AE68 RID: 175720
		ArtifactLayout,
		// Token: 0x0402AE69 RID: 175721
		ArtifactItem,
		// Token: 0x0402AE6A RID: 175722
		BtnConfirm
	}
}
