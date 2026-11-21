using System;
using System.Collections.Generic;
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
	// Token: 0x02005759 RID: 22361
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlHandBookItemTips : UiPanelBase
	{
		// Token: 0x06037229 RID: 225833 RVA: 0x00F636B4 File Offset: 0x00F618B4
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

		// Token: 0x0603722A RID: 225834 RVA: 0x00F637AC File Offset: 0x00F619AC
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

		// Token: 0x0603722B RID: 225835 RVA: 0x00F63804 File Offset: 0x00F61A04
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

		// Token: 0x0603722C RID: 225836 RVA: 0x00F63878 File Offset: 0x00F61A78
		private string[] GetStarDescParams(DangoBrawlItem itemConfig)
		{
			string[] array = new string[itemConfig.StarDescParamLength];
			for (int i = 0; i < itemConfig.StarDescParamLength; i++)
			{
				array[i] = (itemConfig.StarDescParam(i) ?? string.Empty);
			}
			return array;
		}

		// Token: 0x0603722D RID: 225837 RVA: 0x00F638BC File Offset: 0x00F61ABC
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
				if (NoLinq.Contains<int>(dangoBrawlItemCompose.GetNeedItemsBytes(), this.ItemData.ItemId) || dangoBrawlItemCompose.ResultItemId == this.ItemData.ItemId)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603722E RID: 225838 RVA: 0x00F6394C File Offset: 0x00F61B4C
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

		// Token: 0x0603722F RID: 225839 RVA: 0x00F63BCC File Offset: 0x00F61DCC
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlHandBookItemTips.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlHandBookItemTips.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037230 RID: 225840 RVA: 0x00F63C0F File Offset: 0x00F61E0F
		protected override void OnStart()
		{
			ActivityDangoBrawlController.Instance.RegisterTermHyperlink(base.GetText(13));
		}

		// Token: 0x06037231 RID: 225841 RVA: 0x00F63C24 File Offset: 0x00F61E24
		protected override void OnBeforeDestroy()
		{
			ActivityDangoBrawlController.Instance.UnRegisterTermHyperlink(base.GetText(13));
		}

		// Token: 0x06037232 RID: 225842 RVA: 0x00F63C38 File Offset: 0x00F61E38
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

		// Token: 0x06037233 RID: 225843 RVA: 0x00F63C83 File Offset: 0x00F61E83
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

		// Token: 0x06037234 RID: 225844 RVA: 0x00F63CB5 File Offset: 0x00F61EB5
		private DangoBrawlItemTipsAttrItem CreateAttrItem()
		{
			return new DangoBrawlItemTipsAttrItem();
		}

		// Token: 0x06037235 RID: 225845 RVA: 0x00F63CBC File Offset: 0x00F61EBC
		private DangoBrawlItemTipsDescItem CreateDescItem()
		{
			return new DangoBrawlItemTipsDescItem();
		}

		// Token: 0x06037236 RID: 225846 RVA: 0x00F63CC3 File Offset: 0x00F61EC3
		private DangoBrawlOccupationTagItem CreateTagItem()
		{
			return new DangoBrawlOccupationTagItem();
		}

		// Token: 0x06037237 RID: 225847 RVA: 0x00F63CCC File Offset: 0x00F61ECC
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

		// Token: 0x0401D251 RID: 119377
		private const string DAMAGE_ICON_PATH = "T_DangoBrawl_TipsIconDamage";

		// Token: 0x0401D252 RID: 119378
		private const string CD_ICON_PATH = "T_DangoBrawl_TipsIconCd";

		// Token: 0x0401D253 RID: 119379
		private const string COST_ICON_PATH = "T_DangoBrawl_TipsIconCost";

		// Token: 0x0401D254 RID: 119380
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlItemTipsAttrItem, DangoBrawlItemTipsAttrData> AttrLayout;

		// Token: 0x0401D255 RID: 119381
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlItemTipsDescItem, DangoBrawlItemTipsDescData> DescLayout;

		// Token: 0x0401D256 RID: 119382
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<DangoBrawlOccupationTagItem, int> TagLayout;

		// Token: 0x0401D257 RID: 119383
		[Nullable(2)]
		private DangoBrawlHandBookItemTipsSlot SlotItem;

		// Token: 0x0401D258 RID: 119384
		[Nullable(2)]
		private DangoBrawlOutBackpackCostItem CostItem;

		// Token: 0x0401D259 RID: 119385
		[Nullable(2)]
		private DangoBrawlHandBookItemData ItemData;

		// Token: 0x0200B34A RID: 45898
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04037672 RID: 226930
			TexQuality,
			// Token: 0x04037673 RID: 226931
			LockItem,
			// Token: 0x04037674 RID: 226932
			TxtName,
			// Token: 0x04037675 RID: 226933
			TagLayout,
			// Token: 0x04037676 RID: 226934
			TagItem,
			// Token: 0x04037677 RID: 226935
			BottomScrollView,
			// Token: 0x04037678 RID: 226936
			BottomLayout,
			// Token: 0x04037679 RID: 226937
			AttrLayout,
			// Token: 0x0403767A RID: 226938
			AttrItem,
			// Token: 0x0403767B RID: 226939
			DescItem,
			// Token: 0x0403767C RID: 226940
			DescLayout,
			// Token: 0x0403767D RID: 226941
			SprLine,
			// Token: 0x0403767E RID: 226942
			StarContent,
			// Token: 0x0403767F RID: 226943
			StarText,
			// Token: 0x04037680 RID: 226944
			BtnCombineInfo,
			// Token: 0x04037681 RID: 226945
			SelfItem,
			// Token: 0x04037682 RID: 226946
			SlotItem,
			// Token: 0x04037683 RID: 226947
			CostItem,
			// Token: 0x04037684 RID: 226948
			UniqueWeaponItem
		}
	}
}
