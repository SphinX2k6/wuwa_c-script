using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Giant.View
{
	// Token: 0x0200597C RID: 22908
	[NullableContext(1)]
	[Nullable(0)]
	public class GiantCollectedCoinItem : UiPanelBase, IGridProxy<IGiantCollectedCoinData>
	{
		// Token: 0x17008B41 RID: 35649
		// (get) Token: 0x0603A22F RID: 238127 RVA: 0x00DD2E4D File Offset: 0x00DD104D
		// (set) Token: 0x0603A230 RID: 238128 RVA: 0x00DD2E55 File Offset: 0x00DD1055
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public IScrollViewDelegate<IGridProxy<IGiantCollectedCoinData>, IGiantCollectedCoinData> ScrollViewDelegate { [return: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})] set; }

		// Token: 0x17008B42 RID: 35650
		// (get) Token: 0x0603A231 RID: 238129 RVA: 0x00DD2E5E File Offset: 0x00DD105E
		// (set) Token: 0x0603A232 RID: 238130 RVA: 0x00DD2E66 File Offset: 0x00DD1066
		public int GridIndex { get; set; }

		// Token: 0x17008B43 RID: 35651
		// (get) Token: 0x0603A233 RID: 238131 RVA: 0x00DD2E6F File Offset: 0x00DD106F
		// (set) Token: 0x0603A234 RID: 238132 RVA: 0x00DD2E77 File Offset: 0x00DD1077
		public int DisplayIndex { get; set; }

		// Token: 0x0603A235 RID: 238133 RVA: 0x00DD2E80 File Offset: 0x00DD1080
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
		}

		// Token: 0x0603A236 RID: 238134 RVA: 0x00DD2F18 File Offset: 0x00DD1118
		public void Refresh(IGiantCollectedCoinData data, bool isSelected, int gridIndex)
		{
			this.ItemId = data.ItemId;
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(this.ItemId);
			string text = (itemConfigData != null) ? itemConfigData.Icon : null;
			if (text != null)
			{
				base.SetTextureShowUntilLoaded(text, base.GetTexture(0), null);
			}
			UUIText text2 = base.GetText(1);
			if (text2 != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.Count);
				text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			this.RefreshQualityColor();
		}

		// Token: 0x0603A237 RID: 238135 RVA: 0x00DD2F98 File Offset: 0x00DD1198
		private void RefreshQualityColor()
		{
			string[] collectedCoinQualityColorHex = GiantDefine.CollectedCoinQualityColorHex;
			int itemQuality = GiantConfig.GetItemQuality(this.ItemId);
			string hexStr = (itemQuality >= 0 && itemQuality < collectedCoinQualityColorHex.Length) ? collectedCoinQualityColorHex[itemQuality] : collectedCoinQualityColorHex[collectedCoinQualityColorHex.Length - 1];
			UUISprite sprite = base.GetSprite(2);
			if (sprite == null)
			{
				return;
			}
			sprite.SetColor(FColor.FromHex(hexStr));
		}

		// Token: 0x0603A238 RID: 238136 RVA: 0x00DD2FE5 File Offset: 0x00DD11E5
		public void Clear()
		{
		}

		// Token: 0x0603A239 RID: 238137 RVA: 0x00DD2FE7 File Offset: 0x00DD11E7
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x0603A23A RID: 238138 RVA: 0x00DD2FE9 File Offset: 0x00DD11E9
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x0603A23B RID: 238139 RVA: 0x00DD2FEB File Offset: 0x00DD11EB
		public object GetKey(IGiantCollectedCoinData data, int gridIndex)
		{
			return data.ItemId;
		}

		// Token: 0x0401E556 RID: 124246
		private int ItemId;
	}
}
