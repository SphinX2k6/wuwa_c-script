using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA068
{
	// Token: 0x020041B7 RID: 16823
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA068/ABP_NA068.ABP_NA068_C")]
	[UnrealStructLayout(19248, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 19234)]
	public class ABP_NA068_C : ABP_BaseRunAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC46 RID: 179270 RVA: 0x00A09E84 File Offset: 0x00A08084
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA068_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA068/ABP_NA068.ABP_NA068_C");
			}
			return ABP_NA068_C._ClassPtr;
		}

		// Token: 0x0602BC47 RID: 179271 RVA: 0x00A09EA8 File Offset: 0x00A080A8
		public ABP_NA068_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA068_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BC48 RID: 179272 RVA: 0x00A09ED0 File Offset: 0x00A080D0
		[NullableContext(1)]
		public ABP_NA068_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA068_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BC49 RID: 179273 RVA: 0x00A09F03 File Offset: 0x00A08103
		protected ABP_NA068_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D13 RID: 93459
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA068/ABP_NA068.ABP_NA068_C";

		// Token: 0x04016D14 RID: 93460
		private static IntPtr _ClassPtr;

		// Token: 0x04016D15 RID: 93461
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
