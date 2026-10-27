using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal.CommonPet;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA015
{
	// Token: 0x02004228 RID: 16936
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA015/BP_NA015.BP_NA015_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2256)]
	public class BP_NA015_C : BP_CommonPet_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE8E RID: 179854 RVA: 0x00A0E7B4 File Offset: 0x00A0C9B4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA015_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA015/BP_NA015.BP_NA015_C");
			}
			return BP_NA015_C._ClassPtr;
		}

		// Token: 0x0602BE8F RID: 179855 RVA: 0x00A0E7D8 File Offset: 0x00A0C9D8
		public BP_NA015_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA015_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE90 RID: 179856 RVA: 0x00A0E800 File Offset: 0x00A0CA00
		[NullableContext(1)]
		public BP_NA015_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA015_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BE91 RID: 179857 RVA: 0x00A0E833 File Offset: 0x00A0CA33
		protected BP_NA015_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016EB4 RID: 93876
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA015/BP_NA015.BP_NA015_C";

		// Token: 0x04016EB5 RID: 93877
		private static IntPtr _ClassPtr;

		// Token: 0x04016EB6 RID: 93878
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
