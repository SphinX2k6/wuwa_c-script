using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02006957 RID: 26967
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventRestorePhantomFormation : LevelEventBase
	{
		// Token: 0x060432FF RID: 275199 RVA: 0x01061EF4 File Offset: 0x010600F4
		public LevelEventRestorePhantomFormation(int id) : base(id)
		{
		}

		// Token: 0x06043300 RID: 275200 RVA: 0x01061EFD File Offset: 0x010600FD
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x06043301 RID: 275201 RVA: 0x01061F08 File Offset: 0x01060108
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

		// Token: 0x06043302 RID: 275202 RVA: 0x01061F98 File Offset: 0x01060198
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
