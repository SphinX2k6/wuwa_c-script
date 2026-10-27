using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Template
{
	// Token: 0x020043EB RID: 17387
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Template/GE_Template_Periodic.GE_Template_Periodic_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Template_Periodic_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D0A2 RID: 184482 RVA: 0x00A2F25C File Offset: 0x00A2D45C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Template_Periodic_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Template/GE_Template_Periodic.GE_Template_Periodic_C");
			}
			return GE_Template_Periodic_C._ClassPtr;
		}

		// Token: 0x0602D0A3 RID: 184483 RVA: 0x00A2F280 File Offset: 0x00A2D480
		public GE_Template_Periodic_C() : this(BuiltinUtils.AllocNativeUObject(GE_Template_Periodic_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D0A4 RID: 184484 RVA: 0x00A2F2A8 File Offset: 0x00A2D4A8
		[NullableContext(1)]
		public GE_Template_Periodic_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Template_Periodic_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D0A5 RID: 184485 RVA: 0x00A2F2DB File Offset: 0x00A2D4DB
		protected GE_Template_Periodic_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017E72 RID: 97906
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Template/GE_Template_Periodic.GE_Template_Periodic_C";

		// Token: 0x04017E73 RID: 97907
		private static IntPtr _ClassPtr;

		// Token: 0x04017E74 RID: 97908
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
