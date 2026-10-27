using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02006953 RID: 26963
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventChangePhantomFormation : LevelEventBase
	{
		// Token: 0x060432E7 RID: 275175 RVA: 0x01061A64 File Offset: 0x0105FC64
		public LevelEventChangePhantomFormation(int id) : base(id)
		{
		}

		// Token: 0x060432E8 RID: 275176 RVA: 0x01061A6D File Offset: 0x0105FC6D
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x060432E9 RID: 275177 RVA: 0x01061A78 File Offset: 0x0105FC78
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			SceneTeamModel instance = SceneTeamModel.Instance;
			if (instance.IsPhantomTeam && instance.IsTeamReady)
			{
				global::Log.Instance.Info(ELogModule.LevelEvent, ELogAuthor.LYY, "[ChangePhantomFormation] 当前已是声骸队伍", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(true, false, true);
				return;
			}
			global::Log.Instance.Info(ELogModule.LevelEvent, ELogAuthor.LYY, "[ChangePhantomFormation] 开始等待队伍更新", default(ReadOnlySpan<ValueTuple<string, object>>));
			EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnUpdateSceneTeam));
		}

		// Token: 0x060432EA RID: 275178 RVA: 0x01061B08 File Offset: 0x0105FD08
		private void OnUpdateSceneTeam()
		{
			bool isPhantomTeam = SceneTeamModel.Instance.IsPhantomTeam;
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LevelEvent;
			ELogAuthor author = ELogAuthor.LYY;
			string message = "[ChangePhantomFormation] 队伍更新完成";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("isPhantom", isPhantomTeam);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnUpdateSceneTeam));
			base.FinishExecute(isPhantomTeam, false, true);
		}
	}
}
