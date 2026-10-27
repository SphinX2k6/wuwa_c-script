using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonBird;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA038
{
	// Token: 0x02004207 RID: 16903
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA038/BP_NA038.BP_NA038_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2248)]
	public class BP_NA038_C : BP_BaseBird_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BDF4 RID: 179700 RVA: 0x00A0D420 File Offset: 0x00A0B620
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA038_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA038/BP_NA038.BP_NA038_C");
			}
			return BP_NA038_C._ClassPtr;
		}

		// Token: 0x0602BDF5 RID: 179701 RVA: 0x00A0D444 File Offset: 0x00A0B644
		public BP_NA038_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA038_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BDF6 RID: 179702 RVA: 0x00A0D46C File Offset: 0x00A0B66C
		[NullableContext(1)]
		public BP_NA038_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA038_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BDF7 RID: 179703 RVA: 0x00A0D49F File Offset: 0x00A0B69F
		protected BP_NA038_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E44 RID: 93764
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA038/BP_NA038.BP_NA038_C";

		// Token: 0x04016E45 RID: 93765
		private static IntPtr _ClassPtr;

		// Token: 0x04016E46 RID: 93766
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
