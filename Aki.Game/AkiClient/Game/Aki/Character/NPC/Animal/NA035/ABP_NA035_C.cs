using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA035
{
	// Token: 0x0200420C RID: 16908
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA035/ABP_NA035.ABP_NA035_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA035_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE08 RID: 179720 RVA: 0x00A0D6C8 File Offset: 0x00A0B8C8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA035_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA035/ABP_NA035.ABP_NA035_C");
			}
			return ABP_NA035_C._ClassPtr;
		}

		// Token: 0x0602BE09 RID: 179721 RVA: 0x00A0D6EC File Offset: 0x00A0B8EC
		public ABP_NA035_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA035_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE0A RID: 179722 RVA: 0x00A0D714 File Offset: 0x00A0B914
		[NullableContext(1)]
		public ABP_NA035_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA035_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BE0B RID: 179723 RVA: 0x00A0D747 File Offset: 0x00A0B947
		protected ABP_NA035_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E53 RID: 93779
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA035/ABP_NA035.ABP_NA035_C";

		// Token: 0x04016E54 RID: 93780
		private static IntPtr _ClassPtr;

		// Token: 0x04016E55 RID: 93781
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
