using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003ACC RID: 15052
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseRankViewModel
	{
		// Token: 0x06026ABC RID: 158396 RVA: 0x00AD4FE0 File Offset: 0x00AD31E0
		public void RegisterView(TowerDefenseRankView view)
		{
			this.View = view;
		}

		// Token: 0x06026ABD RID: 158397 RVA: 0x00AD4FEC File Offset: 0x00AD31EC
		public UniTask RequestRankData()
		{
			TowerDefenseRankViewModel.<RequestRankData>d__4 <RequestRankData>d__;
			<RequestRankData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestRankData>d__.<>4__this = this;
			<RequestRankData>d__.<>1__state = -1;
			<RequestRankData>d__.<>t__builder.Start<TowerDefenseRankViewModel.<RequestRankData>d__4>(ref <RequestRankData>d__);
			return <RequestRankData>d__.<>t__builder.Task;
		}

		// Token: 0x06026ABE RID: 158398 RVA: 0x00AD5030 File Offset: 0x00AD3230
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

		// Token: 0x06026ABF RID: 158399 RVA: 0x00AD5074 File Offset: 0x00AD3274
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

		// Token: 0x06026AC0 RID: 158400 RVA: 0x00AD50C8 File Offset: 0x00AD32C8
		public bool TabItemCanExecuteChange(TowerDefenceDefine.ETabType tabType)
		{
			TowerDefenceDefine.ETabType? currentType = this.CurrentType;
			return !(currentType.GetValueOrDefault() == tabType & currentType != null);
		}

		// Token: 0x040152BD RID: 86717
		private TowerDefenceDefine.ETabType? CurrentType;

		// Token: 0x040152BE RID: 86718
		public int InstanceId;

		// Token: 0x040152BF RID: 86719
		private TowerDefenseRankView View;
	}
}
