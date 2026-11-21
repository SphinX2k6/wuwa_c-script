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

// Token: 0x0200039A RID: 922
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/LevelGamePlay/Parkour/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/LevelGamePlay/Parkour/TsParkourCheckPoint.TsParkourCheckPoint_C")]
public class TsParkourCheckPoint : AActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000773 RID: 1907
	// (get) Token: 0x060032FC RID: 13052 RVA: 0x0012588B File Offset: 0x00123A8B
	// (set) Token: 0x060032FD RID: 13053 RVA: 0x0012589F File Offset: 0x00123A9F
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

	// Token: 0x17000774 RID: 1908
	// (get) Token: 0x060032FE RID: 13054 RVA: 0x001258B4 File Offset: 0x00123AB4
	// (set) Token: 0x060032FF RID: 13055 RVA: 0x001258C4 File Offset: 0x00123AC4
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

	// Token: 0x17000775 RID: 1909
	// (get) Token: 0x06003300 RID: 13056 RVA: 0x001258D5 File Offset: 0x00123AD5
	// (set) Token: 0x06003301 RID: 13057 RVA: 0x001258E5 File Offset: 0x00123AE5
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

	// Token: 0x17000776 RID: 1910
	// (get) Token: 0x06003302 RID: 13058 RVA: 0x001258F6 File Offset: 0x00123AF6
	// (set) Token: 0x06003303 RID: 13059 RVA: 0x00125906 File Offset: 0x00123B06
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

	// Token: 0x17000777 RID: 1911
	// (get) Token: 0x06003304 RID: 13060 RVA: 0x00125917 File Offset: 0x00123B17
	// (set) Token: 0x06003305 RID: 13061 RVA: 0x0012592B File Offset: 0x00123B2B
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

	// Token: 0x17000778 RID: 1912
	// (get) Token: 0x06003306 RID: 13062 RVA: 0x00125940 File Offset: 0x00123B40
	// (set) Token: 0x06003307 RID: 13063 RVA: 0x00125954 File Offset: 0x00123B54
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

	// Token: 0x06003308 RID: 13064 RVA: 0x0012596C File Offset: 0x00123B6C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void ReceiveBeginPlay()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsParkourCheckPoint) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveBeginPlay"), TsParkourCheckPoint.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ReceiveBeginPlay_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06003309 RID: 13065 RVA: 0x001259C5 File Offset: 0x00123BC5
	protected virtual void ReceiveBeginPlay_Implementation()
	{
		this.FindComponents();
		this.SphereComponent.SetCollisionProfileName(TsParkourCheckPoint.PARKOUR_CHECK_POINT_PRESET, true);
		this.SphereComponent.bKuroPassiveCollisionUpdateOverlapsWhenEnterOverlap = true;
		this.SphereComponent.bKuroPassiveCollision = true;
		this.RegisterEvents();
	}

	// Token: 0x0600330A RID: 13066 RVA: 0x001259FC File Offset: 0x00123BFC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveEndPlay(EEndPlayReason endPlayReason)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsParkourCheckPoint) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveEndPlay"), TsParkourCheckPoint.StaticClass(), out intPtr, out num))
		{
			this.ReceiveEndPlay_Implementation(endPlayReason);
			return;
		}
		AActor.__ReceiveEndPlay_FunctionParams* ptr = stackalloc AActor.__ReceiveEndPlay_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AActor.__ReceiveEndPlay_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(byte*)(&ptr->EndPlayReason) = (byte)endPlayReason;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0600330B RID: 13067 RVA: 0x00125A8C File Offset: 0x00123C8C
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

	// Token: 0x0600330C RID: 13068 RVA: 0x00125B08 File Offset: 0x00123D08
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetDetectSphere(float inRadius)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsParkourCheckPoint) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetDetectSphere"), TsParkourCheckPoint.StaticClass(), out intPtr, out num))
		{
			this.SetDetectSphere_Implementation(inRadius);
			return;
		}
		TsParkourCheckPoint.__SetDetectSphere_FunctionParams* ptr = stackalloc TsParkourCheckPoint.__SetDetectSphere_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsParkourCheckPoint.__SetDetectSphere_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->inRadius = inRadius;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0600330D RID: 13069 RVA: 0x00125B94 File Offset: 0x00123D94
	protected void SetDetectSphere_Implementation(float inRadius)
	{
		this.SphereComponent.SetSphereRadius(inRadius, true);
	}

	// Token: 0x0600330E RID: 13070 RVA: 0x00125BA4 File Offset: 0x00123DA4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void GenerateFx(UEffectModelBase inModelBase)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsParkourCheckPoint) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GenerateFx"), TsParkourCheckPoint.StaticClass(), out intPtr, out num))
		{
			this.GenerateFx_Implementation(inModelBase);
			return;
		}
		TsParkourCheckPoint.__GenerateFx_FunctionParams* ptr = stackalloc TsParkourCheckPoint.__GenerateFx_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsParkourCheckPoint.__GenerateFx_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->inModelBase) = ((inModelBase != null) ? inModelBase.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0600330F RID: 13071 RVA: 0x00125C40 File Offset: 0x00123E40
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

	// Token: 0x06003310 RID: 13072 RVA: 0x00125CA8 File Offset: 0x00123EA8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void GenerateFxByPath(string effectPath)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsParkourCheckPoint) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GenerateFxByPath"), TsParkourCheckPoint.StaticClass(), out intPtr, out num))
		{
			this.GenerateFxByPath_Implementation(effectPath);
			return;
		}
		TsParkourCheckPoint.__GenerateFxByPath_FunctionParams* ptr = stackalloc TsParkourCheckPoint.__GenerateFxByPath_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsParkourCheckPoint.__GenerateFxByPath_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		FString.CopyFrom((void*)(&ptr->effectPath), effectPath);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06003311 RID: 13073 RVA: 0x00125D3C File Offset: 0x00123F3C
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

	// Token: 0x06003312 RID: 13074 RVA: 0x00125D9D File Offset: 0x00123F9D
	private void FindComponents()
	{
		if (this.SphereComponent == null)
		{
			this.SphereComponent = (base.GetComponentByClass(USphereComponent.StaticClass()) as USphereComponent);
		}
	}

	// Token: 0x06003313 RID: 13075 RVA: 0x00125DC4 File Offset: 0x00123FC4
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

	// Token: 0x06003314 RID: 13076 RVA: 0x00125E18 File Offset: 0x00124018
	private void RemoveEvents()
	{
		if (this.SphereComponent != null)
		{
			this.SphereComponent.OnComponentBeginOverlapNoGcAlloc.Clear();
			this.SphereComponent.OnComponentEndOverlap.Clear();
		}
		this.EventRegistered = false;
	}

	// Token: 0x06003315 RID: 13077 RVA: 0x00125E4C File Offset: 0x0012404C
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

	// Token: 0x06003316 RID: 13078 RVA: 0x00125F52 File Offset: 0x00124152
	[NullableContext(2)]
	protected void OnCollisionExit(AActor otherActor)
	{
	}

	// Token: 0x06003317 RID: 13079 RVA: 0x00125F54 File Offset: 0x00124154
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsParkourCheckPoint._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/LevelGamePlay/Parkour/TsParkourCheckPoint.TsParkourCheckPoint_C");
		}
		return TsParkourCheckPoint._ClassPtr;
	}

	// Token: 0x06003318 RID: 13080 RVA: 0x00125F78 File Offset: 0x00124178
	public TsParkourCheckPoint() : this(BuiltinUtils.AllocNativeUObject(TsParkourCheckPoint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06003319 RID: 13081 RVA: 0x00125FA0 File Offset: 0x001241A0
	public TsParkourCheckPoint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsParkourCheckPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600331A RID: 13082 RVA: 0x00125FD3 File Offset: 0x001241D3
	protected TsParkourCheckPoint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x17000779 RID: 1913
	// (get) Token: 0x0600331B RID: 13083 RVA: 0x00125FDC File Offset: 0x001241DC
	[Nullable(2)]
	public unsafe USceneComponent DefaultSceneRoot
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsParkourCheckPoint.__PropertyOffset_DefaultSceneRoot);
		}
	}

	// Token: 0x0600331C RID: 13084 RVA: 0x00125FF0 File Offset: 0x001241F0
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0600331D RID: 13085 RVA: 0x00125FF8 File Offset: 0x001241F8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		this.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0600331E RID: 13086 RVA: 0x00126018 File Offset: 0x00124218
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_SetDetectSphere_Implementation(TsParkourCheckPoint.__SetDetectSphere_FunctionParams* __Params)
	{
		this.SetDetectSphere_Implementation(__Params->inRadius);
	}

	// Token: 0x0600331F RID: 13087 RVA: 0x00126028 File Offset: 0x00124228
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GenerateFx_Implementation(TsParkourCheckPoint.__GenerateFx_FunctionParams* __Params)
	{
		UEffectModelBase orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UEffectModelBase>(__Params->inModelBase);
		this.GenerateFx_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x06003320 RID: 13088 RVA: 0x00126048 File Offset: 0x00124248
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GenerateFxByPath_Implementation(TsParkourCheckPoint.__GenerateFxByPath_FunctionParams* __Params)
	{
		string effectPath = FString.ToString((void*)(&__Params->effectPath));
		this.GenerateFxByPath_Implementation(effectPath);
	}

	// Token: 0x04002BD7 RID: 11223
	[StaticVariableRuleIgnore]
	public static readonly FName PARKOUR_CHECK_POINT_PRESET = new FName("ParkourCheckPoint");

	// Token: 0x04002BD8 RID: 11224
	private int EffectViewHandler;

	// Token: 0x04002BD9 RID: 11225
	private bool EventRegistered;

	// Token: 0x04002BDA RID: 11226
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/LevelGamePlay/Parkour/TsParkourCheckPoint.TsParkourCheckPoint_C";

	// Token: 0x04002BDB RID: 11227
	private static IntPtr _ClassPtr;

	// Token: 0x04002BDC RID: 11228
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04002BDD RID: 11229
	private static int __PropertyOffset_DefaultSceneRoot;

	// Token: 0x04002BDE RID: 11230
	private static int __PropertyOffset_SphereComponent;

	// Token: 0x04002BDF RID: 11231
	private static int __PropertyOffset_CheckPointIndex;

	// Token: 0x04002BE0 RID: 11232
	private static int __PropertyOffset_IndexInGroup;

	// Token: 0x04002BE1 RID: 11233
	private static int __PropertyOffset_ParkourId;

	// Token: 0x04002BE2 RID: 11234
	private static int __PropertyOffset_CheckTag;

	// Token: 0x04002BE3 RID: 11235
	private static int __PropertyOffset_DestroyEffectModelBasePath;

	// Token: 0x020066D8 RID: 26328
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __SetDetectSphere_FunctionParams
	{
		// Token: 0x04021FC5 RID: 139205
		[FieldOffset(0)]
		public float inRadius;
	}

	// Token: 0x020066D9 RID: 26329
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __GenerateFx_FunctionParams
	{
		// Token: 0x04021FC6 RID: 139206
		[FieldOffset(0)]
		public IntPtr inModelBase;
	}

	// Token: 0x020066DA RID: 26330
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GenerateFxByPath_FunctionParams
	{
		// Token: 0x04021FC7 RID: 139207
		[FieldOffset(0)]
		public FString effectPath;
	}
}
