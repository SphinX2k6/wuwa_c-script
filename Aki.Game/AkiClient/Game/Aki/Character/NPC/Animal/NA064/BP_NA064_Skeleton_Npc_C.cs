using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA064
{
	// Token: 0x020041CB RID: 16843
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA064/BP_NA064_Skeleton_Npc.BP_NA064_Skeleton_Npc_C")]
	[UnrealStructLayout(2336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2330)]
	public class BP_NA064_Skeleton_Npc_C : BP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BCBA RID: 179386 RVA: 0x00A0AC0C File Offset: 0x00A08E0C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA064_Skeleton_Npc_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA064/BP_NA064_Skeleton_Npc.BP_NA064_Skeleton_Npc_C");
			}
			return BP_NA064_Skeleton_Npc_C._ClassPtr;
		}

		// Token: 0x0602BCBB RID: 179387 RVA: 0x00A0AC30 File Offset: 0x00A08E30
		public BP_NA064_Skeleton_Npc_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA064_Skeleton_Npc_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BCBC RID: 179388 RVA: 0x00A0AC58 File Offset: 0x00A08E58
		[NullableContext(1)]
		public BP_NA064_Skeleton_Npc_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA064_Skeleton_Npc_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BCBD RID: 179389 RVA: 0x00A0AC8B File Offset: 0x00A08E8B
		protected BP_NA064_Skeleton_Npc_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D61 RID: 93537
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA064/BP_NA064_Skeleton_Npc.BP_NA064_Skeleton_Npc_C";

		// Token: 0x04016D62 RID: 93538
		private static IntPtr _ClassPtr;

		// Token: 0x04016D63 RID: 93539
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
