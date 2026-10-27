using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA060
{
	// Token: 0x020041D4 RID: 16852
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA060/ABP_NA060.ABP_NA060_C")]
	[UnrealStructLayout(19248, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 19234)]
	public class ABP_NA060_C : ABP_BaseRunAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BCEC RID: 179436 RVA: 0x00A0B1FA File Offset: 0x00A093FA
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA060_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA060/ABP_NA060.ABP_NA060_C");
			}
			return ABP_NA060_C._ClassPtr;
		}

		// Token: 0x0602BCED RID: 179437 RVA: 0x00A0B220 File Offset: 0x00A09420
		public ABP_NA060_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA060_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BCEE RID: 179438 RVA: 0x00A0B248 File Offset: 0x00A09448
		[NullableContext(1)]
		public ABP_NA060_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA060_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BCEF RID: 179439 RVA: 0x00A0B27B File Offset: 0x00A0947B
		protected ABP_NA060_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D83 RID: 93571
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA060/ABP_NA060.ABP_NA060_C";

		// Token: 0x04016D84 RID: 93572
		private static IntPtr _ClassPtr;

		// Token: 0x04016D85 RID: 93573
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
