using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common
{
	// Token: 0x02003B5A RID: 15194
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/BP_FloatingChildActor.BP_FloatingChildActor_C")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1528)]
	public class BP_FloatingChildActor_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021B06 RID: 137990 RVA: 0x008F3220 File Offset: 0x008F1420
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FloatingChildActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/BP_FloatingChildActor.BP_FloatingChildActor_C");
			}
			return BP_FloatingChildActor_C._ClassPtr;
		}

		// Token: 0x06021B07 RID: 137991 RVA: 0x008F3244 File Offset: 0x008F1444
		public BP_FloatingChildActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_FloatingChildActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021B08 RID: 137992 RVA: 0x008F326C File Offset: 0x008F146C
		[NullableContext(1)]
		public BP_FloatingChildActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FloatingChildActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170037CC RID: 14284
		// (get) Token: 0x06021B09 RID: 137993 RVA: 0x008F329F File Offset: 0x008F149F
		// (set) Token: 0x06021B0A RID: 137994 RVA: 0x008F32B3 File Offset: 0x008F14B3
		public unsafe USceneComponent Scene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingChildActor_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingChildActor_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170037CD RID: 14285
		// (get) Token: 0x06021B0B RID: 137995 RVA: 0x008F32C8 File Offset: 0x008F14C8
		// (set) Token: 0x06021B0C RID: 137996 RVA: 0x008F32D8 File Offset: 0x008F14D8
		public unsafe float Age
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingChildActor_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingChildActor_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170037CE RID: 14286
		// (get) Token: 0x06021B0D RID: 137997 RVA: 0x008F32E9 File Offset: 0x008F14E9
		// (set) Token: 0x06021B0E RID: 137998 RVA: 0x008F32FD File Offset: 0x008F14FD
		public unsafe FVector Movement
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingChildActor_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingChildActor_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170037CF RID: 14287
		// (get) Token: 0x06021B0F RID: 137999 RVA: 0x008F3312 File Offset: 0x008F1512
		// (set) Token: 0x06021B10 RID: 138000 RVA: 0x008F3322 File Offset: 0x008F1522
		public unsafe float Frequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingChildActor_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingChildActor_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170037D0 RID: 14288
		// (get) Token: 0x06021B11 RID: 138001 RVA: 0x008F3333 File Offset: 0x008F1533
		// (set) Token: 0x06021B12 RID: 138002 RVA: 0x008F3347 File Offset: 0x008F1547
		public unsafe FVector RotateCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingChildActor_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingChildActor_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170037D1 RID: 14289
		// (get) Token: 0x06021B13 RID: 138003 RVA: 0x008F335C File Offset: 0x008F155C
		// (set) Token: 0x06021B14 RID: 138004 RVA: 0x008F3370 File Offset: 0x008F1570
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingChildActor_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingChildActor_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170037D2 RID: 14290
		// (get) Token: 0x06021B15 RID: 138005 RVA: 0x008F3385 File Offset: 0x008F1585
		// (set) Token: 0x06021B16 RID: 138006 RVA: 0x008F3399 File Offset: 0x008F1599
		public unsafe UChildActorComponent ChildActorComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingChildActor_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingChildActor_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x170037D3 RID: 14291
		// (get) Token: 0x06021B17 RID: 138007 RVA: 0x008F33AE File Offset: 0x008F15AE
		// (set) Token: 0x06021B18 RID: 138008 RVA: 0x008F33C2 File Offset: 0x008F15C2
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AActor> BPClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingChildActor_C.__PropertyOffset_8);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingChildActor_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x06021B19 RID: 138009 RVA: 0x008F33D7 File Offset: 0x008F15D7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingChildActor_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06021B1A RID: 138010 RVA: 0x008F33EB File Offset: 0x008F15EB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FloatingChildActor_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021B1B RID: 138011 RVA: 0x008F3400 File Offset: 0x008F1600
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_FloatingChildActor_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FloatingChildActor_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FloatingChildActor_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FloatingChildActor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingChildActor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021B1C RID: 138012 RVA: 0x008F3448 File Offset: 0x008F1648
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_FloatingChildActor_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FloatingChildActor_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FloatingChildActor_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FloatingChildActor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FloatingChildActor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021B1D RID: 138013 RVA: 0x008F3490 File Offset: 0x008F1690
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_FloatingChildActor_C.__EditorTick_FunctionParams* ptr = stackalloc BP_FloatingChildActor_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FloatingChildActor_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FloatingChildActor_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingChildActor_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021B1E RID: 138014 RVA: 0x008F34D8 File Offset: 0x008F16D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_FloatingChildActor_C.__EditorTick_FunctionParams* ptr = stackalloc BP_FloatingChildActor_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FloatingChildActor_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FloatingChildActor_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FloatingChildActor_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021B1F RID: 138015 RVA: 0x008F351F File Offset: 0x008F171F
		protected BP_FloatingChildActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040106F2 RID: 67314
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/BP_FloatingChildActor.BP_FloatingChildActor_C";

		// Token: 0x040106F3 RID: 67315
		private static IntPtr _ClassPtr;

		// Token: 0x040106F4 RID: 67316
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040106F5 RID: 67317
		internal static int __PropertyOffset_1;

		// Token: 0x040106F6 RID: 67318
		internal static int __PropertyOffset_2;

		// Token: 0x040106F7 RID: 67319
		internal static int __PropertyOffset_3;

		// Token: 0x040106F8 RID: 67320
		internal static int __PropertyOffset_4;

		// Token: 0x040106F9 RID: 67321
		internal static int __PropertyOffset_5;

		// Token: 0x040106FA RID: 67322
		internal static int __PropertyOffset_6;

		// Token: 0x040106FB RID: 67323
		internal static int __PropertyOffset_7;

		// Token: 0x040106FC RID: 67324
		internal static int __PropertyOffset_8;

		// Token: 0x040106FD RID: 67325
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040106FE RID: 67326
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040106FF RID: 67327
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009CBF RID: 40127
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040313A4 RID: 201636
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009CC0 RID: 40128
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040313A5 RID: 201637
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
