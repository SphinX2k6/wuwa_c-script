using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057FA RID: 22522
	public class RewardExploreBabelSuccessItem : UiPanelBase
	{
		// Token: 0x0603942F RID: 234543 RVA: 0x00D94008 File Offset: 0x00D92208
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06039430 RID: 234544 RVA: 0x00D940B3 File Offset: 0x00D922B3
		protected override void OnStart()
		{
			this.BuffItemLayout = new GenericLayout<RewardExploreBabelSuccessItem.BabelTowerUnlockBuffItem, IBabelTowerBuffItemData>(base.GetHorizontalLayout(3), new Func<RewardExploreBabelSuccessItem.BabelTowerUnlockBuffItem>(this.CreateBuffItem), null, false, true);
		}

		// Token: 0x06039431 RID: 234545 RVA: 0x00D940D6 File Offset: 0x00D922D6
		[NullableContext(1)]
		private RewardExploreBabelSuccessItem.BabelTowerUnlockBuffItem CreateBuffItem()
		{
			return new RewardExploreBabelSuccessItem.BabelTowerUnlockBuffItem();
		}

		// Token: 0x06039432 RID: 234546 RVA: 0x00D940E0 File Offset: 0x00D922E0
		[NullableContext(1)]
		public void Refresh(IBabelTowerSuccessData data)
		{
			TableTextArgNew starTextParam = data.StarTextParam;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), starTextParam.TextKey, starTextParam.Params);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.TipTextId, Array.Empty<object>());
			List<int> newBabelBuffIds = data.NewBabelBuffIds;
			List<int> newBabelDeTermIds = data.NewBabelDeTermIds;
			base.GetText(1).SetUIActive(newBabelBuffIds.Count != 0 || newBabelDeTermIds.Count != 0);
			if (newBabelBuffIds.Count == 0 && newBabelDeTermIds.Count == 0)
			{
				base.GetItem(2).SetUIActive(false);
				return;
			}
			base.GetItem(2).SetUIActive(true);
			List<IBabelTowerBuffItemData> list = new List<IBabelTowerBuffItemData>();
			foreach (int id in newBabelBuffIds)
			{
				BabelTowerBuffItemData item = new BabelTowerBuffItemData
				{
					Id = id,
					IsDeTerm = false,
					CanClick = false
				};
				list.Add(item);
			}
			foreach (int id2 in newBabelDeTermIds)
			{
				BabelTowerBuffItemData item2 = new BabelTowerBuffItemData
				{
					Id = id2,
					IsDeTerm = true,
					CanClick = false
				};
				list.Add(item2);
			}
			list.Sort(delegate(IBabelTowerBuffItemData a, IBabelTowerBuffItemData b)
			{
				if (a.IsDeTerm == b.IsDeTerm)
				{
					return a.Id - b.Id;
				}
				if (!a.IsDeTerm)
				{
					return -1;
				}
				return 1;
			});
			GenericLayout<RewardExploreBabelSuccessItem.BabelTowerUnlockBuffItem, IBabelTowerBuffItemData> buffItemLayout = this.BuffItemLayout;
			if (buffItemLayout == null)
			{
				return;
			}
			buffItemLayout.RefreshByData(list, null, false);
		}

		// Token: 0x0401DF30 RID: 122672
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RewardExploreBabelSuccessItem.BabelTowerUnlockBuffItem, IBabelTowerBuffItemData> BuffItemLayout;

		// Token: 0x0200B9ED RID: 47597
		private class ESuccessItemComponent
		{
			// Token: 0x04038360 RID: 230240
			public const int StarNumText = 0;

			// Token: 0x04038361 RID: 230241
			public const int TipText = 1;

			// Token: 0x04038362 RID: 230242
			public const int UnlockParentItem = 2;

			// Token: 0x04038363 RID: 230243
			public const int BuffItemLayout = 3;
		}

		// Token: 0x0200B9EE RID: 47598
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public class BabelTowerUnlockBuffItem : GridProxyAbstract<IBabelTowerBuffItemData>
		{
			// Token: 0x0604F6FD RID: 325373 RVA: 0x01542BAC File Offset: 0x01540DAC
			protected unsafe override void OnRegisterComponent()
			{
				int num = 6;
				List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
				CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
				Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
				int num2 = 0;
				*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
				this.ComponentRegisterInfos = list;
				num2 = 1;
				List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
				CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
				Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
				num = 0;
				*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnItemButtonClick));
				this.BtnBindInfo = list2;
			}

			// Token: 0x0604F6FE RID: 325374 RVA: 0x01542CD8 File Offset: 0x01540ED8
			[NullableContext(1)]
			public override void Refresh(IBabelTowerBuffItemData data, bool isSelected, int gridIndex)
			{
				this.Data = data;
				bool isDeTerm = data.IsDeTerm;
				UUIItem item = base.GetItem(5);
				UUIItem uuiitem = item;
				bool bUseChangeColor = !isDeTerm;
				FColor? fcolor = new FColor?(item.changeColor);
				uuiitem.SetChangeColor(bUseChangeColor, fcolor);
				string nameText;
				string texture;
				if (isDeTerm)
				{
					BabelTowerDeTerm value = ConfigBabelTowerDeTermById.GetConfig(data.Id, true).Value;
					nameText = value.NameText;
					texture = value.Texture;
				}
				else
				{
					BabelTowerBuff value2 = ConfigBabelTowerBuffById.GetConfig(data.Id, true).Value;
					nameText = value2.NameText;
					texture = value2.Texture;
				}
				base.GetItem(3).SetUIActive(!isDeTerm);
				base.GetItem(4).SetUIActive(isDeTerm);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), nameText, Array.Empty<object>());
				base.SetTextureByPath(texture, base.GetTexture(0), null, null);
			}

			// Token: 0x0604F6FF RID: 325375 RVA: 0x01542DB8 File Offset: 0x01540FB8
			private void OnItemButtonClick()
			{
				BabelTowerItemInfoViewInfo param = new BabelTowerItemInfoViewInfo
				{
					IsDeTerm = this.Data.IsDeTerm,
					ConfigId = this.Data.Id,
					ShowWays = false
				};
				UiManager.Instance.OpenView(EUiViewName.BabelTowerItemInfoView, param, null);
			}

			// Token: 0x04038364 RID: 230244
			[Nullable(2)]
			private IBabelTowerBuffItemData Data;

			// Token: 0x0200D16B RID: 53611
			private class EUnlockBuffItemComponent
			{
				// Token: 0x0403ED94 RID: 257428
				public const int IconTexture = 0;

				// Token: 0x0403ED95 RID: 257429
				public const int NameText = 1;

				// Token: 0x0403ED96 RID: 257430
				public const int ItemButton = 2;

				// Token: 0x0403ED97 RID: 257431
				public const int BuffBgItem = 3;

				// Token: 0x0403ED98 RID: 257432
				public const int DeTermBgItem = 4;

				// Token: 0x0403ED99 RID: 257433
				public const int CommonBgItem = 5;
			}
		}
	}
}
