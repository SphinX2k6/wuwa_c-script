using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x0200414D RID: 16717
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_AimShoot.GA_Role_AimShoot_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class GA_Role_AimShoot_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B1B6 RID: 176566 RVA: 0x009F60E8 File Offset: 0x009F42E8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Role_AimShoot_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_AimShoot.GA_Role_AimShoot_C");
			}
			return GA_Role_AimShoot_C._ClassPtr;
		}

		// Token: 0x0602B1B7 RID: 176567 RVA: 0x009F610C File Offset: 0x009F430C
		public GA_Role_AimShoot_C() : this(BuiltinUtils.AllocNativeUObject(GA_Role_AimShoot_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B1B8 RID: 176568 RVA: 0x009F6134 File Offset: 0x009F4334
		[NullableContext(1)]
		public GA_Role_AimShoot_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Role_AimShoot_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602B1B9 RID: 176569 RVA: 0x009F6167 File Offset: 0x009F4367
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_AimShoot_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B1BA RID: 176570 RVA: 0x009F617B File Offset: 0x009F437B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_AimShoot_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B1BB RID: 176571 RVA: 0x009F6190 File Offset: 0x009F4390
		protected GA_Role_AimShoot_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016602 RID: 91650
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_AimShoot.GA_Role_AimShoot_C";

		// Token: 0x04016603 RID: 91651
		private static IntPtr _ClassPtr;

		// Token: 0x04016604 RID: 91652
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016605 RID: 91653
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;
	}
}
