using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SlidingBlocks.View
{
	// Token: 0x02003B39 RID: 15161
	[NullableContext(1)]
	[Nullable(0)]
	public class CubeResultItem : UiPanelBase
	{
		// Token: 0x06026F97 RID: 159639 RVA: 0x00AE90D5 File Offset: 0x00AE72D5
		public CubeResultItem(int score, bool isNewRecord, List<TItem> rewardList)
		{
			this.Score = score;
			this.IsNewRecord = isNewRecord;
			this.RewardList = rewardList;
		}

		// Token: 0x06026F98 RID: 159640 RVA: 0x00AE9100 File Offset: 0x00AE7300
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06026F99 RID: 159641 RVA: 0x00AE9254 File Offset: 0x00AE7454
		protected override UniTask OnBeforeStartAsync()
		{
			CubeResultItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CubeResultItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026F9A RID: 159642 RVA: 0x00AE9298 File Offset: 0x00AE7498
		private UniTask InitRewardItem(ETetrisPlayMode playMode)
		{
			CubeResultItem.<InitRewardItem>d__10 <InitRewardItem>d__;
			<InitRewardItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRewardItem>d__.<>4__this = this;
			<InitRewardItem>d__.playMode = playMode;
			<InitRewardItem>d__.<>1__state = -1;
			<InitRewardItem>d__.<>t__builder.Start<CubeResultItem.<InitRewardItem>d__10>(ref <InitRewardItem>d__);
			return <InitRewardItem>d__.<>t__builder.Task;
		}

		// Token: 0x06026F9B RID: 159643 RVA: 0x00AE92E3 File Offset: 0x00AE74E3
		private CommonItemSmallItemGrid InitGridItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x06026F9C RID: 159644 RVA: 0x00AE92EC File Offset: 0x00AE74EC
		private UniTask InitTargetItem()
		{
			CubeResultItem.<InitTargetItem>d__12 <InitTargetItem>d__;
			<InitTargetItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTargetItem>d__.<>4__this = this;
			<InitTargetItem>d__.<>1__state = -1;
			<InitTargetItem>d__.<>t__builder.Start<CubeResultItem.<InitTargetItem>d__12>(ref <InitTargetItem>d__);
			return <InitTargetItem>d__.<>t__builder.Task;
		}

		// Token: 0x06026F9D RID: 159645 RVA: 0x00AE9330 File Offset: 0x00AE7530
		protected override UniTask OnShowAsyncImplementImplement()
		{
			CubeResultItem.<OnShowAsyncImplementImplement>d__13 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<CubeResultItem.<OnShowAsyncImplementImplement>d__13>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06026F9E RID: 159646 RVA: 0x00AE9373 File Offset: 0x00AE7573
		protected override void OnAfterShow()
		{
			if (SlidingBlocksModel.Instance.GameData.PlayMode == ETetrisPlayMode.Endless)
			{
				UUIText text = base.GetText(1);
				if (text == null)
				{
					return;
				}
				UUIItem parentAsUIItem = text.GetParentAsUIItem();
				if (parentAsUIItem == null)
				{
					return;
				}
				parentAsUIItem.SetUIActive(this.IsNewRecord);
			}
		}

		// Token: 0x04015498 RID: 87192
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

		// Token: 0x04015499 RID: 87193
		private readonly List<SettlementTargetItem> TargetItems = new List<SettlementTargetItem>();

		// Token: 0x0401549A RID: 87194
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401549B RID: 87195
		public readonly int Score;

		// Token: 0x0401549C RID: 87196
		public readonly bool IsNewRecord;

		// Token: 0x0401549D RID: 87197
		public readonly List<TItem> RewardList;

		// Token: 0x020097B2 RID: 38834
		[NullableContext(0)]
		private enum EViewComponent
		{
			// Token: 0x0402F522 RID: 193826
			ScoreText,
			// Token: 0x0402F523 RID: 193827
			NewRecordText,
			// Token: 0x0402F524 RID: 193828
			TargetItemNode,
			// Token: 0x0402F525 RID: 193829
			TargetItem,
			// Token: 0x0402F526 RID: 193830
			RewardItemNode,
			// Token: 0x0402F527 RID: 193831
			RewardItem,
			// Token: 0x0402F528 RID: 193832
			PanelTop,
			// Token: 0x0402F529 RID: 193833
			PanelNone,
			// Token: 0x0402F52A RID: 193834
			PanelBg
		}
	}
}
