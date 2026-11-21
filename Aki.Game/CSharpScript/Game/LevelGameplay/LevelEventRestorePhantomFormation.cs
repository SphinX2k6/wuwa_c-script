using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AB2 RID: 23218
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventRestorePhantomFormation : LevelEventBase
	{
		// Token: 0x06039336 RID: 234294 RVA: 0x01006154 File Offset: 0x01004354
		public LevelEventRestorePhantomFormation(int id) : base(id)
		{
		}

		// Token: 0x06039337 RID: 234295 RVA: 0x0100615D File Offset: 0x0100435D
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x06039338 RID: 234296 RVA: 0x01006168 File Offset: 0x01004368
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			SceneTeamModel instance = SceneTeamModel.Instance;
			if (!instance.IsPhantomTeam && instance.IsTeamReady)
			{
				global::Log.Instance.Info(ELogModule.LevelEvent, ELogAuthor.LYY, "[RestorePhantomFormation] 当前已是角色队伍", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(true, false, true);
				return;
			}
			global::Log.Instance.Info(ELogModule.LevelEvent, ELogAuthor.LYY, "[RestorePhantomFormation] 开始等待队伍更新", default(ReadOnlySpan<ValueTuple<string, object>>));
			EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnUpdateSceneTeam));
		}

		// Token: 0x06039339 RID: 234297 RVA: 0x010061F8 File Offset: 0x010043F8
		private void OnUpdateSceneTeam()
		{
			bool flag = !SceneTeamModel.Instance.IsPhantomTeam;
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LevelEvent;
			ELogAuthor author = ELogAuthor.LYY;
			string message = "[RestorePhantomFormation] 队伍更新完成";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("isRole", flag);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnUpdateSceneTeam));
			base.FinishExecute(flag, false, true);
		}
	}
}
