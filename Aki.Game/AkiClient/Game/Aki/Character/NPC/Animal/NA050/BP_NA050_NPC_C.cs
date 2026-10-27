using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA050
{
	// Token: 0x020041EC RID: 16876
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA050/BP_NA050_NPC.BP_NA050_NPC_C")]
	[UnrealStructLayout(2336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2330)]
	public class BP_NA050_NPC_C : BP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD73 RID: 179571 RVA: 0x00A0C1E4 File Offset: 0x00A0A3E4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA050_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA050/BP_NA050_NPC.BP_NA050_NPC_C");
			}
			return BP_NA050_NPC_C._ClassPtr;
		}

		// Token: 0x0602BD74 RID: 179572 RVA: 0x00A0C208 File Offset: 0x00A0A408
		public BP_NA050_NPC_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA050_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD75 RID: 179573 RVA: 0x00A0C230 File Offset: 0x00A0A430
		[NullableContext(1)]
		public BP_NA050_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA050_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BD76 RID: 179574 RVA: 0x00A0C263 File Offset: 0x00A0A463
		protected BP_NA050_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016DE1 RID: 93665
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA050/BP_NA050_NPC.BP_NA050_NPC_C";

		// Token: 0x04016DE2 RID: 93666
		private static IntPtr _ClassPtr;

		// Token: 0x04016DE3 RID: 93667
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
