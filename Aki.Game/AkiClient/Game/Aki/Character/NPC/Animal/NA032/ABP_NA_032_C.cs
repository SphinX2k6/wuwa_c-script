using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA032
{
	// Token: 0x02004212 RID: 16914
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA032/ABP_NA_032.ABP_NA_032_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA_032_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE2A RID: 179754 RVA: 0x00A0DAC5 File Offset: 0x00A0BCC5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA_032_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA032/ABP_NA_032.ABP_NA_032_C");
			}
			return ABP_NA_032_C._ClassPtr;
		}

		// Token: 0x0602BE2B RID: 179755 RVA: 0x00A0DAEC File Offset: 0x00A0BCEC
		public ABP_NA_032_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA_032_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE2C RID: 179756 RVA: 0x00A0DB14 File Offset: 0x00A0BD14
		[NullableContext(1)]
		public ABP_NA_032_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA_032_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BE2D RID: 179757 RVA: 0x00A0DB47 File Offset: 0x00A0BD47
		protected ABP_NA_032_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E6A RID: 93802
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA032/ABP_NA_032.ABP_NA_032_C";

		// Token: 0x04016E6B RID: 93803
		private static IntPtr _ClassPtr;

		// Token: 0x04016E6C RID: 93804
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
