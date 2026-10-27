using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_AttributeModifier
{
	// Token: 0x02004427 RID: 17447
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_ToughModifier.GE_ToughModifier_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_ToughModifier_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D198 RID: 184728 RVA: 0x00A313E8 File Offset: 0x00A2F5E8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_ToughModifier_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_ToughModifier.GE_ToughModifier_C");
			}
			return GE_ToughModifier_C._ClassPtr;
		}

		// Token: 0x0602D199 RID: 184729 RVA: 0x00A3140C File Offset: 0x00A2F60C
		public GE_ToughModifier_C() : this(BuiltinUtils.AllocNativeUObject(GE_ToughModifier_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D19A RID: 184730 RVA: 0x00A31434 File Offset: 0x00A2F634
		[NullableContext(1)]
		public GE_ToughModifier_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_ToughModifier_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D19B RID: 184731 RVA: 0x00A31467 File Offset: 0x00A2F667
		protected GE_ToughModifier_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017F29 RID: 98089
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_ToughModifier.GE_ToughModifier_C";

		// Token: 0x04017F2A RID: 98090
		private static IntPtr _ClassPtr;

		// Token: 0x04017F2B RID: 98091
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
