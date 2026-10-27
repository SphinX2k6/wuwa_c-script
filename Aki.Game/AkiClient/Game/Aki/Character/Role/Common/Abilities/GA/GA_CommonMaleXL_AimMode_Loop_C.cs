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
	// Token: 0x02004124 RID: 16676
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_CommonMaleXL_AimMode_Loop.GA_CommonMaleXL_AimMode_Loop_C")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1531)]
	public class GA_CommonMaleXL_AimMode_Loop_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AF66 RID: 175974 RVA: 0x009F140C File Offset: 0x009EF60C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_CommonMaleXL_AimMode_Loop_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_CommonMaleXL_AimMode_Loop.GA_CommonMaleXL_AimMode_Loop_C");
			}
			return GA_CommonMaleXL_AimMode_Loop_C._ClassPtr;
		}

		// Token: 0x0602AF67 RID: 175975 RVA: 0x009F1430 File Offset: 0x009EF630
		public GA_CommonMaleXL_AimMode_Loop_C() : this(BuiltinUtils.AllocNativeUObject(GA_CommonMaleXL_AimMode_Loop_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AF68 RID: 175976 RVA: 0x009F1458 File Offset: 0x009EF658
		[NullableContext(1)]
		public GA_CommonMaleXL_AimMode_Loop_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_CommonMaleXL_AimMode_Loop_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170069DB RID: 27099
		// (get) Token: 0x0602AF69 RID: 175977 RVA: 0x009F148B File Offset: 0x009EF68B
		// (set) Token: 0x0602AF6A RID: 175978 RVA: 0x009F149F File Offset: 0x009EF69F
		[Nullable(2)]
		public unsafe UGameplayTask_WaitDelay Async_Task
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameplayTask_WaitDelay>(base.NativePtr / (IntPtr)sizeof(void*) + GA_CommonMaleXL_AimMode_Loop_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_CommonMaleXL_AimMode_Loop_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170069DC RID: 27100
		// (get) Token: 0x0602AF6B RID: 175979 RVA: 0x009F14B4 File Offset: 0x009EF6B4
		// (set) Token: 0x0602AF6C RID: 175980 RVA: 0x009F14C4 File Offset: 0x009EF6C4
		public unsafe bool 按键抬起
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_CommonMaleXL_AimMode_Loop_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_CommonMaleXL_AimMode_Loop_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069DD RID: 27101
		// (get) Token: 0x0602AF6D RID: 175981 RVA: 0x009F14D5 File Offset: 0x009EF6D5
		// (set) Token: 0x0602AF6E RID: 175982 RVA: 0x009F14E5 File Offset: 0x009EF6E5
		public unsafe int 蓄力特效子弹
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_CommonMaleXL_AimMode_Loop_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_CommonMaleXL_AimMode_Loop_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170069DE RID: 27102
		// (get) Token: 0x0602AF6F RID: 175983 RVA: 0x009F14F6 File Offset: 0x009EF6F6
		// (set) Token: 0x0602AF70 RID: 175984 RVA: 0x009F1506 File Offset: 0x009EF706
		public unsafe bool 射击中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_CommonMaleXL_AimMode_Loop_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_CommonMaleXL_AimMode_Loop_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069DF RID: 27103
		// (get) Token: 0x0602AF71 RID: 175985 RVA: 0x009F1517 File Offset: 0x009EF717
		// (set) Token: 0x0602AF72 RID: 175986 RVA: 0x009F1527 File Offset: 0x009EF727
		public unsafe bool 蓄力开始
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_CommonMaleXL_AimMode_Loop_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_CommonMaleXL_AimMode_Loop_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069E0 RID: 27104
		// (get) Token: 0x0602AF73 RID: 175987 RVA: 0x009F1538 File Offset: 0x009EF738
		// (set) Token: 0x0602AF74 RID: 175988 RVA: 0x009F1548 File Offset: 0x009EF748
		public unsafe bool 已退出瞄准
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_CommonMaleXL_AimMode_Loop_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_CommonMaleXL_AimMode_Loop_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602AF75 RID: 175989 RVA: 0x009F155C File Offset: 0x009EF75C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EventReceived_18B59F5945020DB23C42FD8813455167(FGameplayEventData Payload)
		{
			GA_CommonMaleXL_AimMode_Loop_C.__EventReceived_18B59F5945020DB23C42FD8813455167_FunctionParams* ptr = stackalloc GA_CommonMaleXL_AimMode_Loop_C.__EventReceived_18B59F5945020DB23C42FD8813455167_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(GA_CommonMaleXL_AimMode_Loop_C.__EventReceived_18B59F5945020DB23C42FD8813455167_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_CommonMaleXL_AimMode_Loop_C.__EventReceived_18B59F5945020DB23C42FD8813455167_NativeFunctionPtr, (void*)ptr, 1);
			if (Payload != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEventData.StaticStruct(), &ptr->Payload, Payload.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonMaleXL_AimMode_Loop_C.__EventReceived_18B59F5945020DB23C42FD8813455167_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_CommonMaleXL_AimMode_Loop_C.__EventReceived_18B59F5945020DB23C42FD8813455167_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602AF76 RID: 175990 RVA: 0x009F15D4 File Offset: 0x009EF7D4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EventReceived_18B59F5945020DB23C42FD8853A2FB4C(FGameplayEventData Payload)
		{
			GA_CommonMaleXL_AimMode_Loop_C.__EventReceived_18B59F5945020DB23C42FD8853A2FB4C_FunctionParams* ptr = stackalloc GA_CommonMaleXL_AimMode_Loop_C.__EventReceived_18B59F5945020DB23C42FD8853A2FB4C_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(GA_CommonMaleXL_AimMode_Loop_C.__EventReceived_18B59F5945020DB23C42FD8853A2FB4C_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_CommonMaleXL_AimMode_Loop_C.__EventReceived_18B59F5945020DB23C42FD8853A2FB4C_NativeFunctionPtr, (void*)ptr, 1);
			if (Payload != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEventData.StaticStruct(), &ptr->Payload, Payload.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonMaleXL_AimMode_Loop_C.__EventReceived_18B59F5945020DB23C42FD8853A2FB4C_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_CommonMaleXL_AimMode_Loop_C.__EventReceived_18B59F5945020DB23C42FD8853A2FB4C_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602AF77 RID: 175991 RVA: 0x009F164C File Offset: 0x009EF84C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EventReceived_18B59F5945020DB23C42FD887623D1BB(FGameplayEventData Payload)
		{
			GA_CommonMaleXL_AimMode_Loop_C.__EventReceived_18B59F5945020DB23C42FD887623D1BB_FunctionParams* ptr = stackalloc GA_CommonMaleXL_AimMode_Loop_C.__EventReceived_18B59F5945020DB23C42FD887623D1BB_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(GA_CommonMaleXL_AimMode_Loop_C.__EventReceived_18B59F5945020DB23C42FD887623D1BB_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_CommonMaleXL_AimMode_Loop_C.__EventReceived_18B59F5945020DB23C42FD887623D1BB_NativeFunctionPtr, (void*)ptr, 1);
			if (Payload != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEventData.StaticStruct(), &ptr->Payload, Payload.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonMaleXL_AimMode_Loop_C.__EventReceived_18B59F5945020DB23C42FD887623D1BB_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_CommonMaleXL_AimMode_Loop_C.__EventReceived_18B59F5945020DB23C42FD887623D1BB_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602AF78 RID: 175992 RVA: 0x009F16C4 File Offset: 0x009EF8C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_1DD1C85741CD361EAE7F4B9DCD34F648(in FGameplayTag Tag)
		{
			GA_CommonMaleXL_AimMode_Loop_C.__Removed_1DD1C85741CD361EAE7F4B9DCD34F648_FunctionParams* ptr = stackalloc GA_CommonMaleXL_AimMode_Loop_C.__Removed_1DD1C85741CD361EAE7F4B9DCD34F648_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_CommonMaleXL_AimMode_Loop_C.__Removed_1DD1C85741CD361EAE7F4B9DCD34F648_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_CommonMaleXL_AimMode_Loop_C.__Removed_1DD1C85741CD361EAE7F4B9DCD34F648_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonMaleXL_AimMode_Loop_C.__Removed_1DD1C85741CD361EAE7F4B9DCD34F648_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AF79 RID: 175993 RVA: 0x009F1710 File Offset: 0x009EF910
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_E54B386745D796C6622339856AC999E7(in FGameplayTag Tag)
		{
			GA_CommonMaleXL_AimMode_Loop_C.__Added_E54B386745D796C6622339856AC999E7_FunctionParams* ptr = stackalloc GA_CommonMaleXL_AimMode_Loop_C.__Added_E54B386745D796C6622339856AC999E7_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_CommonMaleXL_AimMode_Loop_C.__Added_E54B386745D796C6622339856AC999E7_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_CommonMaleXL_AimMode_Loop_C.__Added_E54B386745D796C6622339856AC999E7_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonMaleXL_AimMode_Loop_C.__Added_E54B386745D796C6622339856AC999E7_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AF7A RID: 175994 RVA: 0x009F175C File Offset: 0x009EF95C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_CF1629154081ACA2BB4E2DB5CFBB1DEC(in FGameplayTag Tag)
		{
			GA_CommonMaleXL_AimMode_Loop_C.__Added_CF1629154081ACA2BB4E2DB5CFBB1DEC_FunctionParams* ptr = stackalloc GA_CommonMaleXL_AimMode_Loop_C.__Added_CF1629154081ACA2BB4E2DB5CFBB1DEC_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_CommonMaleXL_AimMode_Loop_C.__Added_CF1629154081ACA2BB4E2DB5CFBB1DEC_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_CommonMaleXL_AimMode_Loop_C.__Added_CF1629154081ACA2BB4E2DB5CFBB1DEC_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonMaleXL_AimMode_Loop_C.__Added_CF1629154081ACA2BB4E2DB5CFBB1DEC_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AF7B RID: 175995 RVA: 0x009F17A8 File Offset: 0x009EF9A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_A2C134B24491879E7774C49150B5709A(in FGameplayTag Tag)
		{
			GA_CommonMaleXL_AimMode_Loop_C.__Added_A2C134B24491879E7774C49150B5709A_FunctionParams* ptr = stackalloc GA_CommonMaleXL_AimMode_Loop_C.__Added_A2C134B24491879E7774C49150B5709A_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_CommonMaleXL_AimMode_Loop_C.__Added_A2C134B24491879E7774C49150B5709A_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_CommonMaleXL_AimMode_Loop_C.__Added_A2C134B24491879E7774C49150B5709A_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonMaleXL_AimMode_Loop_C.__Added_A2C134B24491879E7774C49150B5709A_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AF7C RID: 175996 RVA: 0x009F17F4 File Offset: 0x009EF9F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_D8B84C7B40B280C4C7DFFEAC63C9CCF3(in FGameplayTag Tag)
		{
			GA_CommonMaleXL_AimMode_Loop_C.__Added_D8B84C7B40B280C4C7DFFEAC63C9CCF3_FunctionParams* ptr = stackalloc GA_CommonMaleXL_AimMode_Loop_C.__Added_D8B84C7B40B280C4C7DFFEAC63C9CCF3_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_CommonMaleXL_AimMode_Loop_C.__Added_D8B84C7B40B280C4C7DFFEAC63C9CCF3_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_CommonMaleXL_AimMode_Loop_C.__Added_D8B84C7B40B280C4C7DFFEAC63C9CCF3_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonMaleXL_AimMode_Loop_C.__Added_D8B84C7B40B280C4C7DFFEAC63C9CCF3_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AF7D RID: 175997 RVA: 0x009F1840 File Offset: 0x009EFA40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_7970F50E429588213C1DCE818F152235(in FGameplayTag Tag)
		{
			GA_CommonMaleXL_AimMode_Loop_C.__Added_7970F50E429588213C1DCE818F152235_FunctionParams* ptr = stackalloc GA_CommonMaleXL_AimMode_Loop_C.__Added_7970F50E429588213C1DCE818F152235_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_CommonMaleXL_AimMode_Loop_C.__Added_7970F50E429588213C1DCE818F152235_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_CommonMaleXL_AimMode_Loop_C.__Added_7970F50E429588213C1DCE818F152235_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonMaleXL_AimMode_Loop_C.__Added_7970F50E429588213C1DCE818F152235_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AF7E RID: 175998 RVA: 0x009F188C File Offset: 0x009EFA8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_D4BA4CDF4C987EAD3860C4B25FEE65FA(in FGameplayTag Tag)
		{
			GA_CommonMaleXL_AimMode_Loop_C.__Removed_D4BA4CDF4C987EAD3860C4B25FEE65FA_FunctionParams* ptr = stackalloc GA_CommonMaleXL_AimMode_Loop_C.__Removed_D4BA4CDF4C987EAD3860C4B25FEE65FA_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_CommonMaleXL_AimMode_Loop_C.__Removed_D4BA4CDF4C987EAD3860C4B25FEE65FA_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_CommonMaleXL_AimMode_Loop_C.__Removed_D4BA4CDF4C987EAD3860C4B25FEE65FA_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonMaleXL_AimMode_Loop_C.__Removed_D4BA4CDF4C987EAD3860C4B25FEE65FA_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AF7F RID: 175999 RVA: 0x009F18D7 File Offset: 0x009EFAD7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonMaleXL_AimMode_Loop_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602AF80 RID: 176000 RVA: 0x009F18EB File Offset: 0x009EFAEB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_CommonMaleXL_AimMode_Loop_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602AF81 RID: 176001 RVA: 0x009F1900 File Offset: 0x009EFB00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_CommonMaleXL_AimMode_Loop_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_CommonMaleXL_AimMode_Loop_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_CommonMaleXL_AimMode_Loop_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_CommonMaleXL_AimMode_Loop_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonMaleXL_AimMode_Loop_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AF82 RID: 176002 RVA: 0x009F1948 File Offset: 0x009EFB48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_CommonMaleXL_AimMode_Loop_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_CommonMaleXL_AimMode_Loop_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_CommonMaleXL_AimMode_Loop_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_CommonMaleXL_AimMode_Loop_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_CommonMaleXL_AimMode_Loop_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602AF83 RID: 176003 RVA: 0x009F198F File Offset: 0x009EFB8F
		protected GA_CommonMaleXL_AimMode_Loop_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016468 RID: 91240
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_CommonMaleXL_AimMode_Loop.GA_CommonMaleXL_AimMode_Loop_C";

		// Token: 0x04016469 RID: 91241
		private static IntPtr _ClassPtr;

		// Token: 0x0401646A RID: 91242
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401646B RID: 91243
		internal new static int __PropertyOffset_1;

		// Token: 0x0401646C RID: 91244
		internal new static int __PropertyOffset_2;

		// Token: 0x0401646D RID: 91245
		internal new static int __PropertyOffset_3;

		// Token: 0x0401646E RID: 91246
		internal static int __PropertyOffset_4;

		// Token: 0x0401646F RID: 91247
		internal static int __PropertyOffset_5;

		// Token: 0x04016470 RID: 91248
		internal static int __PropertyOffset_6;

		// Token: 0x04016471 RID: 91249
		private static IntPtr __EventReceived_18B59F5945020DB23C42FD8813455167_NativeFunctionPtr;

		// Token: 0x04016472 RID: 91250
		private static IntPtr __EventReceived_18B59F5945020DB23C42FD8853A2FB4C_NativeFunctionPtr;

		// Token: 0x04016473 RID: 91251
		private static IntPtr __EventReceived_18B59F5945020DB23C42FD887623D1BB_NativeFunctionPtr;

		// Token: 0x04016474 RID: 91252
		private static IntPtr __Removed_1DD1C85741CD361EAE7F4B9DCD34F648_NativeFunctionPtr;

		// Token: 0x04016475 RID: 91253
		private static IntPtr __Added_E54B386745D796C6622339856AC999E7_NativeFunctionPtr;

		// Token: 0x04016476 RID: 91254
		private static IntPtr __Added_CF1629154081ACA2BB4E2DB5CFBB1DEC_NativeFunctionPtr;

		// Token: 0x04016477 RID: 91255
		private static IntPtr __Added_A2C134B24491879E7774C49150B5709A_NativeFunctionPtr;

		// Token: 0x04016478 RID: 91256
		private static IntPtr __Added_D8B84C7B40B280C4C7DFFEAC63C9CCF3_NativeFunctionPtr;

		// Token: 0x04016479 RID: 91257
		private static IntPtr __Added_7970F50E429588213C1DCE818F152235_NativeFunctionPtr;

		// Token: 0x0401647A RID: 91258
		private static IntPtr __Removed_D4BA4CDF4C987EAD3860C4B25FEE65FA_NativeFunctionPtr;

		// Token: 0x0401647B RID: 91259
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0401647C RID: 91260
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A445 RID: 42053
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __EventReceived_18B59F5945020DB23C42FD8813455167_FunctionParams
		{
			// Token: 0x04032284 RID: 205444
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x0200A446 RID: 42054
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __EventReceived_18B59F5945020DB23C42FD8853A2FB4C_FunctionParams
		{
			// Token: 0x04032285 RID: 205445
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x0200A447 RID: 42055
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __EventReceived_18B59F5945020DB23C42FD887623D1BB_FunctionParams
		{
			// Token: 0x04032286 RID: 205446
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x0200A448 RID: 42056
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_1DD1C85741CD361EAE7F4B9DCD34F648_FunctionParams
		{
			// Token: 0x04032287 RID: 205447
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A449 RID: 42057
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_E54B386745D796C6622339856AC999E7_FunctionParams
		{
			// Token: 0x04032288 RID: 205448
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A44A RID: 42058
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_CF1629154081ACA2BB4E2DB5CFBB1DEC_FunctionParams
		{
			// Token: 0x04032289 RID: 205449
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A44B RID: 42059
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_A2C134B24491879E7774C49150B5709A_FunctionParams
		{
			// Token: 0x0403228A RID: 205450
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A44C RID: 42060
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_D8B84C7B40B280C4C7DFFEAC63C9CCF3_FunctionParams
		{
			// Token: 0x0403228B RID: 205451
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A44D RID: 42061
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_7970F50E429588213C1DCE818F152235_FunctionParams
		{
			// Token: 0x0403228C RID: 205452
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A44E RID: 42062
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_D4BA4CDF4C987EAD3860C4B25FEE65FA_FunctionParams
		{
			// Token: 0x0403228D RID: 205453
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A44F RID: 42063
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x0403228E RID: 205454
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
