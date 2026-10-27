using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA073
{
	// Token: 0x020041A9 RID: 16809
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA073/ABP_NA073.ABP_NA073_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA073_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC06 RID: 179206 RVA: 0x00A09669 File Offset: 0x00A07869
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA073_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA073/ABP_NA073.ABP_NA073_C");
			}
			return ABP_NA073_C._ClassPtr;
		}

		// Token: 0x0602BC07 RID: 179207 RVA: 0x00A09690 File Offset: 0x00A07890
		public ABP_NA073_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA073_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BC08 RID: 179208 RVA: 0x00A096B8 File Offset: 0x00A078B8
		[NullableContext(1)]
		public ABP_NA073_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA073_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BC09 RID: 179209 RVA: 0x00A096EB File Offset: 0x00A078EB
		protected ABP_NA073_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016CE5 RID: 93413
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA073/ABP_NA073.ABP_NA073_C";

		// Token: 0x04016CE6 RID: 93414
		private static IntPtr _ClassPtr;

		// Token: 0x04016CE7 RID: 93415
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
