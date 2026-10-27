using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Common;
using AkiClient.Game.Aki.Render.RuntimeBP.SnowCoverInteraction.BluePrints;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA066
{
	// Token: 0x020041C2 RID: 16834
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA066/BP_NA066_Skeleton_Npc.BP_NA066_Skeleton_Npc_C")]
	[UnrealStructLayout(2352, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2344)]
	public class BP_NA066_Skeleton_Npc_C : BP_BaseNPC_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BC86 RID: 179334 RVA: 0x00A0A5F8 File Offset: 0x00A087F8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NA066_Skeleton_Npc_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA066/BP_NA066_Skeleton_Npc.BP_NA066_Skeleton_Npc_C");
			}
			return BP_NA066_Skeleton_Npc_C._ClassPtr;
		}

		// Token: 0x0602BC87 RID: 179335 RVA: 0x00A0A61C File Offset: 0x00A0881C
		public BP_NA066_Skeleton_Npc_C() : this(BuiltinUtils.AllocNativeUObject(BP_NA066_Skeleton_Npc_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BC88 RID: 179336 RVA: 0x00A0A644 File Offset: 0x00A08844
		[NullableContext(1)]
		public BP_NA066_Skeleton_Npc_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NA066_Skeleton_Npc_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CD6 RID: 27862
		// (get) Token: 0x0602BC89 RID: 179337 RVA: 0x00A0A677 File Offset: 0x00A08877
		// (set) Token: 0x0602BC8A RID: 179338 RVA: 0x00A0A68B File Offset: 0x00A0888B
		[Nullable(2)]
		public unsafe BP_SnowTrailComponent_NPC_C BP_SnowTrailComponent_NPC
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_SnowTrailComponent_NPC_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA066_Skeleton_Npc_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NA066_Skeleton_Npc_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x0602BC8B RID: 179339 RVA: 0x00A0A6A0 File Offset: 0x00A088A0
		protected BP_NA066_Skeleton_Npc_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D3E RID: 93502
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA066/BP_NA066_Skeleton_Npc.BP_NA066_Skeleton_Npc_C";

		// Token: 0x04016D3F RID: 93503
		private static IntPtr _ClassPtr;

		// Token: 0x04016D40 RID: 93504
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016D41 RID: 93505
		internal static int __PropertyOffset_0;
	}
}
