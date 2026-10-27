using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA041
{
	// Token: 0x020041FF RID: 16895
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA041/ABP_NA041.ABP_NA041_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA041_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BDD4 RID: 179668 RVA: 0x00A0CFDD File Offset: 0x00A0B1DD
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA041_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA041/ABP_NA041.ABP_NA041_C");
			}
			return ABP_NA041_C._ClassPtr;
		}

		// Token: 0x0602BDD5 RID: 179669 RVA: 0x00A0D004 File Offset: 0x00A0B204
		public ABP_NA041_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA041_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BDD6 RID: 179670 RVA: 0x00A0D02C File Offset: 0x00A0B22C
		[NullableContext(1)]
		public ABP_NA041_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA041_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BDD7 RID: 179671 RVA: 0x00A0D05F File Offset: 0x00A0B25F
		protected ABP_NA041_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E2C RID: 93740
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA041/ABP_NA041.ABP_NA041_C";

		// Token: 0x04016E2D RID: 93741
		private static IntPtr _ClassPtr;

		// Token: 0x04016E2E RID: 93742
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
