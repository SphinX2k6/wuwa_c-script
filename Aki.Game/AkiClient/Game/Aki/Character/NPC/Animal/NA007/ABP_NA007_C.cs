using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA007
{
	// Token: 0x02004234 RID: 16948
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA007/ABP_NA007.ABP_NA007_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA007_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BEC8 RID: 179912 RVA: 0x00A0EFAD File Offset: 0x00A0D1AD
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA007_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA007/ABP_NA007.ABP_NA007_C");
			}
			return ABP_NA007_C._ClassPtr;
		}

		// Token: 0x0602BEC9 RID: 179913 RVA: 0x00A0EFD4 File Offset: 0x00A0D1D4
		public ABP_NA007_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA007_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BECA RID: 179914 RVA: 0x00A0EFFC File Offset: 0x00A0D1FC
		[NullableContext(1)]
		public ABP_NA007_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA007_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BECB RID: 179915 RVA: 0x00A0F02F File Offset: 0x00A0D22F
		protected ABP_NA007_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016EDD RID: 93917
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA007/ABP_NA007.ABP_NA007_C";

		// Token: 0x04016EDE RID: 93918
		private static IntPtr _ClassPtr;

		// Token: 0x04016EDF RID: 93919
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
