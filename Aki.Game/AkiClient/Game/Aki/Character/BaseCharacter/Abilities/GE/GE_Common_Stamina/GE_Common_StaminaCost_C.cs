using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_Stamina
{
	// Token: 0x02004406 RID: 17414
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_Common_StaminaCost.GE_Common_StaminaCost_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Common_StaminaCost_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D114 RID: 184596 RVA: 0x00A30260 File Offset: 0x00A2E460
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Common_StaminaCost_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_Common_StaminaCost.GE_Common_StaminaCost_C");
			}
			return GE_Common_StaminaCost_C._ClassPtr;
		}

		// Token: 0x0602D115 RID: 184597 RVA: 0x00A30284 File Offset: 0x00A2E484
		public GE_Common_StaminaCost_C() : this(BuiltinUtils.AllocNativeUObject(GE_Common_StaminaCost_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D116 RID: 184598 RVA: 0x00A302AC File Offset: 0x00A2E4AC
		[NullableContext(1)]
		public GE_Common_StaminaCost_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Common_StaminaCost_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D117 RID: 184599 RVA: 0x00A302DF File Offset: 0x00A2E4DF
		protected GE_Common_StaminaCost_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017EC6 RID: 97990
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Stamina/GE_Common_StaminaCost.GE_Common_StaminaCost_C";

		// Token: 0x04017EC7 RID: 97991
		private static IntPtr _ClassPtr;

		// Token: 0x04017EC8 RID: 97992
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
