using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AC4 RID: 15044
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TowerDefenseRankItem : GridProxyAbstract<TowerDefenseRankItemData>
	{
		// Token: 0x06026A7A RID: 158330 RVA: 0x00AD3EED File Offset: 0x00AD20ED
		public TowerDefenseRankItem(bool isShowInBottom)
		{
			this.IsShowInBottom = isShowInBottom;
		}

		// Token: 0x06026A7B RID: 158331 RVA: 0x00AD3EFC File Offset: 0x00AD20FC
		protected unsafe override void OnRegisterComponent()
		{
			this.ParentModel = (this.OpenParam as TowerDefenseRankViewModel);
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06026A7C RID: 158332 RVA: 0x00AD40A2 File Offset: 0x00AD22A2
		protected override void OnStart()
		{
			this.InitOnlineNameLayout();
			this.InitRankGridLayout();
		}

		// Token: 0x06026A7D RID: 158333 RVA: 0x00AD40B0 File Offset: 0x00AD22B0
		private void InitOnlineNameLayout()
		{
			this.OnlineNameLayout = new GenericLayout<OnlineItem, ITowerDefenseRankPlayerName>(base.GetLayoutBase(5), new Func<OnlineItem>(this.InitOnlineItem), base.GetItem(6).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x06026A7E RID: 158334 RVA: 0x00AD40E3 File Offset: 0x00AD22E3
		private void InitRankGridLayout()
		{
			this.RankGridLayout = new GenericLayout<RankGridItem, TowerDefenseRankRoleData>(base.GetLayoutBase(8), new Func<RankGridItem>(this.InitRankGridItem), base.GetItem(9).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x06026A7F RID: 158335 RVA: 0x00AD4117 File Offset: 0x00AD2317
		private OnlineItem InitOnlineItem()
		{
			return new OnlineItem(this.IsShowInBottom);
		}

		// Token: 0x06026A80 RID: 158336 RVA: 0x00AD4124 File Offset: 0x00AD2324
		private RankGridItem InitRankGridItem()
		{
			return new RankGridItem();
		}

		// Token: 0x06026A81 RID: 158337 RVA: 0x00AD412C File Offset: 0x00AD232C
		private void RefreshEmpty()
		{
			base.GetText(1).SetUIActive(false);
			base.GetText(2).SetUIActive(false);
			base.GetItem(3).SetUIActive(true);
			UUIItem rootUiItem = this.OnlineNameLayout.GetRootUiItem();
			if (rootUiItem != null)
			{
				rootUiItem.SetUIActive(false);
			}
			string newText = PlayerInfoModel.Instance.GetAccountName(true) ?? string.Empty;
			base.GetText(4).SetText(newText, true);
			base.GetText(4).SetUIActive(true);
			base.GetText(7).SetUIActive(false);
			UUIItem rootUiItem2 = this.RankGridLayout.GetRootUiItem();
			if (rootUiItem2 != null)
			{
				rootUiItem2.SetUIActive(false);
			}
			base.GetItem(10).SetUIActive(true);
			this.RefreshRankBg();
		}

		// Token: 0x06026A82 RID: 158338 RVA: 0x00AD41E0 File Offset: 0x00AD23E0
		private void RefreshRankBg()
		{
			bool flag = !this.IsShowInBottom || this.RankItemData.IsTopThree;
			base.GetTexture(0).SetUIActive(flag);
			if (flag)
			{
				string rankBg = this.RankItemData.RankBg;
				string resourcePath = UiResourceConfig.Instance.GetResourcePath(rankBg);
				base.SetTextureByPath(resourcePath, base.GetTexture(0), null, null);
			}
		}

		// Token: 0x06026A83 RID: 158339 RVA: 0x00AD4244 File Offset: 0x00AD2444
		private void RefreshRankNum()
		{
			bool isTopThree = this.RankItemData.IsTopThree;
			UUIText text = base.GetText(1);
			UUIText text2 = base.GetText(2);
			text.SetUIActive(isTopThree);
			text2.SetUIActive(!isTopThree && this.RankItemData.IsInRank);
			base.GetItem(3).SetUIActive(!this.RankItemData.IsInRank);
			if (isTopThree)
			{
				text.SetText(this.RankItemData.Rank.ToString(), true);
				text.outlineColor = FColor.FromHex(this.RankItemData.TopThreeNumColor);
				return;
			}
			if (this.RankItemData.IsInRank)
			{
				text2.SetText(this.RankItemData.Rank.ToString(), true);
			}
		}

		// Token: 0x06026A84 RID: 158340 RVA: 0x00AD42FC File Offset: 0x00AD24FC
		public UniTask RefreshPlayerName()
		{
			TowerDefenseRankItem.<RefreshPlayerName>d__16 <RefreshPlayerName>d__;
			<RefreshPlayerName>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshPlayerName>d__.<>4__this = this;
			<RefreshPlayerName>d__.<>1__state = -1;
			<RefreshPlayerName>d__.<>t__builder.Start<TowerDefenseRankItem.<RefreshPlayerName>d__16>(ref <RefreshPlayerName>d__);
			return <RefreshPlayerName>d__.<>t__builder.Task;
		}

		// Token: 0x06026A85 RID: 158341 RVA: 0x00AD4340 File Offset: 0x00AD2540
		private void RefreshTimeScore()
		{
			base.GetText(7).SetUIActive(true);
			string newText = this.RankItemData.IsDifficult ? TimeUtil.Instance.GetTimeDataFormat((double)this.RankItemData.PassScore) : this.RankItemData.PassScore.ToString();
			base.GetText(7).SetText(newText, true);
		}

		// Token: 0x06026A86 RID: 158342 RVA: 0x00AD43A4 File Offset: 0x00AD25A4
		private UniTask RefreshRankGrid()
		{
			TowerDefenseRankItem.<RefreshRankGrid>d__18 <RefreshRankGrid>d__;
			<RefreshRankGrid>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRankGrid>d__.<>4__this = this;
			<RefreshRankGrid>d__.<>1__state = -1;
			<RefreshRankGrid>d__.<>t__builder.Start<TowerDefenseRankItem.<RefreshRankGrid>d__18>(ref <RefreshRankGrid>d__);
			return <RefreshRankGrid>d__.<>t__builder.Task;
		}

		// Token: 0x06026A87 RID: 158343 RVA: 0x00AD43E7 File Offset: 0x00AD25E7
		public override void Refresh(TowerDefenseRankItemData data, bool isSelected, int gridIndex)
		{
			this.RankItemData = data;
			if (data.IsEmpty)
			{
				this.RefreshEmpty();
				return;
			}
			this.RefreshRankBg();
			this.RefreshRankNum();
			this.RefreshPlayerName();
			this.RefreshTimeScore();
			this.RefreshRankGrid();
		}

		// Token: 0x06026A88 RID: 158344 RVA: 0x00AD441F File Offset: 0x00AD261F
		public bool IsSelfItem()
		{
			return this.RankItemData.IsSelfInData;
		}

		// Token: 0x04015299 RID: 86681
		protected TowerDefenseRankViewModel ParentModel;

		// Token: 0x0401529A RID: 86682
		private readonly bool IsShowInBottom;

		// Token: 0x0401529B RID: 86683
		private GenericLayout<OnlineItem, ITowerDefenseRankPlayerName> OnlineNameLayout;

		// Token: 0x0401529C RID: 86684
		private GenericLayout<RankGridItem, TowerDefenseRankRoleData> RankGridLayout;

		// Token: 0x0401529D RID: 86685
		private TowerDefenseRankItemData RankItemData;

		// Token: 0x020096C0 RID: 38592
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0402F0E6 RID: 192742
			public const int RankBg = 0;

			// Token: 0x0402F0E7 RID: 192743
			public const int RankTopThreeNum = 1;

			// Token: 0x0402F0E8 RID: 192744
			public const int RankOtherNum = 2;

			// Token: 0x0402F0E9 RID: 192745
			public const int RankNoneItem = 3;

			// Token: 0x0402F0EA RID: 192746
			public const int Name = 4;

			// Token: 0x0402F0EB RID: 192747
			public const int OnlineNameLayout = 5;

			// Token: 0x0402F0EC RID: 192748
			public const int OnlineNameItem = 6;

			// Token: 0x0402F0ED RID: 192749
			public const int TimeScore = 7;

			// Token: 0x0402F0EE RID: 192750
			public const int RankGridLayout = 8;

			// Token: 0x0402F0EF RID: 192751
			public const int RankGridItem = 9;

			// Token: 0x0402F0F0 RID: 192752
			public const int RankGridEmptyItem = 10;
		}
	}
}
