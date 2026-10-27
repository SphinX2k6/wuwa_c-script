using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonPet;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA046
{
	// Token: 0x020041F3 RID: 16883
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA046/BP_NA046.BP_NA046_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2256)]
	public class BP_NA046_C : BP_CommonPet_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD8F RID: 179599 RVA: 0x00A0C59C File Offset: 0x00A0A79C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA046_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA046/BP_NA046.BP_NA046_C");
			}
			return BP_NA046_C._ClassPtr;
		}

		// Token: 0x0602BD90 RID: 179600 RVA: 0x00A0C5C0 File Offset: 0x00A0A7C0
		public BP_NA046_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA046_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD91 RID: 179601 RVA: 0x00A0C5E8 File Offset: 0x00A0A7E8
		[NullableContext(1)]
		public BP_NA046_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA046_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BD92 RID: 179602 RVA: 0x00A0C61B File Offset: 0x00A0A81B
		protected BP_NA046_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016DF6 RID: 93686
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA046/BP_NA046.BP_NA046_C";

		// Token: 0x04016DF7 RID: 93687
		private static IntPtr _ClassPtr;

		// Token: 0x04016DF8 RID: 93688
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
