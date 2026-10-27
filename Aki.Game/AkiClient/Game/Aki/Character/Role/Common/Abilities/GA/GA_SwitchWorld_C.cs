using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x0200417F RID: 16767
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_SwitchWorld.GA_SwitchWorld_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class GA_SwitchWorld_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B6AA RID: 177834 RVA: 0x00A0006D File Offset: 0x009FE26D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_SwitchWorld_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_SwitchWorld.GA_SwitchWorld_C");
			}
			return GA_SwitchWorld_C._ClassPtr;
		}

		// Token: 0x0602B6AB RID: 177835 RVA: 0x00A00094 File Offset: 0x009FE294
		public GA_SwitchWorld_C() : this(BuiltinUtils.AllocNativeUObject(GA_SwitchWorld_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B6AC RID: 177836 RVA: 0x00A000BC File Offset: 0x009FE2BC
		[NullableContext(1)]
		public GA_SwitchWorld_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_SwitchWorld_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602B6AD RID: 177837 RVA: 0x00A000EF File Offset: 0x009FE2EF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SwitchWorld_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B6AE RID: 177838 RVA: 0x00A00103 File Offset: 0x009FE303
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_SwitchWorld_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B6AF RID: 177839 RVA: 0x00A00118 File Offset: 0x009FE318
		protected GA_SwitchWorld_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016982 RID: 92546
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_SwitchWorld.GA_SwitchWorld_C";

		// Token: 0x04016983 RID: 92547
		private static IntPtr _ClassPtr;

		// Token: 0x04016984 RID: 92548
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016985 RID: 92549
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;
	}
}
