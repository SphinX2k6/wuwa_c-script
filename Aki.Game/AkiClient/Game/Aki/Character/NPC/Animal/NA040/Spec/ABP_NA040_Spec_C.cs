using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA040.Spec
{
	// Token: 0x02004203 RID: 16899
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA040/Spec/ABP_NA040_Spec.ABP_NA040_Spec_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA040_Spec_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BDE4 RID: 179684 RVA: 0x00A0D200 File Offset: 0x00A0B400
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA040_Spec_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA040/Spec/ABP_NA040_Spec.ABP_NA040_Spec_C");
			}
			return ABP_NA040_Spec_C._ClassPtr;
		}

		// Token: 0x0602BDE5 RID: 179685 RVA: 0x00A0D224 File Offset: 0x00A0B424
		public ABP_NA040_Spec_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA040_Spec_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BDE6 RID: 179686 RVA: 0x00A0D24C File Offset: 0x00A0B44C
		[NullableContext(1)]
		public ABP_NA040_Spec_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA040_Spec_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BDE7 RID: 179687 RVA: 0x00A0D27F File Offset: 0x00A0B47F
		protected ABP_NA040_Spec_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E38 RID: 93752
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA040/Spec/ABP_NA040_Spec.ABP_NA040_Spec_C";

		// Token: 0x04016E39 RID: 93753
		private static IntPtr _ClassPtr;

		// Token: 0x04016E3A RID: 93754
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
