using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.CreatureTools;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002871 RID: 10353
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Vehicle/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Vehicle/TsBaseVehicle.TsBaseVehicle_C")]
public class TsBaseVehicle : AKuroBaseVehicle, IBPI_CreatureInterface_C, IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject, IUnrealUObject
{
	// Token: 0x17002AF8 RID: 11000
	// (get) Token: 0x0601A3FC RID: 107516 RVA: 0x008218DD File Offset: 0x0081FADD
	// (set) Token: 0x0601A3FD RID: 107517 RVA: 0x008218ED File Offset: 0x0081FAED
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int EntityId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsBaseVehicle.__PropertyOffset_EntityId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsBaseVehicle.__PropertyOffset_EntityId) = value;
		}
	}

	// Token: 0x0601A3FE RID: 107518 RVA: 0x008218FE File Offset: 0x0081FAFE
	public void SetEntityId(int entityId)
	{
		this.EntityId = entityId;
		base.EntityIdInternal = entityId;
	}

	// Token: 0x17002AF9 RID: 11001
	// (get) Token: 0x0601A3FF RID: 107519 RVA: 0x0082190E File Offset: 0x0081FB0E
	// (set) Token: 0x0601A400 RID: 107520 RVA: 0x00821922 File Offset: 0x0081FB22
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe CharRenderingComponent CharRenderingComponent
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<CharRenderingComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseVehicle.__PropertyOffset_CharRenderingComponent);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseVehicle.__PropertyOffset_CharRenderingComponent, value);
		}
	}

	// Token: 0x17002AFA RID: 11002
	// (get) Token: 0x0601A401 RID: 107521 RVA: 0x00821937 File Offset: 0x0081FB37
	// (set) Token: 0x0601A402 RID: 107522 RVA: 0x00821947 File Offset: 0x0081FB47
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe ECharacterRenderingType RenderType
	{
		get
		{
			return (ECharacterRenderingType)(*(base.NativePtr + (IntPtr)TsBaseVehicle.__PropertyOffset_RenderType));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsBaseVehicle.__PropertyOffset_RenderType) = (byte)value;
		}
	}

	// Token: 0x17002AFB RID: 11003
	// (get) Token: 0x0601A403 RID: 107523 RVA: 0x00821958 File Offset: 0x0081FB58
	// (set) Token: 0x0601A404 RID: 107524 RVA: 0x00821991 File Offset: 0x0081FB91
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public FSoftClassPath InputComponentClass
	{
		[NullableContext(1)]
		get
		{
			base.FastCheckIsValid();
			FSoftClassPath result;
			if ((result = this._InputComponentClass) == null)
			{
				result = (this._InputComponentClass = new FSoftClassPath(base.NativePtr + (IntPtr)TsBaseVehicle.__PropertyOffset_InputComponentClass, this));
			}
			return result;
		}
		[NullableContext(1)]
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)TsBaseVehicle.__PropertyOffset_InputComponentClass, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002AFC RID: 11004
	// (get) Token: 0x0601A405 RID: 107525 RVA: 0x008219B9 File Offset: 0x0081FBB9
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe AActor PlatformActor
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + TsBaseVehicle.__PropertyOffset_PlatformActor);
		}
	}

	// Token: 0x0601A406 RID: 107526 RVA: 0x008219D0 File Offset: 0x0081FBD0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual int GetEntityId()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsBaseVehicle) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetEntityId"), TsBaseVehicle.StaticClass(), out intPtr, out num))
		{
			return this.GetEntityId_Implementation();
		}
		TsBaseVehicle.__GetEntityId_FunctionParams* ptr = stackalloc TsBaseVehicle.__GetEntityId_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsBaseVehicle.__GetEntityId_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		int _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0601A407 RID: 107527 RVA: 0x00821A5A File Offset: 0x0081FC5A
	protected int GetEntityId_Implementation()
	{
		return ((IBPI_CreatureInterface_C)this).GetEntityId();
	}

	// Token: 0x0601A408 RID: 107528 RVA: 0x00821A62 File Offset: 0x0081FC62
	int IBPI_CreatureInterface_C.GetEntityId()
	{
		if (this.VehicleActorComponent != null)
		{
			return this.VehicleActorComponent.Entity.Id;
		}
		return 0;
	}

	// Token: 0x0601A409 RID: 107529 RVA: 0x00821A7E File Offset: 0x0081FC7E
	public int GetEntityIdNoBlueprint()
	{
		if (this.VehicleActorComponent != null)
		{
			return this.VehicleActorComponent.Entity.Id;
		}
		return 0;
	}

	// Token: 0x0601A40A RID: 107530 RVA: 0x00821A9A File Offset: 0x0081FC9A
	[NullableContext(2)]
	public Entity GetEntityNoBlueprint()
	{
		if (this.VehicleActorComponent != null)
		{
			return this.VehicleActorComponent.Entity;
		}
		return null;
	}

	// Token: 0x0601A40B RID: 107531 RVA: 0x00821AB4 File Offset: 0x0081FCB4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void ReceiveDestroyed()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsBaseVehicle) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveDestroyed"), TsBaseVehicle.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ReceiveDestroyed_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601A40C RID: 107532 RVA: 0x00821B0D File Offset: 0x0081FD0D
	protected virtual void ReceiveDestroyed_Implementation()
	{
		if (!ObjectUtils.IsValid(this))
		{
			return;
		}
		this.InputComponentClass = null;
		this.VehicleActorComponent = null;
		this.CharRenderingComponent = null;
		this.DitherEffectControllerInternal = null;
	}

	// Token: 0x0601A40D RID: 107533 RVA: 0x00821B34 File Offset: 0x0081FD34
	public void TryAddTsAbilitySystemComponent()
	{
		if (base.AbilitySystemComponent == null)
		{
			base.AbilitySystemComponent = (base.AddComponentByClass(UBaseAbilitySystemComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as UBaseAbilitySystemComponent);
		}
	}

	// Token: 0x17002AFD RID: 11005
	// (get) Token: 0x0601A40E RID: 107534 RVA: 0x00821B79 File Offset: 0x0081FD79
	// (set) Token: 0x0601A40F RID: 107535 RVA: 0x00821B9B File Offset: 0x0081FD9B
	[Nullable(1)]
	public CharacterDitherEffectController DitherEffectController
	{
		[NullableContext(1)]
		get
		{
			if (this.DitherEffectControllerInternal == null)
			{
				this.DitherEffectControllerInternal = new CharacterDitherEffectController(this, this.CharRenderingComponent);
			}
			return this.DitherEffectControllerInternal;
		}
		[NullableContext(1)]
		set
		{
			this.DitherEffectControllerInternal = value;
		}
	}

	// Token: 0x17002AFE RID: 11006
	// (get) Token: 0x0601A410 RID: 107536 RVA: 0x00821BA4 File Offset: 0x0081FDA4
	public bool HasDitherEffectController
	{
		get
		{
			return this.DitherEffectControllerInternal != null;
		}
	}

	// Token: 0x0601A411 RID: 107537 RVA: 0x00821BB0 File Offset: 0x0081FDB0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetDitherEffect(float dither, ECharacterDitherType ditherType = ECharacterDitherType.Temporary)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsBaseVehicle) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetDitherEffect"), TsBaseVehicle.StaticClass(), out intPtr, out num))
		{
			this.SetDitherEffect_Implementation(dither, ditherType);
			return;
		}
		TsBaseVehicle.__SetDitherEffect_FunctionParams* ptr = stackalloc TsBaseVehicle.__SetDitherEffect_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsBaseVehicle.__SetDitherEffect_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->dither = dither;
		*(&ptr->ditherType) = (byte)ditherType;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601A412 RID: 107538 RVA: 0x00821C46 File Offset: 0x0081FE46
	protected void SetDitherEffect_Implementation(float dither, ECharacterDitherType ditherType = ECharacterDitherType.Temporary)
	{
		this.DitherEffectController.SetDitherEffect((double)dither, ditherType, true);
	}

	// Token: 0x0601A413 RID: 107539 RVA: 0x00821C57 File Offset: 0x0081FE57
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsBaseVehicle._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Vehicle/TsBaseVehicle.TsBaseVehicle_C");
		}
		return TsBaseVehicle._ClassPtr;
	}

	// Token: 0x0601A414 RID: 107540 RVA: 0x00821C7C File Offset: 0x0081FE7C
	public TsBaseVehicle() : this(BuiltinUtils.AllocNativeUObject(TsBaseVehicle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601A415 RID: 107541 RVA: 0x00821CA4 File Offset: 0x0081FEA4
	[NullableContext(1)]
	public TsBaseVehicle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBaseVehicle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601A416 RID: 107542 RVA: 0x00821CD7 File Offset: 0x0081FED7
	protected TsBaseVehicle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601A417 RID: 107543 RVA: 0x00821CE0 File Offset: 0x0081FEE0
	protected unsafe virtual void __CPPCALL_GetEntityId_Implementation(TsBaseVehicle.__GetEntityId_FunctionParams* __Params)
	{
		__Params->__Result = this.GetEntityId_Implementation();
	}

	// Token: 0x0601A418 RID: 107544 RVA: 0x00821CEE File Offset: 0x0081FEEE
	protected virtual void __CPPCALL_ReceiveDestroyed_Implementation()
	{
		this.ReceiveDestroyed_Implementation();
	}

	// Token: 0x0601A419 RID: 107545 RVA: 0x00821CF8 File Offset: 0x0081FEF8
	protected unsafe virtual void __CPPCALL_SetDitherEffect_Implementation(TsBaseVehicle.__SetDitherEffect_FunctionParams* __Params)
	{
		ECharacterDitherType ditherType = (ECharacterDitherType)__Params->ditherType;
		this.SetDitherEffect_Implementation(__Params->dither, ditherType);
	}

	// Token: 0x0400E679 RID: 59001
	[Nullable(2)]
	public VehicleActorComponent VehicleActorComponent;

	// Token: 0x0400E67A RID: 59002
	[Nullable(2)]
	private CharacterDitherEffectController DitherEffectControllerInternal;

	// Token: 0x0400E67B RID: 59003
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Vehicle/TsBaseVehicle.TsBaseVehicle_C";

	// Token: 0x0400E67C RID: 59004
	private static IntPtr _ClassPtr;

	// Token: 0x0400E67D RID: 59005
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E67E RID: 59006
	private static int __PropertyOffset_EntityId;

	// Token: 0x0400E67F RID: 59007
	private static int __PropertyOffset_CharRenderingComponent;

	// Token: 0x0400E680 RID: 59008
	private static int __PropertyOffset_RenderType;

	// Token: 0x0400E681 RID: 59009
	private static int __PropertyOffset_InputComponentClass;

	// Token: 0x0400E682 RID: 59010
	[Nullable(2)]
	private FSoftClassPath _InputComponentClass;

	// Token: 0x0400E683 RID: 59011
	private static int __PropertyOffset_PlatformActor;

	// Token: 0x020089AE RID: 35246
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __GetEntityId_FunctionParams
	{
		// Token: 0x0402BDA2 RID: 179618
		[FieldOffset(0)]
		public int __Result;
	}

	// Token: 0x020089AF RID: 35247
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SetDitherEffect_FunctionParams
	{
		// Token: 0x0402BDA3 RID: 179619
		[FieldOffset(0)]
		public float dither;

		// Token: 0x0402BDA4 RID: 179620
		[FieldOffset(4)]
		public byte ditherType;
	}
}
