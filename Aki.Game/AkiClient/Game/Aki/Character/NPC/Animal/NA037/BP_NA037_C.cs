using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.NA004;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA037
{
	// Token: 0x02004209 RID: 16905
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA037/BP_NA037.BP_NA037_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2248)]
	public class BP_NA037_C : BP_NA004_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BDFC RID: 179708 RVA: 0x00A0D530 File Offset: 0x00A0B730
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA037_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA037/BP_NA037.BP_NA037_C");
			}
			return BP_NA037_C._ClassPtr;
		}

		// Token: 0x0602BDFD RID: 179709 RVA: 0x00A0D554 File Offset: 0x00A0B754
		public BP_NA037_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA037_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BDFE RID: 179710 RVA: 0x00A0D57C File Offset: 0x00A0B77C
		[NullableContext(1)]
		public BP_NA037_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA037_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BDFF RID: 179711 RVA: 0x00A0D5AF File Offset: 0x00A0B7AF
		protected BP_NA037_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E4A RID: 93770
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA037/BP_NA037.BP_NA037_C";

		// Token: 0x04016E4B RID: 93771
		private static IntPtr _ClassPtr;

		// Token: 0x04016E4C RID: 93772
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
