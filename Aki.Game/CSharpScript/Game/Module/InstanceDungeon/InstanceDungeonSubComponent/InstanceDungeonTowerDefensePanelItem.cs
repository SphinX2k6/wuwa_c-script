using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x020058B1 RID: 22705
	public class InstanceDungeonTowerDefensePanelItem : UiPanelBase
	{
		// Token: 0x06039BE3 RID: 236515 RVA: 0x00DB95FC File Offset: 0x00DB77FC
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

		// Token: 0x06039BE4 RID: 236516 RVA: 0x00DB96E4 File Offset: 0x00DB78E4
		protected override void OnStart()
		{
			if (this.ItemDataHandle != null && this.ItemDataHandle.HaveRefresh)
			{
				this.RefreshItem();
			}
		}

		// Token: 0x06039BE5 RID: 236517 RVA: 0x00DB9704 File Offset: 0x00DB7904
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

		// Token: 0x06039BE6 RID: 236518 RVA: 0x00DB9780 File Offset: 0x00DB7980
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

		// Token: 0x0401E27F RID: 123519
		[Nullable(2)]
		private IInstanceDungeonTowerDefensePanelItem ItemDataHandle;

		// Token: 0x0200BB17 RID: 47895
		private enum EChildType
		{
			// Token: 0x04038848 RID: 231496
			BtnScoreReward,
			// Token: 0x04038849 RID: 231497
			TxtScore,
			// Token: 0x0403884A RID: 231498
			ScoreRedDot,
			// Token: 0x0403884B RID: 231499
			TxtDesc
		}
	}
}
