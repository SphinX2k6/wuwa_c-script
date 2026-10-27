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
	// Token: 0x02004087 RID: 16519
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_ShowVision.GA_Motor_ShowVision_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_Motor_ShowVision_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A852 RID: 174162 RVA: 0x009E310C File Offset: 0x009E130C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_ShowVision_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_ShowVision.GA_Motor_ShowVision_C");
			}
			return GA_Motor_ShowVision_C._ClassPtr;
		}

		// Token: 0x0602A853 RID: 174163 RVA: 0x009E3130 File Offset: 0x009E1330
		public GA_Motor_ShowVision_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_ShowVision_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A854 RID: 174164 RVA: 0x009E3158 File Offset: 0x009E1358
		[NullableContext(1)]
		public GA_Motor_ShowVision_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_ShowVision_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006842 RID: 26690
		// (get) Token: 0x0602A855 RID: 174165 RVA: 0x009E318B File Offset: 0x009E138B
		// (set) Token: 0x0602A856 RID: 174166 RVA: 0x009E319F File Offset: 0x009E139F
		[Nullable(2)]
		public unsafe AActor 被控物
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_ShowVision_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_ShowVision_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602A857 RID: 174167 RVA: 0x009E31B4 File Offset: 0x009E13B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_ShowVision_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A858 RID: 174168 RVA: 0x009E31C8 File Offset: 0x009E13C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_ShowVision_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A859 RID: 174169 RVA: 0x009E31E0 File Offset: 0x009E13E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_ShowVision_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_ShowVision_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_ShowVision_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_ShowVision_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_ShowVision_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A85A RID: 174170 RVA: 0x009E3228 File Offset: 0x009E1428
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_ShowVision_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_ShowVision_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_ShowVision_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_ShowVision_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_ShowVision_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A85B RID: 174171 RVA: 0x009E326F File Offset: 0x009E146F
		protected GA_Motor_ShowVision_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015F9C RID: 90012
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_ShowVision.GA_Motor_ShowVision_C";

		// Token: 0x04015F9D RID: 90013
		private static IntPtr _ClassPtr;

		// Token: 0x04015F9E RID: 90014
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015F9F RID: 90015
		internal new static int __PropertyOffset_1;

		// Token: 0x04015FA0 RID: 90016
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015FA1 RID: 90017
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A3C0 RID: 41920
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040321AD RID: 205229
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
