using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Utils;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000D0 RID: 208
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskWander.TsTaskWander_C")]
public class TsTaskWander : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000244 RID: 580
	// (get) Token: 0x06000C56 RID: 3158 RVA: 0x0003EF33 File Offset: 0x0003D133
	// (set) Token: 0x06000C57 RID: 3159 RVA: 0x0003EF43 File Offset: 0x0003D143
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float RandomRadius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskWander.__PropertyOffset_RandomRadius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskWander.__PropertyOffset_RandomRadius) = value;
		}
	}

	// Token: 0x17000245 RID: 581
	// (get) Token: 0x06000C58 RID: 3160 RVA: 0x0003EF54 File Offset: 0x0003D154
	// (set) Token: 0x06000C59 RID: 3161 RVA: 0x0003EF64 File Offset: 0x0003D164
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MinWanderDistance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskWander.__PropertyOffset_MinWanderDistance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskWander.__PropertyOffset_MinWanderDistance) = value;
		}
	}

	// Token: 0x17000246 RID: 582
	// (get) Token: 0x06000C5A RID: 3162 RVA: 0x0003EF75 File Offset: 0x0003D175
	// (set) Token: 0x06000C5B RID: 3163 RVA: 0x0003EF85 File Offset: 0x0003D185
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MaxNavigationMillisecond
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskWander.__PropertyOffset_MaxNavigationMillisecond);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskWander.__PropertyOffset_MaxNavigationMillisecond) = value;
		}
	}

	// Token: 0x17000247 RID: 583
	// (get) Token: 0x06000C5C RID: 3164 RVA: 0x0003EF96 File Offset: 0x0003D196
	// (set) Token: 0x06000C5D RID: 3165 RVA: 0x0003EFA6 File Offset: 0x0003D1A6
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool MoveStateForWanderOrReset
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskWander.__PropertyOffset_MoveStateForWanderOrReset) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskWander.__PropertyOffset_MoveStateForWanderOrReset) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000248 RID: 584
	// (get) Token: 0x06000C5E RID: 3166 RVA: 0x0003EFB7 File Offset: 0x0003D1B7
	// (set) Token: 0x06000C5F RID: 3167 RVA: 0x0003EFC7 File Offset: 0x0003D1C7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MaxStopTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskWander.__PropertyOffset_MaxStopTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskWander.__PropertyOffset_MaxStopTime) = value;
		}
	}

	// Token: 0x17000249 RID: 585
	// (get) Token: 0x06000C60 RID: 3168 RVA: 0x0003EFD8 File Offset: 0x0003D1D8
	// (set) Token: 0x06000C61 RID: 3169 RVA: 0x0003EFE8 File Offset: 0x0003D1E8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float BlinkTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskWander.__PropertyOffset_BlinkTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskWander.__PropertyOffset_BlinkTime) = value;
		}
	}

	// Token: 0x1700024A RID: 586
	// (get) Token: 0x06000C62 RID: 3170 RVA: 0x0003EFF9 File Offset: 0x0003D1F9
	// (set) Token: 0x06000C63 RID: 3171 RVA: 0x0003F009 File Offset: 0x0003D209
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool UsePatrolPointPriority
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskWander.__PropertyOffset_UsePatrolPointPriority) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskWander.__PropertyOffset_UsePatrolPointPriority) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700024B RID: 587
	// (get) Token: 0x06000C64 RID: 3172 RVA: 0x0003F01C File Offset: 0x0003D21C
	// (set) Token: 0x06000C65 RID: 3173 RVA: 0x0003F055 File Offset: 0x0003D255
	[UProperty(EPropertyFlags.CPF_None)]
	public FSoftObjectPath ShowEffectDa
	{
		get
		{
			base.FastCheckIsValid();
			FSoftObjectPath result;
			if ((result = this._ShowEffectDa) == null)
			{
				result = (this._ShowEffectDa = new FSoftObjectPath(base.NativePtr + (IntPtr)TsTaskWander.__PropertyOffset_ShowEffectDa, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)TsTaskWander.__PropertyOffset_ShowEffectDa, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x1700024C RID: 588
	// (get) Token: 0x06000C66 RID: 3174 RVA: 0x0003F080 File Offset: 0x0003D280
	// (set) Token: 0x06000C67 RID: 3175 RVA: 0x0003F0B9 File Offset: 0x0003D2B9
	[UProperty(EPropertyFlags.CPF_None)]
	public FSoftObjectPath HideEffectDa
	{
		get
		{
			base.FastCheckIsValid();
			FSoftObjectPath result;
			if ((result = this._HideEffectDa) == null)
			{
				result = (this._HideEffectDa = new FSoftObjectPath(base.NativePtr + (IntPtr)TsTaskWander.__PropertyOffset_HideEffectDa, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)TsTaskWander.__PropertyOffset_HideEffectDa, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x1700024D RID: 589
	// (get) Token: 0x06000C68 RID: 3176 RVA: 0x0003F0E4 File Offset: 0x0003D2E4
	// (set) Token: 0x06000C69 RID: 3177 RVA: 0x0003F11D File Offset: 0x0003D31D
	[UProperty(EPropertyFlags.CPF_None)]
	public FSoftObjectPath ShowMaterialDa
	{
		get
		{
			base.FastCheckIsValid();
			FSoftObjectPath result;
			if ((result = this._ShowMaterialDa) == null)
			{
				result = (this._ShowMaterialDa = new FSoftObjectPath(base.NativePtr + (IntPtr)TsTaskWander.__PropertyOffset_ShowMaterialDa, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)TsTaskWander.__PropertyOffset_ShowMaterialDa, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x1700024E RID: 590
	// (get) Token: 0x06000C6A RID: 3178 RVA: 0x0003F148 File Offset: 0x0003D348
	// (set) Token: 0x06000C6B RID: 3179 RVA: 0x0003F181 File Offset: 0x0003D381
	[UProperty(EPropertyFlags.CPF_None)]
	public FSoftObjectPath HideMaterialDa
	{
		get
		{
			base.FastCheckIsValid();
			FSoftObjectPath result;
			if ((result = this._HideMaterialDa) == null)
			{
				result = (this._HideMaterialDa = new FSoftObjectPath(base.NativePtr + (IntPtr)TsTaskWander.__PropertyOffset_HideMaterialDa, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)TsTaskWander.__PropertyOffset_HideMaterialDa, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x1700024F RID: 591
	// (get) Token: 0x06000C6C RID: 3180 RVA: 0x0003F1A9 File Offset: 0x0003D3A9
	// (set) Token: 0x06000C6D RID: 3181 RVA: 0x0003F1B9 File Offset: 0x0003D3B9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool Debug
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskWander.__PropertyOffset_Debug) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskWander.__PropertyOffset_Debug) = (value ? 1 : 0);
		}
	}

	// Token: 0x06000C6E RID: 3182 RVA: 0x0003F1CC File Offset: 0x0003D3CC
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsRandomRadius = this.RandomRadius;
			this.TsMinWanderDistance = this.MinWanderDistance;
			this.TsMaxNavigationMillisecond = this.MaxNavigationMillisecond;
			this.TsMoveStateForWanderOrReset = this.MoveStateForWanderOrReset;
			this.TsMaxStopTime = this.MaxStopTime;
			this.TsBlinkTime = this.BlinkTime;
			this.TsUsePatrolPointPriority = this.UsePatrolPointPriority;
			this.TsShowEffectDa = this.ShowEffectDa.AssetPathName.ToString();
			this.TsShowEffectDa = ((this.TsShowEffectDa == "None") ? "" : this.TsShowEffectDa);
			this.TsHideEffectDa = this.HideEffectDa.AssetPathName.ToString();
			this.TsHideEffectDa = ((this.TsHideEffectDa == "None") ? "" : this.TsHideEffectDa);
			this.TsShowMaterialDa = this.ShowMaterialDa.AssetPathName.ToString();
			this.TsHideMaterialDa = this.HideMaterialDa.AssetPathName.ToString();
			this.TsDebug = this.Debug;
			this.SelectedTargetLocation = global::Vector.Create();
			this.CacheVector = global::Vector.Create();
		}
	}

	// Token: 0x06000C6F RID: 3183 RVA: 0x0003F330 File Offset: 0x0003D530
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveExecuteAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000C70 RID: 3184 RVA: 0x0003F3CC File Offset: 0x0003D5CC
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "[TsTaskWander]错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.FoundPath = false;
			return;
		}
		AiWanderInfos aiWanderInfos = aiController.AiWanderInfos;
		AiWander? aiWander = (aiWanderInfos != null) ? aiWanderInfos.AiWander : null;
		if (aiWander == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.BehaviorTree;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "[TsTaskWander]没有配置AiWander";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("AiBaseId", aiController.AiBase.Value.Id);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			this.MoveStateActural = 2;
		}
		else
		{
			this.MoveStateActural = (this.TsMoveStateForWanderOrReset ? aiWander.Value.WanderMoveState : aiWander.Value.ResetMoveState);
			this.TsShowEffectDa = aiWander.Value.ShowEffectDaPath;
			this.TsHideEffectDa = aiWander.Value.HideEffectDaPath;
			this.TsShowMaterialDa = aiWander.Value.ShowMaterialDaPath;
			this.TsHideMaterialDa = aiWander.Value.HideMaterialDaPath;
		}
		if (aiController.AiWanderRadiusConfig != null)
		{
			this.TsRandomRadius = aiController.AiWanderRadiusConfig.Value.RandomRadius;
			this.TsMinWanderDistance = aiController.AiWanderRadiusConfig.Value.MinWanderDistance;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		global::Vector vector = global::Vector.Create();
		if (this.TsUsePatrolPointPriority && aiController.AiPatrol.HasPatrolConfig())
		{
			global::Vector lastPatrolPoint = aiController.AiPatrol.GetLastPatrolPoint();
			if (lastPatrolPoint != null)
			{
				vector.DeepCopy(lastPatrolPoint);
			}
			else
			{
				vector.DeepCopy(aiController.CharActorComp.GetInitLocation());
			}
		}
		else
		{
			vector.DeepCopy(aiController.CharActorComp.GetInitLocation());
		}
		this.FindNavPoint(ownerController, vector, charActorComp);
		this.CheckPreLocationDistance(charActorComp, 0f);
		switch (this.MoveStateActural)
		{
		case 1:
		case 2:
		{
			if (this.NavigationPath == null)
			{
				this.NavigationPath = new List<global::Vector>();
			}
			BaseUnifiedStateComponent component = charActorComp.Entity.GetComponent<BaseUnifiedStateComponent>();
			if (component != null && component.PositionState == ECharPositionState.Ground)
			{
				this.CacheVector.DeepCopy(charActorComp.FloorLocation);
			}
			else
			{
				this.CacheVector.DeepCopy(charActorComp.ActorLocationProxy);
			}
			this.FoundPath = AiControllerLibrary.NavigationFindPath(ownerController, this.CacheVector.ToUeVector(false), this.SelectedTargetLocation.ToUeVector(false), this.NavigationPath, null, null);
			if (!this.FoundPath)
			{
				if (this.TsMoveStateForWanderOrReset)
				{
					base.Finish(false);
					return;
				}
				if (this.BlinkMoveBegin(charActorComp, true))
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.BehaviorTree;
					ELogAuthor author3 = ELogAuthor.LJM;
					string message3 = "[TsTaskWander]AiWander怪物复位寻路失败";
					ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
					instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
					return;
				}
			}
			this.CurrentNavigationIndex = 1;
			this.NavigationEndTime = Time.Instance.WorldTime + (double)this.TsMaxNavigationMillisecond;
			BaseUnifiedStateComponent baseUnifiedStateComponent = charActorComp.Entity.CheckGetComponent<BaseUnifiedStateComponent>();
			if (baseUnifiedStateComponent.Valid)
			{
				int moveStateActural = this.MoveStateActural;
				if (moveStateActural != 1)
				{
					if (moveStateActural == 2)
					{
						baseUnifiedStateComponent.SetMoveState(ECharMoveState.Run);
					}
				}
				else
				{
					baseUnifiedStateComponent.SetMoveState(ECharMoveState.Walk);
				}
			}
			break;
		}
		case 3:
			this.BlinkMoveBegin(charActorComp, false);
			break;
		case 4:
			this.UseSkill(charActorComp, aiWander);
			break;
		}
		this.SetAiSceneEnable(aiController, false);
	}

	// Token: 0x06000C71 RID: 3185 RVA: 0x0003F768 File Offset: 0x0003D968
	private void FindNavPoint([Nullable(2)] AAIController ownerController, global::Vector initLocation, CharacterActorComponent character)
	{
		int i = 5;
		BaseMoveComponent moveComp = character.MoveComp;
		bool flag = moveComp == null || moveComp.IsStandardGravity;
		while (i > 0)
		{
			FVectorDouble fvectorDouble = default(FVectorDouble);
			bool flag2;
			if (flag)
			{
				FVectorDouble fvectorDouble2 = initLocation.ToUeVector(false);
				flag2 = UNavigationSystemV1.D_K2_GetRandomLocationInNavigableRadius(ownerController, fvectorDouble2, ref fvectorDouble, this.TsRandomRadius, null, default(TSubclassOf<UNavigationQueryFilter>));
				this.SelectedTargetLocation.FromUeVector(fvectorDouble);
			}
			else
			{
				flag2 = true;
				float randomFloatNumber = MathUtils.Instance.GetRandomFloatNumber(0f, 6.2831855f);
				this.SelectedTargetLocation.Set(Math.Cos((double)randomFloatNumber), Math.Sin((double)randomFloatNumber), 0.0);
				character.ActorQuatProxy.RotateVector(this.SelectedTargetLocation, this.SelectedTargetLocation);
				double inB = Math.Sqrt((double)MathUtils.Instance.GetRandomFloatNumber(this.TsMinWanderDistance * this.TsMinWanderDistance, this.TsRandomRadius * this.TsRandomRadius));
				this.SelectedTargetLocation.MultiplyEqual(inB);
				this.SelectedTargetLocation.AdditionEqual(character.FloorLocation);
			}
			if (flag2 && global::Vector.DistSquared(this.SelectedTargetLocation, character.ActorLocationProxy) > (double)(this.TsMinWanderDistance * this.TsMinWanderDistance))
			{
				break;
			}
			i--;
		}
		bool flag3 = false;
		if (global::Vector.DistSquared(this.SelectedTargetLocation, character.ActorLocationProxy) <= (double)(this.TsRandomRadius * this.TsRandomRadius))
		{
			flag3 = true;
		}
		if (!flag3)
		{
			this.FoundPath = false;
			this.NavigationPath = null;
			this.SelectedTargetLocation.DeepCopy(initLocation);
		}
	}

	// Token: 0x06000C72 RID: 3186 RVA: 0x0003F8E8 File Offset: 0x0003DAE8
	private void SetAiSceneEnable(AiController aiController, bool enable)
	{
		if (!this.TsMoveStateForWanderOrReset)
		{
			AiPerception aiPerception = aiController.AiPerception as AiPerception;
			if (aiPerception != null)
			{
				aiPerception.SetAllAiSenseEnable(enable);
			}
		}
	}

	// Token: 0x06000C73 RID: 3187 RVA: 0x0003F914 File Offset: 0x0003DB14
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveTickAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
			ptr2->DeltaSeconds = deltaSeconds;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000C74 RID: 3188 RVA: 0x0003F9B4 File Offset: 0x0003DBB4
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			base.FinishExecute(false);
			return;
		}
		if (!this.FoundPath && !this.InBlink)
		{
			base.Finish(false);
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		if (this.TsDebug)
		{
			this.DrawDebugPath(charActorComp);
		}
		if (this.InBlink)
		{
			this.BlinkMoveTick(charActorComp, deltaSeconds);
			return;
		}
		if (!this.TsMoveStateForWanderOrReset && Time.Instance.WorldTime > this.NavigationEndTime)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[TsTaskWander]AiWander怪物复位超时，瞬移回目标点";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (this.BlinkMoveBegin(charActorComp, true))
			{
				return;
			}
		}
		global::Vector vector = global::Vector.Create(this.NavigationPath[this.CurrentNavigationIndex]);
		vector.Subtraction(charActorComp.ActorLocationProxy, vector);
		vector.Z = 0.0;
		double num = vector.Size();
		if (num <= (double)aiController.AiWanderInfos.AiWander.Value.CompleteDistance)
		{
			this.CurrentNavigationIndex++;
			if (this.CurrentNavigationIndex == this.NavigationPath.Count)
			{
				base.Finish(true);
				return;
			}
		}
		vector.DivisionEqual(num);
		charActorComp.SetInputDirect(vector, true);
		AiControllerLibrary.TurnToDirect(charActorComp, vector, aiController.AiWanderInfos.AiWander.Value.TurnSpeed, false, 0f);
		if (!this.TsMoveStateForWanderOrReset && !this.CheckPreLocationDistance(charActorComp, deltaSeconds))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.BehaviorTree;
			ELogAuthor author2 = ELogAuthor.LJM;
			string message2 = "[TsTaskWander]AiWander怪物游荡卡住超时，瞬移回目标点";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			this.BlinkMoveBegin(charActorComp, true);
		}
	}

	// Token: 0x06000C75 RID: 3189 RVA: 0x0003FB84 File Offset: 0x0003DD84
	protected override void OnClear()
	{
		TsAiController tsAiController = base.AIOwner as TsAiController;
		if (tsAiController != null)
		{
			AiControllerLibrary.ClearInput(tsAiController);
			this.SetAiSceneEnable(tsAiController.AiController, true);
			TsBaseCharacter actor = tsAiController.AiController.CharActorComp.Actor;
			if (this.InBlink)
			{
				actor.SetActorEnableCollision(true);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.BehaviorTree;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "[TsTaskWander]AiWander[OnClear]怪物闪烁导致Actor碰撞为True";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor:", actor);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			CharRenderingComponent charRenderingComponent = actor.CharRenderingComponent;
			int? num = this.HideMaterialData;
			int num2 = 0;
			if (num.GetValueOrDefault() > num2 & num != null)
			{
				charRenderingComponent.RemoveMaterialControllerData(this.HideMaterialData.Value);
				charRenderingComponent.ResetAllRenderingState();
			}
			num = this.ShowMaterialData;
			num2 = 0;
			if (num.GetValueOrDefault() > num2 & num != null)
			{
				charRenderingComponent.RemoveMaterialControllerData(this.ShowMaterialData.Value);
				charRenderingComponent.ResetAllRenderingState();
			}
			if (!this.TsMoveStateForWanderOrReset)
			{
				Entity entity = tsAiController.AiController.CharActorComp.Entity;
				EventSystem.Instance.EmitWithTarget(entity, EEventName.AiTaskWanderForResetEnd);
			}
		}
		this.NavigationPath = null;
		this.FoundPath = false;
		this.InBlink = false;
		this.BlinkTimeCount = 0f;
		this.StopTimeCount = 0f;
		this.HideMaterialData = null;
		this.ShowMaterialData = null;
	}

	// Token: 0x06000C76 RID: 3190 RVA: 0x0003FCE4 File Offset: 0x0003DEE4
	private bool CheckPreLocationDistance(CharacterActorComponent actor, float deltaSeconds)
	{
		if (this.PreLocation == null)
		{
			this.PreLocation = global::Vector.Create(actor.ActorLocation);
			this.StopTimeCount = 0f;
			return true;
		}
		global::Vector actorLocationProxy = actor.ActorLocationProxy;
		if (global::Vector.DistSquared(this.PreLocation, actorLocationProxy) < 0.0010000000474974513)
		{
			this.StopTimeCount += deltaSeconds;
		}
		else
		{
			this.StopTimeCount = 0f;
		}
		this.PreLocation.DeepCopy(actorLocationProxy);
		return this.StopTimeCount <= this.TsMaxStopTime;
	}

	// Token: 0x06000C77 RID: 3191 RVA: 0x0003FD74 File Offset: 0x0003DF74
	private bool BlinkMoveBegin(CharacterActorComponent actor, bool bForce = false)
	{
		if (this.MoveStateActural == 3 || bForce)
		{
			if (bForce)
			{
				this.MoveStateActural = 3;
			}
			this.InBlink = true;
			this.BlinkTimeCount = 0f;
			this.ShowMaterialData = null;
			this.HideMaterialData = null;
			actor.Actor.SetActorEnableCollision(false);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[TsTaskWander]AiWander[BlinkMoveBegin]怪物闪烁导致Actor碰撞为False";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor:", actor.Actor.GetName());
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (this.TsHideEffectDa != "")
			{
				EffectSystem instance2 = EffectSystem.Instance;
				UObject world = GlobalData.World;
				FTransformDouble? ftransformDouble = new FTransformDouble?(MathUtils.Instance.DefaultTransformDouble);
				int id = instance2.SpawnEffect(world, ftransformDouble, this.TsHideEffectDa, "[TsTaskWander.BlinkMoveBegin] hideEffect", new EffectContext(new int?(actor.Entity.Id), null, false), EEffectType.Scene, null, null, null, false, false);
				OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(id);
				if (effectActor.IsValid())
				{
					FHitResult fhitResult = null;
					OneOf<KuroEffectActorHandle, AActor> self = effectActor;
					FVectorDouble actorLocation = actor.ActorLocation;
					self.D_K2_SetActorLocation(actorLocation, false, ref fhitResult, false);
				}
				else
				{
					Log instance3 = Log.Instance;
					ELogModule module2 = ELogModule.BehaviorTree;
					ELogAuthor author2 = ELogAuthor.LJM;
					string message2 = "[TsTaskWander]AiWander瞬移隐藏特效生成失败。";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Type", actor.Actor.GetName());
					instance3.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
			}
			if (this.TsHideMaterialDa != "")
			{
				ResourceSystem.Instance.LoadAsync<PD_CharacterControllerData_C>(this.TsHideMaterialDa, delegate([Nullable(2)] PD_CharacterControllerData_C hideMaterial, string _)
				{
					if (hideMaterial != null)
					{
						this.HideMaterialData = new int?(actor.Actor.CharRenderingComponent.AddMaterialControllerData(hideMaterial));
						return;
					}
					this.HideMaterialData = new int?(0);
					Log instance4 = Log.Instance;
					ELogModule module3 = ELogModule.BehaviorTree;
					ELogAuthor author3 = ELogAuthor.LJM;
					string message3 = "[TsTaskWander]AiWander瞬移隐藏材质生成失败";
					ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("Type", actor.Actor.GetName());
					instance4.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				}, 100, "js_undefined");
			}
			else
			{
				this.HideMaterialData = new int?(-1);
			}
			return true;
		}
		return false;
	}

	// Token: 0x06000C78 RID: 3192 RVA: 0x0003FF38 File Offset: 0x0003E138
	private void BlinkMoveTick(CharacterActorComponent actor, float deltaSeconds)
	{
		this.BlinkTimeCount += deltaSeconds;
		if (this.BlinkTimeCount >= this.TsBlinkTime - 1f && this.ShowMaterialData == null)
		{
			actor.SetActorLocation(this.SelectedTargetLocation.ToUeVector(false), "脱战节点.执行瞬移重置位置", false);
			actor.FixBornLocation("脱战节点.修正角色地面位置", true, null, false, false, true);
			actor.Actor.SetActorEnableCollision(true);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[TsTaskWander]AiWander[BlinkMoveTick]怪物闪烁导致Actor碰撞为True";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor:", actor.Actor.GetName());
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.ResetAiInfo(actor);
			if (this.TsShowEffectDa != "")
			{
				EffectSystem instance2 = EffectSystem.Instance;
				UObject world = GlobalData.World;
				FTransformDouble? ftransformDouble = new FTransformDouble?(MathUtils.Instance.DefaultTransformDouble);
				int id = instance2.SpawnEffect(world, ftransformDouble, this.TsShowEffectDa, "[TsTaskWander.BlinkMoveTick] showEffect", new EffectContext(new int?(actor.Entity.Id), null, false), EEffectType.Scene, null, null, null, false, false);
				OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(id);
				if (effectActor.IsValid())
				{
					FHitResult fhitResult = null;
					OneOf<KuroEffectActorHandle, AActor> self = effectActor;
					FVectorDouble actorLocation = actor.ActorLocation;
					self.D_K2_SetActorLocation(actorLocation, false, ref fhitResult, false);
				}
				else
				{
					Log instance3 = Log.Instance;
					ELogModule module2 = ELogModule.BehaviorTree;
					ELogAuthor author2 = ELogAuthor.LJM;
					string message2 = "[TsTaskWander]AiWander瞬移显示特效生成失败";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Type", actor.Actor.GetName());
					instance3.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
			}
			if (this.HideMaterialData != null && this.HideMaterialData.Value > 0)
			{
				actor.Actor.CharRenderingComponent.RemoveMaterialControllerData(this.HideMaterialData.Value);
				this.HideMaterialData = null;
			}
			if (this.TsShowMaterialDa != "")
			{
				ResourceSystem.Instance.LoadAsync<PD_CharacterControllerData_C>(this.TsShowMaterialDa, delegate([Nullable(2)] PD_CharacterControllerData_C showMaterial, string _)
				{
					if (showMaterial != null)
					{
						this.ShowMaterialData = new int?(actor.Actor.CharRenderingComponent.AddMaterialControllerData(showMaterial));
						return;
					}
					this.ShowMaterialData = new int?(-1);
					Log instance4 = Log.Instance;
					ELogModule module3 = ELogModule.BehaviorTree;
					ELogAuthor author3 = ELogAuthor.LJM;
					string message3 = "[TsTaskWander]AiWander瞬移显示材质生成失败";
					ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("Type", actor.Actor.GetName());
					instance4.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				}, 100, "js_undefined");
			}
			else
			{
				this.ShowMaterialData = new int?(-1);
			}
			actor.SetInputDirect(global::Vector.ZeroVectorProxy, false);
		}
		if (this.BlinkTimeCount >= this.TsBlinkTime)
		{
			this.BlinkMoveEnd(actor);
		}
	}

	// Token: 0x06000C79 RID: 3193 RVA: 0x000401A4 File Offset: 0x0003E3A4
	private bool BlinkMoveEnd(CharacterActorComponent actor)
	{
		if (this.InBlink)
		{
			this.InBlink = false;
			if (!actor.Actor.bActorEnableCollision)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.BehaviorTree;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "[TsTaskWander]AiWander[BlinkMoveEnd]怪物闪烁此刻Actor碰撞不应该为False,查看[BlinkMoveTick]是否置为True";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor:", actor.Actor.GetName());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			if (this.ShowMaterialData != null && this.ShowMaterialData.Value > 0)
			{
				actor.Actor.CharRenderingComponent.RemoveMaterialControllerData(this.ShowMaterialData.Value);
				this.ShowMaterialData = null;
			}
			actor.Actor.CharRenderingComponent.ResetAllRenderingState();
			base.Finish(true);
			return true;
		}
		return false;
	}

	// Token: 0x06000C7A RID: 3194 RVA: 0x00040260 File Offset: 0x0003E460
	private void UseSkill(CharacterActorComponent actor, AiWander? aiWander)
	{
		CharacterSkillComponent component = actor.Entity.GetComponent<CharacterSkillComponent>();
		if (!component.Valid || aiWander == null)
		{
			base.Finish(false);
			return;
		}
		bool bSuccess = component.BeginSkill(aiWander.Value.MoveStateGA, new SkillParam
		{
			Reason = "TsTaskWander.UseSkill"
		});
		base.Finish(bSuccess);
	}

	// Token: 0x06000C7B RID: 3195 RVA: 0x000402C0 File Offset: 0x0003E4C0
	private void ResetAiInfo(CharacterActorComponent actor)
	{
		CreatureDataComponent component = actor.Entity.GetComponent<CreatureDataComponent>();
		FRotator? frotator = (component != null) ? new FRotator?(component.GetRotation()) : null;
		if (frotator != null)
		{
			actor.SetActorRotation(frotator.Value, "脱战节点.重置为基础方法", false);
		}
	}

	// Token: 0x06000C7C RID: 3196 RVA: 0x00040310 File Offset: 0x0003E510
	private void DrawDebugPath(CharacterActorComponent actor)
	{
		int count = this.NavigationPath.Count;
		if (count == 0)
		{
			return;
		}
		int num = 0;
		UKismetSystemLibrary.D_DrawDebugSphere(actor.Actor, this.SelectedTargetLocation.ToUeVector(false), 40f, 10, new FLinearColor?(ColorUtils.LinearGreen), 0f, 2f);
		UKismetSystemLibrary.D_DrawDebugLine(actor.Actor, actor.ActorLocation, this.SelectedTargetLocation.ToUeVector(false), ColorUtils.LinearGreen, 0f, 2f);
		foreach (global::Vector vector in this.NavigationPath)
		{
			UKismetSystemLibrary.D_DrawDebugSphere(actor.Actor, vector.ToUeVector(false), 30f, 10, new FLinearColor?(ColorUtils.LinearRed), 0f, 2f);
			num++;
			if (num < count)
			{
				UKismetSystemLibrary.D_DrawDebugLine(actor.Actor, vector.ToUeVector(false), this.NavigationPath[num].ToUeVector(false), ColorUtils.LinearRed, 0f, 2f);
			}
		}
	}

	// Token: 0x06000C7D RID: 3197 RVA: 0x00040434 File Offset: 0x0003E634
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskWander._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskWander.TsTaskWander_C");
		}
		return TsTaskWander._ClassPtr;
	}

	// Token: 0x06000C7E RID: 3198 RVA: 0x00040458 File Offset: 0x0003E658
	public TsTaskWander() : this(BuiltinUtils.AllocNativeUObject(TsTaskWander.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000C7F RID: 3199 RVA: 0x00040480 File Offset: 0x0003E680
	public TsTaskWander(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskWander.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000C80 RID: 3200 RVA: 0x000404B4 File Offset: 0x0003E6B4
	protected TsTaskWander(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000C81 RID: 3201 RVA: 0x0004050C File Offset: 0x0003E70C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000C82 RID: 3202 RVA: 0x0004053C File Offset: 0x0003E73C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x040009D4 RID: 2516
	private const string NONE_PATH = "None";

	// Token: 0x040009D5 RID: 2517
	private const int BLINK_STATE = 3;

	// Token: 0x040009D6 RID: 2518
	private const int SKILL_STATE = 4;

	// Token: 0x040009D7 RID: 2519
	private global::Vector SelectedTargetLocation = global::Vector.Create();

	// Token: 0x040009D8 RID: 2520
	private bool FoundPath;

	// Token: 0x040009D9 RID: 2521
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<global::Vector> NavigationPath;

	// Token: 0x040009DA RID: 2522
	private int CurrentNavigationIndex;

	// Token: 0x040009DB RID: 2523
	private double NavigationEndTime;

	// Token: 0x040009DC RID: 2524
	private bool InBlink;

	// Token: 0x040009DD RID: 2525
	private float StopTimeCount;

	// Token: 0x040009DE RID: 2526
	private float BlinkTimeCount;

	// Token: 0x040009DF RID: 2527
	[Nullable(2)]
	private global::Vector PreLocation;

	// Token: 0x040009E0 RID: 2528
	private int? ShowMaterialData;

	// Token: 0x040009E1 RID: 2529
	private int? HideMaterialData;

	// Token: 0x040009E2 RID: 2530
	private int MoveStateActural;

	// Token: 0x040009E3 RID: 2531
	private bool IsInitTsVariables;

	// Token: 0x040009E4 RID: 2532
	private float TsRandomRadius;

	// Token: 0x040009E5 RID: 2533
	private float TsMinWanderDistance;

	// Token: 0x040009E6 RID: 2534
	private float TsMaxNavigationMillisecond;

	// Token: 0x040009E7 RID: 2535
	private bool TsMoveStateForWanderOrReset;

	// Token: 0x040009E8 RID: 2536
	private float TsMaxStopTime;

	// Token: 0x040009E9 RID: 2537
	private float TsBlinkTime;

	// Token: 0x040009EA RID: 2538
	private bool TsUsePatrolPointPriority;

	// Token: 0x040009EB RID: 2539
	private string TsShowEffectDa = "";

	// Token: 0x040009EC RID: 2540
	private string TsHideEffectDa = "";

	// Token: 0x040009ED RID: 2541
	private string TsShowMaterialDa = "";

	// Token: 0x040009EE RID: 2542
	private string TsHideMaterialDa = "";

	// Token: 0x040009EF RID: 2543
	private bool TsDebug;

	// Token: 0x040009F0 RID: 2544
	private global::Vector CacheVector = global::Vector.Create();

	// Token: 0x040009F1 RID: 2545
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskWander.TsTaskWander_C";

	// Token: 0x040009F2 RID: 2546
	private static IntPtr _ClassPtr;

	// Token: 0x040009F3 RID: 2547
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040009F4 RID: 2548
	private static int __PropertyOffset_RandomRadius;

	// Token: 0x040009F5 RID: 2549
	private static int __PropertyOffset_MinWanderDistance;

	// Token: 0x040009F6 RID: 2550
	private static int __PropertyOffset_MaxNavigationMillisecond;

	// Token: 0x040009F7 RID: 2551
	private static int __PropertyOffset_MoveStateForWanderOrReset;

	// Token: 0x040009F8 RID: 2552
	private static int __PropertyOffset_MaxStopTime;

	// Token: 0x040009F9 RID: 2553
	private static int __PropertyOffset_BlinkTime;

	// Token: 0x040009FA RID: 2554
	private static int __PropertyOffset_UsePatrolPointPriority;

	// Token: 0x040009FB RID: 2555
	private static int __PropertyOffset_ShowEffectDa;

	// Token: 0x040009FC RID: 2556
	[Nullable(2)]
	private FSoftObjectPath _ShowEffectDa;

	// Token: 0x040009FD RID: 2557
	private static int __PropertyOffset_HideEffectDa;

	// Token: 0x040009FE RID: 2558
	[Nullable(2)]
	private FSoftObjectPath _HideEffectDa;

	// Token: 0x040009FF RID: 2559
	private static int __PropertyOffset_ShowMaterialDa;

	// Token: 0x04000A00 RID: 2560
	[Nullable(2)]
	private FSoftObjectPath _ShowMaterialDa;

	// Token: 0x04000A01 RID: 2561
	private static int __PropertyOffset_HideMaterialDa;

	// Token: 0x04000A02 RID: 2562
	[Nullable(2)]
	private FSoftObjectPath _HideMaterialDa;

	// Token: 0x04000A03 RID: 2563
	private static int __PropertyOffset_Debug;
}
