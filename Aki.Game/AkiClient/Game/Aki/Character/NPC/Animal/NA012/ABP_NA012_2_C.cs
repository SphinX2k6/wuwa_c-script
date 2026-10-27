using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA012
{
	// Token: 0x0200422C RID: 16940
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA012/ABP_NA012_2.ABP_NA012_2_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA012_2_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BEA2 RID: 179874 RVA: 0x00A0EA8C File Offset: 0x00A0CC8C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA012_2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA012/ABP_NA012_2.ABP_NA012_2_C");
			}
			return ABP_NA012_2_C._ClassPtr;
		}

		// Token: 0x0602BEA3 RID: 179875 RVA: 0x00A0EAB0 File Offset: 0x00A0CCB0
		public ABP_NA012_2_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA012_2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BEA4 RID: 179876 RVA: 0x00A0EAD8 File Offset: 0x00A0CCD8
		[NullableContext(1)]
		public ABP_NA012_2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA012_2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BEA5 RID: 179877 RVA: 0x00A0EB0B File Offset: 0x00A0CD0B
		protected ABP_NA012_2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016EC2 RID: 93890
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA012/ABP_NA012_2.ABP_NA012_2_C";

		// Token: 0x04016EC3 RID: 93891
		private static IntPtr _ClassPtr;

		// Token: 0x04016EC4 RID: 93892
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
