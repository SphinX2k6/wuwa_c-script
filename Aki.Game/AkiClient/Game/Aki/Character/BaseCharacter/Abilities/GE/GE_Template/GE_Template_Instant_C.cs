using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Template
{
	// Token: 0x020043EA RID: 17386
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Template/GE_Template_Instant.GE_Template_Instant_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Template_Instant_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D09E RID: 184478 RVA: 0x00A2F1D4 File Offset: 0x00A2D3D4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Template_Instant_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Template/GE_Template_Instant.GE_Template_Instant_C");
			}
			return GE_Template_Instant_C._ClassPtr;
		}

		// Token: 0x0602D09F RID: 184479 RVA: 0x00A2F1F8 File Offset: 0x00A2D3F8
		public GE_Template_Instant_C() : this(BuiltinUtils.AllocNativeUObject(GE_Template_Instant_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D0A0 RID: 184480 RVA: 0x00A2F220 File Offset: 0x00A2D420
		[NullableContext(1)]
		public GE_Template_Instant_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Template_Instant_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D0A1 RID: 184481 RVA: 0x00A2F253 File Offset: 0x00A2D453
		protected GE_Template_Instant_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017E6F RID: 97903
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Template/GE_Template_Instant.GE_Template_Instant_C";

		// Token: 0x04017E70 RID: 97904
		private static IntPtr _ClassPtr;

		// Token: 0x04017E71 RID: 97905
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
