using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x0200014C RID: 332
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateOpenSimpleGameplay.TsAnimNotifyStateOpenSimpleGameplay_C")]
public class TsAnimNotifyStateOpenSimpleGameplay : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700034A RID: 842
	// (get) Token: 0x06001460 RID: 5216 RVA: 0x000714B8 File Offset: 0x0006F6B8
	// (set) Token: 0x06001461 RID: 5217 RVA: 0x000714F1 File Offset: 0x0006F6F1
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

	// Token: 0x1700034B RID: 843
	// (get) Token: 0x06001462 RID: 5218 RVA: 0x000714FF File Offset: 0x0006F6FF
	// (set) Token: 0x06001463 RID: 5219 RVA: 0x0007150F File Offset: 0x0006F70F
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

	// Token: 0x1700034C RID: 844
	// (get) Token: 0x06001464 RID: 5220 RVA: 0x00071520 File Offset: 0x0006F720
	// (set) Token: 0x06001465 RID: 5221 RVA: 0x00071559 File Offset: 0x0006F759
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

	// Token: 0x06001466 RID: 5222 RVA: 0x00071568 File Offset: 0x0006F768
	[return: Nullable(2)]
	private AnsInstanceState GetState(USkeletalMeshComponent meshComp)
	{
		AnsInstanceState result;
		this.StateMap.TryGetValue(meshComp, out result);
		return result;
	}

	// Token: 0x06001467 RID: 5223 RVA: 0x00071585 File Offset: 0x0006F785
	private void DeleteState(USkeletalMeshComponent meshComp)
	{
		this.StateMap.Remove(meshComp);
	}

	// Token: 0x06001468 RID: 5224 RVA: 0x00071594 File Offset: 0x0006F794
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

	// Token: 0x06001469 RID: 5225 RVA: 0x000716A0 File Offset: 0x0006F8A0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyBegin"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->TotalDuration = totalDuration;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0600146A RID: 5226 RVA: 0x00071748 File Offset: 0x0006F948
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

	// Token: 0x0600146B RID: 5227 RVA: 0x000717BC File Offset: 0x0006F9BC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyEnd"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0600146C RID: 5228 RVA: 0x0007185C File Offset: 0x0006FA5C
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

	// Token: 0x0600146D RID: 5229 RVA: 0x000718A8 File Offset: 0x0006FAA8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotifyState.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		string result = FString.ToString((void*)(&ptr2->__Result));
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}

	// Token: 0x0600146E RID: 5230 RVA: 0x00071923 File Offset: 0x0006FB23
	protected override string GetNotifyName_Implementation()
	{
		return "开启休闲玩法ANS";
	}

	// Token: 0x0600146F RID: 5231 RVA: 0x0007192C File Offset: 0x0006FB2C
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

	// Token: 0x06001470 RID: 5232 RVA: 0x000719C0 File Offset: 0x0006FBC0
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

	// Token: 0x06001471 RID: 5233 RVA: 0x00071A54 File Offset: 0x0006FC54
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

	// Token: 0x06001472 RID: 5234 RVA: 0x00071A94 File Offset: 0x0006FC94
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

	// Token: 0x06001473 RID: 5235 RVA: 0x00071AE3 File Offset: 0x0006FCE3
	private void CleanupAllInteractions(USkeletalMeshComponent meshComp)
	{
		this.UnBindInputActions(meshComp);
		this.UnregisterExternalInteractInfos(meshComp);
	}

	// Token: 0x06001474 RID: 5236 RVA: 0x00071AF4 File Offset: 0x0006FCF4
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

	// Token: 0x06001475 RID: 5237 RVA: 0x00071B68 File Offset: 0x0006FD68
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

	// Token: 0x06001476 RID: 5238 RVA: 0x00071BF8 File Offset: 0x0006FDF8
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

	// Token: 0x06001477 RID: 5239 RVA: 0x00071C78 File Offset: 0x0006FE78
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

	// Token: 0x06001478 RID: 5240 RVA: 0x00071CA8 File Offset: 0x0006FEA8
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

	// Token: 0x06001479 RID: 5241 RVA: 0x00071D44 File Offset: 0x0006FF44
	private void OpenDaemonHackGameplay(USkeletalMeshComponent meshComp)
	{
		TsInteractionUtils.RegisterOpenViewName(EUiViewName.GolemHackingGameView);
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("LucyIdle2Games");
		int configId = 0;
		configId = GolemHackingController.Instance.OpenGameplayView(intArrayConfig.ToList<int>(), delegate(bool result)
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

	// Token: 0x0600147A RID: 5242 RVA: 0x00071DB0 File Offset: 0x0006FFB0
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

	// Token: 0x0600147B RID: 5243 RVA: 0x00071E0C File Offset: 0x0007000C
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

	// Token: 0x0600147C RID: 5244 RVA: 0x00071E64 File Offset: 0x00070064
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

	// Token: 0x0600147D RID: 5245 RVA: 0x00071EB4 File Offset: 0x000700B4
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

	// Token: 0x0600147E RID: 5246 RVA: 0x00071F07 File Offset: 0x00070107
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateOpenSimpleGameplay._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateOpenSimpleGameplay.TsAnimNotifyStateOpenSimpleGameplay_C");
		}
		return TsAnimNotifyStateOpenSimpleGameplay._ClassPtr;
	}

	// Token: 0x0600147F RID: 5247 RVA: 0x00071F2C File Offset: 0x0007012C
	public TsAnimNotifyStateOpenSimpleGameplay() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateOpenSimpleGameplay.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001480 RID: 5248 RVA: 0x00071F54 File Offset: 0x00070154
	public TsAnimNotifyStateOpenSimpleGameplay(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateOpenSimpleGameplay.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001481 RID: 5249 RVA: 0x00071F87 File Offset: 0x00070187
	protected TsAnimNotifyStateOpenSimpleGameplay(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001482 RID: 5250 RVA: 0x00071F9C File Offset: 0x0007019C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001483 RID: 5251 RVA: 0x00071FD8 File Offset: 0x000701D8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001484 RID: 5252 RVA: 0x0007200B File Offset: 0x0007020B
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000E94 RID: 3732
	private static readonly Dictionary<EANSGameplayType, ESimpleGameplayType> ansGameplayTypeMap = new Dictionary<EANSGameplayType, ESimpleGameplayType>
	{
		{
			EANSGameplayType.魔偶骇入,
			ESimpleGameplayType.DaemonHack
		}
	};

	// Token: 0x04000E95 RID: 3733
	private static readonly Dictionary<EInputAction, string> inputActionMap = new Dictionary<EInputAction, string>
	{
		{
			EInputAction.通用交互,
			"通用交互"
		}
	};

	// Token: 0x04000E96 RID: 3734
	private readonly Dictionary<USkeletalMeshComponent, AnsInstanceState> StateMap = new Dictionary<USkeletalMeshComponent, AnsInstanceState>();

	// Token: 0x04000E97 RID: 3735
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateOpenSimpleGameplay.TsAnimNotifyStateOpenSimpleGameplay_C";

	// Token: 0x04000E98 RID: 3736
	private static IntPtr _ClassPtr;

	// Token: 0x04000E99 RID: 3737
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000E9A RID: 3738
	private static int __PropertyOffset_InteractInfos;

	// Token: 0x04000E9B RID: 3739
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<SAnimNotifyInteractInfo> _InteractInfos;

	// Token: 0x04000E9C RID: 3740
	private static int __PropertyOffset_GameplayType;

	// Token: 0x04000E9D RID: 3741
	private static int __PropertyOffset_SkillInfos;

	// Token: 0x04000E9E RID: 3742
	[Nullable(2)]
	private TArray<SGameplayResultSkillInfo> _SkillInfos;
}
