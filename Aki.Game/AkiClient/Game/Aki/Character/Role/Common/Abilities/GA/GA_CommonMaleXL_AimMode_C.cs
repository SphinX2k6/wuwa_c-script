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
	// Token: 0x02004123 RID: 16675
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_CommonMaleXL_AimMode.GA_CommonMaleXL_AimMode_C")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1530)]
	public class GA_CommonMaleXL_AimMode_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AF4A RID: 175946 RVA: 0x009F0F04 File Offset: 0x009EF104
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_CommonMaleXL_AimMode_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_CommonMaleXL_AimMode.GA_CommonMaleXL_AimMode_C");
			}
			return GA_CommonMaleXL_AimMode_C._ClassPtr;
		}

		// Token: 0x0602AF4B RID: 175947 RVA: 0x009F0F28 File Offset: 0x009EF128
		public GA_CommonMaleXL_AimMode_C() : this(BuiltinUtils.AllocNativeUObject(GA_CommonMaleXL_AimMode_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AF4C RID: 175948 RVA: 0x009F0F50 File Offset: 0x009EF150
		[NullableContext(1)]
		public GA_CommonMaleXL_AimMode_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_CommonMaleXL_AimMode_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170069D6 RID: 27094
		// (get) Token: 0x0602AF4D RID: 175949 RVA: 0x009F0F83 File Offset: 0x009EF183
		// (set) Token: 0x0602AF4E RID: 175950 RVA: 0x009F0F97 File Offset: 0x009EF197
		[Nullable(2)]
		public unsafe UGameplayTask_WaitDelay Async_Task
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameplayTask_WaitDelay>(base.NativePtr / (IntPtr)sizeof(void*) + GA_CommonMaleXL_AimMode_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_CommonMaleXL_AimMode_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170069D7 RID: 27095
		// (get) Token: 0x0602AF4F RID: 175951 RVA: 0x009F0FAC File Offset: 0x009EF1AC
		// (set) Token: 0x0602AF50 RID: 175952 RVA: 0x009F0FBC File Offset: 0x009EF1BC
		public unsafe bool 蓄力完成
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_CommonMaleXL_AimMode_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_CommonMaleXL_AimMode_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069D8 RID: 27096
		// (get) Token: 0x0602AF51 RID: 175953 RVA: 0x009F0FCD File Offset: 0x009EF1CD
		// (set) Token: 0x0602AF52 RID: 175954 RVA: 0x009F0FDD File Offset: 0x009EF1DD
		public unsafe int 蓄力特效子弹
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_CommonMaleXL_AimMode_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_CommonMaleXL_AimMode_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170069D9 RID: 27097
		// (get) Token: 0x0602AF53 RID: 175955 RVA: 0x009F0FEE File Offset: 0x009EF1EE
		// (set) Token: 0x0602AF54 RID: 175956 RVA: 0x009F0FFE File Offset: 0x009EF1FE
		public unsafe bool 射击中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_CommonMaleXL_AimMode_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_CommonMaleXL_AimMode_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069DA RID: 27098
		// (get) Token: 0x0602AF55 RID: 175957 RVA: 0x009F100F File Offset: 0x009EF20F
		// (set) Token: 0x0602AF56 RID: 175958 RVA: 0x009F101F File Offset: 0x009EF21F
		public unsafe bool 是否进入自动瞄准
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_CommonMaleXL_AimMode_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_CommonMaleXL_AimMode_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602AF57 RID: 175959 RVA: 0x009F1030 File Offset: 0x009EF230
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 自动瞄准处理(ref bool 是否进入自动瞄准)
		{
			GA_CommonMaleXL_AimMode_C.__自动瞄准处理_FunctionParams* ptr = stackalloc GA_CommonMaleXL_AimMode_C.__自动瞄准处理_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(GA_CommonMaleXL_AimMode_C.__自动瞄准处理_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_CommonMaleXL_AimMode_C.__自动瞄准处理_NativeFunctionPtr, (void*)ptr, 1);
			ptr->是否进入自动瞄准 = 是否进入自动瞄准;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonMaleXL_AimMode_C.__自动瞄准处理_NativeFunctionPtr, (void*)ptr);
			是否进入自动瞄准 = ptr->是否进入自动瞄准;
		}

		// Token: 0x0602AF58 RID: 175960 RVA: 0x009F1080 File Offset: 0x009EF280
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EventReceived_18B59F5945020DB23C42FD88DC330F7F(FGameplayEventData Payload)
		{
			GA_CommonMaleXL_AimMode_C.__EventReceived_18B59F5945020DB23C42FD88DC330F7F_FunctionParams* ptr = stackalloc GA_CommonMaleXL_AimMode_C.__EventReceived_18B59F5945020DB23C42FD88DC330F7F_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(GA_CommonMaleXL_AimMode_C.__EventReceived_18B59F5945020DB23C42FD88DC330F7F_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_CommonMaleXL_AimMode_C.__EventReceived_18B59F5945020DB23C42FD88DC330F7F_NativeFunctionPtr, (void*)ptr, 1);
			if (Payload != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEventData.StaticStruct(), &ptr->Payload, Payload.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonMaleXL_AimMode_C.__EventReceived_18B59F5945020DB23C42FD88DC330F7F_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_CommonMaleXL_AimMode_C.__EventReceived_18B59F5945020DB23C42FD88DC330F7F_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602AF59 RID: 175961 RVA: 0x009F10F8 File Offset: 0x009EF2F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_1653F7D946291B91D3E713A910288372(in FGameplayTag Tag)
		{
			GA_CommonMaleXL_AimMode_C.__Removed_1653F7D946291B91D3E713A910288372_FunctionParams* ptr = stackalloc GA_CommonMaleXL_AimMode_C.__Removed_1653F7D946291B91D3E713A910288372_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_CommonMaleXL_AimMode_C.__Removed_1653F7D946291B91D3E713A910288372_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_CommonMaleXL_AimMode_C.__Removed_1653F7D946291B91D3E713A910288372_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonMaleXL_AimMode_C.__Removed_1653F7D946291B91D3E713A910288372_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AF5A RID: 175962 RVA: 0x009F1144 File Offset: 0x009EF344
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EventReceived_18B59F5945020DB23C42FD8891F18A29(FGameplayEventData Payload)
		{
			GA_CommonMaleXL_AimMode_C.__EventReceived_18B59F5945020DB23C42FD8891F18A29_FunctionParams* ptr = stackalloc GA_CommonMaleXL_AimMode_C.__EventReceived_18B59F5945020DB23C42FD8891F18A29_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(GA_CommonMaleXL_AimMode_C.__EventReceived_18B59F5945020DB23C42FD8891F18A29_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_CommonMaleXL_AimMode_C.__EventReceived_18B59F5945020DB23C42FD8891F18A29_NativeFunctionPtr, (void*)ptr, 1);
			if (Payload != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEventData.StaticStruct(), &ptr->Payload, Payload.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonMaleXL_AimMode_C.__EventReceived_18B59F5945020DB23C42FD8891F18A29_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_CommonMaleXL_AimMode_C.__EventReceived_18B59F5945020DB23C42FD8891F18A29_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602AF5B RID: 175963 RVA: 0x009F11BC File Offset: 0x009EF3BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_2871C22A44665795BF80D78EEE1213F4(in FGameplayTag Tag)
		{
			GA_CommonMaleXL_AimMode_C.__Added_2871C22A44665795BF80D78EEE1213F4_FunctionParams* ptr = stackalloc GA_CommonMaleXL_AimMode_C.__Added_2871C22A44665795BF80D78EEE1213F4_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_CommonMaleXL_AimMode_C.__Added_2871C22A44665795BF80D78EEE1213F4_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_CommonMaleXL_AimMode_C.__Added_2871C22A44665795BF80D78EEE1213F4_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonMaleXL_AimMode_C.__Added_2871C22A44665795BF80D78EEE1213F4_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AF5C RID: 175964 RVA: 0x009F1208 File Offset: 0x009EF408
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_BEBCE37F4E1B69E39F534EBBC1B1FEE7(in FGameplayTag Tag)
		{
			GA_CommonMaleXL_AimMode_C.__Added_BEBCE37F4E1B69E39F534EBBC1B1FEE7_FunctionParams* ptr = stackalloc GA_CommonMaleXL_AimMode_C.__Added_BEBCE37F4E1B69E39F534EBBC1B1FEE7_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_CommonMaleXL_AimMode_C.__Added_BEBCE37F4E1B69E39F534EBBC1B1FEE7_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_CommonMaleXL_AimMode_C.__Added_BEBCE37F4E1B69E39F534EBBC1B1FEE7_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonMaleXL_AimMode_C.__Added_BEBCE37F4E1B69E39F534EBBC1B1FEE7_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AF5D RID: 175965 RVA: 0x009F1254 File Offset: 0x009EF454
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_BB323FB84E3263466E0BEE98E1B3092A(in FGameplayTag Tag)
		{
			GA_CommonMaleXL_AimMode_C.__Added_BB323FB84E3263466E0BEE98E1B3092A_FunctionParams* ptr = stackalloc GA_CommonMaleXL_AimMode_C.__Added_BB323FB84E3263466E0BEE98E1B3092A_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_CommonMaleXL_AimMode_C.__Added_BB323FB84E3263466E0BEE98E1B3092A_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_CommonMaleXL_AimMode_C.__Added_BB323FB84E3263466E0BEE98E1B3092A_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonMaleXL_AimMode_C.__Added_BB323FB84E3263466E0BEE98E1B3092A_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AF5E RID: 175966 RVA: 0x009F12A0 File Offset: 0x009EF4A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_57B8397E4602013F2C15DF852515BD1D(in FGameplayTag Tag)
		{
			GA_CommonMaleXL_AimMode_C.__Added_57B8397E4602013F2C15DF852515BD1D_FunctionParams* ptr = stackalloc GA_CommonMaleXL_AimMode_C.__Added_57B8397E4602013F2C15DF852515BD1D_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_CommonMaleXL_AimMode_C.__Added_57B8397E4602013F2C15DF852515BD1D_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_CommonMaleXL_AimMode_C.__Added_57B8397E4602013F2C15DF852515BD1D_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonMaleXL_AimMode_C.__Added_57B8397E4602013F2C15DF852515BD1D_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AF5F RID: 175967 RVA: 0x009F12EC File Offset: 0x009EF4EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_FDAE1367416FE117430C11803F232A8E(in FGameplayTag Tag)
		{
			GA_CommonMaleXL_AimMode_C.__Added_FDAE1367416FE117430C11803F232A8E_FunctionParams* ptr = stackalloc GA_CommonMaleXL_AimMode_C.__Added_FDAE1367416FE117430C11803F232A8E_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_CommonMaleXL_AimMode_C.__Added_FDAE1367416FE117430C11803F232A8E_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_CommonMaleXL_AimMode_C.__Added_FDAE1367416FE117430C11803F232A8E_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonMaleXL_AimMode_C.__Added_FDAE1367416FE117430C11803F232A8E_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AF60 RID: 175968 RVA: 0x009F1337 File Offset: 0x009EF537
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonMaleXL_AimMode_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602AF61 RID: 175969 RVA: 0x009F134B File Offset: 0x009EF54B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_CommonMaleXL_AimMode_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602AF62 RID: 175970 RVA: 0x009F1360 File Offset: 0x009EF560
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_CommonMaleXL_AimMode_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_CommonMaleXL_AimMode_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_CommonMaleXL_AimMode_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_CommonMaleXL_AimMode_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonMaleXL_AimMode_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AF63 RID: 175971 RVA: 0x009F13A8 File Offset: 0x009EF5A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_CommonMaleXL_AimMode_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_CommonMaleXL_AimMode_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_CommonMaleXL_AimMode_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_CommonMaleXL_AimMode_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_CommonMaleXL_AimMode_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602AF64 RID: 175972 RVA: 0x009F13EF File Offset: 0x009EF5EF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomEvent_0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonMaleXL_AimMode_C.__CustomEvent_0_NativeFunctionPtr, null);
		}

		// Token: 0x0602AF65 RID: 175973 RVA: 0x009F1403 File Offset: 0x009EF603
		protected GA_CommonMaleXL_AimMode_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016454 RID: 91220
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_CommonMaleXL_AimMode.GA_CommonMaleXL_AimMode_C";

		// Token: 0x04016455 RID: 91221
		private static IntPtr _ClassPtr;

		// Token: 0x04016456 RID: 91222
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016457 RID: 91223
		internal new static int __PropertyOffset_1;

		// Token: 0x04016458 RID: 91224
		internal new static int __PropertyOffset_2;

		// Token: 0x04016459 RID: 91225
		internal new static int __PropertyOffset_3;

		// Token: 0x0401645A RID: 91226
		internal static int __PropertyOffset_4;

		// Token: 0x0401645B RID: 91227
		internal static int __PropertyOffset_5;

		// Token: 0x0401645C RID: 91228
		private static IntPtr __自动瞄准处理_NativeFunctionPtr;

		// Token: 0x0401645D RID: 91229
		private static IntPtr __EventReceived_18B59F5945020DB23C42FD88DC330F7F_NativeFunctionPtr;

		// Token: 0x0401645E RID: 91230
		private static IntPtr __Removed_1653F7D946291B91D3E713A910288372_NativeFunctionPtr;

		// Token: 0x0401645F RID: 91231
		private static IntPtr __EventReceived_18B59F5945020DB23C42FD8891F18A29_NativeFunctionPtr;

		// Token: 0x04016460 RID: 91232
		private static IntPtr __Added_2871C22A44665795BF80D78EEE1213F4_NativeFunctionPtr;

		// Token: 0x04016461 RID: 91233
		private static IntPtr __Added_BEBCE37F4E1B69E39F534EBBC1B1FEE7_NativeFunctionPtr;

		// Token: 0x04016462 RID: 91234
		private static IntPtr __Added_BB323FB84E3263466E0BEE98E1B3092A_NativeFunctionPtr;

		// Token: 0x04016463 RID: 91235
		private static IntPtr __Added_57B8397E4602013F2C15DF852515BD1D_NativeFunctionPtr;

		// Token: 0x04016464 RID: 91236
		private static IntPtr __Added_FDAE1367416FE117430C11803F232A8E_NativeFunctionPtr;

		// Token: 0x04016465 RID: 91237
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04016466 RID: 91238
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x04016467 RID: 91239
		private static IntPtr __CustomEvent_0_NativeFunctionPtr;

		// Token: 0x0200A43B RID: 42043
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __自动瞄准处理_FunctionParams
		{
			// Token: 0x0403227A RID: 205434
			[FieldOffset(0)]
			public bool 是否进入自动瞄准;
		}

		// Token: 0x0200A43C RID: 42044
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __EventReceived_18B59F5945020DB23C42FD88DC330F7F_FunctionParams
		{
			// Token: 0x0403227B RID: 205435
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x0200A43D RID: 42045
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_1653F7D946291B91D3E713A910288372_FunctionParams
		{
			// Token: 0x0403227C RID: 205436
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A43E RID: 42046
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __EventReceived_18B59F5945020DB23C42FD8891F18A29_FunctionParams
		{
			// Token: 0x0403227D RID: 205437
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x0200A43F RID: 42047
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_2871C22A44665795BF80D78EEE1213F4_FunctionParams
		{
			// Token: 0x0403227E RID: 205438
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A440 RID: 42048
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_BEBCE37F4E1B69E39F534EBBC1B1FEE7_FunctionParams
		{
			// Token: 0x0403227F RID: 205439
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A441 RID: 42049
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_BB323FB84E3263466E0BEE98E1B3092A_FunctionParams
		{
			// Token: 0x04032280 RID: 205440
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A442 RID: 42050
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_57B8397E4602013F2C15DF852515BD1D_FunctionParams
		{
			// Token: 0x04032281 RID: 205441
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A443 RID: 42051
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_FDAE1367416FE117430C11803F232A8E_FunctionParams
		{
			// Token: 0x04032282 RID: 205442
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A444 RID: 42052
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032283 RID: 205443
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
