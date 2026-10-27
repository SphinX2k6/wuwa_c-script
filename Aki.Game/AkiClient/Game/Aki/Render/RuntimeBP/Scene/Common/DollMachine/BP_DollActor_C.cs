using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B6E RID: 15214
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollActor.BP_DollActor_C")]
	[UnrealStructLayout(1664, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1664)]
	public class BP_DollActor_C : AKuroBPActor, IUnrealUObject, IUnrealObject, IBPI_DollActor_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x06021DA6 RID: 138662 RVA: 0x008F7985 File Offset: 0x008F5B85
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollActor.BP_DollActor_C");
			}
			return BP_DollActor_C._ClassPtr;
		}

		// Token: 0x06021DA7 RID: 138663 RVA: 0x008F79AC File Offset: 0x008F5BAC
		public BP_DollActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021DA8 RID: 138664 RVA: 0x008F79D4 File Offset: 0x008F5BD4
		[NullableContext(1)]
		public BP_DollActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038B7 RID: 14519
		// (get) Token: 0x06021DA9 RID: 138665 RVA: 0x008F7A07 File Offset: 0x008F5C07
		// (set) Token: 0x06021DAA RID: 138666 RVA: 0x008F7A1B File Offset: 0x008F5C1B
		[Nullable(2)]
		public unsafe UChildActorComponent PermanentEffect1
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollActor_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollActor_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170038B8 RID: 14520
		// (get) Token: 0x06021DAB RID: 138667 RVA: 0x008F7A30 File Offset: 0x008F5C30
		// (set) Token: 0x06021DAC RID: 138668 RVA: 0x008F7A44 File Offset: 0x008F5C44
		[Nullable(2)]
		public unsafe UChildActorComponent PermanentEffect
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollActor_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollActor_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170038B9 RID: 14521
		// (get) Token: 0x06021DAD RID: 138669 RVA: 0x008F7A59 File Offset: 0x008F5C59
		// (set) Token: 0x06021DAE RID: 138670 RVA: 0x008F7A6D File Offset: 0x008F5C6D
		[Nullable(2)]
		public unsafe UStaticMeshComponent StaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollActor_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollActor_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170038BA RID: 14522
		// (get) Token: 0x06021DAF RID: 138671 RVA: 0x008F7A82 File Offset: 0x008F5C82
		// (set) Token: 0x06021DB0 RID: 138672 RVA: 0x008F7A92 File Offset: 0x008F5C92
		public unsafe int Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollActor_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollActor_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170038BB RID: 14523
		// (get) Token: 0x06021DB1 RID: 138673 RVA: 0x008F7AA3 File Offset: 0x008F5CA3
		// (set) Token: 0x06021DB2 RID: 138674 RVA: 0x008F7AB8 File Offset: 0x008F5CB8
		[Nullable(1)]
		public TSoftObjectPtr<EffectModelGroup> GrabEffect
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)BP_DollActor_C.__PropertyOffset_5, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollActor_C.__PropertyOffset_5, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170038BC RID: 14524
		// (get) Token: 0x06021DB3 RID: 138675 RVA: 0x008F7ADD File Offset: 0x008F5CDD
		// (set) Token: 0x06021DB4 RID: 138676 RVA: 0x008F7AF2 File Offset: 0x008F5CF2
		[Nullable(1)]
		public TSoftObjectPtr<EffectModelGroup> GrabEndlessEffect
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)BP_DollActor_C.__PropertyOffset_6, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollActor_C.__PropertyOffset_6, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170038BD RID: 14525
		// (get) Token: 0x06021DB5 RID: 138677 RVA: 0x008F7B17 File Offset: 0x008F5D17
		// (set) Token: 0x06021DB6 RID: 138678 RVA: 0x008F7B2C File Offset: 0x008F5D2C
		[Nullable(1)]
		public TSoftObjectPtr<EffectModelGroup> SpawnEffect
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)BP_DollActor_C.__PropertyOffset_7, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollActor_C.__PropertyOffset_7, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170038BE RID: 14526
		// (get) Token: 0x06021DB7 RID: 138679 RVA: 0x008F7B51 File Offset: 0x008F5D51
		// (set) Token: 0x06021DB8 RID: 138680 RVA: 0x008F7B61 File Offset: 0x008F5D61
		public unsafe bool MainDoll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollActor_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollActor_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x170038BF RID: 14527
		// (get) Token: 0x06021DB9 RID: 138681 RVA: 0x008F7B72 File Offset: 0x008F5D72
		// (set) Token: 0x06021DBA RID: 138682 RVA: 0x008F7B86 File Offset: 0x008F5D86
		[Nullable(2)]
		public unsafe UAnimSequence DollIdleAnim
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollActor_C.__PropertyOffset_9);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollActor_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x170038C0 RID: 14528
		// (get) Token: 0x06021DBB RID: 138683 RVA: 0x008F7B9B File Offset: 0x008F5D9B
		// (set) Token: 0x06021DBC RID: 138684 RVA: 0x008F7BAF File Offset: 0x008F5DAF
		[Nullable(2)]
		public unsafe UAnimSequence DollGrabAnim
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollActor_C.__PropertyOffset_10);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollActor_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x170038C1 RID: 14529
		// (get) Token: 0x06021DBD RID: 138685 RVA: 0x008F7BC4 File Offset: 0x008F5DC4
		// (set) Token: 0x06021DBE RID: 138686 RVA: 0x008F7BFD File Offset: 0x008F5DFD
		[Nullable(1)]
		public OnBeginPlay OnBeginPlay
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				OnBeginPlay result;
				if ((result = this._OnBeginPlay) == null)
				{
					result = (this._OnBeginPlay = new OnBeginPlay(base.NativePtr + (IntPtr)BP_DollActor_C.__PropertyOffset_11, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_DollActor_C.__PropertyOffset_11, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06021DBF RID: 138687 RVA: 0x008F7C20 File Offset: 0x008F5E20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetSimulatePhysics(bool Enable)
		{
			BP_DollActor_C.__SetSimulatePhysics_FunctionParams* ptr = stackalloc BP_DollActor_C.__SetSimulatePhysics_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_DollActor_C.__SetSimulatePhysics_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollActor_C.__SetSimulatePhysics_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Enable = Enable;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__SetSimulatePhysics_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021DC0 RID: 138688 RVA: 0x008F7C66 File Offset: 0x008F5E66
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PlayGrabAnim()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__PlayGrabAnim_NativeFunctionPtr, null);
		}

		// Token: 0x06021DC1 RID: 138689 RVA: 0x008F7C7C File Offset: 0x008F5E7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void TogglePlayIdleAnim(bool toggle)
		{
			BP_DollActor_C.__TogglePlayIdleAnim_FunctionParams* ptr = stackalloc BP_DollActor_C.__TogglePlayIdleAnim_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_DollActor_C.__TogglePlayIdleAnim_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollActor_C.__TogglePlayIdleAnim_NativeFunctionPtr, (void*)ptr, 1);
			ptr->toggle = toggle;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__TogglePlayIdleAnim_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021DC2 RID: 138690 RVA: 0x008F7CC4 File Offset: 0x008F5EC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EnableRagdoll(bool Enable)
		{
			BP_DollActor_C.__EnableRagdoll_FunctionParams* ptr = stackalloc BP_DollActor_C.__EnableRagdoll_FunctionParams[(UIntPtr)303] + 15L / (long)sizeof(BP_DollActor_C.__EnableRagdoll_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollActor_C.__EnableRagdoll_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Enable = Enable;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__EnableRagdoll_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021DC3 RID: 138691 RVA: 0x008F7D10 File Offset: 0x008F5F10
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetPermanentEffect(bool Visibility, string Reason)
		{
			BP_DollActor_C.__SetPermanentEffect_FunctionParams* ptr = stackalloc BP_DollActor_C.__SetPermanentEffect_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(BP_DollActor_C.__SetPermanentEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollActor_C.__SetPermanentEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Visibility = Visibility;
			FString.CopyFrom((void*)(&ptr->Reason), Reason);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__SetPermanentEffect_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_DollActor_C.__SetPermanentEffect_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021DC4 RID: 138692 RVA: 0x008F7D74 File Offset: 0x008F5F74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void PlayGrabEffectByLocation(FVectorDouble Location)
		{
			BP_DollActor_C.__PlayGrabEffectByLocation_FunctionParams* ptr = stackalloc BP_DollActor_C.__PlayGrabEffectByLocation_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_DollActor_C.__PlayGrabEffectByLocation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollActor_C.__PlayGrabEffectByLocation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Location = Location;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__PlayGrabEffectByLocation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021DC5 RID: 138693 RVA: 0x008F7DBA File Offset: 0x008F5FBA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PlayTimeEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__PlayTimeEffect_NativeFunctionPtr, null);
		}

		// Token: 0x06021DC6 RID: 138694 RVA: 0x008F7DCE File Offset: 0x008F5FCE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021DC7 RID: 138695 RVA: 0x008F7DE2 File Offset: 0x008F5FE2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DollActor_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021DC8 RID: 138696 RVA: 0x008F7DF8 File Offset: 0x008F5FF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetVisible(bool ToggleVisibility, bool TogglePhysics)
		{
			BP_DollActor_C.__SetVisible_FunctionParams* ptr = stackalloc BP_DollActor_C.__SetVisible_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(BP_DollActor_C.__SetVisible_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollActor_C.__SetVisible_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ToggleVisibility = ToggleVisibility;
			ptr->TogglePhysics = TogglePhysics;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__SetVisible_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021DC9 RID: 138697 RVA: 0x008F7E48 File Offset: 0x008F6048
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void PlayGrabEffect(bool IsEndless, FVectorDouble Location)
		{
			BP_DollActor_C.__PlayGrabEffect_FunctionParams* ptr = stackalloc BP_DollActor_C.__PlayGrabEffect_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_DollActor_C.__PlayGrabEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollActor_C.__PlayGrabEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsEndless = IsEndless;
			ptr->Location = Location;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__PlayGrabEffect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021DCA RID: 138698 RVA: 0x008F7E95 File Offset: 0x008F6095
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PlaySpawnEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__PlaySpawnEffect_NativeFunctionPtr, null);
		}

		// Token: 0x06021DCB RID: 138699 RVA: 0x008F7EAC File Offset: 0x008F60AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetPhysicsParameters(float AngularDamping, float LineraDamping)
		{
			BP_DollActor_C.__SetPhysicsParameters_FunctionParams* ptr = stackalloc BP_DollActor_C.__SetPhysicsParameters_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_DollActor_C.__SetPhysicsParameters_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollActor_C.__SetPhysicsParameters_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AngularDamping = AngularDamping;
			ptr->LineraDamping = LineraDamping;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__SetPhysicsParameters_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021DCC RID: 138700 RVA: 0x008F7EF9 File Offset: 0x008F60F9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ResetPhysics()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__ResetPhysics_NativeFunctionPtr, null);
		}

		// Token: 0x06021DCD RID: 138701 RVA: 0x008F7F10 File Offset: 0x008F6110
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void TogglePlayShow(bool Toggle, float PlayRate)
		{
			BP_DollActor_C.__TogglePlayShow_FunctionParams* ptr = stackalloc BP_DollActor_C.__TogglePlayShow_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_DollActor_C.__TogglePlayShow_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollActor_C.__TogglePlayShow_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Toggle = Toggle;
			ptr->PlayRate = PlayRate;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__TogglePlayShow_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021DCE RID: 138702 RVA: 0x008F7F60 File Offset: 0x008F6160
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void TogglePlayGrabAnim(bool Enable, float Rate)
		{
			BP_DollActor_C.__TogglePlayGrabAnim_FunctionParams* ptr = stackalloc BP_DollActor_C.__TogglePlayGrabAnim_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_DollActor_C.__TogglePlayGrabAnim_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollActor_C.__TogglePlayGrabAnim_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Enable = Enable;
			ptr->Rate = Rate;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__TogglePlayGrabAnim_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021DCF RID: 138703 RVA: 0x008F7FB0 File Offset: 0x008F61B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void PlayGrabEffectByTransform(bool IsEndless, FTransformDouble Transform)
		{
			BP_DollActor_C.__PlayGrabEffectByTransform_FunctionParams* ptr = stackalloc BP_DollActor_C.__PlayGrabEffectByTransform_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(BP_DollActor_C.__PlayGrabEffectByTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollActor_C.__PlayGrabEffectByTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsEndless = IsEndless;
			ptr->Transform = Transform;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollActor_C.__PlayGrabEffectByTransform_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021DD0 RID: 138704 RVA: 0x008F7FFD File Offset: 0x008F61FD
		protected BP_DollActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401089C RID: 67740
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollActor.BP_DollActor_C";

		// Token: 0x0401089D RID: 67741
		private static IntPtr _ClassPtr;

		// Token: 0x0401089E RID: 67742
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401089F RID: 67743
		public static IntPtr __OnBeginPlay__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040108A0 RID: 67744
		internal static int __PropertyOffset_1;

		// Token: 0x040108A1 RID: 67745
		internal static int __PropertyOffset_2;

		// Token: 0x040108A2 RID: 67746
		internal static int __PropertyOffset_3;

		// Token: 0x040108A3 RID: 67747
		internal static int __PropertyOffset_4;

		// Token: 0x040108A4 RID: 67748
		internal static int __PropertyOffset_5;

		// Token: 0x040108A5 RID: 67749
		internal static int __PropertyOffset_6;

		// Token: 0x040108A6 RID: 67750
		internal static int __PropertyOffset_7;

		// Token: 0x040108A7 RID: 67751
		internal static int __PropertyOffset_8;

		// Token: 0x040108A8 RID: 67752
		internal static int __PropertyOffset_9;

		// Token: 0x040108A9 RID: 67753
		internal static int __PropertyOffset_10;

		// Token: 0x040108AA RID: 67754
		internal static int __PropertyOffset_11;

		// Token: 0x040108AB RID: 67755
		[Nullable(2)]
		private OnBeginPlay _OnBeginPlay;

		// Token: 0x040108AC RID: 67756
		private static IntPtr __SetSimulatePhysics_NativeFunctionPtr;

		// Token: 0x040108AD RID: 67757
		private static IntPtr __PlayGrabAnim_NativeFunctionPtr;

		// Token: 0x040108AE RID: 67758
		private static IntPtr __TogglePlayIdleAnim_NativeFunctionPtr;

		// Token: 0x040108AF RID: 67759
		private static IntPtr __EnableRagdoll_NativeFunctionPtr;

		// Token: 0x040108B0 RID: 67760
		private static IntPtr __SetPermanentEffect_NativeFunctionPtr;

		// Token: 0x040108B1 RID: 67761
		private static IntPtr __PlayGrabEffectByLocation_NativeFunctionPtr;

		// Token: 0x040108B2 RID: 67762
		private static IntPtr __PlayTimeEffect_NativeFunctionPtr;

		// Token: 0x040108B3 RID: 67763
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040108B4 RID: 67764
		private static IntPtr __SetVisible_NativeFunctionPtr;

		// Token: 0x040108B5 RID: 67765
		private static IntPtr __PlayGrabEffect_NativeFunctionPtr;

		// Token: 0x040108B6 RID: 67766
		private static IntPtr __PlaySpawnEffect_NativeFunctionPtr;

		// Token: 0x040108B7 RID: 67767
		private static IntPtr __SetPhysicsParameters_NativeFunctionPtr;

		// Token: 0x040108B8 RID: 67768
		private static IntPtr __ResetPhysics_NativeFunctionPtr;

		// Token: 0x040108B9 RID: 67769
		private static IntPtr __TogglePlayShow_NativeFunctionPtr;

		// Token: 0x040108BA RID: 67770
		private static IntPtr __TogglePlayGrabAnim_NativeFunctionPtr;

		// Token: 0x040108BB RID: 67771
		private static IntPtr __PlayGrabEffectByTransform_NativeFunctionPtr;

		// Token: 0x02009CE5 RID: 40165
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetSimulatePhysics_FunctionParams
		{
			// Token: 0x040313DD RID: 201693
			[FieldOffset(0)]
			public bool Enable;
		}

		// Token: 0x02009CE6 RID: 40166
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __TogglePlayIdleAnim_FunctionParams
		{
			// Token: 0x040313DE RID: 201694
			[FieldOffset(0)]
			public bool toggle;
		}

		// Token: 0x02009CE7 RID: 40167
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 288)]
		protected ref struct __EnableRagdoll_FunctionParams
		{
			// Token: 0x040313DF RID: 201695
			[FieldOffset(0)]
			public bool Enable;
		}

		// Token: 0x02009CE8 RID: 40168
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __SetPermanentEffect_FunctionParams
		{
			// Token: 0x040313E0 RID: 201696
			[FieldOffset(0)]
			public bool Visibility;

			// Token: 0x040313E1 RID: 201697
			[FieldOffset(8)]
			public FString Reason;
		}

		// Token: 0x02009CE9 RID: 40169
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __PlayGrabEffectByLocation_FunctionParams
		{
			// Token: 0x040313E2 RID: 201698
			[FieldOffset(0)]
			public FVectorDouble Location;
		}

		// Token: 0x02009CEA RID: 40170
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __SetVisible_FunctionParams
		{
			// Token: 0x040313E3 RID: 201699
			[FieldOffset(0)]
			public bool ToggleVisibility;

			// Token: 0x040313E4 RID: 201700
			[FieldOffset(1)]
			public bool TogglePhysics;
		}

		// Token: 0x02009CEB RID: 40171
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __PlayGrabEffect_FunctionParams
		{
			// Token: 0x040313E5 RID: 201701
			[FieldOffset(0)]
			public bool IsEndless;

			// Token: 0x040313E6 RID: 201702
			[FieldOffset(8)]
			public FVectorDouble Location;
		}

		// Token: 0x02009CEC RID: 40172
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetPhysicsParameters_FunctionParams
		{
			// Token: 0x040313E7 RID: 201703
			[FieldOffset(0)]
			public float AngularDamping;

			// Token: 0x040313E8 RID: 201704
			[FieldOffset(4)]
			public float LineraDamping;
		}

		// Token: 0x02009CED RID: 40173
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __TogglePlayShow_FunctionParams
		{
			// Token: 0x040313E9 RID: 201705
			[FieldOffset(0)]
			public bool Toggle;

			// Token: 0x040313EA RID: 201706
			[FieldOffset(4)]
			public float PlayRate;
		}

		// Token: 0x02009CEE RID: 40174
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __TogglePlayGrabAnim_FunctionParams
		{
			// Token: 0x040313EB RID: 201707
			[FieldOffset(0)]
			public bool Enable;

			// Token: 0x040313EC RID: 201708
			[FieldOffset(4)]
			public float Rate;
		}

		// Token: 0x02009CEF RID: 40175
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __PlayGrabEffectByTransform_FunctionParams
		{
			// Token: 0x040313ED RID: 201709
			[FieldOffset(0)]
			public bool IsEndless;

			// Token: 0x040313EE RID: 201710
			[FieldOffset(16)]
			public FTransformDouble Transform;
		}
	}
}
