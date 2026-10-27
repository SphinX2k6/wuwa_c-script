using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DC7 RID: 19911
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeBossChallengeDebuffListItem : UiPanelBase
	{
		// Token: 0x0603365D RID: 210525 RVA: 0x00C00018 File Offset: 0x00BFE218
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.OnTogDescModeChanged));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603365E RID: 210526 RVA: 0x00C00100 File Offset: 0x00BFE300
		protected override void OnStart()
		{
			this.DebuffScrollView = new GenericScrollViewNew<RoguelikeBossChallengeDebuffItem, RoguelikeBossChallengeBuffData>(base.GetScrollViewWithScrollbar(1), new Func<RoguelikeBossChallengeDebuffItem>(this.CreateBossDebuffItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, null);
			this.RefreshToggleState();
		}

		// Token: 0x0603365F RID: 210527 RVA: 0x00C0013C File Offset: 0x00BFE33C
		public void RefreshDebuffList(List<RoguelikeBossChallengeBuffData> dataList, int currentBossId)
		{
			this.CurrentDataList = dataList;
			this.UpdateDataDescMode();
			GenericScrollViewNew<RoguelikeBossChallengeDebuffItem, RoguelikeBossChallengeBuffData> debuffScrollView = this.DebuffScrollView;
			if (debuffScrollView == null)
			{
				return;
			}
			debuffScrollView.RefreshByData(dataList, delegate
			{
				this.OnDebuffListRefreshed(currentBossId);
			}, false);
		}

		// Token: 0x06033660 RID: 210528 RVA: 0x00C00188 File Offset: 0x00BFE388
		public void RefreshToggleState()
		{
			EToggleState state = (RoguelikeModel.Instance.GetDescModel() == EDescModel.SIMPLE) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(3);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(state, true, false, false);
		}

		// Token: 0x06033661 RID: 210529 RVA: 0x00C001BC File Offset: 0x00BFE3BC
		public void OnDescModelChange()
		{
			this.RefreshToggleState();
			this.UpdateDataDescMode();
			GenericScrollViewNew<RoguelikeBossChallengeDebuffItem, RoguelikeBossChallengeBuffData> debuffScrollView = this.DebuffScrollView;
			if (debuffScrollView == null)
			{
				return;
			}
			debuffScrollView.RefreshByData(this.CurrentDataList, null, false);
		}

		// Token: 0x06033662 RID: 210530 RVA: 0x00C001E2 File Offset: 0x00BFE3E2
		protected override void OnBeforeDestroy()
		{
			this.DebuffScrollView = null;
			this.CurrentDataList = new List<RoguelikeBossChallengeBuffData>();
		}

		// Token: 0x06033663 RID: 210531 RVA: 0x00C001F8 File Offset: 0x00BFE3F8
		private void UpdateDataDescMode()
		{
			EDescModel descModel = RoguelikeModel.Instance.GetDescModel();
			foreach (RoguelikeBossChallengeBuffData roguelikeBossChallengeBuffData in this.CurrentDataList)
			{
				roguelikeBossChallengeBuffData.DescMode = descModel;
			}
		}

		// Token: 0x06033664 RID: 210532 RVA: 0x00C00254 File Offset: 0x00BFE454
		private void OnDebuffListRefreshed(int currentBossId)
		{
			if (this.DebuffScrollView == null)
			{
				return;
			}
			this.DebuffScrollView.ScrollToTop(0);
			this.PlayCurrentBossStartSequence(this.DebuffScrollView.GetScrollItemList(), currentBossId);
		}

		// Token: 0x06033665 RID: 210533 RVA: 0x00C00284 File Offset: 0x00BFE484
		private void PlayCurrentBossStartSequence(List<RoguelikeBossChallengeDebuffItem> itemList, int currentBossId)
		{
			if (currentBossId == 0)
			{
				return;
			}
			foreach (RoguelikeBossChallengeDebuffItem roguelikeBossChallengeDebuffItem in itemList)
			{
				if (roguelikeBossChallengeDebuffItem.IsCurrentBossBuff(currentBossId))
				{
					roguelikeBossChallengeDebuffItem.PlayStartSequence();
				}
			}
		}

		// Token: 0x06033666 RID: 210534 RVA: 0x00C002E0 File Offset: 0x00BFE4E0
		private void OnTogDescModeChanged(EToggleState state)
		{
			RoguelikeModel.Instance.UpdateDescModel(state == EToggleState.ETT_Checked);
		}

		// Token: 0x06033667 RID: 210535 RVA: 0x00C002F0 File Offset: 0x00BFE4F0
		private RoguelikeBossChallengeDebuffItem CreateBossDebuffItem()
		{
			return new RoguelikeBossChallengeDebuffItem();
		}

		// Token: 0x06033668 RID: 210536 RVA: 0x00C002F7 File Offset: 0x00BFE4F7
		[NullableContext(2)]
		public RoguelikeBossChallengeDebuffItem GetUiItemByIndex(int index)
		{
			if (this.DebuffScrollView == null)
			{
				return null;
			}
			GenericLayout<RoguelikeBossChallengeDebuffItem, RoguelikeBossChallengeBuffData> genericLayout = this.DebuffScrollView.GetGenericLayout();
			if (genericLayout != null && genericLayout.IsLock)
			{
				return null;
			}
			return this.DebuffScrollView.GetScrollItemByIndex(index);
		}

		// Token: 0x0401B4A1 RID: 111777
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RoguelikeBossChallengeDebuffItem, RoguelikeBossChallengeBuffData> DebuffScrollView;

		// Token: 0x0401B4A2 RID: 111778
		private List<RoguelikeBossChallengeBuffData> CurrentDataList = new List<RoguelikeBossChallengeBuffData>();

		// Token: 0x0200AF3E RID: 44862
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035370 RID: 217968
			public const int TxtTitle = 0;

			// Token: 0x04035371 RID: 217969
			public const int DebuffItemScroll = 1;

			// Token: 0x04035372 RID: 217970
			public const int UiItemBossDebuffItem = 2;

			// Token: 0x04035373 RID: 217971
			public const int TogDescMode = 3;
		}
	}
}
