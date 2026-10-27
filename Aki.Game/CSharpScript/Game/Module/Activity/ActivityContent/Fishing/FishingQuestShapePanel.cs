using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200661C RID: 26140
	public class FishingQuestShapePanel : UiPanelBase
	{
		// Token: 0x06041886 RID: 268422 RVA: 0x00FE2624 File Offset: 0x00FE0824
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06041887 RID: 268423 RVA: 0x00FE26F0 File Offset: 0x00FE08F0
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(1);
			this.GirdWidth = item.Width;
			this.GirdHeight = item.Height;
			this.InitialGirdOffsetX = item.GetAnchorOffsetX();
			this.InitialGirdOffsetY = item.GetAnchorOffsetY();
			item.SetUIActive(false);
		}

		// Token: 0x06041888 RID: 268424 RVA: 0x00FE273C File Offset: 0x00FE093C
		public void RefreshPanel(int itemId, bool isUnlock = true)
		{
			FishingItem? fishingItemConfig = FishingConfig.Instance.GetFishingItemConfig(itemId);
			IntArray[] array = FishingConfig.Instance.GetFishingShapeConfig(fishingItemConfig.Value.Shap).FillState();
			int num = -1;
			int num2 = -1;
			int num3 = -1;
			int num4 = -1;
			for (int i = 0; i < array.Length; i++)
			{
				IntArray intArray = array[i];
				for (int j = 0; j < intArray.ArrayIntLength; j++)
				{
					if (intArray.ArrayInt(j) == 1)
					{
						num = ((num == -1) ? i : Math.Min(num, i));
						num2 = ((num2 == -1) ? i : Math.Max(num2, i));
						num3 = ((num3 == -1) ? j : Math.Min(num3, j));
						num4 = ((num4 == -1) ? j : Math.Max(num4, j));
					}
				}
			}
			List<FishingQuestShapePanelItem> girdList = this.GirdList;
			foreach (FishingQuestShapePanelItem fishingQuestShapePanelItem in girdList)
			{
				fishingQuestShapePanelItem.SetUiActive(false);
			}
			this.RefreshAllGird(array.ToList<IntArray>(), num, num3);
			float width = (float)(num4 - num3 + 1) * this.GirdWidth;
			float height = (float)(num2 - num + 1) * this.GirdHeight;
			UUITexture texture = base.GetTexture(2);
			texture.SetWidth(width);
			texture.SetHeight(height);
			UUIItem item = base.GetItem(0);
			item.SetWidth(width);
			item.SetHeight(height);
			string sprite = fishingItemConfig.Value.Sprite;
			foreach (FishingQuestShapePanelItem fishingQuestShapePanelItem2 in girdList)
			{
				fishingQuestShapePanelItem2.SetGirdSprite(fishingItemConfig.Value.Category, sprite);
			}
			base.SetTextureByPath(fishingItemConfig.Value.Pic, texture, null, null);
			this.SetTextureMaterialActive(isUnlock);
			base.GetItem(3).SetUIActive(!isUnlock);
			base.GetItem(4).useChangeColor = isUnlock;
		}

		// Token: 0x06041889 RID: 268425 RVA: 0x00FE2964 File Offset: 0x00FE0B64
		private void SetTextureMaterialActive(bool value)
		{
			if (value)
			{
				base.GetTexture(2).SetCustomMaterialScalarParameter(FishingDefine.materialProgressName, 1f);
				return;
			}
			base.GetTexture(2).SetCustomMaterialScalarParameter(FishingDefine.materialProgressName, 0f);
		}

		// Token: 0x0604188A RID: 268426 RVA: 0x00FE2998 File Offset: 0x00FE0B98
		[NullableContext(1)]
		private void RefreshAllGird(List<IntArray> targetList, int minValidRow, int minValidCol)
		{
			int num = 0;
			for (int i = 0; i < targetList.Count; i++)
			{
				IntArray intArray = targetList[i];
				for (int j = 0; j < intArray.ArrayIntLength; j++)
				{
					if (intArray.ArrayInt(j) == 1)
					{
						this.SetShapePanelItem(num++, i - minValidRow, j - minValidCol);
					}
				}
			}
		}

		// Token: 0x0604188B RID: 268427 RVA: 0x00FE29F0 File Offset: 0x00FE0BF0
		private void SetShapePanelItem(int index, int rowIndex, int columnIndex)
		{
			float anchorOffsetX = this.InitialGirdOffsetX + (float)columnIndex * this.GirdWidth;
			float anchorOffsetY = this.InitialGirdOffsetY - (float)rowIndex * this.GirdHeight;
			FishingQuestShapePanelItem fishingQuestShapePanelItem;
			if (this.GirdList.Count > index)
			{
				fishingQuestShapePanelItem = this.GirdList[index];
				fishingQuestShapePanelItem.SetUiActive(true);
			}
			else
			{
				UUIItem uuiitem = LguiUtil.Instance.CopyItem(base.GetItem(1), base.GetItem(0));
				fishingQuestShapePanelItem = new FishingQuestShapePanelItem();
				fishingQuestShapePanelItem.CreateThenShowByActorAsync(uuiitem.GetOwner());
				this.GirdList.Add(fishingQuestShapePanelItem);
			}
			fishingQuestShapePanelItem.GetRootItem().SetAnchorOffsetX(anchorOffsetX);
			fishingQuestShapePanelItem.GetRootItem().SetAnchorOffsetY(anchorOffsetY);
		}

		// Token: 0x04022189 RID: 139657
		private float GirdWidth;

		// Token: 0x0402218A RID: 139658
		private float GirdHeight;

		// Token: 0x0402218B RID: 139659
		private float InitialGirdOffsetX;

		// Token: 0x0402218C RID: 139660
		private float InitialGirdOffsetY;

		// Token: 0x0402218D RID: 139661
		[Nullable(1)]
		private readonly List<FishingQuestShapePanelItem> GirdList = new List<FishingQuestShapePanelItem>();

		// Token: 0x0200C831 RID: 51249
		private class EComponentDefine
		{
			// Token: 0x0403C76C RID: 247660
			public const int GirdListItem = 0;

			// Token: 0x0403C76D RID: 247661
			public const int GirdItem = 1;

			// Token: 0x0403C76E RID: 247662
			public const int FishingIconTexture = 2;

			// Token: 0x0403C76F RID: 247663
			public const int LockItem = 3;

			// Token: 0x0403C770 RID: 247664
			public const int ColorItem = 4;
		}
	}
}
