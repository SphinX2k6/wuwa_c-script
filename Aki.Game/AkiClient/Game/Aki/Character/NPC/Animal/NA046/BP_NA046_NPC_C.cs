using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA046
{
	// Token: 0x020041F4 RID: 16884
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA046/BP_NA046_NPC.BP_NA046_NPC_C")]
	[UnrealStructLayout(2336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2330)]
	public class BP_NA046_NPC_C : BP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD93 RID: 179603 RVA: 0x00A0C624 File Offset: 0x00A0A824
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA046_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA046/BP_NA046_NPC.BP_NA046_NPC_C");
			}
			return BP_NA046_NPC_C._ClassPtr;
		}

		// Token: 0x0602BD94 RID: 179604 RVA: 0x00A0C648 File Offset: 0x00A0A848
		public BP_NA046_NPC_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA046_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD95 RID: 179605 RVA: 0x00A0C670 File Offset: 0x00A0A870
		[NullableContext(1)]
		public BP_NA046_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA046_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BD96 RID: 179606 RVA: 0x00A0C6A3 File Offset: 0x00A0A8A3
		protected BP_NA046_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016DF9 RID: 93689
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA046/BP_NA046_NPC.BP_NA046_NPC_C";

		// Token: 0x04016DFA RID: 93690
		private static IntPtr _ClassPtr;

		// Token: 0x04016DFB RID: 93691
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
