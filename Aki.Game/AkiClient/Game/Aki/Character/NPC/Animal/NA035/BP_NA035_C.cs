using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonSmallAnimal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA035
{
	// Token: 0x0200420E RID: 16910
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA035/BP_NA035.BP_NA035_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2248)]
	public class BP_NA035_C : BP_CommonSmallAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE18 RID: 179736 RVA: 0x00A0D87C File Offset: 0x00A0BA7C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA035_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA035/BP_NA035.BP_NA035_C");
			}
			return BP_NA035_C._ClassPtr;
		}

		// Token: 0x0602BE19 RID: 179737 RVA: 0x00A0D8A0 File Offset: 0x00A0BAA0
		public BP_NA035_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA035_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE1A RID: 179738 RVA: 0x00A0D8C8 File Offset: 0x00A0BAC8
		[NullableContext(1)]
		public BP_NA035_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA035_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BE1B RID: 179739 RVA: 0x00A0D8FB File Offset: 0x00A0BAFB
		protected BP_NA035_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E5D RID: 93789
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA035/BP_NA035.BP_NA035_C";

		// Token: 0x04016E5E RID: 93790
		private static IntPtr _ClassPtr;

		// Token: 0x04016E5F RID: 93791
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
