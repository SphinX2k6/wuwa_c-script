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
	// Token: 0x02004188 RID: 16776
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_WuYinQu_YuanNiaoZe.GA_WuYinQu_YuanNiaoZe_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_WuYinQu_YuanNiaoZe_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B717 RID: 177943 RVA: 0x00A00D65 File Offset: 0x009FEF65
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_WuYinQu_YuanNiaoZe_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_WuYinQu_YuanNiaoZe.GA_WuYinQu_YuanNiaoZe_C");
			}
			return GA_WuYinQu_YuanNiaoZe_C._ClassPtr;
		}

		// Token: 0x0602B718 RID: 177944 RVA: 0x00A00D8C File Offset: 0x009FEF8C
		public GA_WuYinQu_YuanNiaoZe_C() : this(BuiltinUtils.AllocNativeUObject(GA_WuYinQu_YuanNiaoZe_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B719 RID: 177945 RVA: 0x00A00DB4 File Offset: 0x009FEFB4
		[NullableContext(1)]
		public GA_WuYinQu_YuanNiaoZe_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_WuYinQu_YuanNiaoZe_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006B28 RID: 27432
		// (get) Token: 0x0602B71A RID: 177946 RVA: 0x00A00DE7 File Offset: 0x009FEFE7
		// (set) Token: 0x0602B71B RID: 177947 RVA: 0x00A00DF7 File Offset: 0x009FEFF7
		public unsafe float 随机上下
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_WuYinQu_YuanNiaoZe_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_WuYinQu_YuanNiaoZe_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006B29 RID: 27433
		// (get) Token: 0x0602B71C RID: 177948 RVA: 0x00A00E08 File Offset: 0x009FF008
		// (set) Token: 0x0602B71D RID: 177949 RVA: 0x00A00E18 File Offset: 0x009FF018
		public unsafe float 随机左右
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_WuYinQu_YuanNiaoZe_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_WuYinQu_YuanNiaoZe_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x0602B71E RID: 177950 RVA: 0x00A00E2C File Offset: 0x009FF02C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_WuYinQu_YuanNiaoZe_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_WuYinQu_YuanNiaoZe_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_WuYinQu_YuanNiaoZe_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_WuYinQu_YuanNiaoZe_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_WuYinQu_YuanNiaoZe_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B71F RID: 177951 RVA: 0x00A00E74 File Offset: 0x009FF074
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_WuYinQu_YuanNiaoZe_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_WuYinQu_YuanNiaoZe_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_WuYinQu_YuanNiaoZe_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_WuYinQu_YuanNiaoZe_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_WuYinQu_YuanNiaoZe_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B720 RID: 177952 RVA: 0x00A00EBB File Offset: 0x009FF0BB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_WuYinQu_YuanNiaoZe_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B721 RID: 177953 RVA: 0x00A00ECF File Offset: 0x009FF0CF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_WuYinQu_YuanNiaoZe_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B722 RID: 177954 RVA: 0x00A00EE4 File Offset: 0x009FF0E4
		protected GA_WuYinQu_YuanNiaoZe_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040169C7 RID: 92615
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_WuYinQu_YuanNiaoZe.GA_WuYinQu_YuanNiaoZe_C";

		// Token: 0x040169C8 RID: 92616
		private static IntPtr _ClassPtr;

		// Token: 0x040169C9 RID: 92617
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040169CA RID: 92618
		internal new static int __PropertyOffset_1;

		// Token: 0x040169CB RID: 92619
		internal new static int __PropertyOffset_2;

		// Token: 0x040169CC RID: 92620
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x040169CD RID: 92621
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0200A526 RID: 42278
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032394 RID: 205716
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
