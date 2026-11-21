using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.RollBlock
{
	// Token: 0x02005C04 RID: 23556
	[NullableContext(1)]
	[Nullable(0)]
	public class RollBlockDefind
	{
		// Token: 0x06039DB0 RID: 236976 RVA: 0x01042F69 File Offset: 0x01041169
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

		// Token: 0x06039DB1 RID: 236977 RVA: 0x01042F72 File Offset: 0x01041172
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

		// Token: 0x06039DB2 RID: 236978 RVA: 0x01042F93 File Offset: 0x01041193
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

		// Token: 0x06039DB3 RID: 236979 RVA: 0x01042FB4 File Offset: 0x010411B4
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

		// Token: 0x0401E916 RID: 125206
		public const int RB_HALF_HEIGHT = 50;

		// Token: 0x0401E917 RID: 125207
		public static readonly FName RB_SEQ_BINDING_TAG = new FName("Cube");

		// Token: 0x0401E918 RID: 125208
		public const string RB_JUMP_SEQ_PATH = "/Game/Aki/Data/Gameplay/RollBlock/Sequence/RollBlockJump.RollBlockJump";

		// Token: 0x0401E919 RID: 125209
		public const string RB_CONFIG_DA_PATH = "/Game/Aki/Data/Gameplay/RollBlock/DA_RollBlockSetting.DA_RollBlockSetting";

		// Token: 0x0401E91A RID: 125210
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

		// Token: 0x0401E91B RID: 125211
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
