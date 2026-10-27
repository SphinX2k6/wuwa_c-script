using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x02004185 RID: 16773
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_WuYinQu_HuKouSanMai_Ball.GA_WuYinQu_HuKouSanMai_Ball_C")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1536)]
	public class GA_WuYinQu_HuKouSanMai_Ball_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B6F1 RID: 177905 RVA: 0x00A00911 File Offset: 0x009FEB11
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_WuYinQu_HuKouSanMai_Ball_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_WuYinQu_HuKouSanMai_Ball.GA_WuYinQu_HuKouSanMai_Ball_C");
			}
			return GA_WuYinQu_HuKouSanMai_Ball_C._ClassPtr;
		}

		// Token: 0x0602B6F2 RID: 177906 RVA: 0x00A00938 File Offset: 0x009FEB38
		public GA_WuYinQu_HuKouSanMai_Ball_C() : this(BuiltinUtils.AllocNativeUObject(GA_WuYinQu_HuKouSanMai_Ball_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B6F3 RID: 177907 RVA: 0x00A00960 File Offset: 0x009FEB60
		public GA_WuYinQu_HuKouSanMai_Ball_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_WuYinQu_HuKouSanMai_Ball_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006B20 RID: 27424
		// (get) Token: 0x0602B6F4 RID: 177908 RVA: 0x00A00993 File Offset: 0x009FEB93
		// (set) Token: 0x0602B6F5 RID: 177909 RVA: 0x00A009A3 File Offset: 0x009FEBA3
		public unsafe float 随机上下
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_WuYinQu_HuKouSanMai_Ball_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_WuYinQu_HuKouSanMai_Ball_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006B21 RID: 27425
		// (get) Token: 0x0602B6F6 RID: 177910 RVA: 0x00A009B4 File Offset: 0x009FEBB4
		// (set) Token: 0x0602B6F7 RID: 177911 RVA: 0x00A009C4 File Offset: 0x009FEBC4
		public unsafe float 随机左右
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_WuYinQu_HuKouSanMai_Ball_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_WuYinQu_HuKouSanMai_Ball_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006B22 RID: 27426
		// (get) Token: 0x0602B6F8 RID: 177912 RVA: 0x00A009D5 File Offset: 0x009FEBD5
		// (set) Token: 0x0602B6F9 RID: 177913 RVA: 0x00A009E9 File Offset: 0x009FEBE9
		public unsafe string 子弹_ID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)GA_WuYinQu_HuKouSanMai_Ball_C.__PropertyOffset_3)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)GA_WuYinQu_HuKouSanMai_Ball_C.__PropertyOffset_3)), value);
			}
		}

		// Token: 0x0602B6FA RID: 177914 RVA: 0x00A00A00 File Offset: 0x009FEC00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_WuYinQu_HuKouSanMai_Ball_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_WuYinQu_HuKouSanMai_Ball_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_WuYinQu_HuKouSanMai_Ball_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_WuYinQu_HuKouSanMai_Ball_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_WuYinQu_HuKouSanMai_Ball_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B6FB RID: 177915 RVA: 0x00A00A48 File Offset: 0x009FEC48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_WuYinQu_HuKouSanMai_Ball_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_WuYinQu_HuKouSanMai_Ball_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_WuYinQu_HuKouSanMai_Ball_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_WuYinQu_HuKouSanMai_Ball_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_WuYinQu_HuKouSanMai_Ball_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B6FC RID: 177916 RVA: 0x00A00A8F File Offset: 0x009FEC8F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_WuYinQu_HuKouSanMai_Ball_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B6FD RID: 177917 RVA: 0x00A00AA3 File Offset: 0x009FECA3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_WuYinQu_HuKouSanMai_Ball_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B6FE RID: 177918 RVA: 0x00A00AB8 File Offset: 0x009FECB8
		protected GA_WuYinQu_HuKouSanMai_Ball_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040169B1 RID: 92593
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_WuYinQu_HuKouSanMai_Ball.GA_WuYinQu_HuKouSanMai_Ball_C";

		// Token: 0x040169B2 RID: 92594
		private static IntPtr _ClassPtr;

		// Token: 0x040169B3 RID: 92595
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040169B4 RID: 92596
		internal new static int __PropertyOffset_1;

		// Token: 0x040169B5 RID: 92597
		internal new static int __PropertyOffset_2;

		// Token: 0x040169B6 RID: 92598
		internal new static int __PropertyOffset_3;

		// Token: 0x040169B7 RID: 92599
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x040169B8 RID: 92600
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0200A524 RID: 42276
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032392 RID: 205714
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
