using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA012
{
	// Token: 0x0200422B RID: 16939
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA012/ABP_NA012_1.ABP_NA012_1_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA012_1_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE9E RID: 179870 RVA: 0x00A0EA04 File Offset: 0x00A0CC04
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA012_1_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA012/ABP_NA012_1.ABP_NA012_1_C");
			}
			return ABP_NA012_1_C._ClassPtr;
		}

		// Token: 0x0602BE9F RID: 179871 RVA: 0x00A0EA28 File Offset: 0x00A0CC28
		public ABP_NA012_1_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA012_1_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BEA0 RID: 179872 RVA: 0x00A0EA50 File Offset: 0x00A0CC50
		[NullableContext(1)]
		public ABP_NA012_1_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA012_1_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BEA1 RID: 179873 RVA: 0x00A0EA83 File Offset: 0x00A0CC83
		protected ABP_NA012_1_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016EBF RID: 93887
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA012/ABP_NA012_1.ABP_NA012_1_C";

		// Token: 0x04016EC0 RID: 93888
		private static IntPtr _ClassPtr;

		// Token: 0x04016EC1 RID: 93889
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
