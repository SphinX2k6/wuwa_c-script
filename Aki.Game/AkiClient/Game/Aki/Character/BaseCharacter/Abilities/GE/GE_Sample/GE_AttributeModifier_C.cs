using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Sample
{
	// Token: 0x020043ED RID: 17389
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/GE_AttributeModifier.GE_AttributeModifier_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_AttributeModifier_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D0AE RID: 184494 RVA: 0x00A2F3BE File Offset: 0x00A2D5BE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_AttributeModifier_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/GE_AttributeModifier.GE_AttributeModifier_C");
			}
			return GE_AttributeModifier_C._ClassPtr;
		}

		// Token: 0x0602D0AF RID: 184495 RVA: 0x00A2F3E4 File Offset: 0x00A2D5E4
		public GE_AttributeModifier_C() : this(BuiltinUtils.AllocNativeUObject(GE_AttributeModifier_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D0B0 RID: 184496 RVA: 0x00A2F40C File Offset: 0x00A2D60C
		[NullableContext(1)]
		public GE_AttributeModifier_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_AttributeModifier_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D0B1 RID: 184497 RVA: 0x00A2F43F File Offset: 0x00A2D63F
		protected GE_AttributeModifier_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017E7A RID: 97914
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Sample/GE_AttributeModifier.GE_AttributeModifier_C";

		// Token: 0x04017E7B RID: 97915
		private static IntPtr _ClassPtr;

		// Token: 0x04017E7C RID: 97916
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
