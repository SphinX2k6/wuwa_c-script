using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200006B RID: 107
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskNpcEnableEntityLookAt.TsTaskNpcEnableEntityLookAt_C")]
public class TsTaskNpcEnableEntityLookAt : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170000B4 RID: 180
	// (get) Token: 0x0600048C RID: 1164 RVA: 0x00015B15 File Offset: 0x00013D15
	// (set) Token: 0x0600048D RID: 1165 RVA: 0x00015B29 File Offset: 0x00013D29
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string Key
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskNpcEnableEntityLookAt.__PropertyOffset_Key)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskNpcEnableEntityLookAt.__PropertyOffset_Key)), value);
		}
	}

	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x0600048E RID: 1166 RVA: 0x00015B40 File Offset: 0x00013D40
	// (set) Token: 0x0600048F RID: 1167 RVA: 0x00015B79 File Offset: 0x00013D79
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<int> SourcePbDataId
	{
		get
		{
			base.FastCheckIsValid();
			TArray<int> result;
			if ((result = this._SourcePbDataId) == null)
			{
				result = (this._SourcePbDataId = new TArray<int>(base.NativePtr + (IntPtr)TsTaskNpcEnableEntityLookAt.__PropertyOffset_SourcePbDataId, this));
			}
			return result;
		}
		set
		{
			this.SourcePbDataId.CopyAssign(value);
		}
	}

	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x06000490 RID: 1168 RVA: 0x00015B88 File Offset: 0x00013D88
	// (set) Token: 0x06000491 RID: 1169 RVA: 0x00015BC1 File Offset: 0x00013DC1
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<int> TargetPbDataId
	{
		get
		{
			base.FastCheckIsValid();
			TArray<int> result;
			if ((result = this._TargetPbDataId) == null)
			{
				result = (this._TargetPbDataId = new TArray<int>(base.NativePtr + (IntPtr)TsTaskNpcEnableEntityLookAt.__PropertyOffset_TargetPbDataId, this));
			}
			return result;
		}
		set
		{
			this.TargetPbDataId.CopyAssign(value);
		}
	}

	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x06000492 RID: 1170 RVA: 0x00015BD0 File Offset: 0x00013DD0
	// (set) Token: 0x06000493 RID: 1171 RVA: 0x00015C09 File Offset: 0x00013E09
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<FVector> TargetPosition
	{
		get
		{
			base.FastCheckIsValid();
			TArray<FVector> result;
			if ((result = this._TargetPosition) == null)
			{
				result = (this._TargetPosition = new TArray<FVector>(base.NativePtr + (IntPtr)TsTaskNpcEnableEntityLookAt.__PropertyOffset_TargetPosition, this));
			}
			return result;
		}
		set
		{
			this.TargetPosition.CopyAssign(value);
		}
	}

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x06000494 RID: 1172 RVA: 0x00015C18 File Offset: 0x00013E18
	// (set) Token: 0x06000495 RID: 1173 RVA: 0x00015C51 File Offset: 0x00013E51
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<float> MaxDistance
	{
		get
		{
			base.FastCheckIsValid();
			TArray<float> result;
			if ((result = this._MaxDistance) == null)
			{
				result = (this._MaxDistance = new TArray<float>(base.NativePtr + (IntPtr)TsTaskNpcEnableEntityLookAt.__PropertyOffset_MaxDistance, this));
			}
			return result;
		}
		set
		{
			this.MaxDistance.CopyAssign(value);
		}
	}

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x06000496 RID: 1174 RVA: 0x00015C60 File Offset: 0x00013E60
	// (set) Token: 0x06000497 RID: 1175 RVA: 0x00015C99 File Offset: 0x00013E99
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<float> MaxAngle
	{
		get
		{
			base.FastCheckIsValid();
			TArray<float> result;
			if ((result = this._MaxAngle) == null)
			{
				result = (this._MaxAngle = new TArray<float>(base.NativePtr + (IntPtr)TsTaskNpcEnableEntityLookAt.__PropertyOffset_MaxAngle, this));
			}
			return result;
		}
		set
		{
			this.MaxAngle.CopyAssign(value);
		}
	}

	// Token: 0x06000498 RID: 1176 RVA: 0x00015CA8 File Offset: 0x00013EA8
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

	// Token: 0x06000499 RID: 1177 RVA: 0x00015D44 File Offset: 0x00013F44
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		if (this.Key == "")
		{
			base.FinishExecute(true);
			return;
		}
		if (NpcPerformController.Instance.EntityLookAtCacheForKey.ContainsKey(this.Key))
		{
			base.FinishExecute(true);
			return;
		}
		int num = this.TargetPbDataId.Num();
		int num2 = this.SourcePbDataId.Num();
		if (num == 0 || num2 == 0)
		{
			base.FinishExecute(true);
			return;
		}
		List<INpcInterestLookAtParam> list = new List<INpcInterestLookAtParam>();
		for (int i = 0; i < num; i++)
		{
			NpcInterestLookAtParamImpl npcInterestLookAtParamImpl = new NpcInterestLookAtParamImpl
			{
				TargetPbDataId = 0,
				TargetPosition = Vector.Create(),
				MaxAngle = 180f,
				MaxDistance = 0f
			};
			int num3 = this.TargetPbDataId.Get(i);
			if (num3 == 0)
			{
				FVector fvector = this.TargetPosition.Get(i);
				npcInterestLookAtParamImpl.TargetPosition.FromUeVector(fvector);
			}
			else
			{
				npcInterestLookAtParamImpl.TargetPbDataId = num3;
			}
			npcInterestLookAtParamImpl.MaxAngle = this.MaxAngle.Get(i);
			npcInterestLookAtParamImpl.MaxDistance = this.MaxDistance.Get(i);
			list.Add(npcInterestLookAtParamImpl);
		}
		List<int> list2 = new List<int>();
		for (int j = 0; j < num2; j++)
		{
			list2.Add(this.SourcePbDataId.Get(j));
		}
		NpcPerformController.Instance.AddNpcLookAtParams(new NpcInterestLookAtParamGroupImpl
		{
			Key = this.Key,
			PbDataIds = list2,
			Params = list
		});
		base.FinishExecute(true);
	}

	// Token: 0x0600049A RID: 1178 RVA: 0x00015EBF File Offset: 0x000140BF
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskNpcEnableEntityLookAt._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskNpcEnableEntityLookAt.TsTaskNpcEnableEntityLookAt_C");
		}
		return TsTaskNpcEnableEntityLookAt._ClassPtr;
	}

	// Token: 0x0600049B RID: 1179 RVA: 0x00015EE4 File Offset: 0x000140E4
	public TsTaskNpcEnableEntityLookAt() : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcEnableEntityLookAt.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600049C RID: 1180 RVA: 0x00015F0C File Offset: 0x0001410C
	public TsTaskNpcEnableEntityLookAt(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcEnableEntityLookAt.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600049D RID: 1181 RVA: 0x00015F3F File Offset: 0x0001413F
	protected TsTaskNpcEnableEntityLookAt(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600049E RID: 1182 RVA: 0x00015F48 File Offset: 0x00014148
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000321 RID: 801
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskNpcEnableEntityLookAt.TsTaskNpcEnableEntityLookAt_C";

	// Token: 0x04000322 RID: 802
	private static IntPtr _ClassPtr;

	// Token: 0x04000323 RID: 803
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000324 RID: 804
	private static int __PropertyOffset_Key;

	// Token: 0x04000325 RID: 805
	private static int __PropertyOffset_SourcePbDataId;

	// Token: 0x04000326 RID: 806
	[Nullable(2)]
	private TArray<int> _SourcePbDataId;

	// Token: 0x04000327 RID: 807
	private static int __PropertyOffset_TargetPbDataId;

	// Token: 0x04000328 RID: 808
	[Nullable(2)]
	private TArray<int> _TargetPbDataId;

	// Token: 0x04000329 RID: 809
	private static int __PropertyOffset_TargetPosition;

	// Token: 0x0400032A RID: 810
	[Nullable(2)]
	private TArray<FVector> _TargetPosition;

	// Token: 0x0400032B RID: 811
	private static int __PropertyOffset_MaxDistance;

	// Token: 0x0400032C RID: 812
	[Nullable(2)]
	private TArray<float> _MaxDistance;

	// Token: 0x0400032D RID: 813
	private static int __PropertyOffset_MaxAngle;

	// Token: 0x0400032E RID: 814
	[Nullable(2)]
	private TArray<float> _MaxAngle;
}
