using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonBird;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA028
{
	// Token: 0x02004215 RID: 16917
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA028/BP_NA028_boss.BP_NA028_boss_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2248)]
	public class BP_NA028_boss_C : BP_BaseBird_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE36 RID: 179766 RVA: 0x00A0DC60 File Offset: 0x00A0BE60
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA028_boss_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA028/BP_NA028_boss.BP_NA028_boss_C");
			}
			return BP_NA028_boss_C._ClassPtr;
		}

		// Token: 0x0602BE37 RID: 179767 RVA: 0x00A0DC84 File Offset: 0x00A0BE84
		public BP_NA028_boss_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA028_boss_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE38 RID: 179768 RVA: 0x00A0DCAC File Offset: 0x00A0BEAC
		[NullableContext(1)]
		public BP_NA028_boss_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA028_boss_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BE39 RID: 179769 RVA: 0x00A0DCDF File Offset: 0x00A0BEDF
		protected BP_NA028_boss_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E73 RID: 93811
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA028/BP_NA028_boss.BP_NA028_boss_C";

		// Token: 0x04016E74 RID: 93812
		private static IntPtr _ClassPtr;

		// Token: 0x04016E75 RID: 93813
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
