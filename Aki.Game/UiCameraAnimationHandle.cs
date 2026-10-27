using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002C34 RID: 11316
[NullableContext(1)]
[Nullable(0)]
public class UiCameraAnimationHandle
{
	// Token: 0x0601796B RID: 96619 RVA: 0x00600366 File Offset: 0x005FE566
	public void Initialize()
	{
		this.UiCameraLoadingAnimation = new UiCameraLoadingAnimation();
		this.UiCameraLoadingAnimation.Initialize();
		this.IsActivate = false;
	}

	// Token: 0x0601796C RID: 96620 RVA: 0x00600385 File Offset: 0x005FE585
	public void Reset()
	{
		this.Deactivate();
		this.HandleData = null;
		this.UiCameraAnimationConfig = null;
		this.UiCameraLoadingAnimation = null;
		this.IsViewInLoading = false;
		this.IsPendingRevert = false;
		this.OnRevertFinished = null;
	}

	// Token: 0x0601796D RID: 96621 RVA: 0x006003B7 File Offset: 0x005FE5B7
	public void Tick(float delta)
	{
		UiCameraLoadingAnimation uiCameraLoadingAnimation = this.UiCameraLoadingAnimation;
		if (uiCameraLoadingAnimation == null)
		{
			return;
		}
		uiCameraLoadingAnimation.Tick(delta);
	}

	// Token: 0x0601796E RID: 96622 RVA: 0x006003CA File Offset: 0x005FE5CA
	public void SetHandleData(UiCameraHandleData handleData)
	{
		this.HandleData = handleData;
	}

