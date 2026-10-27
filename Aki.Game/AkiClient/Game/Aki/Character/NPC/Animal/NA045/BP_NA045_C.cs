using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonSmallAnimal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA045
{
	// Token: 0x020041F6 RID: 16886
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA045/BP_NA045.BP_NA045_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2248)]
	public class BP_NA045_C : BP_CommonSmallAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD9B RID: 179611 RVA: 0x00A0C734 File Offset: 0x00A0A934
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA045_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA045/BP_NA045.BP_NA045_C");
			}
			return BP_NA045_C._ClassPtr;
		}

		// Token: 0x0602BD9C RID: 179612 RVA: 0x00A0C758 File Offset: 0x00A0A958
		public BP_NA045_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA045_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD9D RID: 179613 RVA: 0x00A0C780 File Offset: 0x00A0A980
		[NullableContext(1)]
		public BP_NA045_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA045_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BD9E RID: 179614 RVA: 0x00A0C7B3 File Offset: 0x00A0A9B3
		protected BP_NA045_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016DFF RID: 93695
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA045/BP_NA045.BP_NA045_C";

		// Token: 0x04016E00 RID: 93696
		private static IntPtr _ClassPtr;

		// Token: 0x04016E01 RID: 93697
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
