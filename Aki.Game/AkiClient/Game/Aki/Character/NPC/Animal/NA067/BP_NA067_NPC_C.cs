using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA067
{
	// Token: 0x020041BE RID: 16830
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA067/BP_NA067_NPC.BP_NA067_NPC_C")]
	[UnrealStructLayout(2336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2330)]
	public class BP_NA067_NPC_C : BP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC6E RID: 179310 RVA: 0x00A0A334 File Offset: 0x00A08534
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA067_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA067/BP_NA067_NPC.BP_NA067_NPC_C");
			}
			return BP_NA067_NPC_C._ClassPtr;
		}

		// Token: 0x0602BC6F RID: 179311 RVA: 0x00A0A358 File Offset: 0x00A08558
		public BP_NA067_NPC_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA067_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BC70 RID: 179312 RVA: 0x00A0A380 File Offset: 0x00A08580
		[NullableContext(1)]
		public BP_NA067_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA067_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BC71 RID: 179313 RVA: 0x00A0A3B3 File Offset: 0x00A085B3
		protected BP_NA067_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D2E RID: 93486
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA067/BP_NA067_NPC.BP_NA067_NPC_C";

		// Token: 0x04016D2F RID: 93487
		private static IntPtr _ClassPtr;

		// Token: 0x04016D30 RID: 93488
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
