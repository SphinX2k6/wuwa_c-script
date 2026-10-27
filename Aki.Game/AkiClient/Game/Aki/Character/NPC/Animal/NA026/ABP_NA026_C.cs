using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA026
{
	// Token: 0x02004217 RID: 16919
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA026/ABP_NA026.ABP_NA026_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA026_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE3E RID: 179774 RVA: 0x00A0DD70 File Offset: 0x00A0BF70
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA026_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA026/ABP_NA026.ABP_NA026_C");
			}
			return ABP_NA026_C._ClassPtr;
		}

		// Token: 0x0602BE3F RID: 179775 RVA: 0x00A0DD94 File Offset: 0x00A0BF94
		public ABP_NA026_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA026_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE40 RID: 179776 RVA: 0x00A0DDBC File Offset: 0x00A0BFBC
		[NullableContext(1)]
		public ABP_NA026_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA026_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BE41 RID: 179777 RVA: 0x00A0DDEF File Offset: 0x00A0BFEF
		protected ABP_NA026_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E79 RID: 93817
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA026/ABP_NA026.ABP_NA026_C";

		// Token: 0x04016E7A RID: 93818
		private static IntPtr _ClassPtr;

		// Token: 0x04016E7B RID: 93819
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
