using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonBird;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA007
{
	// Token: 0x02004236 RID: 16950
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA007/BP_NA007.BP_NA007_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2248)]
	public class BP_NA007_C : BP_BaseBird_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BED0 RID: 179920 RVA: 0x00A0F0C0 File Offset: 0x00A0D2C0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA007_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA007/BP_NA007.BP_NA007_C");
			}
			return BP_NA007_C._ClassPtr;
		}

		// Token: 0x0602BED1 RID: 179921 RVA: 0x00A0F0E4 File Offset: 0x00A0D2E4
		public BP_NA007_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA007_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BED2 RID: 179922 RVA: 0x00A0F10C File Offset: 0x00A0D30C
		[NullableContext(1)]
		public BP_NA007_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA007_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BED3 RID: 179923 RVA: 0x00A0F13F File Offset: 0x00A0D33F
		protected BP_NA007_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016EE3 RID: 93923
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA007/BP_NA007.BP_NA007_C";

		// Token: 0x04016EE4 RID: 93924
		private static IntPtr _ClassPtr;

		// Token: 0x04016EE5 RID: 93925
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
