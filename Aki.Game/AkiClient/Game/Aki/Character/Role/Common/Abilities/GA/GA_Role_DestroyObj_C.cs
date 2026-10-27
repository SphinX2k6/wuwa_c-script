using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x0200414F RID: 16719
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_DestroyObj.GA_Role_DestroyObj_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class GA_Role_DestroyObj_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B1C4 RID: 176580 RVA: 0x009F6276 File Offset: 0x009F4476
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Role_DestroyObj_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_DestroyObj.GA_Role_DestroyObj_C");
			}
			return GA_Role_DestroyObj_C._ClassPtr;
		}

		// Token: 0x0602B1C5 RID: 176581 RVA: 0x009F629C File Offset: 0x009F449C
		public GA_Role_DestroyObj_C() : this(BuiltinUtils.AllocNativeUObject(GA_Role_DestroyObj_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B1C6 RID: 176582 RVA: 0x009F62C4 File Offset: 0x009F44C4
		[NullableContext(1)]
		public GA_Role_DestroyObj_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Role_DestroyObj_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602B1C7 RID: 176583 RVA: 0x009F62F7 File Offset: 0x009F44F7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_DestroyObj_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B1C8 RID: 176584 RVA: 0x009F630B File Offset: 0x009F450B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_DestroyObj_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B1C9 RID: 176585 RVA: 0x009F6320 File Offset: 0x009F4520
		protected GA_Role_DestroyObj_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401660B RID: 91659
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_DestroyObj.GA_Role_DestroyObj_C";

		// Token: 0x0401660C RID: 91660
		private static IntPtr _ClassPtr;

		// Token: 0x0401660D RID: 91661
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401660E RID: 91662
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;
	}
}
