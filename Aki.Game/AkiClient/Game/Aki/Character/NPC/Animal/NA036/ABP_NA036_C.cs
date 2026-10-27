using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA036
{
	// Token: 0x0200420A RID: 16906
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA036/ABP_NA036.ABP_NA036_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA036_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE00 RID: 179712 RVA: 0x00A0D5B8 File Offset: 0x00A0B7B8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA036_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA036/ABP_NA036.ABP_NA036_C");
			}
			return ABP_NA036_C._ClassPtr;
		}

		// Token: 0x0602BE01 RID: 179713 RVA: 0x00A0D5DC File Offset: 0x00A0B7DC
		public ABP_NA036_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA036_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE02 RID: 179714 RVA: 0x00A0D604 File Offset: 0x00A0B804
		[NullableContext(1)]
		public ABP_NA036_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA036_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BE03 RID: 179715 RVA: 0x00A0D637 File Offset: 0x00A0B837
		protected ABP_NA036_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E4D RID: 93773
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA036/ABP_NA036.ABP_NA036_C";

		// Token: 0x04016E4E RID: 93774
		private static IntPtr _ClassPtr;

		// Token: 0x04016E4F RID: 93775
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
