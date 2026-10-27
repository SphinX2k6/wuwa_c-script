using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02006954 RID: 26964
	public class LevelEventClientUnlockAchievement : LevelEventBase
	{
		// Token: 0x060432EB RID: 275179 RVA: 0x01061B71 File Offset: 0x0105FD71
		public LevelEventClientUnlockAchievement(int id) : base(id)
		{
		}

		// Token: 0x060432EC RID: 275180 RVA: 0x01061B7C File Offset: 0x0105FD7C
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			int? id = PlayerInfoModel.Instance.GetId();
			int worldOwner = CreatureModel.Instance.GetWorldOwner();
			if (!(id.GetValueOrDefault() == worldOwner & id != null))
			{
				global::Log.Instance.Info(ELogModule.LevelEvent, ELogAuthor.CH, "[LevelEventClientUnlockAchievement] 副机不跑", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			ClientUnlockAchievementSystemItem clientUnlockAchievementSystemItem = inParams as ClientUnlockAchievementSystemItem;
			if (clientUnlockAchievementSystemItem == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.CH, "[LevelEventClientUnlockAchievement] 参数不合法", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			AchievementData achievementData = AchievementModel.Instance.GetAchievementData(clientUnlockAchievementSystemItem.Id);
			if (achievementData == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.CH, "[LevelEventClientUnlockAchievement] 成就数据不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (achievementData.GetFinishState() != EAchievementStateEnum.UnFinished)
			{
				global::Log.Instance.Info(ELogModule.LevelEvent, ELogAuthor.CH, "[LevelEventClientUnlockAchievement] 成就已解锁", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			AchievementFinishRequest achievementFinishRequest = AchievementFinishRequest.Create();
			achievementFinishRequest.Id = clientUnlockAchievementSystemItem.Id;
			Net.Instance.Call(ERequestMessageId.AchievementFinishRequest, achievementFinishRequest, null, 0);
		}
	}
}
