using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Audio
{
	// Token: 0x02004432 RID: 17458
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Audio/BP_SpectrumBand.BP_SpectrumBand_C")]
	[UnrealStructLayout(1088, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1088)]
	public class BP_SpectrumBand_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D2EE RID: 185070 RVA: 0x00A3579B File Offset: 0x00A3399B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SpectrumBand_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Audio/BP_SpectrumBand.BP_SpectrumBand_C");
			}
			return BP_SpectrumBand_C._ClassPtr;
		}

		// Token: 0x0602D2EF RID: 185071 RVA: 0x00A357C0 File Offset: 0x00A339C0
		public BP_SpectrumBand_C() : this(BuiltinUtils.AllocNativeUObject(BP_SpectrumBand_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D2F0 RID: 185072 RVA: 0x00A357E8 File Offset: 0x00A339E8
		[NullableContext(1)]
		public BP_SpectrumBand_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SpectrumBand_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700726C RID: 29292
		// (get) Token: 0x0602D2F1 RID: 185073 RVA: 0x00A3581B File Offset: 0x00A33A1B
		// (set) Token: 0x0602D2F2 RID: 185074 RVA: 0x00A3582F File Offset: 0x00A33A2F
		public unsafe UAkComponent Ak
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpectrumBand_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpectrumBand_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700726D RID: 29293
		// (get) Token: 0x0602D2F3 RID: 185075 RVA: 0x00A35844 File Offset: 0x00A33A44
		// (set) Token: 0x0602D2F4 RID: 185076 RVA: 0x00A35858 File Offset: 0x00A33A58
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpectrumBand_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpectrumBand_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700726E RID: 29294
		// (get) Token: 0x0602D2F5 RID: 185077 RVA: 0x00A3586D File Offset: 0x00A33A6D
		// (set) Token: 0x0602D2F6 RID: 185078 RVA: 0x00A3587D File Offset: 0x00A33A7D
		public unsafe float PercussionVol
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SpectrumBand_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SpectrumBand_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700726F RID: 29295
		// (get) Token: 0x0602D2F7 RID: 185079 RVA: 0x00A3588E File Offset: 0x00A33A8E
		// (set) Token: 0x0602D2F8 RID: 185080 RVA: 0x00A3589E File Offset: 0x00A33A9E
		public unsafe float TimeOri
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SpectrumBand_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SpectrumBand_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17007270 RID: 29296
		// (get) Token: 0x0602D2F9 RID: 185081 RVA: 0x00A358AF File Offset: 0x00A33AAF
		// (set) Token: 0x0602D2FA RID: 185082 RVA: 0x00A358BF File Offset: 0x00A33ABF
		public unsafe float TimeToMaterial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SpectrumBand_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SpectrumBand_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17007271 RID: 29297
		// (get) Token: 0x0602D2FB RID: 185083 RVA: 0x00A358D0 File Offset: 0x00A33AD0
		// (set) Token: 0x0602D2FC RID: 185084 RVA: 0x00A358E0 File Offset: 0x00A33AE0
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SpectrumBand_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SpectrumBand_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x0602D2FD RID: 185085 RVA: 0x00A358F4 File Offset: 0x00A33AF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SpectrumBand_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SpectrumBand_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SpectrumBand_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SpectrumBand_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SpectrumBand_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D2FE RID: 185086 RVA: 0x00A3593C File Offset: 0x00A33B3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SpectrumBand_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SpectrumBand_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SpectrumBand_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SpectrumBand_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SpectrumBand_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602D2FF RID: 185087 RVA: 0x00A35983 File Offset: 0x00A33B83
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SpectrumBand_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602D300 RID: 185088 RVA: 0x00A35997 File Offset: 0x00A33B97
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SpectrumBand_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602D301 RID: 185089 RVA: 0x00A359AC File Offset: 0x00A33BAC
		protected BP_SpectrumBand_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04018026 RID: 98342
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Audio/BP_SpectrumBand.BP_SpectrumBand_C";

		// Token: 0x04018027 RID: 98343
		private static IntPtr _ClassPtr;

		// Token: 0x04018028 RID: 98344
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04018029 RID: 98345
		internal static int __PropertyOffset_1;

		// Token: 0x0401802A RID: 98346
		internal static int __PropertyOffset_2;

		// Token: 0x0401802B RID: 98347
		internal static int __PropertyOffset_3;

		// Token: 0x0401802C RID: 98348
		internal static int __PropertyOffset_4;

		// Token: 0x0401802D RID: 98349
		internal static int __PropertyOffset_5;

		// Token: 0x0401802E RID: 98350
		internal static int __PropertyOffset_6;

		// Token: 0x0401802F RID: 98351
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04018030 RID: 98352
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0200A6E8 RID: 42728
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040326DA RID: 206554
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
