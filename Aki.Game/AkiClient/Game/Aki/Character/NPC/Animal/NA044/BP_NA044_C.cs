using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonBird;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA044
{
	// Token: 0x020041F8 RID: 16888
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA044/BP_NA044.BP_NA044_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2248)]
	public class BP_NA044_C : BP_BaseBird_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BDA3 RID: 179619 RVA: 0x00A0C844 File Offset: 0x00A0AA44
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA044_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA044/BP_NA044.BP_NA044_C");
			}
			return BP_NA044_C._ClassPtr;
		}

		// Token: 0x0602BDA4 RID: 179620 RVA: 0x00A0C868 File Offset: 0x00A0AA68
		public BP_NA044_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA044_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BDA5 RID: 179621 RVA: 0x00A0C890 File Offset: 0x00A0AA90
		[NullableContext(1)]
		public BP_NA044_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA044_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BDA6 RID: 179622 RVA: 0x00A0C8C3 File Offset: 0x00A0AAC3
		protected BP_NA044_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E05 RID: 93701
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA044/BP_NA044.BP_NA044_C";

		// Token: 0x04016E06 RID: 93702
		private static IntPtr _ClassPtr;

		// Token: 0x04016E07 RID: 93703
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
