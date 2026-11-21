using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005543 RID: 21827
	public class DockyardQuestInfoPanel : UiPanelBase, IDockyardLeftTipsInterface
	{
		// Token: 0x170068F5 RID: 26869
		// (get) Token: 0x06036258 RID: 221784 RVA: 0x00F1CDF1 File Offset: 0x00F1AFF1
		// (set) Token: 0x06036259 RID: 221785 RVA: 0x00F1CDF9 File Offset: 0x00F1AFF9
		public bool LockState { get; set; }

		// Token: 0x0603625A RID: 221786 RVA: 0x00F1CE04 File Offset: 0x00F1B004
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnQuestClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnExitClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603625B RID: 221787 RVA: 0x00F1CF30 File Offset: 0x00F1B130
		protected override void OnStart()
		{
			this.ListLayout = new GenericLayout<QuestInfoItem, IFishingDockQuestChildItemData>(base.GetVerticalLayout(1), new Func<QuestInfoItem>(this.CreateItem), null, false, true);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(delegate(string eventName)
			{
				if (eventName == "Hide")
				{
					this.SetActive(false);
				}
			}, false);
		}

		// Token: 0x0603625C RID: 221788 RVA: 0x00F1CF87 File Offset: 0x00F1B187
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add(EEventName.FishingRefreshBackpackData, new Action(this.RefreshList));
			this.Refresh();
		}

		// Token: 0x0603625D RID: 221789 RVA: 0x00F1CFAB File Offset: 0x00F1B1AB
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove(EEventName.FishingRefreshBackpackData, new Action(this.RefreshList));
		}

		// Token: 0x0603625E RID: 221790 RVA: 0x00F1CFC9 File Offset: 0x00F1B1C9
		[NullableContext(1)]
		private QuestInfoItem CreateItem()
		{
			return new QuestInfoItem();
		}

		// Token: 0x0603625F RID: 221791 RVA: 0x00F1CFD0 File Offset: 0x00F1B1D0
		public void SetPanelVisible(bool bVisible)
		{
			if (this.LockState)
			{
				return;
			}
			if (bVisible)
			{
				this.LevelSequencePlayer.StopCurrentSequence(true, true);
				this.LevelSequencePlayer.PlaySequencePurely("Show", false, false, null, null, false);
				this.SetActive(true);
				return;
			}
			this.LevelSequencePlayer.StopCurrentSequence(true, true);
			this.LevelSequencePlayer.PlaySequencePurely("Hide", false, false, null, null, false);
		}

		// Token: 0x06036260 RID: 221792 RVA: 0x00F1D045 File Offset: 0x00F1B245
		public void Refresh()
		{
			this.RefreshList();
		}

		// Token: 0x06036261 RID: 221793 RVA: 0x00F1D050 File Offset: 0x00F1B250
		private void RefreshList()
		{
			if (FishingQuestModel.Instance.CurrentTraceEntrust == 0)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Fishing_NotTraceEntrustInShip", Array.Empty<object>());
				base.GetVerticalLayout(1).RootUIComp.Get().SetUIActive(false);
				return;
			}
			FishingEntrust? fishingEntrust = FishingConfig.Instance.GetFishingEntrust(FishingQuestModel.Instance.CurrentTraceEntrust);
			if (fishingEntrust == null)
			{
				return;
			}
			Dictionary<int, int> dictionary = fishingEntrust.Value.EntrustTarget();
			List<IFishingDockQuestChildItemData> list = new List<IFishingDockQuestChildItemData>();
			Dictionary<int, string> dictionary2 = fishingEntrust.Value.TargetDesText();
			foreach (KeyValuePair<int, int> keyValuePair in dictionary)
			{
				int itemCountByItemId = DockyardModel.Instance.GetItemCountByItemId(keyValuePair.Key);
				string text;
				FishingDockQuestChildItemData item = new FishingDockQuestChildItemData
				{
					MaxCount = keyValuePair.Value,
					CurrentCount = itemCountByItemId,
					DesText = (dictionary2.TryGetValue(keyValuePair.Key, out text) ? text : string.Empty)
				};
				list.Add(item);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), fishingEntrust.Value.Name, Array.Empty<object>());
			this.ListLayout.RefreshByData(list, null, false);
			base.GetVerticalLayout(1).RootUIComp.Get().SetUIActive(true);
		}

		// Token: 0x06036262 RID: 221794 RVA: 0x00F1D1C8 File Offset: 0x00F1B3C8
		public void SetButtonQuestVisible(bool bVisible)
		{
			base.GetButton(3).RootUIComp.Get().SetUIActive(bVisible);
		}

		// Token: 0x06036263 RID: 221795 RVA: 0x00F1D1F0 File Offset: 0x00F1B3F0
		public void SetButtonExitVisible(bool bVisible)
		{
			base.GetButton(4).RootUIComp.Get().SetUIActive(bVisible);
		}

		// Token: 0x06036264 RID: 221796 RVA: 0x00F1D217 File Offset: 0x00F1B417
		private void OnQuestClick()
		{
			FishingController.Instance.OpenFishingQuestView();
		}

		// Token: 0x06036265 RID: 221797 RVA: 0x00F1D223 File Offset: 0x00F1B423
		private void OnExitClick()
		{
			Action exitFunc = this.ExitFunc;
			if (exitFunc == null)
			{
				return;
			}
			exitFunc();
		}

		// Token: 0x0401C942 RID: 117058
		[Nullable(1)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401C943 RID: 117059
		[Nullable(1)]
		protected GenericLayout<QuestInfoItem, IFishingDockQuestChildItemData> ListLayout;

		// Token: 0x0401C944 RID: 117060
		[Nullable(2)]
		public Action ExitFunc;

		// Token: 0x0200B1C9 RID: 45513
		private class EComponentDefine
		{
			// Token: 0x04036F4B RID: 225099
			public const int TxtTitle = 0;

			// Token: 0x04036F4C RID: 225100
			public const int ListLayout = 1;

			// Token: 0x04036F4D RID: 225101
			public const int ListItem = 2;

			// Token: 0x04036F4E RID: 225102
			public const int ButtonQuest = 3;

			// Token: 0x04036F4F RID: 225103
			public const int ButtonExit = 4;
		}
	}
}
