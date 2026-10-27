using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.TrailFields.Runtime.Sensors
{
	// Token: 0x02003AAF RID: 15023
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/Sensors/BP_TrailSensor_Mesh.BP_TrailSensor_Mesh_C")]
	[UnrealStructLayout(1344, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1340)]
	public class BP_TrailSensor_Mesh_C : BP_TrailSensorActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602032E RID: 131886 RVA: 0x008CC650 File Offset: 0x008CA850
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_TrailSensor_Mesh_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/Sensors/BP_TrailSensor_Mesh.BP_TrailSensor_Mesh_C");
			}
			return BP_TrailSensor_Mesh_C._ClassPtr;
		}

		// Token: 0x0602032F RID: 131887 RVA: 0x008CC674 File Offset: 0x008CA874
		public BP_TrailSensor_Mesh_C() : this(BuiltinUtils.AllocNativeUObject(BP_TrailSensor_Mesh_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020330 RID: 131888 RVA: 0x008CC69C File Offset: 0x008CA89C
		[NullableContext(1)]
		public BP_TrailSensor_Mesh_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_TrailSensor_Mesh_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002F7A RID: 12154
		// (get) Token: 0x06020331 RID: 131889 RVA: 0x008CC6CF File Offset: 0x008CA8CF
		// (set) Token: 0x06020332 RID: 131890 RVA: 0x008CC6E3 File Offset: 0x008CA8E3
		public unsafe USceneComponent Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensor_Mesh_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensor_Mesh_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002F7B RID: 12155
		// (get) Token: 0x06020333 RID: 131891 RVA: 0x008CC6F8 File Offset: 0x008CA8F8
		// (set) Token: 0x06020334 RID: 131892 RVA: 0x008CC70C File Offset: 0x008CA90C
		public unsafe BP_TrailsManager_C Manager
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_TrailsManager_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensor_Mesh_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensor_Mesh_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002F7C RID: 12156
		// (get) Token: 0x06020335 RID: 131893 RVA: 0x008CC721 File Offset: 0x008CA921
		// (set) Token: 0x06020336 RID: 131894 RVA: 0x008CC735 File Offset: 0x008CA935
		public unsafe UMaterialInstanceDynamic SnowMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensor_Mesh_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensor_Mesh_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002F7D RID: 12157
		// (get) Token: 0x06020337 RID: 131895 RVA: 0x008CC74A File Offset: 0x008CA94A
		// (set) Token: 0x06020338 RID: 131896 RVA: 0x008CC75E File Offset: 0x008CA95E
		public unsafe UMaterialInterface Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensor_Mesh_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensor_Mesh_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17002F7E RID: 12158
		// (get) Token: 0x06020339 RID: 131897 RVA: 0x008CC773 File Offset: 0x008CA973
		// (set) Token: 0x0602033A RID: 131898 RVA: 0x008CC787 File Offset: 0x008CA987
		public unsafe FRotator MeshRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailSensor_Mesh_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailSensor_Mesh_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x0602033B RID: 131899 RVA: 0x008CC79C File Offset: 0x008CA99C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CreateSnowfield()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailSensor_Mesh_C.__CreateSnowfield_NativeFunctionPtr, null);
		}

		// Token: 0x0602033C RID: 131900 RVA: 0x008CC7B0 File Offset: 0x008CA9B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CreatePreviewMat(float PreviewTexSize, UTexture PrevuewTexture)
		{
			BP_TrailSensor_Mesh_C.__CreatePreviewMat_FunctionParams* ptr = stackalloc BP_TrailSensor_Mesh_C.__CreatePreviewMat_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_TrailSensor_Mesh_C.__CreatePreviewMat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailSensor_Mesh_C.__CreatePreviewMat_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PreviewTexSize = PreviewTexSize;
			ptr->PrevuewTexture = ((PrevuewTexture != null) ? PrevuewTexture.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailSensor_Mesh_C.__CreatePreviewMat_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602033D RID: 131901 RVA: 0x008CC80C File Offset: 0x008CAA0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitializeSnowMatInfo()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailSensor_Mesh_C.__InitializeSnowMatInfo_NativeFunctionPtr, null);
		}

		// Token: 0x0602033E RID: 131902 RVA: 0x008CC820 File Offset: 0x008CAA20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailSensor_Mesh_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602033F RID: 131903 RVA: 0x008CC834 File Offset: 0x008CAA34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TrailSensor_Mesh_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020340 RID: 131904 RVA: 0x008CC849 File Offset: 0x008CAA49
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailSensor_Mesh_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020341 RID: 131905 RVA: 0x008CC85D File Offset: 0x008CAA5D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TrailSensor_Mesh_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020342 RID: 131906 RVA: 0x008CC872 File Offset: 0x008CAA72
		protected BP_TrailSensor_Mesh_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F904 RID: 63748
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/Sensors/BP_TrailSensor_Mesh.BP_TrailSensor_Mesh_C";

		// Token: 0x0400F905 RID: 63749
		private static IntPtr _ClassPtr;

		// Token: 0x0400F906 RID: 63750
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F907 RID: 63751
		internal new static int __PropertyOffset_1;

		// Token: 0x0400F908 RID: 63752
		internal new static int __PropertyOffset_2;

		// Token: 0x0400F909 RID: 63753
		internal new static int __PropertyOffset_3;

		// Token: 0x0400F90A RID: 63754
		internal new static int __PropertyOffset_4;

		// Token: 0x0400F90B RID: 63755
		internal new static int __PropertyOffset_5;

		// Token: 0x0400F90C RID: 63756
		private static IntPtr __CreateSnowfield_NativeFunctionPtr;

		// Token: 0x0400F90D RID: 63757
		private static IntPtr __CreatePreviewMat_NativeFunctionPtr;

		// Token: 0x0400F90E RID: 63758
		private static IntPtr __InitializeSnowMatInfo_NativeFunctionPtr;

		// Token: 0x0400F90F RID: 63759
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F910 RID: 63760
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009B91 RID: 39825
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __CreatePreviewMat_FunctionParams
		{
			// Token: 0x040311E3 RID: 201187
			[FieldOffset(0)]
			public float PreviewTexSize;

			// Token: 0x040311E4 RID: 201188
			[FieldOffset(8)]
			public IntPtr PrevuewTexture;
		}
	}
}
