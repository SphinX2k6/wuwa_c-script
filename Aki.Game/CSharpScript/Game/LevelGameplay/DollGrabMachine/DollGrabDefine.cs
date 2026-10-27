using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006EB4 RID: 28340
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabDefine
	{
		// Token: 0x04023EFD RID: 147197
		public const string DG_CONFIG_DA_PATH = "/Game/Aki/GamePlay/DollGrab/DA_DollGrabMachineGlobalConfig.DA_DollGrabMachineGlobalConfig";

		// Token: 0x04023EFE RID: 147198
		public const string CLAW_REF_KEY = "Claw";

		// Token: 0x04023EFF RID: 147199
		public const string CLAW_ROOT_CTRL_KEY = "ClawCtrl";

		// Token: 0x04023F00 RID: 147200
		public const string CLAW_CHAIN_REF_KEY = "Chain";

		// Token: 0x04023F01 RID: 147201
		public const string CLAW_ANIM_SEQ_REF_KEY = "ClawAnimSeq";

		// Token: 0x04023F02 RID: 147202
		public const string DROP_TRIGGER_REF_KEY = "DropTriggerBox";

		// Token: 0x04023F03 RID: 147203
		public const string DOLL_ITEM_POOL_REF_KEY = "ItemsPool";

		// Token: 0x04023F04 RID: 147204
		public const string TELEPORT_TRIGGER_REF_KEY = "RecycleGroup";

		// Token: 0x04023F05 RID: 147205
		public const string CONVEYOR_BELT_REF_KEY = "ConveyBelt";

		// Token: 0x04023F06 RID: 147206
		public const string ELEMENT_CONTAINER_REF_KEY = "ElementContainer";

		// Token: 0x04023F07 RID: 147207
		public const string ENDLESS_SPAWN_POINT_REF_KEY = "EndlessSpawnPoints";

		// Token: 0x04023F08 RID: 147208
		public const string DISSOLVE_ACTOR_REF_KEY = "CenterDissolve";

		// Token: 0x04023F09 RID: 147209
		public const string CONVEYOR_BELT_MESH_BP_REF_KEY = "ConveyBeltCtrl";

		// Token: 0x04023F0A RID: 147210
		public const string BOUNDARY_TRIGGER_GROUP_REF_KEY = "BoundaryTriggerGroup";

		// Token: 0x04023F0B RID: 147211
		public const string ROOF_ACTOR_REF_KEY = "Roof";

		// Token: 0x04023F0C RID: 147212
		public const string LIGHT_GROUP_ACTOR_REF_KEY = "Lights";

		// Token: 0x04023F0D RID: 147213
		public const string SHOWCASE_CAMERA_REASON = "ShowcaseFixCamera";

		// Token: 0x04023F0E RID: 147214
		public const string DOLL_GRAB_MACHINE_CAMERA_REASON = "DollGrabMachineFixCamera";
	}
}
