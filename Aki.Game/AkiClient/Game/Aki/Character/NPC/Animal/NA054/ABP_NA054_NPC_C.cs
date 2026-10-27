using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA054
{
	// Token: 0x020041E6 RID: 16870
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA054/ABP_NA054_NPC.ABP_NA054_NPC_C")]
	[UnrealStructLayout(13088, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 13082)]
	public class ABP_NA054_NPC_C : ABP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD5B RID: 179547 RVA: 0x00A0BEB4 File Offset: 0x00A0A0B4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA054_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA054/ABP_NA054_NPC.ABP_NA054_NPC_C");
			}
			return ABP_NA054_NPC_C._ClassPtr;
		}

		// Token: 0x0602BD5C RID: 179548 RVA: 0x00A0BED8 File Offset: 0x00A0A0D8
		public ABP_NA054_NPC_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA054_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD5D RID: 179549 RVA: 0x00A0BF00 File Offset: 0x00A0A100
		[NullableContext(1)]
		public ABP_NA054_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA054_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BD5E RID: 179550 RVA: 0x00A0BF33 File Offset: 0x00A0A133
		protected ABP_NA054_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016DCF RID: 93647
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA054/ABP_NA054_NPC.ABP_NA054_NPC_C";

		// Token: 0x04016DD0 RID: 93648
		private static IntPtr _ClassPtr;

		// Token: 0x04016DD1 RID: 93649
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
