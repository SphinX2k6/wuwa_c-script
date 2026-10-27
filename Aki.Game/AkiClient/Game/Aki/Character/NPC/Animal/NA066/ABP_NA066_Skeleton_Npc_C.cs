using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA066
{
	// Token: 0x020041C0 RID: 16832
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA066/ABP_NA066_Skeleton_Npc.ABP_NA066_Skeleton_Npc_C")]
	[UnrealStructLayout(13088, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 13082)]
	public class ABP_NA066_Skeleton_Npc_C : ABP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC76 RID: 179318 RVA: 0x00A0A444 File Offset: 0x00A08644
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA066_Skeleton_Npc_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA066/ABP_NA066_Skeleton_Npc.ABP_NA066_Skeleton_Npc_C");
			}
			return ABP_NA066_Skeleton_Npc_C._ClassPtr;
		}

		// Token: 0x0602BC77 RID: 179319 RVA: 0x00A0A468 File Offset: 0x00A08668
		public ABP_NA066_Skeleton_Npc_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA066_Skeleton_Npc_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BC78 RID: 179320 RVA: 0x00A0A490 File Offset: 0x00A08690
		[NullableContext(1)]
		public ABP_NA066_Skeleton_Npc_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA066_Skeleton_Npc_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BC79 RID: 179321 RVA: 0x00A0A4C3 File Offset: 0x00A086C3
		protected ABP_NA066_Skeleton_Npc_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D34 RID: 93492
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA066/ABP_NA066_Skeleton_Npc.ABP_NA066_Skeleton_Npc_C";

		// Token: 0x04016D35 RID: 93493
		private static IntPtr _ClassPtr;

		// Token: 0x04016D36 RID: 93494
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
