using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005588 RID: 21896
	public class FishingDockQuestItem : UiPanelBase
	{
		// Token: 0x06036432 RID: 222258 RVA: 0x00F215A0 File Offset: 0x00F1F7A0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickQuestBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06036433 RID: 222259 RVA: 0x00F216A9 File Offset: 0x00F1F8A9
		protected override void OnStart()
		{
			this.QuestTargetItemLayout = new GenericLayout<FishingDockQuestChildItem, IFishingDockQuestChildItemData>(base.GetVerticalLayout(2), new Func<FishingDockQuestChildItem>(this.InitItem), null, false, true);
		}

		// Token: 0x06036434 RID: 222260 RVA: 0x00F216CC File Offset: 0x00F1F8CC
		protected override void OnBeforeShow()
		{
			this.RefreshItem();
		}

		// Token: 0x06036435 RID: 222261 RVA: 0x00F216D4 File Offset: 0x00F1F8D4
		public void RefreshItem()
		{
			bool uiactive = false;
			foreach (KeyValuePair<int, EFishingEntrustState> keyValuePair in FishingQuestModel.Instance.CurrentEntrusts)
			{
				int num;
				EFishingEntrustState efishingEntrustState;
				keyValuePair.Deconstruct(out num, out efishingEntrustState);
				int id = num;
				EFishingEntrustState efishingEntrustState2 = efishingEntrustState;
				FishingEntrust? fishingEntrust = FishingConfig.Instance.GetFishingEntrust(id);
				if (fishingEntrust != null)
				{
					if (fishingEntrust.Value.EntrustPool != 3 && efishingEntrustState2 == EFishingEntrustState.Deliverable)
					{
						uiactive = true;
						break;
					}
					AccessPath? accessPathConfig = SkipInterfaceConfig.Instance.GetAccessPathConfig(fishingEntrust.Value.AccessPath);
					int num2 = int.Parse(((accessPathConfig != null) ? accessPathConfig.GetValueOrDefault().Val3 : null) ?? "0");
					if (accessPathConfig != null && num2 != 0 && FishingModel.Instance.GetTechNodeCanLevelUp(num2))
					{
						uiactive = true;
						break;
					}
				}
			}
			base.GetItem(4).SetUIActive(uiactive);
			int currentTraceEntrust = FishingQuestModel.Instance.CurrentTraceEntrust;
			FishingEntrust? fishingEntrust2 = FishingConfig.Instance.GetFishingEntrust(FishingQuestModel.Instance.CurrentTraceEntrust);
			if (fishingEntrust2 == null)
			{
				return;
			}
			if (fishingEntrust2.Value.EntrustType != 0 && fishingEntrust2.Value.EntrustType != 1)
			{
				if (fishingEntrust2.Value.EntrustType == 2)
				{
					base.GetVerticalLayout(2).RootUIComp.Get().SetUIActive(false);
				}
				return;
			}
			base.GetVerticalLayout(2).RootUIComp.Get().SetUIActive(true);
			Dictionary<int, int> dictionary = fishingEntrust2.Value.EntrustTarget();
			List<IFishingDockQuestChildItemData> list = new List<IFishingDockQuestChildItemData>();
			Dictionary<int, string> dictionary2 = fishingEntrust2.Value.TargetDesText();
			foreach (KeyValuePair<int, int> keyValuePair2 in dictionary)
			{
				int num;
				int num3;
				keyValuePair2.Deconstruct(out num, out num3);
				int num4 = num;
				int maxCount = num3;
				int itemCountByItemId = DockyardModel.Instance.GetItemCountByItemId(num4);
				string text;
				FishingDockQuestChildItemData item = new FishingDockQuestChildItemData
				{
					MaxCount = maxCount,
					CurrentCount = itemCountByItemId,
					DesText = (dictionary2.TryGetValue(num4, out text) ? text : "")
				};
				list.Add(item);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), fishingEntrust2.Value.Name, Array.Empty<object>());
			GenericLayout<FishingDockQuestChildItem, IFishingDockQuestChildItemData> questTargetItemLayout = this.QuestTargetItemLayout;
			if (questTargetItemLayout == null)
			{
				return;
			}
			questTargetItemLayout.RefreshByData(list, null, false);
		}

		// Token: 0x06036436 RID: 222262 RVA: 0x00F21980 File Offset: 0x00F1FB80
		private void OnClickQuestBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.FishingQuestView, null, null);
		}

		// Token: 0x06036437 RID: 222263 RVA: 0x00F21993 File Offset: 0x00F1FB93
		[NullableContext(1)]
		private FishingDockQuestChildItem InitItem()
		{
			return new FishingDockQuestChildItem();
		}

		// Token: 0x0401CA60 RID: 117344
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<FishingDockQuestChildItem, IFishingDockQuestChildItemData> QuestTargetItemLayout;

		// Token: 0x0200B1F8 RID: 45560
		private class EComponentDefine
		{
			// Token: 0x04037008 RID: 225288
			public const int TitleText = 0;

			// Token: 0x04037009 RID: 225289
			public const int QuestBtn = 1;

			// Token: 0x0403700A RID: 225290
			public const int QuestLayout = 2;

			// Token: 0x0403700B RID: 225291
			public const int QuestItem = 3;

			// Token: 0x0403700C RID: 225292
			public const int RedDotItem = 4;
		}
	}
}
