using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA015
{
	// Token: 0x02004229 RID: 16937
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA015/BP_NA015_NPC.BP_NA015_NPC_C")]
	[UnrealStructLayout(2336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2330)]
	public class BP_NA015_NPC_C : BP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE92 RID: 179858 RVA: 0x00A0E83C File Offset: 0x00A0CA3C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA015_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA015/BP_NA015_NPC.BP_NA015_NPC_C");
			}
			return BP_NA015_NPC_C._ClassPtr;
		}

		// Token: 0x0602BE93 RID: 179859 RVA: 0x00A0E860 File Offset: 0x00A0CA60
		public BP_NA015_NPC_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA015_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE94 RID: 179860 RVA: 0x00A0E888 File Offset: 0x00A0CA88
		[NullableContext(1)]
		public BP_NA015_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA015_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BE95 RID: 179861 RVA: 0x00A0E8BB File Offset: 0x00A0CABB
		protected BP_NA015_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016EB7 RID: 93879
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA015/BP_NA015_NPC.BP_NA015_NPC_C";

		// Token: 0x04016EB8 RID: 93880
		private static IntPtr _ClassPtr;

		// Token: 0x04016EB9 RID: 93881
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
