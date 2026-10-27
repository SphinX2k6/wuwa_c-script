using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA048
{
	// Token: 0x020041ED RID: 16877
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA048/ABP_NA048.ABP_NA048_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA048_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD77 RID: 179575 RVA: 0x00A0C26C File Offset: 0x00A0A46C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA048_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA048/ABP_NA048.ABP_NA048_C");
			}
			return ABP_NA048_C._ClassPtr;
		}

		// Token: 0x0602BD78 RID: 179576 RVA: 0x00A0C290 File Offset: 0x00A0A490
		public ABP_NA048_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA048_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD79 RID: 179577 RVA: 0x00A0C2B8 File Offset: 0x00A0A4B8
		[NullableContext(1)]
		public ABP_NA048_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA048_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BD7A RID: 179578 RVA: 0x00A0C2EB File Offset: 0x00A0A4EB
		protected ABP_NA048_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016DE4 RID: 93668
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA048/ABP_NA048.ABP_NA048_C";

		// Token: 0x04016DE5 RID: 93669
		private static IntPtr _ClassPtr;

		// Token: 0x04016DE6 RID: 93670
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
