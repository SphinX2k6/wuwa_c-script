using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006AEE RID: 27374
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventAddBuffToPlayer : LevelEventAddBuffClientPrePerformance
	{
		// Token: 0x06043FD4 RID: 278484 RVA: 0x010AE159 File Offset: 0x010AC359
		public LevelEventAddBuffToPlayer(int id) : base(id)
		{
		}

		// Token: 0x06043FD5 RID: 278485 RVA: 0x010AE164 File Offset: 0x010AC364
		[return: Nullable(2)]
		protected override EntityHandle GetTargetEntity(TriggerContext context)
		{
			if (GameModeModel.Instance.IsMulti && !CreatureModel.Instance.IsMyWorld())
			{
				return null;
			}
			ETeamGroupType? currentGroupType = SceneTeamModel.Instance.CurrentGroupType;
			if (currentGroupType != null)
			{
				switch (currentGroupType.GetValueOrDefault())
				{
				case ETeamGroupType.Battle:
					return SceneTeamModel.Instance.GetCurrentEntity;
				case ETeamGroupType.Phantom:
					return SceneTeamModel.Instance.GetCurrentEntity;
				case ETeamGroupType.Plot:
				case ETeamGroupType.Performance:
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.LevelEvent;
					ELogAuthor author = ELogAuthor.XDW;
					string message = "[" + base.GetDebugName() + "] 剧情、玩法演出编队类型角色触发了实体的TriggerComponent，不合理";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("context", context);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					break;
				}
				}
			}
			return null;
		}

		// Token: 0x06043FD6 RID: 278486 RVA: 0x010AE20F File Offset: 0x010AC40F
		protected override List<long> GetBuffIds(ActionParams inParams)
		{
			return (inParams as AddBuffToPlayer).BuffIds;
		}
	}
}
