using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA044
{
	// Token: 0x020041F7 RID: 16887
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA044/ABP_NA044.ABP_NA044_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA044_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD9F RID: 179615 RVA: 0x00A0C7BC File Offset: 0x00A0A9BC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA044_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA044/ABP_NA044.ABP_NA044_C");
			}
			return ABP_NA044_C._ClassPtr;
		}

		// Token: 0x0602BDA0 RID: 179616 RVA: 0x00A0C7E0 File Offset: 0x00A0A9E0
		public ABP_NA044_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA044_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BDA1 RID: 179617 RVA: 0x00A0C808 File Offset: 0x00A0AA08
		[NullableContext(1)]
		public ABP_NA044_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA044_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BDA2 RID: 179618 RVA: 0x00A0C83B File Offset: 0x00A0AA3B
		protected ABP_NA044_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E02 RID: 93698
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA044/ABP_NA044.ABP_NA044_C";

		// Token: 0x04016E03 RID: 93699
		private static IntPtr _ClassPtr;

		// Token: 0x04016E04 RID: 93700
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
