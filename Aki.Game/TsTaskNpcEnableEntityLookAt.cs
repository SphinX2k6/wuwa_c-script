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
	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x0600048E RID: 1166 RVA: 0x00016491 File Offset: 0x00014691
	// (set) Token: 0x0600048F RID: 1167 RVA: 0x000164A5 File Offset: 0x000146A5
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

	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x06000490 RID: 1168 RVA: 0x000164BC File Offset: 0x000146BC
	// (set) Token: 0x06000491 RID: 1169 RVA: 0x000164F5 File Offset: 0x000146F5
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

	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x06000492 RID: 1170 RVA: 0x00016504 File Offset: 0x00014704
	// (set) Token: 0x06000493 RID: 1171 RVA: 0x0001653D File Offset: 0x0001473D
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

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x06000494 RID: 1172 RVA: 0x0001654C File Offset: 0x0001474C
	// (set) Token: 0x06000495 RID: 1173 RVA: 0x00016585 File Offset: 0x00014785
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

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x06000496 RID: 1174 RVA: 0x00016594 File Offset: 0x00014794
	// (set) Token: 0x06000497 RID: 1175 RVA: 0x000165CD File Offset: 0x000147CD
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

	// Token: 0x170000BA RID: 186
	// (get) Token: 0x06000498 RID: 1176 RVA: 0x000165DC File Offset: 0x000147DC
	// (set) Token: 0x06000499 RID: 1177 RVA: 0x00016615 File Offset: 0x00014815
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

	// Token: 0x0600049A RID: 1178 RVA: 0x00016624 File Offset: 0x00014824
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskNpcEnableEntityLookAt) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskNpcEnableEntityLookAt.StaticClass(), out intPtr, out num))
		{
			this.ReceiveExecuteAI_Implementation(ownerController, controlledPawn);
			return;
		}
		UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* ptr = stackalloc UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0600049B RID: 1179 RVA: 0x000166D4 File Offset: 0x000148D4
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

	// Token: 0x0600049C RID: 1180 RVA: 0x0001684F File Offset: 0x00014A4F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskNpcEnableEntityLookAt._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskNpcEnableEntityLookAt.TsTaskNpcEnableEntityLookAt_C");
		}
		return TsTaskNpcEnableEntityLookAt._ClassPtr;
	}

	// Token: 0x0600049D RID: 1181 RVA: 0x00016874 File Offset: 0x00014A74
	public TsTaskNpcEnableEntityLookAt() : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcEnableEntityLookAt.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600049E RID: 1182 RVA: 0x0001689C File Offset: 0x00014A9C
	public TsTaskNpcEnableEntityLookAt(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcEnableEntityLookAt.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600049F RID: 1183 RVA: 0x000168CF File Offset: 0x00014ACF
	protected TsTaskNpcEnableEntityLookAt(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060004A0 RID: 1184 RVA: 0x000168D8 File Offset: 0x00014AD8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000323 RID: 803
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskNpcEnableEntityLookAt.TsTaskNpcEnableEntityLookAt_C";

	// Token: 0x04000324 RID: 804
	private static IntPtr _ClassPtr;

	// Token: 0x04000325 RID: 805
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000326 RID: 806
	private static int __PropertyOffset_Key;

	// Token: 0x04000327 RID: 807
	private static int __PropertyOffset_SourcePbDataId;

	// Token: 0x04000328 RID: 808
	[Nullable(2)]
	private TArray<int> _SourcePbDataId;

	// Token: 0x04000329 RID: 809
	private static int __PropertyOffset_TargetPbDataId;

	// Token: 0x0400032A RID: 810
	[Nullable(2)]
	private TArray<int> _TargetPbDataId;

	// Token: 0x0400032B RID: 811
	private static int __PropertyOffset_TargetPosition;

	// Token: 0x0400032C RID: 812
	[Nullable(2)]
	private TArray<FVector> _TargetPosition;

	// Token: 0x0400032D RID: 813
	private static int __PropertyOffset_MaxDistance;

	// Token: 0x0400032E RID: 814
	[Nullable(2)]
	private TArray<float> _MaxDistance;

	// Token: 0x0400032F RID: 815
	private static int __PropertyOffset_MaxAngle;

	// Token: 0x04000330 RID: 816
	[Nullable(2)]
	private TArray<float> _MaxAngle;
}
