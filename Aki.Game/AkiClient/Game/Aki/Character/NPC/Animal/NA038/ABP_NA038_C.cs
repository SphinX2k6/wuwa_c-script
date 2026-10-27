using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA038
{
	// Token: 0x02004206 RID: 16902
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA038/ABP_NA038.ABP_NA038_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA038_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BDF0 RID: 179696 RVA: 0x00A0D398 File Offset: 0x00A0B598
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA038_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA038/ABP_NA038.ABP_NA038_C");
			}
			return ABP_NA038_C._ClassPtr;
		}

		// Token: 0x0602BDF1 RID: 179697 RVA: 0x00A0D3BC File Offset: 0x00A0B5BC
		public ABP_NA038_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA038_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BDF2 RID: 179698 RVA: 0x00A0D3E4 File Offset: 0x00A0B5E4
		[NullableContext(1)]
		public ABP_NA038_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA038_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BDF3 RID: 179699 RVA: 0x00A0D417 File Offset: 0x00A0B617
		protected ABP_NA038_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E41 RID: 93761
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA038/ABP_NA038.ABP_NA038_C";

		// Token: 0x04016E42 RID: 93762
		private static IntPtr _ClassPtr;

		// Token: 0x04016E43 RID: 93763
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
