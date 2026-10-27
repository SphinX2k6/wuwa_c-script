using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000C9 RID: 201
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTurnToLocation.TsTaskTurnToLocation_C")]
public class TsTaskTurnToLocation : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000222 RID: 546
	// (get) Token: 0x06000BAB RID: 2987 RVA: 0x0003A6C3 File Offset: 0x000388C3
	// (set) Token: 0x06000BAC RID: 2988 RVA: 0x0003A6D7 File Offset: 0x000388D7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string LocationKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskTurnToLocation.__PropertyOffset_LocationKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskTurnToLocation.__PropertyOffset_LocationKey)), value);
		}
	}

	// Token: 0x17000223 RID: 547
	// (get) Token: 0x06000BAD RID: 2989 RVA: 0x0003A6EC File Offset: 0x000388EC
	// (set) Token: 0x06000BAE RID: 2990 RVA: 0x0003A700 File Offset: 0x00038900
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string DirectionKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskTurnToLocation.__PropertyOffset_DirectionKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskTurnToLocation.__PropertyOffset_DirectionKey)), value);
		}
	}

	// Token: 0x17000224 RID: 548
	// (get) Token: 0x06000BAF RID: 2991 RVA: 0x0003A715 File Offset: 0x00038915
	// (set) Token: 0x06000BB0 RID: 2992 RVA: 0x0003A725 File Offset: 0x00038925
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool Continuously
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurnToLocation.__PropertyOffset_Continuously) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurnToLocation.__PropertyOffset_Continuously) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000225 RID: 549
	// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x0003A736 File Offset: 0x00038936
	// (set) Token: 0x06000BB2 RID: 2994 RVA: 0x0003A746 File Offset: 0x00038946
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float TurnSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurnToLocation.__PropertyOffset_TurnSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurnToLocation.__PropertyOffset_TurnSpeed) = value;
		}
	}

	// Token: 0x06000BB3 RID: 2995 RVA: 0x0003A758 File Offset: 0x00038958
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsLocationKey = this.LocationKey;
			this.TsDirectionKey = this.DirectionKey;
			this.TsTurnSpeed = this.TurnSpeed;
			this.TsContinuously = this.Continuously;
			this.TmpVector = global::Vector.Create();
			this.TmpVector2 = global::Vector.Create();
			this.TmpVector3 = global::Vector.Create();
			this.TmpRotator = global::Rotator.Create();
			this.TmpRotator2 = global::Rotator.Create();
		}
	}

	// Token: 0x06000BB4 RID: 2996 RVA: 0x0003A7E4 File Offset: 0x000389E4
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

	// Token: 0x06000BB5 RID: 2997 RVA: 0x0003A884 File Offset: 0x00038A84
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		this.InitTsVariables();
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (((aiController != null) ? aiController.CharActorComp : null) == null)
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
		if (this.TsLocationKey != "")
		{
			if (this.TsLocationKey == "_currentPlayer")
			{
				TsBaseCharacter baseCharacter = Global.BaseCharacter;
				global::Vector vector;
				if (baseCharacter == null)
				{
					vector = null;
				}
				else
				{
					CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
					vector = ((characterActorComponent != null) ? characterActorComponent.ActorLocationProxy : null);
				}
				global::Vector vector2 = vector;
				if (vector2 != null)
				{
					this.TmpVector3.DeepCopy(vector2);
				}
			}
			else
			{
				Aki.Protocol.Vector vectorValueByEntity = BlackboardController.Instance.GetVectorValueByEntity(aiController.CharAiDesignComp.Entity.Id, this.TsLocationKey);
				if (vectorValueByEntity != null)
				{
					this.TmpVector3.DeepCopy(vectorValueByEntity);
				}
			}
			if (!this.TmpVector3.IsNearlyZero(9.999999747378752E-05))
			{
				this.TmpVector3.SubtractionEqual(charActorComp.ActorLocationProxy);
			}
		}
		if (this.TsDirectionKey != "")
		{
			Aki.Protocol.Vector vectorValueByEntity2 = BlackboardController.Instance.GetVectorValueByEntity(aiController.CharAiDesignComp.Entity.Id, this.TsDirectionKey);
			if (vectorValueByEntity2 != null)
			{
				this.TmpVector3.DeepCopy(vectorValueByEntity2);
			}
		}
		this.TmpVector2.DeepCopy(charActorComp.ActorGravityDirectProxy);
		this.TmpVector2.UnaryNegation(this.TmpVector2);
		global::Vector.VectorPlaneProject(this.TmpVector3, this.TmpVector2, this.TmpVector);
		if (this.TmpVector.IsNearlyZero(9.999999747378752E-05))
		{
			base.FinishExecute(true);
			return;
		}
		this.TmpVector.Normalize(9.99999993922529E-09);
		MathUtils.Instance.LookRotationForwardFirst(this.TmpVector, this.TmpVector2, this.TmpRotator);
		if (this.TsContinuously)
		{
			MathUtils.Instance.RotatorInterpConstantTo(charActorComp.ActorRotationProxy, this.TmpRotator, deltaSeconds, this.TsTurnSpeed, this.TmpRotator2);
			charActorComp.SetActorRotation(this.TmpRotator2.ToUeRotator(), "TsTaskTurnToLocation", false);
			if (charActorComp.ActorRotationProxy.Equals2(this.TmpRotator, 0.0001f))
			{
				base.FinishExecute(true);
			}
			return;
		}
		charActorComp.SetActorRotation(this.TmpRotator.ToUeRotator(), "TsTaskTurnToLocation", false);
		base.FinishExecute(true);
	}

	// Token: 0x06000BB6 RID: 2998 RVA: 0x0003AAFD File Offset: 0x00038CFD
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskTurnToLocation._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTurnToLocation.TsTaskTurnToLocation_C");
		}
		return TsTaskTurnToLocation._ClassPtr;
	}

	// Token: 0x06000BB7 RID: 2999 RVA: 0x0003AB24 File Offset: 0x00038D24
	public TsTaskTurnToLocation() : this(BuiltinUtils.AllocNativeUObject(TsTaskTurnToLocation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000BB8 RID: 3000 RVA: 0x0003AB4C File Offset: 0x00038D4C
	public TsTaskTurnToLocation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskTurnToLocation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000BB9 RID: 3001 RVA: 0x0003AB7F File Offset: 0x00038D7F
	protected TsTaskTurnToLocation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000BBA RID: 3002 RVA: 0x0003ABA0 File Offset: 0x00038DA0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x0400092B RID: 2347
	private const string CURRENT_PLAYER = "_currentPlayer";

	// Token: 0x0400092C RID: 2348
	private bool IsInitTsVariables;

	// Token: 0x0400092D RID: 2349
	private string TsLocationKey = "";

	// Token: 0x0400092E RID: 2350
	private string TsDirectionKey = "";

	// Token: 0x0400092F RID: 2351
	private float TsTurnSpeed;

	// Token: 0x04000930 RID: 2352
	public bool TsContinuously;

	// Token: 0x04000931 RID: 2353
	[Nullable(2)]
	public global::Vector TmpVector;

	// Token: 0x04000932 RID: 2354
	[Nullable(2)]
	public global::Vector TmpVector2;

	// Token: 0x04000933 RID: 2355
	[Nullable(2)]
	public global::Vector TmpVector3;

	// Token: 0x04000934 RID: 2356
	[Nullable(2)]
	public global::Rotator TmpRotator;

	// Token: 0x04000935 RID: 2357
	[Nullable(2)]
	public global::Rotator TmpRotator2;

	// Token: 0x04000936 RID: 2358
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTurnToLocation.TsTaskTurnToLocation_C";

	// Token: 0x04000937 RID: 2359
	private static IntPtr _ClassPtr;

	// Token: 0x04000938 RID: 2360
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000939 RID: 2361
	private static int __PropertyOffset_LocationKey;

	// Token: 0x0400093A RID: 2362
	private static int __PropertyOffset_DirectionKey;

	// Token: 0x0400093B RID: 2363
	private static int __PropertyOffset_Continuously;

	// Token: 0x0400093C RID: 2364
	private static int __PropertyOffset_TurnSpeed;
}
