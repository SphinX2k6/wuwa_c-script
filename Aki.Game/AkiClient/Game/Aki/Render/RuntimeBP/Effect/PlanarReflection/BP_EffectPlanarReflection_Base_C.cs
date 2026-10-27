using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.PlanarReflection
{
	// Token: 0x02003DD4 RID: 15828
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/PlanarReflection/BP_EffectPlanarReflection_Base.BP_EffectPlanarReflection_Base_C")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class BP_EffectPlanarReflection_Base_C : APlanarReflection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027799 RID: 161689 RVA: 0x0099279A File Offset: 0x0099099A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_EffectPlanarReflection_Base_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/PlanarReflection/BP_EffectPlanarReflection_Base.BP_EffectPlanarReflection_Base_C");
			}
			return BP_EffectPlanarReflection_Base_C._ClassPtr;
		}

		// Token: 0x0602779A RID: 161690 RVA: 0x009927C0 File Offset: 0x009909C0
		public BP_EffectPlanarReflection_Base_C() : this(BuiltinUtils.AllocNativeUObject(BP_EffectPlanarReflection_Base_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602779B RID: 161691 RVA: 0x009927E8 File Offset: 0x009909E8
		[NullableContext(1)]
		public BP_EffectPlanarReflection_Base_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_EffectPlanarReflection_Base_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700585C RID: 22620
		// (get) Token: 0x0602779C RID: 161692 RVA: 0x0099281B File Offset: 0x00990A1B
		// (set) Token: 0x0602779D RID: 161693 RVA: 0x0099282F File Offset: 0x00990A2F
		public unsafe UStaticMeshComponent Sphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectPlanarReflection_Base_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectPlanarReflection_Base_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x1700585D RID: 22621
		// (get) Token: 0x0602779E RID: 161694 RVA: 0x00992844 File Offset: 0x00990A44
		// (set) Token: 0x0602779F RID: 161695 RVA: 0x00992858 File Offset: 0x00990A58
		public unsafe UStaticMeshComponent Plane
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectPlanarReflection_Base_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectPlanarReflection_Base_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700585E RID: 22622
		// (get) Token: 0x060277A0 RID: 161696 RVA: 0x0099286D File Offset: 0x00990A6D
		// (set) Token: 0x060277A1 RID: 161697 RVA: 0x00992881 File Offset: 0x00990A81
		public unsafe UMaterialInstanceDynamic MDI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectPlanarReflection_Base_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectPlanarReflection_Base_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x060277A2 RID: 161698 RVA: 0x00992898 File Offset: 0x00990A98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetOpaticy(float Opacity)
		{
			BP_EffectPlanarReflection_Base_C.__SetOpaticy_FunctionParams* ptr = stackalloc BP_EffectPlanarReflection_Base_C.__SetOpaticy_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_EffectPlanarReflection_Base_C.__SetOpaticy_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectPlanarReflection_Base_C.__SetOpaticy_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Opacity = Opacity;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectPlanarReflection_Base_C.__SetOpaticy_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060277A3 RID: 161699 RVA: 0x009928DE File Offset: 0x00990ADE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Setup()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectPlanarReflection_Base_C.__Setup_NativeFunctionPtr, null);
		}

		// Token: 0x060277A4 RID: 161700 RVA: 0x009928F2 File Offset: 0x00990AF2
		protected BP_EffectPlanarReflection_Base_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013F16 RID: 81686
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/PlanarReflection/BP_EffectPlanarReflection_Base.BP_EffectPlanarReflection_Base_C";

		// Token: 0x04013F17 RID: 81687
		private static IntPtr _ClassPtr;

		// Token: 0x04013F18 RID: 81688
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013F19 RID: 81689
		internal static int __PropertyOffset_0;

		// Token: 0x04013F1A RID: 81690
		internal static int __PropertyOffset_1;

		// Token: 0x04013F1B RID: 81691
		internal static int __PropertyOffset_2;

		// Token: 0x04013F1C RID: 81692
		private static IntPtr __SetOpaticy_NativeFunctionPtr;

		// Token: 0x04013F1D RID: 81693
		private static IntPtr __Setup_NativeFunctionPtr;

		// Token: 0x0200A23C RID: 41532
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetOpaticy_FunctionParams
		{
			// Token: 0x04031EC9 RID: 204489
			[FieldOffset(0)]
			public float Opacity;
		}
	}
}
