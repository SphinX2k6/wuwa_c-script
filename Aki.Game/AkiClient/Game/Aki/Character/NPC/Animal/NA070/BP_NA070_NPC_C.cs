using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA070
{
	// Token: 0x020041B3 RID: 16819
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA070/BP_NA070_NPC.BP_NA070_NPC_C")]
	[UnrealStructLayout(2336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2330)]
	public class BP_NA070_NPC_C : BP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC30 RID: 179248 RVA: 0x00A09BE5 File Offset: 0x00A07DE5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA070_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA070/BP_NA070_NPC.BP_NA070_NPC_C");
			}
			return BP_NA070_NPC_C._ClassPtr;
		}

		// Token: 0x0602BC31 RID: 179249 RVA: 0x00A09C0C File Offset: 0x00A07E0C
		public BP_NA070_NPC_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA070_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BC32 RID: 179250 RVA: 0x00A09C34 File Offset: 0x00A07E34
		[NullableContext(1)]
		public BP_NA070_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA070_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BC33 RID: 179251 RVA: 0x00A09C67 File Offset: 0x00A07E67
		protected BP_NA070_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D04 RID: 93444
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA070/BP_NA070_NPC.BP_NA070_NPC_C";

		// Token: 0x04016D05 RID: 93445
		private static IntPtr _ClassPtr;

		// Token: 0x04016D06 RID: 93446
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
