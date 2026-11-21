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

// Token: 0x020007E2 RID: 2018
[NullableContext(2)]
[Nullable(0)]
public class BusinessTipsResultView : UiViewBase
{
	// Token: 0x06005C04 RID: 23556 RVA: 0x001DADE7 File Offset: 0x001D8FE7
	[NullableContext(1)]
	public BusinessTipsResultView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06005C05 RID: 23557 RVA: 0x001DADF0 File Offset: 0x001D8FF0
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

	// Token: 0x06005C06 RID: 23558 RVA: 0x001DAEDC File Offset: 0x001D90DC
	protected override UniTask OnBeforeStartAsync()
	{
		BusinessTipsResultView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BusinessTipsResultView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005C07 RID: 23559 RVA: 0x001DAF1F File Offset: 0x001D911F
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.BusinessInvestResult, new Action(this.BusinessInvestResult));
	}

	// Token: 0x06005C08 RID: 23560 RVA: 0x001DAF3D File Offset: 0x001D913D
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.BusinessInvestResult, new Action(this.BusinessInvestResult));
	}

	// Token: 0x06005C09 RID: 23561 RVA: 0x001DAF5B File Offset: 0x001D915B
	protected override void OnBeforeDestroy()
	{
		this.RemoveTimerHandle();
	}

	// Token: 0x06005C0A RID: 23562 RVA: 0x001DAF63 File Offset: 0x001D9163
	private void OnSkip()
	{
		if (this.TimerHandleField == null)
		{
			return;
		}
		this.RemoveTimerHandle();
		this.ShowSettlement();
	}

	// Token: 0x06005C0B RID: 23563 RVA: 0x001DAF7C File Offset: 0x001D917C
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

	// Token: 0x06005C0C RID: 23564 RVA: 0x001DB014 File Offset: 0x001D9214
	private UniTask RefreshRoleTexture()
	{
		BusinessTipsResultView.<RefreshRoleTexture>d__14 <RefreshRoleTexture>d__;
		<RefreshRoleTexture>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRoleTexture>d__.<>4__this = this;
		<RefreshRoleTexture>d__.<>1__state = -1;
		<RefreshRoleTexture>d__.<>t__builder.Start<BusinessTipsResultView.<RefreshRoleTexture>d__14>(ref <RefreshRoleTexture>d__);
		return <RefreshRoleTexture>d__.<>t__builder.Task;
	}

	// Token: 0x06005C0D RID: 23565 RVA: 0x001DB058 File Offset: 0x001D9258
	private UniTask InitCurrencyItem()
	{
		BusinessTipsResultView.<InitCurrencyItem>d__15 <InitCurrencyItem>d__;
		<InitCurrencyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCurrencyItem>d__.<>4__this = this;
		<InitCurrencyItem>d__.<>1__state = -1;
		<InitCurrencyItem>d__.<>t__builder.Start<BusinessTipsResultView.<InitCurrencyItem>d__15>(ref <InitCurrencyItem>d__);
		return <InitCurrencyItem>d__.<>t__builder.Task;
	}

	// Token: 0x06005C0E RID: 23566 RVA: 0x001DB09C File Offset: 0x001D929C
	private void InitDialogText()
	{
		DelegationResultData resultData = MoonChasingBusinessModel.Instance.GetResultData();
		EntrustRole entrustRoleById = BusinessConfig.Instance.GetEntrustRoleById(resultData.TriggerEventRoleId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), entrustRoleById.InvestDialog, Array.Empty<object>());
	}

	// Token: 0x06005C0F RID: 23567 RVA: 0x001DB0E4 File Offset: 0x001D92E4
	private UniTask InitInvestModule()
	{
		BusinessTipsResultView.<InitInvestModule>d__17 <InitInvestModule>d__;
		<InitInvestModule>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitInvestModule>d__.<>4__this = this;
		<InitInvestModule>d__.<>1__state = -1;
		<InitInvestModule>d__.<>t__builder.Start<BusinessTipsResultView.<InitInvestModule>d__17>(ref <InitInvestModule>d__);
		return <InitInvestModule>d__.<>t__builder.Task;
	}

	// Token: 0x06005C10 RID: 23568 RVA: 0x001DB128 File Offset: 0x001D9328
	private UniTask InitSettlementModule()
	{
		BusinessTipsResultView.<InitSettlementModule>d__18 <InitSettlementModule>d__;
		<InitSettlementModule>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitSettlementModule>d__.<>4__this = this;
		<InitSettlementModule>d__.<>1__state = -1;
		<InitSettlementModule>d__.<>t__builder.Start<BusinessTipsResultView.<InitSettlementModule>d__18>(ref <InitSettlementModule>d__);
		return <InitSettlementModule>d__.<>t__builder.Task;
	}

	// Token: 0x06005C11 RID: 23569 RVA: 0x001DB16B File Offset: 0x001D936B
	private void AddTimerHandle()
	{
		this.TimerHandleField = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			this.TimerHandleField = null;
			this.ShowSettlement();
		}, 2000f, null, null, true, 1f);
	}

	// Token: 0x06005C12 RID: 23570 RVA: 0x001DB196 File Offset: 0x001D9396
	private void RemoveTimerHandle()
	{
		if (this.TimerHandleField != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandleField);
			this.TimerHandleField = null;
		}
	}

	// Token: 0x06005C13 RID: 23571 RVA: 0x001DB1B8 File Offset: 0x001D93B8
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

	// Token: 0x06005C14 RID: 23572 RVA: 0x001DB2B2 File Offset: 0x001D94B2
	private void SwitchRoleSpineAnim(ESpineAnimation animName, float mixDuration)
	{
		UTrackEntry utrackEntry = base.GetSpine(0).SetAnimation(0, animName.ToString(), true);
		if (utrackEntry == null)
		{
			return;
		}
		utrackEntry.SetMixDuration(mixDuration);
	}

	// Token: 0x06005C15 RID: 23573 RVA: 0x001DB2DC File Offset: 0x001D94DC
	private void RefreshCurrencyItem()
	{
		DelegationResultData resultData = MoonChasingBusinessModel.Instance.GetResultData();
		int targetValue = resultData.OriginGold - resultData.CostGold;
		this.CurrencyItem.PlayReduceTweener(resultData.OriginGold, targetValue);
	}

	// Token: 0x04003D6A RID: 15722
	protected BusinessTipsInvestModule InvestModule;

	// Token: 0x04003D6B RID: 15723
	protected BusinessTipsSettlementModule SettlementModule;

	// Token: 0x04003D6C RID: 15724
	protected TimerHandle TimerHandleField;

	// Token: 0x04003D6D RID: 15725
	protected BusinessTipsCurrencyItem CurrencyItem;

	// Token: 0x04003D6E RID: 15726
	private const int ANIM_TIME = 2000;

	// Token: 0x02006B13 RID: 27411
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04023382 RID: 144258
		public const int RoleSpine = 0;

		// Token: 0x04023383 RID: 144259
		public const int DialogItem = 1;

		// Token: 0x04023384 RID: 144260
		public const int DialogText = 2;

		// Token: 0x04023385 RID: 144261
		public const int InvestItem = 3;

		// Token: 0x04023386 RID: 144262
		public const int ResultItem = 4;

		// Token: 0x04023387 RID: 144263
		public const int SkipBtn = 5;

		// Token: 0x04023388 RID: 144264
		public const int TitleItem = 6;

		// Token: 0x04023389 RID: 144265
		public const int CurrencyItem = 7;
	}
}
