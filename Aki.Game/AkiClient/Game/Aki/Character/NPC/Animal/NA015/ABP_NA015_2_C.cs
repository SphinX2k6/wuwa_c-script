using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA015
{
	// Token: 0x02004224 RID: 16932
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA015/ABP_NA015_2.ABP_NA015_2_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA015_2_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE7E RID: 179838 RVA: 0x00A0E594 File Offset: 0x00A0C794
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA015_2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA015/ABP_NA015_2.ABP_NA015_2_C");
			}
			return ABP_NA015_2_C._ClassPtr;
		}

		// Token: 0x0602BE7F RID: 179839 RVA: 0x00A0E5B8 File Offset: 0x00A0C7B8
		public ABP_NA015_2_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA015_2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE80 RID: 179840 RVA: 0x00A0E5E0 File Offset: 0x00A0C7E0
		[NullableContext(1)]
		public ABP_NA015_2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA015_2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BE81 RID: 179841 RVA: 0x00A0E613 File Offset: 0x00A0C813
		protected ABP_NA015_2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016EA8 RID: 93864
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA015/ABP_NA015_2.ABP_NA015_2_C";

		// Token: 0x04016EA9 RID: 93865
		private static IntPtr _ClassPtr;

		// Token: 0x04016EAA RID: 93866
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
