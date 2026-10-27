using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA039
{
	// Token: 0x02004204 RID: 16900
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA039/ABP_na039.ABP_NA039_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA039_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BDE8 RID: 179688 RVA: 0x00A0D288 File Offset: 0x00A0B488
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA039_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA039/ABP_na039.ABP_NA039_C");
			}
			return ABP_NA039_C._ClassPtr;
		}

		// Token: 0x0602BDE9 RID: 179689 RVA: 0x00A0D2AC File Offset: 0x00A0B4AC
		public ABP_NA039_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA039_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BDEA RID: 179690 RVA: 0x00A0D2D4 File Offset: 0x00A0B4D4
		[NullableContext(1)]
		public ABP_NA039_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA039_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BDEB RID: 179691 RVA: 0x00A0D307 File Offset: 0x00A0B507
		protected ABP_NA039_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E3B RID: 93755
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA039/ABP_na039.ABP_NA039_C";

		// Token: 0x04016E3C RID: 93756
		private static IntPtr _ClassPtr;

		// Token: 0x04016E3D RID: 93757
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
