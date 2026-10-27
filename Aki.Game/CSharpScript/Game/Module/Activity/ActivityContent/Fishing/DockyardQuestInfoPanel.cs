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
	// Token: 0x020065C5 RID: 26053
	public class DockyardQuestInfoPanel : UiPanelBase, IDockyardLeftTipsInterface
	{
		// Token: 0x17009593 RID: 38291
		// (get) Token: 0x06041593 RID: 267667 RVA: 0x00FD5DB1 File Offset: 0x00FD3FB1
		// (set) Token: 0x06041594 RID: 267668 RVA: 0x00FD5DB9 File Offset: 0x00FD3FB9
		public bool LockState { get; set; }

		// Token: 0x06041595 RID: 267669 RVA: 0x00FD5DC4 File Offset: 0x00FD3FC4
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

		// Token: 0x06041596 RID: 267670 RVA: 0x00FD5EF0 File Offset: 0x00FD40F0
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

		// Token: 0x06041597 RID: 267671 RVA: 0x00FD5F47 File Offset: 0x00FD4147
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add(EEventName.FishingRefreshBackpackData, new Action(this.RefreshList));
			this.Refresh();
		}

		// Token: 0x06041598 RID: 267672 RVA: 0x00FD5F6B File Offset: 0x00FD416B
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove(EEventName.FishingRefreshBackpackData, new Action(this.RefreshList));
		}

		// Token: 0x06041599 RID: 267673 RVA: 0x00FD5F89 File Offset: 0x00FD4189
		[NullableContext(1)]
		private QuestInfoItem CreateItem()
		{
			return new QuestInfoItem();
		}

		// Token: 0x0604159A RID: 267674 RVA: 0x00FD5F90 File Offset: 0x00FD4190
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

		// Token: 0x0604159B RID: 267675 RVA: 0x00FD6005 File Offset: 0x00FD4205
		public void Refresh()
		{
			this.RefreshList();
		}

		// Token: 0x0604159C RID: 267676 RVA: 0x00FD6010 File Offset: 0x00FD4210
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

		// Token: 0x0604159D RID: 267677 RVA: 0x00FD6188 File Offset: 0x00FD4388
		public void SetButtonQuestVisible(bool bVisible)
		{
			base.GetButton(3).RootUIComp.Get().SetUIActive(bVisible);
		}

		// Token: 0x0604159E RID: 267678 RVA: 0x00FD61B0 File Offset: 0x00FD43B0
		public void SetButtonExitVisible(bool bVisible)
		{
			base.GetButton(4).RootUIComp.Get().SetUIActive(bVisible);
		}

		// Token: 0x0604159F RID: 267679 RVA: 0x00FD61D7 File Offset: 0x00FD43D7
		private void OnQuestClick()
		{
			FishingController.Instance.OpenFishingQuestView();
		}

		// Token: 0x060415A0 RID: 267680 RVA: 0x00FD61E3 File Offset: 0x00FD43E3
		private void OnExitClick()
		{
			Action exitFunc = this.ExitFunc;
			if (exitFunc == null)
			{
				return;
			}
			exitFunc();
		}

		// Token: 0x04022011 RID: 139281
		[Nullable(1)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04022012 RID: 139282
		[Nullable(1)]
		protected GenericLayout<QuestInfoItem, IFishingDockQuestChildItemData> ListLayout;

		// Token: 0x04022013 RID: 139283
		[Nullable(2)]
		public Action ExitFunc;

		// Token: 0x0200C7E6 RID: 51174
		private class EComponentDefine
		{
			// Token: 0x0403C5FD RID: 247293
			public const int TxtTitle = 0;

			// Token: 0x0403C5FE RID: 247294
			public const int ListLayout = 1;

			// Token: 0x0403C5FF RID: 247295
			public const int ListItem = 2;

			// Token: 0x0403C600 RID: 247296
			public const int ButtonQuest = 3;

			// Token: 0x0403C601 RID: 247297
			public const int ButtonExit = 4;
		}
	}
}
