using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonComponentModel;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B21 RID: 19233
	public class TowerDefenseRankTimeModel : RankTimeItemModelBase
	{
		// Token: 0x06031D12 RID: 204050 RVA: 0x00B908EC File Offset: 0x00B8EAEC
		protected override void OnButtonClick()
		{
			TowerDefenseRankViewModelV2 towerDefenseRankViewModelV = new TowerDefenseRankViewModelV2();
			towerDefenseRankViewModelV.InstanceId = this.InstanceId;
			UiManager.Instance.OpenView(EUiViewName.TowerDefenseRankViewV2, towerDefenseRankViewModelV, null);
		}

		// Token: 0x06031D13 RID: 204051 RVA: 0x00B9091C File Offset: 0x00B8EB1C
		[NullableContext(1)]
		protected override TableTextArgNew OnGetContent()
		{
			if (TowerDefenseModel.Instance.PhantomMessageCache.IsPassedInstance(this.InstanceId))
			{
				string bestRecordText = TowerDefenseModel.Instance.RankData.GetBestRecordText(this.InstanceId);
				return new TableTextArgNew("ChallengeOL_Bestrecord", new <>z__ReadOnlySingleElementList<object>(bestRecordText));
			}
			return new TableTextArgNew("ChallengeOL_Norecord", Array.Empty<object>());
		}
	}
}
