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
	// Token: 0x17000225 RID: 549
	// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x0003B8FB File Offset: 0x00039AFB
	// (set) Token: 0x06000BB2 RID: 2994 RVA: 0x0003B90F File Offset: 0x00039B0F
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

	// Token: 0x17000226 RID: 550
	// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x0003B924 File Offset: 0x00039B24
	// (set) Token: 0x06000BB4 RID: 2996 RVA: 0x0003B938 File Offset: 0x00039B38
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

	// Token: 0x17000227 RID: 551
	// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x0003B94D File Offset: 0x00039B4D
	// (set) Token: 0x06000BB6 RID: 2998 RVA: 0x0003B95D File Offset: 0x00039B5D
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

	// Token: 0x17000228 RID: 552
	// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x0003B96E File Offset: 0x00039B6E
	// (set) Token: 0x06000BB8 RID: 3000 RVA: 0x0003B97E File Offset: 0x00039B7E
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

	// Token: 0x06000BB9 RID: 3001 RVA: 0x0003B990 File Offset: 0x00039B90
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

	// Token: 0x06000BBA RID: 3002 RVA: 0x0003BA1C File Offset: 0x00039C1C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskTurnToLocation) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskTurnToLocation.StaticClass(), out intPtr, out num))
		{
			this.ReceiveTickAI_Implementation(ownerController, controlledPawn, deltaSeconds);
			return;
		}
		UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* ptr = stackalloc UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		ptr->DeltaSeconds = deltaSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000BBB RID: 3003 RVA: 0x0003BAD4 File Offset: 0x00039CD4
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

	// Token: 0x06000BBC RID: 3004 RVA: 0x0003BD4D File Offset: 0x00039F4D
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskTurnToLocation._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTurnToLocation.TsTaskTurnToLocation_C");
		}
		return TsTaskTurnToLocation._ClassPtr;
	}

	// Token: 0x06000BBD RID: 3005 RVA: 0x0003BD74 File Offset: 0x00039F74
	public TsTaskTurnToLocation() : this(BuiltinUtils.AllocNativeUObject(TsTaskTurnToLocation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000BBE RID: 3006 RVA: 0x0003BD9C File Offset: 0x00039F9C
	public TsTaskTurnToLocation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskTurnToLocation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000BBF RID: 3007 RVA: 0x0003BDCF File Offset: 0x00039FCF
	protected TsTaskTurnToLocation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000BC0 RID: 3008 RVA: 0x0003BDF0 File Offset: 0x00039FF0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x04000933 RID: 2355
	private const string CURRENT_PLAYER = "_currentPlayer";

	// Token: 0x04000934 RID: 2356
	private bool IsInitTsVariables;

	// Token: 0x04000935 RID: 2357
	private string TsLocationKey = "";

	// Token: 0x04000936 RID: 2358
	private string TsDirectionKey = "";

	// Token: 0x04000937 RID: 2359
	private float TsTurnSpeed;

	// Token: 0x04000938 RID: 2360
	public bool TsContinuously;

	// Token: 0x04000939 RID: 2361
	[Nullable(2)]
	public global::Vector TmpVector;

	// Token: 0x0400093A RID: 2362
	[Nullable(2)]
	public global::Vector TmpVector2;

	// Token: 0x0400093B RID: 2363
	[Nullable(2)]
	public global::Vector TmpVector3;

	// Token: 0x0400093C RID: 2364
	[Nullable(2)]
	public global::Rotator TmpRotator;

	// Token: 0x0400093D RID: 2365
	[Nullable(2)]
	public global::Rotator TmpRotator2;

	// Token: 0x0400093E RID: 2366
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTurnToLocation.TsTaskTurnToLocation_C";

	// Token: 0x0400093F RID: 2367
	private static IntPtr _ClassPtr;

	// Token: 0x04000940 RID: 2368
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000941 RID: 2369
	private static int __PropertyOffset_LocationKey;

	// Token: 0x04000942 RID: 2370
	private static int __PropertyOffset_DirectionKey;

	// Token: 0x04000943 RID: 2371
	private static int __PropertyOffset_Continuously;

	// Token: 0x04000944 RID: 2372
	private static int __PropertyOffset_TurnSpeed;
}
