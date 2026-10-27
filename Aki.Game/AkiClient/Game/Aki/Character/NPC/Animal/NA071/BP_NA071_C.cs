using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonSmallAnimal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA071
{
	// Token: 0x020041AE RID: 16814
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA071/BP_NA071.BP_NA071_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2248)]
	public class BP_NA071_C : BP_CommonSmallAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC1A RID: 179226 RVA: 0x00A09914 File Offset: 0x00A07B14
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA071_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA071/BP_NA071.BP_NA071_C");
			}
			return BP_NA071_C._ClassPtr;
		}

		// Token: 0x0602BC1B RID: 179227 RVA: 0x00A09938 File Offset: 0x00A07B38
		public BP_NA071_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA071_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BC1C RID: 179228 RVA: 0x00A09960 File Offset: 0x00A07B60
		[NullableContext(1)]
		public BP_NA071_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA071_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BC1D RID: 179229 RVA: 0x00A09993 File Offset: 0x00A07B93
		protected BP_NA071_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016CF4 RID: 93428
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA071/BP_NA071.BP_NA071_C";

		// Token: 0x04016CF5 RID: 93429
		private static IntPtr _ClassPtr;

		// Token: 0x04016CF6 RID: 93430
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
