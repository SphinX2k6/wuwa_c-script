using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Template
{
	// Token: 0x020043E8 RID: 17384
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Template/GE_Template_InfinitePeriodic.GE_Template_InfinitePeriodic_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Template_InfinitePeriodic_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D096 RID: 184470 RVA: 0x00A2F0C4 File Offset: 0x00A2D2C4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Template_InfinitePeriodic_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Template/GE_Template_InfinitePeriodic.GE_Template_InfinitePeriodic_C");
			}
			return GE_Template_InfinitePeriodic_C._ClassPtr;
		}

		// Token: 0x0602D097 RID: 184471 RVA: 0x00A2F0E8 File Offset: 0x00A2D2E8
		public GE_Template_InfinitePeriodic_C() : this(BuiltinUtils.AllocNativeUObject(GE_Template_InfinitePeriodic_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D098 RID: 184472 RVA: 0x00A2F110 File Offset: 0x00A2D310
		[NullableContext(1)]
		public GE_Template_InfinitePeriodic_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Template_InfinitePeriodic_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D099 RID: 184473 RVA: 0x00A2F143 File Offset: 0x00A2D343
		protected GE_Template_InfinitePeriodic_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017E69 RID: 97897
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Template/GE_Template_InfinitePeriodic.GE_Template_InfinitePeriodic_C";

		// Token: 0x04017E6A RID: 97898
		private static IntPtr _ClassPtr;

		// Token: 0x04017E6B RID: 97899
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
