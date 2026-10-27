using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PayShop.MotorSkinTab
{
	// Token: 0x02005357 RID: 21335
	public class MotorSkinTabView : UiTabViewBase, IUiTabViewRefresh
	{
		// Token: 0x0603682B RID: 223275 RVA: 0x00CE8582 File Offset: 0x00CE6782
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0603682C RID: 223276 RVA: 0x00CE85BC File Offset: 0x00CE67BC
		protected override void OnStart()
		{
			this.CurrentShopId = (int)(this.ExtraParams ?? 0);
			this.TabId = (int)(this.Params ?? 0);
			this.Layout = new LoopScrollView<SkinItemContent, SkinItemContentData>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<SkinItemContent>(this.OnCreateItem), false);
		}

		// Token: 0x0603682D RID: 223277 RVA: 0x00CE862F File Offset: 0x00CE682F
		[NullableContext(1)]
		private SkinItemContent OnCreateItem()
		{
			return new SkinItemContent();
		}

		// Token: 0x0603682E RID: 223278 RVA: 0x00CE8636 File Offset: 0x00CE6836
		protected override void OnBeforeShow()
		{
			this.RefreshLayout();
		}

		// Token: 0x0603682F RID: 223279 RVA: 0x00CE8640 File Offset: 0x00CE6840
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

		// Token: 0x06036830 RID: 223280 RVA: 0x00CE86BB File Offset: 0x00CE68BB
		[NullableContext(2)]
		public void RefreshView(object @params)
		{
		}

		// Token: 0x0401CD44 RID: 118084
		private int CurrentShopId;

		// Token: 0x0401CD45 RID: 118085
		private int TabId;

		// Token: 0x0401CD46 RID: 118086
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<SkinItemContent, SkinItemContentData> Layout;

		// Token: 0x0200B5C1 RID: 46529
		private enum EComponent
		{
			// Token: 0x040370DD RID: 225501
			GridLayout,
			// Token: 0x040370DE RID: 225502
			Item
		}
	}
}
