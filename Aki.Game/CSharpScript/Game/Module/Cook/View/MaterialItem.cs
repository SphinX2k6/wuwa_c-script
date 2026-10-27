using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Manufacture.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02005B0F RID: 23311
	[NullableContext(1)]
	[Nullable(0)]
	public class MaterialItem : UiPanelBase
	{
		// Token: 0x0603B058 RID: 241752 RVA: 0x00E11EE0 File Offset: 0x00E100E0
		public MaterialItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0603B059 RID: 241753 RVA: 0x00E11EF8 File Offset: 0x00E100F8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603B05A RID: 241754 RVA: 0x00E12004 File Offset: 0x00E10204
		public void Update(ISingleItemInfo info, int index)
		{
			this.ItemData = info;
			this.Index = index;
			if (this.ItemData.Proto_ItemId != 0)
			{
				this.ItemInfo = ItemConfig.Instance.GetConfig(this.ItemData.Proto_ItemId);
			}
			else
			{
				this.ItemInfo = null;
			}
			this.RefreshNeed(1);
			this.RefreshHave();
			this.RefreshIcon();
			this.RefreshQuality();
		}

		// Token: 0x0603B05B RID: 241755 RVA: 0x00E12070 File Offset: 0x00E10270
		public void RefreshNeed(int num = 1)
		{
			int num2 = this.ItemData.Proto_ItemNum;
			if (num != 1)
			{
				num2 = num * num2;
			}
			base.GetText(2).SetText(num2.ToString(), true);
		}

		// Token: 0x0603B05C RID: 241756 RVA: 0x00E120A8 File Offset: 0x00E102A8
		protected void RefreshHave()
		{
			int commonItemCount = InventoryModel.Instance.GetCommonItemCount(this.ItemData.Proto_ItemId, 0);
			string newText;
			if (this.ItemData.Proto_IsUnlock)
			{
				if (commonItemCount < this.ItemData.Proto_ItemNum)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
					defaultInterpolatedStringHandler.AppendLiteral("<color=#");
					defaultInterpolatedStringHandler.AppendFormatted("ece5d8");
					defaultInterpolatedStringHandler.AppendLiteral(">");
					defaultInterpolatedStringHandler.AppendFormatted<int>(commonItemCount);
					defaultInterpolatedStringHandler.AppendLiteral("</color>");
					newText = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
					defaultInterpolatedStringHandler.AppendLiteral("<color=#");
					defaultInterpolatedStringHandler.AppendFormatted("aa9b6a");
					defaultInterpolatedStringHandler.AppendLiteral(">");
					defaultInterpolatedStringHandler.AppendFormatted<int>(commonItemCount);
					defaultInterpolatedStringHandler.AppendLiteral("</color>");
					newText = defaultInterpolatedStringHandler.ToStringAndClear();
				}
			}
			else
			{
				newText = "<color=#aa9b6a>--</color>";
			}
			base.GetText(1).SetText(newText, true);
		}

		// Token: 0x0603B05D RID: 241757 RVA: 0x00E12198 File Offset: 0x00E10398
		private void RefreshIcon()
		{
			if (this.ItemData.Proto_IsUnlock)
			{
				base.GetTexture(3).SetUIActive(true);
				base.SetTextureByPath(this.ItemInfo.Value.Icon, base.GetTexture(3), null, null);
				return;
			}
			base.GetTexture(3).SetUIActive(false);
		}

		// Token: 0x0603B05E RID: 241758 RVA: 0x00E121F8 File Offset: 0x00E103F8
		private void RefreshQuality()
		{
			if (this.ItemData.Proto_IsUnlock)
			{
				base.GetSprite(4).SetUIActive(true);
				base.SetItemQualityIcon(base.GetSprite(4), this.ItemData.Proto_ItemId, null, global::CommonDefine.EQualityIconType.BackgroundSprite, null);
				return;
			}
			base.GetSprite(4).SetUIActive(false);
		}

		// Token: 0x0603B05F RID: 241759 RVA: 0x00E12250 File Offset: 0x00E10450
		public void BindOnClickedCallback(Action<ISingleItemInfo, int> onItemButtonClicked)
		{
			this.OnClickedCallback = onItemButtonClicked;
		}

		// Token: 0x0603B060 RID: 241760 RVA: 0x00E12259 File Offset: 0x00E10459
		private void OnClick(EToggleState state)
		{
			if (this.OnClickedCallback != null)
			{
				this.OnClickedCallback(this.ItemData, this.Index);
			}
		}

		// Token: 0x0401ECA7 RID: 126119
		[Nullable(2)]
		protected ISingleItemInfo ItemData;

		// Token: 0x0401ECA8 RID: 126120
		protected ItemInfo? ItemInfo;

		// Token: 0x0401ECA9 RID: 126121
		protected int Index;

		// Token: 0x0401ECAA RID: 126122
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<ISingleItemInfo, int> OnClickedCallback;

		// Token: 0x0200BD4D RID: 48461
		[NullableContext(0)]
		public enum EMaterialDefine
		{
			// Token: 0x04039181 RID: 233857
			MaterialExtendToggle,
			// Token: 0x04039182 RID: 233858
			HaveText,
			// Token: 0x04039183 RID: 233859
			NeedText,
			// Token: 0x04039184 RID: 233860
			MaterialIconTexture,
			// Token: 0x04039185 RID: 233861
			MaterialQualitySprite
		}
	}
}
