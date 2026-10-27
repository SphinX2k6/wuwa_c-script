using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B1E RID: 15134
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_SpotLightFunction_seq.BP_SpotLightFunction_seq_C")]
	[UnrealStructLayout(1120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1120)]
	public class BP_SpotLightFunction_seq_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021286 RID: 135814 RVA: 0x008E63A0 File Offset: 0x008E45A0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SpotLightFunction_seq_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_SpotLightFunction_seq.BP_SpotLightFunction_seq_C");
			}
			return BP_SpotLightFunction_seq_C._ClassPtr;
		}

		// Token: 0x06021287 RID: 135815 RVA: 0x008E63C4 File Offset: 0x008E45C4
		public BP_SpotLightFunction_seq_C() : this(BuiltinUtils.AllocNativeUObject(BP_SpotLightFunction_seq_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021288 RID: 135816 RVA: 0x008E63EC File Offset: 0x008E45EC
		[NullableContext(1)]
		public BP_SpotLightFunction_seq_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SpotLightFunction_seq_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170034B1 RID: 13489
		// (get) Token: 0x06021289 RID: 135817 RVA: 0x008E641F File Offset: 0x008E461F
		// (set) Token: 0x0602128A RID: 135818 RVA: 0x008E6433 File Offset: 0x008E4633
		public unsafe USpotLightComponent SpotLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpotLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpotLightFunction_seq_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpotLightFunction_seq_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170034B2 RID: 13490
		// (get) Token: 0x0602128B RID: 135819 RVA: 0x008E6448 File Offset: 0x008E4648
		// (set) Token: 0x0602128C RID: 135820 RVA: 0x008E645C File Offset: 0x008E465C
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpotLightFunction_seq_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpotLightFunction_seq_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170034B3 RID: 13491
		// (get) Token: 0x0602128D RID: 135821 RVA: 0x008E6471 File Offset: 0x008E4671
		// (set) Token: 0x0602128E RID: 135822 RVA: 0x008E6485 File Offset: 0x008E4685
		public unsafe UMaterialInstance Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpotLightFunction_seq_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpotLightFunction_seq_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170034B4 RID: 13492
		// (get) Token: 0x0602128F RID: 135823 RVA: 0x008E649A File Offset: 0x008E469A
		// (set) Token: 0x06021290 RID: 135824 RVA: 0x008E64AE File Offset: 0x008E46AE
		public unsafe UMaterialInstanceDynamic Material_DY
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpotLightFunction_seq_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpotLightFunction_seq_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170034B5 RID: 13493
		// (get) Token: 0x06021291 RID: 135825 RVA: 0x008E64C3 File Offset: 0x008E46C3
		// (set) Token: 0x06021292 RID: 135826 RVA: 0x008E64D3 File Offset: 0x008E46D3
		public unsafe float UV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SpotLightFunction_seq_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SpotLightFunction_seq_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170034B6 RID: 13494
		// (get) Token: 0x06021293 RID: 135827 RVA: 0x008E64E4 File Offset: 0x008E46E4
		// (set) Token: 0x06021294 RID: 135828 RVA: 0x008E64F4 File Offset: 0x008E46F4
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SpotLightFunction_seq_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SpotLightFunction_seq_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170034B7 RID: 13495
		// (get) Token: 0x06021295 RID: 135829 RVA: 0x008E6505 File Offset: 0x008E4705
		// (set) Token: 0x06021296 RID: 135830 RVA: 0x008E6515 File Offset: 0x008E4715
		public unsafe float Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SpotLightFunction_seq_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SpotLightFunction_seq_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170034B8 RID: 13496
		// (get) Token: 0x06021297 RID: 135831 RVA: 0x008E6526 File Offset: 0x008E4726
		// (set) Token: 0x06021298 RID: 135832 RVA: 0x008E6536 File Offset: 0x008E4736
		public unsafe float Constrast
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SpotLightFunction_seq_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SpotLightFunction_seq_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170034B9 RID: 13497
		// (get) Token: 0x06021299 RID: 135833 RVA: 0x008E6547 File Offset: 0x008E4747
		// (set) Token: 0x0602129A RID: 135834 RVA: 0x008E6557 File Offset: 0x008E4757
		public unsafe float EvolutionaryIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SpotLightFunction_seq_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SpotLightFunction_seq_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170034BA RID: 13498
		// (get) Token: 0x0602129B RID: 135835 RVA: 0x008E6568 File Offset: 0x008E4768
		// (set) Token: 0x0602129C RID: 135836 RVA: 0x008E6578 File Offset: 0x008E4778
		public unsafe float EvolutionarySpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SpotLightFunction_seq_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SpotLightFunction_seq_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170034BB RID: 13499
		// (get) Token: 0x0602129D RID: 135837 RVA: 0x008E6589 File Offset: 0x008E4789
		// (set) Token: 0x0602129E RID: 135838 RVA: 0x008E659D File Offset: 0x008E479D
		public unsafe UTexture Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpotLightFunction_seq_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpotLightFunction_seq_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x0602129F RID: 135839 RVA: 0x008E65B2 File Offset: 0x008E47B2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SpotLightFunction()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SpotLightFunction_seq_C.__SpotLightFunction_NativeFunctionPtr, null);
		}

		// Token: 0x060212A0 RID: 135840 RVA: 0x008E65C6 File Offset: 0x008E47C6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SpotLightFunction_seq_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060212A1 RID: 135841 RVA: 0x008E65DA File Offset: 0x008E47DA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SpotLightFunction_seq_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060212A2 RID: 135842 RVA: 0x008E65F0 File Offset: 0x008E47F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SpotLightFunction_seq_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SpotLightFunction_seq_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SpotLightFunction_seq_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SpotLightFunction_seq_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SpotLightFunction_seq_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060212A3 RID: 135843 RVA: 0x008E6638 File Offset: 0x008E4838
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SpotLightFunction_seq_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SpotLightFunction_seq_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SpotLightFunction_seq_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SpotLightFunction_seq_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SpotLightFunction_seq_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060212A4 RID: 135844 RVA: 0x008E667F File Offset: 0x008E487F
		protected BP_SpotLightFunction_seq_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010233 RID: 66099
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_SpotLightFunction_seq.BP_SpotLightFunction_seq_C";

		// Token: 0x04010234 RID: 66100
		private static IntPtr _ClassPtr;

		// Token: 0x04010235 RID: 66101
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010236 RID: 66102
		internal static int __PropertyOffset_1;

		// Token: 0x04010237 RID: 66103
		internal static int __PropertyOffset_2;

		// Token: 0x04010238 RID: 66104
		internal static int __PropertyOffset_3;

		// Token: 0x04010239 RID: 66105
		internal static int __PropertyOffset_4;

		// Token: 0x0401023A RID: 66106
		internal static int __PropertyOffset_5;

		// Token: 0x0401023B RID: 66107
		internal static int __PropertyOffset_6;

		// Token: 0x0401023C RID: 66108
		internal static int __PropertyOffset_7;

		// Token: 0x0401023D RID: 66109
		internal static int __PropertyOffset_8;

		// Token: 0x0401023E RID: 66110
		internal static int __PropertyOffset_9;

		// Token: 0x0401023F RID: 66111
		internal static int __PropertyOffset_10;

		// Token: 0x04010240 RID: 66112
		internal static int __PropertyOffset_11;

		// Token: 0x04010241 RID: 66113
		private static IntPtr __SpotLightFunction_NativeFunctionPtr;

		// Token: 0x04010242 RID: 66114
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010243 RID: 66115
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009C76 RID: 40054
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031334 RID: 201524
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
