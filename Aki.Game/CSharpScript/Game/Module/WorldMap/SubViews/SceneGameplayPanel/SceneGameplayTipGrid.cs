using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.SceneGameplayPanel
{
	// Token: 0x02003723 RID: 14115
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneGameplayTipGrid : UiPanelBase
	{
		// Token: 0x06024BB0 RID: 150448 RVA: 0x00A5FF53 File Offset: 0x00A5E153
		public void Initialize(AActor actor)
		{
			base.CreateThenShowByActor(actor, null);
		}

		// Token: 0x06024BB1 RID: 150449 RVA: 0x00A5FF60 File Offset: 0x00A5E160
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickPreview));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06024BB2 RID: 150450 RVA: 0x00A60069 File Offset: 0x00A5E269
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x06024BB3 RID: 150451 RVA: 0x00A6007D File Offset: 0x00A5E27D
		protected override void OnBeforeDestroy()
		{
			this.ItemGridList.Clear();
			this.OnClickPreviewCall = null;
		}

		// Token: 0x06024BB4 RID: 150452 RVA: 0x00A60091 File Offset: 0x00A5E291
		public void Refresh(Dictionary<int, int> reward, string title, bool useNew = false, bool showGet = false, bool showDouble = false)
		{
			this.Reward = reward;
			if (useNew)
			{
				this.UpdateTitleNew(title);
			}
			else
			{
				this.UpdateTitle(title);
			}
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(showDouble);
			}
			this.UpdateRewardPreview(showGet);
		}

		// Token: 0x06024BB5 RID: 150453 RVA: 0x00A600CC File Offset: 0x00A5E2CC
		public void SetBtnPreviewVisible(bool visible)
		{
			base.GetButton(3).RootUIComp.Get().SetUIActive(visible);
		}

		// Token: 0x06024BB6 RID: 150454 RVA: 0x00A600F4 File Offset: 0x00A5E2F4
		private void UpdateRewardPreview(bool showGet = false)
		{
			Dictionary<int, int> reward = this.Reward;
			this.IsShowReward = (reward != null && reward.Count > 0);
			int num = 0;
			if (this.IsShowReward)
			{
				UUIItem item = base.GetItem(2);
				AActor actor = (item != null) ? item.GetOwner() : null;
				UUIItem item2 = base.GetItem(1);
				int num2 = 0;
				foreach (KeyValuePair<int, int> keyValuePair in this.Reward)
				{
					CommonItemSmallItemGrid commonItemSmallItemGrid;
					if (num2 < this.ItemGridList.Count)
					{
						commonItemSmallItemGrid = this.ItemGridList[num2];
					}
					else
					{
						commonItemSmallItemGrid = new CommonItemSmallItemGrid();
						commonItemSmallItemGrid.Initialize(LguiUtil.Instance.DuplicateActor(actor, item2));
						this.ItemGridList.Add(commonItemSmallItemGrid);
					}
					this.OnRefreshItemGrid(commonItemSmallItemGrid, keyValuePair.Key, keyValuePair.Value, showGet);
					commonItemSmallItemGrid.SetActive(true);
					num2++;
				}
				num = this.Reward.Count;
			}
			for (int i = num; i < this.ItemGridList.Count; i++)
			{
				this.ItemGridList[i].SetActive(false);
			}
		}

		// Token: 0x06024BB7 RID: 150455 RVA: 0x00A6022C File Offset: 0x00A5E42C
		protected virtual void OnRefreshItemGrid(CommonItemSmallItemGrid grid, int itemId, int itemCount, bool showGet = false)
		{
			grid.RefreshByConfigId(itemId, new int?(itemCount), null, showGet, false);
		}

		// Token: 0x06024BB8 RID: 150456 RVA: 0x00A6023F File Offset: 0x00A5E43F
		private void UpdateTitle(string title)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(0), title, Array.Empty<object>());
		}

		// Token: 0x06024BB9 RID: 150457 RVA: 0x00A60258 File Offset: 0x00A5E458
		private void UpdateTitleNew(string title)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), title, Array.Empty<object>());
		}

		// Token: 0x06024BBA RID: 150458 RVA: 0x00A60271 File Offset: 0x00A5E471
		private void OnClickPreview()
		{
			Action onClickPreviewCall = this.OnClickPreviewCall;
			if (onClickPreviewCall == null)
			{
				return;
			}
			onClickPreviewCall();
		}

		// Token: 0x04014639 RID: 83513
		[Nullable(2)]
		public Action OnClickPreviewCall;

		// Token: 0x0401463A RID: 83514
		[Nullable(2)]
		private Dictionary<int, int> Reward;

		// Token: 0x0401463B RID: 83515
		private bool IsShowReward;

		// Token: 0x0401463C RID: 83516
		private readonly List<CommonItemSmallItemGrid> ItemGridList = new List<CommonItemSmallItemGrid>();

		// Token: 0x0200946C RID: 37996
		[NullableContext(0)]
		public static class EChildCom
		{
			// Token: 0x0402E66E RID: 190062
			public const int RewardTitle = 0;

			// Token: 0x0402E66F RID: 190063
			public const int UiItemContainer = 1;

			// Token: 0x0402E670 RID: 190064
			public const int UiItemItem = 2;

			// Token: 0x0402E671 RID: 190065
			public const int BtnPreview = 3;

			// Token: 0x0402E672 RID: 190066
			public const int DoubleTip = 4;
		}
	}
}
