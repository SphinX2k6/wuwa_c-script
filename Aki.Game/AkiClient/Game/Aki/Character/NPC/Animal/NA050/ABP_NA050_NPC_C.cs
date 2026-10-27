using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA050
{
	// Token: 0x020041EB RID: 16875
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA050/ABP_NA050_NPC.ABP_NA050_NPC_C")]
	[UnrealStructLayout(13088, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 13082)]
	public class ABP_NA050_NPC_C : ABP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BD6F RID: 179567 RVA: 0x00A0C15C File Offset: 0x00A0A35C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA050_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA050/ABP_NA050_NPC.ABP_NA050_NPC_C");
			}
			return ABP_NA050_NPC_C._ClassPtr;
		}

		// Token: 0x0602BD70 RID: 179568 RVA: 0x00A0C180 File Offset: 0x00A0A380
		public ABP_NA050_NPC_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA050_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BD71 RID: 179569 RVA: 0x00A0C1A8 File Offset: 0x00A0A3A8
		[NullableContext(1)]
		public ABP_NA050_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA050_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BD72 RID: 179570 RVA: 0x00A0C1DB File Offset: 0x00A0A3DB
		protected ABP_NA050_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016DDE RID: 93662
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA050/ABP_NA050_NPC.ABP_NA050_NPC_C";

		// Token: 0x04016DDF RID: 93663
		private static IntPtr _ClassPtr;

		// Token: 0x04016DE0 RID: 93664
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
