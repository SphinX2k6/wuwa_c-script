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
	// (get) Token: 0x06000167 RID: 359 RVA: 0x0000780F File Offset: 0x00005A0F
	// (set) Token: 0x06000168 RID: 360 RVA: 0x00007823 File Offset: 0x00005A23
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
	// (get) Token: 0x06000169 RID: 361 RVA: 0x00007838 File Offset: 0x00005A38
	// (set) Token: 0x0600016A RID: 362 RVA: 0x0000784C File Offset: 0x00005A4C
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
	// (get) Token: 0x0600016B RID: 363 RVA: 0x00007861 File Offset: 0x00005A61
	// (set) Token: 0x0600016C RID: 364 RVA: 0x00007875 File Offset: 0x00005A75
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
	// (get) Token: 0x0600016D RID: 365 RVA: 0x0000788A File Offset: 0x00005A8A
	// (set) Token: 0x0600016E RID: 366 RVA: 0x0000789E File Offset: 0x00005A9E
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
	// (get) Token: 0x0600016F RID: 367 RVA: 0x000078B3 File Offset: 0x00005AB3
	// (set) Token: 0x06000170 RID: 368 RVA: 0x000078C7 File Offset: 0x00005AC7
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
	// (get) Token: 0x06000171 RID: 369 RVA: 0x000078DC File Offset: 0x00005ADC
	// (set) Token: 0x06000172 RID: 370 RVA: 0x000078F0 File Offset: 0x00005AF0
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
	// (get) Token: 0x06000173 RID: 371 RVA: 0x00007905 File Offset: 0x00005B05
	// (set) Token: 0x06000174 RID: 372 RVA: 0x00007919 File Offset: 0x00005B19
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
	// (get) Token: 0x06000175 RID: 373 RVA: 0x0000792E File Offset: 0x00005B2E
	// (set) Token: 0x06000176 RID: 374 RVA: 0x00007942 File Offset: 0x00005B42
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

	// Token: 0x06000177 RID: 375 RVA: 0x00007958 File Offset: 0x00005B58
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

	// Token: 0x06000178 RID: 376 RVA: 0x000079EC File Offset: 0x00005BEC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsDecoratorBlackboardActorsLocation) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("PerformConditionCheckAI"), TsDecoratorBlackboardActorsLocation.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000179 RID: 377 RVA: 0x00007AA4 File Offset: 0x00005CA4
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

	// Token: 0x0600017A RID: 378 RVA: 0x00007B6C File Offset: 0x00005D6C
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

	// Token: 0x0600017B RID: 379 RVA: 0x00007C3C File Offset: 0x00005E3C
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

	// Token: 0x0600017C RID: 380 RVA: 0x00007CDC File Offset: 0x00005EDC
	private float ReadRadiusByKey(int myEntityId, string key)
	{
		if (string.IsNullOrEmpty(key))
		{
			return 0f;
		}
		return BlackboardController.Instance.GetFloatValueByEntity(myEntityId, key).GetValueOrDefault();
	}

	// Token: 0x0600017D RID: 381 RVA: 0x00007D0C File Offset: 0x00005F0C
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

	// Token: 0x0600017E RID: 382 RVA: 0x00007DBC File Offset: 0x00005FBC
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

	// Token: 0x0600017F RID: 383 RVA: 0x00007F09 File Offset: 0x00006109
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorBlackboardActorsLocation._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorBlackboardActorsLocation.TsDecoratorBlackboardActorsLocation_C");
		}
		return TsDecoratorBlackboardActorsLocation._ClassPtr;
	}

	// Token: 0x06000180 RID: 384 RVA: 0x00007F30 File Offset: 0x00006130
	public TsDecoratorBlackboardActorsLocation() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorBlackboardActorsLocation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000181 RID: 385 RVA: 0x00007F58 File Offset: 0x00006158
	public TsDecoratorBlackboardActorsLocation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorBlackboardActorsLocation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000182 RID: 386 RVA: 0x00007F8C File Offset: 0x0000618C
	protected TsDecoratorBlackboardActorsLocation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000183 RID: 387 RVA: 0x0000801C File Offset: 0x0000621C
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
