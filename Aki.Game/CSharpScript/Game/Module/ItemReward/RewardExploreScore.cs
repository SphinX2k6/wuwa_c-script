using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x02005806 RID: 22534
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreScore : UiPanelBase
	{
		// Token: 0x0603948E RID: 234638 RVA: 0x00D95ED4 File Offset: 0x00D940D4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603948F RID: 234639 RVA: 0x00D95F40 File Offset: 0x00D94140
		protected override UniTask OnBeforeStartAsync()
		{
			RewardExploreScore.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RewardExploreScore.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039490 RID: 234640 RVA: 0x00D95F84 File Offset: 0x00D94184
		protected override void OnStart()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(0);
			this.Scroller = new GenericLayout<RewardExploreScore.ScoreItem, IRewardExploreTargetReached>(scrollViewWithScrollbar.GetContent().GetComponentByClass(UUILayoutBase.StaticClass()) as UUILayoutBase, new Func<RewardExploreScore.ScoreItem>(this.CreateTaskItem), null, false, true);
		}

		// Token: 0x06039491 RID: 234641 RVA: 0x00D95FCD File Offset: 0x00D941CD
		private RewardExploreScore.ScoreItem CreateTaskItem()
		{
			return new RewardExploreScore.ScoreItem();
		}

		// Token: 0x06039492 RID: 234642 RVA: 0x00D95FD4 File Offset: 0x00D941D4
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x06039493 RID: 234643 RVA: 0x00D95FD6 File Offset: 0x00D941D6
		public void Refresh(ReachTargetData data)
		{
			GenericLayout<RewardExploreScore.ScoreItem, IRewardExploreTargetReached> scroller = this.Scroller;
			if (scroller != null)
			{
				scroller.RefreshByData(data.TargetReached, null, false);
			}
			RewardExploreScore.NewRecordItem newRecordItemInstance = this.NewRecordItemInstance;
			if (newRecordItemInstance == null)
			{
				return;
			}
			newRecordItemInstance.Refresh(data);
		}

		// Token: 0x0401DF52 RID: 122706
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RewardExploreScore.ScoreItem, IRewardExploreTargetReached> Scroller;

		// Token: 0x0401DF53 RID: 122707
		[Nullable(2)]
		private RewardExploreScore.NewRecordItem NewRecordItemInstance;

		// Token: 0x0200BA02 RID: 47618
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040383A8 RID: 230312
			public const int LayoutItem = 0;

			// Token: 0x040383A9 RID: 230313
			public const int NewRecordItem = 1;
		}

		// Token: 0x0200BA03 RID: 47619
		[Nullable(0)]
		public class ScoreItem : UiPanelBase, IGridProxy<IRewardExploreTargetReached>
		{
			// Token: 0x1700A1BE RID: 41406
			// (get) Token: 0x0604F722 RID: 325410 RVA: 0x0154343E File Offset: 0x0154163E
			// (set) Token: 0x0604F723 RID: 325411 RVA: 0x01543446 File Offset: 0x01541646
			[Nullable(new byte[]
			{
				2,
				1,
				1,
				1
			})]
			public IScrollViewDelegate<IGridProxy<IRewardExploreTargetReached>, IRewardExploreTargetReached> ScrollViewDelegate { [return: Nullable(new byte[]
			{
				2,
				1,
				1,
				1
			})] get; [param: Nullable(new byte[]
			{
				2,
				1,
				1,
				1
			})] set; }

			// Token: 0x1700A1BF RID: 41407
			// (get) Token: 0x0604F724 RID: 325412 RVA: 0x0154344F File Offset: 0x0154164F
			// (set) Token: 0x0604F725 RID: 325413 RVA: 0x01543457 File Offset: 0x01541657
			public int GridIndex { get; set; }

			// Token: 0x1700A1C0 RID: 41408
			// (get) Token: 0x0604F726 RID: 325414 RVA: 0x01543460 File Offset: 0x01541660
			// (set) Token: 0x0604F727 RID: 325415 RVA: 0x01543468 File Offset: 0x01541668
			public int DisplayIndex { get; set; }

			// Token: 0x0604F728 RID: 325416 RVA: 0x01543471 File Offset: 0x01541671
			public void Clear()
			{
			}

			// Token: 0x0604F729 RID: 325417 RVA: 0x01543473 File Offset: 0x01541673
			public void OnSelected(bool fireEvent)
			{
			}

			// Token: 0x0604F72A RID: 325418 RVA: 0x01543475 File Offset: 0x01541675
			public void OnDeselected(bool fireEvent)
			{
			}

			// Token: 0x0604F72B RID: 325419 RVA: 0x01543477 File Offset: 0x01541677
			public object GetKey(IRewardExploreTargetReached data, int gridIndex)
			{
				return null;
			}

			// Token: 0x0604F72C RID: 325420 RVA: 0x0154347C File Offset: 0x0154167C
			protected unsafe override void OnRegisterComponent()
			{
				int num = 3;
				List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
				CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
				Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
				int num2 = 0;
				*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
				this.ComponentRegisterInfos = list;
				this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
			}

			// Token: 0x0604F72D RID: 325421 RVA: 0x01543511 File Offset: 0x01541711
			public void Refresh(IRewardExploreTargetReached data, bool isSelected, int gridIndex)
			{
				this.RefreshName(data);
				this.RefreshDesc(data);
			}

			// Token: 0x0604F72E RID: 325422 RVA: 0x01543521 File Offset: 0x01541721
			private void RefreshName(IRewardExploreTargetReached data)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.DescriptionTextId, Array.Empty<object>());
			}

			// Token: 0x0604F72F RID: 325423 RVA: 0x0154353F File Offset: 0x0154173F
			private void RefreshDesc(IRewardExploreTargetReached data)
			{
				UUIText text = base.GetText(2);
				if (text == null)
				{
					return;
				}
				text.SetText(data.Target[0], true);
			}

			// Token: 0x0200D16C RID: 53612
			[NullableContext(0)]
			private class EScoreItemComponent
			{
				// Token: 0x0403ED9A RID: 257434
				public const int SpriteBg = 0;

				// Token: 0x0403ED9B RID: 257435
				public const int NameText = 1;

				// Token: 0x0403ED9C RID: 257436
				public const int DescText = 2;
			}
		}

		// Token: 0x0200BA04 RID: 47620
		[Nullable(0)]
		public class NewRecordItem : UiPanelBase
		{
			// Token: 0x0604F731 RID: 325425 RVA: 0x01543568 File Offset: 0x01541768
			protected unsafe override void OnRegisterComponent()
			{
				int num = 3;
				List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
				CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
				Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
				int num2 = 0;
				*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
				this.ComponentRegisterInfos = list;
				this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
			}

			// Token: 0x0604F732 RID: 325426 RVA: 0x015435FD File Offset: 0x015417FD
			public void Refresh(ReachTargetData data)
			{
				this.RefreshTitle(data);
				this.RefreshRecord(data);
				this.SetNewRecordItemVisible(data.IfNewRecord);
			}

			// Token: 0x0604F733 RID: 325427 RVA: 0x01543619 File Offset: 0x01541819
			private void RefreshTitle(ReachTargetData data)
			{
				if (StringUtils.IsEmpty(data.RecordTextId))
				{
					return;
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.RecordTextId, Array.Empty<object>());
			}

			// Token: 0x0604F734 RID: 325428 RVA: 0x01543645 File Offset: 0x01541845
			private void RefreshRecord(ReachTargetData data)
			{
				UUIText text = base.GetText(1);
				if (text == null)
				{
					return;
				}
				text.SetText(data.FullScore.ToString(), true);
			}

			// Token: 0x0604F735 RID: 325429 RVA: 0x01543664 File Offset: 0x01541864
			private void SetNewRecordItemVisible(bool bVisible)
			{
				UUIItem item = base.GetItem(2);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(bVisible);
			}

			// Token: 0x0200D16D RID: 53613
			[NullableContext(0)]
			private class ENewRecordCompoent
			{
				// Token: 0x0403ED9D RID: 257437
				public const int TitleText = 0;

				// Token: 0x0403ED9E RID: 257438
				public const int RecordText = 1;

				// Token: 0x0403ED9F RID: 257439
				public const int NewRecordItem = 2;
			}
		}
	}
}
