using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA065
{
	// Token: 0x020041C3 RID: 16835
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA065/ABP_NA065.ABP_NA065_C")]
	[UnrealStructLayout(19248, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 19234)]
	public class ABP_NA065_C : ABP_BaseRunAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC8C RID: 179340 RVA: 0x00A0A6A9 File Offset: 0x00A088A9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA065_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA065/ABP_NA065.ABP_NA065_C");
			}
			return ABP_NA065_C._ClassPtr;
		}

		// Token: 0x0602BC8D RID: 179341 RVA: 0x00A0A6D0 File Offset: 0x00A088D0
		public ABP_NA065_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA065_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BC8E RID: 179342 RVA: 0x00A0A6F8 File Offset: 0x00A088F8
		[NullableContext(1)]
		public ABP_NA065_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA065_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BC8F RID: 179343 RVA: 0x00A0A72B File Offset: 0x00A0892B
		protected ABP_NA065_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D42 RID: 93506
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA065/ABP_NA065.ABP_NA065_C";

		// Token: 0x04016D43 RID: 93507
		private static IntPtr _ClassPtr;

		// Token: 0x04016D44 RID: 93508
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
