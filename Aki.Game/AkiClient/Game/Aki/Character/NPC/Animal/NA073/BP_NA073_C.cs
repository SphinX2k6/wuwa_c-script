using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonBird;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA073
{
	// Token: 0x020041AA RID: 16810
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA073/BP_NA073.BP_NA073_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2248)]
	public class BP_NA073_C : BP_BaseBird_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC0A RID: 179210 RVA: 0x00A096F4 File Offset: 0x00A078F4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA073_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA073/BP_NA073.BP_NA073_C");
			}
			return BP_NA073_C._ClassPtr;
		}

		// Token: 0x0602BC0B RID: 179211 RVA: 0x00A09718 File Offset: 0x00A07918
		public BP_NA073_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA073_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BC0C RID: 179212 RVA: 0x00A09740 File Offset: 0x00A07940
		[NullableContext(1)]
		public BP_NA073_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA073_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BC0D RID: 179213 RVA: 0x00A09773 File Offset: 0x00A07973
		protected BP_NA073_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016CE8 RID: 93416
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA073/BP_NA073.BP_NA073_C";

		// Token: 0x04016CE9 RID: 93417
		private static IntPtr _ClassPtr;

		// Token: 0x04016CEA RID: 93418
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
