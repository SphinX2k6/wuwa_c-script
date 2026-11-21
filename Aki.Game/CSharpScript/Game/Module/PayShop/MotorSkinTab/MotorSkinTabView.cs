using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PayShop.MotorSkinTab
{
	// Token: 0x0200433A RID: 17210
	public class MotorSkinTabView : UiTabViewBase, IUiTabViewRefresh
	{
		// Token: 0x0602B771 RID: 178033 RVA: 0x00C3740A File Offset: 0x00C3560A
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0602B772 RID: 178034 RVA: 0x00C37444 File Offset: 0x00C35644
		protected override void OnStart()
		{
			this.CurrentShopId = (int)(this.ExtraParams ?? 0);
			this.TabId = (int)(this.Params ?? 0);
			this.Layout = new LoopScrollView<SkinItemContent, SkinItemContentData>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<SkinItemContent>(this.OnCreateItem), false);
		}

		// Token: 0x0602B773 RID: 178035 RVA: 0x00C374B7 File Offset: 0x00C356B7
		[NullableContext(1)]
		private SkinItemContent OnCreateItem()
		{
			return new SkinItemContent();
		}

		// Token: 0x0602B774 RID: 178036 RVA: 0x00C374BE File Offset: 0x00C356BE
		protected override void OnBeforeShow()
		{
			this.RefreshLayout();
		}

		// Token: 0x0602B775 RID: 178037 RVA: 0x00C374C8 File Offset: 0x00C356C8
		private void RefreshLayout()
		{
			List<PayShopGoods> payShopTabData = PayShopModel.Instance.GetPayShopTabData((PayShopDefine.EPayShopTabType)this.CurrentShopId, this.TabId, true);
			List<SkinItemContentData> list = new List<SkinItemContentData>();
			int count = payShopTabData.Count;
			for (int i = 0; i < count; i++)
			{
				PayShopGoods data = payShopTabData[i];
				SkinItemContentData skinItemContentData = new SkinItemContentData();
				ShopMotorSkinData shopMotorSkinData = ShopMotorSkinData.Create(data);
				skinItemContentData.ShopMotorSkinData = shopMotorSkinData;
				skinItemContentData.AllData = payShopTabData;
				list.Add(skinItemContentData);
			}
			this.Layout.RefreshByData(list, false, null, true);
		}

		// Token: 0x0602B776 RID: 178038 RVA: 0x00C37543 File Offset: 0x00C35743
		[NullableContext(2)]
		public void RefreshView(object @params)
		{
		}

		// Token: 0x040177D8 RID: 96216
		private int CurrentShopId;

		// Token: 0x040177D9 RID: 96217
		private int TabId;

		// Token: 0x040177DA RID: 96218
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<SkinItemContent, SkinItemContentData> Layout;

		// Token: 0x02009FFA RID: 40954
		private enum EComponent
		{
			// Token: 0x04031B35 RID: 203573
			GridLayout,
			// Token: 0x04031B36 RID: 203574
			Item
		}
	}
}
