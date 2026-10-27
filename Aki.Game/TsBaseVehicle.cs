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

// Token: 0x020032FF RID: 13055
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Vehicle/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Vehicle/TsBaseVehicle.TsBaseVehicle_C")]
public class TsBaseVehicle : AKuroBaseVehicle, IBPI_CreatureInterface_C, IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject, IUnrealUObject
{
	// Token: 0x1700275B RID: 10075
	// (get) Token: 0x0601C70B RID: 116491 RVA: 0x007FB7AA File Offset: 0x007F99AA
	// (set) Token: 0x0601C70C RID: 116492 RVA: 0x007FB7BA File Offset: 0x007F99BA
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

	// Token: 0x0601C70D RID: 116493 RVA: 0x007FB7CB File Offset: 0x007F99CB
	public void SetEntityId(int entityId)
	{
		this.EntityId = entityId;
		base.EntityIdInternal = entityId;
	}

	// Token: 0x1700275C RID: 10076
	// (get) Token: 0x0601C70E RID: 116494 RVA: 0x007FB7DB File Offset: 0x007F99DB
	// (set) Token: 0x0601C70F RID: 116495 RVA: 0x007FB7EF File Offset: 0x007F99EF
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

	// Token: 0x1700275D RID: 10077
	// (get) Token: 0x0601C710 RID: 116496 RVA: 0x007FB804 File Offset: 0x007F9A04
	// (set) Token: 0x0601C711 RID: 116497 RVA: 0x007FB814 File Offset: 0x007F9A14
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

	// Token: 0x1700275E RID: 10078
	// (get) Token: 0x0601C712 RID: 116498 RVA: 0x007FB828 File Offset: 0x007F9A28
	// (set) Token: 0x0601C713 RID: 116499 RVA: 0x007FB861 File Offset: 0x007F9A61
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

	// Token: 0x1700275F RID: 10079
	// (get) Token: 0x0601C714 RID: 116500 RVA: 0x007FB889 File Offset: 0x007F9A89
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

	// Token: 0x0601C715 RID: 116501 RVA: 0x007FB8A0 File Offset: 0x007F9AA0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual int GetEntityId()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetEntityId"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBaseVehicle.__GetEntityId_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBaseVehicle.__GetEntityId_FunctionParams*)ptr + 15L / (long)sizeof(TsBaseVehicle.__GetEntityId_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		int _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601C716 RID: 116502 RVA: 0x007FB915 File Offset: 0x007F9B15
	protected int GetEntityId_Implementation()
	{
		return ((IBPI_CreatureInterface_C)this).GetEntityId();
	}

	// Token: 0x0601C717 RID: 116503 RVA: 0x007FB91D File Offset: 0x007F9B1D
	int IBPI_CreatureInterface_C.GetEntityId()
	{
		if (this.VehicleActorComponent != null)
		{
			return this.VehicleActorComponent.Entity.Id;
		}
		return 0;
	}

	// Token: 0x0601C718 RID: 116504 RVA: 0x007FB939 File Offset: 0x007F9B39
	public int GetEntityIdNoBlueprint()
	{
		if (this.VehicleActorComponent != null)
		{
			return this.VehicleActorComponent.Entity.Id;
		}
		return 0;
	}

	// Token: 0x0601C719 RID: 116505 RVA: 0x007FB955 File Offset: 0x007F9B55
	[NullableContext(2)]
	public Entity GetEntityNoBlueprint()
	{
		if (this.VehicleActorComponent != null)
		{
			return this.VehicleActorComponent.Entity;
		}
		return null;
	}

	// Token: 0x0601C71A RID: 116506 RVA: 0x007FB96C File Offset: 0x007F9B6C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveDestroyed()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveDestroyed"), out num);
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

	// Token: 0x0601C71B RID: 116507 RVA: 0x007FB9DC File Offset: 0x007F9BDC
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

