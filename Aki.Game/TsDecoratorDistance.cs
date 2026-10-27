using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000041 RID: 65
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorDistance.TsDecoratorDistance_C")]
public class TsDecoratorDistance : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000060 RID: 96
	// (get) Token: 0x06000268 RID: 616 RVA: 0x0000B75F File Offset: 0x0000995F
	// (set) Token: 0x06000269 RID: 617 RVA: 0x0000B76F File Offset: 0x0000996F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Distance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorDistance.__PropertyOffset_Distance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorDistance.__PropertyOffset_Distance) = value;
		}
	}

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x0600026A RID: 618 RVA: 0x0000B780 File Offset: 0x00009980
	// (set) Token: 0x0600026B RID: 619 RVA: 0x0000B790 File Offset: 0x00009990
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int CompareType
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorDistance.__PropertyOffset_CompareType);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorDistance.__PropertyOffset_CompareType) = value;
		}
	}

	// Token: 0x0600026C RID: 620 RVA: 0x0000B7A1 File Offset: 0x000099A1
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsDistance = this.Distance;
			this.TsCompareType = this.CompareType;
		}
	}

	// Token: 0x0600026D RID: 621 RVA: 0x0000B7D4 File Offset: 0x000099D4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("PerformConditionCheckAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0600026E RID: 622 RVA: 0x0000B874 File Offset: 0x00009A74
	[NullableContext(2)]
	protected unsafe virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		AiController aiController = (ownerController as TsAiController).AiController;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		this.InitTsVariables();
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		CreatureDataComponent creatureDataComponent = charActorComp.Entity.CheckGetComponent<CreatureDataComponent>();
		int entityId = CreatureModel.Instance.GetEntityId(creatureDataComponent.GetSummonerId());
		if (entityId != 0)
		{
			CharacterActorComponent characterActorComponentById = CharacterController.Instance.GetCharacterActorComponentById(entityId);
			if (!characterActorComponentById)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.BehaviorTree;
				ELogAuthor author2 = ELogAuthor.LCZ;
				string message2 = "主人已经被销毁";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", (charActorComp != null) ? new int?(charActorComp.Entity.Id) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Self", charActorComp.Actor.GetName());
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			FVectorDouble actorLocation = characterActorComponentById.ActorLocation;
			FVectorDouble actorLocation2 = charActorComp.ActorLocation;
			double num = FVectorDouble.DistSquared(actorLocation, actorLocation2);
			switch (this.TsCompareType)
			{
			case 0:
				if (num == (double)(this.TsDistance * this.TsDistance))
				{
					return true;
				}
				break;
			case 1:
				if (num < (double)(this.TsDistance * this.TsDistance))
				{
					return true;
				}
				break;
			case 2:
				if (num > (double)(this.TsDistance * this.TsDistance))
				{
					return true;
				}
				break;
			}
		}
		return false;
	}

	// Token: 0x0600026F RID: 623 RVA: 0x0000BA06 File Offset: 0x00009C06
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorDistance._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorDistance.TsDecoratorDistance_C");
		}
		return TsDecoratorDistance._ClassPtr;
	}

	// Token: 0x06000270 RID: 624 RVA: 0x0000BA2C File Offset: 0x00009C2C
	public TsDecoratorDistance() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorDistance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000271 RID: 625 RVA: 0x0000BA54 File Offset: 0x00009C54
	[NullableContext(1)]
	public TsDecoratorDistance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorDistance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000272 RID: 626 RVA: 0x0000BA87 File Offset: 0x00009C87
	protected TsDecoratorDistance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000273 RID: 627 RVA: 0x0000BA90 File Offset: 0x00009C90
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000198 RID: 408
	private bool IsInitTsVariables;

	// Token: 0x04000199 RID: 409
	private float TsDistance;

	// Token: 0x0400019A RID: 410
	private int TsCompareType;

	// Token: 0x0400019B RID: 411
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorDistance.TsDecoratorDistance_C";

	// Token: 0x0400019C RID: 412
	private static IntPtr _ClassPtr;

	// Token: 0x0400019D RID: 413
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400019E RID: 414
	private static int __PropertyOffset_Distance;

	// Token: 0x0400019F RID: 415
	private static int __PropertyOffset_CompareType;
}
