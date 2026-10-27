using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200005F RID: 95
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Animal/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Animal/TsTaskSetAnimalLocation.TsTaskSetAnimalLocation_C")]
public class TsTaskSetAnimalLocation : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000093 RID: 147
	// (get) Token: 0x060003D4 RID: 980 RVA: 0x000128AD File Offset: 0x00010AAD
	// (set) Token: 0x060003D5 RID: 981 RVA: 0x000128C1 File Offset: 0x00010AC1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskSetAnimalLocation.__PropertyOffset_BlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskSetAnimalLocation.__PropertyOffset_BlackboardKey)), value);
		}
	}

	// Token: 0x060003D6 RID: 982 RVA: 0x000128D6 File Offset: 0x00010AD6
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsBlackboardKey = this.BlackboardKey;
			this.TmpVector = global::Vector.Create();
		}
	}

	// Token: 0x060003D7 RID: 983 RVA: 0x00012908 File Offset: 0x00010B08
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

	// Token: 0x060003D8 RID: 984 RVA: 0x000129A4 File Offset: 0x00010BA4
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
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		if (charActorComp == null || !charActorComp.Valid)
		{
			base.FinishExecute(false);
			return;
		}
		int id = charActorComp.Entity.Id;
		if (!string.IsNullOrEmpty(this.TsBlackboardKey))
		{
			Aki.Protocol.Vector vectorValueByEntity = BlackboardController.Instance.GetVectorValueByEntity(id, this.TsBlackboardKey);
			if (vectorValueByEntity == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.BehaviorTree;
				ELogAuthor author2 = ELogAuthor.CWZ;
				string message2 = "不存在BlackboardKey";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Key", this.TsBlackboardKey);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				base.FinishExecute(false);
				return;
			}
			this.TmpVector.Set((double)vectorValueByEntity.X, (double)vectorValueByEntity.Y, (double)vectorValueByEntity.Z);
			UKuroHitResult ukuroHitResult = this.DetectFloor(charActorComp, this.TmpVector);
			if (ukuroHitResult != null)
			{
				TraceElementCommon.Instance.GetHitLocation(ukuroHitResult, 0, this.TmpVector);
				charActorComp.SetActorLocation(this.TmpVector.ToUeVector(false), "TsTaskSetAnimalLocation", false);
				base.FinishExecute(true);
				return;
			}
		}
		base.FinishExecute(false);
	}

	// Token: 0x060003D9 RID: 985 RVA: 0x00012B04 File Offset: 0x00010D04
	[return: Nullable(2)]
	private UKuroHitResult DetectFloor(CharacterActorComponent actorComp, global::Vector pos)
	{
		UTraceSphereElement actorTrace = TraceElementModel.Instance.GetActorTrace();
		actorTrace.WorldContextObject = actorComp.Actor;
		actorTrace.Radius = actorComp.ScaledRadius;
		float num = 2f * actorComp.ScaledHalfHeight;
		MathUtils.Instance.CommonTempVector.DeepCopy(pos);
		GravityUtils.Instance.AddZnInGravityForActor(actorComp, MathUtils.Instance.CommonTempVector, (double)num);
		TraceElementCommon.Instance.SetStartLocation(actorTrace, MathUtils.Instance.CommonTempVector);
		MathUtils.Instance.CommonTempVector.DeepCopy(pos);
		GravityUtils.Instance.AddZnInGravityForActor(actorComp, MathUtils.Instance.CommonTempVector, (double)(-1f * num));
		TraceElementCommon.Instance.SetEndLocation(actorTrace, MathUtils.Instance.CommonTempVector);
		actorTrace.ActorsToIgnore.Empty(true);
		foreach (AActor value in WorldModel.Instance.ActorsToIgnoreSet)
		{
			actorTrace.ActorsToIgnore.Add(value);
		}
		if (!TraceElementCommon.Instance.ShapeTrace(actorComp.Actor.CapsuleComponent, actorTrace, "TsTaskSetAnimalLocation", "TsTaskSetAnimalLocation"))
		{
			return null;
		}
		return actorTrace.HitResult;
	}

	// Token: 0x060003DA RID: 986 RVA: 0x00012C44 File Offset: 0x00010E44
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskSetAnimalLocation._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Animal/TsTaskSetAnimalLocation.TsTaskSetAnimalLocation_C");
		}
		return TsTaskSetAnimalLocation._ClassPtr;
	}

	// Token: 0x060003DB RID: 987 RVA: 0x00012C68 File Offset: 0x00010E68
	public TsTaskSetAnimalLocation() : this(BuiltinUtils.AllocNativeUObject(TsTaskSetAnimalLocation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060003DC RID: 988 RVA: 0x00012C90 File Offset: 0x00010E90
	public TsTaskSetAnimalLocation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSetAnimalLocation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060003DD RID: 989 RVA: 0x00012CC3 File Offset: 0x00010EC3
	protected TsTaskSetAnimalLocation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060003DE RID: 990 RVA: 0x00012CD8 File Offset: 0x00010ED8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040002A3 RID: 675
	private bool IsInitTsVariables;

	// Token: 0x040002A4 RID: 676
	private string TsBlackboardKey = "";

	// Token: 0x040002A5 RID: 677
	[Nullable(2)]
	public global::Vector TmpVector;

	// Token: 0x040002A6 RID: 678
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Animal/TsTaskSetAnimalLocation.TsTaskSetAnimalLocation_C";

	// Token: 0x040002A7 RID: 679
	private static IntPtr _ClassPtr;

	// Token: 0x040002A8 RID: 680
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040002A9 RID: 681
	private static int __PropertyOffset_BlackboardKey;
}
