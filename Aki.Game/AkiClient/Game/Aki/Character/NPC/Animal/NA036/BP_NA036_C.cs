using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonBird;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA036
{
	// Token: 0x0200420B RID: 16907
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA036/BP_NA036.BP_NA036_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2248)]
	public class BP_NA036_C : BP_BaseBird_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE04 RID: 179716 RVA: 0x00A0D640 File Offset: 0x00A0B840
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA036_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA036/BP_NA036.BP_NA036_C");
			}
			return BP_NA036_C._ClassPtr;
		}

		// Token: 0x0602BE05 RID: 179717 RVA: 0x00A0D664 File Offset: 0x00A0B864
		public BP_NA036_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA036_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE06 RID: 179718 RVA: 0x00A0D68C File Offset: 0x00A0B88C
		[NullableContext(1)]
		public BP_NA036_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA036_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BE07 RID: 179719 RVA: 0x00A0D6BF File Offset: 0x00A0B8BF
		protected BP_NA036_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E50 RID: 93776
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA036/BP_NA036.BP_NA036_C";

		// Token: 0x04016E51 RID: 93777
		private static IntPtr _ClassPtr;

		// Token: 0x04016E52 RID: 93778
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
