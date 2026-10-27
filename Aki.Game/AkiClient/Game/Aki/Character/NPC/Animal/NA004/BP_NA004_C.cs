using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonSmallAnimal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA004
{
	// Token: 0x02004240 RID: 16960
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA004/BP_NA004.BP_NA004_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2248)]
	public class BP_NA004_C : BP_CommonSmallAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BEFE RID: 179966 RVA: 0x00A0F694 File Offset: 0x00A0D894
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA004_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA004/BP_NA004.BP_NA004_C");
			}
			return BP_NA004_C._ClassPtr;
		}

		// Token: 0x0602BEFF RID: 179967 RVA: 0x00A0F6B8 File Offset: 0x00A0D8B8
		public BP_NA004_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA004_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BF00 RID: 179968 RVA: 0x00A0F6E0 File Offset: 0x00A0D8E0
		[NullableContext(1)]
		public BP_NA004_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA004_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BF01 RID: 179969 RVA: 0x00A0F713 File Offset: 0x00A0D913
		protected BP_NA004_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016F04 RID: 93956
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA004/BP_NA004.BP_NA004_C";

		// Token: 0x04016F05 RID: 93957
		private static IntPtr _ClassPtr;

		// Token: 0x04016F06 RID: 93958
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
