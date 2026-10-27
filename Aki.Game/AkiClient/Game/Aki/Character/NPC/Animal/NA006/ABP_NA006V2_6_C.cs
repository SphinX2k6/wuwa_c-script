using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA006
{
	// Token: 0x0200423A RID: 16954
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA006/ABP_NA006V2_6.ABP_NA006V2_6_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA006V2_6_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BEE0 RID: 179936 RVA: 0x00A0F2E0 File Offset: 0x00A0D4E0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA006V2_6_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA006/ABP_NA006V2_6.ABP_NA006V2_6_C");
			}
			return ABP_NA006V2_6_C._ClassPtr;
		}

		// Token: 0x0602BEE1 RID: 179937 RVA: 0x00A0F304 File Offset: 0x00A0D504
		public ABP_NA006V2_6_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA006V2_6_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BEE2 RID: 179938 RVA: 0x00A0F32C File Offset: 0x00A0D52C
		[NullableContext(1)]
		public ABP_NA006V2_6_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA006V2_6_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BEE3 RID: 179939 RVA: 0x00A0F35F File Offset: 0x00A0D55F
		protected ABP_NA006V2_6_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016EEF RID: 93935
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA006/ABP_NA006V2_6.ABP_NA006V2_6_C";

		// Token: 0x04016EF0 RID: 93936
		private static IntPtr _ClassPtr;

		// Token: 0x04016EF1 RID: 93937
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
