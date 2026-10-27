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
	// Token: 0x02004B1C RID: 19228
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TowerDefenseRankItem : GridProxyAbstract<TowerDefenseRankItemData>
	{
		// Token: 0x06031CEA RID: 204010 RVA: 0x00B8FE89 File Offset: 0x00B8E089
		public TowerDefenseRankItem(bool isShowInBottom)
		{
			this.IsShowInBottom = isShowInBottom;
		}

		// Token: 0x06031CEB RID: 204011 RVA: 0x00B8FE98 File Offset: 0x00B8E098
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

		// Token: 0x06031CEC RID: 204012 RVA: 0x00B9003E File Offset: 0x00B8E23E
		protected override void OnStart()
		{
			this.InitOnlineNameLayout();
			this.InitRankGridLayout();
		}

		// Token: 0x06031CED RID: 204013 RVA: 0x00B9004C File Offset: 0x00B8E24C
		private void InitOnlineNameLayout()
		{
			this.OnlineNameLayout = new GenericLayout<OnlineItem, ITowerDefenseRankPlayerName>(base.GetLayoutBase(5), new Func<OnlineItem>(this.InitOnlineItem), base.GetItem(6).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x06031CEE RID: 204014 RVA: 0x00B9007F File Offset: 0x00B8E27F
		private void InitRankGridLayout()
		{
			this.RankGridLayout = new GenericLayout<RankGridItem, TowerDefenseRankRoleData>(base.GetLayoutBase(8), new Func<RankGridItem>(this.InitRankGridItem), base.GetItem(9).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x06031CEF RID: 204015 RVA: 0x00B900B3 File Offset: 0x00B8E2B3
		private OnlineItem InitOnlineItem()
		{
			return new OnlineItem(this.IsShowInBottom);
		}

		// Token: 0x06031CF0 RID: 204016 RVA: 0x00B900C0 File Offset: 0x00B8E2C0
		private RankGridItem InitRankGridItem()
		{
			return new RankGridItem();
		}

		// Token: 0x06031CF1 RID: 204017 RVA: 0x00B900C8 File Offset: 0x00B8E2C8
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

		// Token: 0x06031CF2 RID: 204018 RVA: 0x00B9017C File Offset: 0x00B8E37C
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

		// Token: 0x06031CF3 RID: 204019 RVA: 0x00B901E0 File Offset: 0x00B8E3E0
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

		// Token: 0x06031CF4 RID: 204020 RVA: 0x00B90298 File Offset: 0x00B8E498
		public UniTask RefreshPlayerName()
		{
			TowerDefenseRankItem.<RefreshPlayerName>d__16 <RefreshPlayerName>d__;
			<RefreshPlayerName>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshPlayerName>d__.<>4__this = this;
			<RefreshPlayerName>d__.<>1__state = -1;
			<RefreshPlayerName>d__.<>t__builder.Start<TowerDefenseRankItem.<RefreshPlayerName>d__16>(ref <RefreshPlayerName>d__);
			return <RefreshPlayerName>d__.<>t__builder.Task;
		}

		// Token: 0x06031CF5 RID: 204021 RVA: 0x00B902DC File Offset: 0x00B8E4DC
		private void RefreshTimeScore()
		{
			base.GetText(7).SetUIActive(true);
			string newText = this.RankItemData.IsDifficult ? TimeUtil.Instance.GetTimeDataFormat((double)this.RankItemData.PassScore) : this.RankItemData.PassScore.ToString();
			base.GetText(7).SetText(newText, true);
		}

		// Token: 0x06031CF6 RID: 204022 RVA: 0x00B90340 File Offset: 0x00B8E540
		private UniTask RefreshRankGrid()
		{
			TowerDefenseRankItem.<RefreshRankGrid>d__18 <RefreshRankGrid>d__;
			<RefreshRankGrid>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRankGrid>d__.<>4__this = this;
			<RefreshRankGrid>d__.<>1__state = -1;
			<RefreshRankGrid>d__.<>t__builder.Start<TowerDefenseRankItem.<RefreshRankGrid>d__18>(ref <RefreshRankGrid>d__);
			return <RefreshRankGrid>d__.<>t__builder.Task;
		}

		// Token: 0x06031CF7 RID: 204023 RVA: 0x00B90383 File Offset: 0x00B8E583
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

		// Token: 0x06031CF8 RID: 204024 RVA: 0x00B903BB File Offset: 0x00B8E5BB
		public bool IsSelfItem()
		{
			return this.RankItemData.IsSelfInData;
		}

		// Token: 0x0401A947 RID: 108871
		protected TowerDefenseRankViewModel ParentModel;

		// Token: 0x0401A948 RID: 108872
		private readonly bool IsShowInBottom;

		// Token: 0x0401A949 RID: 108873
		private GenericLayout<OnlineItem, ITowerDefenseRankPlayerName> OnlineNameLayout;

		// Token: 0x0401A94A RID: 108874
		private GenericLayout<RankGridItem, TowerDefenseRankRoleData> RankGridLayout;

		// Token: 0x0401A94B RID: 108875
		private TowerDefenseRankItemData RankItemData;

		// Token: 0x0200ACA0 RID: 44192
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04034735 RID: 214837
			public const int RankBg = 0;

			// Token: 0x04034736 RID: 214838
			public const int RankTopThreeNum = 1;

			// Token: 0x04034737 RID: 214839
			public const int RankOtherNum = 2;

			// Token: 0x04034738 RID: 214840
			public const int RankNoneItem = 3;

			// Token: 0x04034739 RID: 214841
			public const int Name = 4;

			// Token: 0x0403473A RID: 214842
			public const int OnlineNameLayout = 5;

			// Token: 0x0403473B RID: 214843
			public const int OnlineNameItem = 6;

			// Token: 0x0403473C RID: 214844
			public const int TimeScore = 7;

			// Token: 0x0403473D RID: 214845
			public const int RankGridLayout = 8;

			// Token: 0x0403473E RID: 214846
			public const int RankGridItem = 9;

			// Token: 0x0403473F RID: 214847
			public const int RankGridEmptyItem = 10;
		}
	}
}
