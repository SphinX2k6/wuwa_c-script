using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA015
{
	// Token: 0x02004226 RID: 16934
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA015/ABP_NA015_Swim.ABP_NA015_Swim_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA015_Swim_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE86 RID: 179846 RVA: 0x00A0E6A4 File Offset: 0x00A0C8A4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA015_Swim_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA015/ABP_NA015_Swim.ABP_NA015_Swim_C");
			}
			return ABP_NA015_Swim_C._ClassPtr;
		}

		// Token: 0x0602BE87 RID: 179847 RVA: 0x00A0E6C8 File Offset: 0x00A0C8C8
		public ABP_NA015_Swim_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA015_Swim_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE88 RID: 179848 RVA: 0x00A0E6F0 File Offset: 0x00A0C8F0
		[NullableContext(1)]
		public ABP_NA015_Swim_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA015_Swim_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BE89 RID: 179849 RVA: 0x00A0E723 File Offset: 0x00A0C923
		protected ABP_NA015_Swim_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016EAE RID: 93870
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA015/ABP_NA015_Swim.ABP_NA015_Swim_C";

		// Token: 0x04016EAF RID: 93871
		private static IntPtr _ClassPtr;

		// Token: 0x04016EB0 RID: 93872
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
