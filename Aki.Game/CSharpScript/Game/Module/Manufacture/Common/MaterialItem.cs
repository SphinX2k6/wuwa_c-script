using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Common
{
	// Token: 0x0200568B RID: 22155
	[NullableContext(1)]
	[Nullable(0)]
	public class MaterialItem : UiPanelBase
	{
		// Token: 0x060385EE RID: 230894 RVA: 0x00D61FDF File Offset: 0x00D601DF
		public MaterialItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x060385EF RID: 230895 RVA: 0x00D61FF4 File Offset: 0x00D601F4
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

		// Token: 0x060385F0 RID: 230896 RVA: 0x00D62100 File Offset: 0x00D60300
		public void Update(ISingleItemInfo info)
		{
			this.ItemData = info;
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

		// Token: 0x060385F1 RID: 230897 RVA: 0x00D62164 File Offset: 0x00D60364
		public void RefreshNeed(int num = 1)
		{
			int num2 = this.ItemData.Proto_ItemNum;
			if (num != 1)
			{
				num2 = num * num2;
			}
			base.GetText(2).SetText(num2.ToString(), true);
		}

		// Token: 0x060385F2 RID: 230898 RVA: 0x00D6219C File Offset: 0x00D6039C
		protected void RefreshHave()
		{
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(this.ItemData.Proto_ItemId, 0);
			string newText;
			if (this.ItemData.Proto_IsUnlock)
			{
				if (itemCountByConfigId < this.ItemData.Proto_ItemNum)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
					defaultInterpolatedStringHandler.AppendLiteral("<color=#dc0300>");
					defaultInterpolatedStringHandler.AppendFormatted<int>(itemCountByConfigId);
					defaultInterpolatedStringHandler.AppendLiteral("</color>");
					newText = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
					defaultInterpolatedStringHandler.AppendLiteral("<color=#ffffff>");
					defaultInterpolatedStringHandler.AppendFormatted<int>(itemCountByConfigId);
					defaultInterpolatedStringHandler.AppendLiteral("</color>");
					newText = defaultInterpolatedStringHandler.ToStringAndClear();
				}
			}
			else
			{
				newText = "<color=#ffffff>--</color>";
			}
			base.GetText(1).SetText(newText, true);
		}

		// Token: 0x060385F3 RID: 230899 RVA: 0x00D6225C File Offset: 0x00D6045C
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

		// Token: 0x060385F4 RID: 230900 RVA: 0x00D622BC File Offset: 0x00D604BC
		private void RefreshQuality()
		{
			if (this.ItemData.Proto_IsUnlock)
			{
				base.GetSprite(4).SetUIActive(true);
				base.SetItemQualityIcon(base.GetSprite(4), this.ItemInfo.Value.Id, null, CommonDefine.EQualityIconType.BackgroundSprite, null);
				return;
			}
			base.GetSprite(4).SetUIActive(false);
		}

		// Token: 0x060385F5 RID: 230901 RVA: 0x00D6231C File Offset: 0x00D6051C
		public void BindOnClickedCallback(Action<ISingleItemInfo> onItemButtonClicked)
		{
			this.OnClickedCallback = onItemButtonClicked;
		}

		// Token: 0x060385F6 RID: 230902 RVA: 0x00D62325 File Offset: 0x00D60525
		protected void OnClick(EToggleState state)
		{
			if (this.OnClickedCallback != null)
			{
				this.OnClickedCallback(this.ItemData);
			}
		}

		// Token: 0x0401D9FB RID: 121339
		[Nullable(2)]
		protected ISingleItemInfo ItemData;

		// Token: 0x0401D9FC RID: 121340
		protected ItemInfo? ItemInfo;

		// Token: 0x0401D9FD RID: 121341
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<ISingleItemInfo> OnClickedCallback;

		// Token: 0x0200B853 RID: 47187
		[NullableContext(0)]
		private class EMaterialDefine
		{
			// Token: 0x04037CA5 RID: 228517
			public const int MaterialExtendToggle = 0;

			// Token: 0x04037CA6 RID: 228518
			public const int HaveText = 1;

			// Token: 0x04037CA7 RID: 228519
			public const int NeedText = 2;

			// Token: 0x04037CA8 RID: 228520
			public const int MaterialIconTexture = 3;

			// Token: 0x04037CA9 RID: 228521
			public const int MaterialQualitySprite = 4;
		}
	}
}
