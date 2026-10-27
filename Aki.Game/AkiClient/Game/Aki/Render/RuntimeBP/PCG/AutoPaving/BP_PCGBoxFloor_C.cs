using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.AutoPaving
{
	// Token: 0x02003CDC RID: 15580
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/AutoPaving/BP_PCGBoxFloor.BP_PCGBoxFloor_C")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1100)]
	public class BP_PCGBoxFloor_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024FD1 RID: 151505 RVA: 0x0094DF78 File Offset: 0x0094C178
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PCGBoxFloor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/AutoPaving/BP_PCGBoxFloor.BP_PCGBoxFloor_C");
			}
			return BP_PCGBoxFloor_C._ClassPtr;
		}

		// Token: 0x06024FD2 RID: 151506 RVA: 0x0094DF9C File Offset: 0x0094C19C
		public BP_PCGBoxFloor_C() : this(BuiltinUtils.AllocNativeUObject(BP_PCGBoxFloor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024FD3 RID: 151507 RVA: 0x0094DFC4 File Offset: 0x0094C1C4
		[NullableContext(1)]
		public BP_PCGBoxFloor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PCGBoxFloor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004A34 RID: 18996
		// (get) Token: 0x06024FD4 RID: 151508 RVA: 0x0094DFF7 File Offset: 0x0094C1F7
		// (set) Token: 0x06024FD5 RID: 151509 RVA: 0x0094E00B File Offset: 0x0094C20B
		public unsafe UHierarchicalInstancedStaticMeshComponent HierarchicalInstancedStaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHierarchicalInstancedStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGBoxFloor_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGBoxFloor_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17004A35 RID: 18997
		// (get) Token: 0x06024FD6 RID: 151510 RVA: 0x0094E020 File Offset: 0x0094C220
		// (set) Token: 0x06024FD7 RID: 151511 RVA: 0x0094E034 File Offset: 0x0094C234
		public unsafe UInstancedStaticMeshComponent InstancedStaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInstancedStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGBoxFloor_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGBoxFloor_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004A36 RID: 18998
		// (get) Token: 0x06024FD8 RID: 151512 RVA: 0x0094E049 File Offset: 0x0094C249
		// (set) Token: 0x06024FD9 RID: 151513 RVA: 0x0094E05D File Offset: 0x0094C25D
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGBoxFloor_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGBoxFloor_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004A37 RID: 18999
		// (get) Token: 0x06024FDA RID: 151514 RVA: 0x0094E072 File Offset: 0x0094C272
		// (set) Token: 0x06024FDB RID: 151515 RVA: 0x0094E082 File Offset: 0x0094C282
		public unsafe float 半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PCGBoxFloor_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PCGBoxFloor_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17004A38 RID: 19000
		// (get) Token: 0x06024FDC RID: 151516 RVA: 0x0094E093 File Offset: 0x0094C293
		// (set) Token: 0x06024FDD RID: 151517 RVA: 0x0094E0A7 File Offset: 0x0094C2A7
		public unsafe UStaticMesh 模型
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGBoxFloor_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGBoxFloor_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004A39 RID: 19001
		// (get) Token: 0x06024FDE RID: 151518 RVA: 0x0094E0BC File Offset: 0x0094C2BC
		// (set) Token: 0x06024FDF RID: 151519 RVA: 0x0094E0D0 File Offset: 0x0094C2D0
		public unsafe UMaterialInterface 材质
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGBoxFloor_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGBoxFloor_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004A3A RID: 19002
		// (get) Token: 0x06024FE0 RID: 151520 RVA: 0x0094E0E5 File Offset: 0x0094C2E5
		// (set) Token: 0x06024FE1 RID: 151521 RVA: 0x0094E0F9 File Offset: 0x0094C2F9
		public unsafe FVector 模型缩放
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PCGBoxFloor_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PCGBoxFloor_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x06024FE2 RID: 151522 RVA: 0x0094E10E File Offset: 0x0094C30E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 烘焙HISM()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PCGBoxFloor_C.__烘焙HISM_NativeFunctionPtr, null);
		}

		// Token: 0x06024FE3 RID: 151523 RVA: 0x0094E122 File Offset: 0x0094C322
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 生成阵列()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PCGBoxFloor_C.__生成阵列_NativeFunctionPtr, null);
		}

		// Token: 0x06024FE4 RID: 151524 RVA: 0x0094E136 File Offset: 0x0094C336
		protected BP_PCGBoxFloor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012653 RID: 75347
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/AutoPaving/BP_PCGBoxFloor.BP_PCGBoxFloor_C";

		// Token: 0x04012654 RID: 75348
		private static IntPtr _ClassPtr;

		// Token: 0x04012655 RID: 75349
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012656 RID: 75350
		internal static int __PropertyOffset_0;

		// Token: 0x04012657 RID: 75351
		internal static int __PropertyOffset_1;

		// Token: 0x04012658 RID: 75352
		internal static int __PropertyOffset_2;

		// Token: 0x04012659 RID: 75353
		internal static int __PropertyOffset_3;

		// Token: 0x0401265A RID: 75354
		internal static int __PropertyOffset_4;

		// Token: 0x0401265B RID: 75355
		internal static int __PropertyOffset_5;

		// Token: 0x0401265C RID: 75356
		internal static int __PropertyOffset_6;

		// Token: 0x0401265D RID: 75357
		private static IntPtr __烘焙HISM_NativeFunctionPtr;

		// Token: 0x0401265E RID: 75358
		private static IntPtr __生成阵列_NativeFunctionPtr;
	}
}
