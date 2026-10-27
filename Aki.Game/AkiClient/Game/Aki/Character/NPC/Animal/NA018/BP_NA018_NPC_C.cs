using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA018
{
	// Token: 0x02004220 RID: 16928
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA018/BP_NA018_NPC.BP_NA018_NPC_C")]
	[UnrealStructLayout(2336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2330)]
	public class BP_NA018_NPC_C : BP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE6E RID: 179822 RVA: 0x00A0E374 File Offset: 0x00A0C574
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA018_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA018/BP_NA018_NPC.BP_NA018_NPC_C");
			}
			return BP_NA018_NPC_C._ClassPtr;
		}

		// Token: 0x0602BE6F RID: 179823 RVA: 0x00A0E398 File Offset: 0x00A0C598
		public BP_NA018_NPC_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA018_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE70 RID: 179824 RVA: 0x00A0E3C0 File Offset: 0x00A0C5C0
		[NullableContext(1)]
		public BP_NA018_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA018_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BE71 RID: 179825 RVA: 0x00A0E3F3 File Offset: 0x00A0C5F3
		protected BP_NA018_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E9C RID: 93852
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA018/BP_NA018_NPC.BP_NA018_NPC_C";

		// Token: 0x04016E9D RID: 93853
		private static IntPtr _ClassPtr;

		// Token: 0x04016E9E RID: 93854
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
