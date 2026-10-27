using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA043
{
	// Token: 0x020041F9 RID: 16889
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA043/ABP_NA043.ABP_NA043_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA043_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BDA7 RID: 179623 RVA: 0x00A0C8CC File Offset: 0x00A0AACC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA043_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA043/ABP_NA043.ABP_NA043_C");
			}
			return ABP_NA043_C._ClassPtr;
		}

		// Token: 0x0602BDA8 RID: 179624 RVA: 0x00A0C8F0 File Offset: 0x00A0AAF0
		public ABP_NA043_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA043_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BDA9 RID: 179625 RVA: 0x00A0C918 File Offset: 0x00A0AB18
		[NullableContext(1)]
		public ABP_NA043_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA043_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BDAA RID: 179626 RVA: 0x00A0C94B File Offset: 0x00A0AB4B
		protected ABP_NA043_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E08 RID: 93704
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA043/ABP_NA043.ABP_NA043_C";

		// Token: 0x04016E09 RID: 93705
		private static IntPtr _ClassPtr;

		// Token: 0x04016E0A RID: 93706
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
