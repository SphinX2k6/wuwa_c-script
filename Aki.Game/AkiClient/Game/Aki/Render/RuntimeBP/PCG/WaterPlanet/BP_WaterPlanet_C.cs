using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.WaterPlanet
{
	// Token: 0x02003BDB RID: 15323
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/WaterPlanet/BP_WaterPlanet.BP_WaterPlanet_C")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1536)]
	public class BP_WaterPlanet_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022901 RID: 141569 RVA: 0x0090C2B2 File Offset: 0x0090A4B2
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WaterPlanet_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/WaterPlanet/BP_WaterPlanet.BP_WaterPlanet_C");
			}
			return BP_WaterPlanet_C._ClassPtr;
		}

		// Token: 0x06022902 RID: 141570 RVA: 0x0090C2D8 File Offset: 0x0090A4D8
		public BP_WaterPlanet_C() : this(BuiltinUtils.AllocNativeUObject(BP_WaterPlanet_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022903 RID: 141571 RVA: 0x0090C300 File Offset: 0x0090A500
		[NullableContext(1)]
		public BP_WaterPlanet_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WaterPlanet_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003C6D RID: 15469
		// (get) Token: 0x06022904 RID: 141572 RVA: 0x0090C333 File Offset: 0x0090A533
		// (set) Token: 0x06022905 RID: 141573 RVA: 0x0090C347 File Offset: 0x0090A547
		public unsafe UStaticMeshComponent SM_WaterPlanet_02
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterPlanet_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterPlanet_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003C6E RID: 15470
		// (get) Token: 0x06022906 RID: 141574 RVA: 0x0090C35C File Offset: 0x0090A55C
		// (set) Token: 0x06022907 RID: 141575 RVA: 0x0090C370 File Offset: 0x0090A570
		public unsafe UStaticMeshComponent SM_WaterPlanet_01
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterPlanet_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterPlanet_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003C6F RID: 15471
		// (get) Token: 0x06022908 RID: 141576 RVA: 0x0090C385 File Offset: 0x0090A585
		// (set) Token: 0x06022909 RID: 141577 RVA: 0x0090C399 File Offset: 0x0090A599
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterPlanet_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterPlanet_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003C70 RID: 15472
		// (get) Token: 0x0602290A RID: 141578 RVA: 0x0090C3AE File Offset: 0x0090A5AE
		// (set) Token: 0x0602290B RID: 141579 RVA: 0x0090C3BE File Offset: 0x0090A5BE
		public unsafe float CustomTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterPlanet_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterPlanet_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003C71 RID: 15473
		// (get) Token: 0x0602290C RID: 141580 RVA: 0x0090C3CF File Offset: 0x0090A5CF
		// (set) Token: 0x0602290D RID: 141581 RVA: 0x0090C3DF File Offset: 0x0090A5DF
		public unsafe float TransitTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterPlanet_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterPlanet_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003C72 RID: 15474
		// (get) Token: 0x0602290E RID: 141582 RVA: 0x0090C3F0 File Offset: 0x0090A5F0
		// (set) Token: 0x0602290F RID: 141583 RVA: 0x0090C400 File Offset: 0x0090A600
		public unsafe float AnimaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterPlanet_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterPlanet_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003C73 RID: 15475
		// (get) Token: 0x06022910 RID: 141584 RVA: 0x0090C411 File Offset: 0x0090A611
		// (set) Token: 0x06022911 RID: 141585 RVA: 0x0090C421 File Offset: 0x0090A621
		public unsafe float Delta_Seconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterPlanet_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterPlanet_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003C74 RID: 15476
		// (get) Token: 0x06022912 RID: 141586 RVA: 0x0090C432 File Offset: 0x0090A632
		// (set) Token: 0x06022913 RID: 141587 RVA: 0x0090C442 File Offset: 0x0090A642
		public unsafe float ShaderTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterPlanet_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterPlanet_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003C75 RID: 15477
		// (get) Token: 0x06022914 RID: 141588 RVA: 0x0090C453 File Offset: 0x0090A653
		// (set) Token: 0x06022915 RID: 141589 RVA: 0x0090C467 File Offset: 0x0090A667
		public unsafe FVectorDouble Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterPlanet_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterPlanet_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x06022916 RID: 141590 RVA: 0x0090C47C File Offset: 0x0090A67C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterPlanet_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022917 RID: 141591 RVA: 0x0090C490 File Offset: 0x0090A690
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterPlanet_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022918 RID: 141592 RVA: 0x0090C4A8 File Offset: 0x0090A6A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_WaterPlanet_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterPlanet_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterPlanet_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterPlanet_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterPlanet_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022919 RID: 141593 RVA: 0x0090C4F0 File Offset: 0x0090A6F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_WaterPlanet_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterPlanet_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterPlanet_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterPlanet_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterPlanet_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602291A RID: 141594 RVA: 0x0090C538 File Offset: 0x0090A738
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_WaterPlanet_C.__EditorTick_FunctionParams* ptr = stackalloc BP_WaterPlanet_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterPlanet_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterPlanet_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterPlanet_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602291B RID: 141595 RVA: 0x0090C580 File Offset: 0x0090A780
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_WaterPlanet_C.__EditorTick_FunctionParams* ptr = stackalloc BP_WaterPlanet_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterPlanet_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterPlanet_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterPlanet_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602291C RID: 141596 RVA: 0x0090C5C7 File Offset: 0x0090A7C7
		protected BP_WaterPlanet_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010F95 RID: 69525
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/WaterPlanet/BP_WaterPlanet.BP_WaterPlanet_C";

		// Token: 0x04010F96 RID: 69526
		private static IntPtr _ClassPtr;

		// Token: 0x04010F97 RID: 69527
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010F98 RID: 69528
		internal static int __PropertyOffset_1;

		// Token: 0x04010F99 RID: 69529
		internal static int __PropertyOffset_2;

		// Token: 0x04010F9A RID: 69530
		internal static int __PropertyOffset_3;

		// Token: 0x04010F9B RID: 69531
		internal static int __PropertyOffset_4;

		// Token: 0x04010F9C RID: 69532
		internal static int __PropertyOffset_5;

		// Token: 0x04010F9D RID: 69533
		internal static int __PropertyOffset_6;

		// Token: 0x04010F9E RID: 69534
		internal static int __PropertyOffset_7;

		// Token: 0x04010F9F RID: 69535
		internal static int __PropertyOffset_8;

		// Token: 0x04010FA0 RID: 69536
		internal static int __PropertyOffset_9;

		// Token: 0x04010FA1 RID: 69537
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010FA2 RID: 69538
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010FA3 RID: 69539
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009D97 RID: 40343
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031568 RID: 202088
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009D98 RID: 40344
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031569 RID: 202089
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
