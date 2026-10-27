using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B95 RID: 27541
	public class LevelEventSpawnTraceEffect : LevelEventBase
	{
		// Token: 0x060442C8 RID: 279240 RVA: 0x010CC81D File Offset: 0x010CAA1D
		public LevelEventSpawnTraceEffect(int id) : base(id)
		{
		}

		// Token: 0x060442C9 RID: 279241 RVA: 0x010CC828 File Offset: 0x010CAA28
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

		// Token: 0x060442CA RID: 279242 RVA: 0x010CC89F File Offset: 0x010CAA9F
		protected override void OnReset()
		{
			QuestNewController.Instance.ClearQuestTraceEffect(this.QuestId);
		}

		// Token: 0x0402396F RID: 145775
		private int QuestId;
	}
}
