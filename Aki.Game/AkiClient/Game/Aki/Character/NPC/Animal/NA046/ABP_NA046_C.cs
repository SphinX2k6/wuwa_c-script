using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA046
{
	// Token: 0x020041F1 RID: 16881
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA046/ABP_NA046.ABP_NA046_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA046_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD87 RID: 179591 RVA: 0x00A0C48C File Offset: 0x00A0A68C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA046_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA046/ABP_NA046.ABP_NA046_C");
			}
			return ABP_NA046_C._ClassPtr;
		}

		// Token: 0x0602BD88 RID: 179592 RVA: 0x00A0C4B0 File Offset: 0x00A0A6B0
		public ABP_NA046_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA046_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD89 RID: 179593 RVA: 0x00A0C4D8 File Offset: 0x00A0A6D8
		[NullableContext(1)]
		public ABP_NA046_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA046_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BD8A RID: 179594 RVA: 0x00A0C50B File Offset: 0x00A0A70B
		protected ABP_NA046_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016DF0 RID: 93680
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA046/ABP_NA046.ABP_NA046_C";

		// Token: 0x04016DF1 RID: 93681
		private static IntPtr _ClassPtr;

		// Token: 0x04016DF2 RID: 93682
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
