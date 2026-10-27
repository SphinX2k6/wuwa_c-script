using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA042
{
	// Token: 0x020041FC RID: 16892
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA042/ABP_NA042.ABP_NA042_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA042_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BDBB RID: 179643 RVA: 0x00A0CB48 File Offset: 0x00A0AD48
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA042_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA042/ABP_NA042.ABP_NA042_C");
			}
			return ABP_NA042_C._ClassPtr;
		}

		// Token: 0x0602BDBC RID: 179644 RVA: 0x00A0CB6C File Offset: 0x00A0AD6C
		public ABP_NA042_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA042_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BDBD RID: 179645 RVA: 0x00A0CB94 File Offset: 0x00A0AD94
		[NullableContext(1)]
		public ABP_NA042_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA042_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BDBE RID: 179646 RVA: 0x00A0CBC7 File Offset: 0x00A0ADC7
		protected ABP_NA042_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E17 RID: 93719
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA042/ABP_NA042.ABP_NA042_C";

		// Token: 0x04016E18 RID: 93720
		private static IntPtr _ClassPtr;

		// Token: 0x04016E19 RID: 93721
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
