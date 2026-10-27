using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonBird;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA028
{
	// Token: 0x02004216 RID: 16918
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA028/BP_NA028.BP_NA028_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2248)]
	public class BP_NA028_C : BP_BaseBird_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE3A RID: 179770 RVA: 0x00A0DCE8 File Offset: 0x00A0BEE8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA028_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA028/BP_NA028.BP_NA028_C");
			}
			return BP_NA028_C._ClassPtr;
		}

		// Token: 0x0602BE3B RID: 179771 RVA: 0x00A0DD0C File Offset: 0x00A0BF0C
		public BP_NA028_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA028_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE3C RID: 179772 RVA: 0x00A0DD34 File Offset: 0x00A0BF34
		[NullableContext(1)]
		public BP_NA028_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA028_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BE3D RID: 179773 RVA: 0x00A0DD67 File Offset: 0x00A0BF67
		protected BP_NA028_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E76 RID: 93814
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA028/BP_NA028.BP_NA028_C";

		// Token: 0x04016E77 RID: 93815
		private static IntPtr _ClassPtr;

		// Token: 0x04016E78 RID: 93816
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
