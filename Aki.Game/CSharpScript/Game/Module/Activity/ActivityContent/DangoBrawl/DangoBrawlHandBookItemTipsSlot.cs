using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200575A RID: 22362
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlHandBookItemTipsSlot : UiPanelBase
	{
		// Token: 0x06037239 RID: 225849 RVA: 0x00F63D2C File Offset: 0x00F61F2C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603723A RID: 225850 RVA: 0x00F63E19 File Offset: 0x00F62019
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUIItem item3 = base.GetItem(5);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(false);
		}

		// Token: 0x0603723B RID: 225851 RVA: 0x00F63E54 File Offset: 0x00F62054
		public UniTask RefreshAsync(int itemId)
		{
			DangoBrawlHandBookItemTipsSlot.<RefreshAsync>d__6 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.itemId = itemId;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<DangoBrawlHandBookItemTipsSlot.<RefreshAsync>d__6>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603723C RID: 225852 RVA: 0x00F63E9F File Offset: 0x00F6209F
		private float GetGridSize()
		{
			return base.GetItem(2).GetHeight();
		}

		// Token: 0x0603723D RID: 225853 RVA: 0x00F63EB0 File Offset: 0x00F620B0
		private void RefreshBlurGrids(PanelPos[] posList)
		{
			UUIItem item = base.GetItem(2);
			UUIItem item2 = base.GetItem(1);
			float gridSize = this.GetGridSize();
			item.SetUIActive(false);
			item2.SetUIActive(true);
			for (int i = 0; i < posList.Length; i++)
			{
				PanelPos panelPos = posList[i];
				FVector uirelativeLocation = new FVector((float)panelPos.ColIndex * gridSize, (float)(-(float)panelPos.RowIndex) * gridSize, 0f);
				UUIItem uuiitem = (i < this.BlurGridPool.Count) ? this.BlurGridPool[i] : null;
				if (uuiitem == null)
				{
					uuiitem = LguiUtil.Instance.CopyItem(item, item2);
					this.BlurGridPool.Add(uuiitem);
				}
				uuiitem.SetUIActive(true);
				uuiitem.SetUIRelativeLocation(uirelativeLocation);
			}
			for (int j = posList.Length; j < this.BlurGridPool.Count; j++)
			{
				this.BlurGridPool[j].SetUIActive(false);
			}
		}

		// Token: 0x0603723E RID: 225854 RVA: 0x00F63F9C File Offset: 0x00F6219C
		private UniTask RefreshStarsAsync(PanelPos[] starPosList)
		{
			DangoBrawlHandBookItemTipsSlot.<RefreshStarsAsync>d__9 <RefreshStarsAsync>d__;
			<RefreshStarsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshStarsAsync>d__.<>4__this = this;
			<RefreshStarsAsync>d__.starPosList = starPosList;
			<RefreshStarsAsync>d__.<>1__state = -1;
			<RefreshStarsAsync>d__.<>t__builder.Start<DangoBrawlHandBookItemTipsSlot.<RefreshStarsAsync>d__9>(ref <RefreshStarsAsync>d__);
			return <RefreshStarsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603723F RID: 225855 RVA: 0x00F63FE8 File Offset: 0x00F621E8
		private UniTask EnsureStarPanelsAsync(int need)
		{
			DangoBrawlHandBookItemTipsSlot.<EnsureStarPanelsAsync>d__10 <EnsureStarPanelsAsync>d__;
			<EnsureStarPanelsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EnsureStarPanelsAsync>d__.<>4__this = this;
			<EnsureStarPanelsAsync>d__.need = need;
			<EnsureStarPanelsAsync>d__.<>1__state = -1;
			<EnsureStarPanelsAsync>d__.<>t__builder.Start<DangoBrawlHandBookItemTipsSlot.<EnsureStarPanelsAsync>d__10>(ref <EnsureStarPanelsAsync>d__);
			return <EnsureStarPanelsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037240 RID: 225856 RVA: 0x00F64034 File Offset: 0x00F62234
		private void ApplyStarLayout(PanelPos[] starPosList)
		{
			float gridSize = this.GetGridSize();
			for (int i = 0; i < this.StarPanels.Count; i++)
			{
				DangoBrawlGeneralStar dangoBrawlGeneralStar = this.StarPanels[i];
				if (i >= starPosList.Length)
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
					PanelPos panelPos = starPosList[i];
					UUIItem rootItem2 = dangoBrawlGeneralStar.GetRootItem();
					if (rootItem2 != null)
					{
						rootItem2.SetUIActive(true);
					}
					dangoBrawlGeneralStar.SetUiRelativeLocation(new FVector2D((float)panelPos.ColIndex * gridSize, (float)(-(float)panelPos.RowIndex) * gridSize));
					dangoBrawlGeneralStar.SetStarVisible(false);
				}
			}
		}

		// Token: 0x06037241 RID: 225857 RVA: 0x00F640CC File Offset: 0x00F622CC
		private UniTask RefreshIconAsync()
		{
			DangoBrawlHandBookItemTipsSlot.<RefreshIconAsync>d__12 <RefreshIconAsync>d__;
			<RefreshIconAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshIconAsync>d__.<>4__this = this;
			<RefreshIconAsync>d__.<>1__state = -1;
			<RefreshIconAsync>d__.<>t__builder.Start<DangoBrawlHandBookItemTipsSlot.<RefreshIconAsync>d__12>(ref <RefreshIconAsync>d__);
			return <RefreshIconAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037242 RID: 225858 RVA: 0x00F64110 File Offset: 0x00F62310
		private void ApplyIconScale()
		{
			DangoBrawlItem? dangoBrawlItemById = DangoBrawlConfig.Instance.GetDangoBrawlItemById(this.ItemId);
			float num = (dangoBrawlItemById != null) ? dangoBrawlItemById.GetValueOrDefault().IconHandBookScale2 : 1f;
			UUITexture texture = base.GetTexture(3);
			if (texture == null)
			{
				return;
			}
			texture.SetRelativeScale3D(new FVector(num, num, num));
		}

		// Token: 0x06037243 RID: 225859 RVA: 0x00F64168 File Offset: 0x00F62368
		private void RefreshSize(PanelPos[] posList)
		{
			int num = 0;
			int num2 = 0;
			foreach (PanelPos panelPos in posList)
			{
				if (panelPos.ColIndex > num)
				{
					num = panelPos.ColIndex;
				}
				if (panelPos.RowIndex > num2)
				{
					num2 = panelPos.RowIndex;
				}
			}
			float gridSize = this.GetGridSize();
			UUIItem rootItem = base.GetRootItem();
			if (rootItem != null)
			{
				rootItem.SetWidth((float)(num + 1) * gridSize);
			}
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetHeight((float)(num2 + 1) * gridSize);
		}

		// Token: 0x0401D25A RID: 119386
		private int ItemId = -1;

		// Token: 0x0401D25B RID: 119387
		private readonly List<UUIItem> BlurGridPool = new List<UUIItem>();

		// Token: 0x0401D25C RID: 119388
		private readonly List<DangoBrawlGeneralStar> StarPanels = new List<DangoBrawlGeneralStar>();

		// Token: 0x0200B34D RID: 45901
		[NullableContext(0)]
		private enum EItemComponents
		{
			// Token: 0x04037692 RID: 226962
			TogItem,
			// Token: 0x04037693 RID: 226963
			ContentBlurGrid,
			// Token: 0x04037694 RID: 226964
			TemplateBlurGrid,
			// Token: 0x04037695 RID: 226965
			TexIcon,
			// Token: 0x04037696 RID: 226966
			PnlRaycast,
			// Token: 0x04037697 RID: 226967
			ContentStar,
			// Token: 0x04037698 RID: 226968
			StarItem,
			// Token: 0x04037699 RID: 226969
			PnlLine,
			// Token: 0x0403769A RID: 226970
			PnlCombineLine,
			// Token: 0x0403769B RID: 226971
			PnlFrame
		}
	}
}
