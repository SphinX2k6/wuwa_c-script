using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020048AC RID: 18604
	public class InstanceDungeonEntranceFlowAbyss : InstanceDungeonEntranceFlowBase
	{
		// Token: 0x0602EBBA RID: 191418 RVA: 0x00D092AE File Offset: 0x00D074AE
		protected override void OnCreate()
		{
			base.AddStep(delegate
			{
				DangoAbyssModel.Instance.InitCacheDangoOwnerMap();
				DangoAbyssModel.Instance.SetInAbyssFlow(true);
				FormationController.Instance.OpenBattleTeamView(InstanceDungeonEntranceModel.Instance.InstanceId, false, true, false, null);
			});
			base.AddStep(delegate
			{
				DangoAbyssModel.Instance.SetInAbyssFlow(false);
				List<int> item = BattleTeamModel.Instance.OwnRoleConfigIdList.Item1;
				int value = PlayerInfoModel.Instance.GetId().Value;
				MapField<int, int> mapField = new MapField<int, int>();
				foreach (int num in item)
				{
					AbyssDangoOwnerData playerRoleCfgOwnerData = DangoAbyssModel.Instance.GetPlayerRoleCfgOwnerData(value, num);
					mapField[num] = ((playerRoleCfgOwnerData != null) ? playerRoleCfgOwnerData.DangoId : 0);
				}
				AbyssInstCtx abyssInstCtx = new AbyssInstCtx();
				abyssInstCtx.LittleRoleMap.MergeFrom(mapField);
				DangoAbyssModel.Instance.SaveCacheDangoOwnerMap();
				InstanceDungeonModel.Instance.InstanceEnterContentText.AbyssInstCtx = abyssInstCtx;
				int currentSelectEntranceId = DangoAbyssModel.Instance.CurrentSelectEntranceId;
				int instanceId = InstanceDungeonEntranceModel.Instance.InstanceId;
				this.TryEnterAbyss(instanceId, item, currentSelectEntranceId);
			});
		}

		// Token: 0x0602EBBB RID: 191419 RVA: 0x00D092E8 File Offset: 0x00D074E8
		[NullableContext(1)]
		private UniTask TryEnterAbyss(int insId, List<int> roleIds, int entranceId)
		{
			InstanceDungeonEntranceFlowAbyss.<TryEnterAbyss>d__1 <TryEnterAbyss>d__;
			<TryEnterAbyss>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TryEnterAbyss>d__.<>4__this = this;
			<TryEnterAbyss>d__.insId = insId;
			<TryEnterAbyss>d__.roleIds = roleIds;
			<TryEnterAbyss>d__.entranceId = entranceId;
			<TryEnterAbyss>d__.<>1__state = -1;
			<TryEnterAbyss>d__.<>t__builder.Start<InstanceDungeonEntranceFlowAbyss.<TryEnterAbyss>d__1>(ref <TryEnterAbyss>d__);
			return <TryEnterAbyss>d__.<>t__builder.Task;
		}

		// Token: 0x0602EBBC RID: 191420 RVA: 0x00D09343 File Offset: 0x00D07543
		protected override void OnEditBattleViewCloseCall()
		{
			DangoAbyssModel.Instance.SetInAbyssFlow(false);
		}
	}
}
