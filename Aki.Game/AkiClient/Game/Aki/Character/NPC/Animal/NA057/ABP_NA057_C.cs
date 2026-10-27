using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA057
{
	// Token: 0x020041DE RID: 16862
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA057/ABP_NA057.ABP_NA057_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA057_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD33 RID: 179507 RVA: 0x00A0B9C9 File Offset: 0x00A09BC9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA057_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA057/ABP_NA057.ABP_NA057_C");
			}
			return ABP_NA057_C._ClassPtr;
		}

		// Token: 0x0602BD34 RID: 179508 RVA: 0x00A0B9F0 File Offset: 0x00A09BF0
		public ABP_NA057_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA057_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD35 RID: 179509 RVA: 0x00A0BA18 File Offset: 0x00A09C18
		[NullableContext(1)]
		public ABP_NA057_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA057_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BD36 RID: 179510 RVA: 0x00A0BA4B File Offset: 0x00A09C4B
		protected ABP_NA057_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016DB3 RID: 93619
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA057/ABP_NA057.ABP_NA057_C";

		// Token: 0x04016DB4 RID: 93620
		private static IntPtr _ClassPtr;

		// Token: 0x04016DB5 RID: 93621
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
