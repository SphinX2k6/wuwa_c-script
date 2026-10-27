using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using AkiClient.Game.Aki.Character.Vehicle.Motor;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x02004147 RID: 16711
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Motor_GetOn.GA_Motor_GetOn_C")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1524)]
	public class GA_Motor_GetOn_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B150 RID: 176464 RVA: 0x009F5508 File Offset: 0x009F3708
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_GetOn_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Motor_GetOn.GA_Motor_GetOn_C");
			}
			return GA_Motor_GetOn_C._ClassPtr;
		}

		// Token: 0x0602B151 RID: 176465 RVA: 0x009F552C File Offset: 0x009F372C
		public GA_Motor_GetOn_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_GetOn_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B152 RID: 176466 RVA: 0x009F5554 File Offset: 0x009F3754
		[NullableContext(1)]
		public GA_Motor_GetOn_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_GetOn_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A14 RID: 27156
		// (get) Token: 0x0602B153 RID: 176467 RVA: 0x009F5587 File Offset: 0x009F3787
		// (set) Token: 0x0602B154 RID: 176468 RVA: 0x009F559B File Offset: 0x009F379B
		[Nullable(2)]
		public unsafe BP_Motor_BaseVehicle_C 摩托车对象缓存
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_Motor_BaseVehicle_C>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_GetOn_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_GetOn_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006A15 RID: 27157
		// (get) Token: 0x0602B155 RID: 176469 RVA: 0x009F55B0 File Offset: 0x009F37B0
		// (set) Token: 0x0602B156 RID: 176470 RVA: 0x009F55C0 File Offset: 0x009F37C0
		public unsafe int 摩托车对象entity_Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_GetOn_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_GetOn_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x0602B157 RID: 176471 RVA: 0x009F55D1 File Offset: 0x009F37D1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E817DB48968()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_GetOn_C.__OnTick_5D118C384AE61F1C80292E817DB48968_NativeFunctionPtr, null);
		}

		// Token: 0x0602B158 RID: 176472 RVA: 0x009F55E5 File Offset: 0x009F37E5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E817DB48968()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_GetOn_C.__OnCancelled_5D118C384AE61F1C80292E817DB48968_NativeFunctionPtr, null);
		}

		// Token: 0x0602B159 RID: 176473 RVA: 0x009F55F9 File Offset: 0x009F37F9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E817DB48968()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_GetOn_C.__OnInterrupted_5D118C384AE61F1C80292E817DB48968_NativeFunctionPtr, null);
		}

		// Token: 0x0602B15A RID: 176474 RVA: 0x009F560D File Offset: 0x009F380D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E817DB48968()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_GetOn_C.__OnBlendOut_5D118C384AE61F1C80292E817DB48968_NativeFunctionPtr, null);
		}

		// Token: 0x0602B15B RID: 176475 RVA: 0x009F5621 File Offset: 0x009F3821
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E817DB48968()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_GetOn_C.__OnCompleted_5D118C384AE61F1C80292E817DB48968_NativeFunctionPtr, null);
		}

		// Token: 0x0602B15C RID: 176476 RVA: 0x009F5635 File Offset: 0x009F3835
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_GetOn_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B15D RID: 176477 RVA: 0x009F5649 File Offset: 0x009F3849
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_GetOn_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B15E RID: 176478 RVA: 0x009F5660 File Offset: 0x009F3860
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_GetOn_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_GetOn_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_GetOn_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_GetOn_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_GetOn_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B15F RID: 176479 RVA: 0x009F56A8 File Offset: 0x009F38A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_GetOn_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_GetOn_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_GetOn_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_GetOn_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_GetOn_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B160 RID: 176480 RVA: 0x009F56EF File Offset: 0x009F38EF
		protected GA_Motor_GetOn_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040165BE RID: 91582
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Motor_GetOn.GA_Motor_GetOn_C";

		// Token: 0x040165BF RID: 91583
		private static IntPtr _ClassPtr;

		// Token: 0x040165C0 RID: 91584
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040165C1 RID: 91585
		internal new static int __PropertyOffset_1;

		// Token: 0x040165C2 RID: 91586
		internal new static int __PropertyOffset_2;

		// Token: 0x040165C3 RID: 91587
		private static IntPtr __OnTick_5D118C384AE61F1C80292E817DB48968_NativeFunctionPtr;

		// Token: 0x040165C4 RID: 91588
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E817DB48968_NativeFunctionPtr;

		// Token: 0x040165C5 RID: 91589
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E817DB48968_NativeFunctionPtr;

		// Token: 0x040165C6 RID: 91590
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E817DB48968_NativeFunctionPtr;

		// Token: 0x040165C7 RID: 91591
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E817DB48968_NativeFunctionPtr;

		// Token: 0x040165C8 RID: 91592
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x040165C9 RID: 91593
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A47A RID: 42106
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040322C9 RID: 205513
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
