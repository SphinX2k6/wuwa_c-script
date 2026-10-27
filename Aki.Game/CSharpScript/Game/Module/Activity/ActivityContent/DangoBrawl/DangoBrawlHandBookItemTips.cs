using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006809 RID: 26633
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlHandBookItemTips : UiPanelBase
	{
		// Token: 0x060426D4 RID: 272084 RVA: 0x01022170 File Offset: 0x01020370
		private List<DangoBrawlItemTipsAttrData> GetAttrList(int damage, float cd, int cost)
		{
			List<DangoBrawlItemTipsAttrData> list = new List<DangoBrawlItemTipsAttrData>();
			if (damage > 0)
			{
				list.Add(new DangoBrawlItemTipsAttrData
				{
					AttrIcon = UiResourceConfig.Instance.GetResourcePath("T_DangoBrawl_TipsIconDamage"),
					AttrName = "DangoBrawlGeneral_1004",
					AttrValue = damage.ToString()
				});
			}
			if (cd > 0f)
			{
				string inString = ConfigMultiTextLang.GetLocalTextNew("DangoBrawlBattleUIText_040", null) ?? "";
				list.Add(new DangoBrawlItemTipsAttrData
				{
					AttrIcon = UiResourceConfig.Instance.GetResourcePath("T_DangoBrawl_TipsIconCd"),
					AttrName = "DangoBrawlGeneral_1005",
					AttrValue = StringUtils.Format(inString, new string[]
					{
						cd.ToString("0.#")
					})
				});
			}
			if (cost > 0)
			{
				list.Add(new DangoBrawlItemTipsAttrData
				{
					AttrIcon = UiResourceConfig.Instance.GetResourcePath("T_DangoBrawl_TipsIconCost"),
					AttrName = "DangoBrawlGeneral_1006",
					AttrValue = cost.ToString()
				});
			}
			return list;
		}

		// Token: 0x060426D5 RID: 272085 RVA: 0x01022268 File Offset: 0x01020468
		private string[] GetStringArray(StringArray? stringArray)
		{
			if (stringArray == null)
			{
				return Array.Empty<string>();
			}
			StringArray value = stringArray.Value;
			string[] array = new string[value.ArrayStringLength];
			for (int i = 0; i < value.ArrayStringLength; i++)
			{
				array[i] = (value.ArrayString(i) ?? string.Empty);
			}
			return array;
		}

		// Token: 0x060426D6 RID: 272086 RVA: 0x010222C0 File Offset: 0x010204C0
		private List<DangoBrawlItemTipsDescData> GetDescList(DangoBrawlItem itemConfig)
		{
			List<DangoBrawlItemTipsDescData> list = new List<DangoBrawlItemTipsDescData>();
			for (int i = 0; i < itemConfig.SpeEffectDescLength; i++)
			{
				StringArray? stringArray = (i < itemConfig.SpeEffectDescParamLength) ? itemConfig.SpeEffectDescParam(i) : null;
				list.Add(new DangoBrawlItemTipsDescData
				{
					Desc = (itemConfig.SpeEffectDesc(i) ?? string.Empty),
					DescParams = this.GetStringArray(stringArray)
				});
			}
			return list;
		}

		// Token: 0x060426D7 RID: 272087 RVA: 0x01022334 File Offset: 0x01020534
		private string[] GetStarDescParams(DangoBrawlItem itemConfig)
		{
			string[] array = new string[itemConfig.StarDescParamLength];
			for (int i = 0; i < itemConfig.StarDescParamLength; i++)
			{
				array[i] = (itemConfig.StarDescParam(i) ?? string.Empty);
			}
			return array;
		}

		// Token: 0x060426D8 RID: 272088 RVA: 0x01022378 File Offset: 0x01020578
		private bool HasAnyCombineInfo()
		{
			if (this.ItemData == null)
			{
				return false;
			}
			IReadOnlyList<DangoBrawlItemCompose> dangoBrawlAllCompose = DangoBrawlConfig.Instance.GetDangoBrawlAllCompose();
			if (dangoBrawlAllCompose == null)
			{
				return false;
			}
			foreach (DangoBrawlItemCompose dangoBrawlItemCompose in dangoBrawlAllCompose)
			{
				if (dangoBrawlItemCompose.GetNeedItemsArray().Contains(this.ItemData.ItemId) || dangoBrawlItemCompose.ResultItemId == this.ItemData.ItemId)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060426D9 RID: 272089 RVA: 0x01022408 File Offset: 0x01020608
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIMultiTemplateLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(14, new Action(this.OnCombineInfoBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060426DA RID: 272090 RVA: 0x01022688 File Offset: 0x01020888
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlHandBookItemTips.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlHandBookItemTips.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060426DB RID: 272091 RVA: 0x010226CB File Offset: 0x010208CB
		protected override void OnStart()
		{
			ActivityDangoBrawlController.Instance.RegisterTermHyperlink(base.GetText(13));
		}

		// Token: 0x060426DC RID: 272092 RVA: 0x010226E0 File Offset: 0x010208E0
		protected override void OnBeforeDestroy()
		{
			ActivityDangoBrawlController.Instance.UnRegisterTermHyperlink(base.GetText(13));
		}

		// Token: 0x060426DD RID: 272093 RVA: 0x010226F4 File Offset: 0x010208F4
		public UniTask RefreshAsync(DangoBrawlHandBookItemData data)
		{
			DangoBrawlHandBookItemTips.<RefreshAsync>d__19 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.data = data;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<DangoBrawlHandBookItemTips.<RefreshAsync>d__19>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060426DE RID: 272094 RVA: 0x0102273F File Offset: 0x0102093F
		private void RefreshCostDisplay(int cost)
		{
			UUIItem item = base.GetItem(17);
			if (item != null)
			{
				item.SetUIActive(cost > 0);
			}
			if (cost <= 0 || this.CostItem == null)
			{
				return;
			}
			this.CostItem.SetCostNum(cost);
		}

		// Token: 0x060426DF RID: 272095 RVA: 0x01022771 File Offset: 0x01020971
		private DangoBrawlItemTipsAttrItem CreateAttrItem()
		{
			return new DangoBrawlItemTipsAttrItem();
		}

		// Token: 0x060426E0 RID: 272096 RVA: 0x01022778 File Offset: 0x01020978
		private DangoBrawlItemTipsDescItem CreateDescItem()
		{
			return new DangoBrawlItemTipsDescItem();
		}

		// Token: 0x060426E1 RID: 272097 RVA: 0x0102277F File Offset: 0x0102097F
		private DangoBrawlOccupationTagItem CreateTagItem()
		{
			return new DangoBrawlOccupationTagItem();
		}

		// Token: 0x060426E2 RID: 272098 RVA: 0x01022788 File Offset: 0x01020988
		private void OnCombineInfoBtnClick()
		{
			if (this.ItemData == null)
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlCombineView, new DangoBrawlCombineViewOpenData
			{
				FocusConfigId = this.ItemData.ItemId,
				AllowCombine = false,
				UseActData = false,
				ShowIntoSelf = true,
				ShowSelfIntoOther = true
			}, null);
		}

		// Token: 0x040229F4 RID: 141812
		private const string DAMAGE_ICON_PATH = "T_DangoBrawl_TipsIconDamage";

		// Token: 0x040229F5 RID: 141813
		private const string CD_ICON_PATH = "T_DangoBrawl_TipsIconCd";

		// Token: 0x040229F6 RID: 141814
		private const string COST_ICON_PATH = "T_DangoBrawl_TipsIconCost";

		// Token: 0x040229F7 RID: 141815
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlItemTipsAttrItem, DangoBrawlItemTipsAttrData> AttrLayout;

		// Token: 0x040229F8 RID: 141816
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlItemTipsDescItem, DangoBrawlItemTipsDescData> DescLayout;

		// Token: 0x040229F9 RID: 141817
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<DangoBrawlOccupationTagItem, int> TagLayout;

		// Token: 0x040229FA RID: 141818
		[Nullable(2)]
		private DangoBrawlHandBookItemTipsSlot SlotItem;

		// Token: 0x040229FB RID: 141819
		[Nullable(2)]
		private DangoBrawlOutBackpackCostItem CostItem;

		// Token: 0x040229FC RID: 141820
		[Nullable(2)]
		private DangoBrawlHandBookItemData ItemData;

		// Token: 0x0200C97D RID: 51581
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403CD85 RID: 249221
			TexQuality,
			// Token: 0x0403CD86 RID: 249222
			LockItem,
			// Token: 0x0403CD87 RID: 249223
			TxtName,
			// Token: 0x0403CD88 RID: 249224
			TagLayout,
			// Token: 0x0403CD89 RID: 249225
			TagItem,
			// Token: 0x0403CD8A RID: 249226
			BottomScrollView,
			// Token: 0x0403CD8B RID: 249227
			BottomLayout,
			// Token: 0x0403CD8C RID: 249228
			AttrLayout,
			// Token: 0x0403CD8D RID: 249229
			AttrItem,
			// Token: 0x0403CD8E RID: 249230
			DescItem,
			// Token: 0x0403CD8F RID: 249231
			DescLayout,
			// Token: 0x0403CD90 RID: 249232
			SprLine,
			// Token: 0x0403CD91 RID: 249233
			StarContent,
			// Token: 0x0403CD92 RID: 249234
			StarText,
			// Token: 0x0403CD93 RID: 249235
			BtnCombineInfo,
			// Token: 0x0403CD94 RID: 249236
			SelfItem,
			// Token: 0x0403CD95 RID: 249237
			SlotItem,
			// Token: 0x0403CD96 RID: 249238
			CostItem,
			// Token: 0x0403CD97 RID: 249239
			UniqueWeaponItem
		}
	}
}
