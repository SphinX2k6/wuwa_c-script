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
	// Token: 0x02004955 RID: 18773
	[NullableContext(1)]
	[Nullable(0)]
	public class GiantCollectedCoinItem : UiPanelBase, IGridProxy<IGiantCollectedCoinData>
	{
		// Token: 0x17005F0E RID: 24334
		// (get) Token: 0x0602F155 RID: 192853 RVA: 0x00D222DD File Offset: 0x00D204DD
		// (set) Token: 0x0602F156 RID: 192854 RVA: 0x00D222E5 File Offset: 0x00D204E5
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

		// Token: 0x17005F0F RID: 24335
		// (get) Token: 0x0602F157 RID: 192855 RVA: 0x00D222EE File Offset: 0x00D204EE
		// (set) Token: 0x0602F158 RID: 192856 RVA: 0x00D222F6 File Offset: 0x00D204F6
		public int GridIndex { get; set; }

		// Token: 0x17005F10 RID: 24336
		// (get) Token: 0x0602F159 RID: 192857 RVA: 0x00D222FF File Offset: 0x00D204FF
		// (set) Token: 0x0602F15A RID: 192858 RVA: 0x00D22307 File Offset: 0x00D20507
		public int DisplayIndex { get; set; }

		// Token: 0x0602F15B RID: 192859 RVA: 0x00D22310 File Offset: 0x00D20510
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

		// Token: 0x0602F15C RID: 192860 RVA: 0x00D223A8 File Offset: 0x00D205A8
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

		// Token: 0x0602F15D RID: 192861 RVA: 0x00D22428 File Offset: 0x00D20628
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

		// Token: 0x0602F15E RID: 192862 RVA: 0x00D22475 File Offset: 0x00D20675
		public void Clear()
		{
		}

		// Token: 0x0602F15F RID: 192863 RVA: 0x00D22477 File Offset: 0x00D20677
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x0602F160 RID: 192864 RVA: 0x00D22479 File Offset: 0x00D20679
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x0602F161 RID: 192865 RVA: 0x00D2247B File Offset: 0x00D2067B
		public object GetKey(IGiantCollectedCoinData data, int gridIndex)
		{
			return data.ItemId;
		}

		// Token: 0x04018FF4 RID: 102388
		private int ItemId;
	}
}
