using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay.TimeTrackControl;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005D1E RID: 23838
	public class LevelEventTimeTrackControl : LevelEventBase
	{
		// Token: 0x0603A457 RID: 238679 RVA: 0x01078283 File Offset: 0x01076483
		public LevelEventTimeTrackControl(int id) : base(id)
		{
		}

		// Token: 0x0603A458 RID: 238680 RVA: 0x0107828C File Offset: 0x0107648C
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			ActionTimeTrackControl actionTimeTrackControl = inParams as ActionTimeTrackControl;
			if (actionTimeTrackControl == null)
			{
				global::Log.Instance.Info(ELogModule.SceneGameplay, ELogAuthor.JYS, "时间控制装置启动请求:LevelEventTimeTrackControl params转换失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(false, false, true);
				return;
			}
			long entityId = actionTimeTrackControl.EntityId;
			EntityHandle entity = CreatureModel.Instance.GetEntity(entityId);
			if (entity == null || !entity.Valid)
			{
				global::Log.Instance.Info(ELogModule.SceneGameplay, ELogAuthor.JYS, "时间控制装置启动请求:LevelEventTimeTrackControl entity不合法", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(false, false, true);
				return;
			}
			TsInteractionUtils.RegisterOpenViewName(EUiViewName.TimeTrackControlView);
			TimeTrackController.Instance.OpenTimeTrackControlView(entityId, actionTimeTrackControl.ConfigIndex, new Action<bool>(this.OnResponse));
		}

		// Token: 0x0603A459 RID: 238681 RVA: 0x01078339 File Offset: 0x01076539
		private void OnResponse(bool isSuccess)
		{
			base.FinishExecute(isSuccess, false, true);
		}
	}
}
