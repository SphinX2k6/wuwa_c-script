using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.TrailFields.Runtime.Sensors;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.TrailFields.Runtime.Drawers
{
	// Token: 0x02003AB6 RID: 15030
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/Drawers/BP_TrailSensorSnowActor_SingleMesh.BP_TrailSensorSnowActor_SingleMesh_C")]
	[UnrealStructLayout(1368, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1368)]
	public class BP_TrailSensorSnowActor_SingleMesh_C : BP_TrailSensor_Mesh_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060203B1 RID: 132017 RVA: 0x008CD3FD File Offset: 0x008CB5FD
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_TrailSensorSnowActor_SingleMesh_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/Drawers/BP_TrailSensorSnowActor_SingleMesh.BP_TrailSensorSnowActor_SingleMesh_C");
			}
			return BP_TrailSensorSnowActor_SingleMesh_C._ClassPtr;
		}

		// Token: 0x060203B2 RID: 132018 RVA: 0x008CD424 File Offset: 0x008CB624
		public BP_TrailSensorSnowActor_SingleMesh_C() : this(BuiltinUtils.AllocNativeUObject(BP_TrailSensorSnowActor_SingleMesh_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060203B3 RID: 132019 RVA: 0x008CD44C File Offset: 0x008CB64C
		[NullableContext(1)]
		public BP_TrailSensorSnowActor_SingleMesh_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_TrailSensorSnowActor_SingleMesh_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002FA1 RID: 12193
		// (get) Token: 0x060203B4 RID: 132020 RVA: 0x008CD47F File Offset: 0x008CB67F
		// (set) Token: 0x060203B5 RID: 132021 RVA: 0x008CD493 File Offset: 0x008CB693
		[Nullable(2)]
		public unsafe UStaticMeshComponent StaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorSnowActor_SingleMesh_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorSnowActor_SingleMesh_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x060203B6 RID: 132022 RVA: 0x008CD4A8 File Offset: 0x008CB6A8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetScale(UStaticMeshComponent 组件, float 乘数)
		{
			BP_TrailSensorSnowActor_SingleMesh_C.__SetScale_FunctionParams* ptr = stackalloc BP_TrailSensorSnowActor_SingleMesh_C.__SetScale_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(BP_TrailSensorSnowActor_SingleMesh_C.__SetScale_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailSensorSnowActor_SingleMesh_C.__SetScale_NativeFunctionPtr, (void*)ptr, 1);
			ptr->组件 = ((组件 != null) ? 组件.NativePtr : IntPtr.Zero);
			ptr->乘数 = 乘数;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailSensorSnowActor_SingleMesh_C.__SetScale_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060203B7 RID: 132023 RVA: 0x008CD504 File Offset: 0x008CB704
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailSensorSnowActor_SingleMesh_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060203B8 RID: 132024 RVA: 0x008CD518 File Offset: 0x008CB718
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TrailSensorSnowActor_SingleMesh_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060203B9 RID: 132025 RVA: 0x008CD52D File Offset: 0x008CB72D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailSensorSnowActor_SingleMesh_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060203BA RID: 132026 RVA: 0x008CD541 File Offset: 0x008CB741
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TrailSensorSnowActor_SingleMesh_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060203BB RID: 132027 RVA: 0x008CD556 File Offset: 0x008CB756
		protected BP_TrailSensorSnowActor_SingleMesh_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F953 RID: 63827
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/Drawers/BP_TrailSensorSnowActor_SingleMesh.BP_TrailSensorSnowActor_SingleMesh_C";

		// Token: 0x0400F954 RID: 63828
		private static IntPtr _ClassPtr;

		// Token: 0x0400F955 RID: 63829
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F956 RID: 63830
		internal new static int __PropertyOffset_1;

		// Token: 0x0400F957 RID: 63831
		private static IntPtr __SetScale_NativeFunctionPtr;

		// Token: 0x0400F958 RID: 63832
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F959 RID: 63833
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009B96 RID: 39830
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __SetScale_FunctionParams
		{
			// Token: 0x040311E9 RID: 201193
			[FieldOffset(0)]
			public IntPtr 组件;

			// Token: 0x040311EA RID: 201194
			[FieldOffset(8)]
			public float 乘数;
		}
	}
}
