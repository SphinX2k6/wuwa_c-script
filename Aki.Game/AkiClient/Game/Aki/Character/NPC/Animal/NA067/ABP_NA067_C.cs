using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA067
{
	// Token: 0x020041BB RID: 16827
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA067/ABP_NA067.ABP_NA067_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA067_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC62 RID: 179298 RVA: 0x00A0A19A File Offset: 0x00A0839A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA067_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA067/ABP_NA067.ABP_NA067_C");
			}
			return ABP_NA067_C._ClassPtr;
		}

		// Token: 0x0602BC63 RID: 179299 RVA: 0x00A0A1C0 File Offset: 0x00A083C0
		public ABP_NA067_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA067_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BC64 RID: 179300 RVA: 0x00A0A1E8 File Offset: 0x00A083E8
		[NullableContext(1)]
		public ABP_NA067_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA067_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BC65 RID: 179301 RVA: 0x00A0A21B File Offset: 0x00A0841B
		protected ABP_NA067_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D25 RID: 93477
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA067/ABP_NA067.ABP_NA067_C";

		// Token: 0x04016D26 RID: 93478
		private static IntPtr _ClassPtr;

		// Token: 0x04016D27 RID: 93479
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
