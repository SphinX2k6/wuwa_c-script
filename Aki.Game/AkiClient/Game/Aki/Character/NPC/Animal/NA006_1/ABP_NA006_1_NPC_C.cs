using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA006_1
{
	// Token: 0x02004238 RID: 16952
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA006_1/ABP_NA006_1_NPC.ABP_NA006_1_NPC_C")]
	[UnrealStructLayout(13088, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 13082)]
	public class ABP_NA006_1_NPC_C : ABP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BED8 RID: 179928 RVA: 0x00A0F1D0 File Offset: 0x00A0D3D0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA006_1_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA006_1/ABP_NA006_1_NPC.ABP_NA006_1_NPC_C");
			}
			return ABP_NA006_1_NPC_C._ClassPtr;
		}

		// Token: 0x0602BED9 RID: 179929 RVA: 0x00A0F1F4 File Offset: 0x00A0D3F4
		public ABP_NA006_1_NPC_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA006_1_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BEDA RID: 179930 RVA: 0x00A0F21C File Offset: 0x00A0D41C
		[NullableContext(1)]
		public ABP_NA006_1_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA006_1_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BEDB RID: 179931 RVA: 0x00A0F24F File Offset: 0x00A0D44F
		protected ABP_NA006_1_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016EE9 RID: 93929
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA006_1/ABP_NA006_1_NPC.ABP_NA006_1_NPC_C";

		// Token: 0x04016EEA RID: 93930
		private static IntPtr _ClassPtr;

		// Token: 0x04016EEB RID: 93931
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
