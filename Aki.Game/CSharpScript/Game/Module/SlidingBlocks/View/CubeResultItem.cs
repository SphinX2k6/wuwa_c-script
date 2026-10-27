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
	// Token: 0x02004B8F RID: 19343
	[NullableContext(1)]
	[Nullable(0)]
	public class CubeResultItem : UiPanelBase
	{
		// Token: 0x06032207 RID: 205319 RVA: 0x00BA4F89 File Offset: 0x00BA3189
		public CubeResultItem(int score, bool isNewRecord, List<TItem> rewardList)
		{
			this.Score = score;
			this.IsNewRecord = isNewRecord;
			this.RewardList = rewardList;
		}

		// Token: 0x06032208 RID: 205320 RVA: 0x00BA4FB4 File Offset: 0x00BA31B4
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

		// Token: 0x06032209 RID: 205321 RVA: 0x00BA5108 File Offset: 0x00BA3308
		protected override UniTask OnBeforeStartAsync()
		{
			CubeResultItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CubeResultItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603220A RID: 205322 RVA: 0x00BA514C File Offset: 0x00BA334C
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

		// Token: 0x0603220B RID: 205323 RVA: 0x00BA5197 File Offset: 0x00BA3397
		private CommonItemSmallItemGrid InitGridItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x0603220C RID: 205324 RVA: 0x00BA51A0 File Offset: 0x00BA33A0
		private UniTask InitTargetItem()
		{
			CubeResultItem.<InitTargetItem>d__12 <InitTargetItem>d__;
			<InitTargetItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTargetItem>d__.<>4__this = this;
			<InitTargetItem>d__.<>1__state = -1;
			<InitTargetItem>d__.<>t__builder.Start<CubeResultItem.<InitTargetItem>d__12>(ref <InitTargetItem>d__);
			return <InitTargetItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603220D RID: 205325 RVA: 0x00BA51E4 File Offset: 0x00BA33E4
		protected override UniTask OnShowAsyncImplementImplement()
		{
			CubeResultItem.<OnShowAsyncImplementImplement>d__13 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<CubeResultItem.<OnShowAsyncImplementImplement>d__13>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603220E RID: 205326 RVA: 0x00BA5227 File Offset: 0x00BA3427
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

		// Token: 0x0401AB44 RID: 109380
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

		// Token: 0x0401AB45 RID: 109381
		private readonly List<SettlementTargetItem> TargetItems = new List<SettlementTargetItem>();

		// Token: 0x0401AB46 RID: 109382
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401AB47 RID: 109383
		public readonly int Score;

		// Token: 0x0401AB48 RID: 109384
		public readonly bool IsNewRecord;

		// Token: 0x0401AB49 RID: 109385
		public readonly List<TItem> RewardList;

		// Token: 0x0200AD93 RID: 44435
		[NullableContext(0)]
		private enum EViewComponent
		{
			// Token: 0x04034B7B RID: 215931
			ScoreText,
			// Token: 0x04034B7C RID: 215932
			NewRecordText,
			// Token: 0x04034B7D RID: 215933
			TargetItemNode,
			// Token: 0x04034B7E RID: 215934
			TargetItem,
			// Token: 0x04034B7F RID: 215935
			RewardItemNode,
			// Token: 0x04034B80 RID: 215936
			RewardItem,
			// Token: 0x04034B81 RID: 215937
			PanelTop,
			// Token: 0x04034B82 RID: 215938
			PanelNone,
			// Token: 0x04034B83 RID: 215939
			PanelBg
		}
	}
}
