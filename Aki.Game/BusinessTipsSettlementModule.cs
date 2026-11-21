using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020007E3 RID: 2019
[NullableContext(2)]
[Nullable(0)]
public class BusinessTipsSettlementModule : UiPanelBase
{
	// Token: 0x06005C19 RID: 23577 RVA: 0x001DB368 File Offset: 0x001D9568
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

	// Token: 0x06005C1A RID: 23578 RVA: 0x001DB3FC File Offset: 0x001D95FC
	private UniTask InitCharacterListModule()
	{
		BusinessTipsSettlementModule.<InitCharacterListModule>d__8 <InitCharacterListModule>d__;
		<InitCharacterListModule>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCharacterListModule>d__.<>4__this = this;
		<InitCharacterListModule>d__.<>1__state = -1;
		<InitCharacterListModule>d__.<>t__builder.Start<BusinessTipsSettlementModule.<InitCharacterListModule>d__8>(ref <InitCharacterListModule>d__);
		return <InitCharacterListModule>d__.<>t__builder.Task;
	}

	// Token: 0x06005C1B RID: 23579 RVA: 0x001DB440 File Offset: 0x001D9640
	protected override UniTask OnBeforeStartAsync()
	{
		BusinessTipsSettlementModule.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BusinessTipsSettlementModule.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005C1C RID: 23580 RVA: 0x001DB484 File Offset: 0x001D9684
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

	// Token: 0x06005C1D RID: 23581 RVA: 0x001DB51C File Offset: 0x001D971C
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

	// Token: 0x06005C1E RID: 23582 RVA: 0x001DB56F File Offset: 0x001D976F
	private void StopTween()
	{
		if (this.ExpTweener != null)
		{
			this.ExpTweener.Kill(false);
			this.ExpTweener = null;
		}
	}

	// Token: 0x06005C1F RID: 23583 RVA: 0x001DB58C File Offset: 0x001D978C
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

	// Token: 0x06005C20 RID: 23584 RVA: 0x001DB64C File Offset: 0x001D984C
	private void PlayCharacterEndAction()
	{
		foreach (CharacterItemWithAdd characterItemWithAdd in this.CharacterListModule.GetItemList())
		{
			characterItemWithAdd.PlayEndAction();
		}
	}

	// Token: 0x06005C21 RID: 23585 RVA: 0x001DB6A4 File Offset: 0x001D98A4
	private void PlayCurrentValueTween()
	{
		this.ExpTweener = ULTweenBPLibrary.FloatTo(GlobalData.World, this.ValueDelegate, 0f, 1f, 0.5f, 0f, LTweenEase.OutCubic);
	}

	// Token: 0x06005C22 RID: 23586 RVA: 0x001DB6D1 File Offset: 0x001D98D1
	private void OnConfirm()
	{
		MoonChasingController.Instance.OpenTipsFinishView();
	}

	// Token: 0x06005C23 RID: 23587 RVA: 0x001DB6DD File Offset: 0x001D98DD
	[NullableContext(1)]
	private CharacterItemWithAdd InitCharacterItemWithAdd()
	{
		return new CharacterItemWithAdd();
	}

	// Token: 0x06005C24 RID: 23588 RVA: 0x001DB6E4 File Offset: 0x001D98E4
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

	// Token: 0x06005C25 RID: 23589 RVA: 0x001DB754 File Offset: 0x001D9954
	private void PlayCurrentValue(float value)
	{
		foreach (CharacterItemWithAdd characterItemWithAdd in this.CharacterListModule.GetItemList())
		{
			characterItemWithAdd.RefreshCurrentValue(value);
		}
	}

	// Token: 0x06005C26 RID: 23590 RVA: 0x001DB7AC File Offset: 0x001D99AC
	private void OnComplete()
	{
		this.PlayCharacterEndAction();
		this.PlayCurrentValueTween();
	}

	// Token: 0x06005C27 RID: 23591 RVA: 0x001DB7BA File Offset: 0x001D99BA
	public void StartCharacterAnim()
	{
		MoonChasingBusinessModel.Instance.GetResultData().UseInvestProperData();
		this.PlayCharacterRunFinishAction();
	}

	// Token: 0x04003D6F RID: 15727
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected CharacterListModule<CharacterItemWithAdd> CharacterListModule;

	// Token: 0x04003D70 RID: 15728
	protected ULTweener ExpTweener;

	// Token: 0x04003D71 RID: 15729
	protected FLTweenFloatSetterDynamic Delegate;

	// Token: 0x04003D72 RID: 15730
	protected FLTweenFloatSetterDynamic ValueDelegate;

	// Token: 0x04003D73 RID: 15731
	private const float TWEEN_TIME = 1f;

	// Token: 0x04003D74 RID: 15732
	private const float VALUE_TIME = 0.5f;

	// Token: 0x02006B19 RID: 27417
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402339E RID: 144286
		public const int Title = 0;

		// Token: 0x0402339F RID: 144287
		public const int ReturnRatio = 1;

		// Token: 0x040233A0 RID: 144288
		public const int ConfirmBtn = 2;

		// Token: 0x040233A1 RID: 144289
		public const int CharacterListItem = 3;
	}
}
