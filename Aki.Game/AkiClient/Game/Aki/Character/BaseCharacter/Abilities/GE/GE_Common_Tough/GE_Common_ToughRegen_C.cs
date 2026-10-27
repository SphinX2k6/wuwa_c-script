using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_Tough
{
	// Token: 0x020043FB RID: 17403
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Tough/GE_Common_ToughRegen.GE_Common_ToughRegen_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Common_ToughRegen_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D0E8 RID: 184552 RVA: 0x00A2FC88 File Offset: 0x00A2DE88
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Common_ToughRegen_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Tough/GE_Common_ToughRegen.GE_Common_ToughRegen_C");
			}
			return GE_Common_ToughRegen_C._ClassPtr;
		}

		// Token: 0x0602D0E9 RID: 184553 RVA: 0x00A2FCAC File Offset: 0x00A2DEAC
		public GE_Common_ToughRegen_C() : this(BuiltinUtils.AllocNativeUObject(GE_Common_ToughRegen_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D0EA RID: 184554 RVA: 0x00A2FCD4 File Offset: 0x00A2DED4
		[NullableContext(1)]
		public GE_Common_ToughRegen_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Common_ToughRegen_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D0EB RID: 184555 RVA: 0x00A2FD07 File Offset: 0x00A2DF07
		protected GE_Common_ToughRegen_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017EA5 RID: 97957
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Tough/GE_Common_ToughRegen.GE_Common_ToughRegen_C";

		// Token: 0x04017EA6 RID: 97958
		private static IntPtr _ClassPtr;

		// Token: 0x04017EA7 RID: 97959
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
