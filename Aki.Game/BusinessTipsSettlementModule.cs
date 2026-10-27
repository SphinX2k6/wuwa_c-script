using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200132F RID: 4911
[NullableContext(2)]
[Nullable(0)]
public class BusinessTipsSettlementModule : UiPanelBase
{
	// Token: 0x0600887E RID: 34942 RVA: 0x001D24FC File Offset: 0x001D06FC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnConfirm))
		};
	}

	// Token: 0x0600887F RID: 34943 RVA: 0x001D2590 File Offset: 0x001D0790
	private UniTask InitCharacterListModule()
	{
		BusinessTipsSettlementModule.<InitCharacterListModule>d__8 <InitCharacterListModule>d__;
		<InitCharacterListModule>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCharacterListModule>d__.<>4__this = this;
		<InitCharacterListModule>d__.<>1__state = -1;
		<InitCharacterListModule>d__.<>t__builder.Start<BusinessTipsSettlementModule.<InitCharacterListModule>d__8>(ref <InitCharacterListModule>d__);
		return <InitCharacterListModule>d__.<>t__builder.Task;
	}

	// Token: 0x06008880 RID: 34944 RVA: 0x001D25D4 File Offset: 0x001D07D4
	protected override UniTask OnBeforeStartAsync()
	{
		BusinessTipsSettlementModule.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BusinessTipsSettlementModule.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008881 RID: 34945 RVA: 0x001D2618 File Offset: 0x001D0818
	protected override void OnBeforeShow()
	{
		DelegationResultData resultData = MoonChasingBusinessModel.Instance.GetResultData();
		if (resultData.IsInvestSuccess)
		{
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetText(resultData.Ratio.ToString() + "%", true);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Moonfiesta_EventSuccess", Array.Empty<object>());
			return;
		}
		UUIText text2 = base.GetText(1);
		if (text2 != null)
		{
			text2.SetText("100%", true);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Moonfiesta_EventFail", Array.Empty<object>());
	}

	// Token: 0x06008882 RID: 34946 RVA: 0x001D26B0 File Offset: 0x001D08B0
	protected override void OnBeforeDestroy()
	{
		if (this.Delegate != null)
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.PlayFillAmount));
			this.Delegate = null;
		}
		if (this.ValueDelegate != null)
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.PlayCurrentValue));
			this.ValueDelegate = null;
		}
		this.StopTween();
	}

	// Token: 0x06008883 RID: 34947 RVA: 0x001D2703 File Offset: 0x001D0903
	private void StopTween()
	{
		if (this.ExpTweener != null)
		{
			this.ExpTweener.Kill(false);
			this.ExpTweener = null;
		}
	}

	// Token: 0x06008884 RID: 34948 RVA: 0x001D2720 File Offset: 0x001D0920
	private void PlayCharacterRunFinishAction()
	{
		foreach (CharacterItemWithAdd characterItemWithAdd in this.CharacterListModule.GetItemList())
		{
			characterItemWithAdd.SetLightProgressWidth();
			characterItemWithAdd.PlayAddAction();
			characterItemWithAdd.RefreshAddText();
		}
		this.ExpTweener = ULTweenBPLibrary.FloatTo(GlobalData.World, this.Delegate, 0f, 1f, 1f, 0f, LTweenEase.OutCubic);
		ULTweener expTweener = this.ExpTweener;
		if (expTweener != null)
		{
			expTweener.OnCompleteCallBack.Bind(new Action(this.OnComplete));
		}
		AudioSystem.Instance.PostEvent("play_ui_figure_up_1s");
	}

	// Token: 0x06008885 RID: 34949 RVA: 0x001D27E0 File Offset: 0x001D09E0
	private void PlayCharacterEndAction()
	{
		foreach (CharacterItemWithAdd characterItemWithAdd in this.CharacterListModule.GetItemList())
		{
			characterItemWithAdd.PlayEndAction();
		}
	}

	// Token: 0x06008886 RID: 34950 RVA: 0x001D2838 File Offset: 0x001D0A38
	private void PlayCurrentValueTween()
	{
		this.ExpTweener = ULTweenBPLibrary.FloatTo(GlobalData.World, this.ValueDelegate, 0f, 1f, 0.5f, 0f, LTweenEase.OutCubic);
	}

	// Token: 0x06008887 RID: 34951 RVA: 0x001D2865 File Offset: 0x001D0A65
	private void OnConfirm()
	{
		MoonChasingController.Instance.OpenTipsFinishView();
	}

	// Token: 0x06008888 RID: 34952 RVA: 0x001D2871 File Offset: 0x001D0A71
	[NullableContext(1)]
	private CharacterItemWithAdd InitCharacterItemWithAdd()
	{
		return new CharacterItemWithAdd();
	}

	// Token: 0x06008889 RID: 34953 RVA: 0x001D2878 File Offset: 0x001D0A78
	private void PlayFillAmount(float value)
	{
		foreach (CharacterItemWithAdd characterItemWithAdd in this.CharacterListModule.GetItemList())
		{
			characterItemWithAdd.RefreshProgressAdd(value);
			if (value == 1f)
			{
				characterItemWithAdd.RefreshProgress(value);
				characterItemWithAdd.SetLightProgressWidth();
			}
		}
	}

	// Token: 0x0600888A RID: 34954 RVA: 0x001D28E8 File Offset: 0x001D0AE8
	private void PlayCurrentValue(float value)
	{
		foreach (CharacterItemWithAdd characterItemWithAdd in this.CharacterListModule.GetItemList())
		{
			characterItemWithAdd.RefreshCurrentValue(value);
		}
	}

	// Token: 0x0600888B RID: 34955 RVA: 0x001D2940 File Offset: 0x001D0B40
	private void OnComplete()
	{
		this.PlayCharacterEndAction();
		this.PlayCurrentValueTween();
	}

	// Token: 0x0600888C RID: 34956 RVA: 0x001D294E File Offset: 0x001D0B4E
	public void StartCharacterAnim()
	{
		MoonChasingBusinessModel.Instance.GetResultData().UseInvestProperData();
		this.PlayCharacterRunFinishAction();
	}

	// Token: 0x04003CD7 RID: 15575
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected CharacterListModule<CharacterItemWithAdd> CharacterListModule;

	// Token: 0x04003CD8 RID: 15576
	protected ULTweener ExpTweener;

	// Token: 0x04003CD9 RID: 15577
	protected FLTweenFloatSetterDynamic Delegate;

	// Token: 0x04003CDA RID: 15578
	protected FLTweenFloatSetterDynamic ValueDelegate;

	// Token: 0x04003CDB RID: 15579
	private const float TWEEN_TIME = 1f;

	// Token: 0x04003CDC RID: 15580
	private const float VALUE_TIME = 0.5f;

	// Token: 0x0200798F RID: 31119
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04028071 RID: 163953
		public const int Title = 0;

		// Token: 0x04028072 RID: 163954
		public const int ReturnRatio = 1;

		// Token: 0x04028073 RID: 163955
		public const int ConfirmBtn = 2;

		// Token: 0x04028074 RID: 163956
		public const int CharacterListItem = 3;
	}
}
