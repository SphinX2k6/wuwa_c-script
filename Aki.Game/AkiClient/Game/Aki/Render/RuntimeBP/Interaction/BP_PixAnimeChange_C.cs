using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x02003D1A RID: 15642
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/BP_PixAnimeChange.BP_PixAnimeChange_C")]
	[UnrealStructLayout(1504, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1504)]
	public class BP_PixAnimeChange_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025899 RID: 153753 RVA: 0x0095C618 File Offset: 0x0095A818
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PixAnimeChange_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/BP_PixAnimeChange.BP_PixAnimeChange_C");
			}
			return BP_PixAnimeChange_C._ClassPtr;
		}

		// Token: 0x0602589A RID: 153754 RVA: 0x0095C63C File Offset: 0x0095A83C
		public BP_PixAnimeChange_C() : this(BuiltinUtils.AllocNativeUObject(BP_PixAnimeChange_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602589B RID: 153755 RVA: 0x0095C664 File Offset: 0x0095A864
		[NullableContext(1)]
		public BP_PixAnimeChange_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PixAnimeChange_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D27 RID: 19751
		// (get) Token: 0x0602589C RID: 153756 RVA: 0x0095C697 File Offset: 0x0095A897
		// (set) Token: 0x0602589D RID: 153757 RVA: 0x0095C6AB File Offset: 0x0095A8AB
		public unsafe UStaticMeshComponent Plane
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PixAnimeChange_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PixAnimeChange_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004D28 RID: 19752
		// (get) Token: 0x0602589E RID: 153758 RVA: 0x0095C6C0 File Offset: 0x0095A8C0
		// (set) Token: 0x0602589F RID: 153759 RVA: 0x0095C6D4 File Offset: 0x0095A8D4
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PixAnimeChange_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PixAnimeChange_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004D29 RID: 19753
		// (get) Token: 0x060258A0 RID: 153760 RVA: 0x0095C6E9 File Offset: 0x0095A8E9
		// (set) Token: 0x060258A1 RID: 153761 RVA: 0x0095C6F9 File Offset: 0x0095A8F9
		public unsafe bool bIsPlaying
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PixAnimeChange_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PixAnimeChange_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D2A RID: 19754
		// (get) Token: 0x060258A2 RID: 153762 RVA: 0x0095C70A File Offset: 0x0095A90A
		// (set) Token: 0x060258A3 RID: 153763 RVA: 0x0095C71A File Offset: 0x0095A91A
		public unsafe int PlayingRow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PixAnimeChange_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PixAnimeChange_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004D2B RID: 19755
		// (get) Token: 0x060258A4 RID: 153764 RVA: 0x0095C72B File Offset: 0x0095A92B
		// (set) Token: 0x060258A5 RID: 153765 RVA: 0x0095C73B File Offset: 0x0095A93B
		public unsafe int LastPlayingRow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PixAnimeChange_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PixAnimeChange_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004D2C RID: 19756
		// (get) Token: 0x060258A6 RID: 153766 RVA: 0x0095C74C File Offset: 0x0095A94C
		// (set) Token: 0x060258A7 RID: 153767 RVA: 0x0095C75C File Offset: 0x0095A95C
		public unsafe float PlayingSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PixAnimeChange_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PixAnimeChange_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004D2D RID: 19757
		// (get) Token: 0x060258A8 RID: 153768 RVA: 0x0095C76D File Offset: 0x0095A96D
		// (set) Token: 0x060258A9 RID: 153769 RVA: 0x0095C781 File Offset: 0x0095A981
		public unsafe UMaterialInstanceDynamic NewVar_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PixAnimeChange_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PixAnimeChange_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004D2E RID: 19758
		// (get) Token: 0x060258AA RID: 153770 RVA: 0x0095C796 File Offset: 0x0095A996
		// (set) Token: 0x060258AB RID: 153771 RVA: 0x0095C7A6 File Offset: 0x0095A9A6
		public unsafe float AccumulatedTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PixAnimeChange_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PixAnimeChange_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004D2F RID: 19759
		// (get) Token: 0x060258AC RID: 153772 RVA: 0x0095C7B7 File Offset: 0x0095A9B7
		// (set) Token: 0x060258AD RID: 153773 RVA: 0x0095C7C7 File Offset: 0x0095A9C7
		public unsafe float EmissionIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PixAnimeChange_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PixAnimeChange_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x060258AE RID: 153774 RVA: 0x0095C7D8 File Offset: 0x0095A9D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PixAnimeChange_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060258AF RID: 153775 RVA: 0x0095C7EC File Offset: 0x0095A9EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PixAnimeChange_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060258B0 RID: 153776 RVA: 0x0095C804 File Offset: 0x0095AA04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_PixAnimeChange_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PixAnimeChange_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PixAnimeChange_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PixAnimeChange_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PixAnimeChange_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060258B1 RID: 153777 RVA: 0x0095C84C File Offset: 0x0095AA4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_PixAnimeChange_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PixAnimeChange_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PixAnimeChange_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PixAnimeChange_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PixAnimeChange_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060258B2 RID: 153778 RVA: 0x0095C894 File Offset: 0x0095AA94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_PixAnimeChange_C.__EditorTick_FunctionParams* ptr = stackalloc BP_PixAnimeChange_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PixAnimeChange_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PixAnimeChange_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PixAnimeChange_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060258B3 RID: 153779 RVA: 0x0095C8DC File Offset: 0x0095AADC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_PixAnimeChange_C.__EditorTick_FunctionParams* ptr = stackalloc BP_PixAnimeChange_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PixAnimeChange_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PixAnimeChange_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PixAnimeChange_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060258B4 RID: 153780 RVA: 0x0095C923 File Offset: 0x0095AB23
		protected BP_PixAnimeChange_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012BC4 RID: 76740
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/BP_PixAnimeChange.BP_PixAnimeChange_C";

		// Token: 0x04012BC5 RID: 76741
		private static IntPtr _ClassPtr;

		// Token: 0x04012BC6 RID: 76742
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012BC7 RID: 76743
		internal static int __PropertyOffset_1;

		// Token: 0x04012BC8 RID: 76744
		internal static int __PropertyOffset_2;

		// Token: 0x04012BC9 RID: 76745
		internal static int __PropertyOffset_3;

		// Token: 0x04012BCA RID: 76746
		internal static int __PropertyOffset_4;

		// Token: 0x04012BCB RID: 76747
		internal static int __PropertyOffset_5;

		// Token: 0x04012BCC RID: 76748
		internal static int __PropertyOffset_6;

		// Token: 0x04012BCD RID: 76749
		internal static int __PropertyOffset_7;

		// Token: 0x04012BCE RID: 76750
		internal static int __PropertyOffset_8;

		// Token: 0x04012BCF RID: 76751
		internal static int __PropertyOffset_9;

		// Token: 0x04012BD0 RID: 76752
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012BD1 RID: 76753
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012BD2 RID: 76754
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A00B RID: 40971
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031AA6 RID: 203430
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A00C RID: 40972
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031AA7 RID: 203431
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
