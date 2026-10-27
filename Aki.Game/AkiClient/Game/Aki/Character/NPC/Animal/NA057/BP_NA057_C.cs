using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonBird;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA057
{
	// Token: 0x020041DF RID: 16863
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA057/BP_NA057.BP_NA057_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2248)]
	public class BP_NA057_C : BP_BaseBird_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD37 RID: 179511 RVA: 0x00A0BA54 File Offset: 0x00A09C54
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA057_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA057/BP_NA057.BP_NA057_C");
			}
			return BP_NA057_C._ClassPtr;
		}

		// Token: 0x0602BD38 RID: 179512 RVA: 0x00A0BA78 File Offset: 0x00A09C78
		public BP_NA057_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA057_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD39 RID: 179513 RVA: 0x00A0BAA0 File Offset: 0x00A09CA0
		[NullableContext(1)]
		public BP_NA057_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA057_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BD3A RID: 179514 RVA: 0x00A0BAD3 File Offset: 0x00A09CD3
		protected BP_NA057_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016DB6 RID: 93622
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA057/BP_NA057.BP_NA057_C";

		// Token: 0x04016DB7 RID: 93623
		private static IntPtr _ClassPtr;

		// Token: 0x04016DB8 RID: 93624
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
