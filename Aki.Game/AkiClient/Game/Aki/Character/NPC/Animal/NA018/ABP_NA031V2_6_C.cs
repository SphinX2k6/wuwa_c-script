using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA018
{
	// Token: 0x0200421E RID: 16926
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA018/ABP_NA031V2_6.ABP_NA031V2_6_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA031V2_6_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE5E RID: 179806 RVA: 0x00A0E180 File Offset: 0x00A0C380
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA031V2_6_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA018/ABP_NA031V2_6.ABP_NA031V2_6_C");
			}
			return ABP_NA031V2_6_C._ClassPtr;
		}

		// Token: 0x0602BE5F RID: 179807 RVA: 0x00A0E1A4 File Offset: 0x00A0C3A4
		public ABP_NA031V2_6_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA031V2_6_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE60 RID: 179808 RVA: 0x00A0E1CC File Offset: 0x00A0C3CC
		[NullableContext(1)]
		public ABP_NA031V2_6_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA031V2_6_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BE61 RID: 179809 RVA: 0x00A0E1FF File Offset: 0x00A0C3FF
		protected ABP_NA031V2_6_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E90 RID: 93840
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA018/ABP_NA031V2_6.ABP_NA031V2_6_C";

		// Token: 0x04016E91 RID: 93841
		private static IntPtr _ClassPtr;

		// Token: 0x04016E92 RID: 93842
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
