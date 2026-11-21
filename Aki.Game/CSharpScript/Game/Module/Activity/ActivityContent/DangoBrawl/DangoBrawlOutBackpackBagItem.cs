using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005776 RID: 22390
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlOutBackpackBagItem : DangoBrawlOutBackpackItemBase
	{
		// Token: 0x17006A83 RID: 27267
		// (get) Token: 0x060373DE RID: 226270 RVA: 0x00F6C6BA File Offset: 0x00F6A8BA
		private UUITexture SprIconMask02
		{
			get
			{
				return base.GetTexture(18);
			}
		}

		// Token: 0x17006A84 RID: 27268
		// (get) Token: 0x060373DF RID: 226271 RVA: 0x00F6C6C4 File Offset: 0x00F6A8C4
		private UUITexture SprIconMask03
		{
			get
			{
				return base.GetTexture(24);
			}
		}

		// Token: 0x17006A85 RID: 27269
		// (get) Token: 0x060373E0 RID: 226272 RVA: 0x00F6C6CE File Offset: 0x00F6A8CE
		private UUIItem UniqueWeaponItem
		{
			get
			{
				return base.GetItem(17);
			}
		}

		// Token: 0x060373E1 RID: 226273 RVA: 0x00F6C6D8 File Offset: 0x00F6A8D8
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(9, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(10, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(11, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(12, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(13, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(17, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(18, typeof(UUITexture)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(24, typeof(UUITexture)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(21, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(22, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(26, typeof(UUINiagara)));
		}

		// Token: 0x060373E2 RID: 226274 RVA: 0x00F6C81F File Offset: 0x00F6AA1F
		[NullableContext(1)]
		protected override void CollectIconTextures(List<UUITexture> textures)
		{
			base.CollectIconTextures(textures);
			if (this.SprIconMask02 != null)
			{
				textures.Add(this.SprIconMask02);
			}
			if (this.SprIconMask03 != null)
			{
				textures.Add(this.SprIconMask03);
			}
		}

		// Token: 0x060373E3 RID: 226275 RVA: 0x00F6C850 File Offset: 0x00F6AA50
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlOutBackpackBagItem.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlOutBackpackBagItem.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060373E4 RID: 226276 RVA: 0x00F6C893 File Offset: 0x00F6AA93
		public override void RefreshView()
		{
			base.RefreshView();
			this.RefreshCost();
			this.RefreshUniqueWeapon();
			this.SetSelected(false);
		}

		// Token: 0x060373E5 RID: 226277 RVA: 0x00F6C8AE File Offset: 0x00F6AAAE
		public override void ResetOnInit()
		{
			this.SetStarsContentActive(false);
			this.SetBlurContentActive(false);
			this.HideWeaponQualityFx();
			base.ResetOnInit();
		}

		// Token: 0x060373E6 RID: 226278 RVA: 0x00F6C8CA File Offset: 0x00F6AACA
		public override void SetSelected(bool selected)
		{
			this.SetSelected(selected, null);
		}

		// Token: 0x060373E7 RID: 226279 RVA: 0x00F6C8D4 File Offset: 0x00F6AAD4
		public void SetSelected(bool selected, [Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<DangoBrawlOutBackpackItemData> fillStarByLayout)
		{
			if (!this.CanSelect)
			{
				return;
			}
			base.SetSelected(selected);
			if (!selected)
			{
				this.ShowStarsDisplay(false, true);
				return;
			}
			if (fillStarByLayout != null)
			{
				this.ShowStarsDisplayWithFill(fillStarByLayout);
				return;
			}
			this.ShowStarsDisplay(true, true);
		}

		// Token: 0x060373E8 RID: 226280 RVA: 0x00F6C908 File Offset: 0x00F6AB08
		private UniTask CreateCostItem()
		{
			DangoBrawlOutBackpackBagItem.<CreateCostItem>d__17 <CreateCostItem>d__;
			<CreateCostItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCostItem>d__.<>4__this = this;
			<CreateCostItem>d__.<>1__state = -1;
			<CreateCostItem>d__.<>t__builder.Start<DangoBrawlOutBackpackBagItem.<CreateCostItem>d__17>(ref <CreateCostItem>d__);
			return <CreateCostItem>d__.<>t__builder.Task;
		}

		// Token: 0x060373E9 RID: 226281 RVA: 0x00F6C94C File Offset: 0x00F6AB4C
		private void RefreshCost()
		{
			if (this.CostItem == null || base.MyItemData == null || base.MyItemData.MyConfigId <= 0)
			{
				return;
			}
			DangoBrawlItem? dangoBrawlItemById = DangoBrawlConfig.Instance.GetDangoBrawlItemById(base.MyItemData.MyConfigId);
			if (dangoBrawlItemById == null)
			{
				return;
			}
			int cost = dangoBrawlItemById.Value.Cost;
			this.CostItem.SetUiActive(cost > 0);
			this.CostItem.SetCostNum(cost);
		}

		// Token: 0x060373EA RID: 226282 RVA: 0x00F6C9C4 File Offset: 0x00F6ABC4
		private void RefreshUniqueWeapon()
		{
			if (this.UniqueWeaponItem == null || base.MyItemData == null || base.MyItemData.MyConfigId <= 0)
			{
				return;
			}
			DangoBrawlItem? dangoBrawlItemById = DangoBrawlConfig.Instance.GetDangoBrawlItemById(base.MyItemData.MyConfigId);
			if (dangoBrawlItemById == null)
			{
				return;
			}
			this.UniqueWeaponItem.SetUIActive(dangoBrawlItemById.Value.IsSpeItem);
		}

		// Token: 0x060373EB RID: 226283 RVA: 0x00F6CA2A File Offset: 0x00F6AC2A
		public void SetStarsContentActive(bool val)
		{
			UUIItem item = base.GetItem(9);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(val);
		}

		// Token: 0x060373EC RID: 226284 RVA: 0x00F6CA40 File Offset: 0x00F6AC40
		public void ShowStarsDisplay(bool isShow, bool showIcon = true)
		{
			UUIItem item = base.GetItem(10);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			if (isShow)
			{
				DangoBrawlOutBackpackItemData myItemData = base.MyItemData;
				if (((myItemData != null) ? myItemData.StarPanelPosList.Length : 0) > 0)
				{
					this.SetStarsContentActive(true);
					this.ShowStarsDisplayAsync(showIcon).Forget();
					return;
				}
			}
			this.SetStarsContentActive(false);
		}

		// Token: 0x060373ED RID: 226285 RVA: 0x00F6CA98 File Offset: 0x00F6AC98
		[NullableContext(1)]
		public void ShowStarsDisplayWithFill(IReadOnlyList<DangoBrawlOutBackpackItemData> allItems)
		{
			UUIItem item = base.GetItem(10);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			DangoBrawlOutBackpackItemData myItemData = base.MyItemData;
			if (((myItemData != null) ? myItemData.StarPanelPosList.Length : 0) <= 0)
			{
				this.SetStarsContentActive(false);
				return;
			}
			this.SetStarsContentActive(true);
			this.ShowStarsDisplayWithFillAsync(allItems).Forget();
		}

		// Token: 0x060373EE RID: 226286 RVA: 0x00F6CAEC File Offset: 0x00F6ACEC
		private UniTask ShowStarsDisplayAsync(bool showIcon)
		{
			DangoBrawlOutBackpackBagItem.<ShowStarsDisplayAsync>d__23 <ShowStarsDisplayAsync>d__;
			<ShowStarsDisplayAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowStarsDisplayAsync>d__.<>4__this = this;
			<ShowStarsDisplayAsync>d__.showIcon = showIcon;
			<ShowStarsDisplayAsync>d__.<>1__state = -1;
			<ShowStarsDisplayAsync>d__.<>t__builder.Start<DangoBrawlOutBackpackBagItem.<ShowStarsDisplayAsync>d__23>(ref <ShowStarsDisplayAsync>d__);
			return <ShowStarsDisplayAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060373EF RID: 226287 RVA: 0x00F6CB38 File Offset: 0x00F6AD38
		[NullableContext(1)]
		private UniTask ShowStarsDisplayWithFillAsync(IReadOnlyList<DangoBrawlOutBackpackItemData> allItems)
		{
			DangoBrawlOutBackpackBagItem.<ShowStarsDisplayWithFillAsync>d__24 <ShowStarsDisplayWithFillAsync>d__;
			<ShowStarsDisplayWithFillAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowStarsDisplayWithFillAsync>d__.<>4__this = this;
			<ShowStarsDisplayWithFillAsync>d__.allItems = allItems;
			<ShowStarsDisplayWithFillAsync>d__.<>1__state = -1;
			<ShowStarsDisplayWithFillAsync>d__.<>t__builder.Start<DangoBrawlOutBackpackBagItem.<ShowStarsDisplayWithFillAsync>d__24>(ref <ShowStarsDisplayWithFillAsync>d__);
			return <ShowStarsDisplayWithFillAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060373F0 RID: 226288 RVA: 0x00F6CB84 File Offset: 0x00F6AD84
		private UniTask EnsureStarPanelsAsync()
		{
			DangoBrawlOutBackpackBagItem.<EnsureStarPanelsAsync>d__25 <EnsureStarPanelsAsync>d__;
			<EnsureStarPanelsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EnsureStarPanelsAsync>d__.<>4__this = this;
			<EnsureStarPanelsAsync>d__.<>1__state = -1;
			<EnsureStarPanelsAsync>d__.<>t__builder.Start<DangoBrawlOutBackpackBagItem.<EnsureStarPanelsAsync>d__25>(ref <EnsureStarPanelsAsync>d__);
			return <EnsureStarPanelsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060373F1 RID: 226289 RVA: 0x00F6CBC8 File Offset: 0x00F6ADC8
		private UniTask CreateStarPanels(int count)
		{
			DangoBrawlOutBackpackBagItem.<CreateStarPanels>d__26 <CreateStarPanels>d__;
			<CreateStarPanels>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateStarPanels>d__.<>4__this = this;
			<CreateStarPanels>d__.count = count;
			<CreateStarPanels>d__.<>1__state = -1;
			<CreateStarPanels>d__.<>t__builder.Start<DangoBrawlOutBackpackBagItem.<CreateStarPanels>d__26>(ref <CreateStarPanels>d__);
			return <CreateStarPanels>d__.<>t__builder.Task;
		}

		// Token: 0x060373F2 RID: 226290 RVA: 0x00F6CC14 File Offset: 0x00F6AE14
		[NullableContext(1)]
		private List<PanelPos> RefreshStars(bool showIcon = true)
		{
			if (base.MyItemData == null)
			{
				return new List<PanelPos>();
			}
			PanelPos[] starPanelPosList = base.MyItemData.StarPanelPosList;
			PanelPos leftTopPos = base.MyItemData.LeftTopPos;
			List<PanelPos> list = new List<PanelPos>(starPanelPosList.Length);
			foreach (PanelPos panelPos in starPanelPosList)
			{
				list.Add(new PanelPos(leftTopPos.RowIndex + panelPos.RowIndex, leftTopPos.ColIndex + panelPos.ColIndex));
			}
			list.Sort(delegate(PanelPos a, PanelPos b)
			{
				if (a.RowIndex == b.RowIndex)
				{
					return a.ColIndex - b.ColIndex;
				}
				return a.RowIndex - b.RowIndex;
			});
			for (int j = 0; j < this.StarPanels.Count; j++)
			{
				DangoBrawlGeneralStar dangoBrawlGeneralStar = this.StarPanels[j];
				if (j >= list.Count)
				{
					UUIItem rootItem = dangoBrawlGeneralStar.GetRootItem();
					if (rootItem != null)
					{
						rootItem.SetUIActive(false);
					}
					dangoBrawlGeneralStar.SetStarVisible(false);
				}
				else
				{
					PanelPos panelPos2 = list[j];
					UUIItem rootItem2 = dangoBrawlGeneralStar.GetRootItem();
					if (rootItem2 != null)
					{
						rootItem2.SetUIActive(true);
					}
					dangoBrawlGeneralStar.SetStarVisible(showIcon);
					dangoBrawlGeneralStar.SetUiRelativeLocation(new FVector2D((float)(panelPos2.ColIndex - leftTopPos.ColIndex) * this.OutGridSize, (float)(-(float)(panelPos2.RowIndex - leftTopPos.RowIndex)) * this.OutGridSize));
				}
			}
			return list;
		}

		// Token: 0x060373F3 RID: 226291 RVA: 0x00F6CD68 File Offset: 0x00F6AF68
		public void SetBlurContentActive(bool val)
		{
			UUIItem item = base.GetItem(12);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(val);
		}

		// Token: 0x060373F4 RID: 226292 RVA: 0x00F6CD7D File Offset: 0x00F6AF7D
		public void ShowBlurGridsDisplay(bool isShow)
		{
			this.SetBlurContentActive(isShow);
			if (isShow)
			{
				this.EnsureBlurGrids();
				this.RefreshBlurGrids();
			}
		}

		// Token: 0x060373F5 RID: 226293 RVA: 0x00F6CD98 File Offset: 0x00F6AF98
		private void EnsureBlurGrids()
		{
			DangoBrawlOutBackpackItemData myItemData = base.MyItemData;
			int num = (myItemData != null) ? myItemData.PanelPosList.Length : 0;
			UUIItem item = base.GetItem(13);
			UUIItem item2 = base.GetItem(12);
			if (item == null || item2 == null || num <= 0)
			{
				return;
			}
			item.SetUIActive(false);
			while (this.BlurGridPool.Count < num)
			{
				UUIItem uuiitem = LguiUtil.Instance.CopyItem(item, item2);
				if (uuiitem == null)
				{
					break;
				}
				uuiitem.SetUIActive(false);
				this.BlurGridPool.Add(uuiitem);
			}
		}

		// Token: 0x060373F6 RID: 226294 RVA: 0x00F6CE14 File Offset: 0x00F6B014
		private void RefreshBlurGrids()
		{
			if (base.MyItemData == null)
			{
				return;
			}
			PanelPos[] panelPosList = base.MyItemData.PanelPosList;
			for (int i = 0; i < this.BlurGridPool.Count; i++)
			{
				bool flag = i < panelPosList.Length;
				this.BlurGridPool[i].SetUIActive(flag);
				if (flag)
				{
					PanelPos panelPos = panelPosList[i];
					this.BlurGridPool[i].SetUIRelativeLocation(new FVector((float)panelPos.ColIndex * this.OutGridSize, (float)(-(float)panelPos.RowIndex) * this.OutGridSize, 0f));
				}
			}
		}

		// Token: 0x060373F7 RID: 226295 RVA: 0x00F6CEA8 File Offset: 0x00F6B0A8
		public void RefreshWeaponQualityFx()
		{
			this.RefreshQualityFx(base.GetItem(21), base.GetItem(22), base.GetUiNiagara(26));
		}

		// Token: 0x060373F8 RID: 226296 RVA: 0x00F6CEC8 File Offset: 0x00F6B0C8
		private void HideWeaponQualityFx()
		{
			UUIItem item = base.GetItem(21);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(22);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUINiagara uiNiagara = base.GetUiNiagara(26);
			if (uiNiagara == null)
			{
				return;
			}
			uiNiagara.SetUIActive(false);
		}

		// Token: 0x0401D300 RID: 119552
		[Nullable(1)]
		private readonly List<DangoBrawlGeneralStar> StarPanels = new List<DangoBrawlGeneralStar>();

		// Token: 0x0401D301 RID: 119553
		[Nullable(1)]
		private readonly List<UUIItem> BlurGridPool = new List<UUIItem>();

		// Token: 0x0401D302 RID: 119554
		private DangoBrawlOutBackpackCostItem CostItem;

		// Token: 0x0200B393 RID: 45971
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403783F RID: 227391
			ContentStar = 9,
			// Token: 0x04037840 RID: 227392
			ItemStar,
			// Token: 0x04037841 RID: 227393
			CostNumItem,
			// Token: 0x04037842 RID: 227394
			ContentBlurGrid,
			// Token: 0x04037843 RID: 227395
			TemplateBlurGrid,
			// Token: 0x04037844 RID: 227396
			UniqueWeaponItem = 17,
			// Token: 0x04037845 RID: 227397
			SprIconMask02,
			// Token: 0x04037846 RID: 227398
			FxNiagaraType1 = 21,
			// Token: 0x04037847 RID: 227399
			FxNiagaraType2,
			// Token: 0x04037848 RID: 227400
			SprIconMask03 = 24,
			// Token: 0x04037849 RID: 227401
			NiagaraQualityFx = 26
		}
	}
}
