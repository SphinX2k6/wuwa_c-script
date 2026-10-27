using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay.TimeTrackControl;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006BA6 RID: 27558
	public class LevelEventTimeTrackControl : LevelEventBase
	{
		// Token: 0x06044301 RID: 279297 RVA: 0x010CE3F7 File Offset: 0x010CC5F7
		public LevelEventTimeTrackControl(int id) : base(id)
		{
		}

		// Token: 0x06044302 RID: 279298 RVA: 0x010CE400 File Offset: 0x010CC600
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

		// Token: 0x06044303 RID: 279299 RVA: 0x010CE4AD File Offset: 0x010CC6AD
		private void OnResponse(bool isSuccess)
		{
			base.FinishExecute(isSuccess, false, true);
		}
	}
}
