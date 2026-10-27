using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonPet;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA012
{
	// Token: 0x02004231 RID: 16945
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA012/BP_NA012_Swimming.BP_NA012_Swimming_C")]
	[UnrealStructLayout(2304, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2296)]
	public class BP_NA012_Swimming_C : BP_CommonPet_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BEB6 RID: 179894 RVA: 0x00A0ED34 File Offset: 0x00A0CF34
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA012_Swimming_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA012/BP_NA012_Swimming.BP_NA012_Swimming_C");
			}
			return BP_NA012_Swimming_C._ClassPtr;
		}

		// Token: 0x0602BEB7 RID: 179895 RVA: 0x00A0ED58 File Offset: 0x00A0CF58
		public BP_NA012_Swimming_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA012_Swimming_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BEB8 RID: 179896 RVA: 0x00A0ED80 File Offset: 0x00A0CF80
		[NullableContext(1)]
		public BP_NA012_Swimming_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA012_Swimming_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CFD RID: 27901
		// (get) Token: 0x0602BEB9 RID: 179897 RVA: 0x00A0EDB3 File Offset: 0x00A0CFB3
		// (set) Token: 0x0602BEBA RID: 179898 RVA: 0x00A0EDC7 File Offset: 0x00A0CFC7
		public unsafe FVectorDouble CurrentVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NA012_Swimming_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NA012_Swimming_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x0602BEBB RID: 179899 RVA: 0x00A0EDDC File Offset: 0x00A0CFDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_NA012_Swimming_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_NA012_Swimming_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_NA012_Swimming_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NA012_Swimming_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NA012_Swimming_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BEBC RID: 179900 RVA: 0x00A0EE24 File Offset: 0x00A0D024
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_NA012_Swimming_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_NA012_Swimming_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_NA012_Swimming_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NA012_Swimming_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NA012_Swimming_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602BEBD RID: 179901 RVA: 0x00A0EE6B File Offset: 0x00A0D06B
		protected BP_NA012_Swimming_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016ED1 RID: 93905
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA012/BP_NA012_Swimming.BP_NA012_Swimming_C";

		// Token: 0x04016ED2 RID: 93906
		private static IntPtr _ClassPtr;

		// Token: 0x04016ED3 RID: 93907
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016ED4 RID: 93908
		internal static int __PropertyOffset_1;

		// Token: 0x04016ED5 RID: 93909
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A59D RID: 42397
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04032430 RID: 205872
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
