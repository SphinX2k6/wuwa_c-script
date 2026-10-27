using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonPet;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA012
{
	// Token: 0x0200422E RID: 16942
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA012/BP_NA012.BP_NA012_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2256)]
	public class BP_NA012_C : BP_CommonPet_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BEAA RID: 179882 RVA: 0x00A0EB9C File Offset: 0x00A0CD9C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA012_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA012/BP_NA012.BP_NA012_C");
			}
			return BP_NA012_C._ClassPtr;
		}

		// Token: 0x0602BEAB RID: 179883 RVA: 0x00A0EBC0 File Offset: 0x00A0CDC0
		public BP_NA012_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA012_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BEAC RID: 179884 RVA: 0x00A0EBE8 File Offset: 0x00A0CDE8
		[NullableContext(1)]
		public BP_NA012_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA012_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BEAD RID: 179885 RVA: 0x00A0EC1B File Offset: 0x00A0CE1B
		protected BP_NA012_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016EC8 RID: 93896
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA012/BP_NA012.BP_NA012_C";

		// Token: 0x04016EC9 RID: 93897
		private static IntPtr _ClassPtr;

		// Token: 0x04016ECA RID: 93898
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
