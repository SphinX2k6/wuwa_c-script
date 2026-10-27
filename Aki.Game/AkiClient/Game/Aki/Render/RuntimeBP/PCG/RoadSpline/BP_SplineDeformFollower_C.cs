using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.RoadSpline
{
	// Token: 0x02003C26 RID: 15398
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/BP_SplineDeformFollower.BP_SplineDeformFollower_C")]
	[UnrealStructLayout(1480, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1476)]
	public class BP_SplineDeformFollower_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602350D RID: 144653 RVA: 0x00920DBA File Offset: 0x0091EFBA
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SplineDeformFollower_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/BP_SplineDeformFollower.BP_SplineDeformFollower_C");
			}
			return BP_SplineDeformFollower_C._ClassPtr;
		}

		// Token: 0x0602350E RID: 144654 RVA: 0x00920DE0 File Offset: 0x0091EFE0
		public BP_SplineDeformFollower_C() : this(BuiltinUtils.AllocNativeUObject(BP_SplineDeformFollower_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602350F RID: 144655 RVA: 0x00920E08 File Offset: 0x0091F008
		[NullableContext(1)]
		public BP_SplineDeformFollower_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SplineDeformFollower_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170040A2 RID: 16546
		// (get) Token: 0x06023510 RID: 144656 RVA: 0x00920E3B File Offset: 0x0091F03B
		// (set) Token: 0x06023511 RID: 144657 RVA: 0x00920E4F File Offset: 0x0091F04F
		public unsafe UStaticMeshComponent StaticmeshPreview
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineDeformFollower_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineDeformFollower_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170040A3 RID: 16547
		// (get) Token: 0x06023512 RID: 144658 RVA: 0x00920E64 File Offset: 0x0091F064
		// (set) Token: 0x06023513 RID: 144659 RVA: 0x00920E78 File Offset: 0x0091F078
		public unsafe USplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineDeformFollower_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineDeformFollower_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170040A4 RID: 16548
		// (get) Token: 0x06023514 RID: 144660 RVA: 0x00920E8D File Offset: 0x0091F08D
		// (set) Token: 0x06023515 RID: 144661 RVA: 0x00920EA1 File Offset: 0x0091F0A1
		public unsafe UTextureRenderTarget2D 路径RT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineDeformFollower_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineDeformFollower_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170040A5 RID: 16549
		// (get) Token: 0x06023516 RID: 144662 RVA: 0x00920EB6 File Offset: 0x0091F0B6
		// (set) Token: 0x06023517 RID: 144663 RVA: 0x00920ECA File Offset: 0x0091F0CA
		public unsafe UStaticMesh 模型资产
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineDeformFollower_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineDeformFollower_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170040A6 RID: 16550
		// (get) Token: 0x06023518 RID: 144664 RVA: 0x00920EDF File Offset: 0x0091F0DF
		// (set) Token: 0x06023519 RID: 144665 RVA: 0x00920EEF File Offset: 0x0091F0EF
		public unsafe float 速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineDeformFollower_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineDeformFollower_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x0602351A RID: 144666 RVA: 0x00920F00 File Offset: 0x0091F100
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 生成动态材质()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineDeformFollower_C.__生成动态材质_NativeFunctionPtr, null);
		}

		// Token: 0x0602351B RID: 144667 RVA: 0x00920F14 File Offset: 0x0091F114
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 生成路径RT()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineDeformFollower_C.__生成路径RT_NativeFunctionPtr, null);
		}

		// Token: 0x0602351C RID: 144668 RVA: 0x00920F28 File Offset: 0x0091F128
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void IsEditor(ref bool IsEditor)
		{
			BP_SplineDeformFollower_C.__IsEditor_FunctionParams* ptr = stackalloc BP_SplineDeformFollower_C.__IsEditor_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(BP_SplineDeformFollower_C.__IsEditor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineDeformFollower_C.__IsEditor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsEditor = IsEditor;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineDeformFollower_C.__IsEditor_NativeFunctionPtr, (void*)ptr);
			IsEditor = ptr->IsEditor;
		}

		// Token: 0x0602351D RID: 144669 RVA: 0x00920F77 File Offset: 0x0091F177
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineDeformFollower_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602351E RID: 144670 RVA: 0x00920F8B File Offset: 0x0091F18B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplineDeformFollower_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602351F RID: 144671 RVA: 0x00920FA0 File Offset: 0x0091F1A0
		protected BP_SplineDeformFollower_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040116BB RID: 71355
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/BP_SplineDeformFollower.BP_SplineDeformFollower_C";

		// Token: 0x040116BC RID: 71356
		private static IntPtr _ClassPtr;

		// Token: 0x040116BD RID: 71357
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040116BE RID: 71358
		internal static int __PropertyOffset_0;

		// Token: 0x040116BF RID: 71359
		internal static int __PropertyOffset_1;

		// Token: 0x040116C0 RID: 71360
		internal static int __PropertyOffset_2;

		// Token: 0x040116C1 RID: 71361
		internal static int __PropertyOffset_3;

		// Token: 0x040116C2 RID: 71362
		internal static int __PropertyOffset_4;

		// Token: 0x040116C3 RID: 71363
		private static IntPtr __生成动态材质_NativeFunctionPtr;

		// Token: 0x040116C4 RID: 71364
		private static IntPtr __生成路径RT_NativeFunctionPtr;

		// Token: 0x040116C5 RID: 71365
		private static IntPtr __IsEditor_NativeFunctionPtr;

		// Token: 0x040116C6 RID: 71366
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x02009E59 RID: 40537
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __IsEditor_FunctionParams
		{
			// Token: 0x040316DB RID: 202459
			[FieldOffset(0)]
			public bool IsEditor;
		}
	}
}
