using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA065
{
	// Token: 0x020041C6 RID: 16838
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA065/BP_NA065_NPC.BP_NA065_NPC_C")]
	[UnrealStructLayout(2336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2330)]
	public class BP_NA065_NPC_C : BP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC9E RID: 179358 RVA: 0x00A0A8BF File Offset: 0x00A08ABF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA065_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA065/BP_NA065_NPC.BP_NA065_NPC_C");
			}
			return BP_NA065_NPC_C._ClassPtr;
		}

		// Token: 0x0602BC9F RID: 179359 RVA: 0x00A0A8E4 File Offset: 0x00A08AE4
		public BP_NA065_NPC_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA065_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BCA0 RID: 179360 RVA: 0x00A0A90C File Offset: 0x00A08B0C
		[NullableContext(1)]
		public BP_NA065_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA065_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BCA1 RID: 179361 RVA: 0x00A0A93F File Offset: 0x00A08B3F
		protected BP_NA065_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D4E RID: 93518
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA065/BP_NA065_NPC.BP_NA065_NPC_C";

		// Token: 0x04016D4F RID: 93519
		private static IntPtr _ClassPtr;

		// Token: 0x04016D50 RID: 93520
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
