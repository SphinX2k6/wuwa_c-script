using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA053
{
	// Token: 0x020041E9 RID: 16873
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA053/ABP_NA053_NPC.ABP_NA053_NPC_C")]
	[UnrealStructLayout(13088, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 13082)]
	public class ABP_NA053_NPC_C : ABP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD67 RID: 179559 RVA: 0x00A0C04C File Offset: 0x00A0A24C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA053_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA053/ABP_NA053_NPC.ABP_NA053_NPC_C");
			}
			return ABP_NA053_NPC_C._ClassPtr;
		}

		// Token: 0x0602BD68 RID: 179560 RVA: 0x00A0C070 File Offset: 0x00A0A270
		public ABP_NA053_NPC_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA053_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD69 RID: 179561 RVA: 0x00A0C098 File Offset: 0x00A0A298
		[NullableContext(1)]
		public ABP_NA053_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA053_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BD6A RID: 179562 RVA: 0x00A0C0CB File Offset: 0x00A0A2CB
		protected ABP_NA053_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016DD8 RID: 93656
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA053/ABP_NA053_NPC.ABP_NA053_NPC_C";

		// Token: 0x04016DD9 RID: 93657
		private static IntPtr _ClassPtr;

		// Token: 0x04016DDA RID: 93658
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
