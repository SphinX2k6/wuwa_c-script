using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA045
{
	// Token: 0x020041F5 RID: 16885
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA045/ABP_NA045.ABP_NA045_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA045_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD97 RID: 179607 RVA: 0x00A0C6AC File Offset: 0x00A0A8AC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA045_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA045/ABP_NA045.ABP_NA045_C");
			}
			return ABP_NA045_C._ClassPtr;
		}

		// Token: 0x0602BD98 RID: 179608 RVA: 0x00A0C6D0 File Offset: 0x00A0A8D0
		public ABP_NA045_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA045_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD99 RID: 179609 RVA: 0x00A0C6F8 File Offset: 0x00A0A8F8
		[NullableContext(1)]
		public ABP_NA045_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA045_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BD9A RID: 179610 RVA: 0x00A0C72B File Offset: 0x00A0A92B
		protected ABP_NA045_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016DFC RID: 93692
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA045/ABP_NA045.ABP_NA045_C";

		// Token: 0x04016DFD RID: 93693
		private static IntPtr _ClassPtr;

		// Token: 0x04016DFE RID: 93694
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
