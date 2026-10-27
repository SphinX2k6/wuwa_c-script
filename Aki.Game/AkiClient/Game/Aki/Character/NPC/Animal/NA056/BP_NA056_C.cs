using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonSmallAnimal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA056
{
	// Token: 0x020041E1 RID: 16865
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA056/BP_NA056.BP_NA056_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2248)]
	public class BP_NA056_C : BP_CommonSmallAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD3F RID: 179519 RVA: 0x00A0BB64 File Offset: 0x00A09D64
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA056_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA056/BP_NA056.BP_NA056_C");
			}
			return BP_NA056_C._ClassPtr;
		}

		// Token: 0x0602BD40 RID: 179520 RVA: 0x00A0BB88 File Offset: 0x00A09D88
		public BP_NA056_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA056_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD41 RID: 179521 RVA: 0x00A0BBB0 File Offset: 0x00A09DB0
		[NullableContext(1)]
		public BP_NA056_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA056_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BD42 RID: 179522 RVA: 0x00A0BBE3 File Offset: 0x00A09DE3
		protected BP_NA056_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016DBC RID: 93628
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA056/BP_NA056.BP_NA056_C";

		// Token: 0x04016DBD RID: 93629
		private static IntPtr _ClassPtr;

		// Token: 0x04016DBE RID: 93630
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
