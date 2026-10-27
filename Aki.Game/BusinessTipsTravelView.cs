using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001331 RID: 4913
[NullableContext(2)]
[Nullable(0)]
public class BusinessTipsTravelView : UiViewBase
{
	// Token: 0x060088A7 RID: 34983 RVA: 0x001D323B File Offset: 0x001D143B
	[NullableContext(1)]
	public BusinessTipsTravelView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x060088A8 RID: 34984 RVA: 0x001D3264 File Offset: 0x001D1464
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

	// Token: 0x060088A9 RID: 34985 RVA: 0x001D3310 File Offset: 0x001D1510
	private UniTask InitCharacterListModule()
	{
		BusinessTipsTravelView.<InitCharacterListModule>d__24 <InitCharacterListModule>d__;
		<InitCharacterListModule>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCharacterListModule>d__.<>4__this = this;
		<InitCharacterListModule>d__.<>1__state = -1;
		<InitCharacterListModule>d__.<>t__builder.Start<BusinessTipsTravelView.<InitCharacterListModule>d__24>(ref <InitCharacterListModule>d__);
		return <InitCharacterListModule>d__.<>t__builder.Task;
	}

	// Token: 0x060088AA RID: 34986 RVA: 0x001D3354 File Offset: 0x001D1554
	private UniTask InitRoleItemList()
	{
		BusinessTipsTravelView.<InitRoleItemList>d__25 <InitRoleItemList>d__;
		<InitRoleItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRoleItemList>d__.<>4__this = this;
		<InitRoleItemList>d__.<>1__state = -1;
		<InitRoleItemList>d__.<>t__builder.Start<BusinessTipsTravelView.<InitRoleItemList>d__25>(ref <InitRoleItemList>d__);
		return <InitRoleItemList>d__.<>t__builder.Task;
	}

	// Token: 0x060088AB RID: 34987 RVA: 0x001D3398 File Offset: 0x001D1598
	private UniTask InitRoleList()
	{
		BusinessTipsTravelView.<InitRoleList>d__26 <InitRoleList>d__;
		<InitRoleList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRoleList>d__.<>4__this = this;
		<InitRoleList>d__.<>1__state = -1;
		<InitRoleList>d__.<>t__builder.Start<BusinessTipsTravelView.<InitRoleList>d__26>(ref <InitRoleList>d__);
		return <InitRoleList>d__.<>t__builder.Task;
	}

