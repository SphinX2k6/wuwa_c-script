using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA037
{
	// Token: 0x02004208 RID: 16904
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA037/ABP_NA037.ABP_NA037_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA037_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BDF8 RID: 179704 RVA: 0x00A0D4A8 File Offset: 0x00A0B6A8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA037_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA037/ABP_NA037.ABP_NA037_C");
			}
			return ABP_NA037_C._ClassPtr;
		}

		// Token: 0x0602BDF9 RID: 179705 RVA: 0x00A0D4CC File Offset: 0x00A0B6CC
		public ABP_NA037_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA037_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BDFA RID: 179706 RVA: 0x00A0D4F4 File Offset: 0x00A0B6F4
		[NullableContext(1)]
		public ABP_NA037_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA037_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BDFB RID: 179707 RVA: 0x00A0D527 File Offset: 0x00A0B727
		protected ABP_NA037_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E47 RID: 93767
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA037/ABP_NA037.ABP_NA037_C";

		// Token: 0x04016E48 RID: 93768
		private static IntPtr _ClassPtr;

		// Token: 0x04016E49 RID: 93769
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
