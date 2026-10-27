using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA054
{
	// Token: 0x020041E5 RID: 16869
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA054/ABP_NA054.ABP_NA054_C")]
	[UnrealStructLayout(19248, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 19234)]
	public class ABP_NA054_C : ABP_BaseRunAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD57 RID: 179543 RVA: 0x00A0BE2A File Offset: 0x00A0A02A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA054_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA054/ABP_NA054.ABP_NA054_C");
			}
			return ABP_NA054_C._ClassPtr;
		}

		// Token: 0x0602BD58 RID: 179544 RVA: 0x00A0BE50 File Offset: 0x00A0A050
		public ABP_NA054_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA054_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD59 RID: 179545 RVA: 0x00A0BE78 File Offset: 0x00A0A078
		[NullableContext(1)]
		public ABP_NA054_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA054_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BD5A RID: 179546 RVA: 0x00A0BEAB File Offset: 0x00A0A0AB
		protected ABP_NA054_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016DCC RID: 93644
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA054/ABP_NA054.ABP_NA054_C";

		// Token: 0x04016DCD RID: 93645
		private static IntPtr _ClassPtr;

		// Token: 0x04016DCE RID: 93646
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
