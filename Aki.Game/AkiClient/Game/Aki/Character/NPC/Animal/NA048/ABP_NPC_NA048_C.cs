using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA048
{
	// Token: 0x020041EE RID: 16878
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA048/ABP_NPC_NA048.ABP_NPC_NA048_C")]
	[UnrealStructLayout(13088, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 13082)]
	public class ABP_NPC_NA048_C : ABP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD7B RID: 179579 RVA: 0x00A0C2F4 File Offset: 0x00A0A4F4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NPC_NA048_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA048/ABP_NPC_NA048.ABP_NPC_NA048_C");
			}
			return ABP_NPC_NA048_C._ClassPtr;
		}

		// Token: 0x0602BD7C RID: 179580 RVA: 0x00A0C318 File Offset: 0x00A0A518
		public ABP_NPC_NA048_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NPC_NA048_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD7D RID: 179581 RVA: 0x00A0C340 File Offset: 0x00A0A540
		[NullableContext(1)]
		public ABP_NPC_NA048_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NPC_NA048_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BD7E RID: 179582 RVA: 0x00A0C373 File Offset: 0x00A0A573
		protected ABP_NPC_NA048_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016DE7 RID: 93671
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA048/ABP_NPC_NA048.ABP_NPC_NA048_C";

		// Token: 0x04016DE8 RID: 93672
		private static IntPtr _ClassPtr;

		// Token: 0x04016DE9 RID: 93673
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
