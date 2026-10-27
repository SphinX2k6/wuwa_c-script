using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_AttributeModifier
{
	// Token: 0x02004420 RID: 17440
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_Element3Clear.GE_Element3Clear_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Element3Clear_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D17C RID: 184700 RVA: 0x00A31030 File Offset: 0x00A2F230
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Element3Clear_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_Element3Clear.GE_Element3Clear_C");
			}
			return GE_Element3Clear_C._ClassPtr;
		}

		// Token: 0x0602D17D RID: 184701 RVA: 0x00A31054 File Offset: 0x00A2F254
		public GE_Element3Clear_C() : this(BuiltinUtils.AllocNativeUObject(GE_Element3Clear_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D17E RID: 184702 RVA: 0x00A3107C File Offset: 0x00A2F27C
		[NullableContext(1)]
		public GE_Element3Clear_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Element3Clear_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D17F RID: 184703 RVA: 0x00A310AF File Offset: 0x00A2F2AF
		protected GE_Element3Clear_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017F14 RID: 98068
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_AttributeModifier/GE_Element3Clear.GE_Element3Clear_C";

		// Token: 0x04017F15 RID: 98069
		private static IntPtr _ClassPtr;

		// Token: 0x04017F16 RID: 98070
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
