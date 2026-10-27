using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B25 RID: 19237
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseRankViewModelV2
	{
		// Token: 0x06031D32 RID: 204082 RVA: 0x00B91099 File Offset: 0x00B8F299
		public void RegisterView(TowerDefenseRankViewV2 view)
		{
			this.View = view;
		}

		// Token: 0x06031D33 RID: 204083 RVA: 0x00B910A4 File Offset: 0x00B8F2A4
		public UniTask RequestRankData()
		{
			TowerDefenseRankViewModelV2.<RequestRankData>d__4 <RequestRankData>d__;
			<RequestRankData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestRankData>d__.<>4__this = this;
			<RequestRankData>d__.<>1__state = -1;
			<RequestRankData>d__.<>t__builder.Start<TowerDefenseRankViewModelV2.<RequestRankData>d__4>(ref <RequestRankData>d__);
			return <RequestRankData>d__.<>t__builder.Task;
		}

		// Token: 0x06031D34 RID: 204084 RVA: 0x00B910E8 File Offset: 0x00B8F2E8
		public void ToggleAnonymousClick(EToggleState state)
		{
			bool isOpenAnonymousName = state == EToggleState.ETT_Checked;
			TowerDefenseController.Instance.RequestRankShowName(!isOpenAnonymousName, delegate
			{
				TowerDefenseModel.Instance.RankData.SetIsOpenAnonymousName(isOpenAnonymousName);
				TowerDefenseModel.Instance.RankData.RefreshSelfRankItemDataName(this.InstanceId);
				this.View.RefreshContentShowName();
			});
		}

		// Token: 0x06031D35 RID: 204085 RVA: 0x00B9112C File Offset: 0x00B8F32C
		public void TabItemToggle(TowerDefenceDefine.ETabType tabType)
		{
			TowerDefenceDefine.ETabType? currentType = this.CurrentType;
			this.CurrentType = new TowerDefenceDefine.ETabType?(tabType);
			if (currentType != null)
			{
				this.View.ResetLastTabItemSelected(currentType.Value);
			}
			this.View.RefreshContent(this.CurrentType.Value);
		}

		// Token: 0x06031D36 RID: 204086 RVA: 0x00B91180 File Offset: 0x00B8F380
		public bool TabItemCanExecuteChange(TowerDefenceDefine.ETabType tabType)
		{
			TowerDefenceDefine.ETabType? currentType = this.CurrentType;
			return !(currentType.GetValueOrDefault() == tabType & currentType != null);
		}

		// Token: 0x0401A96E RID: 108910
		public int InstanceId;

		// Token: 0x0401A96F RID: 108911
		private TowerDefenseRankViewV2 View;

		// Token: 0x0401A970 RID: 108912
		private TowerDefenceDefine.ETabType? CurrentType;
	}
}
