using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.RoleUi;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B05 RID: 27397
	public class LevelEventClientChangeTeamPosition : LevelEventBase
	{
		// Token: 0x06044057 RID: 278615 RVA: 0x010B6BA9 File Offset: 0x010B4DA9
		public LevelEventClientChangeTeamPosition(int id) : base(id)
		{
		}

		// Token: 0x06044058 RID: 278616 RVA: 0x010B6BB4 File Offset: 0x010B4DB4
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

		// Token: 0x06044059 RID: 278617 RVA: 0x010B6C12 File Offset: 0x010B4E12
		private UniTask<bool> WaitUpdateSceneTeam()
		{
			GameModePromise loadTeamPromise = SceneTeamModel.Instance.LoadTeamPromise;
			if (loadTeamPromise == null)
			{
				return UniTask.FromResult<bool>(true);
			}
			return loadTeamPromise.Promise;
		}

		// Token: 0x0604405A RID: 278618 RVA: 0x010B6C30 File Offset: 0x010B4E30
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
