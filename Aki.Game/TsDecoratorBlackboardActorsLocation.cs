using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200002D RID: 45
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorBlackboardActorsLocation.TsDecoratorBlackboardActorsLocation_C")]
public class TsDecoratorBlackboardActorsLocation : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000034 RID: 52
	// (get) Token: 0x06000167 RID: 359 RVA: 0x0000757B File Offset: 0x0000577B
	// (set) Token: 0x06000168 RID: 360 RVA: 0x0000758F File Offset: 0x0000578F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string AKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorBlackboardActorsLocation.__PropertyOffset_AKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorBlackboardActorsLocation.__PropertyOffset_AKey)), value);
		}
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x06000169 RID: 361 RVA: 0x000075A4 File Offset: 0x000057A4
	// (set) Token: 0x0600016A RID: 362 RVA: 0x000075B8 File Offset: 0x000057B8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string ARotationKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorBlackboardActorsLocation.__PropertyOffset_ARotationKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorBlackboardActorsLocation.__PropertyOffset_ARotationKey)), value);
		}
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x0600016B RID: 363 RVA: 0x000075CD File Offset: 0x000057CD
	// (set) Token: 0x0600016C RID: 364 RVA: 0x000075E1 File Offset: 0x000057E1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string ARadiusKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorBlackboardActorsLocation.__PropertyOffset_ARadiusKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorBlackboardActorsLocation.__PropertyOffset_ARadiusKey)), value);
		}
	}

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x0600016D RID: 365 RVA: 0x000075F6 File Offset: 0x000057F6
	// (set) Token: 0x0600016E RID: 366 RVA: 0x0000760A File Offset: 0x0000580A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorBlackboardActorsLocation.__PropertyOffset_BKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorBlackboardActorsLocation.__PropertyOffset_BKey)), value);
		}
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x0600016F RID: 367 RVA: 0x0000761F File Offset: 0x0000581F
	// (set) Token: 0x06000170 RID: 368 RVA: 0x00007633 File Offset: 0x00005833
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BRadiusKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorBlackboardActorsLocation.__PropertyOffset_BRadiusKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorBlackboardActorsLocation.__PropertyOffset_BRadiusKey)), value);
		}
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x06000171 RID: 369 RVA: 0x00007648 File Offset: 0x00005848
	// (set) Token: 0x06000172 RID: 370 RVA: 0x0000765C File Offset: 0x0000585C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FFloatRange DistanceRange
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorBlackboardActorsLocation.__PropertyOffset_DistanceRange);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorBlackboardActorsLocation.__PropertyOffset_DistanceRange) = value;
		}
	}

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x06000173 RID: 371 RVA: 0x00007671 File Offset: 0x00005871
	// (set) Token: 0x06000174 RID: 372 RVA: 0x00007685 File Offset: 0x00005885
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FFloatRange AngleRange
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorBlackboardActorsLocation.__PropertyOffset_AngleRange);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorBlackboardActorsLocation.__PropertyOffset_AngleRange) = value;
		}
	}

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x06000175 RID: 373 RVA: 0x0000769A File Offset: 0x0000589A
	// (set) Token: 0x06000176 RID: 374 RVA: 0x000076AE File Offset: 0x000058AE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FFloatRange HeightRange
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorBlackboardActorsLocation.__PropertyOffset_HeightRange);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorBlackboardActorsLocation.__PropertyOffset_HeightRange) = value;
		}
	}

	// Token: 0x06000177 RID: 375 RVA: 0x000076C4 File Offset: 0x000058C4
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsAKey = this.AKey;
			this.TsARotationKey = this.ARotationKey;
			this.TsARadiusKey = this.ARadiusKey;
			this.TsBKey = this.BKey;
			this.TsBRadiusKey = this.BRadiusKey;
			this.TsDistanceRange = new FastUeFloatRange(this.DistanceRange);
			this.TsAngleRange = new FastUeFloatRange(this.AngleRange);
			this.TsHeightRange = new FastUeFloatRange(this.HeightRange);
		}
	}

	// Token: 0x06000178 RID: 376 RVA: 0x00007758 File Offset: 0x00005958
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

	// Token: 0x06000179 RID: 377 RVA: 0x000077F8 File Offset: 0x000059F8
	[NullableContext(2)]
	protected virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
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
		int id = aiController.CharActorComp.Entity.Id;
		string name = ownerController.GetName();
		return this.ResolveSideA(aiController, id, name) && this.ResolveSideB(aiController, id, name) && MathUtils.Instance.LocationInFastUeRange(this.ResultLocationA, this.ResultRotationA, this.ResultLocationB, (double)(this.ResultRadiusA + this.ResultRadiusB), this.TsDistanceRange, this.TsAngleRange, this.TsHeightRange);
	}

	// Token: 0x0600017A RID: 378 RVA: 0x000078C0 File Offset: 0x00005AC0
	private bool ResolveSideA(AiController aiController, int myEntityId, string aiName)
	{
		if (!string.IsNullOrEmpty(this.TsAKey) && this.TsAKey != "_currentPlayer")
		{
			Aki.Protocol.Vector vectorValueByEntity = BlackboardController.Instance.GetVectorValueByEntity(myEntityId, this.TsAKey);
			if (vectorValueByEntity != null)
			{
				global::Rotator rotator = this.ResolveRotationA(myEntityId, aiName);
				if (rotator == null)
				{
					return false;
				}
				this.LocationCacheA.DeepCopy(vectorValueByEntity);
				this.ResultLocationA = this.LocationCacheA;
				this.ResultRadiusA = this.ReadRadiusByKey(myEntityId, this.TsARadiusKey);
				this.ResultRotationA = rotator;
				return true;
			}
		}
		BaseCharacterComponent actorComp = this.GetActorComp(aiController, myEntityId, this.TsAKey, aiName, false);
		if (actorComp == null)
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = actorComp as CharacterActorComponent;
		this.ResultLocationA = ((characterActorComponent != null) ? characterActorComponent.FloorLocation : actorComp.ActorLocationProxy);
		this.ResultRotationA = actorComp.ActorRotationProxy;
		this.ResultRadiusA = actorComp.ScaledRadius;
		return true;
	}

	// Token: 0x0600017B RID: 379 RVA: 0x00007990 File Offset: 0x00005B90
	[return: Nullable(2)]
	private unsafe global::Rotator ResolveRotationA(int myEntityId, string aiName)
	{
		if (string.IsNullOrEmpty(this.TsARotationKey))
		{
			return global::Rotator.ZeroRotatorProxy;
		}
		Aki.Protocol.Rotator rotatorValueByEntity = BlackboardController.Instance.GetRotatorValueByEntity(myEntityId, this.TsARotationKey);
		if (rotatorValueByEntity == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "不存在BlackboardKey";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Key", this.TsARotationKey);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("AI", aiName);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		this.RotationCacheA.DeepCopy(rotatorValueByEntity);
		return this.RotationCacheA;
	}

	// Token: 0x0600017C RID: 380 RVA: 0x00007A30 File Offset: 0x00005C30
	private float ReadRadiusByKey(int myEntityId, string key)
	{
		if (string.IsNullOrEmpty(key))
		{
			return 0f;
		}
		return BlackboardController.Instance.GetFloatValueByEntity(myEntityId, key).GetValueOrDefault();
	}

	// Token: 0x0600017D RID: 381 RVA: 0x00007A60 File Offset: 0x00005C60
	private bool ResolveSideB(AiController aiController, int myEntityId, string aiName)
	{
		if (!string.IsNullOrEmpty(this.TsBKey) && this.TsBKey != "_currentPlayer")
		{
			Aki.Protocol.Vector vectorValueByEntity = BlackboardController.Instance.GetVectorValueByEntity(myEntityId, this.TsBKey);
			if (vectorValueByEntity != null)
			{
				this.LocationCacheB.DeepCopy(vectorValueByEntity);
				this.ResultLocationB = this.LocationCacheB;
				this.ResultRadiusB = this.ReadRadiusByKey(myEntityId, this.TsBRadiusKey);
				return true;
			}
		}
		BaseCharacterComponent actorComp = this.GetActorComp(aiController, myEntityId, this.TsBKey, aiName, true);
		if (actorComp == null)
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = actorComp as CharacterActorComponent;
		this.ResultLocationB = ((characterActorComponent != null) ? characterActorComponent.FloorLocation : actorComp.ActorLocationProxy);
		this.ResultRadiusB = actorComp.ScaledRadius;
		return true;
	}

	// Token: 0x0600017E RID: 382 RVA: 0x00007B10 File Offset: 0x00005D10
	[return: Nullable(2)]
	private unsafe BaseCharacterComponent GetActorComp(AiController aiController, int myEntityId, string key, string aiName, bool isSideB)
	{
		if (key == "_currentPlayer")
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			BaseCharacterComponent baseCharacterComponent;
			if (baseCharacter == null)
			{
				baseCharacterComponent = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
				if (characterActorComponent == null)
				{
					baseCharacterComponent = null;
				}
				else
				{
					Entity entity = characterActorComponent.Entity;
					baseCharacterComponent = ((entity != null) ? entity.GetComponent<BaseCharacterComponent>() : null);
				}
			}
			BaseCharacterComponent baseCharacterComponent2 = baseCharacterComponent;
			if (baseCharacterComponent2 == null)
			{
				Log.Instance.Warn(ELogModule.BehaviorTree, ELogAuthor.LCZ, "不存在玩家", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			return baseCharacterComponent2;
		}
		else if (string.IsNullOrEmpty(key))
		{
			if (!isSideB)
			{
				return aiController.CharActorComp;
			}
			EntityHandle currentTarget = aiController.AiHateList.GetCurrentTarget();
			if (currentTarget == null)
			{
				return null;
			}
			WorldEntity entity2 = currentTarget.Entity;
			if (entity2 == null)
			{
				return null;
			}
			return entity2.GetComponent<BaseCharacterComponent>();
		}
		else
		{
			int? entityIdByEntity = BlackboardController.Instance.GetEntityIdByEntity(myEntityId, key);
			if (entityIdByEntity == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.BehaviorTree;
				ELogAuthor author = ELogAuthor.LCZ;
				string message = "不存在BlackboardKey";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Key", key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("AI", aiName);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return null;
			}
			BaseCharacterComponent component = EntitySystem.Instance.GetComponent<BaseCharacterComponent>(entityIdByEntity.Value);
			if (component == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.BehaviorTree;
				ELogAuthor author2 = ELogAuthor.LCZ;
				string message2 = "不存在Entity";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", entityIdByEntity);
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return component;
		}
	}

	// Token: 0x0600017F RID: 383 RVA: 0x00007C5D File Offset: 0x00005E5D
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorBlackboardActorsLocation._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorBlackboardActorsLocation.TsDecoratorBlackboardActorsLocation_C");
		}
		return TsDecoratorBlackboardActorsLocation._ClassPtr;
	}

	// Token: 0x06000180 RID: 384 RVA: 0x00007C84 File Offset: 0x00005E84
	public TsDecoratorBlackboardActorsLocation() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorBlackboardActorsLocation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000181 RID: 385 RVA: 0x00007CAC File Offset: 0x00005EAC
	public TsDecoratorBlackboardActorsLocation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorBlackboardActorsLocation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000182 RID: 386 RVA: 0x00007CE0 File Offset: 0x00005EE0
	protected TsDecoratorBlackboardActorsLocation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000183 RID: 387 RVA: 0x00007D70 File Offset: 0x00005F70
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040000E2 RID: 226
	private const string CURRENT_PLAYER = "_currentPlayer";

	// Token: 0x040000E3 RID: 227
	private bool IsInitTsVariables;

	// Token: 0x040000E4 RID: 228
	private string TsAKey = "";

	// Token: 0x040000E5 RID: 229
	private string TsARotationKey = "";

	// Token: 0x040000E6 RID: 230
	private string TsARadiusKey = "";

	// Token: 0x040000E7 RID: 231
	private string TsBKey = "";

	// Token: 0x040000E8 RID: 232
	private string TsBRadiusKey = "";

	// Token: 0x040000E9 RID: 233
	[Nullable(2)]
	private FastUeFloatRange TsDistanceRange;

	// Token: 0x040000EA RID: 234
	[Nullable(2)]
	private FastUeFloatRange TsAngleRange;

	// Token: 0x040000EB RID: 235
	[Nullable(2)]
	private FastUeFloatRange TsHeightRange;

	// Token: 0x040000EC RID: 236
	private readonly global::Vector LocationCacheA = global::Vector.Create();

	// Token: 0x040000ED RID: 237
	private readonly global::Rotator RotationCacheA = global::Rotator.Create();

	// Token: 0x040000EE RID: 238
	private readonly global::Vector LocationCacheB = global::Vector.Create();

	// Token: 0x040000EF RID: 239
	private global::Vector ResultLocationA = global::Vector.ZeroVectorProxy;

	// Token: 0x040000F0 RID: 240
	private global::Rotator ResultRotationA = global::Rotator.ZeroRotatorProxy;

	// Token: 0x040000F1 RID: 241
	private float ResultRadiusA;

	// Token: 0x040000F2 RID: 242
	private global::Vector ResultLocationB = global::Vector.ZeroVectorProxy;

	// Token: 0x040000F3 RID: 243
	private float ResultRadiusB;

	// Token: 0x040000F4 RID: 244
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorBlackboardActorsLocation.TsDecoratorBlackboardActorsLocation_C";

	// Token: 0x040000F5 RID: 245
	private static IntPtr _ClassPtr;

	// Token: 0x040000F6 RID: 246
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040000F7 RID: 247
	private static int __PropertyOffset_AKey;

	// Token: 0x040000F8 RID: 248
	private static int __PropertyOffset_ARotationKey;

	// Token: 0x040000F9 RID: 249
	private static int __PropertyOffset_ARadiusKey;

	// Token: 0x040000FA RID: 250
	private static int __PropertyOffset_BKey;

	// Token: 0x040000FB RID: 251
	private static int __PropertyOffset_BRadiusKey;

	// Token: 0x040000FC RID: 252
	private static int __PropertyOffset_DistanceRange;

	// Token: 0x040000FD RID: 253
	private static int __PropertyOffset_AngleRange;

	// Token: 0x040000FE RID: 254
	private static int __PropertyOffset_HeightRange;
}
