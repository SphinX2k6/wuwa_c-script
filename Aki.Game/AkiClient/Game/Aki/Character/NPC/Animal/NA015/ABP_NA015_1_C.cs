using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA015
{
	// Token: 0x02004223 RID: 16931
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA015/ABP_NA015_1.ABP_NA015_1_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA015_1_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE7A RID: 179834 RVA: 0x00A0E50C File Offset: 0x00A0C70C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA015_1_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA015/ABP_NA015_1.ABP_NA015_1_C");
			}
			return ABP_NA015_1_C._ClassPtr;
		}

		// Token: 0x0602BE7B RID: 179835 RVA: 0x00A0E530 File Offset: 0x00A0C730
		public ABP_NA015_1_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA015_1_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE7C RID: 179836 RVA: 0x00A0E558 File Offset: 0x00A0C758
		[NullableContext(1)]
		public ABP_NA015_1_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA015_1_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BE7D RID: 179837 RVA: 0x00A0E58B File Offset: 0x00A0C78B
		protected ABP_NA015_1_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016EA5 RID: 93861
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA015/ABP_NA015_1.ABP_NA015_1_C";

		// Token: 0x04016EA6 RID: 93862
		private static IntPtr _ClassPtr;

		// Token: 0x04016EA7 RID: 93863
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
