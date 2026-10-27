using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA071
{
	// Token: 0x020041AD RID: 16813
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA071/ABP_NA071_NPC.ABP_NA071_NPC_C")]
	[UnrealStructLayout(13088, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 13082)]
	public class ABP_NA071_NPC_C : ABP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC16 RID: 179222 RVA: 0x00A0988C File Offset: 0x00A07A8C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA071_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA071/ABP_NA071_NPC.ABP_NA071_NPC_C");
			}
			return ABP_NA071_NPC_C._ClassPtr;
		}

		// Token: 0x0602BC17 RID: 179223 RVA: 0x00A098B0 File Offset: 0x00A07AB0
		public ABP_NA071_NPC_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA071_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BC18 RID: 179224 RVA: 0x00A098D8 File Offset: 0x00A07AD8
		[NullableContext(1)]
		public ABP_NA071_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA071_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BC19 RID: 179225 RVA: 0x00A0990B File Offset: 0x00A07B0B
		protected ABP_NA071_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016CF1 RID: 93425
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA071/ABP_NA071_NPC.ABP_NA071_NPC_C";

		// Token: 0x04016CF2 RID: 93426
		private static IntPtr _ClassPtr;

		// Token: 0x04016CF3 RID: 93427
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
