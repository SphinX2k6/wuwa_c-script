using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonComponentModel;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AC9 RID: 15049
	public class TowerDefenseRankTimeModel : RankTimeItemModelBase
	{
		// Token: 0x06026AA2 RID: 158370 RVA: 0x00AD4950 File Offset: 0x00AD2B50
		protected override void OnButtonClick()
		{
			TowerDefenseRankViewModelV2 towerDefenseRankViewModelV = new TowerDefenseRankViewModelV2();
			towerDefenseRankViewModelV.InstanceId = this.InstanceId;
			UiManager.Instance.OpenView(EUiViewName.TowerDefenseRankViewV2, towerDefenseRankViewModelV, null);
		}

		// Token: 0x06026AA3 RID: 158371 RVA: 0x00AD4980 File Offset: 0x00AD2B80
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
