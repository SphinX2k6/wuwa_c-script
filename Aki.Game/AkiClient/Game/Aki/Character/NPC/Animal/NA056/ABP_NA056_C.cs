using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA056
{
	// Token: 0x020041E0 RID: 16864
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA056/ABP_NA056.ABP_NA056_C")]
	[UnrealStructLayout(19248, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 19234)]
	public class ABP_NA056_C : ABP_BaseRunAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD3B RID: 179515 RVA: 0x00A0BADC File Offset: 0x00A09CDC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA056_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA056/ABP_NA056.ABP_NA056_C");
			}
			return ABP_NA056_C._ClassPtr;
		}

		// Token: 0x0602BD3C RID: 179516 RVA: 0x00A0BB00 File Offset: 0x00A09D00
		public ABP_NA056_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA056_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD3D RID: 179517 RVA: 0x00A0BB28 File Offset: 0x00A09D28
		[NullableContext(1)]
		public ABP_NA056_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA056_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BD3E RID: 179518 RVA: 0x00A0BB5B File Offset: 0x00A09D5B
		protected ABP_NA056_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016DB9 RID: 93625
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA056/ABP_NA056.ABP_NA056_C";

		// Token: 0x04016DBA RID: 93626
		private static IntPtr _ClassPtr;

		// Token: 0x04016DBB RID: 93627
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
