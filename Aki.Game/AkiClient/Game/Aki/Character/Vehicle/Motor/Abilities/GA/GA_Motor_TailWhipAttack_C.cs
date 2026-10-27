using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Abilities.GA
{
	// Token: 0x0200408E RID: 16526
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_TailWhipAttack.GA_Motor_TailWhipAttack_C")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1525)]
	public class GA_Motor_TailWhipAttack_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A8C7 RID: 174279 RVA: 0x009E3FD0 File Offset: 0x009E21D0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_TailWhipAttack_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_TailWhipAttack.GA_Motor_TailWhipAttack_C");
			}
			return GA_Motor_TailWhipAttack_C._ClassPtr;
		}

		// Token: 0x0602A8C8 RID: 174280 RVA: 0x009E3FF4 File Offset: 0x009E21F4
		public GA_Motor_TailWhipAttack_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_TailWhipAttack_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A8C9 RID: 174281 RVA: 0x009E401C File Offset: 0x009E221C
		[NullableContext(1)]
		public GA_Motor_TailWhipAttack_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_TailWhipAttack_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700684E RID: 26702
		// (get) Token: 0x0602A8CA RID: 174282 RVA: 0x009E404F File Offset: 0x009E224F
		// (set) Token: 0x0602A8CB RID: 174283 RVA: 0x009E4063 File Offset: 0x009E2263
		public unsafe FRotator x轴清零旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_TailWhipAttack_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_TailWhipAttack_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700684F RID: 26703
		// (get) Token: 0x0602A8CC RID: 174284 RVA: 0x009E4078 File Offset: 0x009E2278
		// (set) Token: 0x0602A8CD RID: 174285 RVA: 0x009E4088 File Offset: 0x009E2288
		public unsafe bool 重力不平行摩托朝向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_TailWhipAttack_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_TailWhipAttack_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602A8CE RID: 174286 RVA: 0x009E4099 File Offset: 0x009E2299
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09B69F3D2A9()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_TailWhipAttack_C.__OnTick_CF946D5D4EFE5E5564EFF09B69F3D2A9_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8CF RID: 174287 RVA: 0x009E40AD File Offset: 0x009E22AD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09B69F3D2A9()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_TailWhipAttack_C.__OnCancelled_CF946D5D4EFE5E5564EFF09B69F3D2A9_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8D0 RID: 174288 RVA: 0x009E40C1 File Offset: 0x009E22C1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09B69F3D2A9()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_TailWhipAttack_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09B69F3D2A9_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8D1 RID: 174289 RVA: 0x009E40D5 File Offset: 0x009E22D5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09B69F3D2A9()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_TailWhipAttack_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09B69F3D2A9_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8D2 RID: 174290 RVA: 0x009E40E9 File Offset: 0x009E22E9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09B69F3D2A9()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_TailWhipAttack_C.__OnCompleted_CF946D5D4EFE5E5564EFF09B69F3D2A9_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8D3 RID: 174291 RVA: 0x009E40FD File Offset: 0x009E22FD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09B304CB930()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_TailWhipAttack_C.__OnTick_CF946D5D4EFE5E5564EFF09B304CB930_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8D4 RID: 174292 RVA: 0x009E4111 File Offset: 0x009E2311
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09B304CB930()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_TailWhipAttack_C.__OnCancelled_CF946D5D4EFE5E5564EFF09B304CB930_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8D5 RID: 174293 RVA: 0x009E4125 File Offset: 0x009E2325
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09B304CB930()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_TailWhipAttack_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09B304CB930_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8D6 RID: 174294 RVA: 0x009E4139 File Offset: 0x009E2339
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09B304CB930()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_TailWhipAttack_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09B304CB930_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8D7 RID: 174295 RVA: 0x009E414D File Offset: 0x009E234D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09B304CB930()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_TailWhipAttack_C.__OnCompleted_CF946D5D4EFE5E5564EFF09B304CB930_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8D8 RID: 174296 RVA: 0x009E4161 File Offset: 0x009E2361
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_TailWhipAttack_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8D9 RID: 174297 RVA: 0x009E4175 File Offset: 0x009E2375
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_TailWhipAttack_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A8DA RID: 174298 RVA: 0x009E418A File Offset: 0x009E238A
		protected GA_Motor_TailWhipAttack_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015FF5 RID: 90101
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_TailWhipAttack.GA_Motor_TailWhipAttack_C";

		// Token: 0x04015FF6 RID: 90102
		private static IntPtr _ClassPtr;

		// Token: 0x04015FF7 RID: 90103
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015FF8 RID: 90104
		internal new static int __PropertyOffset_1;

		// Token: 0x04015FF9 RID: 90105
		internal new static int __PropertyOffset_2;

		// Token: 0x04015FFA RID: 90106
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09B69F3D2A9_NativeFunctionPtr;

		// Token: 0x04015FFB RID: 90107
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09B69F3D2A9_NativeFunctionPtr;

		// Token: 0x04015FFC RID: 90108
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09B69F3D2A9_NativeFunctionPtr;

		// Token: 0x04015FFD RID: 90109
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09B69F3D2A9_NativeFunctionPtr;

		// Token: 0x04015FFE RID: 90110
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09B69F3D2A9_NativeFunctionPtr;

		// Token: 0x04015FFF RID: 90111
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09B304CB930_NativeFunctionPtr;

		// Token: 0x04016000 RID: 90112
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09B304CB930_NativeFunctionPtr;

		// Token: 0x04016001 RID: 90113
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09B304CB930_NativeFunctionPtr;

		// Token: 0x04016002 RID: 90114
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09B304CB930_NativeFunctionPtr;

		// Token: 0x04016003 RID: 90115
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09B304CB930_NativeFunctionPtr;

		// Token: 0x04016004 RID: 90116
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;
	}
}
