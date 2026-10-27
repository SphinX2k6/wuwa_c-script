using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonPet;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA012
{
	// Token: 0x0200422F RID: 16943
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA012/BP_NA012_little.BP_NA012_little_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2256)]
	public class BP_NA012_little_C : BP_CommonPet_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BEAE RID: 179886 RVA: 0x00A0EC24 File Offset: 0x00A0CE24
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA012_little_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA012/BP_NA012_little.BP_NA012_little_C");
			}
			return BP_NA012_little_C._ClassPtr;
		}

		// Token: 0x0602BEAF RID: 179887 RVA: 0x00A0EC48 File Offset: 0x00A0CE48
		public BP_NA012_little_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA012_little_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BEB0 RID: 179888 RVA: 0x00A0EC70 File Offset: 0x00A0CE70
		[NullableContext(1)]
		public BP_NA012_little_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA012_little_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BEB1 RID: 179889 RVA: 0x00A0ECA3 File Offset: 0x00A0CEA3
		protected BP_NA012_little_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016ECB RID: 93899
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA012/BP_NA012_little.BP_NA012_little_C";

		// Token: 0x04016ECC RID: 93900
		private static IntPtr _ClassPtr;

		// Token: 0x04016ECD RID: 93901
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
