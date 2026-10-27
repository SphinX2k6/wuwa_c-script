using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.RollBlock
{
	// Token: 0x02006AA7 RID: 27303
	[NullableContext(1)]
	[Nullable(0)]
	public class RollBlockDefind
	{
		// Token: 0x06043D5B RID: 277851 RVA: 0x0109E819 File Offset: 0x0109CA19
		public static bool isRbBlockIdleState([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<RbBlockIdlePbState, RbJumpMovement, RbRollMovement> state)
		{
			return state.IsT1;
		}

		// Token: 0x06043D5C RID: 277852 RVA: 0x0109E822 File Offset: 0x0109CA22
		public static bool isRbBlockRollState([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<RbBlockIdlePbState, RbJumpMovement, RbRollMovement> state)
		{
			if (!state.IsT3)
			{
				return false;
			}
			RbRollMovement asT = state.AsT3;
			if (asT == null)
			{
				return false;
			}
			RbGridDirection direction = asT.Direction;
			return true;
		}

		// Token: 0x06043D5D RID: 277853 RVA: 0x0109E843 File Offset: 0x0109CA43
		public static bool isRbBlockJumpState([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<RbBlockIdlePbState, RbJumpMovement, RbRollMovement> state)
		{
			if (!state.IsT2)
			{
				return false;
			}
			RbJumpMovement asT = state.AsT2;
			if (asT == null)
			{
				return false;
			}
			RbGridDirection direction = asT.Direction;
			return true;
		}

		// Token: 0x06043D5E RID: 277854 RVA: 0x0109E864 File Offset: 0x0109CA64
		public static bool isRbBreakableObstacleInfo([Nullable(new byte[]
		{
			0,
			1,
			1
		})] OneOf<RbBreakableObstaclePbType, RbLaserEmitterPbType> info)
		{
			if (info.IsT1)
			{
				RbBreakableObstaclePbType asT = info.AsT1;
				return ((asT != null) ? asT.LinkPoints : null) != null;
			}
			return false;
		}

		// Token: 0x04023724 RID: 145188
		public const int RB_HALF_HEIGHT = 50;

		// Token: 0x04023725 RID: 145189
		public static readonly FName RB_SEQ_BINDING_TAG = new FName("Cube");

		// Token: 0x04023726 RID: 145190
		public const string RB_JUMP_SEQ_PATH = "/Game/Aki/Data/Gameplay/RollBlock/Sequence/RollBlockJump.RollBlockJump";

		// Token: 0x04023727 RID: 145191
		public const string RB_CONFIG_DA_PATH = "/Game/Aki/Data/Gameplay/RollBlock/DA_RollBlockSetting.DA_RollBlockSetting";

		// Token: 0x04023728 RID: 145192
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<string, RbGridDirection> Input2RbGridDirection = new Dictionary<string, RbGridDirection>
		{
			{
				"向前移动",
				RbGridDirection.RbForward
			},
			{
				"向后移动",
				RbGridDirection.RbBackward
			},
			{
				"向左移动",
				RbGridDirection.RbLeft
			},
			{
				"向右移动",
				RbGridDirection.RbRight
			}
		};

		// Token: 0x04023729 RID: 145193
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<RbGridDirection, string> RbGridDirection2Input = new Dictionary<RbGridDirection, string>
		{
			{
				RbGridDirection.RbForward,
				"向前移动"
			},
			{
				RbGridDirection.RbBackward,
				"向后移动"
			},
			{
				RbGridDirection.RbLeft,
				"向左移动"
			},
			{
				RbGridDirection.RbRight,
				"向右移动"
			}
		};
	}
}
