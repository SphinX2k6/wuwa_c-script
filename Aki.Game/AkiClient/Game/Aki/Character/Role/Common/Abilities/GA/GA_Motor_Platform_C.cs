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
	// Token: 0x02004149 RID: 16713
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Motor_Platform.GA_Motor_Platform_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_Motor_Platform_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B173 RID: 176499 RVA: 0x009F599C File Offset: 0x009F3B9C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Platform_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Motor_Platform.GA_Motor_Platform_C");
			}
			return GA_Motor_Platform_C._ClassPtr;
		}

		// Token: 0x0602B174 RID: 176500 RVA: 0x009F59C0 File Offset: 0x009F3BC0
		public GA_Motor_Platform_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Platform_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B175 RID: 176501 RVA: 0x009F59E8 File Offset: 0x009F3BE8
		[NullableContext(1)]
		public GA_Motor_Platform_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Platform_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A1A RID: 27162
		// (get) Token: 0x0602B176 RID: 176502 RVA: 0x009F5A1B File Offset: 0x009F3C1B
		// (set) Token: 0x0602B177 RID: 176503 RVA: 0x009F5A2F File Offset: 0x009F3C2F
		[Nullable(2)]
		public unsafe BP_Motor_BaseVehicle_C 摩托车对象缓存
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_Motor_BaseVehicle_C>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Platform_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Platform_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602B178 RID: 176504 RVA: 0x009F5A44 File Offset: 0x009F3C44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_Platform_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Platform_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Platform_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Platform_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Platform_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B179 RID: 176505 RVA: 0x009F5A8C File Offset: 0x009F3C8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_Platform_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Platform_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Platform_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Platform_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Platform_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B17A RID: 176506 RVA: 0x009F5AD3 File Offset: 0x009F3CD3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Platform_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B17B RID: 176507 RVA: 0x009F5AE7 File Offset: 0x009F3CE7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Platform_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B17C RID: 176508 RVA: 0x009F5AFC File Offset: 0x009F3CFC
		protected GA_Motor_Platform_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040165D5 RID: 91605
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Motor_Platform.GA_Motor_Platform_C";

		// Token: 0x040165D6 RID: 91606
		private static IntPtr _ClassPtr;

		// Token: 0x040165D7 RID: 91607
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040165D8 RID: 91608
		internal new static int __PropertyOffset_1;

		// Token: 0x040165D9 RID: 91609
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x040165DA RID: 91610
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0200A47E RID: 42110
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040322D0 RID: 205520
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
