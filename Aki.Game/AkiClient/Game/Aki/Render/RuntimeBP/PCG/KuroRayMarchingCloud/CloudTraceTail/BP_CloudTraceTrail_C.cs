using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroRayMarchingCloud.CloudTraceTail
{
	// Token: 0x02003C85 RID: 15493
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/CloudTraceTail/BP_CloudTraceTrail.BP_CloudTraceTrail_C")]
	[UnrealStructLayout(1160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1153)]
	public class BP_CloudTraceTrail_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602426B RID: 148075 RVA: 0x00936204 File Offset: 0x00934404
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CloudTraceTrail_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/CloudTraceTail/BP_CloudTraceTrail.BP_CloudTraceTrail_C");
			}
			return BP_CloudTraceTrail_C._ClassPtr;
		}

		// Token: 0x0602426C RID: 148076 RVA: 0x00936228 File Offset: 0x00934428
		public BP_CloudTraceTrail_C() : this(BuiltinUtils.AllocNativeUObject(BP_CloudTraceTrail_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602426D RID: 148077 RVA: 0x00936250 File Offset: 0x00934450
		[NullableContext(1)]
		public BP_CloudTraceTrail_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CloudTraceTrail_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700458A RID: 17802
		// (get) Token: 0x0602426E RID: 148078 RVA: 0x00936283 File Offset: 0x00934483
		// (set) Token: 0x0602426F RID: 148079 RVA: 0x00936297 File Offset: 0x00934497
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudTraceTrail_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudTraceTrail_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700458B RID: 17803
		// (get) Token: 0x06024270 RID: 148080 RVA: 0x009362AC File Offset: 0x009344AC
		// (set) Token: 0x06024271 RID: 148081 RVA: 0x009362C0 File Offset: 0x009344C0
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudTraceTrail_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudTraceTrail_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700458C RID: 17804
		// (get) Token: 0x06024272 RID: 148082 RVA: 0x009362D5 File Offset: 0x009344D5
		// (set) Token: 0x06024273 RID: 148083 RVA: 0x009362E9 File Offset: 0x009344E9
		public unsafe UMaterialInstanceDynamic RTMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudTraceTrail_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudTraceTrail_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700458D RID: 17805
		// (get) Token: 0x06024274 RID: 148084 RVA: 0x009362FE File Offset: 0x009344FE
		// (set) Token: 0x06024275 RID: 148085 RVA: 0x00936312 File Offset: 0x00934512
		public unsafe AActor BindActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudTraceTrail_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudTraceTrail_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700458E RID: 17806
		// (get) Token: 0x06024276 RID: 148086 RVA: 0x00936327 File Offset: 0x00934527
		// (set) Token: 0x06024277 RID: 148087 RVA: 0x00936337 File Offset: 0x00934537
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudTraceTrail_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudTraceTrail_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700458F RID: 17807
		// (get) Token: 0x06024278 RID: 148088 RVA: 0x00936348 File Offset: 0x00934548
		// (set) Token: 0x06024279 RID: 148089 RVA: 0x0093635C File Offset: 0x0093455C
		public unsafe UMaterialInstanceDynamic RTMaterial_Pre
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudTraceTrail_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudTraceTrail_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004590 RID: 17808
		// (get) Token: 0x0602427A RID: 148090 RVA: 0x00936371 File Offset: 0x00934571
		// (set) Token: 0x0602427B RID: 148091 RVA: 0x00936385 File Offset: 0x00934585
		public unsafe FVectorDouble LastPostion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudTraceTrail_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudTraceTrail_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004591 RID: 17809
		// (get) Token: 0x0602427C RID: 148092 RVA: 0x0093639A File Offset: 0x0093459A
		// (set) Token: 0x0602427D RID: 148093 RVA: 0x009363AE File Offset: 0x009345AE
		public unsafe FVector LastMotionOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudTraceTrail_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudTraceTrail_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004592 RID: 17810
		// (get) Token: 0x0602427E RID: 148094 RVA: 0x009363C3 File Offset: 0x009345C3
		// (set) Token: 0x0602427F RID: 148095 RVA: 0x009363D3 File Offset: 0x009345D3
		public unsafe bool bFadeWhenStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudTraceTrail_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudTraceTrail_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004593 RID: 17811
		// (get) Token: 0x06024280 RID: 148096 RVA: 0x009363E4 File Offset: 0x009345E4
		// (set) Token: 0x06024281 RID: 148097 RVA: 0x009363F4 File Offset: 0x009345F4
		public unsafe bool bFirstTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudTraceTrail_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudTraceTrail_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004594 RID: 17812
		// (get) Token: 0x06024282 RID: 148098 RVA: 0x00936405 File Offset: 0x00934605
		// (set) Token: 0x06024283 RID: 148099 RVA: 0x00936415 File Offset: 0x00934615
		public unsafe bool bEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudTraceTrail_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudTraceTrail_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004595 RID: 17813
		// (get) Token: 0x06024284 RID: 148100 RVA: 0x00936426 File Offset: 0x00934626
		// (set) Token: 0x06024285 RID: 148101 RVA: 0x0093643A File Offset: 0x0093463A
		public unsafe UTexture2D CloudMask
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudTraceTrail_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudTraceTrail_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17004596 RID: 17814
		// (get) Token: 0x06024286 RID: 148102 RVA: 0x0093644F File Offset: 0x0093464F
		// (set) Token: 0x06024287 RID: 148103 RVA: 0x0093645F File Offset: 0x0093465F
		public unsafe bool bDrawBound
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudTraceTrail_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudTraceTrail_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x06024288 RID: 148104 RVA: 0x00936470 File Offset: 0x00934670
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudTraceTrail_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024289 RID: 148105 RVA: 0x00936484 File Offset: 0x00934684
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CloudTraceTrail_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602428A RID: 148106 RVA: 0x0093649C File Offset: 0x0093469C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CloudTraceTrail_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CloudTraceTrail_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CloudTraceTrail_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudTraceTrail_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudTraceTrail_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602428B RID: 148107 RVA: 0x009364E4 File Offset: 0x009346E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CloudTraceTrail_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CloudTraceTrail_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CloudTraceTrail_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudTraceTrail_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CloudTraceTrail_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602428C RID: 148108 RVA: 0x0093652B File Offset: 0x0093472B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudTraceTrail_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x0602428D RID: 148109 RVA: 0x0093653F File Offset: 0x0093473F
		protected BP_CloudTraceTrail_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011E69 RID: 73321
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/CloudTraceTail/BP_CloudTraceTrail.BP_CloudTraceTrail_C";

		// Token: 0x04011E6A RID: 73322
		private static IntPtr _ClassPtr;

		// Token: 0x04011E6B RID: 73323
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011E6C RID: 73324
		internal static int __PropertyOffset_1;

		// Token: 0x04011E6D RID: 73325
		internal static int __PropertyOffset_2;

		// Token: 0x04011E6E RID: 73326
		internal static int __PropertyOffset_3;

		// Token: 0x04011E6F RID: 73327
		internal static int __PropertyOffset_4;

		// Token: 0x04011E70 RID: 73328
		internal static int __PropertyOffset_5;

		// Token: 0x04011E71 RID: 73329
		internal static int __PropertyOffset_6;

		// Token: 0x04011E72 RID: 73330
		internal static int __PropertyOffset_7;

		// Token: 0x04011E73 RID: 73331
		internal static int __PropertyOffset_8;

		// Token: 0x04011E74 RID: 73332
		internal static int __PropertyOffset_9;

		// Token: 0x04011E75 RID: 73333
		internal static int __PropertyOffset_10;

		// Token: 0x04011E76 RID: 73334
		internal static int __PropertyOffset_11;

		// Token: 0x04011E77 RID: 73335
		internal static int __PropertyOffset_12;

		// Token: 0x04011E78 RID: 73336
		internal static int __PropertyOffset_13;

		// Token: 0x04011E79 RID: 73337
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011E7A RID: 73338
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011E7B RID: 73339
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009ED7 RID: 40663
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040317C4 RID: 202692
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
