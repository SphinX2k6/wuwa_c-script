using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Template
{
	// Token: 0x020043E7 RID: 17383
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Template/GE_Template_Duration.GE_Template_Duration_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Template_Duration_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D092 RID: 184466 RVA: 0x00A2F03C File Offset: 0x00A2D23C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Template_Duration_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Template/GE_Template_Duration.GE_Template_Duration_C");
			}
			return GE_Template_Duration_C._ClassPtr;
		}

		// Token: 0x0602D093 RID: 184467 RVA: 0x00A2F060 File Offset: 0x00A2D260
		public GE_Template_Duration_C() : this(BuiltinUtils.AllocNativeUObject(GE_Template_Duration_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D094 RID: 184468 RVA: 0x00A2F088 File Offset: 0x00A2D288
		[NullableContext(1)]
		public GE_Template_Duration_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Template_Duration_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D095 RID: 184469 RVA: 0x00A2F0BB File Offset: 0x00A2D2BB
		protected GE_Template_Duration_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017E66 RID: 97894
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Template/GE_Template_Duration.GE_Template_Duration_C";

		// Token: 0x04017E67 RID: 97895
		private static IntPtr _ClassPtr;

		// Token: 0x04017E68 RID: 97896
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
