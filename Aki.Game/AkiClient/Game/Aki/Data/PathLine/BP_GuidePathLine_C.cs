using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.PathLine
{
	// Token: 0x02003EE2 RID: 16098
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/PathLine/BP_GuidePathLine.BP_GuidePathLine_C")]
	[UnrealStructLayout(1168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1165)]
	public class BP_GuidePathLine_C : BP_BasePathLine_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028BF9 RID: 166905 RVA: 0x009B3ADD File Offset: 0x009B1CDD
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_GuidePathLine_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/PathLine/BP_GuidePathLine.BP_GuidePathLine_C");
			}
			return BP_GuidePathLine_C._ClassPtr;
		}

		// Token: 0x06028BFA RID: 166906 RVA: 0x009B3B04 File Offset: 0x009B1D04
		public BP_GuidePathLine_C() : this(BuiltinUtils.AllocNativeUObject(BP_GuidePathLine_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028BFB RID: 166907 RVA: 0x009B3B2C File Offset: 0x009B1D2C
		[NullableContext(1)]
		public BP_GuidePathLine_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_GuidePathLine_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005F72 RID: 24434
		// (get) Token: 0x06028BFC RID: 166908 RVA: 0x009B3B5F File Offset: 0x009B1D5F
		// (set) Token: 0x06028BFD RID: 166909 RVA: 0x009B3B73 File Offset: 0x009B1D73
		public unsafe UMaterialInterface Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuidePathLine_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuidePathLine_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005F73 RID: 24435
		// (get) Token: 0x06028BFE RID: 166910 RVA: 0x009B3B88 File Offset: 0x009B1D88
		// (set) Token: 0x06028BFF RID: 166911 RVA: 0x009B3B9C File Offset: 0x009B1D9C
		public unsafe UMaterialInstanceDynamic MaterialInstanceDynamic
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuidePathLine_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuidePathLine_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005F74 RID: 24436
		// (get) Token: 0x06028C00 RID: 166912 RVA: 0x009B3BB1 File Offset: 0x009B1DB1
		// (set) Token: 0x06028C01 RID: 166913 RVA: 0x009B3BC5 File Offset: 0x009B1DC5
		public unsafe FVector DebugColorVector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuidePathLine_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuidePathLine_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005F75 RID: 24437
		// (get) Token: 0x06028C02 RID: 166914 RVA: 0x009B3BDA File Offset: 0x009B1DDA
		// (set) Token: 0x06028C03 RID: 166915 RVA: 0x009B3BEA File Offset: 0x009B1DEA
		public unsafe float DebugPercentTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuidePathLine_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuidePathLine_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005F76 RID: 24438
		// (get) Token: 0x06028C04 RID: 166916 RVA: 0x009B3BFB File Offset: 0x009B1DFB
		// (set) Token: 0x06028C05 RID: 166917 RVA: 0x009B3C0B File Offset: 0x009B1E0B
		public unsafe bool Appear
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuidePathLine_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuidePathLine_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F77 RID: 24439
		// (get) Token: 0x06028C06 RID: 166918 RVA: 0x009B3C1C File Offset: 0x009B1E1C
		// (set) Token: 0x06028C07 RID: 166919 RVA: 0x009B3C2C File Offset: 0x009B1E2C
		public unsafe bool DisAppear
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuidePathLine_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuidePathLine_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F78 RID: 24440
		// (get) Token: 0x06028C08 RID: 166920 RVA: 0x009B3C3D File Offset: 0x009B1E3D
		// (set) Token: 0x06028C09 RID: 166921 RVA: 0x009B3C4D File Offset: 0x009B1E4D
		public unsafe float AppearSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuidePathLine_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuidePathLine_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005F79 RID: 24441
		// (get) Token: 0x06028C0A RID: 166922 RVA: 0x009B3C5E File Offset: 0x009B1E5E
		// (set) Token: 0x06028C0B RID: 166923 RVA: 0x009B3C72 File Offset: 0x009B1E72
		public unsafe FVector CurrentColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuidePathLine_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuidePathLine_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005F7A RID: 24442
		// (get) Token: 0x06028C0C RID: 166924 RVA: 0x009B3C87 File Offset: 0x009B1E87
		// (set) Token: 0x06028C0D RID: 166925 RVA: 0x009B3C97 File Offset: 0x009B1E97
		public unsafe bool DebugBool
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuidePathLine_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuidePathLine_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x06028C0E RID: 166926 RVA: 0x009B3CA8 File Offset: 0x009B1EA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DisAppearLine()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GuidePathLine_C.__DisAppearLine_NativeFunctionPtr, null);
		}

		// Token: 0x06028C0F RID: 166927 RVA: 0x009B3CBC File Offset: 0x009B1EBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void AppearLine()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GuidePathLine_C.__AppearLine_NativeFunctionPtr, null);
		}

		// Token: 0x06028C10 RID: 166928 RVA: 0x009B3CD0 File Offset: 0x009B1ED0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DebugColor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GuidePathLine_C.__DebugColor_NativeFunctionPtr, null);
		}

		// Token: 0x06028C11 RID: 166929 RVA: 0x009B3CE4 File Offset: 0x009B1EE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ChangeEffectColor(float PercentTime, bool SuddenChange)
		{
			BP_GuidePathLine_C.__ChangeEffectColor_FunctionParams* ptr = stackalloc BP_GuidePathLine_C.__ChangeEffectColor_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_GuidePathLine_C.__ChangeEffectColor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GuidePathLine_C.__ChangeEffectColor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PercentTime = PercentTime;
			ptr->SuddenChange = SuddenChange;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GuidePathLine_C.__ChangeEffectColor_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06028C12 RID: 166930 RVA: 0x009B3D31 File Offset: 0x009B1F31
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ShowEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GuidePathLine_C.__ShowEffect_NativeFunctionPtr, null);
		}

		// Token: 0x06028C13 RID: 166931 RVA: 0x009B3D45 File Offset: 0x009B1F45
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void HideEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GuidePathLine_C.__HideEffect_NativeFunctionPtr, null);
		}

		// Token: 0x06028C14 RID: 166932 RVA: 0x009B3D59 File Offset: 0x009B1F59
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GuidePathLine_C.__InitEffect_NativeFunctionPtr, null);
		}

		// Token: 0x06028C15 RID: 166933 RVA: 0x009B3D6D File Offset: 0x009B1F6D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GuidePathLine_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06028C16 RID: 166934 RVA: 0x009B3D81 File Offset: 0x009B1F81
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GuidePathLine_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06028C17 RID: 166935 RVA: 0x009B3D96 File Offset: 0x009B1F96
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GuidePathLine_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06028C18 RID: 166936 RVA: 0x009B3DAA File Offset: 0x009B1FAA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GuidePathLine_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06028C19 RID: 166937 RVA: 0x009B3DC0 File Offset: 0x009B1FC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_GuidePathLine_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_GuidePathLine_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GuidePathLine_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GuidePathLine_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GuidePathLine_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06028C1A RID: 166938 RVA: 0x009B3E08 File Offset: 0x009B2008
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_GuidePathLine_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_GuidePathLine_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GuidePathLine_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GuidePathLine_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GuidePathLine_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06028C1B RID: 166939 RVA: 0x009B3E4F File Offset: 0x009B204F
		protected BP_GuidePathLine_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014D3A RID: 85306
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/PathLine/BP_GuidePathLine.BP_GuidePathLine_C";

		// Token: 0x04014D3B RID: 85307
		private static IntPtr _ClassPtr;

		// Token: 0x04014D3C RID: 85308
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014D3D RID: 85309
		internal new static int __PropertyOffset_1;

		// Token: 0x04014D3E RID: 85310
		internal new static int __PropertyOffset_2;

		// Token: 0x04014D3F RID: 85311
		internal new static int __PropertyOffset_3;

		// Token: 0x04014D40 RID: 85312
		internal new static int __PropertyOffset_4;

		// Token: 0x04014D41 RID: 85313
		internal static int __PropertyOffset_5;

		// Token: 0x04014D42 RID: 85314
		internal static int __PropertyOffset_6;

		// Token: 0x04014D43 RID: 85315
		internal static int __PropertyOffset_7;

		// Token: 0x04014D44 RID: 85316
		internal static int __PropertyOffset_8;

		// Token: 0x04014D45 RID: 85317
		internal static int __PropertyOffset_9;

		// Token: 0x04014D46 RID: 85318
		private static IntPtr __DisAppearLine_NativeFunctionPtr;

		// Token: 0x04014D47 RID: 85319
		private static IntPtr __AppearLine_NativeFunctionPtr;

		// Token: 0x04014D48 RID: 85320
		private static IntPtr __DebugColor_NativeFunctionPtr;

		// Token: 0x04014D49 RID: 85321
		private static IntPtr __ChangeEffectColor_NativeFunctionPtr;

		// Token: 0x04014D4A RID: 85322
		private static IntPtr __ShowEffect_NativeFunctionPtr;

		// Token: 0x04014D4B RID: 85323
		private static IntPtr __HideEffect_NativeFunctionPtr;

		// Token: 0x04014D4C RID: 85324
		private static IntPtr __InitEffect_NativeFunctionPtr;

		// Token: 0x04014D4D RID: 85325
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04014D4E RID: 85326
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04014D4F RID: 85327
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A2D8 RID: 41688
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __ChangeEffectColor_FunctionParams
		{
			// Token: 0x0403201B RID: 204827
			[FieldOffset(0)]
			public float PercentTime;

			// Token: 0x0403201C RID: 204828
			[FieldOffset(4)]
			public bool SuddenChange;
		}

		// Token: 0x0200A2D9 RID: 41689
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403201D RID: 204829
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
