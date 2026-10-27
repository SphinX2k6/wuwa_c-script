using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA070
{
	// Token: 0x020041B0 RID: 16816
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA070/ABP_NA070.ABP_NA070_C")]
	[UnrealStructLayout(19248, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 19234)]
	public class ABP_NA070_C : ABP_BaseRunAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC22 RID: 179234 RVA: 0x00A09A24 File Offset: 0x00A07C24
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA070_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA070/ABP_NA070.ABP_NA070_C");
			}
			return ABP_NA070_C._ClassPtr;
		}

		// Token: 0x0602BC23 RID: 179235 RVA: 0x00A09A48 File Offset: 0x00A07C48
		public ABP_NA070_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA070_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BC24 RID: 179236 RVA: 0x00A09A70 File Offset: 0x00A07C70
		[NullableContext(1)]
		public ABP_NA070_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA070_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BC25 RID: 179237 RVA: 0x00A09AA3 File Offset: 0x00A07CA3
		protected ABP_NA070_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016CFA RID: 93434
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA070/ABP_NA070.ABP_NA070_C";

		// Token: 0x04016CFB RID: 93435
		private static IntPtr _ClassPtr;

		// Token: 0x04016CFC RID: 93436
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
