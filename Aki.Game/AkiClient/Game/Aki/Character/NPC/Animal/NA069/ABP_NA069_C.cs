using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA069
{
	// Token: 0x020041B4 RID: 16820
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA069/ABP_NA069.ABP_NA069_C")]
	[UnrealStructLayout(19248, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 19234)]
	public class ABP_NA069_C : ABP_BaseRunAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC34 RID: 179252 RVA: 0x00A09C70 File Offset: 0x00A07E70
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA069_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA069/ABP_NA069.ABP_NA069_C");
			}
			return ABP_NA069_C._ClassPtr;
		}

		// Token: 0x0602BC35 RID: 179253 RVA: 0x00A09C94 File Offset: 0x00A07E94
		public ABP_NA069_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA069_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BC36 RID: 179254 RVA: 0x00A09CBC File Offset: 0x00A07EBC
		[NullableContext(1)]
		public ABP_NA069_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA069_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BC37 RID: 179255 RVA: 0x00A09CEF File Offset: 0x00A07EEF
		protected ABP_NA069_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D07 RID: 93447
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA069/ABP_NA069.ABP_NA069_C";

		// Token: 0x04016D08 RID: 93448
		private static IntPtr _ClassPtr;

		// Token: 0x04016D09 RID: 93449
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
