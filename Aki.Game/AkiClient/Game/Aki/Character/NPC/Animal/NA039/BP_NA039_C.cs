using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonBird;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA039
{
	// Token: 0x02004205 RID: 16901
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA039/BP_NA039.BP_NA039_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2248)]
	public class BP_NA039_C : BP_BaseBird_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BDEC RID: 179692 RVA: 0x00A0D310 File Offset: 0x00A0B510
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA039_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA039/BP_NA039.BP_NA039_C");
			}
			return BP_NA039_C._ClassPtr;
		}

		// Token: 0x0602BDED RID: 179693 RVA: 0x00A0D334 File Offset: 0x00A0B534
		public BP_NA039_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA039_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BDEE RID: 179694 RVA: 0x00A0D35C File Offset: 0x00A0B55C
		[NullableContext(1)]
		public BP_NA039_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA039_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BDEF RID: 179695 RVA: 0x00A0D38F File Offset: 0x00A0B58F
		protected BP_NA039_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E3E RID: 93758
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA039/BP_NA039.BP_NA039_C";

		// Token: 0x04016E3F RID: 93759
		private static IntPtr _ClassPtr;

		// Token: 0x04016E40 RID: 93760
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
