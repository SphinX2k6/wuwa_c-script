using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Character.BaseCharacter.AnimNotifyState;
using AkiClient.Game.Aki.Character.Input.Enum;
using CSharpScript.Game;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000150 RID: 336
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateOpenSimpleGameplay.TsAnimNotifyStateOpenSimpleGameplay_C")]
public class TsAnimNotifyStateOpenSimpleGameplay : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700036C RID: 876
	// (get) Token: 0x060014FD RID: 5373 RVA: 0x00076850 File Offset: 0x00074A50
	// (set) Token: 0x060014FE RID: 5374 RVA: 0x00076889 File Offset: 0x00074A89
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<SAnimNotifyInteractInfo> InteractInfos
	{
		get
		{
			base.FastCheckIsValid();
			TArray<SAnimNotifyInteractInfo> result;
			if ((result = this._InteractInfos) == null)
			{
				result = (this._InteractInfos = new TArray<SAnimNotifyInteractInfo>(base.NativePtr + (IntPtr)TsAnimNotifyStateOpenSimpleGameplay.__PropertyOffset_InteractInfos, this));
			}
			return result;
		}
		set
		{
			this.InteractInfos.CopyAssign(value);
		}
	}

	// Token: 0x1700036D RID: 877
	// (get) Token: 0x060014FF RID: 5375 RVA: 0x00076897 File Offset: 0x00074A97
	// (set) Token: 0x06001500 RID: 5376 RVA: 0x000768A7 File Offset: 0x00074AA7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EANSGameplayType GameplayType
	{
		get
		{
			return (EANSGameplayType)(*(base.NativePtr + (IntPtr)TsAnimNotifyStateOpenSimpleGameplay.__PropertyOffset_GameplayType));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateOpenSimpleGameplay.__PropertyOffset_GameplayType) = (byte)value;
		}
	}

	// Token: 0x1700036E RID: 878
	// (get) Token: 0x06001501 RID: 5377 RVA: 0x000768B8 File Offset: 0x00074AB8
	// (set) Token: 0x06001502 RID: 5378 RVA: 0x000768F1 File Offset: 0x00074AF1
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<SGameplayResultSkillInfo> SkillInfos
	{
		get
		{
			base.FastCheckIsValid();
			TArray<SGameplayResultSkillInfo> result;
			if ((result = this._SkillInfos) == null)
			{
				result = (this._SkillInfos = new TArray<SGameplayResultSkillInfo>(base.NativePtr + (IntPtr)TsAnimNotifyStateOpenSimpleGameplay.__PropertyOffset_SkillInfos, this));
			}
			return result;
		}
		set
		{
			this.SkillInfos.CopyAssign(value);
		}
	}

	// Token: 0x06001503 RID: 5379 RVA: 0x00076900 File Offset: 0x00074B00
	[return: Nullable(2)]
	private AnsInstanceState GetState(USkeletalMeshComponent meshComp)
	{
		AnsInstanceState result;
		this.StateMap.TryGetValue(meshComp, out result);
		return result;
	}

	// Token: 0x06001504 RID: 5380 RVA: 0x0007691D File Offset: 0x00074B1D
	private void DeleteState(USkeletalMeshComponent meshComp)
	{
		this.StateMap.Remove(meshComp);
	}

	// Token: 0x06001505 RID: 5381 RVA: 0x0007692C File Offset: 0x00074B2C
	private AnsInstanceState CreateState(USkeletalMeshComponent meshComp, TsAnimNotifyStateOpenSimpleGameplay ans, TsBaseCharacter owner)
	{
		AnsInstanceState ansInstanceState;
		if (!this.StateMap.TryGetValue(meshComp, out ansInstanceState))
		{
			ansInstanceState = new AnsInstanceState
			{
				IsListening = true,
				BoundActionNames = new List<string>(),
				ExternalInteractIds = new List<int>(),
				Owner = owner,
				IsGameplayOpened = false,
				StartServerTimeStamp = new double?(TimeUtil.Instance.GetServerTimeStamp()),
				OnActionCallback = delegate(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
				{
					if (actionType == InputDistributeDefine.EActionType.Press)
					{
						ans.OnInteractTriggered(meshComp);
					}
				}
			};
			this.StateMap[meshComp] = ansInstanceState;
		}
		else
		{
			global::Log.Instance.Warn(ELogModule.Battle, ELogAuthor.ZJL, "[TsAnimNotifyStateOpenSimpleGameplay] CreateState时发现旧状态残留，先清理", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.CleanupAllInteractions(meshComp);
			ansInstanceState.IsListening = true;
			ansInstanceState.BoundActionNames.Clear();
			ansInstanceState.ExternalInteractIds.Clear();
			ansInstanceState.Owner = owner;
			ansInstanceState.IsGameplayOpened = false;
			ansInstanceState.StartServerTimeStamp = new double?(TimeUtil.Instance.GetServerTimeStamp());
		}
		return ansInstanceState;
	}

	// Token: 0x06001506 RID: 5382 RVA: 0x00076A38 File Offset: 0x00074C38
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateOpenSimpleGameplay) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateOpenSimpleGameplay.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyBegin_Implementation(meshComp, animation, totalDuration);
		}
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->TotalDuration = totalDuration;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001507 RID: 5383 RVA: 0x00076AF8 File Offset: 0x00074CF8
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = ((TsBaseCharacter)owner).CharacterActorComponent;
		if (characterActorComponent == null || !characterActorComponent.Valid || !characterActorComponent.IsAutonomousProxy)
		{
			return false;
		}
		if (PhotographModel.Instance.IsOpenPhotograph)
		{
			return false;
		}
		if (owner != Global.BaseCharacter)
		{
			return false;
		}
		this.CreateState(meshComp, this, (TsBaseCharacter)owner);
		this.ProcessInteractInfos(meshComp);
		return true;
	}

	// Token: 0x06001508 RID: 5384 RVA: 0x00076B6C File Offset: 0x00074D6C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateOpenSimpleGameplay) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateOpenSimpleGameplay.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyEnd_Implementation(meshComp, animation);
		}
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001509 RID: 5385 RVA: 0x00076C24 File Offset: 0x00074E24
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AnsInstanceState state = this.GetState(meshComp);
		if (state == null)
		{
			return false;
		}
		if (state.IsGameplayOpened)
		{
			return true;
		}
		if (state.IsListening)
		{
			this.CleanupAllInteractions(meshComp);
		}
		state.IsListening = false;
		state.Owner = null;
		this.DeleteState(meshComp);
		return true;
	}

	// Token: 0x0600150A RID: 5386 RVA: 0x00076C70 File Offset: 0x00074E70
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateOpenSimpleGameplay) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateOpenSimpleGameplay.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotifyState.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x0600150B RID: 5387 RVA: 0x00076D00 File Offset: 0x00074F00
	protected override string GetNotifyName_Implementation()
	{
		return "开启休闲玩法ANS";
	}

	// Token: 0x0600150C RID: 5388 RVA: 0x00076D08 File Offset: 0x00074F08
	private void ProcessInteractInfos(USkeletalMeshComponent meshComp)
	{
		AnsInstanceState state = this.GetState(meshComp);
		if (state == null)
		{
			return;
		}
		state.BoundActionNames = new List<string>();
		state.ExternalInteractIds = new List<int>();
		TArray<SAnimNotifyInteractInfo> interactInfos = this.InteractInfos;
		int num = (interactInfos != null) ? interactInfos.Num() : 0;
		if (num <= 0)
		{
			return;
		}
		for (int i = 0; i < num; i++)
		{
			SAnimNotifyInteractInfo sanimNotifyInteractInfo = this.InteractInfos.Get(i);
			if (sanimNotifyInteractInfo.IsShowInteractUi)
			{
				this.RegisterExternalInteractInfo(meshComp, sanimNotifyInteractInfo);
			}
			else
			{
				this.BindInputActionFromInfo(meshComp, sanimNotifyInteractInfo);
			}
		}
		if (state.ExternalInteractIds.Count > 0)
		{
			TsInteractionUtils.OpenInteractHintView().Forget<bool>();
		}
	}

	// Token: 0x0600150D RID: 5389 RVA: 0x00076D9C File Offset: 0x00074F9C
	private void RegisterExternalInteractInfo(USkeletalMeshComponent meshComp, SAnimNotifyInteractInfo info)
	{
		AnsInstanceState state = this.GetState(meshComp);
		if (state == null)
		{
			return;
		}
		ExternalInteractInfo info2 = new ExternalInteractInfo
		{
			Text = (info.InteractText ?? ""),
			IconType = this.MapExternalInteractIcon(info.InteractIconType),
			Callback = delegate
			{
				this.OnInteractTriggered(meshComp);
			}
		};
		int num = InteractionModel.Instance.RegisterExternalInteractInfo(info2);
		if (num >= 0)
		{
			state.ExternalInteractIds.Add(num);
		}
	}

	// Token: 0x0600150E RID: 5390 RVA: 0x00076E30 File Offset: 0x00075030
	private EInteractIcon MapExternalInteractIcon(EExternalInteractIcon ueIconType)
	{
		if (ueIconType == EExternalInteractIcon.Dialog)
		{
			return EInteractIcon.Dialog;
		}
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.Battle;
		ELogAuthor author = ELogAuthor.ZJL;
		string message = "[TsAnimNotifyStateOpenSimpleGameplay] 未知的外部交互图标类型，回退为 Dialog";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IconType", ueIconType);
		instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return EInteractIcon.Dialog;
	}

	// Token: 0x0600150F RID: 5391 RVA: 0x00076E70 File Offset: 0x00075070
	private void BindInputActionFromInfo(USkeletalMeshComponent meshComp, SAnimNotifyInteractInfo info)
	{
		AnsInstanceState state = this.GetState(meshComp);
		if (state == null)
		{
			return;
		}
		string text;
		if (TsAnimNotifyStateOpenSimpleGameplay.inputActionMap.TryGetValue(info.InputAction, out text))
		{
			InputDistributeController.Instance.BindAction(text, state.OnActionCallback);
			state.BoundActionNames.Add(text);
		}
	}

	// Token: 0x06001510 RID: 5392 RVA: 0x00076EBF File Offset: 0x000750BF
	private void CleanupAllInteractions(USkeletalMeshComponent meshComp)
	{
		this.UnBindInputActions(meshComp);
		this.UnregisterExternalInteractInfos(meshComp);
	}

	// Token: 0x06001511 RID: 5393 RVA: 0x00076ED0 File Offset: 0x000750D0
	private void UnBindInputActions(USkeletalMeshComponent meshComp)
	{
		AnsInstanceState state = this.GetState(meshComp);
		if (state == null)
		{
			return;
		}
		foreach (string actionName in state.BoundActionNames)
		{
			InputDistributeController.Instance.UnBindAction(actionName, state.OnActionCallback);
		}
		state.BoundActionNames = new List<string>();
	}

	// Token: 0x06001512 RID: 5394 RVA: 0x00076F44 File Offset: 0x00075144
	private void UnregisterExternalInteractInfos(USkeletalMeshComponent meshComp)
	{
		AnsInstanceState state = this.GetState(meshComp);
		if (state == null)
		{
			return;
		}
		InteractionModel instance = InteractionModel.Instance;
		foreach (int id in state.ExternalInteractIds)
		{
			instance.UnregisterExternalInteractInfo(id);
		}
		state.ExternalInteractIds = new List<int>();
		if (!instance.HasExternalInteractInfos() && instance.GetInteractEntityIds().Count <= 0)
		{
			TsInteractionUtils.CloseInteractHintView("Unknown");
		}
	}

	// Token: 0x06001513 RID: 5395 RVA: 0x00076FD4 File Offset: 0x000751D4
	public void OnInteractTriggered(USkeletalMeshComponent meshComp)
	{
		AnsInstanceState state = this.GetState(meshComp);
		if (state == null)
		{
			return;
		}
		if (!state.IsListening)
		{
			global::Log.Instance.Warn(ELogModule.Battle, ELogAuthor.ZJL, "[TsAnimNotifyStateOpenSimpleGameplay] 收到交互触发，但当前未处于监听状态", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (state.IsGameplayOpened)
		{
			global::Log.Instance.Warn(ELogModule.Battle, ELogAuthor.ZJL, "[TsAnimNotifyStateOpenSimpleGameplay] 收到交互触发，但玩法已开启，防止重复触发", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.CleanupAllInteractions(meshComp);
		state.IsListening = false;
		state.IsGameplayOpened = true;
		this.OpenSimpleGameplay(meshComp);
	}

	// Token: 0x06001514 RID: 5396 RVA: 0x00077054 File Offset: 0x00075254
	private void FinalizeGameplay(USkeletalMeshComponent meshComp)
	{
		AnsInstanceState state = this.GetState(meshComp);
		if (state != null)
		{
			state.Owner = null;
			state.IsGameplayOpened = false;
		}
		this.DeleteState(meshComp);
	}

	// Token: 0x06001515 RID: 5397 RVA: 0x00077084 File Offset: 0x00075284
	private void OpenSimpleGameplay(USkeletalMeshComponent meshComp)
	{
		ESimpleGameplayType esimpleGameplayType;
		if (!TsAnimNotifyStateOpenSimpleGameplay.ansGameplayTypeMap.TryGetValue(this.GameplayType, out esimpleGameplayType))
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "[TsAnimNotifyStateOpenSimpleGameplay] 未知的玩法类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("GameplayType", this.GameplayType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.FinalizeGameplay(meshComp);
			return;
		}
		if (esimpleGameplayType == ESimpleGameplayType.DaemonHack)
		{
			this.OpenDaemonHackGameplay(meshComp);
			return;
		}
		global::Log instance2 = global::Log.Instance;
		ELogModule module2 = ELogModule.Battle;
		ELogAuthor author2 = ELogAuthor.ZJL;
		string message2 = "[TsAnimNotifyStateOpenSimpleGameplay] 暂不支持的玩法类型";
		ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Type", esimpleGameplayType);
		instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		this.FinalizeGameplay(meshComp);
	}

	// Token: 0x06001516 RID: 5398 RVA: 0x00077120 File Offset: 0x00075320
	private void OpenDaemonHackGameplay(USkeletalMeshComponent meshComp)
	{
		TsInteractionUtils.RegisterOpenViewName(EUiViewName.GolemHackingGameView);
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("LucyIdle2Games");
		int configId = 0;
		configId = GolemHackingController.Instance.OpenGameplayView(new List<int>(intArrayConfig), delegate(bool result)
		{
			this.OnGameplayResult(meshComp, result);
			GolemHackingController.Instance.OnUiGameplayFinish(configId);
		}, false, delegate(bool openResult, int _)
		{
			if (!openResult)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.ZJL;
				string message = "[TsAnimNotifyStateOpenSimpleGameplay] 打开玩法界面失败，可能是参数错误或其他原因";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ConfigId", configId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.FinalizeGameplay(meshComp);
				return;
			}
			AudioSystem.Instance.PostEvent("play_vo_luxi_idle_idle02_minigame01");
			AnsInstanceState state = this.GetState(meshComp);
			if (state != null)
			{
				state.StartServerTimeStamp = new double?(TimeUtil.Instance.GetServerTimeStamp());
			}
		});
	}

	// Token: 0x06001517 RID: 5399 RVA: 0x0007718C File Offset: 0x0007538C
	private void OnGameplayResult(USkeletalMeshComponent meshComp, bool success)
	{
		int resultSkillId = this.GetResultSkillId(meshComp, success);
		if (resultSkillId <= 0)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "[TsAnimNotifyStateOpenSimpleGameplay] 玩法结果无对应技能";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("success", success);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.FinalizeGameplay(meshComp);
			return;
		}
		this.CastResultSkill(meshComp, resultSkillId).Forget();
	}

	// Token: 0x06001518 RID: 5400 RVA: 0x000771E8 File Offset: 0x000753E8
	private int GetResultSkillId(USkeletalMeshComponent meshComp, bool success)
	{
		AnsInstanceState state = this.GetState(meshComp);
		if (state == null || state.Owner == null)
		{
			return -1;
		}
		for (int i = 0; i < this.SkillInfos.Num(); i++)
		{
			SGameplayResultSkillInfo sgameplayResultSkillInfo = this.SkillInfos.Get(i);
			if (this.CheckSkillCondition(state, success, sgameplayResultSkillInfo))
			{
				return sgameplayResultSkillInfo.SkillId;
			}
		}
		return -1;
	}

	// Token: 0x06001519 RID: 5401 RVA: 0x00077240 File Offset: 0x00075440
	private bool CheckSkillCondition(AnsInstanceState state, bool success, SGameplayResultSkillInfo skillInfo)
	{
		if (skillInfo.IsWinResult != success)
		{
			return false;
		}
		if (skillInfo.IsCheckStartTimeStamp)
		{
			double? startServerTimeStamp = state.StartServerTimeStamp;
			if ((TimeUtil.Instance.GetServerTimeStamp() - startServerTimeStamp.GetValueOrDefault()) * TimeUtil.Instance.Millisecond > (double)skillInfo.TimeStampDelta)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600151A RID: 5402 RVA: 0x00077290 File Offset: 0x00075490
	private UniTask CastResultSkill(USkeletalMeshComponent meshComp, int skillId)
	{
		TsAnimNotifyStateOpenSimpleGameplay.<CastResultSkill>d__36 <CastResultSkill>d__;
		<CastResultSkill>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CastResultSkill>d__.<>4__this = this;
		<CastResultSkill>d__.meshComp = meshComp;
		<CastResultSkill>d__.skillId = skillId;
		<CastResultSkill>d__.<>1__state = -1;
		<CastResultSkill>d__.<>t__builder.Start<TsAnimNotifyStateOpenSimpleGameplay.<CastResultSkill>d__36>(ref <CastResultSkill>d__);
		return <CastResultSkill>d__.<>t__builder.Task;
	}

	// Token: 0x0600151B RID: 5403 RVA: 0x000772E3 File Offset: 0x000754E3
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateOpenSimpleGameplay._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateOpenSimpleGameplay.TsAnimNotifyStateOpenSimpleGameplay_C");
		}
		return TsAnimNotifyStateOpenSimpleGameplay._ClassPtr;
	}

	// Token: 0x0600151C RID: 5404 RVA: 0x00077308 File Offset: 0x00075508
	public TsAnimNotifyStateOpenSimpleGameplay() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateOpenSimpleGameplay.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600151D RID: 5405 RVA: 0x00077330 File Offset: 0x00075530
	public TsAnimNotifyStateOpenSimpleGameplay(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateOpenSimpleGameplay.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600151E RID: 5406 RVA: 0x00077363 File Offset: 0x00075563
	protected TsAnimNotifyStateOpenSimpleGameplay(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600151F RID: 5407 RVA: 0x00077378 File Offset: 0x00075578
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001520 RID: 5408 RVA: 0x000773B4 File Offset: 0x000755B4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001521 RID: 5409 RVA: 0x000773E7 File Offset: 0x000755E7
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000ED7 RID: 3799
	private static readonly Dictionary<EANSGameplayType, ESimpleGameplayType> ansGameplayTypeMap = new Dictionary<EANSGameplayType, ESimpleGameplayType>
	{
		{
			EANSGameplayType.魔偶骇入,
			ESimpleGameplayType.DaemonHack
		}
	};

	// Token: 0x04000ED8 RID: 3800
	private static readonly Dictionary<EInputAction, string> inputActionMap = new Dictionary<EInputAction, string>
	{
		{
			EInputAction.通用交互,
			"通用交互"
		}
	};

	// Token: 0x04000ED9 RID: 3801
	private readonly Dictionary<USkeletalMeshComponent, AnsInstanceState> StateMap = new Dictionary<USkeletalMeshComponent, AnsInstanceState>();

	// Token: 0x04000EDA RID: 3802
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateOpenSimpleGameplay.TsAnimNotifyStateOpenSimpleGameplay_C";

	// Token: 0x04000EDB RID: 3803
	private static IntPtr _ClassPtr;

	// Token: 0x04000EDC RID: 3804
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000EDD RID: 3805
	private static int __PropertyOffset_InteractInfos;

	// Token: 0x04000EDE RID: 3806
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<SAnimNotifyInteractInfo> _InteractInfos;

	// Token: 0x04000EDF RID: 3807
	private static int __PropertyOffset_GameplayType;

	// Token: 0x04000EE0 RID: 3808
	private static int __PropertyOffset_SkillInfos;

	// Token: 0x04000EE1 RID: 3809
	[Nullable(2)]
	private TArray<SGameplayResultSkillInfo> _SkillInfos;
}
