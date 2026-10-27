using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Template;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_State
{
	// Token: 0x02004404 RID: 17412
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_State/GE_Stiff.GE_Stiff_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Stiff_C : GE_Template_Duration_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D10C RID: 184588 RVA: 0x00A30150 File Offset: 0x00A2E350
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Stiff_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_State/GE_Stiff.GE_Stiff_C");
			}
			return GE_Stiff_C._ClassPtr;
		}

		// Token: 0x0602D10D RID: 184589 RVA: 0x00A30174 File Offset: 0x00A2E374
		public GE_Stiff_C() : this(BuiltinUtils.AllocNativeUObject(GE_Stiff_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D10E RID: 184590 RVA: 0x00A3019C File Offset: 0x00A2E39C
		[NullableContext(1)]
		public GE_Stiff_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Stiff_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D10F RID: 184591 RVA: 0x00A301CF File Offset: 0x00A2E3CF
		protected GE_Stiff_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017EC0 RID: 97984
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_State/GE_Stiff.GE_Stiff_C";

		// Token: 0x04017EC1 RID: 97985
		private static IntPtr _ClassPtr;

		// Token: 0x04017EC2 RID: 97986
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
