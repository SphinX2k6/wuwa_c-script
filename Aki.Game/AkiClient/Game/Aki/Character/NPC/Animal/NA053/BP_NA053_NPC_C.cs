using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA053
{
	// Token: 0x020041EA RID: 16874
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA053/BP_NA053_NPC.BP_NA053_NPC_C")]
	[UnrealStructLayout(2336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2330)]
	public class BP_NA053_NPC_C : BP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD6B RID: 179563 RVA: 0x00A0C0D4 File Offset: 0x00A0A2D4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA053_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA053/BP_NA053_NPC.BP_NA053_NPC_C");
			}
			return BP_NA053_NPC_C._ClassPtr;
		}

		// Token: 0x0602BD6C RID: 179564 RVA: 0x00A0C0F8 File Offset: 0x00A0A2F8
		public BP_NA053_NPC_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA053_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD6D RID: 179565 RVA: 0x00A0C120 File Offset: 0x00A0A320
		[NullableContext(1)]
		public BP_NA053_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA053_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BD6E RID: 179566 RVA: 0x00A0C153 File Offset: 0x00A0A353
		protected BP_NA053_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016DDB RID: 93659
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA053/BP_NA053_NPC.BP_NA053_NPC_C";

		// Token: 0x04016DDC RID: 93660
		private static IntPtr _ClassPtr;

		// Token: 0x04016DDD RID: 93661
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
