using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_Tough
{
	// Token: 0x020043FD RID: 17405
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Tough/GE_Tough_Reduce.GE_Tough_Reduce_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_Tough_Reduce_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D0F0 RID: 184560 RVA: 0x00A2FD98 File Offset: 0x00A2DF98
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_Tough_Reduce_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Tough/GE_Tough_Reduce.GE_Tough_Reduce_C");
			}
			return GE_Tough_Reduce_C._ClassPtr;
		}

		// Token: 0x0602D0F1 RID: 184561 RVA: 0x00A2FDBC File Offset: 0x00A2DFBC
		public GE_Tough_Reduce_C() : this(BuiltinUtils.AllocNativeUObject(GE_Tough_Reduce_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D0F2 RID: 184562 RVA: 0x00A2FDE4 File Offset: 0x00A2DFE4
		[NullableContext(1)]
		public GE_Tough_Reduce_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_Tough_Reduce_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D0F3 RID: 184563 RVA: 0x00A2FE17 File Offset: 0x00A2E017
		protected GE_Tough_Reduce_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017EAB RID: 97963
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Tough/GE_Tough_Reduce.GE_Tough_Reduce_C";

		// Token: 0x04017EAC RID: 97964
		private static IntPtr _ClassPtr;

		// Token: 0x04017EAD RID: 97965
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
