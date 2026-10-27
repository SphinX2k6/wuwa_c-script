using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.BlueprintLevel
{
	// Token: 0x02003BA3 RID: 15267
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/BlueprintLevel/BP_KuroISMGroup.BP_KuroISMGroup_C")]
	[UnrealStructLayout(1112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1112)]
	public class BP_KuroISMGroup_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021FD1 RID: 139217 RVA: 0x008FB963 File Offset: 0x008F9B63
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroISMGroup_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/BlueprintLevel/BP_KuroISMGroup.BP_KuroISMGroup_C");
			}
			return BP_KuroISMGroup_C._ClassPtr;
		}

		// Token: 0x06021FD2 RID: 139218 RVA: 0x008FB988 File Offset: 0x008F9B88
		public BP_KuroISMGroup_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroISMGroup_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021FD3 RID: 139219 RVA: 0x008FB9B0 File Offset: 0x008F9BB0
		[NullableContext(1)]
		public BP_KuroISMGroup_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroISMGroup_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003941 RID: 14657
		// (get) Token: 0x06021FD4 RID: 139220 RVA: 0x008FB9E3 File Offset: 0x008F9BE3
		// (set) Token: 0x06021FD5 RID: 139221 RVA: 0x008FB9F7 File Offset: 0x008F9BF7
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroISMGroup_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroISMGroup_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003942 RID: 14658
		// (get) Token: 0x06021FD6 RID: 139222 RVA: 0x008FBA0C File Offset: 0x008F9C0C
		// (set) Token: 0x06021FD7 RID: 139223 RVA: 0x008FBA1C File Offset: 0x008F9C1C
		public unsafe bool HideLogicallyOnBeginPlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003943 RID: 14659
		// (get) Token: 0x06021FD8 RID: 139224 RVA: 0x008FBA2D File Offset: 0x008F9C2D
		// (set) Token: 0x06021FD9 RID: 139225 RVA: 0x008FBA3D File Offset: 0x008F9C3D
		public unsafe float DitherProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17003944 RID: 14660
		// (get) Token: 0x06021FDA RID: 139226 RVA: 0x008FBA4E File Offset: 0x008F9C4E
		// (set) Token: 0x06021FDB RID: 139227 RVA: 0x008FBA5E File Offset: 0x008F9C5E
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003945 RID: 14661
		// (get) Token: 0x06021FDC RID: 139228 RVA: 0x008FBA6F File Offset: 0x008F9C6F
		// (set) Token: 0x06021FDD RID: 139229 RVA: 0x008FBA7F File Offset: 0x008F9C7F
		public unsafe bool IsTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003946 RID: 14662
		// (get) Token: 0x06021FDE RID: 139230 RVA: 0x008FBA90 File Offset: 0x008F9C90
		// (set) Token: 0x06021FDF RID: 139231 RVA: 0x008FBAA0 File Offset: 0x008F9CA0
		public unsafe float DeltaSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003947 RID: 14663
		// (get) Token: 0x06021FE0 RID: 139232 RVA: 0x008FBAB1 File Offset: 0x008F9CB1
		// (set) Token: 0x06021FE1 RID: 139233 RVA: 0x008FBAC1 File Offset: 0x008F9CC1
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003948 RID: 14664
		// (get) Token: 0x06021FE2 RID: 139234 RVA: 0x008FBAD2 File Offset: 0x008F9CD2
		// (set) Token: 0x06021FE3 RID: 139235 RVA: 0x008FBAE2 File Offset: 0x008F9CE2
		public unsafe bool IsShow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003949 RID: 14665
		// (get) Token: 0x06021FE4 RID: 139236 RVA: 0x008FBAF3 File Offset: 0x008F9CF3
		// (set) Token: 0x06021FE5 RID: 139237 RVA: 0x008FBB07 File Offset: 0x008F9D07
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700394A RID: 14666
		// (get) Token: 0x06021FE6 RID: 139238 RVA: 0x008FBB1C File Offset: 0x008F9D1C
		// (set) Token: 0x06021FE7 RID: 139239 RVA: 0x008FBB2C File Offset: 0x008F9D2C
		public unsafe float FloatPar_Start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700394B RID: 14667
		// (get) Token: 0x06021FE8 RID: 139240 RVA: 0x008FBB3D File Offset: 0x008F9D3D
		// (set) Token: 0x06021FE9 RID: 139241 RVA: 0x008FBB4D File Offset: 0x008F9D4D
		public unsafe float FloatPar_End
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroISMGroup_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x06021FEA RID: 139242 RVA: 0x008FBB60 File Offset: 0x008F9D60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Timer(ref float ElapsedTime)
		{
			BP_KuroISMGroup_C.__Timer_FunctionParams* ptr = stackalloc BP_KuroISMGroup_C.__Timer_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_KuroISMGroup_C.__Timer_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroISMGroup_C.__Timer_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ElapsedTime = ElapsedTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroISMGroup_C.__Timer_NativeFunctionPtr, (void*)ptr);
			ElapsedTime = ptr->ElapsedTime;
		}

		// Token: 0x06021FEB RID: 139243 RVA: 0x008FBBB0 File Offset: 0x008F9DB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void MaterialParameterGradient(float DeltalTime)
		{
			BP_KuroISMGroup_C.__MaterialParameterGradient_FunctionParams* ptr = stackalloc BP_KuroISMGroup_C.__MaterialParameterGradient_FunctionParams[(UIntPtr)295] + 15L / (long)sizeof(BP_KuroISMGroup_C.__MaterialParameterGradient_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroISMGroup_C.__MaterialParameterGradient_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltalTime = DeltalTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroISMGroup_C.__MaterialParameterGradient_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021FEC RID: 139244 RVA: 0x008FBBF9 File Offset: 0x008F9DF9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SeyLogicallyShowForAllChildren()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroISMGroup_C.__SeyLogicallyShowForAllChildren_NativeFunctionPtr, null);
		}

		// Token: 0x06021FED RID: 139245 RVA: 0x008FBC0D File Offset: 0x008F9E0D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SeyLogicallyHiddenForAllChildren()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroISMGroup_C.__SeyLogicallyHiddenForAllChildren_NativeFunctionPtr, null);
		}

		// Token: 0x06021FEE RID: 139246 RVA: 0x008FBC21 File Offset: 0x008F9E21
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorValidCheck()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroISMGroup_C.__EditorValidCheck_NativeFunctionPtr, null);
		}

		// Token: 0x06021FEF RID: 139247 RVA: 0x008FBC38 File Offset: 0x008F9E38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void IsEditor(ref bool IsEditor)
		{
			BP_KuroISMGroup_C.__IsEditor_FunctionParams* ptr = stackalloc BP_KuroISMGroup_C.__IsEditor_FunctionParams[(UIntPtr)20] + 15L / (long)sizeof(BP_KuroISMGroup_C.__IsEditor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroISMGroup_C.__IsEditor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsEditor = IsEditor;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroISMGroup_C.__IsEditor_NativeFunctionPtr, (void*)ptr);
			IsEditor = ptr->IsEditor;
		}

		// Token: 0x06021FF0 RID: 139248 RVA: 0x008FBC87 File Offset: 0x008F9E87
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroISMGroup_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06021FF1 RID: 139249 RVA: 0x008FBC9B File Offset: 0x008F9E9B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroISMGroup_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021FF2 RID: 139250 RVA: 0x008FBCB0 File Offset: 0x008F9EB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroISMGroup_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021FF3 RID: 139251 RVA: 0x008FBCC4 File Offset: 0x008F9EC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroISMGroup_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021FF4 RID: 139252 RVA: 0x008FBCDC File Offset: 0x008F9EDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroISMGroup_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroISMGroup_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroISMGroup_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroISMGroup_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroISMGroup_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021FF5 RID: 139253 RVA: 0x008FBD24 File Offset: 0x008F9F24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroISMGroup_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroISMGroup_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroISMGroup_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroISMGroup_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroISMGroup_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021FF6 RID: 139254 RVA: 0x008FBD6B File Offset: 0x008F9F6B
		protected BP_KuroISMGroup_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010A02 RID: 68098
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/BlueprintLevel/BP_KuroISMGroup.BP_KuroISMGroup_C";

		// Token: 0x04010A03 RID: 68099
		private static IntPtr _ClassPtr;

		// Token: 0x04010A04 RID: 68100
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010A05 RID: 68101
		internal static int __PropertyOffset_1;

		// Token: 0x04010A06 RID: 68102
		internal static int __PropertyOffset_2;

		// Token: 0x04010A07 RID: 68103
		internal static int __PropertyOffset_3;

		// Token: 0x04010A08 RID: 68104
		internal static int __PropertyOffset_4;

		// Token: 0x04010A09 RID: 68105
		internal static int __PropertyOffset_5;

		// Token: 0x04010A0A RID: 68106
		internal static int __PropertyOffset_6;

		// Token: 0x04010A0B RID: 68107
		internal static int __PropertyOffset_7;

		// Token: 0x04010A0C RID: 68108
		internal static int __PropertyOffset_8;

		// Token: 0x04010A0D RID: 68109
		internal static int __PropertyOffset_9;

		// Token: 0x04010A0E RID: 68110
		internal static int __PropertyOffset_10;

		// Token: 0x04010A0F RID: 68111
		internal static int __PropertyOffset_11;

		// Token: 0x04010A10 RID: 68112
		private static IntPtr __Timer_NativeFunctionPtr;

		// Token: 0x04010A11 RID: 68113
		private static IntPtr __MaterialParameterGradient_NativeFunctionPtr;

		// Token: 0x04010A12 RID: 68114
		private static IntPtr __SeyLogicallyShowForAllChildren_NativeFunctionPtr;

		// Token: 0x04010A13 RID: 68115
		private static IntPtr __SeyLogicallyHiddenForAllChildren_NativeFunctionPtr;

		// Token: 0x04010A14 RID: 68116
		private static IntPtr __EditorValidCheck_NativeFunctionPtr;

		// Token: 0x04010A15 RID: 68117
		private static IntPtr __IsEditor_NativeFunctionPtr;

		// Token: 0x04010A16 RID: 68118
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010A17 RID: 68119
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010A18 RID: 68120
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009D00 RID: 40192
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __Timer_FunctionParams
		{
			// Token: 0x04031413 RID: 201747
			[FieldOffset(0)]
			public float ElapsedTime;
		}

		// Token: 0x02009D01 RID: 40193
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 280)]
		protected ref struct __MaterialParameterGradient_FunctionParams
		{
			// Token: 0x04031414 RID: 201748
			[FieldOffset(0)]
			public float DeltalTime;
		}

		// Token: 0x02009D02 RID: 40194
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 5)]
		protected ref struct __IsEditor_FunctionParams
		{
			// Token: 0x04031415 RID: 201749
			[FieldOffset(0)]
			public bool IsEditor;
		}

		// Token: 0x02009D03 RID: 40195
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031416 RID: 201750
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