	// Token: 0x060088AC RID: 34988 RVA: 0x001D33DC File Offset: 0x001D15DC
	protected override UniTask OnBeforeStartAsync()
	{
		BusinessTipsTravelView.<OnBeforeStartAsync>d__27 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BusinessTipsTravelView.<OnBeforeStartAsync>d__27>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060088AD RID: 34989 RVA: 0x001D3420 File Offset: 0x001D1620
	protected override UniTask OnBeforeShowAsyncImplementImplement()
	{
		BusinessTipsTravelView.<OnBeforeShowAsyncImplementImplement>d__28 <OnBeforeShowAsyncImplementImplement>d__;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<BusinessTipsTravelView.<OnBeforeShowAsyncImplementImplement>d__28>(ref <OnBeforeShowAsyncImplementImplement>d__);
		return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x060088AE RID: 34990 RVA: 0x001D3463 File Offset: 0x001D1663
	protected override void OnAfterPlayStartSequence()
	{
		this.ShowAddCharacter();
	}

	// Token: 0x060088AF RID: 34991 RVA: 0x001D346C File Offset: 0x001D166C
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

	// Token: 0x060088B0 RID: 34992 RVA: 0x001D34DC File Offset: 0x001D16DC
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

	// Token: 0x060088B1 RID: 34993 RVA: 0x001D3588 File Offset: 0x001D1788
	[NullableContext(1)]
	private CharacterItemWithAdd InitCharacterItemWithAdd()
	{
		return new CharacterItemWithAdd();
	}

	// Token: 0x060088B2 RID: 34994 RVA: 0x001D358F File Offset: 0x001D178F
	[NullableContext(1)]
	private BusinessTravelRoleItem InitRoleItem()
	{
		return new BusinessTravelRoleItem();
	}

	// Token: 0x060088B3 RID: 34995 RVA: 0x001D3598 File Offset: 0x001D1798
	private UniTask OnPreparingFestival()
	{
		BusinessTipsTravelView.<OnPreparingFestival>d__34 <OnPreparingFestival>d__;
		<OnPreparingFestival>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPreparingFestival>d__.<>4__this = this;
		<OnPreparingFestival>d__.<>1__state = -1;
		<OnPreparingFestival>d__.<>t__builder.Start<BusinessTipsTravelView.<OnPreparingFestival>d__34>(ref <OnPreparingFestival>d__);
		return <OnPreparingFestival>d__.<>t__builder.Task;
	}

	// Token: 0x060088B4 RID: 34996 RVA: 0x001D35DC File Offset: 0x001D17DC
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

	// Token: 0x060088B5 RID: 34997 RVA: 0x001D364C File Offset: 0x001D184C
	private void PlayCurrentValue(float value)
	{
		foreach (CharacterItemWithAdd characterItemWithAdd in this.CharacterListModule.GetItemList())
		{
			characterItemWithAdd.RefreshCurrentValue(value);
		}
	}

	// Token: 0x060088B6 RID: 34998 RVA: 0x001D36A4 File Offset: 0x001D18A4
	private void StopTween()
	{
		if (this.ExpTweener != null)
		{
			this.ExpTweener.Kill(false);
			this.ExpTweener = null;
		}
	}

	// Token: 0x060088B7 RID: 34999 RVA: 0x001D36C1 File Offset: 0x001D18C1
	private void PlayStartAction()
	{
		BusinessTravelRoleItem layoutItemByKey = this.RoleLayout.GetLayoutItemByKey(this.ShowIndex);
		if (layoutItemByKey == null)
		{
			return;
		}
		layoutItemByKey.PlayStartAction();
	}

	// Token: 0x060088B8 RID: 35000 RVA: 0x001D36E4 File Offset: 0x001D18E4
	private void PlayCharacterStartAction()
	{
		foreach (CharacterItemWithAdd characterItemWithAdd in this.CharacterListModule.GetItemList())
		{
			characterItemWithAdd.PlayStartAction();
		}
	}

	// Token: 0x060088B9 RID: 35001 RVA: 0x001D373C File Offset: 0x001D193C
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

	// Token: 0x060088BA RID: 35002 RVA: 0x001D37AA File Offset: 0x001D19AA
	private void PlayStopRunAction()
	{
		BusinessTravelRoleItem layoutItemByKey = this.RoleLayout.GetLayoutItemByKey(this.ShowIndex);
		if (layoutItemByKey == null)
		{
			return;
		}
		layoutItemByKey.StopRunToLastFrame();
	}

	// Token: 0x060088BB RID: 35003 RVA: 0x001D37CC File Offset: 0x001D19CC
	private void PlayCharacterRunFinishAction()
	{
		foreach (CharacterItemWithAdd characterItemWithAdd in this.CharacterListModule.GetItemList())
		{
			characterItemWithAdd.PlayAddAction();
			characterItemWithAdd.RefreshAddText();
		}
	}

	// Token: 0x060088BC RID: 35004 RVA: 0x001D3828 File Offset: 0x001D1A28
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

	// Token: 0x060088BD RID: 35005 RVA: 0x001D3854 File Offset: 0x001D1A54
	private void PlayCharacterEndAction()
	{
		foreach (CharacterItemWithAdd characterItemWithAdd in this.CharacterListModule.GetItemList())
		{
			characterItemWithAdd.PlayEndAction();
		}
	}

	// Token: 0x060088BE RID: 35006 RVA: 0x001D38AC File Offset: 0x001D1AAC
	private bool IsFinishShowLastRole()
	{
		List<int> roleIdList = MoonChasingBusinessModel.Instance.GetResultData().GetRoleIdList();
		return this.ShowIndex >= roleIdList.Count - 1;
	}

	// Token: 0x060088BF RID: 35007 RVA: 0x001D38DC File Offset: 0x001D1ADC
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

	// Token: 0x060088C0 RID: 35008 RVA: 0x001D3928 File Offset: 0x001D1B28
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

	// Token: 0x060088C1 RID: 35009 RVA: 0x001D3986 File Offset: 0x001D1B86
	private void RemoveSkipAnimDelayTimerHandle()
	{
		if (this.SkipAnimDelayTimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.SkipAnimDelayTimerHandle);
			this.SkipAnimDelayTimerHandle = null;
		}
	}

	// Token: 0x060088C2 RID: 35010 RVA: 0x001D39A8 File Offset: 0x001D1BA8
	private void AddRunTimerHandle()
	{
		this.RunTimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			this.RunFinishCallback();
		}, 2000f, null, null, true, 1f);
	}

	// Token: 0x060088C3 RID: 35011 RVA: 0x001D39D3 File Offset: 0x001D1BD3
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

	// Token: 0x060088C4 RID: 35012 RVA: 0x001D39F8 File Offset: 0x001D1BF8
	private void AddSkipResultTimeHandle()
	{
		this.SkipResultTimeHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			this.RemoveSkipResultTimeHandle();
			this.IsInResult = true;
		}, 800f, null, null, true, 1f);
	}

	// Token: 0x060088C5 RID: 35013 RVA: 0x001D3A23 File Offset: 0x001D1C23
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

	// Token: 0x060088C6 RID: 35014 RVA: 0x001D3A48 File Offset: 0x001D1C48
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

	// Token: 0x060088C7 RID: 35015 RVA: 0x001D3AC5 File Offset: 0x001D1CC5
	private void PlayCurrentValueTween()
	{
		this.ExpTweener = ULTweenBPLibrary.FloatTo(GlobalData.World, this.ValueDelegate, 0f, 1f, 0.5f, 0f, LTweenEase.OutCubic);
	}

	// Token: 0x060088C8 RID: 35016 RVA: 0x001D3AF2 File Offset: 0x001D1CF2
	private void OnCompleteDelegate()
	{
		this.OnComplete(false);
	}

	// Token: 0x060088C9 RID: 35017 RVA: 0x001D3AFC File Offset: 0x001D1CFC
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

	// Token: 0x060088CA RID: 35018 RVA: 0x001D3B64 File Offset: 0x001D1D64
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

	// Token: 0x060088CB RID: 35019 RVA: 0x001D3B9D File Offset: 0x001D1D9D
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

	// Token: 0x060088CC RID: 35020 RVA: 0x001D3BC4 File Offset: 0x001D1DC4
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

	// Token: 0x04003CEA RID: 15594
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected CharacterListModule<CharacterItemWithAdd> CharacterListModule;

	// Token: 0x04003CEB RID: 15595
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayout<BusinessTravelRoleItem, int> RoleLayout;

	// Token: 0x04003CEC RID: 15596
	[Nullable(1)]
	protected List<int> RoleIdList = new List<int>();

	// Token: 0x04003CED RID: 15597
	protected int DelegateId;

	// Token: 0x04003CEE RID: 15598
	protected int ShowIndex = -1;

	// Token: 0x04003CEF RID: 15599
	[Nullable(1)]
	private List<CharacterData> CharacterList = new List<CharacterData>();

	// Token: 0x04003CF0 RID: 15600
	protected ULTweener ExpTweener;

	// Token: 0x04003CF1 RID: 15601
	protected FLTweenFloatSetterDynamic Delegate;

	// Token: 0x04003CF2 RID: 15602
	protected FLTweenFloatSetterDynamic ValueDelegate;

	// Token: 0x04003CF3 RID: 15603
	protected TimerHandle SkipAnimDelayTimerHandle;

	// Token: 0x04003CF4 RID: 15604
	protected TimerHandle RunTimerHandle;

	// Token: 0x04003CF5 RID: 15605
	protected bool IsLastFinishShow;

	// Token: 0x04003CF6 RID: 15606
	protected bool IsInResult;

	// Token: 0x04003CF7 RID: 15607
	protected TimerHandle SkipResultTimeHandle;

	// Token: 0x04003CF8 RID: 15608
	protected TimerHandle TimerHandle;

	// Token: 0x04003CF9 RID: 15609
	private const float TWEEN_TIME = 1f;

	// Token: 0x04003CFA RID: 15610
	private const float VALUE_TIME = 0.5f;

	// Token: 0x04003CFB RID: 15611
	private const int RUN_TIME = 2000;

	// Token: 0x04003CFC RID: 15612
	private const int LAST_SHOW = 2000;

	// Token: 0x04003CFD RID: 15613
	private const int NORMAL_SHOW = 1000;

	// Token: 0x04003CFE RID: 15614
	private const int SKIP_RESULT_DELAY = 800;

	// Token: 0x02007998 RID: 31128
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402809F RID: 163999
		public const int Title = 0;

		// Token: 0x040280A0 RID: 164000
		public const int CharacterListItem = 1;

		// Token: 0x040280A1 RID: 164001
		public const int SkipBtn = 2;

		// Token: 0x040280A2 RID: 164002
		public const int RoleLayout = 3;

		// Token: 0x040280A3 RID: 164003
		public const int RoleItem = 4;
	}
}
