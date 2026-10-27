using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.InteractFoliage.Blueprint
{
	// Token: 0x02003B56 RID: 15190
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/InteractFoliage/Blueprint/BP_InteractFoliageManager.BP_InteractFoliageManager_C")]
	[UnrealStructLayout(1552, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1537)]
	public class BP_InteractFoliageManager_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021AD6 RID: 137942 RVA: 0x008F2D6A File Offset: 0x008F0F6A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_InteractFoliageManager_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/InteractFoliage/Blueprint/BP_InteractFoliageManager.BP_InteractFoliageManager_C");
			}
			return BP_InteractFoliageManager_C._ClassPtr;
		}

		// Token: 0x06021AD7 RID: 137943 RVA: 0x008F2D90 File Offset: 0x008F0F90
		public BP_InteractFoliageManager_C() : this(BuiltinUtils.AllocNativeUObject(BP_InteractFoliageManager_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021AD8 RID: 137944 RVA: 0x008F2DB8 File Offset: 0x008F0FB8
		[NullableContext(1)]
		public BP_InteractFoliageManager_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_InteractFoliageManager_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170037C3 RID: 14275
		// (get) Token: 0x06021AD9 RID: 137945 RVA: 0x008F2DEB File Offset: 0x008F0FEB
		// (set) Token: 0x06021ADA RID: 137946 RVA: 0x008F2DFF File Offset: 0x008F0FFF
		public unsafe UStaticMeshComponent Interactor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractFoliageManager_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractFoliageManager_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170037C4 RID: 14276
		// (get) Token: 0x06021ADB RID: 137947 RVA: 0x008F2E14 File Offset: 0x008F1014
		// (set) Token: 0x06021ADC RID: 137948 RVA: 0x008F2E28 File Offset: 0x008F1028
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractFoliageManager_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractFoliageManager_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170037C5 RID: 14277
		// (get) Token: 0x06021ADD RID: 137949 RVA: 0x008F2E3D File Offset: 0x008F103D
		// (set) Token: 0x06021ADE RID: 137950 RVA: 0x008F2E51 File Offset: 0x008F1051
		public unsafe FTransformDouble CharacterTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractFoliageManager_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractFoliageManager_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170037C6 RID: 14278
		// (get) Token: 0x06021ADF RID: 137951 RVA: 0x008F2E66 File Offset: 0x008F1066
		// (set) Token: 0x06021AE0 RID: 137952 RVA: 0x008F2E76 File Offset: 0x008F1076
		public unsafe bool Active
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractFoliageManager_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractFoliageManager_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021AE1 RID: 137953 RVA: 0x008F2E87 File Offset: 0x008F1087
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractFoliageManager_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021AE2 RID: 137954 RVA: 0x008F2E9B File Offset: 0x008F109B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_InteractFoliageManager_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021AE3 RID: 137955 RVA: 0x008F2EB0 File Offset: 0x008F10B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_InteractFoliageManager_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_InteractFoliageManager_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InteractFoliageManager_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractFoliageManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractFoliageManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021AE4 RID: 137956 RVA: 0x008F2EF8 File Offset: 0x008F10F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_InteractFoliageManager_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_InteractFoliageManager_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InteractFoliageManager_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractFoliageManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_InteractFoliageManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021AE5 RID: 137957 RVA: 0x008F2F3F File Offset: 0x008F113F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CheckActive()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractFoliageManager_C.__CheckActive_NativeFunctionPtr, null);
		}

		// Token: 0x06021AE6 RID: 137958 RVA: 0x008F2F53 File Offset: 0x008F1153
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DebugInteractor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractFoliageManager_C.__DebugInteractor_NativeFunctionPtr, null);
		}

		// Token: 0x06021AE7 RID: 137959 RVA: 0x008F2F67 File Offset: 0x008F1167
		protected BP_InteractFoliageManager_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040106D6 RID: 67286
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/InteractFoliage/Blueprint/BP_InteractFoliageManager.BP_InteractFoliageManager_C";

		// Token: 0x040106D7 RID: 67287
		private static IntPtr _ClassPtr;

		// Token: 0x040106D8 RID: 67288
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040106D9 RID: 67289
		internal static int __PropertyOffset_1;

		// Token: 0x040106DA RID: 67290
		internal static int __PropertyOffset_2;

		// Token: 0x040106DB RID: 67291
		internal static int __PropertyOffset_3;

		// Token: 0x040106DC RID: 67292
		internal static int __PropertyOffset_4;

		// Token: 0x040106DD RID: 67293
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040106DE RID: 67294
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040106DF RID: 67295
		private static IntPtr __CheckActive_NativeFunctionPtr;

		// Token: 0x040106E0 RID: 67296
		private static IntPtr __DebugInteractor_NativeFunctionPtr;

		// Token: 0x02009CBE RID: 40126
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040313A3 RID: 201635
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
