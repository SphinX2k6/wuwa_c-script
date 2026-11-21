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
	// Token: 0x020047DD RID: 18397
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreScore : UiPanelBase
	{
		// Token: 0x0602E3A2 RID: 189346 RVA: 0x00CE4D3C File Offset: 0x00CE2F3C
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

		// Token: 0x0602E3A3 RID: 189347 RVA: 0x00CE4DA8 File Offset: 0x00CE2FA8
		protected override UniTask OnBeforeStartAsync()
		{
			RewardExploreScore.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RewardExploreScore.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E3A4 RID: 189348 RVA: 0x00CE4DEC File Offset: 0x00CE2FEC
		protected override void OnStart()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(0);
			this.Scroller = new GenericLayout<RewardExploreScore.ScoreItem, IRewardExploreTargetReached>(scrollViewWithScrollbar.GetContent().GetComponentByClass(UUILayoutBase.StaticClass()) as UUILayoutBase, new Func<RewardExploreScore.ScoreItem>(this.CreateTaskItem), null, false, true);
		}

		// Token: 0x0602E3A5 RID: 189349 RVA: 0x00CE4E35 File Offset: 0x00CE3035
		private RewardExploreScore.ScoreItem CreateTaskItem()
		{
			return new RewardExploreScore.ScoreItem();
		}

		// Token: 0x0602E3A6 RID: 189350 RVA: 0x00CE4E3C File Offset: 0x00CE303C
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x0602E3A7 RID: 189351 RVA: 0x00CE4E3E File Offset: 0x00CE303E
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

		// Token: 0x040189E9 RID: 100841
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RewardExploreScore.ScoreItem, IRewardExploreTargetReached> Scroller;

		// Token: 0x040189EA RID: 100842
		[Nullable(2)]
		private RewardExploreScore.NewRecordItem NewRecordItemInstance;

		// Token: 0x0200A418 RID: 42008
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04032D95 RID: 208277
			public const int LayoutItem = 0;

			// Token: 0x04032D96 RID: 208278
			public const int NewRecordItem = 1;
		}

		// Token: 0x0200A419 RID: 42009
		[Nullable(0)]
		public class ScoreItem : UiPanelBase, IGridProxy<IRewardExploreTargetReached>
		{
			// Token: 0x1700795B RID: 31067
			// (get) Token: 0x06045CAE RID: 285870 RVA: 0x014FC786 File Offset: 0x014FA986
			// (set) Token: 0x06045CAF RID: 285871 RVA: 0x014FC78E File Offset: 0x014FA98E
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

			// Token: 0x1700795C RID: 31068
			// (get) Token: 0x06045CB0 RID: 285872 RVA: 0x014FC797 File Offset: 0x014FA997
			// (set) Token: 0x06045CB1 RID: 285873 RVA: 0x014FC79F File Offset: 0x014FA99F
			public int GridIndex { get; set; }

			// Token: 0x1700795D RID: 31069
			// (get) Token: 0x06045CB2 RID: 285874 RVA: 0x014FC7A8 File Offset: 0x014FA9A8
			// (set) Token: 0x06045CB3 RID: 285875 RVA: 0x014FC7B0 File Offset: 0x014FA9B0
			public int DisplayIndex { get; set; }

			// Token: 0x06045CB4 RID: 285876 RVA: 0x014FC7B9 File Offset: 0x014FA9B9
			public void Clear()
			{
			}

			// Token: 0x06045CB5 RID: 285877 RVA: 0x014FC7BB File Offset: 0x014FA9BB
			public void OnSelected(bool fireEvent)
			{
			}

			// Token: 0x06045CB6 RID: 285878 RVA: 0x014FC7BD File Offset: 0x014FA9BD
			public void OnDeselected(bool fireEvent)
			{
			}

			// Token: 0x06045CB7 RID: 285879 RVA: 0x014FC7BF File Offset: 0x014FA9BF
			public object GetKey(IRewardExploreTargetReached data, int gridIndex)
			{
				return null;
			}

			// Token: 0x06045CB8 RID: 285880 RVA: 0x014FC7C4 File Offset: 0x014FA9C4
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

			// Token: 0x06045CB9 RID: 285881 RVA: 0x014FC859 File Offset: 0x014FAA59
			public void Refresh(IRewardExploreTargetReached data, bool isSelected, int gridIndex)
			{
				this.RefreshName(data);
				this.RefreshDesc(data);
			}

			// Token: 0x06045CBA RID: 285882 RVA: 0x014FC869 File Offset: 0x014FAA69
			private void RefreshName(IRewardExploreTargetReached data)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.DescriptionTextId, Array.Empty<object>());
			}

			// Token: 0x06045CBB RID: 285883 RVA: 0x014FC887 File Offset: 0x014FAA87
			private void RefreshDesc(IRewardExploreTargetReached data)
			{
				UUIText text = base.GetText(2);
				if (text == null)
				{
					return;
				}
				text.SetText(data.Target[0], true);
			}

			// Token: 0x0200BD4A RID: 48458
			[NullableContext(0)]
			private class EScoreItemComponent
			{
				// Token: 0x0403A1E2 RID: 238050
				public const int SpriteBg = 0;

				// Token: 0x0403A1E3 RID: 238051
				public const int NameText = 1;

				// Token: 0x0403A1E4 RID: 238052
				public const int DescText = 2;
			}
		}

		// Token: 0x0200A41A RID: 42010
		[Nullable(0)]
		public class NewRecordItem : UiPanelBase
		{
			// Token: 0x06045CBD RID: 285885 RVA: 0x014FC8B0 File Offset: 0x014FAAB0
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

			// Token: 0x06045CBE RID: 285886 RVA: 0x014FC945 File Offset: 0x014FAB45
			public void Refresh(ReachTargetData data)
			{
				this.RefreshTitle(data);
				this.RefreshRecord(data);
				this.SetNewRecordItemVisible(data.IfNewRecord);
			}

			// Token: 0x06045CBF RID: 285887 RVA: 0x014FC961 File Offset: 0x014FAB61
			private void RefreshTitle(ReachTargetData data)
			{
				if (StringUtils.IsEmpty(data.RecordTextId))
				{
					return;
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.RecordTextId, Array.Empty<object>());
			}

			// Token: 0x06045CC0 RID: 285888 RVA: 0x014FC98D File Offset: 0x014FAB8D
			private void RefreshRecord(ReachTargetData data)
			{
				UUIText text = base.GetText(1);
				if (text == null)
				{
					return;
				}
				text.SetText(data.FullScore.ToString(), true);
			}

			// Token: 0x06045CC1 RID: 285889 RVA: 0x014FC9AC File Offset: 0x014FABAC
			private void SetNewRecordItemVisible(bool bVisible)
			{
				UUIItem item = base.GetItem(2);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(bVisible);
			}

			// Token: 0x0200BD4B RID: 48459
			[NullableContext(0)]
			private class ENewRecordCompoent
			{
				// Token: 0x0403A1E5 RID: 238053
				public const int TitleText = 0;

				// Token: 0x0403A1E6 RID: 238054
				public const int RecordText = 1;

				// Token: 0x0403A1E7 RID: 238055
				public const int NewRecordItem = 2;
			}
		}
	}
}
