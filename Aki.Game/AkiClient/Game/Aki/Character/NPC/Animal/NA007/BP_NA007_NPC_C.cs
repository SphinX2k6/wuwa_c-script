using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA007
{
	// Token: 0x02004237 RID: 16951
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA007/BP_NA007_NPC.BP_NA007_NPC_C")]
	[UnrealStructLayout(2336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2330)]
	public class BP_NA007_NPC_C : BP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BED4 RID: 179924 RVA: 0x00A0F148 File Offset: 0x00A0D348
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA007_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA007/BP_NA007_NPC.BP_NA007_NPC_C");
			}
			return BP_NA007_NPC_C._ClassPtr;
		}

		// Token: 0x0602BED5 RID: 179925 RVA: 0x00A0F16C File Offset: 0x00A0D36C
		public BP_NA007_NPC_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA007_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BED6 RID: 179926 RVA: 0x00A0F194 File Offset: 0x00A0D394
		[NullableContext(1)]
		public BP_NA007_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA007_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BED7 RID: 179927 RVA: 0x00A0F1C7 File Offset: 0x00A0D3C7
		protected BP_NA007_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016EE6 RID: 93926
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA007/BP_NA007_NPC.BP_NA007_NPC_C";

		// Token: 0x04016EE7 RID: 93927
		private static IntPtr _ClassPtr;

		// Token: 0x04016EE8 RID: 93928
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
