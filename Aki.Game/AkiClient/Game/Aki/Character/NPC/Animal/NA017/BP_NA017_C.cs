using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonBigAnimal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA017
{
	// Token: 0x02004222 RID: 16930
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA017/BP_NA017.BP_NA017_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2248)]
	public class BP_NA017_C : BP_CommonBigAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE76 RID: 179830 RVA: 0x00A0E484 File Offset: 0x00A0C684
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA017_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA017/BP_NA017.BP_NA017_C");
			}
			return BP_NA017_C._ClassPtr;
		}

		// Token: 0x0602BE77 RID: 179831 RVA: 0x00A0E4A8 File Offset: 0x00A0C6A8
		public BP_NA017_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA017_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE78 RID: 179832 RVA: 0x00A0E4D0 File Offset: 0x00A0C6D0
		[NullableContext(1)]
		public BP_NA017_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA017_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BE79 RID: 179833 RVA: 0x00A0E503 File Offset: 0x00A0C703
		protected BP_NA017_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016EA2 RID: 93858
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA017/BP_NA017.BP_NA017_C";

		// Token: 0x04016EA3 RID: 93859
		private static IntPtr _ClassPtr;

		// Token: 0x04016EA4 RID: 93860
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
