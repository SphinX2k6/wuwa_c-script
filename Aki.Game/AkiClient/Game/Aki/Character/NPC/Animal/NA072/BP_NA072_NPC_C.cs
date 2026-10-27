using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA072
{
	// Token: 0x020041AB RID: 16811
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA072/BP_NA072_NPC.BP_NA072_NPC_C")]
	[UnrealStructLayout(2336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2330)]
	public class BP_NA072_NPC_C : BP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC0E RID: 179214 RVA: 0x00A0977C File Offset: 0x00A0797C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA072_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA072/BP_NA072_NPC.BP_NA072_NPC_C");
			}
			return BP_NA072_NPC_C._ClassPtr;
		}

		// Token: 0x0602BC0F RID: 179215 RVA: 0x00A097A0 File Offset: 0x00A079A0
		public BP_NA072_NPC_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA072_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BC10 RID: 179216 RVA: 0x00A097C8 File Offset: 0x00A079C8
		[NullableContext(1)]
		public BP_NA072_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA072_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BC11 RID: 179217 RVA: 0x00A097FB File Offset: 0x00A079FB
		protected BP_NA072_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016CEB RID: 93419
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA072/BP_NA072_NPC.BP_NA072_NPC_C";

		// Token: 0x04016CEC RID: 93420
		private static IntPtr _ClassPtr;

		// Token: 0x04016CED RID: 93421
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
