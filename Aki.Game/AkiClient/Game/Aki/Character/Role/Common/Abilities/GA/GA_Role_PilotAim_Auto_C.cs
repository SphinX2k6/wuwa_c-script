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
	// Token: 0x02004160 RID: 16736
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_PilotAim_Auto.GA_Role_PilotAim_Auto_C")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1536)]
	public class GA_Role_PilotAim_Auto_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B3A0 RID: 177056 RVA: 0x009F9FBC File Offset: 0x009F81BC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Role_PilotAim_Auto_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_PilotAim_Auto.GA_Role_PilotAim_Auto_C");
			}
			return GA_Role_PilotAim_Auto_C._ClassPtr;
		}

		// Token: 0x0602B3A1 RID: 177057 RVA: 0x009F9FE0 File Offset: 0x009F81E0
		public GA_Role_PilotAim_Auto_C() : this(BuiltinUtils.AllocNativeUObject(GA_Role_PilotAim_Auto_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B3A2 RID: 177058 RVA: 0x009FA008 File Offset: 0x009F8208
		[NullableContext(1)]
		public GA_Role_PilotAim_Auto_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Role_PilotAim_Auto_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A83 RID: 27267
		// (get) Token: 0x0602B3A3 RID: 177059 RVA: 0x009FA03B File Offset: 0x009F823B
		// (set) Token: 0x0602B3A4 RID: 177060 RVA: 0x009FA04F File Offset: 0x009F824F
		[Nullable(2)]
		public unsafe TsBaseCharacter 施法者_0
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_PilotAim_Auto_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_PilotAim_Auto_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006A84 RID: 27268
		// (get) Token: 0x0602B3A5 RID: 177061 RVA: 0x009FA064 File Offset: 0x009F8264
		// (set) Token: 0x0602B3A6 RID: 177062 RVA: 0x009FA078 File Offset: 0x009F8278
		[Nullable(2)]
		public unsafe USkeletalMeshComponent PilotSkeletal
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_PilotAim_Auto_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_PilotAim_Auto_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17006A85 RID: 27269
		// (get) Token: 0x0602B3A7 RID: 177063 RVA: 0x009FA08D File Offset: 0x009F828D
		// (set) Token: 0x0602B3A8 RID: 177064 RVA: 0x009FA09D File Offset: 0x009F829D
		public unsafe bool IsThrow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotAim_Auto_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotAim_Auto_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A86 RID: 27270
		// (get) Token: 0x0602B3A9 RID: 177065 RVA: 0x009FA0AE File Offset: 0x009F82AE
		// (set) Token: 0x0602B3AA RID: 177066 RVA: 0x009FA0BE File Offset: 0x009F82BE
		public unsafe int 变身特效Handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotAim_Auto_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotAim_Auto_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x0602B3AB RID: 177067 RVA: 0x009FA0CF File Offset: 0x009F82CF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void onEndAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotAim_Auto_C.__onEndAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B3AC RID: 177068 RVA: 0x009FA0E3 File Offset: 0x009F82E3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void onBegin()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotAim_Auto_C.__onBegin_NativeFunctionPtr, null);
		}

		// Token: 0x0602B3AD RID: 177069 RVA: 0x009FA0F7 File Offset: 0x009F82F7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void AimTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotAim_Auto_C.__AimTick_NativeFunctionPtr, null);
		}

		// Token: 0x0602B3AE RID: 177070 RVA: 0x009FA10B File Offset: 0x009F830B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void AimStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotAim_Auto_C.__AimStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602B3AF RID: 177071 RVA: 0x009FA120 File Offset: 0x009F8320
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EventReceived_18B59F5945020DB23C42FD880D1BBE62(FGameplayEventData Payload)
		{
			GA_Role_PilotAim_Auto_C.__EventReceived_18B59F5945020DB23C42FD880D1BBE62_FunctionParams* ptr = stackalloc GA_Role_PilotAim_Auto_C.__EventReceived_18B59F5945020DB23C42FD880D1BBE62_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(GA_Role_PilotAim_Auto_C.__EventReceived_18B59F5945020DB23C42FD880D1BBE62_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_PilotAim_Auto_C.__EventReceived_18B59F5945020DB23C42FD880D1BBE62_NativeFunctionPtr, (void*)ptr, 1);
			if (Payload != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEventData.StaticStruct(), &ptr->Payload, Payload.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotAim_Auto_C.__EventReceived_18B59F5945020DB23C42FD880D1BBE62_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Role_PilotAim_Auto_C.__EventReceived_18B59F5945020DB23C42FD880D1BBE62_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602B3B0 RID: 177072 RVA: 0x009FA198 File Offset: 0x009F8398
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnNotifyEnd_80D1BE3544247D6E275C61916DB57E88(FName NotifyName)
		{
			GA_Role_PilotAim_Auto_C.__OnNotifyEnd_80D1BE3544247D6E275C61916DB57E88_FunctionParams* ptr = stackalloc GA_Role_PilotAim_Auto_C.__OnNotifyEnd_80D1BE3544247D6E275C61916DB57E88_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Role_PilotAim_Auto_C.__OnNotifyEnd_80D1BE3544247D6E275C61916DB57E88_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_PilotAim_Auto_C.__OnNotifyEnd_80D1BE3544247D6E275C61916DB57E88_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NotifyName = NotifyName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotAim_Auto_C.__OnNotifyEnd_80D1BE3544247D6E275C61916DB57E88_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B3B1 RID: 177073 RVA: 0x009FA1E0 File Offset: 0x009F83E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnNotifyBegin_80D1BE3544247D6E275C61916DB57E88(FName NotifyName)
		{
			GA_Role_PilotAim_Auto_C.__OnNotifyBegin_80D1BE3544247D6E275C61916DB57E88_FunctionParams* ptr = stackalloc GA_Role_PilotAim_Auto_C.__OnNotifyBegin_80D1BE3544247D6E275C61916DB57E88_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Role_PilotAim_Auto_C.__OnNotifyBegin_80D1BE3544247D6E275C61916DB57E88_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_PilotAim_Auto_C.__OnNotifyBegin_80D1BE3544247D6E275C61916DB57E88_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NotifyName = NotifyName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotAim_Auto_C.__OnNotifyBegin_80D1BE3544247D6E275C61916DB57E88_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B3B2 RID: 177074 RVA: 0x009FA228 File Offset: 0x009F8428
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnInterrupted_80D1BE3544247D6E275C61916DB57E88(FName NotifyName)
		{
			GA_Role_PilotAim_Auto_C.__OnInterrupted_80D1BE3544247D6E275C61916DB57E88_FunctionParams* ptr = stackalloc GA_Role_PilotAim_Auto_C.__OnInterrupted_80D1BE3544247D6E275C61916DB57E88_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Role_PilotAim_Auto_C.__OnInterrupted_80D1BE3544247D6E275C61916DB57E88_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_PilotAim_Auto_C.__OnInterrupted_80D1BE3544247D6E275C61916DB57E88_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NotifyName = NotifyName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotAim_Auto_C.__OnInterrupted_80D1BE3544247D6E275C61916DB57E88_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B3B3 RID: 177075 RVA: 0x009FA270 File Offset: 0x009F8470
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnBlendOut_80D1BE3544247D6E275C61916DB57E88(FName NotifyName)
		{
			GA_Role_PilotAim_Auto_C.__OnBlendOut_80D1BE3544247D6E275C61916DB57E88_FunctionParams* ptr = stackalloc GA_Role_PilotAim_Auto_C.__OnBlendOut_80D1BE3544247D6E275C61916DB57E88_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Role_PilotAim_Auto_C.__OnBlendOut_80D1BE3544247D6E275C61916DB57E88_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_PilotAim_Auto_C.__OnBlendOut_80D1BE3544247D6E275C61916DB57E88_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NotifyName = NotifyName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotAim_Auto_C.__OnBlendOut_80D1BE3544247D6E275C61916DB57E88_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B3B4 RID: 177076 RVA: 0x009FA2B8 File Offset: 0x009F84B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnCompleted_80D1BE3544247D6E275C61916DB57E88(FName NotifyName)
		{
			GA_Role_PilotAim_Auto_C.__OnCompleted_80D1BE3544247D6E275C61916DB57E88_FunctionParams* ptr = stackalloc GA_Role_PilotAim_Auto_C.__OnCompleted_80D1BE3544247D6E275C61916DB57E88_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Role_PilotAim_Auto_C.__OnCompleted_80D1BE3544247D6E275C61916DB57E88_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_PilotAim_Auto_C.__OnCompleted_80D1BE3544247D6E275C61916DB57E88_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NotifyName = NotifyName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotAim_Auto_C.__OnCompleted_80D1BE3544247D6E275C61916DB57E88_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B3B5 RID: 177077 RVA: 0x009FA2FE File Offset: 0x009F84FE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotAim_Auto_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B3B6 RID: 177078 RVA: 0x009FA312 File Offset: 0x009F8512
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_PilotAim_Auto_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B3B7 RID: 177079 RVA: 0x009FA328 File Offset: 0x009F8528
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Role_PilotAim_Auto_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_PilotAim_Auto_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_PilotAim_Auto_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_PilotAim_Auto_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotAim_Auto_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B3B8 RID: 177080 RVA: 0x009FA370 File Offset: 0x009F8570
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Role_PilotAim_Auto_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_PilotAim_Auto_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_PilotAim_Auto_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_PilotAim_Auto_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_PilotAim_Auto_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B3B9 RID: 177081 RVA: 0x009FA3B7 File Offset: 0x009F85B7
		protected GA_Role_PilotAim_Auto_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401675F RID: 91999
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_PilotAim_Auto.GA_Role_PilotAim_Auto_C";

		// Token: 0x04016760 RID: 92000
		private static IntPtr _ClassPtr;

		// Token: 0x04016761 RID: 92001
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016762 RID: 92002
		internal new static int __PropertyOffset_1;

		// Token: 0x04016763 RID: 92003
		internal new static int __PropertyOffset_2;

		// Token: 0x04016764 RID: 92004
		internal new static int __PropertyOffset_3;

		// Token: 0x04016765 RID: 92005
		internal static int __PropertyOffset_4;

		// Token: 0x04016766 RID: 92006
		private static IntPtr __onEndAbility_NativeFunctionPtr;

		// Token: 0x04016767 RID: 92007
		private static IntPtr __onBegin_NativeFunctionPtr;

		// Token: 0x04016768 RID: 92008
		private static IntPtr __AimTick_NativeFunctionPtr;

		// Token: 0x04016769 RID: 92009
		private static IntPtr __AimStart_NativeFunctionPtr;

		// Token: 0x0401676A RID: 92010
		private static IntPtr __EventReceived_18B59F5945020DB23C42FD880D1BBE62_NativeFunctionPtr;

		// Token: 0x0401676B RID: 92011
		private static IntPtr __OnNotifyEnd_80D1BE3544247D6E275C61916DB57E88_NativeFunctionPtr;

		// Token: 0x0401676C RID: 92012
		private static IntPtr __OnNotifyBegin_80D1BE3544247D6E275C61916DB57E88_NativeFunctionPtr;

		// Token: 0x0401676D RID: 92013
		private static IntPtr __OnInterrupted_80D1BE3544247D6E275C61916DB57E88_NativeFunctionPtr;

		// Token: 0x0401676E RID: 92014
		private static IntPtr __OnBlendOut_80D1BE3544247D6E275C61916DB57E88_NativeFunctionPtr;

		// Token: 0x0401676F RID: 92015
		private static IntPtr __OnCompleted_80D1BE3544247D6E275C61916DB57E88_NativeFunctionPtr;

		// Token: 0x04016770 RID: 92016
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04016771 RID: 92017
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A4B0 RID: 42160
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __EventReceived_18B59F5945020DB23C42FD880D1BBE62_FunctionParams
		{
			// Token: 0x04032316 RID: 205590
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x0200A4B1 RID: 42161
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OnNotifyEnd_80D1BE3544247D6E275C61916DB57E88_FunctionParams
		{
			// Token: 0x04032317 RID: 205591
			[FieldOffset(0)]
			public FName NotifyName;
		}

		// Token: 0x0200A4B2 RID: 42162
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OnNotifyBegin_80D1BE3544247D6E275C61916DB57E88_FunctionParams
		{
			// Token: 0x04032318 RID: 205592
			[FieldOffset(0)]
			public FName NotifyName;
		}

		// Token: 0x0200A4B3 RID: 42163
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OnInterrupted_80D1BE3544247D6E275C61916DB57E88_FunctionParams
		{
			// Token: 0x04032319 RID: 205593
			[FieldOffset(0)]
			public FName NotifyName;
		}

		// Token: 0x0200A4B4 RID: 42164
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OnBlendOut_80D1BE3544247D6E275C61916DB57E88_FunctionParams
		{
			// Token: 0x0403231A RID: 205594
			[FieldOffset(0)]
			public FName NotifyName;
		}

		// Token: 0x0200A4B5 RID: 42165
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OnCompleted_80D1BE3544247D6E275C61916DB57E88_FunctionParams
		{
			// Token: 0x0403231B RID: 205595
			[FieldOffset(0)]
			public FName NotifyName;
		}

		// Token: 0x0200A4B6 RID: 42166
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x0403231C RID: 205596
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
