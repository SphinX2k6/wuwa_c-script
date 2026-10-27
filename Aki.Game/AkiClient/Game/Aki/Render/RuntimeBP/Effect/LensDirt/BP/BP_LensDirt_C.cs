using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.LensDirt.BP
{
	// Token: 0x02003DD8 RID: 15832
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/LensDirt/BP/BP_LensDirt.BP_LensDirt_C")]
	[UnrealStructLayout(1544, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1544)]
	public class BP_LensDirt_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060277B5 RID: 161717 RVA: 0x00992AB2 File Offset: 0x00990CB2
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_LensDirt_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/LensDirt/BP/BP_LensDirt.BP_LensDirt_C");
			}
			return BP_LensDirt_C._ClassPtr;
		}

		// Token: 0x060277B6 RID: 161718 RVA: 0x00992AD8 File Offset: 0x00990CD8
		public BP_LensDirt_C() : this(BuiltinUtils.AllocNativeUObject(BP_LensDirt_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060277B7 RID: 161719 RVA: 0x00992B00 File Offset: 0x00990D00
		[NullableContext(1)]
		public BP_LensDirt_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_LensDirt_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005863 RID: 22627
		// (get) Token: 0x060277B8 RID: 161720 RVA: 0x00992B33 File Offset: 0x00990D33
		// (set) Token: 0x060277B9 RID: 161721 RVA: 0x00992B47 File Offset: 0x00990D47
		public unsafe UStaticMeshComponent LensDirt_Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LensDirt_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LensDirt_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005864 RID: 22628
		// (get) Token: 0x060277BA RID: 161722 RVA: 0x00992B5C File Offset: 0x00990D5C
		// (set) Token: 0x060277BB RID: 161723 RVA: 0x00992B70 File Offset: 0x00990D70
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LensDirt_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LensDirt_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005865 RID: 22629
		// (get) Token: 0x060277BC RID: 161724 RVA: 0x00992B85 File Offset: 0x00990D85
		// (set) Token: 0x060277BD RID: 161725 RVA: 0x00992B99 File Offset: 0x00990D99
		public unsafe UMaterialInstanceDynamic LensDirt_DynamicMaterialInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LensDirt_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LensDirt_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005866 RID: 22630
		// (get) Token: 0x060277BE RID: 161726 RVA: 0x00992BAE File Offset: 0x00990DAE
		// (set) Token: 0x060277BF RID: 161727 RVA: 0x00992BC2 File Offset: 0x00990DC2
		public unsafe UTexture2D LensDirt_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LensDirt_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LensDirt_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17005867 RID: 22631
		// (get) Token: 0x060277C0 RID: 161728 RVA: 0x00992BD7 File Offset: 0x00990DD7
		// (set) Token: 0x060277C1 RID: 161729 RVA: 0x00992BEB File Offset: 0x00990DEB
		public unsafe FVector Dirt_Tilling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDirt_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDirt_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005868 RID: 22632
		// (get) Token: 0x060277C2 RID: 161730 RVA: 0x00992C00 File Offset: 0x00990E00
		// (set) Token: 0x060277C3 RID: 161731 RVA: 0x00992C14 File Offset: 0x00990E14
		public unsafe UTexture2D DirtMask_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LensDirt_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LensDirt_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17005869 RID: 22633
		// (get) Token: 0x060277C4 RID: 161732 RVA: 0x00992C29 File Offset: 0x00990E29
		// (set) Token: 0x060277C5 RID: 161733 RVA: 0x00992C3D File Offset: 0x00990E3D
		public unsafe FVector Mask_Tilling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDirt_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDirt_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700586A RID: 22634
		// (get) Token: 0x060277C6 RID: 161734 RVA: 0x00992C52 File Offset: 0x00990E52
		// (set) Token: 0x060277C7 RID: 161735 RVA: 0x00992C62 File Offset: 0x00990E62
		public unsafe float SphereMask_Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDirt_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDirt_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700586B RID: 22635
		// (get) Token: 0x060277C8 RID: 161736 RVA: 0x00992C73 File Offset: 0x00990E73
		// (set) Token: 0x060277C9 RID: 161737 RVA: 0x00992C83 File Offset: 0x00990E83
		public unsafe float SphereMask_Range
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDirt_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDirt_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700586C RID: 22636
		// (get) Token: 0x060277CA RID: 161738 RVA: 0x00992C94 File Offset: 0x00990E94
		// (set) Token: 0x060277CB RID: 161739 RVA: 0x00992CA4 File Offset: 0x00990EA4
		public unsafe float SphereMask_Power
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDirt_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDirt_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700586D RID: 22637
		// (get) Token: 0x060277CC RID: 161740 RVA: 0x00992CB5 File Offset: 0x00990EB5
		// (set) Token: 0x060277CD RID: 161741 RVA: 0x00992CC9 File Offset: 0x00990EC9
		public unsafe FColor Dirt_ColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDirt_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDirt_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700586E RID: 22638
		// (get) Token: 0x060277CE RID: 161742 RVA: 0x00992CDE File Offset: 0x00990EDE
		// (set) Token: 0x060277CF RID: 161743 RVA: 0x00992CEE File Offset: 0x00990EEE
		public unsafe float Dirt_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDirt_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDirt_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x060277D0 RID: 161744 RVA: 0x00992CFF File Offset: 0x00990EFF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LensDirt_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060277D1 RID: 161745 RVA: 0x00992D13 File Offset: 0x00990F13
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LensDirt_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060277D2 RID: 161746 RVA: 0x00992D28 File Offset: 0x00990F28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LensDirt_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060277D3 RID: 161747 RVA: 0x00992D3C File Offset: 0x00990F3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LensDirt_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060277D4 RID: 161748 RVA: 0x00992D54 File Offset: 0x00990F54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_LensDirt_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LensDirt_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LensDirt_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LensDirt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LensDirt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060277D5 RID: 161749 RVA: 0x00992D9C File Offset: 0x00990F9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_LensDirt_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LensDirt_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LensDirt_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LensDirt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LensDirt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060277D6 RID: 161750 RVA: 0x00992DE4 File Offset: 0x00990FE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_LensDirt_C.__EditorTick_FunctionParams* ptr = stackalloc BP_LensDirt_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LensDirt_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LensDirt_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LensDirt_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060277D7 RID: 161751 RVA: 0x00992E2C File Offset: 0x0099102C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_LensDirt_C.__EditorTick_FunctionParams* ptr = stackalloc BP_LensDirt_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LensDirt_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LensDirt_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LensDirt_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060277D8 RID: 161752 RVA: 0x00992E73 File Offset: 0x00991073
		protected BP_LensDirt_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013F2B RID: 81707
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/LensDirt/BP/BP_LensDirt.BP_LensDirt_C";

		// Token: 0x04013F2C RID: 81708
		private static IntPtr _ClassPtr;

		// Token: 0x04013F2D RID: 81709
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013F2E RID: 81710
		internal static int __PropertyOffset_1;

		// Token: 0x04013F2F RID: 81711
		internal static int __PropertyOffset_2;

		// Token: 0x04013F30 RID: 81712
		internal static int __PropertyOffset_3;

		// Token: 0x04013F31 RID: 81713
		internal static int __PropertyOffset_4;

		// Token: 0x04013F32 RID: 81714
		internal static int __PropertyOffset_5;

		// Token: 0x04013F33 RID: 81715
		internal static int __PropertyOffset_6;

		// Token: 0x04013F34 RID: 81716
		internal static int __PropertyOffset_7;

		// Token: 0x04013F35 RID: 81717
		internal static int __PropertyOffset_8;

		// Token: 0x04013F36 RID: 81718
		internal static int __PropertyOffset_9;

		// Token: 0x04013F37 RID: 81719
		internal static int __PropertyOffset_10;

		// Token: 0x04013F38 RID: 81720
		internal static int __PropertyOffset_11;

		// Token: 0x04013F39 RID: 81721
		internal static int __PropertyOffset_12;

		// Token: 0x04013F3A RID: 81722
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04013F3B RID: 81723
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013F3C RID: 81724
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04013F3D RID: 81725
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A23D RID: 41533
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031ECA RID: 204490
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A23E RID: 41534
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031ECB RID: 204491
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
