using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonPet;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA048
{
	// Token: 0x020041EF RID: 16879
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA048/BP_NA048.BP_NA048_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2256)]
	public class BP_NA048_C : BP_CommonPet_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD7F RID: 179583 RVA: 0x00A0C37C File Offset: 0x00A0A57C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA048_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA048/BP_NA048.BP_NA048_C");
			}
			return BP_NA048_C._ClassPtr;
		}

		// Token: 0x0602BD80 RID: 179584 RVA: 0x00A0C3A0 File Offset: 0x00A0A5A0
		public BP_NA048_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA048_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD81 RID: 179585 RVA: 0x00A0C3C8 File Offset: 0x00A0A5C8
		[NullableContext(1)]
		public BP_NA048_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA048_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BD82 RID: 179586 RVA: 0x00A0C3FB File Offset: 0x00A0A5FB
		protected BP_NA048_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016DEA RID: 93674
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA048/BP_NA048.BP_NA048_C";

		// Token: 0x04016DEB RID: 93675
		private static IntPtr _ClassPtr;

		// Token: 0x04016DEC RID: 93676
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
