using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003ACD RID: 15053
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseRankViewModelV2
	{
		// Token: 0x06026AC2 RID: 158402 RVA: 0x00AD50FD File Offset: 0x00AD32FD
		public void RegisterView(TowerDefenseRankViewV2 view)
		{
			this.View = view;
		}

		// Token: 0x06026AC3 RID: 158403 RVA: 0x00AD5108 File Offset: 0x00AD3308
		public UniTask RequestRankData()
		{
			TowerDefenseRankViewModelV2.<RequestRankData>d__4 <RequestRankData>d__;
			<RequestRankData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestRankData>d__.<>4__this = this;
			<RequestRankData>d__.<>1__state = -1;
			<RequestRankData>d__.<>t__builder.Start<TowerDefenseRankViewModelV2.<RequestRankData>d__4>(ref <RequestRankData>d__);
			return <RequestRankData>d__.<>t__builder.Task;
		}

		// Token: 0x06026AC4 RID: 158404 RVA: 0x00AD514C File Offset: 0x00AD334C
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

		// Token: 0x06026AC5 RID: 158405 RVA: 0x00AD5190 File Offset: 0x00AD3390
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

		// Token: 0x06026AC6 RID: 158406 RVA: 0x00AD51E4 File Offset: 0x00AD33E4
		public bool TabItemCanExecuteChange(TowerDefenceDefine.ETabType tabType)
		{
			TowerDefenceDefine.ETabType? currentType = this.CurrentType;
			return !(currentType.GetValueOrDefault() == tabType & currentType != null);
		}

		// Token: 0x040152C0 RID: 86720
		public int InstanceId;

		// Token: 0x040152C1 RID: 86721
		private TowerDefenseRankViewV2 View;

		// Token: 0x040152C2 RID: 86722
		private TowerDefenceDefine.ETabType? CurrentType;
	}
}
