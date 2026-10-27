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
	// Token: 0x0200414C RID: 16716
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_3_7_BossChasing.GA_Role_3_7_BossChasing_C")]
	[UnrealStructLayout(1544, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1540)]
	public class GA_Role_3_7_BossChasing_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B19C RID: 176540 RVA: 0x009F5E4B File Offset: 0x009F404B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Role_3_7_BossChasing_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_3_7_BossChasing.GA_Role_3_7_BossChasing_C");
			}
			return GA_Role_3_7_BossChasing_C._ClassPtr;
		}

		// Token: 0x0602B19D RID: 176541 RVA: 0x009F5E70 File Offset: 0x009F4070
		public GA_Role_3_7_BossChasing_C() : this(BuiltinUtils.AllocNativeUObject(GA_Role_3_7_BossChasing_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B19E RID: 176542 RVA: 0x009F5E98 File Offset: 0x009F4098
		[NullableContext(1)]
		public GA_Role_3_7_BossChasing_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Role_3_7_BossChasing_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A21 RID: 27169
		// (get) Token: 0x0602B19F RID: 176543 RVA: 0x009F5ECB File Offset: 0x009F40CB
		// (set) Token: 0x0602B1A0 RID: 176544 RVA: 0x009F5EDF File Offset: 0x009F40DF
		public unsafe FVector 目标点位
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_3_7_BossChasing_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_3_7_BossChasing_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006A22 RID: 27170
		// (get) Token: 0x0602B1A1 RID: 176545 RVA: 0x009F5EF4 File Offset: 0x009F40F4
		// (set) Token: 0x0602B1A2 RID: 176546 RVA: 0x009F5F04 File Offset: 0x009F4104
		public unsafe bool NewVar_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_3_7_BossChasing_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_3_7_BossChasing_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A23 RID: 27171
		// (get) Token: 0x0602B1A3 RID: 176547 RVA: 0x009F5F15 File Offset: 0x009F4115
		// (set) Token: 0x0602B1A4 RID: 176548 RVA: 0x009F5F29 File Offset: 0x009F4129
		[Nullable(2)]
		public unsafe TsBaseCharacter 角色
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_3_7_BossChasing_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_3_7_BossChasing_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17006A24 RID: 27172
		// (get) Token: 0x0602B1A5 RID: 176549 RVA: 0x009F5F3E File Offset: 0x009F413E
		// (set) Token: 0x0602B1A6 RID: 176550 RVA: 0x009F5F4E File Offset: 0x009F414E
		public unsafe float 角色胶囊体半高
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_3_7_BossChasing_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_3_7_BossChasing_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x0602B1A7 RID: 176551 RVA: 0x009F5F5F File Offset: 0x009F415F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E818A607CE2()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_3_7_BossChasing_C.__OnTick_5D118C384AE61F1C80292E818A607CE2_NativeFunctionPtr, null);
		}

		// Token: 0x0602B1A8 RID: 176552 RVA: 0x009F5F73 File Offset: 0x009F4173
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E818A607CE2()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_3_7_BossChasing_C.__OnCancelled_5D118C384AE61F1C80292E818A607CE2_NativeFunctionPtr, null);
		}

		// Token: 0x0602B1A9 RID: 176553 RVA: 0x009F5F87 File Offset: 0x009F4187
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E818A607CE2()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_3_7_BossChasing_C.__OnInterrupted_5D118C384AE61F1C80292E818A607CE2_NativeFunctionPtr, null);
		}

		// Token: 0x0602B1AA RID: 176554 RVA: 0x009F5F9B File Offset: 0x009F419B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E818A607CE2()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_3_7_BossChasing_C.__OnBlendOut_5D118C384AE61F1C80292E818A607CE2_NativeFunctionPtr, null);
		}

		// Token: 0x0602B1AB RID: 176555 RVA: 0x009F5FAF File Offset: 0x009F41AF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E818A607CE2()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_3_7_BossChasing_C.__OnCompleted_5D118C384AE61F1C80292E818A607CE2_NativeFunctionPtr, null);
		}

		// Token: 0x0602B1AC RID: 176556 RVA: 0x009F5FC3 File Offset: 0x009F41C3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E81726125FB()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_3_7_BossChasing_C.__OnTick_5D118C384AE61F1C80292E81726125FB_NativeFunctionPtr, null);
		}

		// Token: 0x0602B1AD RID: 176557 RVA: 0x009F5FD7 File Offset: 0x009F41D7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E81726125FB()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_3_7_BossChasing_C.__OnCancelled_5D118C384AE61F1C80292E81726125FB_NativeFunctionPtr, null);
		}

		// Token: 0x0602B1AE RID: 176558 RVA: 0x009F5FEB File Offset: 0x009F41EB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E81726125FB()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_3_7_BossChasing_C.__OnInterrupted_5D118C384AE61F1C80292E81726125FB_NativeFunctionPtr, null);
		}

		// Token: 0x0602B1AF RID: 176559 RVA: 0x009F5FFF File Offset: 0x009F41FF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E81726125FB()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_3_7_BossChasing_C.__OnBlendOut_5D118C384AE61F1C80292E81726125FB_NativeFunctionPtr, null);
		}

		// Token: 0x0602B1B0 RID: 176560 RVA: 0x009F6013 File Offset: 0x009F4213
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E81726125FB()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_3_7_BossChasing_C.__OnCompleted_5D118C384AE61F1C80292E81726125FB_NativeFunctionPtr, null);
		}

		// Token: 0x0602B1B1 RID: 176561 RVA: 0x009F6027 File Offset: 0x009F4227
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_3_7_BossChasing_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B1B2 RID: 176562 RVA: 0x009F603B File Offset: 0x009F423B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_3_7_BossChasing_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B1B3 RID: 176563 RVA: 0x009F6050 File Offset: 0x009F4250
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Role_3_7_BossChasing_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_3_7_BossChasing_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_3_7_BossChasing_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_3_7_BossChasing_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_3_7_BossChasing_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B1B4 RID: 176564 RVA: 0x009F6098 File Offset: 0x009F4298
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Role_3_7_BossChasing_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_3_7_BossChasing_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_3_7_BossChasing_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_3_7_BossChasing_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_3_7_BossChasing_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B1B5 RID: 176565 RVA: 0x009F60DF File Offset: 0x009F42DF
		protected GA_Role_3_7_BossChasing_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040165EF RID: 91631
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_3_7_BossChasing.GA_Role_3_7_BossChasing_C";

		// Token: 0x040165F0 RID: 91632
		private static IntPtr _ClassPtr;

		// Token: 0x040165F1 RID: 91633
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040165F2 RID: 91634
		internal new static int __PropertyOffset_1;

		// Token: 0x040165F3 RID: 91635
		internal new static int __PropertyOffset_2;

		// Token: 0x040165F4 RID: 91636
		internal new static int __PropertyOffset_3;

		// Token: 0x040165F5 RID: 91637
		internal static int __PropertyOffset_4;

		// Token: 0x040165F6 RID: 91638
		private static IntPtr __OnTick_5D118C384AE61F1C80292E818A607CE2_NativeFunctionPtr;

		// Token: 0x040165F7 RID: 91639
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E818A607CE2_NativeFunctionPtr;

		// Token: 0x040165F8 RID: 91640
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E818A607CE2_NativeFunctionPtr;

		// Token: 0x040165F9 RID: 91641
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E818A607CE2_NativeFunctionPtr;

		// Token: 0x040165FA RID: 91642
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E818A607CE2_NativeFunctionPtr;

		// Token: 0x040165FB RID: 91643
		private static IntPtr __OnTick_5D118C384AE61F1C80292E81726125FB_NativeFunctionPtr;

		// Token: 0x040165FC RID: 91644
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E81726125FB_NativeFunctionPtr;

		// Token: 0x040165FD RID: 91645
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E81726125FB_NativeFunctionPtr;

		// Token: 0x040165FE RID: 91646
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E81726125FB_NativeFunctionPtr;

		// Token: 0x040165FF RID: 91647
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E81726125FB_NativeFunctionPtr;

		// Token: 0x04016600 RID: 91648
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04016601 RID: 91649
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A480 RID: 42112
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040322D2 RID: 205522
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
