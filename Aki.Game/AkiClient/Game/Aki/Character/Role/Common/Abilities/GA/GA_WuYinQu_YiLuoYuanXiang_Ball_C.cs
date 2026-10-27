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
	// Token: 0x02004187 RID: 16775
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_WuYinQu_YiLuoYuanXiang_Ball.GA_WuYinQu_YiLuoYuanXiang_Ball_C")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1536)]
	public class GA_WuYinQu_YiLuoYuanXiang_Ball_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B709 RID: 177929 RVA: 0x00A00BB7 File Offset: 0x009FEDB7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_WuYinQu_YiLuoYuanXiang_Ball_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_WuYinQu_YiLuoYuanXiang_Ball.GA_WuYinQu_YiLuoYuanXiang_Ball_C");
			}
			return GA_WuYinQu_YiLuoYuanXiang_Ball_C._ClassPtr;
		}

		// Token: 0x0602B70A RID: 177930 RVA: 0x00A00BDC File Offset: 0x009FEDDC
		public GA_WuYinQu_YiLuoYuanXiang_Ball_C() : this(BuiltinUtils.AllocNativeUObject(GA_WuYinQu_YiLuoYuanXiang_Ball_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B70B RID: 177931 RVA: 0x00A00C04 File Offset: 0x009FEE04
		public GA_WuYinQu_YiLuoYuanXiang_Ball_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_WuYinQu_YiLuoYuanXiang_Ball_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006B25 RID: 27429
		// (get) Token: 0x0602B70C RID: 177932 RVA: 0x00A00C37 File Offset: 0x009FEE37
		// (set) Token: 0x0602B70D RID: 177933 RVA: 0x00A00C47 File Offset: 0x009FEE47
		public unsafe float 随机上下
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_WuYinQu_YiLuoYuanXiang_Ball_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_WuYinQu_YiLuoYuanXiang_Ball_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006B26 RID: 27430
		// (get) Token: 0x0602B70E RID: 177934 RVA: 0x00A00C58 File Offset: 0x009FEE58
		// (set) Token: 0x0602B70F RID: 177935 RVA: 0x00A00C68 File Offset: 0x009FEE68
		public unsafe float 随机左右
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_WuYinQu_YiLuoYuanXiang_Ball_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_WuYinQu_YiLuoYuanXiang_Ball_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006B27 RID: 27431
		// (get) Token: 0x0602B710 RID: 177936 RVA: 0x00A00C79 File Offset: 0x009FEE79
		// (set) Token: 0x0602B711 RID: 177937 RVA: 0x00A00C8D File Offset: 0x009FEE8D
		public unsafe string 子弹_ID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)GA_WuYinQu_YiLuoYuanXiang_Ball_C.__PropertyOffset_3)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)GA_WuYinQu_YiLuoYuanXiang_Ball_C.__PropertyOffset_3)), value);
			}
		}

		// Token: 0x0602B712 RID: 177938 RVA: 0x00A00CA4 File Offset: 0x009FEEA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_WuYinQu_YiLuoYuanXiang_Ball_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_WuYinQu_YiLuoYuanXiang_Ball_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_WuYinQu_YiLuoYuanXiang_Ball_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_WuYinQu_YiLuoYuanXiang_Ball_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_WuYinQu_YiLuoYuanXiang_Ball_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B713 RID: 177939 RVA: 0x00A00CEC File Offset: 0x009FEEEC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_WuYinQu_YiLuoYuanXiang_Ball_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_WuYinQu_YiLuoYuanXiang_Ball_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_WuYinQu_YiLuoYuanXiang_Ball_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_WuYinQu_YiLuoYuanXiang_Ball_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_WuYinQu_YiLuoYuanXiang_Ball_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B714 RID: 177940 RVA: 0x00A00D33 File Offset: 0x009FEF33
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_WuYinQu_YiLuoYuanXiang_Ball_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B715 RID: 177941 RVA: 0x00A00D47 File Offset: 0x009FEF47
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_WuYinQu_YiLuoYuanXiang_Ball_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B716 RID: 177942 RVA: 0x00A00D5C File Offset: 0x009FEF5C
		protected GA_WuYinQu_YiLuoYuanXiang_Ball_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040169BF RID: 92607
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_WuYinQu_YiLuoYuanXiang_Ball.GA_WuYinQu_YiLuoYuanXiang_Ball_C";

		// Token: 0x040169C0 RID: 92608
		private static IntPtr _ClassPtr;

		// Token: 0x040169C1 RID: 92609
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040169C2 RID: 92610
		internal new static int __PropertyOffset_1;

		// Token: 0x040169C3 RID: 92611
		internal new static int __PropertyOffset_2;

		// Token: 0x040169C4 RID: 92612
		internal new static int __PropertyOffset_3;

		// Token: 0x040169C5 RID: 92613
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x040169C6 RID: 92614
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0200A525 RID: 42277
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032393 RID: 205715
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
