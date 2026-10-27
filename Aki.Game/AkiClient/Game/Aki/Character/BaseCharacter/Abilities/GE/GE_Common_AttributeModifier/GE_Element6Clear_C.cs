using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_AttributeModifier
{
	// Token: 0x02004423 RID: 17443
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_Element6Clear.GE_Element6Clear_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Element6Clear_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D188 RID: 184712 RVA: 0x00A311C8 File Offset: 0x00A2F3C8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Element6Clear_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_Element6Clear.GE_Element6Clear_C");
			}
			return GE_Element6Clear_C._ClassPtr;
		}

		// Token: 0x0602D189 RID: 184713 RVA: 0x00A311EC File Offset: 0x00A2F3EC
		public GE_Element6Clear_C() : this(BuiltinUtils.AllocNativeUObject(GE_Element6Clear_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D18A RID: 184714 RVA: 0x00A31214 File Offset: 0x00A2F414
		[NullableContext(1)]
		public GE_Element6Clear_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Element6Clear_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D18B RID: 184715 RVA: 0x00A31247 File Offset: 0x00A2F447
		protected GE_Element6Clear_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017F1D RID: 98077
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_Element6Clear.GE_Element6Clear_C";

		// Token: 0x04017F1E RID: 98078
		private static IntPtr _ClassPtr;

		// Token: 0x04017F1F RID: 98079
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
