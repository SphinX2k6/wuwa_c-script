using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA034
{
	// Token: 0x02004210 RID: 16912
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA034/ABP_NA034.ABP_NA034_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA034_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE20 RID: 179744 RVA: 0x00A0D98C File Offset: 0x00A0BB8C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA034_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA034/ABP_NA034.ABP_NA034_C");
			}
			return ABP_NA034_C._ClassPtr;
		}

		// Token: 0x0602BE21 RID: 179745 RVA: 0x00A0D9B0 File Offset: 0x00A0BBB0
		public ABP_NA034_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA034_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE22 RID: 179746 RVA: 0x00A0D9D8 File Offset: 0x00A0BBD8
		[NullableContext(1)]
		public ABP_NA034_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA034_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BE23 RID: 179747 RVA: 0x00A0DA0B File Offset: 0x00A0BC0B
		protected ABP_NA034_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E63 RID: 93795
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA034/ABP_NA034.ABP_NA034_C";

		// Token: 0x04016E64 RID: 93796
		private static IntPtr _ClassPtr;

		// Token: 0x04016E65 RID: 93797
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
