using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x02004166 RID: 16742
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_TransportObj.GA_Role_TransportObj_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class GA_Role_TransportObj_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B4C3 RID: 177347 RVA: 0x009FBF2D File Offset: 0x009FA12D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Role_TransportObj_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_TransportObj.GA_Role_TransportObj_C");
			}
			return GA_Role_TransportObj_C._ClassPtr;
		}

		// Token: 0x0602B4C4 RID: 177348 RVA: 0x009FBF54 File Offset: 0x009FA154
		public GA_Role_TransportObj_C() : this(BuiltinUtils.AllocNativeUObject(GA_Role_TransportObj_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B4C5 RID: 177349 RVA: 0x009FBF7C File Offset: 0x009FA17C
		[NullableContext(1)]
		public GA_Role_TransportObj_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Role_TransportObj_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602B4C6 RID: 177350 RVA: 0x009FBFAF File Offset: 0x009FA1AF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_TransportObj_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B4C7 RID: 177351 RVA: 0x009FBFC3 File Offset: 0x009FA1C3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_TransportObj_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B4C8 RID: 177352 RVA: 0x009FBFD8 File Offset: 0x009FA1D8
		protected GA_Role_TransportObj_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016822 RID: 92194
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_TransportObj.GA_Role_TransportObj_C";

		// Token: 0x04016823 RID: 92195
		private static IntPtr _ClassPtr;

		// Token: 0x04016824 RID: 92196
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016825 RID: 92197
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;
	}
}
