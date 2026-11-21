using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02004137 RID: 16695
	public class PhantomArenaEntranceShopTabView : UiTabViewBase
	{
		// Token: 0x0602A371 RID: 172913 RVA: 0x00BEB304 File Offset: 0x00BE9504
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0602A372 RID: 172914 RVA: 0x00BEB340 File Offset: 0x00BE9540
		protected override void OnStart()
		{
			this.ActivityId = (int)this.ExtraParams;
			this.ScrollView = new LoopScrollView<PhantomArenaEntranceShopItem, IPayShopUnionData>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<PhantomArenaEntranceShopItem>(this.InitItem), false);
		}

		// Token: 0x0602A373 RID: 172915 RVA: 0x00BEB38E File Offset: 0x00BE958E
		protected override void OnBeforeDestroy()
		{
			this.ScrollView = null;
		}

		// Token: 0x0602A374 RID: 172916 RVA: 0x00BEB397 File Offset: 0x00BE9597
		protected override void OnBeforeShow()
		{
			this.OnRefreshGoods();
		}

		// Token: 0x0602A375 RID: 172917 RVA: 0x00BEB39F File Offset: 0x00BE959F
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.EventRefreshGoods));
		}

		// Token: 0x0602A376 RID: 172918 RVA: 0x00BEB3BD File Offset: 0x00BE95BD
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.EventRefreshGoods));
		}

		// Token: 0x0602A377 RID: 172919 RVA: 0x00BEB3DB File Offset: 0x00BE95DB
		[NullableContext(1)]
		protected PhantomArenaEntranceShopItem InitItem()
		{
			return new PhantomArenaEntranceShopItem();
		}

		// Token: 0x0602A378 RID: 172920 RVA: 0x00BEB3E2 File Offset: 0x00BE95E2
		protected void EventRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType payShopId, int tabId)
		{
			this.OnRefreshGoods();
		}

		// Token: 0x0602A379 RID: 172921 RVA: 0x00BEB3EC File Offset: 0x00BE95EC
		protected void OnRefreshGoods()
		{
			PhantomArenaModel.Instance.OnShopViewOpen(this.ActivityId);
			List<object> shopList = PhantomArenaModel.Instance.GetShopList(this.ActivityId);
			LoopScrollView<PhantomArenaEntranceShopItem, IPayShopUnionData> scrollView = this.ScrollView;
			if (scrollView == null)
			{
				return;
			}
			scrollView.RefreshByData(shopList.ConvertAll<IPayShopUnionData>(([Nullable(1)] object shop) => (IPayShopUnionData)shop), false, null, true);
		}

		// Token: 0x04016FA7 RID: 94119
		protected int ActivityId;

		// Token: 0x04016FA8 RID: 94120
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<PhantomArenaEntranceShopItem, IPayShopUnionData> ScrollView;

		// Token: 0x02009D02 RID: 40194
		private class EComponentDefine
		{
			// Token: 0x04030D0D RID: 199949
			public const int LoopShop = 0;

			// Token: 0x04030D0E RID: 199950
			public const int ShopItem = 1;
		}
	}
}
