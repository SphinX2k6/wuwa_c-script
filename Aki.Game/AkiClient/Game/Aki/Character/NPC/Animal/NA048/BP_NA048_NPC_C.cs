using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA048
{
	// Token: 0x020041F0 RID: 16880
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA048/BP_NA048_NPC.BP_NA048_NPC_C")]
	[UnrealStructLayout(2336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2330)]
	public class BP_NA048_NPC_C : BP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD83 RID: 179587 RVA: 0x00A0C404 File Offset: 0x00A0A604
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA048_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA048/BP_NA048_NPC.BP_NA048_NPC_C");
			}
			return BP_NA048_NPC_C._ClassPtr;
		}

		// Token: 0x0602BD84 RID: 179588 RVA: 0x00A0C428 File Offset: 0x00A0A628
		public BP_NA048_NPC_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA048_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD85 RID: 179589 RVA: 0x00A0C450 File Offset: 0x00A0A650
		[NullableContext(1)]
		public BP_NA048_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA048_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BD86 RID: 179590 RVA: 0x00A0C483 File Offset: 0x00A0A683
		protected BP_NA048_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016DED RID: 93677
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA048/BP_NA048_NPC.BP_NA048_NPC_C";

		// Token: 0x04016DEE RID: 93678
		private static IntPtr _ClassPtr;

		// Token: 0x04016DEF RID: 93679
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
