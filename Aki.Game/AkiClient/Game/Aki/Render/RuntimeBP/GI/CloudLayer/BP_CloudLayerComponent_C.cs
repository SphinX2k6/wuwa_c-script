using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.CloudLayer
{
	// Token: 0x02003D7F RID: 15743
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/CloudLayer/BP_CloudLayerComponent.BP_CloudLayerComponent_C")]
	[UnrealStructLayout(624, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 620)]
	public class BP_CloudLayerComponent_C : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026A33 RID: 158259 RVA: 0x0097A38C File Offset: 0x0097858C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CloudLayerComponent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/CloudLayer/BP_CloudLayerComponent.BP_CloudLayerComponent_C");
			}
			return BP_CloudLayerComponent_C._ClassPtr;
		}

		// Token: 0x06026A34 RID: 158260 RVA: 0x0097A3B0 File Offset: 0x009785B0
		public BP_CloudLayerComponent_C() : this(BuiltinUtils.AllocNativeUObject(BP_CloudLayerComponent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026A35 RID: 158261 RVA: 0x0097A3D8 File Offset: 0x009785D8
		[NullableContext(1)]
		public BP_CloudLayerComponent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CloudLayerComponent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005354 RID: 21332
		// (get) Token: 0x06026A36 RID: 158262 RVA: 0x0097A40B File Offset: 0x0097860B
		// (set) Token: 0x06026A37 RID: 158263 RVA: 0x0097A41B File Offset: 0x0097861B
		public unsafe float CloudSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudLayerComponent_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudLayerComponent_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005355 RID: 21333
		// (get) Token: 0x06026A38 RID: 158264 RVA: 0x0097A42C File Offset: 0x0097862C
		// (set) Token: 0x06026A39 RID: 158265 RVA: 0x0097A440 File Offset: 0x00978640
		public unsafe FVector CloudPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudLayerComponent_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudLayerComponent_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005356 RID: 21334
		// (get) Token: 0x06026A3A RID: 158266 RVA: 0x0097A455 File Offset: 0x00978655
		// (set) Token: 0x06026A3B RID: 158267 RVA: 0x0097A465 File Offset: 0x00978665
		public unsafe float CloudsTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudLayerComponent_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudLayerComponent_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005357 RID: 21335
		// (get) Token: 0x06026A3C RID: 158268 RVA: 0x0097A476 File Offset: 0x00978676
		// (set) Token: 0x06026A3D RID: 158269 RVA: 0x0097A486 File Offset: 0x00978686
		public unsafe float CloudDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudLayerComponent_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudLayerComponent_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005358 RID: 21336
		// (get) Token: 0x06026A3E RID: 158270 RVA: 0x0097A497 File Offset: 0x00978697
		// (set) Token: 0x06026A3F RID: 158271 RVA: 0x0097A4A7 File Offset: 0x009786A7
		public unsafe float CloudPhase
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudLayerComponent_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudLayerComponent_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005359 RID: 21337
		// (get) Token: 0x06026A40 RID: 158272 RVA: 0x0097A4B8 File Offset: 0x009786B8
		// (set) Token: 0x06026A41 RID: 158273 RVA: 0x0097A4C8 File Offset: 0x009786C8
		public unsafe float PrevCloudsTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudLayerComponent_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudLayerComponent_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700535A RID: 21338
		// (get) Token: 0x06026A42 RID: 158274 RVA: 0x0097A4D9 File Offset: 0x009786D9
		// (set) Token: 0x06026A43 RID: 158275 RVA: 0x0097A4ED File Offset: 0x009786ED
		public unsafe FVector CloudsPhasePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudLayerComponent_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudLayerComponent_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x06026A44 RID: 158276 RVA: 0x0097A504 File Offset: 0x00978704
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCloudVelocity(ref FVector Ret)
		{
			BP_CloudLayerComponent_C.__GetCloudVelocity_FunctionParams* ptr = stackalloc BP_CloudLayerComponent_C.__GetCloudVelocity_FunctionParams[(UIntPtr)99] + 15L / (long)sizeof(BP_CloudLayerComponent_C.__GetCloudVelocity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudLayerComponent_C.__GetCloudVelocity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Ret = Ret;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudLayerComponent_C.__GetCloudVelocity_NativeFunctionPtr, (void*)ptr);
			Ret = ptr->Ret;
		}

		// Token: 0x06026A45 RID: 158277 RVA: 0x0097A55C File Offset: 0x0097875C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Update_Cloud_Layer(UMaterialInstanceDynamic CloudMID, FVector SunLightDir, float TimeOfDay, BP_GlobalGI_C TODObj)
		{
			BP_CloudLayerComponent_C.__Update_Cloud_Layer_FunctionParams* ptr = stackalloc BP_CloudLayerComponent_C.__Update_Cloud_Layer_FunctionParams[(UIntPtr)311] + 15L / (long)sizeof(BP_CloudLayerComponent_C.__Update_Cloud_Layer_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudLayerComponent_C.__Update_Cloud_Layer_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CloudMID = ((CloudMID != null) ? CloudMID.NativePtr : IntPtr.Zero);
			ptr->SunLightDir = SunLightDir;
			ptr->TimeOfDay = TimeOfDay;
			ptr->TODObj = ((TODObj != null) ? TODObj.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudLayerComponent_C.__Update_Cloud_Layer_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026A46 RID: 158278 RVA: 0x0097A5DA File Offset: 0x009787DA
		protected BP_CloudLayerComponent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040136B9 RID: 79545
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/CloudLayer/BP_CloudLayerComponent.BP_CloudLayerComponent_C";

		// Token: 0x040136BA RID: 79546
		private static IntPtr _ClassPtr;

		// Token: 0x040136BB RID: 79547
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040136BC RID: 79548
		internal static int __PropertyOffset_0;

		// Token: 0x040136BD RID: 79549
		internal static int __PropertyOffset_1;

		// Token: 0x040136BE RID: 79550
		internal static int __PropertyOffset_2;

		// Token: 0x040136BF RID: 79551
		internal static int __PropertyOffset_3;

		// Token: 0x040136C0 RID: 79552
		internal static int __PropertyOffset_4;

		// Token: 0x040136C1 RID: 79553
		internal static int __PropertyOffset_5;

		// Token: 0x040136C2 RID: 79554
		internal static int __PropertyOffset_6;

		// Token: 0x040136C3 RID: 79555
		private static IntPtr __GetCloudVelocity_NativeFunctionPtr;

		// Token: 0x040136C4 RID: 79556
		private static IntPtr __Update_Cloud_Layer_NativeFunctionPtr;

		// Token: 0x0200A121 RID: 41249
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 84)]
		protected ref struct __GetCloudVelocity_FunctionParams
		{
			// Token: 0x04031C9B RID: 203931
			[FieldOffset(0)]
			public FVector Ret;
		}

		// Token: 0x0200A122 RID: 41250
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 296)]
		protected ref struct __Update_Cloud_Layer_FunctionParams
		{
			// Token: 0x04031C9C RID: 203932
			[FieldOffset(0)]
			public IntPtr CloudMID;

			// Token: 0x04031C9D RID: 203933
			[FieldOffset(8)]
			public FVector SunLightDir;

			// Token: 0x04031C9E RID: 203934
			[FieldOffset(20)]
			public float TimeOfDay;

			// Token: 0x04031C9F RID: 203935
			[FieldOffset(24)]
			public IntPtr TODObj;
		}
	}
}
