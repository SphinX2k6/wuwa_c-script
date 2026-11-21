using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047D0 RID: 18384
	public class RewardExploreAccumulatedScoreItem : UiPanelBase
	{
		// Token: 0x0602E33E RID: 189246 RVA: 0x00CE2C1C File Offset: 0x00CE0E1C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602E33F RID: 189247 RVA: 0x00CE2D0C File Offset: 0x00CE0F0C
		protected override void OnStart()
		{
			this.DetailScoreLayout = new GenericLayout<RewardExploreAccumulatedScoreItem.ScoreItem, IAccumulatedScoreLineData>(base.GetVerticalLayout(0), new Func<RewardExploreAccumulatedScoreItem.ScoreItem>(this.CreateScoreItem), null, false, true);
			this.TotalScoreLayout = new GenericLayout<RewardExploreAccumulatedScoreItem.ScoreItem, IAccumulatedScoreLineData>(base.GetVerticalLayout(2), new Func<RewardExploreAccumulatedScoreItem.ScoreItem>(this.CreateScoreItem), null, false, true);
		}

		// Token: 0x0602E340 RID: 189248 RVA: 0x00CE2D5B File Offset: 0x00CE0F5B
		[NullableContext(1)]
		private RewardExploreAccumulatedScoreItem.ScoreItem CreateScoreItem()
		{
			return new RewardExploreAccumulatedScoreItem.ScoreItem();
		}

		// Token: 0x0602E341 RID: 189249 RVA: 0x00CE2D64 File Offset: 0x00CE0F64
		[NullableContext(1)]
		public void Refresh(AccumulatedScoreData data)
		{
			List<IAccumulatedScoreLineData> list = data.DetailScoreDataList;
			if (list != null)
			{
				GenericLayout<RewardExploreAccumulatedScoreItem.ScoreItem, IAccumulatedScoreLineData> detailScoreLayout = this.DetailScoreLayout;
				if (detailScoreLayout != null)
				{
					detailScoreLayout.RefreshByData(list, null, false);
				}
			}
			list = data.TotalScoreDataList;
			if (list != null)
			{
				GenericLayout<RewardExploreAccumulatedScoreItem.ScoreItem, IAccumulatedScoreLineData> totalScoreLayout = this.TotalScoreLayout;
				if (totalScoreLayout != null)
				{
					totalScoreLayout.RefreshByData(list, null, false);
				}
			}
			int curScore = data.CurScore;
			int maxScore = data.MaxScore;
			bool flag = curScore >= maxScore;
			if (!flag)
			{
				UUIText text = base.GetText(4);
				if (text != null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted<int>(curScore);
					defaultInterpolatedStringHandler.AppendLiteral("/");
					defaultInterpolatedStringHandler.AppendFormatted<int>(maxScore);
					text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				}
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "riskofrain_UIScore", new <>z__ReadOnlyArray<object>(new object[]
				{
					curScore,
					maxScore
				}));
			}
			base.GetItem(5).SetUIActive(flag);
		}

		// Token: 0x040189C5 RID: 100805
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RewardExploreAccumulatedScoreItem.ScoreItem, IAccumulatedScoreLineData> DetailScoreLayout;

		// Token: 0x040189C6 RID: 100806
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RewardExploreAccumulatedScoreItem.ScoreItem, IAccumulatedScoreLineData> TotalScoreLayout;

		// Token: 0x0200A401 RID: 41985
		private class EChildType
		{
			// Token: 0x04032D47 RID: 208199
			public const int DetailScoreLayout = 0;

			// Token: 0x04032D48 RID: 208200
			public const int DetailScoreTemplateItem = 1;

			// Token: 0x04032D49 RID: 208201
			public const int TotalScoreLayout = 2;

			// Token: 0x04032D4A RID: 208202
			public const int TotalScoreTemplateItem = 3;

			// Token: 0x04032D4B RID: 208203
			public const int LimitScoreText = 4;

			// Token: 0x04032D4C RID: 208204
			public const int ArriveMaxScoreItem = 5;
		}

		// Token: 0x0200A402 RID: 41986
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public class ScoreItem : GridProxyAbstract<IAccumulatedScoreLineData>
		{
			// Token: 0x06045C85 RID: 285829 RVA: 0x014FBE48 File Offset: 0x014FA048
			protected unsafe override void OnRegisterComponent()
			{
				int num = 2;
				List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
				CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
				Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
				int num2 = 0;
				*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
				this.ComponentRegisterInfos = list;
			}

			// Token: 0x06045C86 RID: 285830 RVA: 0x014FBEB1 File Offset: 0x014FA0B1
			[NullableContext(1)]
			public override void Refresh(IAccumulatedScoreLineData data, bool isSelected, int gridIndex)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.DescTextId, Array.Empty<object>());
				base.GetText(1).SetText(data.ScoreText, true);
			}

			// Token: 0x0200BD48 RID: 48456
			private class EScoreItemComponent
			{
				// Token: 0x0403A1DA RID: 238042
				public const int DescText = 0;

				// Token: 0x0403A1DB RID: 238043
				public const int ScoreText = 1;
			}
		}
	}
}
