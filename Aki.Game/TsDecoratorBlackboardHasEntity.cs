using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game;
using CSharpScript.Game.World.Controller;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000031 RID: 49
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorBlackboardHasEntity.TsDecoratorBlackboardHasEntity_C")]
public class TsDecoratorBlackboardHasEntity : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000044 RID: 68
	// (get) Token: 0x060001AC RID: 428 RVA: 0x00008B4B File Offset: 0x00006D4B
	// (set) Token: 0x060001AD RID: 429 RVA: 0x00008B5F File Offset: 0x00006D5F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorBlackboardHasEntity.__PropertyOffset_BlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorBlackboardHasEntity.__PropertyOffset_BlackboardKey)), value);
		}
	}

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x060001AE RID: 430 RVA: 0x00008B74 File Offset: 0x00006D74
	// (set) Token: 0x060001AF RID: 431 RVA: 0x00008B84 File Offset: 0x00006D84
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool CompareValue
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorBlackboardHasEntity.__PropertyOffset_CompareValue) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorBlackboardHasEntity.__PropertyOffset_CompareValue) = (value ? 1 : 0);
		}
	}

	// Token: 0x060001B0 RID: 432 RVA: 0x00008B95 File Offset: 0x00006D95
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsBlackboardKey = this.BlackboardKey;
			this.TsCompareValue = this.CompareValue;
		}
	}

	// Token: 0x060001B1 RID: 433 RVA: 0x00008BC8 File Offset: 0x00006DC8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsDecoratorBlackboardHasEntity) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("PerformConditionCheckAI"), TsDecoratorBlackboardHasEntity.StaticClass(), out intPtr, out num))
		{
			return this.PerformConditionCheckAI_Implementation(ownerController, controlledPawn);
		}
		UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* ptr = stackalloc UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x00008C80 File Offset: 0x00006E80
	[NullableContext(2)]
	protected unsafe virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		AiController aiController = (ownerController as TsAiController).AiController;
		bool flag = ServerGmController.Instance.AnimalDebug && this.BlackboardKey == "NearerPlayerId";
		if (flag)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "AnimalDebug BlackboardHasEntity";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Tree", base.TreeAsset);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("aiController", aiController != null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("aiComp", !(!((aiController != null) ? aiController.CharAiDesignComp : null)));
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
			string item = "SelfId";
			int? num;
			if (aiController == null)
			{
				num = null;
			}
			else
			{
				CharacterActorComponent charActorComp = aiController.CharActorComp;
				num = ((charActorComp != null) ? new int?(charActorComp.Entity.Id) : null);
			}
			ptr = new ValueTuple<string, object>(item, num);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}
		if (aiController == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.BehaviorTree;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		CharacterAiComponent charAiDesignComp = aiController.CharAiDesignComp;
		if (charAiDesignComp == null)
		{
			return false;
		}
		this.InitTsVariables();
		if (this.TsBlackboardKey != "")
		{
			int? entityIdByEntity = BlackboardController.Instance.GetEntityIdByEntity(charAiDesignComp.Entity.Id, this.TsBlackboardKey);
			if (flag)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.AI;
				ELogAuthor author3 = ELogAuthor.LCZ;
				string message3 = "AnimalDebug BlackboardHasEntity2";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("value", entityIdByEntity);
				instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				if (entityIdByEntity != null)
				{
					CharacterActorComponent component = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityIdByEntity.Value);
					EEntityType? eentityType = (component != null) ? new EEntityType?(component.CreatureData.GetEntityType()) : null;
					Log instance4 = Log.Instance;
					ELogModule module4 = ELogModule.AI;
					ELogAuthor author4 = ELogAuthor.LCZ;
					string message4 = "AnimalDebug BlackboardHasEntity3";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("entityType", eentityType);
					ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1);
					string item2 = "Player";
					TsBaseCharacter baseCharacter = Global.BaseCharacter;
					ptr2 = new ValueTuple<string, object>(item2, (baseCharacter != null) ? new int?(baseCharacter.GetEntityIdNoBlueprint()) : null);
					ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2);
					string item3 = "MainAnims";
					CharacterAnimationComponent component2 = charAiDesignComp.Entity.GetComponent<CharacterAnimationComponent>();
					object item4;
					if (component2 == null)
					{
						item4 = null;
					}
					else
					{
						UAnimInstance mainAnimInstance = component2.MainAnimInstance;
						item4 = ((mainAnimInstance != null) ? mainAnimInstance.GetMainAnimsDebugText() : null);
					}
					ptr3 = new ValueTuple<string, object>(item3, item4);
					instance4.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				}
			}
			if (entityIdByEntity != null && EntitySystem.Instance.Get(entityIdByEntity.Value) != null)
			{
				return this.TsCompareValue;
			}
		}
		return !this.TsCompareValue;
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x00008F6C File Offset: 0x0000716C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorBlackboardHasEntity._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorBlackboardHasEntity.TsDecoratorBlackboardHasEntity_C");
		}
		return TsDecoratorBlackboardHasEntity._ClassPtr;
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x00008F90 File Offset: 0x00007190
	public TsDecoratorBlackboardHasEntity() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorBlackboardHasEntity.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x00008FB8 File Offset: 0x000071B8
	public TsDecoratorBlackboardHasEntity(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorBlackboardHasEntity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x00008FEB File Offset: 0x000071EB
	protected TsDecoratorBlackboardHasEntity(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x00009000 File Offset: 0x00007200
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400011E RID: 286
	private bool IsInitTsVariables;

	// Token: 0x0400011F RID: 287
	private string TsBlackboardKey = "";

	// Token: 0x04000120 RID: 288
	private bool TsCompareValue;

	// Token: 0x04000121 RID: 289
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorBlackboardHasEntity.TsDecoratorBlackboardHasEntity_C";

	// Token: 0x04000122 RID: 290
	private static IntPtr _ClassPtr;

	// Token: 0x04000123 RID: 291
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000124 RID: 292
	private static int __PropertyOffset_BlackboardKey;

	// Token: 0x04000125 RID: 293
	private static int __PropertyOffset_CompareValue;
}
