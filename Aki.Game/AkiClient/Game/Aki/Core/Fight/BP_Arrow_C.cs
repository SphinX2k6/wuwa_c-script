using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003FED RID: 16365
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/BP_Arrow.BP_Arrow_C")]
	[UnrealStructLayout(1080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1080)]
	public class BP_Arrow_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029F12 RID: 171794 RVA: 0x009D18F0 File Offset: 0x009CFAF0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Arrow_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/Fight/BP_Arrow.BP_Arrow_C");
			}
			return BP_Arrow_C._ClassPtr;
		}

		// Token: 0x06029F13 RID: 171795 RVA: 0x009D1914 File Offset: 0x009CFB14
		public BP_Arrow_C() : this(BuiltinUtils.AllocNativeUObject(BP_Arrow_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029F14 RID: 171796 RVA: 0x009D193C File Offset: 0x009CFB3C
		[NullableContext(1)]
		public BP_Arrow_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Arrow_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170065E2 RID: 26082
		// (get) Token: 0x06029F15 RID: 171797 RVA: 0x009D196F File Offset: 0x009CFB6F
		// (set) Token: 0x06029F16 RID: 171798 RVA: 0x009D1983 File Offset: 0x009CFB83
		public unsafe UArrowComponent Arrow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UArrowComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Arrow_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Arrow_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170065E3 RID: 26083
		// (get) Token: 0x06029F17 RID: 171799 RVA: 0x009D1998 File Offset: 0x009CFB98
		// (set) Token: 0x06029F18 RID: 171800 RVA: 0x009D19AC File Offset: 0x009CFBAC
		public unsafe USceneComponent Scene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Arrow_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Arrow_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170065E4 RID: 26084
		// (get) Token: 0x06029F19 RID: 171801 RVA: 0x009D19C1 File Offset: 0x009CFBC1
		// (set) Token: 0x06029F1A RID: 171802 RVA: 0x009D19D1 File Offset: 0x009CFBD1
		public unsafe float 开始时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Arrow_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Arrow_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170065E5 RID: 26085
		// (get) Token: 0x06029F1B RID: 171803 RVA: 0x009D19E2 File Offset: 0x009CFBE2
		// (set) Token: 0x06029F1C RID: 171804 RVA: 0x009D19F2 File Offset: 0x009CFBF2
		public unsafe float 持续时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Arrow_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Arrow_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x06029F1D RID: 171805 RVA: 0x009D1A03 File Offset: 0x009CFC03
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Arrow_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06029F1E RID: 171806 RVA: 0x009D1A17 File Offset: 0x009CFC17
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Arrow_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06029F1F RID: 171807 RVA: 0x009D1A2C File Offset: 0x009CFC2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Arrow_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Arrow_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Arrow_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Arrow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Arrow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06029F20 RID: 171808 RVA: 0x009D1A74 File Offset: 0x009CFC74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Arrow_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Arrow_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Arrow_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Arrow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Arrow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06029F21 RID: 171809 RVA: 0x009D1ABB File Offset: 0x009CFCBB
		protected BP_Arrow_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040158D4 RID: 88276
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Core/Fight/BP_Arrow.BP_Arrow_C";

		// Token: 0x040158D5 RID: 88277
		private static IntPtr _ClassPtr;

		// Token: 0x040158D6 RID: 88278
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040158D7 RID: 88279
		internal static int __PropertyOffset_1;

		// Token: 0x040158D8 RID: 88280
		internal static int __PropertyOffset_2;

		// Token: 0x040158D9 RID: 88281
		internal static int __PropertyOffset_3;

		// Token: 0x040158DA RID: 88282
		internal static int __PropertyOffset_4;

		// Token: 0x040158DB RID: 88283
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040158DC RID: 88284
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A31B RID: 41755
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040320CE RID: 205006
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
