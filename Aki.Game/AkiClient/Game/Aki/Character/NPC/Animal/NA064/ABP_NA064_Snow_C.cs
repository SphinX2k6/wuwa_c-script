using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA064
{
	// Token: 0x020041C8 RID: 16840
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA064/ABP_NA064_Snow.ABP_NA064_Snow_C")]
	[UnrealStructLayout(19248, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 19234)]
	public class ABP_NA064_Snow_C : ABP_BaseRunAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BCA6 RID: 179366 RVA: 0x00A0A9D0 File Offset: 0x00A08BD0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA064_Snow_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA064/ABP_NA064_Snow.ABP_NA064_Snow_C");
			}
			return ABP_NA064_Snow_C._ClassPtr;
		}

		// Token: 0x0602BCA7 RID: 179367 RVA: 0x00A0A9F4 File Offset: 0x00A08BF4
		public ABP_NA064_Snow_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA064_Snow_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BCA8 RID: 179368 RVA: 0x00A0AA1C File Offset: 0x00A08C1C
		[NullableContext(1)]
		public ABP_NA064_Snow_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA064_Snow_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BCA9 RID: 179369 RVA: 0x00A0AA4F File Offset: 0x00A08C4F
		protected ABP_NA064_Snow_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D54 RID: 93524
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA064/ABP_NA064_Snow.ABP_NA064_Snow_C";

		// Token: 0x04016D55 RID: 93525
		private static IntPtr _ClassPtr;

		// Token: 0x04016D56 RID: 93526
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
