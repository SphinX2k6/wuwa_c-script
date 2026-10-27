using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02005167 RID: 20839
	public class PhantomArenaEntranceShopTabView : UiTabViewBase
	{
		// Token: 0x06035475 RID: 218229 RVA: 0x00C9DDD4 File Offset: 0x00C9BFD4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x06035476 RID: 218230 RVA: 0x00C9DE10 File Offset: 0x00C9C010
		protected override void OnStart()
		{
			this.ActivityId = (int)this.ExtraParams;
			this.ScrollView = new LoopScrollView<PhantomArenaEntranceShopItem, IPayShopUnionData>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<PhantomArenaEntranceShopItem>(this.InitItem), false);
		}

		// Token: 0x06035477 RID: 218231 RVA: 0x00C9DE5E File Offset: 0x00C9C05E
		protected override void OnBeforeDestroy()
		{
			this.ScrollView = null;
		}

		// Token: 0x06035478 RID: 218232 RVA: 0x00C9DE67 File Offset: 0x00C9C067
		protected override void OnBeforeShow()
		{
			this.OnRefreshGoods();
		}

		// Token: 0x06035479 RID: 218233 RVA: 0x00C9DE6F File Offset: 0x00C9C06F
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.EventRefreshGoods));
		}

		// Token: 0x0603547A RID: 218234 RVA: 0x00C9DE8D File Offset: 0x00C9C08D
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.EventRefreshGoods));
		}

		// Token: 0x0603547B RID: 218235 RVA: 0x00C9DEAB File Offset: 0x00C9C0AB
		[NullableContext(1)]
		protected PhantomArenaEntranceShopItem InitItem()
		{
			return new PhantomArenaEntranceShopItem();
		}

		// Token: 0x0603547C RID: 218236 RVA: 0x00C9DEB2 File Offset: 0x00C9C0B2
		protected void EventRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType payShopId, int tabId)
		{
			this.OnRefreshGoods();
		}

		// Token: 0x0603547D RID: 218237 RVA: 0x00C9DEBC File Offset: 0x00C9C0BC
		protected void OnRefreshGoods()
		{
			PhantomArenaModel.Instance.OnShopViewOpen(this.ActivityId);
			List<object> shopList = PhantomArenaModel.Instance.GetShopList(this.ActivityId);
			LoopScrollView<PhantomArenaEntranceShopItem, IPayShopUnionData> scrollView = this.ScrollView;
			if (scrollView == null)
			{
				return;
			}
			scrollView.RefreshByData(shopList.Cast<IPayShopUnionData>().ToList<IPayShopUnionData>(), false, null, true);
		}

		// Token: 0x0401C572 RID: 116082
		protected int ActivityId;

		// Token: 0x0401C573 RID: 116083
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<PhantomArenaEntranceShopItem, IPayShopUnionData> ScrollView;

		// Token: 0x0200B2C9 RID: 45769
		private class EComponentDefine
		{
			// Token: 0x040362B8 RID: 221880
			public const int LoopShop = 0;

			// Token: 0x040362B9 RID: 221881
			public const int ShopItem = 1;
		}
	}
}
