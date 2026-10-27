using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA004
{
	// Token: 0x0200423F RID: 16959
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA004/ABP_NA004.ABP_NA004_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA004_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BEFA RID: 179962 RVA: 0x00A0F609 File Offset: 0x00A0D809
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA004_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA004/ABP_NA004.ABP_NA004_C");
			}
			return ABP_NA004_C._ClassPtr;
		}

		// Token: 0x0602BEFB RID: 179963 RVA: 0x00A0F630 File Offset: 0x00A0D830
		public ABP_NA004_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA004_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BEFC RID: 179964 RVA: 0x00A0F658 File Offset: 0x00A0D858
		[NullableContext(1)]
		public ABP_NA004_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA004_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BEFD RID: 179965 RVA: 0x00A0F68B File Offset: 0x00A0D88B
		protected ABP_NA004_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016F01 RID: 93953
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA004/ABP_NA004.ABP_NA004_C";

		// Token: 0x04016F02 RID: 93954
		private static IntPtr _ClassPtr;

		// Token: 0x04016F03 RID: 93955
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
