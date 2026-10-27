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
	// Token: 0x0200680A RID: 26634
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlHandBookItemTipsSlot : UiPanelBase
	{
		// Token: 0x060426E4 RID: 272100 RVA: 0x010227E8 File Offset: 0x010209E8
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

		// Token: 0x060426E5 RID: 272101 RVA: 0x010228D5 File Offset: 0x01020AD5
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

		// Token: 0x060426E6 RID: 272102 RVA: 0x01022910 File Offset: 0x01020B10
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

		// Token: 0x060426E7 RID: 272103 RVA: 0x0102295B File Offset: 0x01020B5B
		private float GetGridSize()
		{
			return base.GetItem(2).GetHeight();
		}

		// Token: 0x060426E8 RID: 272104 RVA: 0x0102296C File Offset: 0x01020B6C
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

		// Token: 0x060426E9 RID: 272105 RVA: 0x01022A58 File Offset: 0x01020C58
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

		// Token: 0x060426EA RID: 272106 RVA: 0x01022AA4 File Offset: 0x01020CA4
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

		// Token: 0x060426EB RID: 272107 RVA: 0x01022AF0 File Offset: 0x01020CF0
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

		// Token: 0x060426EC RID: 272108 RVA: 0x01022B88 File Offset: 0x01020D88
		private UniTask RefreshIconAsync()
		{
			DangoBrawlHandBookItemTipsSlot.<RefreshIconAsync>d__12 <RefreshIconAsync>d__;
			<RefreshIconAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshIconAsync>d__.<>4__this = this;
			<RefreshIconAsync>d__.<>1__state = -1;
			<RefreshIconAsync>d__.<>t__builder.Start<DangoBrawlHandBookItemTipsSlot.<RefreshIconAsync>d__12>(ref <RefreshIconAsync>d__);
			return <RefreshIconAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060426ED RID: 272109 RVA: 0x01022BCC File Offset: 0x01020DCC
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

		// Token: 0x060426EE RID: 272110 RVA: 0x01022C24 File Offset: 0x01020E24
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

		// Token: 0x040229FD RID: 141821
		private int ItemId = -1;

		// Token: 0x040229FE RID: 141822
		private readonly List<UUIItem> BlurGridPool = new List<UUIItem>();

		// Token: 0x040229FF RID: 141823
		private readonly List<DangoBrawlGeneralStar> StarPanels = new List<DangoBrawlGeneralStar>();

		// Token: 0x0200C980 RID: 51584
		[NullableContext(0)]
		private enum EItemComponents
		{
			// Token: 0x0403CDA5 RID: 249253
			TogItem,
			// Token: 0x0403CDA6 RID: 249254
			ContentBlurGrid,
			// Token: 0x0403CDA7 RID: 249255
			TemplateBlurGrid,
			// Token: 0x0403CDA8 RID: 249256
			TexIcon,
			// Token: 0x0403CDA9 RID: 249257
			PnlRaycast,
			// Token: 0x0403CDAA RID: 249258
			ContentStar,
			// Token: 0x0403CDAB RID: 249259
			StarItem,
			// Token: 0x0403CDAC RID: 249260
			PnlLine,
			// Token: 0x0403CDAD RID: 249261
			PnlCombineLine,
			// Token: 0x0403CDAE RID: 249262
			PnlFrame
		}
	}
}
