using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02005924 RID: 22820
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrastructureShopMainView : UiViewBase
	{
		// Token: 0x06039F6C RID: 237420 RVA: 0x00DC7D56 File Offset: 0x00DC5F56
		public InfrastructureShopMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06039F6D RID: 237421 RVA: 0x00DC7D6C File Offset: 0x00DC5F6C
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

		// Token: 0x06039F6E RID: 237422 RVA: 0x00DC7E38 File Offset: 0x00DC6038
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.RefreshGoodsList));
		}

		// Token: 0x06039F6F RID: 237423 RVA: 0x00DC7E56 File Offset: 0x00DC6056
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.RefreshGoodsList));
		}

		// Token: 0x06039F70 RID: 237424 RVA: 0x00DC7E74 File Offset: 0x00DC6074
		private List<int> GetLevelList()
		{
			return (from item in InfrastructureConfig.Instance.GetAllLevelConfigs()
			where item.Level > 1
			select item.Level into level
			orderby level
			select level).ToList<int>();
		}

		// Token: 0x06039F71 RID: 237425 RVA: 0x00DC7EFC File Offset: 0x00DC60FC
		protected override UniTask OnBeforeStartAsync()
		{
			InfrastructureShopMainView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InfrastructureShopMainView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039F72 RID: 237426 RVA: 0x00DC7F40 File Offset: 0x00DC6140
		private UniTask RefreshCaption()
		{
			InfrastructureShopMainView.<RefreshCaption>d__11 <RefreshCaption>d__;
			<RefreshCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshCaption>d__.<>4__this = this;
			<RefreshCaption>d__.<>1__state = -1;
			<RefreshCaption>d__.<>t__builder.Start<InfrastructureShopMainView.<RefreshCaption>d__11>(ref <RefreshCaption>d__);
			return <RefreshCaption>d__.<>t__builder.Task;
		}

		// Token: 0x06039F73 RID: 237427 RVA: 0x00DC7F84 File Offset: 0x00DC6184
		private UniTask CreateScrollShopMenuAsync()
		{
			InfrastructureShopMainView.<CreateScrollShopMenuAsync>d__12 <CreateScrollShopMenuAsync>d__;
			<CreateScrollShopMenuAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateScrollShopMenuAsync>d__.<>4__this = this;
			<CreateScrollShopMenuAsync>d__.<>1__state = -1;
			<CreateScrollShopMenuAsync>d__.<>t__builder.Start<InfrastructureShopMainView.<CreateScrollShopMenuAsync>d__12>(ref <CreateScrollShopMenuAsync>d__);
			return <CreateScrollShopMenuAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039F74 RID: 237428 RVA: 0x00DC7FC7 File Offset: 0x00DC61C7
		private void CreateScrollShop()
		{
			this.ScrollShop = new GenericScrollViewNew<InfrastructureShopItem, PayShopGoods>(base.GetScrollViewWithScrollbar(3), () => new InfrastructureShopItem(), null, false, null);
		}

		// Token: 0x06039F75 RID: 237429 RVA: 0x00DC8000 File Offset: 0x00DC6200
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

		// Token: 0x06039F76 RID: 237430 RVA: 0x00DC8074 File Offset: 0x00DC6274
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

		// Token: 0x06039F77 RID: 237431 RVA: 0x00DC8104 File Offset: 0x00DC6304
		private void RefreshShop()
		{
			List<PayShopGoods> shopDataList = InfrastructureModel.Instance.GetShopDataList(this.SelectedLevel, true);
			this.ScrollShop.RefreshByData(shopDataList, null, false);
		}

		// Token: 0x06039F78 RID: 237432 RVA: 0x00DC8131 File Offset: 0x00DC6331
		private void RefreshShopMenu()
		{
		}

		// Token: 0x06039F79 RID: 237433 RVA: 0x00DC8133 File Offset: 0x00DC6333
		private void RefreshGoodsList(int goodsId, PayShopDefine.EPayShopTabType payShopId, int tabId)
		{
			this.RefreshShop();
		}

		// Token: 0x0401E37A RID: 123770
		private int SelectedLevel;

		// Token: 0x0401E37B RID: 123771
		private readonly PopupCaptionItem ItemCaption = new PopupCaptionItem(null);

		// Token: 0x0401E37C RID: 123772
		private GenericLayout<InfrastructureShopMenuItem, int> TopShopMenu;

		// Token: 0x0401E37D RID: 123773
		private GenericScrollViewNew<InfrastructureShopItem, PayShopGoods> ScrollShop;

		// Token: 0x0200BBC2 RID: 48066
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04038B23 RID: 232227
			public const int ItemCaption = 0;

			// Token: 0x04038B24 RID: 232228
			public const int HorizontalPanelTopMenuLayout = 1;

			// Token: 0x04038B25 RID: 232229
			public const int TopShopMenuItem = 2;

			// Token: 0x04038B26 RID: 232230
			public const int ScrollShop = 3;

			// Token: 0x04038B27 RID: 232231
			public const int ShopItem = 4;
		}
	}
}
