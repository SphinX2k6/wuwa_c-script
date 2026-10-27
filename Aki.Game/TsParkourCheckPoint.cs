using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game;
using CSharpScript.Game.Effect;
using CSharpScript.Game.LevelGamePlay.Parkour;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000EE5 RID: 3813
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/LevelGamePlay/Parkour/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/LevelGamePlay/Parkour/TsParkourCheckPoint.TsParkourCheckPoint_C")]
public class TsParkourCheckPoint : AActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000750 RID: 1872
	// (get) Token: 0x06005F65 RID: 24421 RVA: 0x0011DA63 File Offset: 0x0011BC63
	// (set) Token: 0x06005F66 RID: 24422 RVA: 0x0011DA77 File Offset: 0x0011BC77
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe USphereComponent SphereComponent
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsParkourCheckPoint.__PropertyOffset_SphereComponent);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsParkourCheckPoint.__PropertyOffset_SphereComponent, value);
		}
	}

	// Token: 0x17000751 RID: 1873
	// (get) Token: 0x06005F67 RID: 24423 RVA: 0x0011DA8C File Offset: 0x0011BC8C
	// (set) Token: 0x06005F68 RID: 24424 RVA: 0x0011DA9C File Offset: 0x0011BC9C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int CheckPointIndex
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsParkourCheckPoint.__PropertyOffset_CheckPointIndex);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsParkourCheckPoint.__PropertyOffset_CheckPointIndex) = value;
		}
	}

	// Token: 0x17000752 RID: 1874
	// (get) Token: 0x06005F69 RID: 24425 RVA: 0x0011DAAD File Offset: 0x0011BCAD
	// (set) Token: 0x06005F6A RID: 24426 RVA: 0x0011DABD File Offset: 0x0011BCBD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int IndexInGroup
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsParkourCheckPoint.__PropertyOffset_IndexInGroup);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsParkourCheckPoint.__PropertyOffset_IndexInGroup) = value;
		}
	}

	// Token: 0x17000753 RID: 1875
	// (get) Token: 0x06005F6B RID: 24427 RVA: 0x0011DACE File Offset: 0x0011BCCE
	// (set) Token: 0x06005F6C RID: 24428 RVA: 0x0011DADE File Offset: 0x0011BCDE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int ParkourId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsParkourCheckPoint.__PropertyOffset_ParkourId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsParkourCheckPoint.__PropertyOffset_ParkourId) = value;
		}
	}

	// Token: 0x17000754 RID: 1876
	// (get) Token: 0x06005F6D RID: 24429 RVA: 0x0011DAEF File Offset: 0x0011BCEF
	// (set) Token: 0x06005F6E RID: 24430 RVA: 0x0011DB03 File Offset: 0x0011BD03
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string CheckTag
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsParkourCheckPoint.__PropertyOffset_CheckTag)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsParkourCheckPoint.__PropertyOffset_CheckTag)), value);
		}
	}

	// Token: 0x17000755 RID: 1877
	// (get) Token: 0x06005F6F RID: 24431 RVA: 0x0011DB18 File Offset: 0x0011BD18
	// (set) Token: 0x06005F70 RID: 24432 RVA: 0x0011DB2C File Offset: 0x0011BD2C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string DestroyEffectModelBasePath
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsParkourCheckPoint.__PropertyOffset_DestroyEffectModelBasePath)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsParkourCheckPoint.__PropertyOffset_DestroyEffectModelBasePath)), value);
		}
	}

	// Token: 0x06005F71 RID: 24433 RVA: 0x0011DB44 File Offset: 0x0011BD44
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveBeginPlay()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveBeginPlay"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06005F72 RID: 24434 RVA: 0x0011DBB4 File Offset: 0x0011BDB4
	protected virtual void ReceiveBeginPlay_Implementation()
	{
		this.FindComponents();
		this.SphereComponent.SetCollisionProfileName(TsParkourCheckPoint.PARKOUR_CHECK_POINT_PRESET, true);
		this.SphereComponent.bKuroPassiveCollisionUpdateOverlapsWhenEnterOverlap = true;
		this.SphereComponent.bKuroPassiveCollision = true;
		this.RegisterEvents();
	}

	// Token: 0x06005F73 RID: 24435 RVA: 0x0011DBEC File Offset: 0x0011BDEC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveEndPlay(EEndPlayReason endPlayReason)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveEndPlay"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AActor.__ReceiveEndPlay_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AActor.__ReceiveEndPlay_FunctionParams*)ptr + 15L / (long)sizeof(AActor.__ReceiveEndPlay_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(byte*)(&ptr2->EndPlayReason) = (byte)endPlayReason;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06005F74 RID: 24436 RVA: 0x0011DC68 File Offset: 0x0011BE68
	protected virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		this.RemoveEvents();
		if (this.EffectViewHandler != 0)
		{
			EffectSystem.Instance.StopEffectById(this.EffectViewHandler, "[TsParkourCheckPoint.ReceiveEndPlay]", false, null);
			this.EffectViewHandler = 0;
		}
		if (!StringUtils.IsEmpty(this.DestroyEffectModelBasePath))
		{
			EffectSystem instance = EffectSystem.Instance;
			FTransformDouble? ftransformDouble = new FTransformDouble?(base.D_GetTransform());
			instance.SpawnUnloopedEffect(this, ftransformDouble, this.DestroyEffectModelBasePath, "[TsParkourCheckPoint.ReceiveEndPlay]", null, EEffectType.Scene, null, null, null, false, false);
		}
	}

	// Token: 0x06005F75 RID: 24437 RVA: 0x0011DCE4 File Offset: 0x0011BEE4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetDetectSphere(float inRadius)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetDetectSphere"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsParkourCheckPoint.__SetDetectSphere_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsParkourCheckPoint.__SetDetectSphere_FunctionParams*)ptr + 15L / (long)sizeof(TsParkourCheckPoint.__SetDetectSphere_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->inRadius = inRadius;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06005F76 RID: 24438 RVA: 0x0011DD5A File Offset: 0x0011BF5A
	protected void SetDetectSphere_Implementation(float inRadius)
	{
		this.SphereComponent.SetSphereRadius(inRadius, true);
	}

	// Token: 0x06005F77 RID: 24439 RVA: 0x0011DD6C File Offset: 0x0011BF6C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void GenerateFx(UEffectModelBase inModelBase)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GenerateFx"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsParkourCheckPoint.__GenerateFx_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsParkourCheckPoint.__GenerateFx_FunctionParams*)ptr + 15L / (long)sizeof(TsParkourCheckPoint.__GenerateFx_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->inModelBase) = ((inModelBase != null) ? inModelBase.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06005F78 RID: 24440 RVA: 0x0011DDF0 File Offset: 0x0011BFF0
	protected void GenerateFx_Implementation(UEffectModelBase inModelBase)
	{
		string pathName = UKismetSystemLibrary.GetPathName(inModelBase);
		EffectSystem instance = EffectSystem.Instance;
		FTransformDouble? ftransformDouble = new FTransformDouble?(base.D_GetTransform());
		this.EffectViewHandler = instance.SpawnEffect(this, ftransformDouble, pathName, "[TsParkourCheckPoint.GenerateFx]", new EffectContext(null, this, false), EEffectType.Scene, null, null, null, false, false);
		if (!EffectSystem.Instance.IsValid(this.EffectViewHandler))
		{
			this.EffectViewHandler = 0;
		}
	}

	// Token: 0x06005F79 RID: 24441 RVA: 0x0011DE58 File Offset: 0x0011C058
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void GenerateFxByPath(string effectPath)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GenerateFxByPath"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsParkourCheckPoint.__GenerateFxByPath_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsParkourCheckPoint.__GenerateFxByPath_FunctionParams*)ptr + 15L / (long)sizeof(TsParkourCheckPoint.__GenerateFxByPath_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			FString.CopyFrom((void*)(&ptr2->effectPath), effectPath);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06005F7A RID: 24442 RVA: 0x0011DED4 File Offset: 0x0011C0D4
	protected void GenerateFxByPath_Implementation(string effectPath)
	{
		EffectSystem instance = EffectSystem.Instance;
		FTransformDouble? ftransformDouble = new FTransformDouble?(base.D_GetTransform());
		this.EffectViewHandler = instance.SpawnEffect(this, ftransformDouble, effectPath, "[TsParkourCheckPoint.GenerateFxByPath]", new EffectContext(null, this, false), EEffectType.Scene, null, null, null, false, false);
		if (!EffectSystem.Instance.IsValid(this.EffectViewHandler))
		{
			this.EffectViewHandler = 0;
		}
	}

	// Token: 0x06005F7B RID: 24443 RVA: 0x0011DF35 File Offset: 0x0011C135
	private void FindComponents()
	{
		if (this.SphereComponent == null)
		{
			this.SphereComponent = (base.GetComponentByClass(USphereComponent.StaticClass()) as USphereComponent);
		}
	}

	// Token: 0x06005F7C RID: 24444 RVA: 0x0011DF5C File Offset: 0x0011C15C
	private void RegisterEvents()
	{
		if (!this.EventRegistered)
		{
			this.SphereComponent.OnComponentBeginOverlapNoGcAlloc.Add(delegate(UPrimitiveComponent overlappedComponent, AActor otherActor, UPrimitiveComponent otherComp)
			{
				this.OnCollisionEnter(otherActor);
			});
			this.SphereComponent.OnComponentEndOverlap.Add(delegate(UPrimitiveComponent overlappedComponent, AActor otherActor, UPrimitiveComponent otherComp, int otherBodyIndex)
			{
				this.OnCollisionExit(otherActor);
			});
			this.EventRegistered = true;
		}
	}

	// Token: 0x06005F7D RID: 24445 RVA: 0x0011DFB0 File Offset: 0x0011C1B0
	private void RemoveEvents()
	{
		if (this.SphereComponent != null)
		{
			this.SphereComponent.OnComponentBeginOverlapNoGcAlloc.Clear();
			this.SphereComponent.OnComponentEndOverlap.Clear();
		}
		this.EventRegistered = false;
	}

	// Token: 0x06005F7E RID: 24446 RVA: 0x0011DFE4 File Offset: 0x0011C1E4
	[NullableContext(2)]
	protected unsafe void OnCollisionEnter(AActor otherActor)
	{
		if (!ParkourController.Instance.MatchParkourRoleConfig(this.ParkourId))
		{
			return;
		}
		if (otherActor != RoleTriggerController.Instance.GetMyRoleTrigger())
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Level;
		ELogAuthor author = ELogAuthor.YZH;
		string message = "[ParkourCheckPoint]检测到玩家";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ParkourId", this.ParkourId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Index", this.CheckPointIndex);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		if (!StringUtils.IsEmpty(this.CheckTag))
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			Entity entity;
			if (baseCharacter == null)
			{
				entity = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
				entity = ((characterActorComponent != null) ? characterActorComponent.Entity : null);
			}
			Entity entity2 = entity;
			if (entity2 != null)
			{
				BaseTagComponent component = entity2.GetComponent<BaseTagComponent>();
				if (component != null)
				{
					int tagIdByName = GameplayTagUtils.GetTagIdByName(this.CheckTag);
					if (!component.HasTag(tagIdByName))
					{
						return;
					}
				}
			}
		}
		if (this.ParkourId != 0)
		{
			ParkourController.Instance.HandleParkourPoint(this.ParkourId, this.CheckPointIndex, this.IndexInGroup);
		}
	}

	// Token: 0x06005F7F RID: 24447 RVA: 0x0011E0EA File Offset: 0x0011C2EA
	[NullableContext(2)]
	protected void OnCollisionExit(AActor otherActor)
	{
	}

	// Token: 0x06005F80 RID: 24448 RVA: 0x0011E0EC File Offset: 0x0011C2EC
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsParkourCheckPoint._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/LevelGamePlay/Parkour/TsParkourCheckPoint.TsParkourCheckPoint_C");
		}
		return TsParkourCheckPoint._ClassPtr;
	}

	// Token: 0x06005F81 RID: 24449 RVA: 0x0011E110 File Offset: 0x0011C310
	public TsParkourCheckPoint() : this(BuiltinUtils.AllocNativeUObject(TsParkourCheckPoint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06005F82 RID: 24450 RVA: 0x0011E138 File Offset: 0x0011C338
	public TsParkourCheckPoint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsParkourCheckPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06005F83 RID: 24451 RVA: 0x0011E16B File Offset: 0x0011C36B
	protected TsParkourCheckPoint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x17000756 RID: 1878
	// (get) Token: 0x06005F84 RID: 24452 RVA: 0x0011E174 File Offset: 0x0011C374
	public unsafe FPointerToUberGraphFrame UberGraphFrame
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsParkourCheckPoint.__PropertyOffset_UberGraphFrame);
		}
	}

	// Token: 0x17000757 RID: 1879
	// (get) Token: 0x06005F85 RID: 24453 RVA: 0x0011E184 File Offset: 0x0011C384
	[Nullable(2)]
	public unsafe USceneComponent DefaultSceneRoot
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsParkourCheckPoint.__PropertyOffset_DefaultSceneRoot);
		}
	}

	// Token: 0x06005F86 RID: 24454 RVA: 0x0011E198 File Offset: 0x0011C398
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x06005F87 RID: 24455 RVA: 0x0011E1A0 File Offset: 0x0011C3A0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		this.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x06005F88 RID: 24456 RVA: 0x0011E1C0 File Offset: 0x0011C3C0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_SetDetectSphere_Implementation(TsParkourCheckPoint.__SetDetectSphere_FunctionParams* __Params)
	{
		this.SetDetectSphere_Implementation(__Params->inRadius);
	}

	// Token: 0x06005F89 RID: 24457 RVA: 0x0011E1D0 File Offset: 0x0011C3D0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GenerateFx_Implementation(TsParkourCheckPoint.__GenerateFx_FunctionParams* __Params)
	{
		UEffectModelBase orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UEffectModelBase>(__Params->inModelBase);
		this.GenerateFx_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x06005F8A RID: 24458 RVA: 0x0011E1F0 File Offset: 0x0011C3F0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GenerateFxByPath_Implementation(TsParkourCheckPoint.__GenerateFxByPath_FunctionParams* __Params)
	{
		string effectPath = FString.ToString((void*)(&__Params->effectPath));
		this.GenerateFxByPath_Implementation(effectPath);
	}

	// Token: 0x04002B3D RID: 11069
	[StaticVariableRuleIgnore]
	public static readonly FName PARKOUR_CHECK_POINT_PRESET = new FName("ParkourCheckPoint");

	// Token: 0x04002B3E RID: 11070
	private int EffectViewHandler;

	// Token: 0x04002B3F RID: 11071
	private bool EventRegistered;

	// Token: 0x04002B40 RID: 11072
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/LevelGamePlay/Parkour/TsParkourCheckPoint.TsParkourCheckPoint_C";

	// Token: 0x04002B41 RID: 11073
	private static IntPtr _ClassPtr;

	// Token: 0x04002B42 RID: 11074
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04002B43 RID: 11075
	private static int __PropertyOffset_UberGraphFrame;

	// Token: 0x04002B44 RID: 11076
	private static int __PropertyOffset_DefaultSceneRoot;

	// Token: 0x04002B45 RID: 11077
	private static int __PropertyOffset_SphereComponent;

	// Token: 0x04002B46 RID: 11078
	private static int __PropertyOffset_CheckPointIndex;

	// Token: 0x04002B47 RID: 11079
	private static int __PropertyOffset_IndexInGroup;

	// Token: 0x04002B48 RID: 11080
	private static int __PropertyOffset_ParkourId;

	// Token: 0x04002B49 RID: 11081
	private static int __PropertyOffset_CheckTag;

	// Token: 0x04002B4A RID: 11082
	private static int __PropertyOffset_DestroyEffectModelBasePath;

	// Token: 0x02007544 RID: 30020
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __SetDetectSphere_FunctionParams
	{
		// Token: 0x04026C7A RID: 158842
		[FieldOffset(0)]
		public float inRadius;
	}

	// Token: 0x02007545 RID: 30021
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __GenerateFx_FunctionParams
	{
		// Token: 0x04026C7B RID: 158843
		[FieldOffset(0)]
		public IntPtr inModelBase;
	}

	// Token: 0x02007546 RID: 30022
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GenerateFxByPath_FunctionParams
	{
		// Token: 0x04026C7C RID: 158844
		[FieldOffset(0)]
		public FString effectPath;
	}
}
