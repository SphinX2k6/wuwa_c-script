using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonSmallAnimal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA041
{
	// Token: 0x02004200 RID: 16896
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA041/BP_NA041.BP_NA041_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2248)]
	public class BP_NA041_C : BP_CommonSmallAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BDD8 RID: 179672 RVA: 0x00A0D068 File Offset: 0x00A0B268
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA041_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA041/BP_NA041.BP_NA041_C");
			}
			return BP_NA041_C._ClassPtr;
		}

		// Token: 0x0602BDD9 RID: 179673 RVA: 0x00A0D08C File Offset: 0x00A0B28C
		public BP_NA041_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA041_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BDDA RID: 179674 RVA: 0x00A0D0B4 File Offset: 0x00A0B2B4
		[NullableContext(1)]
		public BP_NA041_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA041_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BDDB RID: 179675 RVA: 0x00A0D0E7 File Offset: 0x00A0B2E7
		protected BP_NA041_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E2F RID: 93743
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA041/BP_NA041.BP_NA041_C";

		// Token: 0x04016E30 RID: 93744
		private static IntPtr _ClassPtr;

		// Token: 0x04016E31 RID: 93745
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
