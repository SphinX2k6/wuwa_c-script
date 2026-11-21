using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020007E5 RID: 2021
[NullableContext(2)]
[Nullable(0)]
public class BusinessTipsTravelView : UiViewBase
{
	// Token: 0x06005C42 RID: 23618 RVA: 0x001DC0A7 File Offset: 0x001DA2A7
	[NullableContext(1)]
	public BusinessTipsTravelView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06005C43 RID: 23619 RVA: 0x001DC0D0 File Offset: 0x001DA2D0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUILayoutBase)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnSkip))
		};
	}

	// Token: 0x06005C44 RID: 23620 RVA: 0x001DC17C File Offset: 0x001DA37C
	private UniTask InitCharacterListModule()
	{
		BusinessTipsTravelView.<InitCharacterListModule>d__24 <InitCharacterListModule>d__;
		<InitCharacterListModule>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCharacterListModule>d__.<>4__this = this;
		<InitCharacterListModule>d__.<>1__state = -1;
		<InitCharacterListModule>d__.<>t__builder.Start<BusinessTipsTravelView.<InitCharacterListModule>d__24>(ref <InitCharacterListModule>d__);
		return <InitCharacterListModule>d__.<>t__builder.Task;
	}

	// Token: 0x06005C45 RID: 23621 RVA: 0x001DC1C0 File Offset: 0x001DA3C0
	private UniTask InitRoleItemList()
	{
		BusinessTipsTravelView.<InitRoleItemList>d__25 <InitRoleItemList>d__;
		<InitRoleItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRoleItemList>d__.<>4__this = this;
		<InitRoleItemList>d__.<>1__state = -1;
		<InitRoleItemList>d__.<>t__builder.Start<BusinessTipsTravelView.<InitRoleItemList>d__25>(ref <InitRoleItemList>d__);
		return <InitRoleItemList>d__.<>t__builder.Task;
	}

	// Token: 0x06005C46 RID: 23622 RVA: 0x001DC204 File Offset: 0x001DA404
	private UniTask InitRoleList()
	{
		BusinessTipsTravelView.<InitRoleList>d__26 <InitRoleList>d__;
		<InitRoleList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRoleList>d__.<>4__this = this;
		<InitRoleList>d__.<>1__state = -1;
		<InitRoleList>d__.<>t__builder.Start<BusinessTipsTravelView.<InitRoleList>d__26>(ref <InitRoleList>d__);
		return <InitRoleList>d__.<>t__builder.Task;
	}

	// Token: 0x06005C47 RID: 23623 RVA: 0x001DC248 File Offset: 0x001DA448
	protected override UniTask OnBeforeStartAsync()
	{
		BusinessTipsTravelView.<OnBeforeStartAsync>d__27 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BusinessTipsTravelView.<OnBeforeStartAsync>d__27>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005C48 RID: 23624 RVA: 0x001DC28C File Offset: 0x001DA48C
	protected override UniTask OnBeforeShowAsyncImplementImplement()
	{
		BusinessTipsTravelView.<OnBeforeShowAsyncImplementImplement>d__28 <OnBeforeShowAsyncImplementImplement>d__;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<BusinessTipsTravelView.<OnBeforeShowAsyncImplementImplement>d__28>(ref <OnBeforeShowAsyncImplementImplement>d__);
		return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06005C49 RID: 23625 RVA: 0x001DC2CF File Offset: 0x001DA4CF
	protected override void OnAfterPlayStartSequence()
	{
		this.ShowAddCharacter();
	}

	// Token: 0x06005C4A RID: 23626 RVA: 0x001DC2D8 File Offset: 0x001DA4D8
	protected override void OnBeforeDestroy()
	{
		this.RemoveTimerHandle();
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
		this.RemoveSkipAnimDelayTimerHandle();
		this.RemoveRunTimerHandle();
		this.RemoveSkipResultTimeHandle();
	}

	// Token: 0x06005C4B RID: 23627 RVA: 0x001DC348 File Offset: 0x001DA548
	protected void ShowAddCharacter()
	{
		if (this.IsFinishShowLastRole())
		{
			return;
		}
		this.ShowIndex++;
		DelegationResultData resultData = MoonChasingBusinessModel.Instance.GetResultData();
		this.RoleIdList = resultData.GetRoleIdList();
		int roleId = this.RoleIdList[this.ShowIndex];
		IRoleResultData roleResultDataById = resultData.GetRoleResultDataById(roleId);
		for (int i = 0; i < 3; i++)
		{
			int currentValue = this.CharacterList[i].CurrentValue + roleResultDataById.CharacterValueList[i];
			this.CharacterList[i].SetCurrentValue(currentValue);
		}
		this.PlayStartAction();
		this.PlayCharacterStartAction();
		this.AddSkipAnimDelayTimerHandle();
		this.AddRunTimerHandle();
	}

	// Token: 0x06005C4C RID: 23628 RVA: 0x001DC3F4 File Offset: 0x001DA5F4
	[NullableContext(1)]
	private CharacterItemWithAdd InitCharacterItemWithAdd()
	{
		return new CharacterItemWithAdd();
	}

	// Token: 0x06005C4D RID: 23629 RVA: 0x001DC3FB File Offset: 0x001DA5FB
	[NullableContext(1)]
	private BusinessTravelRoleItem InitRoleItem()
	{
		return new BusinessTravelRoleItem();
	}

	// Token: 0x06005C4E RID: 23630 RVA: 0x001DC404 File Offset: 0x001DA604
	private UniTask OnPreparingFestival()
	{
		BusinessTipsTravelView.<OnPreparingFestival>d__34 <OnPreparingFestival>d__;
		<OnPreparingFestival>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPreparingFestival>d__.<>4__this = this;
		<OnPreparingFestival>d__.<>1__state = -1;
		<OnPreparingFestival>d__.<>t__builder.Start<BusinessTipsTravelView.<OnPreparingFestival>d__34>(ref <OnPreparingFestival>d__);
		return <OnPreparingFestival>d__.<>t__builder.Task;
	}

	// Token: 0x06005C4F RID: 23631 RVA: 0x001DC448 File Offset: 0x001DA648
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

	// Token: 0x06005C50 RID: 23632 RVA: 0x001DC4B8 File Offset: 0x001DA6B8
	private void PlayCurrentValue(float value)
	{
		foreach (CharacterItemWithAdd characterItemWithAdd in this.CharacterListModule.GetItemList())
		{
			characterItemWithAdd.RefreshCurrentValue(value);
		}
	}

	// Token: 0x06005C51 RID: 23633 RVA: 0x001DC510 File Offset: 0x001DA710
	private void StopTween()
	{
		if (this.ExpTweener != null)
		{
			this.ExpTweener.Kill(false);
			this.ExpTweener = null;
		}
	}

	// Token: 0x06005C52 RID: 23634 RVA: 0x001DC52D File Offset: 0x001DA72D
	private void PlayStartAction()
	{
		BusinessTravelRoleItem layoutItemByKey = this.RoleLayout.GetLayoutItemByKey(this.ShowIndex);
		if (layoutItemByKey == null)
		{
			return;
		}
		layoutItemByKey.PlayStartAction();
	}

	// Token: 0x06005C53 RID: 23635 RVA: 0x001DC550 File Offset: 0x001DA750
	private void PlayCharacterStartAction()
	{
		foreach (CharacterItemWithAdd characterItemWithAdd in this.CharacterListModule.GetItemList())
		{
			characterItemWithAdd.PlayStartAction();
		}
	}

	// Token: 0x06005C54 RID: 23636 RVA: 0x001DC5A8 File Offset: 0x001DA7A8
	private void PlayRunFinishAction()
	{
		BusinessTravelRoleItem layoutItemByKey = this.RoleLayout.GetLayoutItemByKey(this.ShowIndex);
		DelegationResultData resultData = MoonChasingBusinessModel.Instance.GetResultData();
		int roleId = layoutItemByKey.GetRoleId();
		IRoleResultData roleResultDataById = resultData.GetRoleResultDataById(roleId);
		List<int> lastLevelList = ((IBusinessTipsTravelData)this.OpenParam).LastLevelList;
		if (layoutItemByKey != null)
		{
			layoutItemByKey.PlayRunFinishAction(roleResultDataById.SuccessResult, lastLevelList[this.ShowIndex]);
		}
		this.AddSkipResultTimeHandle();
	}

	// Token: 0x06005C55 RID: 23637 RVA: 0x001DC616 File Offset: 0x001DA816
	private void PlayStopRunAction()
	{
		BusinessTravelRoleItem layoutItemByKey = this.RoleLayout.GetLayoutItemByKey(this.ShowIndex);
		if (layoutItemByKey == null)
		{
			return;
		}
		layoutItemByKey.StopRunToLastFrame();
	}

	// Token: 0x06005C56 RID: 23638 RVA: 0x001DC638 File Offset: 0x001DA838
	private void PlayCharacterRunFinishAction()
	{
		foreach (CharacterItemWithAdd characterItemWithAdd in this.CharacterListModule.GetItemList())
		{
			characterItemWithAdd.PlayAddAction();
			characterItemWithAdd.RefreshAddText();
		}
	}

	// Token: 0x06005C57 RID: 23639 RVA: 0x001DC694 File Offset: 0x001DA894
	private void PlayEndAction()
	{
		this.IsInResult = false;
		BusinessTravelRoleItem layoutItemByKey = this.RoleLayout.GetLayoutItemByKey(this.ShowIndex);
		if (layoutItemByKey == null)
		{
			return;
		}
		layoutItemByKey.PlayEndAction();
	}

	// Token: 0x06005C58 RID: 23640 RVA: 0x001DC6C0 File Offset: 0x001DA8C0
	private void PlayCharacterEndAction()
	{
		foreach (CharacterItemWithAdd characterItemWithAdd in this.CharacterListModule.GetItemList())
		{
			characterItemWithAdd.PlayEndAction();
		}
	}

	// Token: 0x06005C59 RID: 23641 RVA: 0x001DC718 File Offset: 0x001DA918
	private bool IsFinishShowLastRole()
	{
		List<int> roleIdList = MoonChasingBusinessModel.Instance.GetResultData().GetRoleIdList();
		return this.ShowIndex >= roleIdList.Count - 1;
	}

	// Token: 0x06005C5A RID: 23642 RVA: 0x001DC748 File Offset: 0x001DA948
	private void SkipToNextStep()
	{
		UUIButtonComponent button = base.GetButton(2);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(false);
		}
		MoonChasingBusinessModel.Instance.GetResultData().SetResultCharacterList(this.CharacterList);
		MoonChasingController.Instance.TipsTravelSkipToNextStep();
	}

	// Token: 0x06005C5B RID: 23643 RVA: 0x001DC794 File Offset: 0x001DA994
	private void AddSkipAnimDelayTimerHandle()
	{
		UUIButtonComponent button = base.GetButton(2);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(false);
		}
		int skipAnimDelayTime = BusinessConfig.Instance.GetSkipAnimDelayTime();
		this.SkipAnimDelayTimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			UUIButtonComponent button2 = base.GetButton(2);
			if (button2 != null)
			{
				button2.RootUIComp.Get().SetUIActive(true);
			}
			this.SkipAnimDelayTimerHandle = null;
		}, (float)skipAnimDelayTime, null, null, true, 1f);
	}

	// Token: 0x06005C5C RID: 23644 RVA: 0x001DC7F2 File Offset: 0x001DA9F2
	private void RemoveSkipAnimDelayTimerHandle()
	{
		if (this.SkipAnimDelayTimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.SkipAnimDelayTimerHandle);
			this.SkipAnimDelayTimerHandle = null;
		}
	}

	// Token: 0x06005C5D RID: 23645 RVA: 0x001DC814 File Offset: 0x001DAA14
	private void AddRunTimerHandle()
	{
		this.RunTimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			this.RunFinishCallback();
		}, 2000f, null, null, true, 1f);
	}

	// Token: 0x06005C5E RID: 23646 RVA: 0x001DC83F File Offset: 0x001DAA3F
	private bool RemoveRunTimerHandle()
	{
		if (this.RunTimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.RunTimerHandle);
			this.RunTimerHandle = null;
			return true;
		}
		return false;
	}

	// Token: 0x06005C5F RID: 23647 RVA: 0x001DC864 File Offset: 0x001DAA64
	private void AddSkipResultTimeHandle()
	{
		this.SkipResultTimeHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			this.RemoveSkipResultTimeHandle();
			this.IsInResult = true;
		}, 800f, null, null, true, 1f);
	}

	// Token: 0x06005C60 RID: 23648 RVA: 0x001DC88F File Offset: 0x001DAA8F
	private bool RemoveSkipResultTimeHandle()
	{
		if (this.SkipResultTimeHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.SkipResultTimeHandle);
			this.SkipResultTimeHandle = null;
			return true;
		}
		return false;
	}

	// Token: 0x06005C61 RID: 23649 RVA: 0x001DC8B4 File Offset: 0x001DAAB4
	private void RunFinishCallback()
	{
		this.RunTimerHandle = null;
		this.PlayRunFinishAction();
		this.PlayCharacterRunFinishAction();
		this.ExpTweener = ULTweenBPLibrary.FloatTo(GlobalData.World, this.Delegate, 0f, 1f, 1f, 0f, LTweenEase.OutCubic);
		ULTweener expTweener = this.ExpTweener;
		if (expTweener != null)
		{
			expTweener.OnCompleteCallBack.Bind(new Action(this.OnCompleteDelegate));
		}
		AudioSystem.Instance.PostEvent("play_ui_figure_up_1s");
	}

	// Token: 0x06005C62 RID: 23650 RVA: 0x001DC931 File Offset: 0x001DAB31
	private void PlayCurrentValueTween()
	{
		this.ExpTweener = ULTweenBPLibrary.FloatTo(GlobalData.World, this.ValueDelegate, 0f, 1f, 0.5f, 0f, LTweenEase.OutCubic);
	}

	// Token: 0x06005C63 RID: 23651 RVA: 0x001DC95E File Offset: 0x001DAB5E
	private void OnCompleteDelegate()
	{
		this.OnComplete(false);
	}

	// Token: 0x06005C64 RID: 23652 RVA: 0x001DC968 File Offset: 0x001DAB68
	private void OnComplete(bool isSkip)
	{
		this.PlayCharacterEndAction();
		this.PlayCurrentValueTween();
		this.RemoveTimerHandle();
		if (!isSkip)
		{
			this.TimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.TimerHandle = null;
				if (this.IsFinishShowLastRole())
				{
					this.DelayToSkipToNextStep();
					return;
				}
				this.PlayEndAction();
				this.ShowAddCharacter();
			}, 1000f, null, null, true, 1f);
			return;
		}
		if (this.IsFinishShowLastRole())
		{
			this.DelayToSkipToNextStep();
			return;
		}
		this.PlayEndAction();
		this.ShowAddCharacter();
	}

	// Token: 0x06005C65 RID: 23653 RVA: 0x001DC9D0 File Offset: 0x001DABD0
	private void DelayToSkipToNextStep()
	{
		this.IsLastFinishShow = true;
		this.IsInResult = false;
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			this.TimerHandle = null;
			this.SkipToNextStep();
		}, 2000f, null, null, true, 1f);
	}

	// Token: 0x06005C66 RID: 23654 RVA: 0x001DCA09 File Offset: 0x001DAC09
	private bool RemoveTimerHandle()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
			return true;
		}
		return false;
	}

	// Token: 0x06005C67 RID: 23655 RVA: 0x001DCA30 File Offset: 0x001DAC30
	private void OnSkip()
	{
		if (this.IsLastFinishShow)
		{
			this.RemoveTimerHandle();
			this.SkipToNextStep();
			return;
		}
		if (!this.IsInResult)
		{
			if (this.RemoveRunTimerHandle())
			{
				this.RunFinishCallback();
			}
			return;
		}
		this.PlayStopRunAction();
		if (!this.RemoveTimerHandle())
		{
			if (this.ExpTweener != null)
			{
				this.ExpTweener.Kill(false);
				this.ExpTweener = null;
			}
			this.OnComplete(true);
			return;
		}
		if (this.IsFinishShowLastRole())
		{
			this.DelayToSkipToNextStep();
			return;
		}
		this.PlayEndAction();
		this.ShowAddCharacter();
	}

	// Token: 0x04003D82 RID: 15746
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected CharacterListModule<CharacterItemWithAdd> CharacterListModule;

	// Token: 0x04003D83 RID: 15747
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayout<BusinessTravelRoleItem, int> RoleLayout;

	// Token: 0x04003D84 RID: 15748
	[Nullable(1)]
	protected List<int> RoleIdList = new List<int>();

	// Token: 0x04003D85 RID: 15749
	protected int DelegateId;

	// Token: 0x04003D86 RID: 15750
	protected int ShowIndex = -1;

	// Token: 0x04003D87 RID: 15751
	[Nullable(1)]
	private List<CharacterData> CharacterList = new List<CharacterData>();

	// Token: 0x04003D88 RID: 15752
	protected ULTweener ExpTweener;

	// Token: 0x04003D89 RID: 15753
	protected FLTweenFloatSetterDynamic Delegate;

	// Token: 0x04003D8A RID: 15754
	protected FLTweenFloatSetterDynamic ValueDelegate;

	// Token: 0x04003D8B RID: 15755
	protected TimerHandle SkipAnimDelayTimerHandle;

	// Token: 0x04003D8C RID: 15756
	protected TimerHandle RunTimerHandle;

	// Token: 0x04003D8D RID: 15757
	protected bool IsLastFinishShow;

	// Token: 0x04003D8E RID: 15758
	protected bool IsInResult;

	// Token: 0x04003D8F RID: 15759
	protected TimerHandle SkipResultTimeHandle;

	// Token: 0x04003D90 RID: 15760
	protected TimerHandle TimerHandle;

	// Token: 0x04003D91 RID: 15761
	private const float TWEEN_TIME = 1f;

	// Token: 0x04003D92 RID: 15762
	private const float VALUE_TIME = 0.5f;

	// Token: 0x04003D93 RID: 15763
	private const int RUN_TIME = 2000;

	// Token: 0x04003D94 RID: 15764
	private const int LAST_SHOW = 2000;

	// Token: 0x04003D95 RID: 15765
	private const int NORMAL_SHOW = 1000;

	// Token: 0x04003D96 RID: 15766
	private const int SKIP_RESULT_DELAY = 800;

	// Token: 0x02006B22 RID: 27426
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x040233CC RID: 144332
		public const int Title = 0;

		// Token: 0x040233CD RID: 144333
		public const int CharacterListItem = 1;

		// Token: 0x040233CE RID: 144334
		public const int SkipBtn = 2;

		// Token: 0x040233CF RID: 144335
		public const int RoleLayout = 3;

		// Token: 0x040233D0 RID: 144336
		public const int RoleItem = 4;
	}
}
