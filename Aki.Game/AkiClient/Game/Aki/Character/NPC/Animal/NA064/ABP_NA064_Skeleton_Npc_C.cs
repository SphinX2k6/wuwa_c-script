using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA064
{
	// Token: 0x020041C7 RID: 16839
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA064/ABP_NA064_Skeleton_Npc.ABP_NA064_Skeleton_Npc_C")]
	[UnrealStructLayout(13088, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 13082)]
	public class ABP_NA064_Skeleton_Npc_C : ABP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BCA2 RID: 179362 RVA: 0x00A0A948 File Offset: 0x00A08B48
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA064_Skeleton_Npc_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA064/ABP_NA064_Skeleton_Npc.ABP_NA064_Skeleton_Npc_C");
			}
			return ABP_NA064_Skeleton_Npc_C._ClassPtr;
		}

		// Token: 0x0602BCA3 RID: 179363 RVA: 0x00A0A96C File Offset: 0x00A08B6C
		public ABP_NA064_Skeleton_Npc_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA064_Skeleton_Npc_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BCA4 RID: 179364 RVA: 0x00A0A994 File Offset: 0x00A08B94
		[NullableContext(1)]
		public ABP_NA064_Skeleton_Npc_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA064_Skeleton_Npc_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BCA5 RID: 179365 RVA: 0x00A0A9C7 File Offset: 0x00A08BC7
		protected ABP_NA064_Skeleton_Npc_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D51 RID: 93521
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA064/ABP_NA064_Skeleton_Npc.ABP_NA064_Skeleton_Npc_C";

		// Token: 0x04016D52 RID: 93522
		private static IntPtr _ClassPtr;

		// Token: 0x04016D53 RID: 93523
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
