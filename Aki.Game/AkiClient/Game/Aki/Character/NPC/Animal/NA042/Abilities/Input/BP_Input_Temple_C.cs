using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.Input.Blueprints;
using AkiClient.Game.Aki.Character.Input.Structures;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA042.Abilities.Input
{
	// Token: 0x020041FE RID: 16894
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA042/Abilities/Input/BP_Input_Temple.BP_Input_Temple_C")]
	[UnrealStructLayout(600, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 596)]
	public class BP_Input_Temple_C : BP_InputComponent_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BDC7 RID: 179655 RVA: 0x00A0CCE8 File Offset: 0x00A0AEE8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Input_Temple_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA042/Abilities/Input/BP_Input_Temple.BP_Input_Temple_C");
			}
			return BP_Input_Temple_C._ClassPtr;
		}

		// Token: 0x0602BDC8 RID: 179656 RVA: 0x00A0CD0C File Offset: 0x00A0AF0C
		public BP_Input_Temple_C() : this(BuiltinUtils.AllocNativeUObject(BP_Input_Temple_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BDC9 RID: 179657 RVA: 0x00A0CD34 File Offset: 0x00A0AF34
		[NullableContext(1)]
		public BP_Input_Temple_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Input_Temple_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CF1 RID: 27889
		// (get) Token: 0x0602BDCA RID: 179658 RVA: 0x00A0CD67 File Offset: 0x00A0AF67
		// (set) Token: 0x0602BDCB RID: 179659 RVA: 0x00A0CD77 File Offset: 0x00A0AF77
		public unsafe float 散华蓄力值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Input_Temple_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Input_Temple_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x0602BDCC RID: 179660 RVA: 0x00A0CD88 File Offset: 0x00A0AF88
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 瞄准按下(float time)
		{
			BP_Input_Temple_C.__瞄准按下_FunctionParams* ptr = stackalloc BP_Input_Temple_C.__瞄准按下_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_Input_Temple_C.__瞄准按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Input_Temple_C.__瞄准按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Input_Temple_C.__瞄准按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602BDCD RID: 179661 RVA: 0x00A0CDDC File Offset: 0x00A0AFDC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 技能1抬起(float time)
		{
			BP_Input_Temple_C.__技能1抬起_FunctionParams* ptr = stackalloc BP_Input_Temple_C.__技能1抬起_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_Input_Temple_C.__技能1抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Input_Temple_C.__技能1抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Input_Temple_C.__技能1抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602BDCE RID: 179662 RVA: 0x00A0CE30 File Offset: 0x00A0B030
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 技能1长按(float time)
		{
			BP_Input_Temple_C.__技能1长按_FunctionParams* ptr = stackalloc BP_Input_Temple_C.__技能1长按_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_Input_Temple_C.__技能1长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Input_Temple_C.__技能1长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Input_Temple_C.__技能1长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602BDCF RID: 179663 RVA: 0x00A0CE84 File Offset: 0x00A0B084
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 技能1按下(float time)
		{
			BP_Input_Temple_C.__技能1按下_FunctionParams* ptr = stackalloc BP_Input_Temple_C.__技能1按下_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_Input_Temple_C.__技能1按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Input_Temple_C.__技能1按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Input_Temple_C.__技能1按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602BDD0 RID: 179664 RVA: 0x00A0CED8 File Offset: 0x00A0B0D8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 攻击抬起(float time)
		{
			BP_Input_Temple_C.__攻击抬起_FunctionParams* ptr = stackalloc BP_Input_Temple_C.__攻击抬起_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_Input_Temple_C.__攻击抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Input_Temple_C.__攻击抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Input_Temple_C.__攻击抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602BDD1 RID: 179665 RVA: 0x00A0CF2C File Offset: 0x00A0B12C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 攻击长按(float time)
		{
			BP_Input_Temple_C.__攻击长按_FunctionParams* ptr = stackalloc BP_Input_Temple_C.__攻击长按_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_Input_Temple_C.__攻击长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Input_Temple_C.__攻击长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Input_Temple_C.__攻击长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602BDD2 RID: 179666 RVA: 0x00A0CF80 File Offset: 0x00A0B180
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 攻击按下(float time)
		{
			BP_Input_Temple_C.__攻击按下_FunctionParams* ptr = stackalloc BP_Input_Temple_C.__攻击按下_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_Input_Temple_C.__攻击按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Input_Temple_C.__攻击按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Input_Temple_C.__攻击按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602BDD3 RID: 179667 RVA: 0x00A0CFD4 File Offset: 0x00A0B1D4
		protected BP_Input_Temple_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E21 RID: 93729
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA042/Abilities/Input/BP_Input_Temple.BP_Input_Temple_C";

		// Token: 0x04016E22 RID: 93730
		private static IntPtr _ClassPtr;

		// Token: 0x04016E23 RID: 93731
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016E24 RID: 93732
		internal new static int __PropertyOffset_0;

		// Token: 0x04016E25 RID: 93733
		private static IntPtr __瞄准按下_NativeFunctionPtr;

		// Token: 0x04016E26 RID: 93734
		private static IntPtr __技能1抬起_NativeFunctionPtr;

		// Token: 0x04016E27 RID: 93735
		private static IntPtr __技能1长按_NativeFunctionPtr;

		// Token: 0x04016E28 RID: 93736
		private static IntPtr __技能1按下_NativeFunctionPtr;

		// Token: 0x04016E29 RID: 93737
		private static IntPtr __攻击抬起_NativeFunctionPtr;

		// Token: 0x04016E2A RID: 93738
		private static IntPtr __攻击长按_NativeFunctionPtr;

		// Token: 0x04016E2B RID: 93739
		private static IntPtr __攻击按下_NativeFunctionPtr;

		// Token: 0x0200A595 RID: 42389
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected new ref struct __瞄准按下_FunctionParams
		{
			// Token: 0x04032421 RID: 205857
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032422 RID: 205858
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A596 RID: 42390
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected new ref struct __技能1抬起_FunctionParams
		{
			// Token: 0x04032423 RID: 205859
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032424 RID: 205860
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A597 RID: 42391
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected new ref struct __技能1长按_FunctionParams
		{
			// Token: 0x04032425 RID: 205861
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032426 RID: 205862
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A598 RID: 42392
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected new ref struct __技能1按下_FunctionParams
		{
			// Token: 0x04032427 RID: 205863
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032428 RID: 205864
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A599 RID: 42393
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected new ref struct __攻击抬起_FunctionParams
		{
			// Token: 0x04032429 RID: 205865
			[FieldOffset(0)]
			public float time;

			// Token: 0x0403242A RID: 205866
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A59A RID: 42394
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected new ref struct __攻击长按_FunctionParams
		{
			// Token: 0x0403242B RID: 205867
			[FieldOffset(0)]
			public float time;

			// Token: 0x0403242C RID: 205868
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A59B RID: 42395
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected new ref struct __攻击按下_FunctionParams
		{
			// Token: 0x0403242D RID: 205869
			[FieldOffset(0)]
			public float time;

			// Token: 0x0403242E RID: 205870
			[FieldOffset(4)]
			public byte __Result;
		}
	}
}
