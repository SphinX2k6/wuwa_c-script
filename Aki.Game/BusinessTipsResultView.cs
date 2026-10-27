using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200132E RID: 4910
[NullableContext(2)]
[Nullable(0)]
public class BusinessTipsResultView : UiViewBase
{
	// Token: 0x06008869 RID: 34921 RVA: 0x001D1F7B File Offset: 0x001D017B
	[NullableContext(1)]
	public BusinessTipsResultView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600886A RID: 34922 RVA: 0x001D1F84 File Offset: 0x001D0184
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(USpineSkeletonAnimationComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action(this.OnSkip))
		};
	}

	// Token: 0x0600886B RID: 34923 RVA: 0x001D2070 File Offset: 0x001D0270
	protected override UniTask OnBeforeStartAsync()
	{
		BusinessTipsResultView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BusinessTipsResultView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600886C RID: 34924 RVA: 0x001D20B3 File Offset: 0x001D02B3
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.BusinessInvestResult, new Action(this.BusinessInvestResult));
	}

	// Token: 0x0600886D RID: 34925 RVA: 0x001D20D1 File Offset: 0x001D02D1
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.BusinessInvestResult, new Action(this.BusinessInvestResult));
	}

	// Token: 0x0600886E RID: 34926 RVA: 0x001D20EF File Offset: 0x001D02EF
	protected override void OnBeforeDestroy()
	{
		this.RemoveTimerHandle();
	}

	// Token: 0x0600886F RID: 34927 RVA: 0x001D20F7 File Offset: 0x001D02F7
	private void OnSkip()
	{
		if (this.TimerHandleField == null)
		{
			return;
		}
		this.RemoveTimerHandle();
		this.ShowSettlement();
	}

	// Token: 0x06008870 RID: 34928 RVA: 0x001D2110 File Offset: 0x001D0310
	private void BusinessInvestResult()
	{
		BusinessTipsInvestModule investModule = this.InvestModule;
		if (investModule != null)
		{
			investModule.SetActive(false);
		}
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(6);
		if (item2 != null)
		{
			item2.SetUIActive(true);
		}
		this.SwitchRoleSpineAnim(ESpineAnimation.Success, 0.1f);
		AudioSystem.Instance.PostEvent("play_ui_zuiyuejie_loading");
		this.RefreshCurrencyItem();
		base.PlaySequenceAsync("Run", false, false, null).ContinueWith(delegate()
		{
			UUIButtonComponent button = base.GetButton(5);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(true);
			}
			this.AddTimerHandle();
		}).Forget();
	}

	// Token: 0x06008871 RID: 34929 RVA: 0x001D21A8 File Offset: 0x001D03A8
	private UniTask RefreshRoleTexture()
	{
		BusinessTipsResultView.<RefreshRoleTexture>d__14 <RefreshRoleTexture>d__;
		<RefreshRoleTexture>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRoleTexture>d__.<>4__this = this;
		<RefreshRoleTexture>d__.<>1__state = -1;
		<RefreshRoleTexture>d__.<>t__builder.Start<BusinessTipsResultView.<RefreshRoleTexture>d__14>(ref <RefreshRoleTexture>d__);
		return <RefreshRoleTexture>d__.<>t__builder.Task;
	}

	// Token: 0x06008872 RID: 34930 RVA: 0x001D21EC File Offset: 0x001D03EC
	private UniTask InitCurrencyItem()
	{
		BusinessTipsResultView.<InitCurrencyItem>d__15 <InitCurrencyItem>d__;
		<InitCurrencyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCurrencyItem>d__.<>4__this = this;
		<InitCurrencyItem>d__.<>1__state = -1;
		<InitCurrencyItem>d__.<>t__builder.Start<BusinessTipsResultView.<InitCurrencyItem>d__15>(ref <InitCurrencyItem>d__);
		return <InitCurrencyItem>d__.<>t__builder.Task;
	}

	// Token: 0x06008873 RID: 34931 RVA: 0x001D2230 File Offset: 0x001D0430
	private void InitDialogText()
	{
		DelegationResultData resultData = MoonChasingBusinessModel.Instance.GetResultData();
		EntrustRole entrustRoleById = BusinessConfig.Instance.GetEntrustRoleById(resultData.TriggerEventRoleId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), entrustRoleById.InvestDialog, Array.Empty<object>());
	}

	// Token: 0x06008874 RID: 34932 RVA: 0x001D2278 File Offset: 0x001D0478
	private UniTask InitInvestModule()
	{
		BusinessTipsResultView.<InitInvestModule>d__17 <InitInvestModule>d__;
		<InitInvestModule>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitInvestModule>d__.<>4__this = this;
		<InitInvestModule>d__.<>1__state = -1;
		<InitInvestModule>d__.<>t__builder.Start<BusinessTipsResultView.<InitInvestModule>d__17>(ref <InitInvestModule>d__);
		return <InitInvestModule>d__.<>t__builder.Task;
	}

	// Token: 0x06008875 RID: 34933 RVA: 0x001D22BC File Offset: 0x001D04BC
	private UniTask InitSettlementModule()
	{
		BusinessTipsResultView.<InitSettlementModule>d__18 <InitSettlementModule>d__;
		<InitSettlementModule>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitSettlementModule>d__.<>4__this = this;
		<InitSettlementModule>d__.<>1__state = -1;
		<InitSettlementModule>d__.<>t__builder.Start<BusinessTipsResultView.<InitSettlementModule>d__18>(ref <InitSettlementModule>d__);
		return <InitSettlementModule>d__.<>t__builder.Task;
	}

	// Token: 0x06008876 RID: 34934 RVA: 0x001D22FF File Offset: 0x001D04FF
	private void AddTimerHandle()
	{
		this.TimerHandleField = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			this.TimerHandleField = null;
			this.ShowSettlement();
		}, 2000f, null, null, true, 1f);
	}

	// Token: 0x06008877 RID: 34935 RVA: 0x001D232A File Offset: 0x001D052A
	private void RemoveTimerHandle()
	{
		if (this.TimerHandleField != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandleField);
			this.TimerHandleField = null;
		}
	}

	// Token: 0x06008878 RID: 34936 RVA: 0x001D234C File Offset: 0x001D054C
	private void ShowSettlement()
	{
		AudioSystem.Instance.ExecuteAction("play_ui_zuiyuejie_loading", EAudioActionType.Stop, null);
		DelegationResultData resultData = MoonChasingBusinessModel.Instance.GetResultData();
		EntrustRole entrustRoleById = BusinessConfig.Instance.GetEntrustRoleById(resultData.TriggerEventRoleId);
		string textStringId = resultData.IsInvestSuccess ? entrustRoleById.InvestSuccessDialog : entrustRoleById.InvestFailDialog;
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		UUIItem item2 = base.GetItem(6);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textStringId, Array.Empty<object>());
		ESpineAnimation animName = resultData.IsInvestSuccess ? ESpineAnimation.Success : ESpineAnimation.Fail;
		this.SwitchRoleSpineAnim(animName, 0.1f);
		BusinessTipsSettlementModule settlementModule = this.SettlementModule;
		if (settlementModule != null)
		{
			settlementModule.SetActive(true);
		}
		if (resultData.IsInvestSuccess)
		{
			base.PlaySequence("Success", delegate
			{
				BusinessTipsSettlementModule settlementModule2 = this.SettlementModule;
				if (settlementModule2 == null)
				{
					return;
				}
				settlementModule2.StartCharacterAnim();
			}, false);
			return;
		}
		base.PlaySequence("Fail", null, false);
	}

	// Token: 0x06008879 RID: 34937 RVA: 0x001D2446 File Offset: 0x001D0646
	private void SwitchRoleSpineAnim(ESpineAnimation animName, float mixDuration)
	{
		UTrackEntry utrackEntry = base.GetSpine(0).SetAnimation(0, animName.ToString(), true);
		if (utrackEntry == null)
		{
			return;
		}
		utrackEntry.SetMixDuration(mixDuration);
	}

	// Token: 0x0600887A RID: 34938 RVA: 0x001D2470 File Offset: 0x001D0670
	private void RefreshCurrencyItem()
	{
		DelegationResultData resultData = MoonChasingBusinessModel.Instance.GetResultData();
		int targetValue = resultData.OriginGold - resultData.CostGold;
		this.CurrencyItem.PlayReduceTweener(resultData.OriginGold, targetValue);
	}

	// Token: 0x04003CD2 RID: 15570
	protected BusinessTipsInvestModule InvestModule;

	// Token: 0x04003CD3 RID: 15571
	protected BusinessTipsSettlementModule SettlementModule;

	// Token: 0x04003CD4 RID: 15572
	protected TimerHandle TimerHandleField;

	// Token: 0x04003CD5 RID: 15573
	protected BusinessTipsCurrencyItem CurrencyItem;

	// Token: 0x04003CD6 RID: 15574
	private const int ANIM_TIME = 2000;

	// Token: 0x02007989 RID: 31113
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04028055 RID: 163925
		public const int RoleSpine = 0;

		// Token: 0x04028056 RID: 163926
		public const int DialogItem = 1;

		// Token: 0x04028057 RID: 163927
		public const int DialogText = 2;

		// Token: 0x04028058 RID: 163928
		public const int InvestItem = 3;

		// Token: 0x04028059 RID: 163929
		public const int ResultItem = 4;

		// Token: 0x0402805A RID: 163930
		public const int SkipBtn = 5;

		// Token: 0x0402805B RID: 163931
		public const int TitleItem = 6;

		// Token: 0x0402805C RID: 163932
		public const int CurrencyItem = 7;
	}
}
