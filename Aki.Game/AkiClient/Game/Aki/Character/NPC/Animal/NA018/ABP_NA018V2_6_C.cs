using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA018
{
	// Token: 0x0200421B RID: 16923
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA018/ABP_NA018V2_6.ABP_NA018V2_6_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA018V2_6_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE52 RID: 179794 RVA: 0x00A0DFE5 File Offset: 0x00A0C1E5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA018V2_6_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA018/ABP_NA018V2_6.ABP_NA018V2_6_C");
			}
			return ABP_NA018V2_6_C._ClassPtr;
		}

		// Token: 0x0602BE53 RID: 179795 RVA: 0x00A0E00C File Offset: 0x00A0C20C
		public ABP_NA018V2_6_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA018V2_6_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE54 RID: 179796 RVA: 0x00A0E034 File Offset: 0x00A0C234
		[NullableContext(1)]
		public ABP_NA018V2_6_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA018V2_6_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BE55 RID: 179797 RVA: 0x00A0E067 File Offset: 0x00A0C267
		protected ABP_NA018V2_6_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E87 RID: 93831
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA018/ABP_NA018V2_6.ABP_NA018V2_6_C";

		// Token: 0x04016E88 RID: 93832
		private static IntPtr _ClassPtr;

		// Token: 0x04016E89 RID: 93833
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
