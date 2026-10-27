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
	// Token: 0x02004063 RID: 16483
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_ChuangSong.GA_Motor_ChuangSong_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_Motor_ChuangSong_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A578 RID: 173432 RVA: 0x009DD860 File Offset: 0x009DBA60
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_ChuangSong_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_ChuangSong.GA_Motor_ChuangSong_C");
			}
			return GA_Motor_ChuangSong_C._ClassPtr;
		}

		// Token: 0x0602A579 RID: 173433 RVA: 0x009DD884 File Offset: 0x009DBA84
		public GA_Motor_ChuangSong_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_ChuangSong_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A57A RID: 173434 RVA: 0x009DD8AC File Offset: 0x009DBAAC
		[NullableContext(1)]
		public GA_Motor_ChuangSong_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_ChuangSong_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170067CC RID: 26572
		// (get) Token: 0x0602A57B RID: 173435 RVA: 0x009DD8DF File Offset: 0x009DBADF
		// (set) Token: 0x0602A57C RID: 173436 RVA: 0x009DD8F3 File Offset: 0x009DBAF3
		[Nullable(2)]
		public unsafe AActor 被控物
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_ChuangSong_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_ChuangSong_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602A57D RID: 173437 RVA: 0x009DD908 File Offset: 0x009DBB08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_ChuangSong_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A57E RID: 173438 RVA: 0x009DD91C File Offset: 0x009DBB1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_ChuangSong_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A57F RID: 173439 RVA: 0x009DD934 File Offset: 0x009DBB34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_ChuangSong_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_ChuangSong_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_ChuangSong_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_ChuangSong_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_ChuangSong_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A580 RID: 173440 RVA: 0x009DD97C File Offset: 0x009DBB7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_ChuangSong_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_ChuangSong_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_ChuangSong_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_ChuangSong_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_ChuangSong_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A581 RID: 173441 RVA: 0x009DD9C3 File Offset: 0x009DBBC3
		protected GA_Motor_ChuangSong_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D96 RID: 89494
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_ChuangSong.GA_Motor_ChuangSong_C";

		// Token: 0x04015D97 RID: 89495
		private static IntPtr _ClassPtr;

		// Token: 0x04015D98 RID: 89496
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015D99 RID: 89497
		internal new static int __PropertyOffset_1;

		// Token: 0x04015D9A RID: 89498
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015D9B RID: 89499
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A37B RID: 41851
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x0403215F RID: 205151
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
