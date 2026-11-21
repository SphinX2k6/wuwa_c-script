using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005D0D RID: 23821
	public class LevelEventSpawnTraceEffect : LevelEventBase
	{
		// Token: 0x0603A41B RID: 238619 RVA: 0x010765A5 File Offset: 0x010747A5
		public LevelEventSpawnTraceEffect(int id) : base(id)
		{
		}

		// Token: 0x0603A41C RID: 238620 RVA: 0x010765B0 File Offset: 0x010747B0
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				global::Log.Instance.Error(ELogModule.Event, ELogAuthor.ZS, "参数配置错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (context.Type.GetValueOrDefault() == EGeneralContextType.GeneralLogicTree)
			{
				GeneralLogicTreeContext generalLogicTreeContext = context as GeneralLogicTreeContext;
				if (generalLogicTreeContext != null && generalLogicTreeContext.BtType == BtType.Quest)
				{
					this.QuestId = generalLogicTreeContext.TreeConfigId;
					return;
				}
			}
			global::Log.Instance.Error(ELogModule.Event, ELogAuthor.YSQ, "该事件仅用于任务行为树内配置", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0603A41D RID: 238621 RVA: 0x01076627 File Offset: 0x01074827
		protected override void OnReset()
		{
			QuestNewController.Instance.ClearQuestTraceEffect(this.QuestId);
		}

		// Token: 0x0401EC11 RID: 125969
		private int QuestId;
	}
}
