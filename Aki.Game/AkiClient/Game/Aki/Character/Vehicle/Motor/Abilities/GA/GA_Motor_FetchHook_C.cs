using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Abilities.GA
{
	// Token: 0x0200406F RID: 16495
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_FetchHook.GA_Motor_FetchHook_C")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1536)]
	public class GA_Motor_FetchHook_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A604 RID: 173572 RVA: 0x009DEE20 File Offset: 0x009DD020
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_FetchHook_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_FetchHook.GA_Motor_FetchHook_C");
			}
			return GA_Motor_FetchHook_C._ClassPtr;
		}

		// Token: 0x0602A605 RID: 173573 RVA: 0x009DEE44 File Offset: 0x009DD044
		public GA_Motor_FetchHook_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_FetchHook_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A606 RID: 173574 RVA: 0x009DEE6C File Offset: 0x009DD06C
		[NullableContext(1)]
		public GA_Motor_FetchHook_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_FetchHook_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170067DB RID: 26587
		// (get) Token: 0x0602A607 RID: 173575 RVA: 0x009DEE9F File Offset: 0x009DD09F
		// (set) Token: 0x0602A608 RID: 173576 RVA: 0x009DEEB3 File Offset: 0x009DD0B3
		[Nullable(2)]
		public unsafe TsBaseVehicle 施法载具
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseVehicle>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FetchHook_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FetchHook_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170067DC RID: 26588
		// (get) Token: 0x0602A609 RID: 173577 RVA: 0x009DEEC8 File Offset: 0x009DD0C8
		// (set) Token: 0x0602A60A RID: 173578 RVA: 0x009DEED8 File Offset: 0x009DD0D8
		public unsafe int 施法载具Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FetchHook_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FetchHook_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170067DD RID: 26589
		// (get) Token: 0x0602A60B RID: 173579 RVA: 0x009DEEE9 File Offset: 0x009DD0E9
		// (set) Token: 0x0602A60C RID: 173580 RVA: 0x009DEEF9 File Offset: 0x009DD0F9
		public unsafe bool 是否移除特效Buff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FetchHook_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FetchHook_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x170067DE RID: 26590
		// (get) Token: 0x0602A60D RID: 173581 RVA: 0x009DEF0A File Offset: 0x009DD10A
		// (set) Token: 0x0602A60E RID: 173582 RVA: 0x009DEF1A File Offset: 0x009DD11A
		public unsafe long BuffId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FetchHook_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FetchHook_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x0602A60F RID: 173583 RVA: 0x009DEF2B File Offset: 0x009DD12B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_CD17688C48A6C8D5BFCE9AA72A8C5696()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FetchHook_C.__OnFinish_CD17688C48A6C8D5BFCE9AA72A8C5696_NativeFunctionPtr, null);
		}

		// Token: 0x0602A610 RID: 173584 RVA: 0x009DEF3F File Offset: 0x009DD13F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CD17688C48A6C8D5BFCE9AA72A8C5696()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FetchHook_C.__OnTick_CD17688C48A6C8D5BFCE9AA72A8C5696_NativeFunctionPtr, null);
		}

		// Token: 0x0602A611 RID: 173585 RVA: 0x009DEF53 File Offset: 0x009DD153
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_7FAAD89C4FA0ED181321D7B5F80D462C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FetchHook_C.__OnFinish_7FAAD89C4FA0ED181321D7B5F80D462C_NativeFunctionPtr, null);
		}

		// Token: 0x0602A612 RID: 173586 RVA: 0x009DEF67 File Offset: 0x009DD167
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_C5EAE3EE4939CB19D2C47DADF3E097A4()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FetchHook_C.__OnFinish_C5EAE3EE4939CB19D2C47DADF3E097A4_NativeFunctionPtr, null);
		}

		// Token: 0x0602A613 RID: 173587 RVA: 0x009DEF7B File Offset: 0x009DD17B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FetchHook_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A614 RID: 173588 RVA: 0x009DEF8F File Offset: 0x009DD18F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_FetchHook_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A615 RID: 173589 RVA: 0x009DEFA4 File Offset: 0x009DD1A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_FetchHook_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_FetchHook_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_FetchHook_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_FetchHook_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FetchHook_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A616 RID: 173590 RVA: 0x009DEFEC File Offset: 0x009DD1EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_FetchHook_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_FetchHook_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_FetchHook_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_FetchHook_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_FetchHook_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A617 RID: 173591 RVA: 0x009DF033 File Offset: 0x009DD233
		protected GA_Motor_FetchHook_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015DF8 RID: 89592
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_FetchHook.GA_Motor_FetchHook_C";

		// Token: 0x04015DF9 RID: 89593
		private static IntPtr _ClassPtr;

		// Token: 0x04015DFA RID: 89594
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015DFB RID: 89595
		internal new static int __PropertyOffset_1;

		// Token: 0x04015DFC RID: 89596
		internal new static int __PropertyOffset_2;

		// Token: 0x04015DFD RID: 89597
		internal new static int __PropertyOffset_3;

		// Token: 0x04015DFE RID: 89598
		internal static int __PropertyOffset_4;

		// Token: 0x04015DFF RID: 89599
		private static IntPtr __OnFinish_CD17688C48A6C8D5BFCE9AA72A8C5696_NativeFunctionPtr;

		// Token: 0x04015E00 RID: 89600
		private static IntPtr __OnTick_CD17688C48A6C8D5BFCE9AA72A8C5696_NativeFunctionPtr;

		// Token: 0x04015E01 RID: 89601
		private static IntPtr __OnFinish_7FAAD89C4FA0ED181321D7B5F80D462C_NativeFunctionPtr;

		// Token: 0x04015E02 RID: 89602
		private static IntPtr __OnFinish_C5EAE3EE4939CB19D2C47DADF3E097A4_NativeFunctionPtr;

		// Token: 0x04015E03 RID: 89603
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015E04 RID: 89604
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A390 RID: 41872
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032178 RID: 205176
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
