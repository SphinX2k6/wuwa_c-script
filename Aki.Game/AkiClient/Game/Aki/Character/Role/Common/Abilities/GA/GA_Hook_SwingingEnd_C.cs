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
	// Token: 0x02004135 RID: 16693
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Hook_SwingingEnd.GA_Hook_SwingingEnd_C")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1524)]
	public class GA_Hook_SwingingEnd_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B066 RID: 176230 RVA: 0x009F34C8 File Offset: 0x009F16C8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Hook_SwingingEnd_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Hook_SwingingEnd.GA_Hook_SwingingEnd_C");
			}
			return GA_Hook_SwingingEnd_C._ClassPtr;
		}

		// Token: 0x0602B067 RID: 176231 RVA: 0x009F34EC File Offset: 0x009F16EC
		public GA_Hook_SwingingEnd_C() : this(BuiltinUtils.AllocNativeUObject(GA_Hook_SwingingEnd_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B068 RID: 176232 RVA: 0x009F3514 File Offset: 0x009F1714
		[NullableContext(1)]
		public GA_Hook_SwingingEnd_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Hook_SwingingEnd_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A05 RID: 27141
		// (get) Token: 0x0602B069 RID: 176233 RVA: 0x009F3547 File Offset: 0x009F1747
		// (set) Token: 0x0602B06A RID: 176234 RVA: 0x009F355B File Offset: 0x009F175B
		public unsafe FVector 摆荡基础速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Hook_SwingingEnd_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Hook_SwingingEnd_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x0602B06B RID: 176235 RVA: 0x009F3570 File Offset: 0x009F1770
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E8136286539()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Hook_SwingingEnd_C.__OnTick_5D118C384AE61F1C80292E8136286539_NativeFunctionPtr, null);
		}

		// Token: 0x0602B06C RID: 176236 RVA: 0x009F3584 File Offset: 0x009F1784
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E8136286539()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Hook_SwingingEnd_C.__OnCancelled_5D118C384AE61F1C80292E8136286539_NativeFunctionPtr, null);
		}

		// Token: 0x0602B06D RID: 176237 RVA: 0x009F3598 File Offset: 0x009F1798
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E8136286539()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Hook_SwingingEnd_C.__OnInterrupted_5D118C384AE61F1C80292E8136286539_NativeFunctionPtr, null);
		}

		// Token: 0x0602B06E RID: 176238 RVA: 0x009F35AC File Offset: 0x009F17AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E8136286539()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Hook_SwingingEnd_C.__OnBlendOut_5D118C384AE61F1C80292E8136286539_NativeFunctionPtr, null);
		}

		// Token: 0x0602B06F RID: 176239 RVA: 0x009F35C0 File Offset: 0x009F17C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E8136286539()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Hook_SwingingEnd_C.__OnCompleted_5D118C384AE61F1C80292E8136286539_NativeFunctionPtr, null);
		}

		// Token: 0x0602B070 RID: 176240 RVA: 0x009F35D4 File Offset: 0x009F17D4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EventReceived_395B7D3941A9DA8F2A9D14B334F75D10(FGameplayEventData Payload)
		{
			GA_Hook_SwingingEnd_C.__EventReceived_395B7D3941A9DA8F2A9D14B334F75D10_FunctionParams* ptr = stackalloc GA_Hook_SwingingEnd_C.__EventReceived_395B7D3941A9DA8F2A9D14B334F75D10_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(GA_Hook_SwingingEnd_C.__EventReceived_395B7D3941A9DA8F2A9D14B334F75D10_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Hook_SwingingEnd_C.__EventReceived_395B7D3941A9DA8F2A9D14B334F75D10_NativeFunctionPtr, (void*)ptr, 1);
			if (Payload != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEventData.StaticStruct(), &ptr->Payload, Payload.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Hook_SwingingEnd_C.__EventReceived_395B7D3941A9DA8F2A9D14B334F75D10_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Hook_SwingingEnd_C.__EventReceived_395B7D3941A9DA8F2A9D14B334F75D10_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602B071 RID: 176241 RVA: 0x009F364C File Offset: 0x009F184C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_54E5FB1C47764D94BD245DAB78EF78CB(in FGameplayTag Tag)
		{
			GA_Hook_SwingingEnd_C.__Added_54E5FB1C47764D94BD245DAB78EF78CB_FunctionParams* ptr = stackalloc GA_Hook_SwingingEnd_C.__Added_54E5FB1C47764D94BD245DAB78EF78CB_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Hook_SwingingEnd_C.__Added_54E5FB1C47764D94BD245DAB78EF78CB_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Hook_SwingingEnd_C.__Added_54E5FB1C47764D94BD245DAB78EF78CB_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Hook_SwingingEnd_C.__Added_54E5FB1C47764D94BD245DAB78EF78CB_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B072 RID: 176242 RVA: 0x009F3698 File Offset: 0x009F1898
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Hook_SwingingEnd_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Hook_SwingingEnd_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Hook_SwingingEnd_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Hook_SwingingEnd_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Hook_SwingingEnd_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B073 RID: 176243 RVA: 0x009F36E0 File Offset: 0x009F18E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Hook_SwingingEnd_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Hook_SwingingEnd_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Hook_SwingingEnd_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Hook_SwingingEnd_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Hook_SwingingEnd_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B074 RID: 176244 RVA: 0x009F3727 File Offset: 0x009F1927
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Hook_SwingingEnd_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B075 RID: 176245 RVA: 0x009F373B File Offset: 0x009F193B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Hook_SwingingEnd_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B076 RID: 176246 RVA: 0x009F3750 File Offset: 0x009F1950
		protected GA_Hook_SwingingEnd_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016513 RID: 91411
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Hook_SwingingEnd.GA_Hook_SwingingEnd_C";

		// Token: 0x04016514 RID: 91412
		private static IntPtr _ClassPtr;

		// Token: 0x04016515 RID: 91413
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016516 RID: 91414
		internal new static int __PropertyOffset_1;

		// Token: 0x04016517 RID: 91415
		private static IntPtr __OnTick_5D118C384AE61F1C80292E8136286539_NativeFunctionPtr;

		// Token: 0x04016518 RID: 91416
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E8136286539_NativeFunctionPtr;

		// Token: 0x04016519 RID: 91417
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E8136286539_NativeFunctionPtr;

		// Token: 0x0401651A RID: 91418
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E8136286539_NativeFunctionPtr;

		// Token: 0x0401651B RID: 91419
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E8136286539_NativeFunctionPtr;

		// Token: 0x0401651C RID: 91420
		private static IntPtr __EventReceived_395B7D3941A9DA8F2A9D14B334F75D10_NativeFunctionPtr;

		// Token: 0x0401651D RID: 91421
		private static IntPtr __Added_54E5FB1C47764D94BD245DAB78EF78CB_NativeFunctionPtr;

		// Token: 0x0401651E RID: 91422
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0401651F RID: 91423
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0200A461 RID: 42081
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __EventReceived_395B7D3941A9DA8F2A9D14B334F75D10_FunctionParams
		{
			// Token: 0x040322A5 RID: 205477
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x0200A462 RID: 42082
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_54E5FB1C47764D94BD245DAB78EF78CB_FunctionParams
		{
			// Token: 0x040322A6 RID: 205478
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A463 RID: 42083
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040322A7 RID: 205479
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