	// Token: 0x0601C71C RID: 116508 RVA: 0x007FBA04 File Offset: 0x007F9C04
	public void TryAddTsAbilitySystemComponent()
	{
		if (base.AbilitySystemComponent == null)
		{
			base.AbilitySystemComponent = (base.AddComponentByClass(UBaseAbilitySystemComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as UBaseAbilitySystemComponent);
		}
	}

	// Token: 0x17002760 RID: 10080
	// (get) Token: 0x0601C71D RID: 116509 RVA: 0x007FBA49 File Offset: 0x007F9C49
	// (set) Token: 0x0601C71E RID: 116510 RVA: 0x007FBA6B File Offset: 0x007F9C6B
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

	// Token: 0x17002761 RID: 10081
	// (get) Token: 0x0601C71F RID: 116511 RVA: 0x007FBA74 File Offset: 0x007F9C74
	public bool HasDitherEffectController
	{
		get
		{
			return this.DitherEffectControllerInternal != null;
		}
	}

	// Token: 0x0601C720 RID: 116512 RVA: 0x007FBA80 File Offset: 0x007F9C80
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetDitherEffect(float dither, ECharacterDitherType ditherType = ECharacterDitherType.Temporary)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetDitherEffect"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBaseVehicle.__SetDitherEffect_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBaseVehicle.__SetDitherEffect_FunctionParams*)ptr + 15L / (long)sizeof(TsBaseVehicle.__SetDitherEffect_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->dither = dither;
			*(&ptr2->ditherType) = (byte)ditherType;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601C721 RID: 116513 RVA: 0x007FBAFF File Offset: 0x007F9CFF
	protected void SetDitherEffect_Implementation(float dither, ECharacterDitherType ditherType = ECharacterDitherType.Temporary)
	{
		this.DitherEffectController.SetDitherEffect((double)dither, ditherType, true);
	}

	// Token: 0x0601C722 RID: 116514 RVA: 0x007FBB10 File Offset: 0x007F9D10
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsBaseVehicle._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Vehicle/TsBaseVehicle.TsBaseVehicle_C");
		}
		return TsBaseVehicle._ClassPtr;
	}

	// Token: 0x0601C723 RID: 116515 RVA: 0x007FBB34 File Offset: 0x007F9D34
	public TsBaseVehicle() : this(BuiltinUtils.AllocNativeUObject(TsBaseVehicle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601C724 RID: 116516 RVA: 0x007FBB5C File Offset: 0x007F9D5C
	[NullableContext(1)]
	public TsBaseVehicle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBaseVehicle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C725 RID: 116517 RVA: 0x007FBB8F File Offset: 0x007F9D8F
	protected TsBaseVehicle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C726 RID: 116518 RVA: 0x007FBB98 File Offset: 0x007F9D98
	protected unsafe virtual void __CPPCALL_GetEntityId_Implementation(TsBaseVehicle.__GetEntityId_FunctionParams* __Params)
	{
		__Params->__Result = this.GetEntityId_Implementation();
	}

	// Token: 0x0601C727 RID: 116519 RVA: 0x007FBBA6 File Offset: 0x007F9DA6
	protected virtual void __CPPCALL_ReceiveDestroyed_Implementation()
	{
		this.ReceiveDestroyed_Implementation();
	}

	// Token: 0x0601C728 RID: 116520 RVA: 0x007FBBB0 File Offset: 0x007F9DB0
	protected unsafe virtual void __CPPCALL_SetDitherEffect_Implementation(TsBaseVehicle.__SetDitherEffect_FunctionParams* __Params)
	{
		ECharacterDitherType ditherType = (ECharacterDitherType)__Params->ditherType;
		this.SetDitherEffect_Implementation(__Params->dither, ditherType);
	}

	// Token: 0x0400E1CE RID: 57806
	[Nullable(2)]
	public VehicleActorComponent VehicleActorComponent;

	// Token: 0x0400E1CF RID: 57807
	[Nullable(2)]
	private CharacterDitherEffectController DitherEffectControllerInternal;

	// Token: 0x0400E1D0 RID: 57808
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Vehicle/TsBaseVehicle.TsBaseVehicle_C";

	// Token: 0x0400E1D1 RID: 57809
	private static IntPtr _ClassPtr;

	// Token: 0x0400E1D2 RID: 57810
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E1D3 RID: 57811
	private static int __PropertyOffset_EntityId;

	// Token: 0x0400E1D4 RID: 57812
	private static int __PropertyOffset_CharRenderingComponent;

	// Token: 0x0400E1D5 RID: 57813
	private static int __PropertyOffset_RenderType;

	// Token: 0x0400E1D6 RID: 57814
	private static int __PropertyOffset_InputComponentClass;

	// Token: 0x0400E1D7 RID: 57815
	[Nullable(2)]
	private FSoftClassPath _InputComponentClass;

	// Token: 0x0400E1D8 RID: 57816
	private static int __PropertyOffset_PlatformActor;

	// Token: 0x0200978B RID: 38795
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __GetEntityId_FunctionParams
	{
		// Token: 0x04030715 RID: 198421
		[FieldOffset(0)]
		public int __Result;
	}

	// Token: 0x0200978C RID: 38796
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SetDitherEffect_FunctionParams
	{
		// Token: 0x04030716 RID: 198422
		[FieldOffset(0)]
		public float dither;

		// Token: 0x04030717 RID: 198423
		[FieldOffset(4)]
		public byte ditherType;
	}
}
