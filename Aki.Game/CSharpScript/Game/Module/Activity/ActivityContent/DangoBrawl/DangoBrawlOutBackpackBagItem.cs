using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006826 RID: 26662
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlOutBackpackBagItem : DangoBrawlOutBackpackItemBase
	{
		// Token: 0x17009742 RID: 38722
		// (get) Token: 0x0604288A RID: 272522 RVA: 0x0102B17E File Offset: 0x0102937E
		private UUITexture SprIconMask02
		{
			get
			{
				return base.GetTexture(18);
			}
		}

		// Token: 0x17009743 RID: 38723
		// (get) Token: 0x0604288B RID: 272523 RVA: 0x0102B188 File Offset: 0x01029388
		private UUITexture SprIconMask03
		{
			get
			{
				return base.GetTexture(24);
			}
		}

		// Token: 0x17009744 RID: 38724
		// (get) Token: 0x0604288C RID: 272524 RVA: 0x0102B192 File Offset: 0x01029392
		private UUIItem UniqueWeaponItem
		{
			get
			{
				return base.GetItem(17);
			}
		}

		// Token: 0x0604288D RID: 272525 RVA: 0x0102B19C File Offset: 0x0102939C
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

		// Token: 0x0604288E RID: 272526 RVA: 0x0102B2E3 File Offset: 0x010294E3
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

		// Token: 0x0604288F RID: 272527 RVA: 0x0102B314 File Offset: 0x01029514
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlOutBackpackBagItem.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlOutBackpackBagItem.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042890 RID: 272528 RVA: 0x0102B357 File Offset: 0x01029557
		public override void RefreshView()
		{
			base.RefreshView();
			this.RefreshCost();
			this.RefreshUniqueWeapon();
			this.SetSelected(false);
		}

		// Token: 0x06042891 RID: 272529 RVA: 0x0102B372 File Offset: 0x01029572
		public override void ResetOnInit()
		{
			this.SetStarsContentActive(false);
			this.SetBlurContentActive(false);
			this.HideWeaponQualityFx();
			base.ResetOnInit();
		}

		// Token: 0x06042892 RID: 272530 RVA: 0x0102B38E File Offset: 0x0102958E
		public override void SetSelected(bool selected)
		{
			this.SetSelected(selected, null);
		}

		// Token: 0x06042893 RID: 272531 RVA: 0x0102B398 File Offset: 0x01029598
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

		// Token: 0x06042894 RID: 272532 RVA: 0x0102B3CC File Offset: 0x010295CC
		private UniTask CreateCostItem()
		{
			DangoBrawlOutBackpackBagItem.<CreateCostItem>d__17 <CreateCostItem>d__;
			<CreateCostItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCostItem>d__.<>4__this = this;
			<CreateCostItem>d__.<>1__state = -1;
			<CreateCostItem>d__.<>t__builder.Start<DangoBrawlOutBackpackBagItem.<CreateCostItem>d__17>(ref <CreateCostItem>d__);
			return <CreateCostItem>d__.<>t__builder.Task;
		}

		// Token: 0x06042895 RID: 272533 RVA: 0x0102B410 File Offset: 0x01029610
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

		// Token: 0x06042896 RID: 272534 RVA: 0x0102B488 File Offset: 0x01029688
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

		// Token: 0x06042897 RID: 272535 RVA: 0x0102B4EE File Offset: 0x010296EE
		public void SetStarsContentActive(bool val)
		{
			UUIItem item = base.GetItem(9);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(val);
		}

		// Token: 0x06042898 RID: 272536 RVA: 0x0102B504 File Offset: 0x01029704
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

		// Token: 0x06042899 RID: 272537 RVA: 0x0102B55C File Offset: 0x0102975C
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

		// Token: 0x0604289A RID: 272538 RVA: 0x0102B5B0 File Offset: 0x010297B0
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

		// Token: 0x0604289B RID: 272539 RVA: 0x0102B5FC File Offset: 0x010297FC
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

		// Token: 0x0604289C RID: 272540 RVA: 0x0102B648 File Offset: 0x01029848
		private UniTask EnsureStarPanelsAsync()
		{
			DangoBrawlOutBackpackBagItem.<EnsureStarPanelsAsync>d__25 <EnsureStarPanelsAsync>d__;
			<EnsureStarPanelsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EnsureStarPanelsAsync>d__.<>4__this = this;
			<EnsureStarPanelsAsync>d__.<>1__state = -1;
			<EnsureStarPanelsAsync>d__.<>t__builder.Start<DangoBrawlOutBackpackBagItem.<EnsureStarPanelsAsync>d__25>(ref <EnsureStarPanelsAsync>d__);
			return <EnsureStarPanelsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604289D RID: 272541 RVA: 0x0102B68C File Offset: 0x0102988C
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

		// Token: 0x0604289E RID: 272542 RVA: 0x0102B6D8 File Offset: 0x010298D8
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

		// Token: 0x0604289F RID: 272543 RVA: 0x0102B82C File Offset: 0x01029A2C
		public void SetBlurContentActive(bool val)
		{
			UUIItem item = base.GetItem(12);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(val);
		}

		// Token: 0x060428A0 RID: 272544 RVA: 0x0102B841 File Offset: 0x01029A41
		public void ShowBlurGridsDisplay(bool isShow)
		{
			this.SetBlurContentActive(isShow);
			if (isShow)
			{
				this.EnsureBlurGrids();
				this.RefreshBlurGrids();
			}
		}

		// Token: 0x060428A1 RID: 272545 RVA: 0x0102B85C File Offset: 0x01029A5C
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

		// Token: 0x060428A2 RID: 272546 RVA: 0x0102B8D8 File Offset: 0x01029AD8
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

		// Token: 0x060428A3 RID: 272547 RVA: 0x0102B96C File Offset: 0x01029B6C
		public void RefreshWeaponQualityFx()
		{
			this.RefreshQualityFx(base.GetItem(21), base.GetItem(22), base.GetUiNiagara(26));
		}

		// Token: 0x060428A4 RID: 272548 RVA: 0x0102B98C File Offset: 0x01029B8C
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

		// Token: 0x04022AA3 RID: 141987
		[Nullable(1)]
		private readonly List<DangoBrawlGeneralStar> StarPanels = new List<DangoBrawlGeneralStar>();

		// Token: 0x04022AA4 RID: 141988
		[Nullable(1)]
		private readonly List<UUIItem> BlurGridPool = new List<UUIItem>();

		// Token: 0x04022AA5 RID: 141989
		private DangoBrawlOutBackpackCostItem CostItem;

		// Token: 0x0200C9C7 RID: 51655
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403CF55 RID: 249685
			ContentStar = 9,
			// Token: 0x0403CF56 RID: 249686
			ItemStar,
			// Token: 0x0403CF57 RID: 249687
			CostNumItem,
			// Token: 0x0403CF58 RID: 249688
			ContentBlurGrid,
			// Token: 0x0403CF59 RID: 249689
			TemplateBlurGrid,
			// Token: 0x0403CF5A RID: 249690
			UniqueWeaponItem = 17,
			// Token: 0x0403CF5B RID: 249691
			SprIconMask02,
			// Token: 0x0403CF5C RID: 249692
			FxNiagaraType1 = 21,
			// Token: 0x0403CF5D RID: 249693
			FxNiagaraType2,
			// Token: 0x0403CF5E RID: 249694
			SprIconMask03 = 24,
			// Token: 0x0403CF5F RID: 249695
			NiagaraQualityFx = 26
		}
	}
}
