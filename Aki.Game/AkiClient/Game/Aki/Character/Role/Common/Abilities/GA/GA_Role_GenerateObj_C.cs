using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x02004157 RID: 16727
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_GenerateObj.GA_Role_GenerateObj_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class GA_Role_GenerateObj_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B2FD RID: 176893 RVA: 0x009F84A5 File Offset: 0x009F66A5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Role_GenerateObj_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_GenerateObj.GA_Role_GenerateObj_C");
			}
			return GA_Role_GenerateObj_C._ClassPtr;
		}

		// Token: 0x0602B2FE RID: 176894 RVA: 0x009F84CC File Offset: 0x009F66CC
		public GA_Role_GenerateObj_C() : this(BuiltinUtils.AllocNativeUObject(GA_Role_GenerateObj_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B2FF RID: 176895 RVA: 0x009F84F4 File Offset: 0x009F66F4
		[NullableContext(1)]
		public GA_Role_GenerateObj_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Role_GenerateObj_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602B300 RID: 176896 RVA: 0x009F8527 File Offset: 0x009F6727
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_GenerateObj_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B301 RID: 176897 RVA: 0x009F853B File Offset: 0x009F673B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_GenerateObj_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B302 RID: 176898 RVA: 0x009F8550 File Offset: 0x009F6750
		protected GA_Role_GenerateObj_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040166E3 RID: 91875
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_GenerateObj.GA_Role_GenerateObj_C";

		// Token: 0x040166E4 RID: 91876
		private static IntPtr _ClassPtr;

		// Token: 0x040166E5 RID: 91877
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040166E6 RID: 91878
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;
	}
}
