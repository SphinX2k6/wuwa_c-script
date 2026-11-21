using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.RoleUi;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005C7D RID: 23677
	public class LevelEventClientChangeTeamPosition : LevelEventBase
	{
		// Token: 0x0603A1A9 RID: 237993 RVA: 0x01060434 File Offset: 0x0105E634
		public LevelEventClientChangeTeamPosition(int id) : base(id)
		{
		}

		// Token: 0x0603A1AA RID: 237994 RVA: 0x01060440 File Offset: 0x0105E640
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			ClientChangeTeamPosition clientChangeTeamPosition = inParams as ClientChangeTeamPosition;
			int roleId = clientChangeTeamPosition.PositionId;
			if (SceneTeamModel.Instance.IsTeamReady)
			{
				this.ChangeRole(roleId);
				return;
			}
			this.WaitUpdateSceneTeam().ContinueWith(delegate(bool r)
			{
				this.ChangeRole(roleId);
			});
		}

		// Token: 0x0603A1AB RID: 237995 RVA: 0x0106049E File Offset: 0x0105E69E
		private UniTask<bool> WaitUpdateSceneTeam()
		{
			GameModePromise loadTeamPromise = SceneTeamModel.Instance.LoadTeamPromise;
			if (loadTeamPromise == null)
			{
				return UniTask.FromResult<bool>(true);
			}
			return loadTeamPromise.Promise;
		}

		// Token: 0x0603A1AC RID: 237996 RVA: 0x010604BC File Offset: 0x0105E6BC
		private void ChangeRole(int roleId)
		{
			foreach (SceneTeamItem sceneTeamItem in SceneTeamModel.Instance.GetTeamItems(true))
			{
				if (RoleConfig.Instance.GetBaseRoleId(sceneTeamItem.GetConfigId) == roleId)
				{
					SceneTeamController.Instance.RequestChangeRole(sceneTeamItem.GetCreatureDataId(), null);
					break;
				}
			}
			base.FinishExecute(true, false, true);
		}
	}
}
