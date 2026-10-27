using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x02004156 RID: 16726
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_GamePlayScan.GA_Role_GamePlayScan_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class GA_Role_GamePlayScan_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B2F7 RID: 176887 RVA: 0x009F83F1 File Offset: 0x009F65F1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Role_GamePlayScan_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_GamePlayScan.GA_Role_GamePlayScan_C");
			}
			return GA_Role_GamePlayScan_C._ClassPtr;
		}

		// Token: 0x0602B2F8 RID: 176888 RVA: 0x009F8418 File Offset: 0x009F6618
		public GA_Role_GamePlayScan_C() : this(BuiltinUtils.AllocNativeUObject(GA_Role_GamePlayScan_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B2F9 RID: 176889 RVA: 0x009F8440 File Offset: 0x009F6640
		[NullableContext(1)]
		public GA_Role_GamePlayScan_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Role_GamePlayScan_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602B2FA RID: 176890 RVA: 0x009F8473 File Offset: 0x009F6673
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_GamePlayScan_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B2FB RID: 176891 RVA: 0x009F8487 File Offset: 0x009F6687
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_GamePlayScan_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B2FC RID: 176892 RVA: 0x009F849C File Offset: 0x009F669C
		protected GA_Role_GamePlayScan_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040166DF RID: 91871
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_GamePlayScan.GA_Role_GamePlayScan_C";

		// Token: 0x040166E0 RID: 91872
		private static IntPtr _ClassPtr;

		// Token: 0x040166E1 RID: 91873
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040166E2 RID: 91874
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;
	}
}
