using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA017
{
	// Token: 0x02004221 RID: 16929
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA017/ABP_NA017.ABP_NA017_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA017_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE72 RID: 179826 RVA: 0x00A0E3FC File Offset: 0x00A0C5FC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA017_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA017/ABP_NA017.ABP_NA017_C");
			}
			return ABP_NA017_C._ClassPtr;
		}

		// Token: 0x0602BE73 RID: 179827 RVA: 0x00A0E420 File Offset: 0x00A0C620
		public ABP_NA017_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA017_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE74 RID: 179828 RVA: 0x00A0E448 File Offset: 0x00A0C648
		[NullableContext(1)]
		public ABP_NA017_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA017_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BE75 RID: 179829 RVA: 0x00A0E47B File Offset: 0x00A0C67B
		protected ABP_NA017_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E9F RID: 93855
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA017/ABP_NA017.ABP_NA017_C";

		// Token: 0x04016EA0 RID: 93856
		private static IntPtr _ClassPtr;

		// Token: 0x04016EA1 RID: 93857
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
