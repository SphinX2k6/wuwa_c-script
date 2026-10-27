using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B24 RID: 19236
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseRankViewModel
	{
		// Token: 0x06031D2C RID: 204076 RVA: 0x00B90F7C File Offset: 0x00B8F17C
		public void RegisterView(TowerDefenseRankView view)
		{
			this.View = view;
		}

		// Token: 0x06031D2D RID: 204077 RVA: 0x00B90F88 File Offset: 0x00B8F188
		public UniTask RequestRankData()
		{
			TowerDefenseRankViewModel.<RequestRankData>d__4 <RequestRankData>d__;
			<RequestRankData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestRankData>d__.<>4__this = this;
			<RequestRankData>d__.<>1__state = -1;
			<RequestRankData>d__.<>t__builder.Start<TowerDefenseRankViewModel.<RequestRankData>d__4>(ref <RequestRankData>d__);
			return <RequestRankData>d__.<>t__builder.Task;
		}

		// Token: 0x06031D2E RID: 204078 RVA: 0x00B90FCC File Offset: 0x00B8F1CC
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

		// Token: 0x06031D2F RID: 204079 RVA: 0x00B91010 File Offset: 0x00B8F210
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

		// Token: 0x06031D30 RID: 204080 RVA: 0x00B91064 File Offset: 0x00B8F264
		public bool TabItemCanExecuteChange(TowerDefenceDefine.ETabType tabType)
		{
			TowerDefenceDefine.ETabType? currentType = this.CurrentType;
			return !(currentType.GetValueOrDefault() == tabType & currentType != null);
		}

		// Token: 0x0401A96B RID: 108907
		private TowerDefenceDefine.ETabType? CurrentType;

		// Token: 0x0401A96C RID: 108908
		public int InstanceId;

		// Token: 0x0401A96D RID: 108909
		private TowerDefenseRankView View;
	}
}
