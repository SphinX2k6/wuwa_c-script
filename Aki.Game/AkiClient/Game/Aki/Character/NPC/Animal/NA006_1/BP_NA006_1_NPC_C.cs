using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA006_1
{
	// Token: 0x02004239 RID: 16953
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA006_1/BP_NA006_1_NPC.BP_NA006_1_NPC_C")]
	[UnrealStructLayout(2336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2330)]
	public class BP_NA006_1_NPC_C : BP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BEDC RID: 179932 RVA: 0x00A0F258 File Offset: 0x00A0D458
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA006_1_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA006_1/BP_NA006_1_NPC.BP_NA006_1_NPC_C");
			}
			return BP_NA006_1_NPC_C._ClassPtr;
		}

		// Token: 0x0602BEDD RID: 179933 RVA: 0x00A0F27C File Offset: 0x00A0D47C
		public BP_NA006_1_NPC_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA006_1_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BEDE RID: 179934 RVA: 0x00A0F2A4 File Offset: 0x00A0D4A4
		[NullableContext(1)]
		public BP_NA006_1_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA006_1_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BEDF RID: 179935 RVA: 0x00A0F2D7 File Offset: 0x00A0D4D7
		protected BP_NA006_1_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016EEC RID: 93932
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA006_1/BP_NA006_1_NPC.BP_NA006_1_NPC_C";

		// Token: 0x04016EED RID: 93933
		private static IntPtr _ClassPtr;

		// Token: 0x04016EEE RID: 93934
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