	// Token: 0x0601796F RID: 96623 RVA: 0x006003D4 File Offset: 0x005FE5D4
	public unsafe void Activate(UiCameraHandleData handleData, bool bBlend = true, bool bPlayBlendInSequence = true)
	{
		this.HandleData = handleData;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CameraAnimation;
		ELogAuthor author = ELogAuthor.BB;
		string message = "激活界面镜头状态";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("HandleData", this.HandleData.ToString());
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		SUiCameraAnimationSettings uiCameraAnimationConfig = this.HandleData.GetUiCameraAnimationConfig();
		if (uiCameraAnimationConfig == null)
		{
			EventSystem.Instance.Emit<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandleFail, this.HandleData);
			return;
		}
		if (handleData.IsEmptyState)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.CameraAnimation;
			ELogAuthor author2 = ELogAuthor.BB;
			string message2 = "激活界面镜头状态时，激活了一个空状态";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("HandleData", this.HandleData.ToString());
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			EventSystem.Instance.Emit<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandle, handleData);
			return;
		}
		this.UiCameraAnimationConfig = uiCameraAnimationConfig;
		this.IsPlayingBlendInSequence = false;
		UiCameraAnimationDefine.EPlayBlendCameraSequenceResult eplayBlendCameraSequenceResult = this.TryPlayBlendCameraSequence(uiCameraAnimationConfig.BlendInCameraSequence, uiCameraAnimationConfig.BlendInCameraSequencePlayRate, uiCameraAnimationConfig.bRevertBlendInCameraSequence, delegate
		{
			this.IsPlayingBlendInSequence = false;
			EventSystem.Instance.Emit<UiCameraHandleData>(EEventName.OnUiBlendInCameraSequenceFinished, handleData);
		});
		if (eplayBlendCameraSequenceResult == UiCameraAnimationDefine.EPlayBlendCameraSequenceResult.TargetActorNotFound)
		{
			this.IsPlayingBlendInSequence = false;
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.CameraAnimation;
			ELogAuthor author3 = ELogAuthor.BB;
			string message3 = "激活界面镜头状态时，填了BlendInCameraSequence，但是目标Actor无法找到，直接休眠UI相机状态";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("HandleData", this.HandleData.ToString());
			instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			EventSystem.Instance.Emit<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandleFail, this.HandleData);
			this.Deactivate();
			return;
		}
		if (eplayBlendCameraSequenceResult == UiCameraAnimationDefine.EPlayBlendCameraSequenceResult.Success)
		{
			this.IsPlayingBlendInSequence = true;
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.CameraAnimation;
			ELogAuthor author4 = ELogAuthor.BB;
			string message4 = "激活界面镜头状态时，填了BlendInCameraSequence，会直接播放Sequence而不会进行其他线性变化计算";
			ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("HandleData", this.HandleData.ToString());
			instance4.Info(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
			EventSystem.Instance.Emit<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandle, handleData);
			return;
		}
		if (UiCameraAnimationManager.Instance.UiCamera == null)
		{
			EventSystem.Instance.Emit<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandleFail, this.HandleData);
			this.Deactivate();
			return;
		}
		this.IsPendingRevert = false;
		FVectorDouble? targetLocation = this.HandleData.GetTargetLocation();
		FRotator? targetRotation = this.HandleData.GetTargetRotation();
		if (targetLocation == null || targetRotation == null)
		{
			Log instance5 = Log.Instance;
			ELogModule module5 = ELogModule.CameraAnimation;
			ELogAuthor author5 = ELogAuthor.BB;
			string message5 = "激活界面镜头状态时，找不到对应位置或旋转，可能是对应目标无法找到";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("HandleData", this.HandleData.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ReplaceCameraTag", this.HandleData.ReplaceCameraTag);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
			string item = "ReplaceCameraIsValid";
			ACineCameraActor replaceCameraActor = this.HandleData.GetReplaceCameraActor();
			ptr = new ValueTuple<string, object>(item, (replaceCameraActor != null) ? new bool?(replaceCameraActor.IsValid()) : null);
			instance5.Info(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			EventSystem.Instance.Emit<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandleFail, this.HandleData);
			this.Deactivate();
			return;
		}
		this.StopSequence();
		this.SetUiCameraAnimationRotation(targetRotation.Value);
		this.SetUiCameraAnimationLocation(targetLocation.Value);
		this.SetSpringArmLength(this.HandleData.GetTargetArmLength());
		this.SetSpringArmRelativeLocation(this.HandleData.GetTargetArmOffsetLocation());
		this.SetSprintArmRelativeRotation(this.HandleData.GetTargetArmOffsetRotation());
		this.SetCollisionTest(this.HandleData.GetTargetArmCollisionTest());
		this.SetCameraFieldOfView(this.HandleData.GetTargetFieldOfView());
		this.SetCameraFocalRegion(this.HandleData.GetTargetFocalRegion());
		this.SetCameraPostProcessBlendWeight(this.HandleData.GetTargetPostProcessBlendWeight());
		this.SetWidgetCameraAttachToAnimationActor();
		UiCameraAnimationManager.Instance.UiCamera.Enter(bBlend ? uiCameraAnimationConfig.BlendInTime : 0f, uiCameraAnimationConfig.BlendInFunction, uiCameraAnimationConfig.BlendInExp, delegate
		{
			EventSystem.Instance.Emit<UiCameraHandleData>(EEventName.OnUiBlendInTimeCameraFinished, handleData);
		});
		if (this.UiCameraAnimationConfig.bResetCameraTransform)
		{
			UiCameraAnimationManager.Instance.ResetFightCameraRotation();
		}
		string viewName = this.HandleData.ViewName;
		UiCameraAnimationDefine.IUiCameraMapping uiCameraMappingConfig = this.HandleData.UiCameraMappingConfig;
		if (!string.IsNullOrEmpty(viewName) && UiManager.Instance.IsViewCreating((EUiViewName)viewName) && uiCameraMappingConfig != null && uiCameraMappingConfig.PlayLoadingCameraAnimation)
		{
			Log instance6 = Log.Instance;
			ELogModule module6 = ELogModule.CameraAnimation;
			ELogAuthor author6 = ELogAuthor.BB;
			string message6 = "激活界面镜头状态时，当前界面在加载中，过渡到模糊镜头效果";
			ValueTuple<string, object> valueTuple5 = new ValueTuple<string, object>("HandleData", this.HandleData.ToString());
			instance6.Info(module6, author6, message6, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple5));
			this.UiCameraLoadingAnimation.Play(UiCameraAnimationManager.Instance.LoadingViewCameraAnimationLength.Value, UiCameraAnimationManager.Instance.LoadingViewManualFocusDistance.Value, UiCameraAnimationManager.Instance.LoadingViewAperture.Value);
			this.IsViewInLoading = true;
		}
		else
		{
			Log instance7 = Log.Instance;
			ELogModule module7 = ELogModule.CameraAnimation;
			ELogAuthor author7 = ELogAuthor.BB;
			string message7 = "激活界面镜头状态时，当前界面不在加载中，所以停止模糊效果";
			ValueTuple<string, object> valueTuple6 = new ValueTuple<string, object>("HandleData", this.HandleData.ToString());
			instance7.Info(module7, author7, message7, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple6));
			this.IsViewInLoading = false;
			this.UiCameraLoadingAnimation.Stop();
			if (CameraModel.Instance.MainModel.GetSavedSeqCameraThings() == null)
			{
				this.SetCameraFocalDistance(this.HandleData.GetTargetFocalDistance());
			}
			this.SetCameraAperture(this.HandleData.GetTargetAperture());
			if (bPlayBlendInSequence)
			{
				this.PlayUiCameraSequence(uiCameraAnimationConfig.BlendInSequence, uiCameraAnimationConfig.BlendInPlayRate, uiCameraAnimationConfig.bBlendInSequenceReverse, null);
			}
		}
		this.IsActivate = true;
		CameraModel instance8 = CameraModel.Instance;
		if (instance8.MainModel.GetSavedSeqCameraThings() != null)
		{
			instance8.MainModel.ResetSavedSeqCameraThings();
		}
		EventSystem.Instance.Emit<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandle, handleData);
	}

	// Token: 0x06017970 RID: 96624 RVA: 0x00600933 File Offset: 0x005FEB33
	public void Deactivate()
	{
		if (!this.IsActivate)
		{
			return;
		}
		UiCameraLoadingAnimation uiCameraLoadingAnimation = this.UiCameraLoadingAnimation;
		if (uiCameraLoadingAnimation != null && uiCameraLoadingAnimation.IsPlaying)
		{
			this.UiCameraLoadingAnimation.Stop();
		}
		this.IsActivate = false;
	}

	// Token: 0x06017971 RID: 96625 RVA: 0x00600964 File Offset: 0x005FEB64
	public UiCameraHandleData GetHandleData()
	{
		return this.HandleData;
	}

	// Token: 0x06017972 RID: 96626 RVA: 0x0060096C File Offset: 0x005FEB6C
	public bool GetIsActivate()
	{
		return this.IsActivate;
	}

	// Token: 0x06017973 RID: 96627 RVA: 0x00600974 File Offset: 0x005FEB74
	[NullableContext(2)]
	public void Revert(bool bPlayBlendOutSequence = true, Action onRevertFinished = null)
	{
		SUiCameraAnimationSettings uiCameraAnimationConfig = this.HandleData.GetUiCameraAnimationConfig();
		if (uiCameraAnimationConfig == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.CameraAnimation;
			ELogAuthor author = ELogAuthor.BB;
			string message = "找不到镜头配置，强制还原镜头至战斗镜头";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("HandleData", this.HandleData.ToString());
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (onRevertFinished != null)
			{
				onRevertFinished();
			}
			this.Reset();
			return;
		}
		this.UiCameraAnimationConfig = uiCameraAnimationConfig;
		TSoftObjectPtr<ULevelSequence> blendOutCameraSequence = uiCameraAnimationConfig.BlendOutCameraSequence;
		float blendOutCameraSequencePlayRate = uiCameraAnimationConfig.BlendOutCameraSequencePlayRate;
		bool bRevertBlendOutCameraSequence = uiCameraAnimationConfig.bRevertBlendOutCameraSequence;
		this.OnRevertFinished = onRevertFinished;
		if (this.TryPlayBlendCameraSequence(blendOutCameraSequence, blendOutCameraSequencePlayRate, bRevertBlendOutCameraSequence, new Action(this.FinishRevert)) == UiCameraAnimationDefine.EPlayBlendCameraSequenceResult.Success)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.CameraAnimation;
			ELogAuthor author2 = ELogAuthor.BB;
			string message2 = "还原界面镜头状态时，填了BlendOutCameraSequence，会直接播放Sequence而不会进行其他线性变化计算";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("HandleData", this.HandleData.ToString());
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		float blendOutTime = this.UiCameraAnimationConfig.BlendOutTime;
		TEnumAsByte<EViewTargetBlendFunction> blendOutFunction = this.UiCameraAnimationConfig.BlendOutFunction;
		float blendOutExp = this.UiCameraAnimationConfig.BlendOutExp;
		bool bResetCameraTransform = this.UiCameraAnimationConfig.bResetCameraTransform;
		TSoftObjectPtr<ULevelSequence> blendOutSequence = this.UiCameraAnimationConfig.BlendOutSequence;
		bool bBlendOutSequenceReverse = this.UiCameraAnimationConfig.bBlendOutSequenceReverse;
		float blendOutPlayRate = this.UiCameraAnimationConfig.BlendOutPlayRate;
		Log instance3 = Log.Instance;
		ELogModule module3 = ELogModule.CameraAnimation;
		ELogAuthor author3 = ELogAuthor.BB;
		string message3 = "还原镜头至战斗镜头";
		ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("HandleData", this.HandleData.ToString());
		instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
		if (bResetCameraTransform)
		{
			UiCameraAnimationManager.Instance.ResetFightCameraRotation();
		}
		UiCameraAnimationManager.Instance.UiCamera.Exit(blendOutTime, blendOutFunction, blendOutExp);
		if (bResetCameraTransform)
		{
			FightCamera fightCamera = CameraModel.Instance.MainModel.FightCamera;
			if (fightCamera != null)
			{
				FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
				if (logicComponent != null)
				{
					logicComponent.ForceTickOutSide();
				}
			}
		}
		this.IsPendingRevert = true;
		TSoftObjectPtr<UObject> tsoftObjectPtr = new TSoftObjectPtr<UObject>(blendOutSequence);
		if (bPlayBlendOutSequence && UKismetSystemLibrary.IsValidSoftObjectReference(tsoftObjectPtr))
		{
			this.PlayUiCameraSequence(blendOutSequence, blendOutPlayRate, bBlendOutSequenceReverse, null).ContinueWith(delegate()
			{
				UiCameraAnimationManager.Instance.UiCameraSequenceComponent.AddUiCameraSequenceFinishedCallback(new Action(this.OnBlendOutSequenceFinished));
			});
			return;
		}
		this.FinishRevert();
	}

	// Token: 0x06017974 RID: 96628 RVA: 0x00600B5D File Offset: 0x005FED5D
	private void OnBlendOutSequenceFinished()
	{
		this.FinishRevert();
	}

	// Token: 0x06017975 RID: 96629 RVA: 0x00600B68 File Offset: 0x005FED68
	private void FinishRevert()
	{
		if (this.HandleData == null)
		{
			Log.Instance.Info(ELogModule.CameraAnimation, ELogAuthor.BB, "界面镜头状态 Revert(BlendOut) 完成时已被重置", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CameraAnimation;
		ELogAuthor author = ELogAuthor.BB;
		string message = "界面镜头状态 Revert(BlendOut) 完成";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("HandleData", this.HandleData.ToString());
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		Action onRevertFinished = this.OnRevertFinished;
		if (onRevertFinished != null)
		{
			onRevertFinished();
		}
		this.Reset();
	}

	// Token: 0x06017976 RID: 96630 RVA: 0x00600BE2 File Offset: 0x005FEDE2
	public bool GetIsPendingRevert()
	{
		return this.IsPendingRevert;
	}

	// Token: 0x06017977 RID: 96631 RVA: 0x00600BEA File Offset: 0x005FEDEA
	public void StopSequence()
	{
		if (UiCameraAnimationManager.Instance.UiCameraSequenceComponent == null)
		{
			return;
		}
		UiCameraAnimationManager.Instance.UiCameraSequenceComponent.DestroyUiCameraSequence(true, ERestoreStateType.NotRestore);
	}

	// Token: 0x06017978 RID: 96632 RVA: 0x00600C0A File Offset: 0x005FEE0A
	public string GetViewName()
	{
		return this.HandleData.ViewName;
	}

	// Token: 0x06017979 RID: 96633 RVA: 0x00600C17 File Offset: 0x005FEE17
	public bool GetIsPlayingBlendInSequence()
	{
		return this.IsPlayingBlendInSequence;
	}

	// Token: 0x17001FC7 RID: 8135
	// (get) Token: 0x0601797A RID: 96634 RVA: 0x00600C1F File Offset: 0x005FEE1F
	public AActor GetUiCameraAnimationActor
	{
		get
		{
			return UiCameraAnimationManager.Instance.UiCameraSpringStructure.GetOwnActor();
		}
	}

	// Token: 0x0601797B RID: 96635 RVA: 0x00600C30 File Offset: 0x005FEE30
	private UiCameraAnimationDefine.EPlayBlendCameraSequenceResult TryPlayBlendCameraSequence(TSoftObjectPtr<ULevelSequence> blendInCameraSequence, float playRate, bool bReverse, Action onFinished = null)
	{
		TSoftObjectPtr<UObject> tsoftObjectPtr = new TSoftObjectPtr<UObject>(blendInCameraSequence);
		if (!UKismetSystemLibrary.IsValidSoftObjectReference(tsoftObjectPtr))
		{
			return UiCameraAnimationDefine.EPlayBlendCameraSequenceResult.PathIsEmpty;
		}
		AActor targetActor = this.HandleData.GetTargetActor();
		if (targetActor == null || !targetActor.IsValid())
		{
			return UiCameraAnimationDefine.EPlayBlendCameraSequenceResult.TargetActorNotFound;
		}
		this.SetWidgetCameraDetachFromAnimationActor();
		this.PlayUiCameraSequence(blendInCameraSequence, playRate, bReverse, targetActor).ContinueWith(delegate()
		{
			SUiCameraAnimationSettings uiCameraAnimationConfig = this.HandleData.GetUiCameraAnimationConfig();
			UiCameraAnimationManager.Instance.UiCamera.Enter(uiCameraAnimationConfig.BlendInTime, uiCameraAnimationConfig.BlendInFunction, uiCameraAnimationConfig.BlendInExp, null);
		});
		UiCameraAnimationManager.Instance.UiCameraSequenceComponent.AddUiCameraSequenceFinishedCallback(onFinished);
		return UiCameraAnimationDefine.EPlayBlendCameraSequenceResult.Success;
	}

	// Token: 0x0601797C RID: 96636 RVA: 0x00600C9C File Offset: 0x005FEE9C
	public void SetUiCameraAnimationLocation(FVectorDouble location)
	{
		UiCameraAnimationManager.Instance.UiCameraSpringStructure.SetActorLocation(location);
	}

	// Token: 0x0601797D RID: 96637 RVA: 0x00600CAE File Offset: 0x005FEEAE
	public void SetUiCameraAnimationRelativeLocation(FVectorDouble location)
	{
		UiCameraAnimationManager.Instance.UiCameraSpringStructure.SetActorRelativeLocation(location);
	}

	// Token: 0x0601797E RID: 96638 RVA: 0x00600CC0 File Offset: 0x005FEEC0
	public void SetUiCameraAnimationRotation(FRotator rotation)
	{
		UiCameraAnimationManager.Instance.UiCameraSpringStructure.SetActorRotation(rotation);
	}

	// Token: 0x0601797F RID: 96639 RVA: 0x00600CD2 File Offset: 0x005FEED2
	public void SetSpringArmLength(float length)
	{
		UiCameraAnimationManager.Instance.UiCameraSpringStructure.SetSpringArmLength(length);
	}

	// Token: 0x06017980 RID: 96640 RVA: 0x00600CE4 File Offset: 0x005FEEE4
	public void SetSprintArmRelativeRotation(FRotator rotation)
	{
		UiCameraAnimationManager.Instance.UiCameraSpringStructure.SetSprintArmRelativeRotation(rotation);
	}

	// Token: 0x06017981 RID: 96641 RVA: 0x00600CF6 File Offset: 0x005FEEF6
	public void SetSpringArmRelativeLocation(FVectorDouble location)
	{
		UiCameraAnimationManager.Instance.UiCameraSpringStructure.SetSpringArmRelativeLocation(location);
	}

	// Token: 0x06017982 RID: 96642 RVA: 0x00600D08 File Offset: 0x005FEF08
	private void SetCollisionTest(bool bCollisionTest)
	{
		UiCameraAnimationManager.Instance.UiCameraSpringStructure.SetCollisionTest(bCollisionTest);
	}

	// Token: 0x06017983 RID: 96643 RVA: 0x00600D1A File Offset: 0x005FEF1A
	public void SetCameraFieldOfView(float fieldOfView)
	{
		UiCameraAnimationManager.Instance.UiCameraPostEffectComponent.SetCameraFieldOfView(fieldOfView);
	}

	// Token: 0x06017984 RID: 96644 RVA: 0x00600D2C File Offset: 0x005FEF2C
	public void SetCameraFocalDistance(float focalDistance)
	{
		UiCameraAnimationManager.Instance.UiCameraPostEffectComponent.SetCameraFocalDistance(focalDistance);
	}

	// Token: 0x06017985 RID: 96645 RVA: 0x00600D3E File Offset: 0x005FEF3E
	public void SetCameraCurrentFocalLength(float currentFocalLength)
	{
		UiCameraAnimationManager.Instance.UiCameraPostEffectComponent.SetCameraCurrentFocalLength(currentFocalLength);
	}

	// Token: 0x06017986 RID: 96646 RVA: 0x00600D50 File Offset: 0x005FEF50
	public void SetCameraAperture(float aperture)
	{
		UiCameraAnimationManager.Instance.UiCameraPostEffectComponent.SetCameraAperture(aperture);
	}

	// Token: 0x06017987 RID: 96647 RVA: 0x00600D62 File Offset: 0x005FEF62
	public void SetCameraFocalRegion(float focalRegion)
	{
		UiCameraAnimationManager.Instance.UiCameraPostEffectComponent.SetCameraFocalRegion(focalRegion);
	}

	// Token: 0x06017988 RID: 96648 RVA: 0x00600D74 File Offset: 0x005FEF74
	public void SetCameraPostProcessBlendWeight(float postProcessBlendWeight)
	{
		UiCameraAnimationManager.Instance.UiCameraPostEffectComponent.SetCameraPostProcessBlendWeight(postProcessBlendWeight);
	}

	// Token: 0x06017989 RID: 96649 RVA: 0x00600D86 File Offset: 0x005FEF86
	public void SetWidgetCameraAttachToAnimationActor()
	{
		UiCameraAnimationManager.Instance.UiCameraSpringStructure.CameraActorAttachToSpringActor();
		UiCameraAnimationManager.Instance.UiCameraSpringStructure.SetCameraActorRelativeLocation(FVectorDouble.ZeroVector);
	}

	// Token: 0x0601798A RID: 96650 RVA: 0x00600DAB File Offset: 0x005FEFAB
	public void SetWidgetCameraDetachFromAnimationActor()
	{
		UiCameraAnimationManager.Instance.UiCameraSpringStructure.CameraActorDetachFromSpringActor();
	}

	// Token: 0x0601798B RID: 96651 RVA: 0x00600DBC File Offset: 0x005FEFBC
	private UniTask PlayUiCameraSequence(TSoftObjectPtr<ULevelSequence> sequenceSoftObjectPtr, float playRate, bool bReverse, AActor originActor = null)
	{
		UiCameraAnimationHandle.<PlayUiCameraSequence>d__41 <PlayUiCameraSequence>d__;
		<PlayUiCameraSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayUiCameraSequence>d__.<>4__this = this;
		<PlayUiCameraSequence>d__.sequenceSoftObjectPtr = sequenceSoftObjectPtr;
		<PlayUiCameraSequence>d__.playRate = playRate;
		<PlayUiCameraSequence>d__.bReverse = bReverse;
		<PlayUiCameraSequence>d__.originActor = originActor;
		<PlayUiCameraSequence>d__.<>1__state = -1;
		<PlayUiCameraSequence>d__.<>t__builder.Start<UiCameraAnimationHandle.<PlayUiCameraSequence>d__41>(ref <PlayUiCameraSequence>d__);
		return <PlayUiCameraSequence>d__.<>t__builder.Task;
	}

	// Token: 0x0601798C RID: 96652 RVA: 0x00600E20 File Offset: 0x005FF020
	public void DeepCopyCameraInfo(ACameraActor cameraActor)
	{
		this.SetUiCameraAnimationRotation(cameraActor.K2_GetActorRotation());
		this.SetUiCameraAnimationLocation(cameraActor.D_K2_GetActorLocation());
		this.SetCameraFieldOfView(cameraActor.CameraComponent.FieldOfView);
	}

	// Token: 0x0400AFF1 RID: 45041
	private SUiCameraAnimationSettings UiCameraAnimationConfig;

	// Token: 0x0400AFF2 RID: 45042
	private UiCameraHandleData HandleData;

	// Token: 0x0400AFF3 RID: 45043
	private bool IsActivate;

	// Token: 0x0400AFF4 RID: 45044
	[Nullable(2)]
	private Action OnRevertFinished;

	// Token: 0x0400AFF5 RID: 45045
	private UiCameraLoadingAnimation UiCameraLoadingAnimation;

	// Token: 0x0400AFF6 RID: 45046
	public bool IsViewInLoading;

	// Token: 0x0400AFF7 RID: 45047
	private bool IsPendingRevert;

	// Token: 0x0400AFF8 RID: 45048
	private bool IsPlayingBlendInSequence;
}
