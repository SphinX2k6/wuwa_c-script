using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA061
{
	// Token: 0x020041D0 RID: 16848
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA061/ABP_NA06102.ABP_NA06102_C")]
	[UnrealStructLayout(19248, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 19234)]
	public class ABP_NA06102_C : ABP_BaseRunAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BCD4 RID: 179412 RVA: 0x00A0AF31 File Offset: 0x00A09131
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA06102_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA061/ABP_NA06102.ABP_NA06102_C");
			}
			return ABP_NA06102_C._ClassPtr;
		}

		// Token: 0x0602BCD5 RID: 179413 RVA: 0x00A0AF58 File Offset: 0x00A09158
		public ABP_NA06102_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA06102_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BCD6 RID: 179414 RVA: 0x00A0AF80 File Offset: 0x00A09180
		[NullableContext(1)]
		public ABP_NA06102_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA06102_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BCD7 RID: 179415 RVA: 0x00A0AFB3 File Offset: 0x00A091B3
		protected ABP_NA06102_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D73 RID: 93555
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA061/ABP_NA06102.ABP_NA06102_C";

		// Token: 0x04016D74 RID: 93556
		private static IntPtr _ClassPtr;

		// Token: 0x04016D75 RID: 93557
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
