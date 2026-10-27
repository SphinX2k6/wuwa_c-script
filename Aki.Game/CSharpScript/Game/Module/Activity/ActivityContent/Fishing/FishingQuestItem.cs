using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200661A RID: 26138
	public class FishingQuestItem : GridProxyAbstract<int>
	{
		// Token: 0x0604186C RID: 268396 RVA: 0x00FE1834 File Offset: 0x00FDFA34
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0604186D RID: 268397 RVA: 0x00FE1942 File Offset: 0x00FDFB42
		protected override void OnStart()
		{
			this.TaskLayout = new GenericLayout<FishingQuestItemChildItem, int>(base.GetVerticalLayout(1), new Func<FishingQuestItemChildItem>(this.InitItem), null, false, true);
		}

		// Token: 0x0604186E RID: 268398 RVA: 0x00FE1968 File Offset: 0x00FDFB68
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			FishingEntrustPool fishingEntrustPoolById = FishingConfig.Instance.GetFishingEntrustPoolById(data);
			this.SetSpriteByPath(fishingEntrustPoolById.TitleSprite, base.GetSprite(3), false, null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), fishingEntrustPoolById.TitleName, Array.Empty<object>());
			this.TaskList = FishingQuestModel.Instance.GetEntrustsByPoolType(data);
			this.TaskList.Sort(delegate(int a, int b)
			{
				FishingEntrust? fishingEntrust = FishingConfig.Instance.GetFishingEntrust(a);
				FishingEntrust? fishingEntrust2 = FishingConfig.Instance.GetFishingEntrust(b);
				if (fishingEntrust == null && fishingEntrust2 == null)
				{
					return 0;
				}
				if (fishingEntrust == null)
				{
					return 1;
				}
				if (fishingEntrust2 == null)
				{
					return -1;
				}
				return fishingEntrust2.Value.Star - fishingEntrust.Value.Star;
			});
			if (data == 4)
			{
				int techNodeCurrentLevel = FishingModel.Instance.GetTechNodeCurrentLevel(FishingModel.Instance.FishingSlotCountTech);
				int techNodeMaxLevel = FishingModel.Instance.GetTechNodeMaxLevel(FishingModel.Instance.FishingSlotCountTech);
				if (techNodeCurrentLevel < techNodeMaxLevel)
				{
					this.TaskList.Add(-1);
				}
			}
			this.TaskLayout.RefreshByData(this.TaskList, delegate
			{
				if (this.ScrollToHandle < 0)
				{
					return;
				}
				FishingQuestItemChildItem layoutItemByIndex = this.TaskLayout.GetLayoutItemByIndex(this.ScrollToHandle);
				if (layoutItemByIndex != null)
				{
					layoutItemByIndex.SelectToggle();
				}
				this.ScrollToHandle = -1;
			}, false);
			base.GetItem(6).SetColor(FColor.FromHex(FishingDefine.fishingQuestPoolColorText[data]));
		}

		// Token: 0x0604186F RID: 268399 RVA: 0x00FE1A70 File Offset: 0x00FDFC70
		public void SelectFirstItem(int target = 0)
		{
			FishingQuestItemChildItem layoutItemByIndex = this.TaskLayout.GetLayoutItemByIndex(target);
			if (layoutItemByIndex == null)
			{
				this.ScrollToHandle = target;
				return;
			}
			layoutItemByIndex.SelectToggle();
		}

		// Token: 0x06041870 RID: 268400 RVA: 0x00FE1A9B File Offset: 0x00FDFC9B
		public int HaveTargetTask(int target)
		{
			return this.TaskList.IndexOf(target);
		}

		// Token: 0x06041871 RID: 268401 RVA: 0x00FE1AA9 File Offset: 0x00FDFCA9
		[NullableContext(1)]
		private FishingQuestItemChildItem InitItem()
		{
			return new FishingQuestItemChildItem
			{
				OnClickTaskCallBack = this.OnClickTaskCallBack
			};
		}

		// Token: 0x06041872 RID: 268402 RVA: 0x00FE1ABC File Offset: 0x00FDFCBC
		public void RefreshChildItemStateAbout()
		{
			GenericLayout<FishingQuestItemChildItem, int> taskLayout = this.TaskLayout;
			List<FishingQuestItemChildItem> list = (taskLayout != null) ? taskLayout.GetLayoutItemList() : null;
			if (list == null)
			{
				return;
			}
			foreach (FishingQuestItemChildItem fishingQuestItemChildItem in list)
			{
				fishingQuestItemChildItem.RefreshItem();
			}
		}

		// Token: 0x04022182 RID: 139650
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<int, UUIExtendToggle, Action> OnClickTaskCallBack;

		// Token: 0x04022183 RID: 139651
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<FishingQuestItemChildItem, int> TaskLayout;

		// Token: 0x04022184 RID: 139652
		private int ScrollToHandle = -1;

		// Token: 0x04022185 RID: 139653
		[Nullable(1)]
		private List<int> TaskList = new List<int>();

		// Token: 0x0200C82E RID: 51246
		private class EComponentDefine
		{
			// Token: 0x0403C752 RID: 247634
			public const int RootItem = 0;

			// Token: 0x0403C753 RID: 247635
			public const int TaskLayout = 1;

			// Token: 0x0403C754 RID: 247636
			public const int TitleText = 2;

			// Token: 0x0403C755 RID: 247637
			public const int TitleSprite = 3;

			// Token: 0x0403C756 RID: 247638
			public const int TitleItem = 4;

			// Token: 0x0403C757 RID: 247639
			public const int TaskItem = 5;

			// Token: 0x0403C758 RID: 247640
			public const int TitleBgItem = 6;
		}
	}
}
