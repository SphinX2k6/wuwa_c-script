using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonPet;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA015
{
	// Token: 0x0200422A RID: 16938
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA015/BP_NA015_Swimming.BP_NA015_Swimming_C")]
	[UnrealStructLayout(2304, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2296)]
	public class BP_NA015_Swimming_C : BP_CommonPet_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE96 RID: 179862 RVA: 0x00A0E8C4 File Offset: 0x00A0CAC4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA015_Swimming_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA015/BP_NA015_Swimming.BP_NA015_Swimming_C");
			}
			return BP_NA015_Swimming_C._ClassPtr;
		}

		// Token: 0x0602BE97 RID: 179863 RVA: 0x00A0E8E8 File Offset: 0x00A0CAE8
		public BP_NA015_Swimming_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA015_Swimming_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE98 RID: 179864 RVA: 0x00A0E910 File Offset: 0x00A0CB10
		[NullableContext(1)]
		public BP_NA015_Swimming_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA015_Swimming_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CFC RID: 27900
		// (get) Token: 0x0602BE99 RID: 179865 RVA: 0x00A0E943 File Offset: 0x00A0CB43
		// (set) Token: 0x0602BE9A RID: 179866 RVA: 0x00A0E957 File Offset: 0x00A0CB57
		public unsafe FVectorDouble CurrentVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NA015_Swimming_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NA015_Swimming_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x0602BE9B RID: 179867 RVA: 0x00A0E96C File Offset: 0x00A0CB6C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_NA015_Swimming_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_NA015_Swimming_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_NA015_Swimming_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NA015_Swimming_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NA015_Swimming_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BE9C RID: 179868 RVA: 0x00A0E9B4 File Offset: 0x00A0CBB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_NA015_Swimming_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_NA015_Swimming_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_NA015_Swimming_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NA015_Swimming_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NA015_Swimming_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602BE9D RID: 179869 RVA: 0x00A0E9FB File Offset: 0x00A0CBFB
		protected BP_NA015_Swimming_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016EBA RID: 93882
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA015/BP_NA015_Swimming.BP_NA015_Swimming_C";

		// Token: 0x04016EBB RID: 93883
		private static IntPtr _ClassPtr;

		// Token: 0x04016EBC RID: 93884
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016EBD RID: 93885
		internal static int __PropertyOffset_1;

		// Token: 0x04016EBE RID: 93886
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A59C RID: 42396
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403242F RID: 205871
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
