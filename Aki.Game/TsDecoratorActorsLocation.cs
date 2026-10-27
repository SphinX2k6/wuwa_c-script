using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200002B RID: 43
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorActorsLocation.TsDecoratorActorsLocation_C")]
public class TsDecoratorActorsLocation : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700002D RID: 45
	// (get) Token: 0x06000149 RID: 329 RVA: 0x00006D5B File Offset: 0x00004F5B
	// (set) Token: 0x0600014A RID: 330 RVA: 0x00006D6F File Offset: 0x00004F6F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string KeyActorA
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorActorsLocation.__PropertyOffset_KeyActorA)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorActorsLocation.__PropertyOffset_KeyActorA)), value);
		}
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x0600014B RID: 331 RVA: 0x00006D84 File Offset: 0x00004F84
	// (set) Token: 0x0600014C RID: 332 RVA: 0x00006D98 File Offset: 0x00004F98
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string KeyActorB
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorActorsLocation.__PropertyOffset_KeyActorB)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorActorsLocation.__PropertyOffset_KeyActorB)), value);
		}
	}

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x0600014D RID: 333 RVA: 0x00006DAD File Offset: 0x00004FAD
	// (set) Token: 0x0600014E RID: 334 RVA: 0x00006DC1 File Offset: 0x00004FC1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FFloatRange DistanceRange
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorActorsLocation.__PropertyOffset_DistanceRange);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorActorsLocation.__PropertyOffset_DistanceRange) = value;
		}
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x0600014F RID: 335 RVA: 0x00006DD6 File Offset: 0x00004FD6
	// (set) Token: 0x06000150 RID: 336 RVA: 0x00006DEA File Offset: 0x00004FEA
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FFloatRange AngleRange
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorActorsLocation.__PropertyOffset_AngleRange);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorActorsLocation.__PropertyOffset_AngleRange) = value;
		}
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x06000151 RID: 337 RVA: 0x00006DFF File Offset: 0x00004FFF
	// (set) Token: 0x06000152 RID: 338 RVA: 0x00006E13 File Offset: 0x00005013
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FFloatRange HeightRange
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorActorsLocation.__PropertyOffset_HeightRange);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorActorsLocation.__PropertyOffset_HeightRange) = value;
		}
	}

	// Token: 0x06000153 RID: 339 RVA: 0x00006E28 File Offset: 0x00005028
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsKeyActorA = this.KeyActorA;
			this.TsKeyActorB = this.KeyActorB;
			this.TsDistanceRange = new FastUeFloatRange(this.DistanceRange);
			this.TsAngleRange = new FastUeFloatRange(this.AngleRange);
			this.TsHeightRange = new FastUeFloatRange(this.HeightRange);
		}
	}

	// Token: 0x06000154 RID: 340 RVA: 0x00006E98 File Offset: 0x00005098
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

	// Token: 0x06000155 RID: 341 RVA: 0x00006F38 File Offset: 0x00005138
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
		int id = charActorComp.Entity.Id;
		CharacterActorComponent characterActorComponent = charActorComp;
		if (!string.IsNullOrEmpty(this.TsKeyActorA))
		{
			int? entityIdByEntity = BlackboardController.Instance.GetEntityIdByEntity(id, this.TsKeyActorA);
			if (entityIdByEntity == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.BehaviorTree;
				ELogAuthor author2 = ELogAuthor.LCZ;
				string message2 = "不存在BlackboardKey";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Key", this.TsKeyActorA);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("AI", (ownerController != null) ? ownerController.GetName() : null);
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			CharacterActorComponent characterActorComponentById = CharacterController.Instance.GetCharacterActorComponentById(entityIdByEntity.Value);
			if (characterActorComponentById == null)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.BehaviorTree;
				ELogAuthor author3 = ELogAuthor.LCZ;
				string message3 = "不存在Entity";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Id", entityIdByEntity);
				instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			characterActorComponent = characterActorComponentById;
		}
		EntityHandle currentTarget = aiController.AiHateList.GetCurrentTarget();
		BaseCharacterComponent baseCharacterComponent;
		if (currentTarget == null)
		{
			baseCharacterComponent = null;
		}
		else
		{
			WorldEntity entity = currentTarget.Entity;
			baseCharacterComponent = ((entity != null) ? entity.GetComponent<BaseCharacterComponent>() : null);
		}
		BaseCharacterComponent baseCharacterComponent2 = baseCharacterComponent;
		if (this.TsKeyActorB == "_currentPlayer")
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			BaseCharacterComponent baseCharacterComponent3;
			if (baseCharacter == null)
			{
				baseCharacterComponent3 = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent2 = baseCharacter.CharacterActorComponent;
				if (characterActorComponent2 == null)
				{
					baseCharacterComponent3 = null;
				}
				else
				{
					Entity entity2 = characterActorComponent2.Entity;
					baseCharacterComponent3 = ((entity2 != null) ? entity2.GetComponent<BaseCharacterComponent>() : null);
				}
			}
			BaseCharacterComponent baseCharacterComponent4 = baseCharacterComponent3;
			if (baseCharacterComponent4 == null)
			{
				Log.Instance.Warn(ELogModule.BehaviorTree, ELogAuthor.LCZ, "不存在玩家", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			baseCharacterComponent2 = baseCharacterComponent4;
		}
		else if (!string.IsNullOrEmpty(this.TsKeyActorB))
		{
			int? entityIdByEntity2 = BlackboardController.Instance.GetEntityIdByEntity(id, this.TsKeyActorB);
			if (entityIdByEntity2 == null)
			{
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.BehaviorTree;
				ELogAuthor author4 = ELogAuthor.LCZ;
				string message4 = "不存在BlackboardKey";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Key", this.TsKeyActorB);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("AI", (ownerController != null) ? ownerController.GetName() : null);
				instance4.Warn(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return false;
			}
			BaseCharacterComponent component = EntitySystem.Instance.GetComponent<BaseCharacterComponent>(entityIdByEntity2.Value);
			if (component == null)
			{
				Log instance5 = Log.Instance;
				ELogModule module5 = ELogModule.BehaviorTree;
				ELogAuthor author5 = ELogAuthor.LCZ;
				string message5 = "不存在Entity";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("Id", entityIdByEntity2);
				instance5.Warn(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				return false;
			}
			baseCharacterComponent2 = component;
		}
		if (baseCharacterComponent2 == null)
		{
			return false;
		}
		CharacterActorComponent characterActorComponent3 = baseCharacterComponent2 as CharacterActorComponent;
		Vector location;
		if (characterActorComponent3 != null)
		{
			location = characterActorComponent3.FloorLocation;
		}
		else
		{
			location = baseCharacterComponent2.ActorLocationProxy;
		}
		return MathUtils.Instance.LocationInFastUeRange(characterActorComponent.FloorLocation, characterActorComponent.ActorRotationProxy, location, (double)(characterActorComponent.ScaledRadius + baseCharacterComponent2.ScaledRadius), this.TsDistanceRange, this.TsAngleRange, this.TsHeightRange);
	}

	// Token: 0x06000156 RID: 342 RVA: 0x0000723D File Offset: 0x0000543D
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorActorsLocation._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorActorsLocation.TsDecoratorActorsLocation_C");
		}
		return TsDecoratorActorsLocation._ClassPtr;
	}

	// Token: 0x06000157 RID: 343 RVA: 0x00007264 File Offset: 0x00005464
	public TsDecoratorActorsLocation() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorActorsLocation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000158 RID: 344 RVA: 0x0000728C File Offset: 0x0000548C
	public TsDecoratorActorsLocation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorActorsLocation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000159 RID: 345 RVA: 0x000072BF File Offset: 0x000054BF
	protected TsDecoratorActorsLocation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600015A RID: 346 RVA: 0x000072E0 File Offset: 0x000054E0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040000CB RID: 203
	private const string CURRENT_PLAYER = "_currentPlayer";

	// Token: 0x040000CC RID: 204
	private bool IsInitTsVariables;

	// Token: 0x040000CD RID: 205
	private string TsKeyActorA = "";

	// Token: 0x040000CE RID: 206
	private string TsKeyActorB = "";

	// Token: 0x040000CF RID: 207
	[Nullable(2)]
	private FastUeFloatRange TsDistanceRange;

	// Token: 0x040000D0 RID: 208
	[Nullable(2)]
	private FastUeFloatRange TsAngleRange;

	// Token: 0x040000D1 RID: 209
	[Nullable(2)]
	private FastUeFloatRange TsHeightRange;

	// Token: 0x040000D2 RID: 210
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorActorsLocation.TsDecoratorActorsLocation_C";

	// Token: 0x040000D3 RID: 211
	private static IntPtr _ClassPtr;

	// Token: 0x040000D4 RID: 212
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040000D5 RID: 213
	private static int __PropertyOffset_KeyActorA;

	// Token: 0x040000D6 RID: 214
	private static int __PropertyOffset_KeyActorB;

	// Token: 0x040000D7 RID: 215
	private static int __PropertyOffset_DistanceRange;

	// Token: 0x040000D8 RID: 216
	private static int __PropertyOffset_AngleRange;

	// Token: 0x040000D9 RID: 217
	private static int __PropertyOffset_HeightRange;
}
