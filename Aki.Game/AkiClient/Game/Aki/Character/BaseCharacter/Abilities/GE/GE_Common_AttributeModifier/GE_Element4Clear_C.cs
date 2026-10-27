using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_AttributeModifier
{
	// Token: 0x02004421 RID: 17441
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_Element4Clear.GE_Element4Clear_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Element4Clear_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D180 RID: 184704 RVA: 0x00A310B8 File Offset: 0x00A2F2B8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Element4Clear_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_Element4Clear.GE_Element4Clear_C");
			}
			return GE_Element4Clear_C._ClassPtr;
		}

		// Token: 0x0602D181 RID: 184705 RVA: 0x00A310DC File Offset: 0x00A2F2DC
		public GE_Element4Clear_C() : this(BuiltinUtils.AllocNativeUObject(GE_Element4Clear_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D182 RID: 184706 RVA: 0x00A31104 File Offset: 0x00A2F304
		[NullableContext(1)]
		public GE_Element4Clear_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Element4Clear_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D183 RID: 184707 RVA: 0x00A31137 File Offset: 0x00A2F337
		protected GE_Element4Clear_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017F17 RID: 98071
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_Element4Clear.GE_Element4Clear_C";

		// Token: 0x04017F18 RID: 98072
		private static IntPtr _ClassPtr;

		// Token: 0x04017F19 RID: 98073
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
