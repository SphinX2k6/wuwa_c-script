using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005598 RID: 21912
	public class FishingQuestItem : GridProxyAbstract<int>
	{
		// Token: 0x06036531 RID: 222513 RVA: 0x00F288A8 File Offset: 0x00F26AA8
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

		// Token: 0x06036532 RID: 222514 RVA: 0x00F289B6 File Offset: 0x00F26BB6
		protected override void OnStart()
		{
			this.TaskLayout = new GenericLayout<FishingQuestItemChildItem, int>(base.GetVerticalLayout(1), new Func<FishingQuestItemChildItem>(this.InitItem), null, false, true);
		}

		// Token: 0x06036533 RID: 222515 RVA: 0x00F289DC File Offset: 0x00F26BDC
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

		// Token: 0x06036534 RID: 222516 RVA: 0x00F28AE4 File Offset: 0x00F26CE4
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

		// Token: 0x06036535 RID: 222517 RVA: 0x00F28B0F File Offset: 0x00F26D0F
		public int HaveTargetTask(int target)
		{
			return this.TaskList.IndexOf(target);
		}

		// Token: 0x06036536 RID: 222518 RVA: 0x00F28B1D File Offset: 0x00F26D1D
		[NullableContext(1)]
		private FishingQuestItemChildItem InitItem()
		{
			return new FishingQuestItemChildItem
			{
				OnClickTaskCallBack = this.OnClickTaskCallBack
			};
		}

		// Token: 0x06036537 RID: 222519 RVA: 0x00F28B30 File Offset: 0x00F26D30
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

		// Token: 0x0401CAB3 RID: 117427
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<int, UUIExtendToggle, Action> OnClickTaskCallBack;

		// Token: 0x0401CAB4 RID: 117428
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<FishingQuestItemChildItem, int> TaskLayout;

		// Token: 0x0401CAB5 RID: 117429
		private int ScrollToHandle = -1;

		// Token: 0x0401CAB6 RID: 117430
		[Nullable(1)]
		private List<int> TaskList = new List<int>();

		// Token: 0x0200B210 RID: 45584
		private class EComponentDefine
		{
			// Token: 0x04037097 RID: 225431
			public const int RootItem = 0;

			// Token: 0x04037098 RID: 225432
			public const int TaskLayout = 1;

			// Token: 0x04037099 RID: 225433
			public const int TitleText = 2;

			// Token: 0x0403709A RID: 225434
			public const int TitleSprite = 3;

			// Token: 0x0403709B RID: 225435
			public const int TitleItem = 4;

			// Token: 0x0403709C RID: 225436
			public const int TaskItem = 5;

			// Token: 0x0403709D RID: 225437
			public const int TitleBgItem = 6;
		}
	}
}
