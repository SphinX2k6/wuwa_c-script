using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D90 RID: 15760
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeBossChallengeDebuffListItem : UiPanelBase
	{
		// Token: 0x060284CA RID: 165066 RVA: 0x00B49558 File Offset: 0x00B47758
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

		// Token: 0x060284CB RID: 165067 RVA: 0x00B49640 File Offset: 0x00B47840
		protected override void OnStart()
		{
			this.DebuffScrollView = new GenericScrollViewNew<RoguelikeBossChallengeDebuffItem, RoguelikeBossChallengeBuffData>(base.GetScrollViewWithScrollbar(1), new Func<RoguelikeBossChallengeDebuffItem>(this.CreateBossDebuffItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, null);
			this.RefreshToggleState();
		}

		// Token: 0x060284CC RID: 165068 RVA: 0x00B4967C File Offset: 0x00B4787C
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

		// Token: 0x060284CD RID: 165069 RVA: 0x00B496C8 File Offset: 0x00B478C8
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

		// Token: 0x060284CE RID: 165070 RVA: 0x00B496FC File Offset: 0x00B478FC
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

		// Token: 0x060284CF RID: 165071 RVA: 0x00B49722 File Offset: 0x00B47922
		protected override void OnBeforeDestroy()
		{
			this.DebuffScrollView = null;
			this.CurrentDataList = new List<RoguelikeBossChallengeBuffData>();
		}

		// Token: 0x060284D0 RID: 165072 RVA: 0x00B49738 File Offset: 0x00B47938
		private void UpdateDataDescMode()
		{
			EDescModel descModel = RoguelikeModel.Instance.GetDescModel();
			foreach (RoguelikeBossChallengeBuffData roguelikeBossChallengeBuffData in this.CurrentDataList)
			{
				roguelikeBossChallengeBuffData.DescMode = descModel;
			}
		}

		// Token: 0x060284D1 RID: 165073 RVA: 0x00B49794 File Offset: 0x00B47994
		private void OnDebuffListRefreshed(int currentBossId)
		{
			if (this.DebuffScrollView == null)
			{
				return;
			}
			this.DebuffScrollView.ScrollToTop(0);
			this.PlayCurrentBossStartSequence(this.DebuffScrollView.GetScrollItemList(), currentBossId);
		}

		// Token: 0x060284D2 RID: 165074 RVA: 0x00B497C4 File Offset: 0x00B479C4
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

		// Token: 0x060284D3 RID: 165075 RVA: 0x00B49820 File Offset: 0x00B47A20
		private void OnTogDescModeChanged(EToggleState state)
		{
			RoguelikeModel.Instance.UpdateDescModel(state == EToggleState.ETT_Checked);
		}

		// Token: 0x060284D4 RID: 165076 RVA: 0x00B49830 File Offset: 0x00B47A30
		private RoguelikeBossChallengeDebuffItem CreateBossDebuffItem()
		{
			return new RoguelikeBossChallengeDebuffItem();
		}

		// Token: 0x060284D5 RID: 165077 RVA: 0x00B49837 File Offset: 0x00B47A37
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

		// Token: 0x04015E74 RID: 89716
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RoguelikeBossChallengeDebuffItem, RoguelikeBossChallengeBuffData> DebuffScrollView;

		// Token: 0x04015E75 RID: 89717
		private List<RoguelikeBossChallengeBuffData> CurrentDataList = new List<RoguelikeBossChallengeBuffData>();

		// Token: 0x02009973 RID: 39283
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0402FDA5 RID: 196005
			public const int TxtTitle = 0;

			// Token: 0x0402FDA6 RID: 196006
			public const int DebuffItemScroll = 1;

			// Token: 0x0402FDA7 RID: 196007
			public const int UiItemBossDebuffItem = 2;

			// Token: 0x0402FDA8 RID: 196008
			public const int TogDescMode = 3;
		}
	}
}
