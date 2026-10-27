using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA069
{
	// Token: 0x020041B6 RID: 16822
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA069/BP_NA069_NPC.BP_NA069_NPC_C")]
	[UnrealStructLayout(2336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2330)]
	public class BP_NA069_NPC_C : BP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC42 RID: 179266 RVA: 0x00A09DFB File Offset: 0x00A07FFB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA069_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA069/BP_NA069_NPC.BP_NA069_NPC_C");
			}
			return BP_NA069_NPC_C._ClassPtr;
		}

		// Token: 0x0602BC43 RID: 179267 RVA: 0x00A09E20 File Offset: 0x00A08020
		public BP_NA069_NPC_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA069_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BC44 RID: 179268 RVA: 0x00A09E48 File Offset: 0x00A08048
		[NullableContext(1)]
		public BP_NA069_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA069_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BC45 RID: 179269 RVA: 0x00A09E7B File Offset: 0x00A0807B
		protected BP_NA069_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D10 RID: 93456
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA069/BP_NA069_NPC.BP_NA069_NPC_C";

		// Token: 0x04016D11 RID: 93457
		private static IntPtr _ClassPtr;

		// Token: 0x04016D12 RID: 93458
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
