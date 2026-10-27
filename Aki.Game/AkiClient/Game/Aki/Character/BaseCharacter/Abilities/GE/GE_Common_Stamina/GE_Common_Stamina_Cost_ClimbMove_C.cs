using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_Stamina
{
	// Token: 0x0200440A RID: 17418
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_Common_Stamina_Cost_ClimbMove.GE_Common_Stamina_Cost_ClimbMove_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Common_Stamina_Cost_ClimbMove_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D124 RID: 184612 RVA: 0x00A30480 File Offset: 0x00A2E680
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Common_Stamina_Cost_ClimbMove_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_Common_Stamina_Cost_ClimbMove.GE_Common_Stamina_Cost_ClimbMove_C");
			}
			return GE_Common_Stamina_Cost_ClimbMove_C._ClassPtr;
		}

		// Token: 0x0602D125 RID: 184613 RVA: 0x00A304A4 File Offset: 0x00A2E6A4
		public GE_Common_Stamina_Cost_ClimbMove_C() : this(BuiltinUtils.AllocNativeUObject(GE_Common_Stamina_Cost_ClimbMove_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D126 RID: 184614 RVA: 0x00A304CC File Offset: 0x00A2E6CC
		[NullableContext(1)]
		public GE_Common_Stamina_Cost_ClimbMove_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Common_Stamina_Cost_ClimbMove_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D127 RID: 184615 RVA: 0x00A304FF File Offset: 0x00A2E6FF
		protected GE_Common_Stamina_Cost_ClimbMove_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017ED2 RID: 98002
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_Common_Stamina_Cost_ClimbMove.GE_Common_Stamina_Cost_ClimbMove_C";

		// Token: 0x04017ED3 RID: 98003
		private static IntPtr _ClassPtr;

		// Token: 0x04017ED4 RID: 98004
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
