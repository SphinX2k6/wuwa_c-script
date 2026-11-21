using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x02004889 RID: 18569
	public class InstanceDungeonTowerDefensePanelItem : UiPanelBase
	{
		// Token: 0x0602EB06 RID: 191238 RVA: 0x00D08514 File Offset: 0x00D06714
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtnScoreReward));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602EB07 RID: 191239 RVA: 0x00D085FC File Offset: 0x00D067FC
		protected override void OnStart()
		{
			if (this.ItemDataHandle != null && this.ItemDataHandle.HaveRefresh)
			{
				this.RefreshItem();
			}
		}

		// Token: 0x0602EB08 RID: 191240 RVA: 0x00D0861C File Offset: 0x00D0681C
		public void RefreshItem()
		{
			if (base.InAsyncLoading())
			{
				this.ItemDataHandle = new IInstanceDungeonTowerDefensePanelItem
				{
					HaveRefresh = true
				};
				return;
			}
			base.GetItem(2).SetUIActive(TowerDefenseController.Instance.CheckHasReward());
			string text = TowerDefenseController.Instance.BuildTotalScoreContent();
			base.GetText(1).SetText(text ?? "", true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "TowerDefence_PintDesc", Array.Empty<object>());
		}

		// Token: 0x0602EB09 RID: 191241 RVA: 0x00D08698 File Offset: 0x00D06898
		private void OnClickBtnScoreReward()
		{
			IActivityRewardViewData param = TowerDefenseController.Instance.BuildPreviewRewardData();
			UiManager.Instance.OpenView(EUiViewName.ActivityRewardPopUpView, param, delegate(bool success, int viewId)
			{
				if (success && UiManager.Instance.IsViewShow(EUiViewName.InstanceDungeonEntranceView))
				{
					UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.InstanceDungeonEntranceView);
					if (viewByName == null)
					{
						return;
					}
					viewByName.AddChildViewById(viewId);
				}
			});
		}

		// Token: 0x04018D1C RID: 101660
		[Nullable(2)]
		private IInstanceDungeonTowerDefensePanelItem ItemDataHandle;

		// Token: 0x0200A530 RID: 42288
		private enum EChildType
		{
			// Token: 0x04033249 RID: 209481
			BtnScoreReward,
			// Token: 0x0403324A RID: 209482
			TxtScore,
			// Token: 0x0403324B RID: 209483
			ScoreRedDot,
			// Token: 0x0403324C RID: 209484
			TxtDesc
		}
	}
}
