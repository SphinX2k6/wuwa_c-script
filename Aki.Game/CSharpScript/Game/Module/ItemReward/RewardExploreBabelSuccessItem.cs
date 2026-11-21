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
	// Token: 0x020047D1 RID: 18385
	public class RewardExploreBabelSuccessItem : UiPanelBase
	{
		// Token: 0x0602E343 RID: 189251 RVA: 0x00CE2E50 File Offset: 0x00CE1050
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

		// Token: 0x0602E344 RID: 189252 RVA: 0x00CE2EFB File Offset: 0x00CE10FB
		protected override void OnStart()
		{
			this.BuffItemLayout = new GenericLayout<RewardExploreBabelSuccessItem.BabelTowerUnlockBuffItem, IBabelTowerBuffItemData>(base.GetHorizontalLayout(3), new Func<RewardExploreBabelSuccessItem.BabelTowerUnlockBuffItem>(this.CreateBuffItem), null, false, true);
		}

		// Token: 0x0602E345 RID: 189253 RVA: 0x00CE2F1E File Offset: 0x00CE111E
		[NullableContext(1)]
		private RewardExploreBabelSuccessItem.BabelTowerUnlockBuffItem CreateBuffItem()
		{
			return new RewardExploreBabelSuccessItem.BabelTowerUnlockBuffItem();
		}

		// Token: 0x0602E346 RID: 189254 RVA: 0x00CE2F28 File Offset: 0x00CE1128
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

		// Token: 0x040189C7 RID: 100807
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RewardExploreBabelSuccessItem.BabelTowerUnlockBuffItem, IBabelTowerBuffItemData> BuffItemLayout;

		// Token: 0x0200A403 RID: 41987
		private class ESuccessItemComponent
		{
			// Token: 0x04032D4D RID: 208205
			public const int StarNumText = 0;

			// Token: 0x04032D4E RID: 208206
			public const int TipText = 1;

			// Token: 0x04032D4F RID: 208207
			public const int UnlockParentItem = 2;

			// Token: 0x04032D50 RID: 208208
			public const int BuffItemLayout = 3;
		}

		// Token: 0x0200A404 RID: 41988
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public class BabelTowerUnlockBuffItem : GridProxyAbstract<IBabelTowerBuffItemData>
		{
			// Token: 0x06045C89 RID: 285833 RVA: 0x014FBEF4 File Offset: 0x014FA0F4
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

			// Token: 0x06045C8A RID: 285834 RVA: 0x014FC020 File Offset: 0x014FA220
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

			// Token: 0x06045C8B RID: 285835 RVA: 0x014FC100 File Offset: 0x014FA300
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

			// Token: 0x04032D51 RID: 208209
			[Nullable(2)]
			private IBabelTowerBuffItemData Data;

			// Token: 0x0200BD49 RID: 48457
			private class EUnlockBuffItemComponent
			{
				// Token: 0x0403A1DC RID: 238044
				public const int IconTexture = 0;

				// Token: 0x0403A1DD RID: 238045
				public const int NameText = 1;

				// Token: 0x0403A1DE RID: 238046
				public const int ItemButton = 2;

				// Token: 0x0403A1DF RID: 238047
				public const int BuffBgItem = 3;

				// Token: 0x0403A1E0 RID: 238048
				public const int DeTermBgItem = 4;

				// Token: 0x0403A1E1 RID: 238049
				public const int CommonBgItem = 5;
			}
		}
	}
}
