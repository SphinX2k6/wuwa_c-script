using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AAE RID: 23214
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventChangePhantomFormation : LevelEventBase
	{
		// Token: 0x0603931E RID: 234270 RVA: 0x01005CC4 File Offset: 0x01003EC4
		public LevelEventChangePhantomFormation(int id) : base(id)
		{
		}

		// Token: 0x0603931F RID: 234271 RVA: 0x01005CCD File Offset: 0x01003ECD
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x06039320 RID: 234272 RVA: 0x01005CD8 File Offset: 0x01003ED8
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

		// Token: 0x06039321 RID: 234273 RVA: 0x01005D68 File Offset: 0x01003F68
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
