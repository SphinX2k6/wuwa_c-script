using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.SceneGameplayPanel
{
	// Token: 0x020047F2 RID: 18418
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneGameplayTipGrid : UiPanelBase
	{
		// Token: 0x060303E0 RID: 197600 RVA: 0x00B2FFB5 File Offset: 0x00B2E1B5
		public void Initialize(AActor actor)
		{
			base.CreateThenShowByActor(actor, null);
		}

		// Token: 0x060303E1 RID: 197601 RVA: 0x00B2FFC0 File Offset: 0x00B2E1C0
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

		// Token: 0x060303E2 RID: 197602 RVA: 0x00B300C9 File Offset: 0x00B2E2C9
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x060303E3 RID: 197603 RVA: 0x00B300DD File Offset: 0x00B2E2DD
		protected override void OnBeforeDestroy()
		{
			this.ItemGridList.Clear();
			this.OnClickPreviewCall = null;
		}

		// Token: 0x060303E4 RID: 197604 RVA: 0x00B300F1 File Offset: 0x00B2E2F1
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

		// Token: 0x060303E5 RID: 197605 RVA: 0x00B3012C File Offset: 0x00B2E32C
		public void SetBtnPreviewVisible(bool visible)
		{
			base.GetButton(3).RootUIComp.Get().SetUIActive(visible);
		}

		// Token: 0x060303E6 RID: 197606 RVA: 0x00B30154 File Offset: 0x00B2E354
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

		// Token: 0x060303E7 RID: 197607 RVA: 0x00B3028C File Offset: 0x00B2E48C
		protected virtual void OnRefreshItemGrid(CommonItemSmallItemGrid grid, int itemId, int itemCount, bool showGet = false)
		{
			grid.RefreshByConfigId(itemId, new int?(itemCount), null, showGet, false);
		}

		// Token: 0x060303E8 RID: 197608 RVA: 0x00B3029F File Offset: 0x00B2E49F
		private void UpdateTitle(string title)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(0), title, Array.Empty<object>());
		}

		// Token: 0x060303E9 RID: 197609 RVA: 0x00B302B8 File Offset: 0x00B2E4B8
		private void UpdateTitleNew(string title)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), title, Array.Empty<object>());
		}

		// Token: 0x060303EA RID: 197610 RVA: 0x00B302D1 File Offset: 0x00B2E4D1
		private void OnClickPreview()
		{
			Action onClickPreviewCall = this.OnClickPreviewCall;
			if (onClickPreviewCall == null)
			{
				return;
			}
			onClickPreviewCall();
		}

		// Token: 0x04019F85 RID: 106373
		[Nullable(2)]
		public Action OnClickPreviewCall;

		// Token: 0x04019F86 RID: 106374
		[Nullable(2)]
		private Dictionary<int, int> Reward;

		// Token: 0x04019F87 RID: 106375
		private bool IsShowReward;

		// Token: 0x04019F88 RID: 106376
		private readonly List<CommonItemSmallItemGrid> ItemGridList = new List<CommonItemSmallItemGrid>();

		// Token: 0x0200AABB RID: 43707
		[NullableContext(0)]
		public static class EChildCom
		{
			// Token: 0x04033EEB RID: 212715
			public const int RewardTitle = 0;

			// Token: 0x04033EEC RID: 212716
			public const int UiItemContainer = 1;

			// Token: 0x04033EED RID: 212717
			public const int UiItemItem = 2;

			// Token: 0x04033EEE RID: 212718
			public const int BtnPreview = 3;

			// Token: 0x04033EEF RID: 212719
			public const int DoubleTip = 4;
		}
	}
}
