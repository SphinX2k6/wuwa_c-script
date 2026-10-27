using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA043.Spec
{
	// Token: 0x020041FB RID: 16891
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA043/Spec/ABP_NA043_Spec.ABP_NA043_Spec_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA043_Spec_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BDB7 RID: 179639 RVA: 0x00A0CAC0 File Offset: 0x00A0ACC0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA043_Spec_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA043/Spec/ABP_NA043_Spec.ABP_NA043_Spec_C");
			}
			return ABP_NA043_Spec_C._ClassPtr;
		}

		// Token: 0x0602BDB8 RID: 179640 RVA: 0x00A0CAE4 File Offset: 0x00A0ACE4
		public ABP_NA043_Spec_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA043_Spec_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BDB9 RID: 179641 RVA: 0x00A0CB0C File Offset: 0x00A0AD0C
		[NullableContext(1)]
		public ABP_NA043_Spec_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA043_Spec_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BDBA RID: 179642 RVA: 0x00A0CB3F File Offset: 0x00A0AD3F
		protected ABP_NA043_Spec_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E14 RID: 93716
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA043/Spec/ABP_NA043_Spec.ABP_NA043_Spec_C";

		// Token: 0x04016E15 RID: 93717
		private static IntPtr _ClassPtr;

		// Token: 0x04016E16 RID: 93718
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
