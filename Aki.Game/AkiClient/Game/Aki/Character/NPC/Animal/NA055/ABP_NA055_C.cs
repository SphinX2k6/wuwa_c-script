using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA055
{
	// Token: 0x020041E2 RID: 16866
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA055/ABP_NA055.ABP_NA055_C")]
	[UnrealStructLayout(19248, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 19234)]
	public class ABP_NA055_C : ABP_BaseRunAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD43 RID: 179523 RVA: 0x00A0BBEC File Offset: 0x00A09DEC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA055_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA055/ABP_NA055.ABP_NA055_C");
			}
			return ABP_NA055_C._ClassPtr;
		}

		// Token: 0x0602BD44 RID: 179524 RVA: 0x00A0BC10 File Offset: 0x00A09E10
		public ABP_NA055_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA055_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD45 RID: 179525 RVA: 0x00A0BC38 File Offset: 0x00A09E38
		[NullableContext(1)]
		public ABP_NA055_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA055_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BD46 RID: 179526 RVA: 0x00A0BC6B File Offset: 0x00A09E6B
		protected ABP_NA055_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016DBF RID: 93631
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA055/ABP_NA055.ABP_NA055_C";

		// Token: 0x04016DC0 RID: 93632
		private static IntPtr _ClassPtr;

		// Token: 0x04016DC1 RID: 93633
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
