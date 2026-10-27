using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x02004150 RID: 16720
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_Exchange.GA_Role_Exchange_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class GA_Role_Exchange_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B1CA RID: 176586 RVA: 0x009F6329 File Offset: 0x009F4529
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Role_Exchange_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_Exchange.GA_Role_Exchange_C");
			}
			return GA_Role_Exchange_C._ClassPtr;
		}

		// Token: 0x0602B1CB RID: 176587 RVA: 0x009F6350 File Offset: 0x009F4550
		public GA_Role_Exchange_C() : this(BuiltinUtils.AllocNativeUObject(GA_Role_Exchange_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B1CC RID: 176588 RVA: 0x009F6378 File Offset: 0x009F4578
		[NullableContext(1)]
		public GA_Role_Exchange_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Role_Exchange_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602B1CD RID: 176589 RVA: 0x009F63AB File Offset: 0x009F45AB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_F5022130490EA872D5F5AA989A337C9B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Exchange_C.__OnFinish_F5022130490EA872D5F5AA989A337C9B_NativeFunctionPtr, null);
		}

		// Token: 0x0602B1CE RID: 176590 RVA: 0x009F63BF File Offset: 0x009F45BF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Exchange_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B1CF RID: 176591 RVA: 0x009F63D3 File Offset: 0x009F45D3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_Exchange_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B1D0 RID: 176592 RVA: 0x009F63E8 File Offset: 0x009F45E8
		protected GA_Role_Exchange_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401660F RID: 91663
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_Exchange.GA_Role_Exchange_C";

		// Token: 0x04016610 RID: 91664
		private static IntPtr _ClassPtr;

		// Token: 0x04016611 RID: 91665
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016612 RID: 91666
		private static IntPtr __OnFinish_F5022130490EA872D5F5AA989A337C9B_NativeFunctionPtr;

		// Token: 0x04016613 RID: 91667
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;
	}
}
