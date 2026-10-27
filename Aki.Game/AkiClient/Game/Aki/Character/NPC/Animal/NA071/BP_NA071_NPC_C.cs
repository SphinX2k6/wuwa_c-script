using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA071
{
	// Token: 0x020041AF RID: 16815
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA071/BP_NA071_NPC.BP_NA071_NPC_C")]
	[UnrealStructLayout(2336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2330)]
	public class BP_NA071_NPC_C : BP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC1E RID: 179230 RVA: 0x00A0999C File Offset: 0x00A07B9C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA071_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA071/BP_NA071_NPC.BP_NA071_NPC_C");
			}
			return BP_NA071_NPC_C._ClassPtr;
		}

		// Token: 0x0602BC1F RID: 179231 RVA: 0x00A099C0 File Offset: 0x00A07BC0
		public BP_NA071_NPC_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA071_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BC20 RID: 179232 RVA: 0x00A099E8 File Offset: 0x00A07BE8
		[NullableContext(1)]
		public BP_NA071_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA071_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BC21 RID: 179233 RVA: 0x00A09A1B File Offset: 0x00A07C1B
		protected BP_NA071_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016CF7 RID: 93431
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA071/BP_NA071_NPC.BP_NA071_NPC_C";

		// Token: 0x04016CF8 RID: 93432
		private static IntPtr _ClassPtr;

		// Token: 0x04016CF9 RID: 93433
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
