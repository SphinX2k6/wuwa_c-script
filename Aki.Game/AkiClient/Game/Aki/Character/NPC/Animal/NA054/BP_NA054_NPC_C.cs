using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA054
{
	// Token: 0x020041E8 RID: 16872
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA054/BP_NA054_NPC.BP_NA054_NPC_C")]
	[UnrealStructLayout(2336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2330)]
	public class BP_NA054_NPC_C : BP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD63 RID: 179555 RVA: 0x00A0BFC4 File Offset: 0x00A0A1C4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA054_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA054/BP_NA054_NPC.BP_NA054_NPC_C");
			}
			return BP_NA054_NPC_C._ClassPtr;
		}

		// Token: 0x0602BD64 RID: 179556 RVA: 0x00A0BFE8 File Offset: 0x00A0A1E8
		public BP_NA054_NPC_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA054_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD65 RID: 179557 RVA: 0x00A0C010 File Offset: 0x00A0A210
		[NullableContext(1)]
		public BP_NA054_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA054_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BD66 RID: 179558 RVA: 0x00A0C043 File Offset: 0x00A0A243
		protected BP_NA054_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016DD5 RID: 93653
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA054/BP_NA054_NPC.BP_NA054_NPC_C";

		// Token: 0x04016DD6 RID: 93654
		private static IntPtr _ClassPtr;

		// Token: 0x04016DD7 RID: 93655
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
