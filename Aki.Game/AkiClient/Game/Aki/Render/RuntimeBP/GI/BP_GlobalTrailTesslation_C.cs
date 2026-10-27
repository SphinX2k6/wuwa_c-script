using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.TrailFields.Runtime;
using AkiClient.Game.Aki.Render.RuntimeBP.TrailFields.Runtime.Drawers;
using AkiClient.Game.Aki.Render.RuntimeBP.TrailFields.Runtime.Sensors;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI
{
	// Token: 0x02003D2F RID: 15663
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/BP_GlobalTrailTesslation.BP_GlobalTrailTesslation_C")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class BP_GlobalTrailTesslation_C : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025F22 RID: 155426 RVA: 0x00967148 File Offset: 0x00965348
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_GlobalTrailTesslation_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/BP_GlobalTrailTesslation.BP_GlobalTrailTesslation_C");
			}
			return BP_GlobalTrailTesslation_C._ClassPtr;
		}

		// Token: 0x06025F23 RID: 155427 RVA: 0x0096716C File Offset: 0x0096536C
		public BP_GlobalTrailTesslation_C() : this(BuiltinUtils.AllocNativeUObject(BP_GlobalTrailTesslation_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025F24 RID: 155428 RVA: 0x00967194 File Offset: 0x00965394
		[NullableContext(1)]
		public BP_GlobalTrailTesslation_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_GlobalTrailTesslation_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004FA6 RID: 20390
		// (get) Token: 0x06025F25 RID: 155429 RVA: 0x009671C7 File Offset: 0x009653C7
		// (set) Token: 0x06025F26 RID: 155430 RVA: 0x009671D7 File Offset: 0x009653D7
		public unsafe bool GenerateTesslation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GlobalTrailTesslation_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GlobalTrailTesslation_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004FA7 RID: 20391
		// (get) Token: 0x06025F27 RID: 155431 RVA: 0x009671E8 File Offset: 0x009653E8
		// (set) Token: 0x06025F28 RID: 155432 RVA: 0x009671FC File Offset: 0x009653FC
		public unsafe BP_TrailDrawActor_Capture_C TrailDrawCapture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_TrailDrawActor_Capture_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalTrailTesslation_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalTrailTesslation_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004FA8 RID: 20392
		// (get) Token: 0x06025F29 RID: 155433 RVA: 0x00967211 File Offset: 0x00965411
		// (set) Token: 0x06025F2A RID: 155434 RVA: 0x00967225 File Offset: 0x00965425
		public unsafe BP_TrailSensor_Snow_C TrailSensor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_TrailSensor_Snow_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalTrailTesslation_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalTrailTesslation_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004FA9 RID: 20393
		// (get) Token: 0x06025F2B RID: 155435 RVA: 0x0096723A File Offset: 0x0096543A
		// (set) Token: 0x06025F2C RID: 155436 RVA: 0x0096724E File Offset: 0x0096544E
		public unsafe BP_TrailsManager_C Trailmanager
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_TrailsManager_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalTrailTesslation_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalTrailTesslation_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004FAA RID: 20394
		// (get) Token: 0x06025F2D RID: 155437 RVA: 0x00967263 File Offset: 0x00965463
		// (set) Token: 0x06025F2E RID: 155438 RVA: 0x00967277 File Offset: 0x00965477
		public unsafe BP_GlobalGI_C BP_GlobalGI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_GlobalGI_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalTrailTesslation_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalTrailTesslation_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x06025F2F RID: 155439 RVA: 0x0096728C File Offset: 0x0096548C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalTrailTesslation_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06025F30 RID: 155440 RVA: 0x009672A0 File Offset: 0x009654A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalTrailTesslation_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025F31 RID: 155441 RVA: 0x009672B8 File Offset: 0x009654B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_GlobalTrailTesslation_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_GlobalTrailTesslation_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_GlobalTrailTesslation_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalTrailTesslation_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalTrailTesslation_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025F32 RID: 155442 RVA: 0x00967304 File Offset: 0x00965504
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_GlobalTrailTesslation_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_GlobalTrailTesslation_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_GlobalTrailTesslation_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalTrailTesslation_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GlobalTrailTesslation_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025F33 RID: 155443 RVA: 0x00967350 File Offset: 0x00965550
		protected BP_GlobalTrailTesslation_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012FB5 RID: 77749
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/BP_GlobalTrailTesslation.BP_GlobalTrailTesslation_C";

		// Token: 0x04012FB6 RID: 77750
		private static IntPtr _ClassPtr;

		// Token: 0x04012FB7 RID: 77751
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012FB8 RID: 77752
		internal static int __PropertyOffset_1;

		// Token: 0x04012FB9 RID: 77753
		internal static int __PropertyOffset_2;

		// Token: 0x04012FBA RID: 77754
		internal static int __PropertyOffset_3;

		// Token: 0x04012FBB RID: 77755
		internal static int __PropertyOffset_4;

		// Token: 0x04012FBC RID: 77756
		internal static int __PropertyOffset_5;

		// Token: 0x04012FBD RID: 77757
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012FBE RID: 77758
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x0200A06F RID: 41071
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031B61 RID: 203617
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
