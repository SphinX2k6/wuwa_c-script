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
	// Token: 0x02004159 RID: 16729
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_Hook.GA_Role_Hook_C")]
	[UnrealStructLayout(1576, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1576)]
	public class GA_Role_Hook_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B325 RID: 176933 RVA: 0x009F8A11 File Offset: 0x009F6C11
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Role_Hook_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_Hook.GA_Role_Hook_C");
			}
			return GA_Role_Hook_C._ClassPtr;
		}

		// Token: 0x0602B326 RID: 176934 RVA: 0x009F8A38 File Offset: 0x009F6C38
		public GA_Role_Hook_C() : this(BuiltinUtils.AllocNativeUObject(GA_Role_Hook_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B327 RID: 176935 RVA: 0x009F8A60 File Offset: 0x009F6C60
		[NullableContext(1)]
		public GA_Role_Hook_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Role_Hook_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A7C RID: 27260
		// (get) Token: 0x0602B328 RID: 176936 RVA: 0x009F8A93 File Offset: 0x009F6C93
		// (set) Token: 0x0602B329 RID: 176937 RVA: 0x009F8AA7 File Offset: 0x009F6CA7
		[Nullable(2)]
		public unsafe TsBaseCharacter 角色
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_Hook_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_Hook_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006A7D RID: 27261
		// (get) Token: 0x0602B32A RID: 176938 RVA: 0x009F8ABC File Offset: 0x009F6CBC
		// (set) Token: 0x0602B32B RID: 176939 RVA: 0x009F8AD0 File Offset: 0x009F6CD0
		public unsafe FVector Forward
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_Hook_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_Hook_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006A7E RID: 27262
		// (get) Token: 0x0602B32C RID: 176940 RVA: 0x009F8AE5 File Offset: 0x009F6CE5
		// (set) Token: 0x0602B32D RID: 176941 RVA: 0x009F8AF9 File Offset: 0x009F6CF9
		public unsafe FVector EndPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_Hook_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_Hook_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006A7F RID: 27263
		// (get) Token: 0x0602B32E RID: 176942 RVA: 0x009F8B0E File Offset: 0x009F6D0E
		// (set) Token: 0x0602B32F RID: 176943 RVA: 0x009F8B1E File Offset: 0x009F6D1E
		public unsafe bool InWater
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_Hook_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_Hook_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A80 RID: 27264
		// (get) Token: 0x0602B330 RID: 176944 RVA: 0x009F8B2F File Offset: 0x009F6D2F
		// (set) Token: 0x0602B331 RID: 176945 RVA: 0x009F8B43 File Offset: 0x009F6D43
		public unsafe FVectorDouble LastLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_Hook_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_Hook_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x0602B332 RID: 176946 RVA: 0x009F8B58 File Offset: 0x009F6D58
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EventReceived_BE49D8B84159B3E2C93AFC8C33E21F9B(FGameplayEventData Payload)
		{
			GA_Role_Hook_C.__EventReceived_BE49D8B84159B3E2C93AFC8C33E21F9B_FunctionParams* ptr = stackalloc GA_Role_Hook_C.__EventReceived_BE49D8B84159B3E2C93AFC8C33E21F9B_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(GA_Role_Hook_C.__EventReceived_BE49D8B84159B3E2C93AFC8C33E21F9B_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_Hook_C.__EventReceived_BE49D8B84159B3E2C93AFC8C33E21F9B_NativeFunctionPtr, (void*)ptr, 1);
			if (Payload != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEventData.StaticStruct(), &ptr->Payload, Payload.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Hook_C.__EventReceived_BE49D8B84159B3E2C93AFC8C33E21F9B_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Role_Hook_C.__EventReceived_BE49D8B84159B3E2C93AFC8C33E21F9B_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602B333 RID: 176947 RVA: 0x009F8BCD File Offset: 0x009F6DCD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E813209EC9F()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Hook_C.__OnTick_5D118C384AE61F1C80292E813209EC9F_NativeFunctionPtr, null);
		}

		// Token: 0x0602B334 RID: 176948 RVA: 0x009F8BE1 File Offset: 0x009F6DE1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E813209EC9F()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Hook_C.__OnCancelled_5D118C384AE61F1C80292E813209EC9F_NativeFunctionPtr, null);
		}

		// Token: 0x0602B335 RID: 176949 RVA: 0x009F8BF5 File Offset: 0x009F6DF5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E813209EC9F()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Hook_C.__OnInterrupted_5D118C384AE61F1C80292E813209EC9F_NativeFunctionPtr, null);
		}

		// Token: 0x0602B336 RID: 176950 RVA: 0x009F8C09 File Offset: 0x009F6E09
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E813209EC9F()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Hook_C.__OnBlendOut_5D118C384AE61F1C80292E813209EC9F_NativeFunctionPtr, null);
		}

		// Token: 0x0602B337 RID: 176951 RVA: 0x009F8C1D File Offset: 0x009F6E1D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E813209EC9F()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Hook_C.__OnCompleted_5D118C384AE61F1C80292E813209EC9F_NativeFunctionPtr, null);
		}

		// Token: 0x0602B338 RID: 176952 RVA: 0x009F8C31 File Offset: 0x009F6E31
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Hook_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B339 RID: 176953 RVA: 0x009F8C45 File Offset: 0x009F6E45
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_Hook_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B33A RID: 176954 RVA: 0x009F8C5C File Offset: 0x009F6E5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Role_Hook_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_Hook_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_Hook_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_Hook_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Hook_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B33B RID: 176955 RVA: 0x009F8CA4 File Offset: 0x009F6EA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Role_Hook_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_Hook_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_Hook_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_Hook_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_Hook_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B33C RID: 176956 RVA: 0x009F8CEB File Offset: 0x009F6EEB
		protected GA_Role_Hook_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016704 RID: 91908
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_Hook.GA_Role_Hook_C";

		// Token: 0x04016705 RID: 91909
		private static IntPtr _ClassPtr;

		// Token: 0x04016706 RID: 91910
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016707 RID: 91911
		internal new static int __PropertyOffset_1;

		// Token: 0x04016708 RID: 91912
		internal new static int __PropertyOffset_2;

		// Token: 0x04016709 RID: 91913
		internal new static int __PropertyOffset_3;

		// Token: 0x0401670A RID: 91914
		internal static int __PropertyOffset_4;

		// Token: 0x0401670B RID: 91915
		internal static int __PropertyOffset_5;

		// Token: 0x0401670C RID: 91916
		private static IntPtr __EventReceived_BE49D8B84159B3E2C93AFC8C33E21F9B_NativeFunctionPtr;

		// Token: 0x0401670D RID: 91917
		private static IntPtr __OnTick_5D118C384AE61F1C80292E813209EC9F_NativeFunctionPtr;

		// Token: 0x0401670E RID: 91918
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E813209EC9F_NativeFunctionPtr;

		// Token: 0x0401670F RID: 91919
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E813209EC9F_NativeFunctionPtr;

		// Token: 0x04016710 RID: 91920
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E813209EC9F_NativeFunctionPtr;

		// Token: 0x04016711 RID: 91921
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E813209EC9F_NativeFunctionPtr;

		// Token: 0x04016712 RID: 91922
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04016713 RID: 91923
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A49C RID: 42140
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __EventReceived_BE49D8B84159B3E2C93AFC8C33E21F9B_FunctionParams
		{
			// Token: 0x040322FA RID: 205562
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x0200A49D RID: 42141
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040322FB RID: 205563
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
