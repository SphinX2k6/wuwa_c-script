using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048FD RID: 18685
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrastructureShopMainView : UiViewBase
	{
		// Token: 0x0602EE8F RID: 192143 RVA: 0x00D1707E File Offset: 0x00D1527E
		public InfrastructureShopMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602EE90 RID: 192144 RVA: 0x00D17094 File Offset: 0x00D15294
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602EE91 RID: 192145 RVA: 0x00D17160 File Offset: 0x00D15360
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.RefreshGoodsList));
		}

		// Token: 0x0602EE92 RID: 192146 RVA: 0x00D1717E File Offset: 0x00D1537E
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.RefreshGoodsList));
		}

		// Token: 0x0602EE93 RID: 192147 RVA: 0x00D1719C File Offset: 0x00D1539C
		private List<int> GetLevelList()
		{
			IReadOnlyList<InfrLevel> allLevelConfigs = InfrastructureConfig.Instance.GetAllLevelConfigs();
			List<int> list = new List<int>(allLevelConfigs.Count);
			for (int i = 0; i < allLevelConfigs.Count; i++)
			{
				int level = allLevelConfigs[i].Level;
				if (level > 1)
				{
					list.Add(level);
				}
			}
			list.Sort();
			return list;
		}

		// Token: 0x0602EE94 RID: 192148 RVA: 0x00D171F4 File Offset: 0x00D153F4
		protected override UniTask OnBeforeStartAsync()
		{
			InfrastructureShopMainView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InfrastructureShopMainView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EE95 RID: 192149 RVA: 0x00D17238 File Offset: 0x00D15438
		private UniTask RefreshCaption()
		{
			InfrastructureShopMainView.<RefreshCaption>d__11 <RefreshCaption>d__;
			<RefreshCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshCaption>d__.<>4__this = this;
			<RefreshCaption>d__.<>1__state = -1;
			<RefreshCaption>d__.<>t__builder.Start<InfrastructureShopMainView.<RefreshCaption>d__11>(ref <RefreshCaption>d__);
			return <RefreshCaption>d__.<>t__builder.Task;
		}

		// Token: 0x0602EE96 RID: 192150 RVA: 0x00D1727C File Offset: 0x00D1547C
		private UniTask CreateScrollShopMenuAsync()
		{
			InfrastructureShopMainView.<CreateScrollShopMenuAsync>d__12 <CreateScrollShopMenuAsync>d__;
			<CreateScrollShopMenuAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateScrollShopMenuAsync>d__.<>4__this = this;
			<CreateScrollShopMenuAsync>d__.<>1__state = -1;
			<CreateScrollShopMenuAsync>d__.<>t__builder.Start<InfrastructureShopMainView.<CreateScrollShopMenuAsync>d__12>(ref <CreateScrollShopMenuAsync>d__);
			return <CreateScrollShopMenuAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EE97 RID: 192151 RVA: 0x00D172BF File Offset: 0x00D154BF
		private void CreateScrollShop()
		{
			this.ScrollShop = new GenericScrollViewNew<InfrastructureShopItem, PayShopGoods>(base.GetScrollViewWithScrollbar(3), () => new InfrastructureShopItem(), null, false, null);
		}

		// Token: 0x0602EE98 RID: 192152 RVA: 0x00D172F8 File Offset: 0x00D154F8
		private void OnClickTopShopMenuItem(int id)
		{
			foreach (InfrastructureShopMenuItem infrastructureShopMenuItem in this.TopShopMenu.GetLayoutItemList())
			{
				if (infrastructureShopMenuItem.Level == this.SelectedLevel)
				{
					infrastructureShopMenuItem.SetDeselect();
				}
			}
			this.SelectedLevel = id;
			this.RefreshShop();
		}

		// Token: 0x0602EE99 RID: 192153 RVA: 0x00D1736C File Offset: 0x00D1556C
		protected override void OnStart()
		{
			InfrastructureModel.Instance.RefreshShopHasNewRedDot();
			this.SelectedLevel = this.GetLevelList()[0];
			this.RefreshShop();
			this.RefreshShopMenu();
			foreach (InfrastructureShopMenuItem infrastructureShopMenuItem in this.TopShopMenu.GetLayoutItemList())
			{
				if (infrastructureShopMenuItem.Level == this.SelectedLevel)
				{
					infrastructureShopMenuItem.SetSelect();
				}
			}
		}

		// Token: 0x0602EE9A RID: 192154 RVA: 0x00D173FC File Offset: 0x00D155FC
		private void RefreshShop()
		{
			List<PayShopGoods> shopDataList = InfrastructureModel.Instance.GetShopDataList(this.SelectedLevel, true);
			this.ScrollShop.RefreshByData(shopDataList, null, false);
		}

		// Token: 0x0602EE9B RID: 192155 RVA: 0x00D17429 File Offset: 0x00D15629
		private void RefreshShopMenu()
		{
		}

		// Token: 0x0602EE9C RID: 192156 RVA: 0x00D1742B File Offset: 0x00D1562B
		private void RefreshGoodsList(int goodsId, PayShopDefine.EPayShopTabType payShopId, int tabId)
		{
			this.RefreshShop();
		}

		// Token: 0x04018E17 RID: 101911
		private int SelectedLevel;

		// Token: 0x04018E18 RID: 101912
		private readonly PopupCaptionItem ItemCaption = new PopupCaptionItem(null);

		// Token: 0x04018E19 RID: 101913
		private GenericLayout<InfrastructureShopMenuItem, int> TopShopMenu;

		// Token: 0x04018E1A RID: 101914
		private GenericScrollViewNew<InfrastructureShopItem, PayShopGoods> ScrollShop;

		// Token: 0x0200A5D1 RID: 42449
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04033505 RID: 210181
			public const int ItemCaption = 0;

			// Token: 0x04033506 RID: 210182
			public const int HorizontalPanelTopMenuLayout = 1;

			// Token: 0x04033507 RID: 210183
			public const int TopShopMenuItem = 2;

			// Token: 0x04033508 RID: 210184
			public const int ScrollShop = 3;

			// Token: 0x04033509 RID: 210185
			public const int ShopItem = 4;
		}
	}
}
