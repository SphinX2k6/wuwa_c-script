using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonBigAnimal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA040
{
	// Token: 0x02004202 RID: 16898
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA040/BP_NA040.BP_NA040_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2248)]
	public class BP_NA040_C : BP_CommonBigAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BDE0 RID: 179680 RVA: 0x00A0D178 File Offset: 0x00A0B378
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA040_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA040/BP_NA040.BP_NA040_C");
			}
			return BP_NA040_C._ClassPtr;
		}

		// Token: 0x0602BDE1 RID: 179681 RVA: 0x00A0D19C File Offset: 0x00A0B39C
		public BP_NA040_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA040_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BDE2 RID: 179682 RVA: 0x00A0D1C4 File Offset: 0x00A0B3C4
		[NullableContext(1)]
		public BP_NA040_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA040_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BDE3 RID: 179683 RVA: 0x00A0D1F7 File Offset: 0x00A0B3F7
		protected BP_NA040_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E35 RID: 93749
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA040/BP_NA040.BP_NA040_C";

		// Token: 0x04016E36 RID: 93750
		private static IntPtr _ClassPtr;

		// Token: 0x04016E37 RID: 93751
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
