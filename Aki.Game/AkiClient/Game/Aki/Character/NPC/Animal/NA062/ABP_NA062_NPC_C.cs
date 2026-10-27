using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA062
{
	// Token: 0x020041CD RID: 16845
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA062/ABP_NA062_NPC.ABP_NA062_NPC_C")]
	[UnrealStructLayout(13088, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 13082)]
	public class ABP_NA062_NPC_C : ABP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BCC2 RID: 179394 RVA: 0x00A0AD1C File Offset: 0x00A08F1C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA062_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA062/ABP_NA062_NPC.ABP_NA062_NPC_C");
			}
			return ABP_NA062_NPC_C._ClassPtr;
		}

		// Token: 0x0602BCC3 RID: 179395 RVA: 0x00A0AD40 File Offset: 0x00A08F40
		public ABP_NA062_NPC_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA062_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BCC4 RID: 179396 RVA: 0x00A0AD68 File Offset: 0x00A08F68
		[NullableContext(1)]
		public ABP_NA062_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA062_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BCC5 RID: 179397 RVA: 0x00A0AD9B File Offset: 0x00A08F9B
		protected ABP_NA062_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D67 RID: 93543
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA062/ABP_NA062_NPC.ABP_NA062_NPC_C";

		// Token: 0x04016D68 RID: 93544
		private static IntPtr _ClassPtr;

		// Token: 0x04016D69 RID: 93545
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
