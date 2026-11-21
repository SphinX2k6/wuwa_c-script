using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B55 RID: 15189
	[NullableContext(1)]
	[Nullable(0)]
	public class SkipTaskFishingRelatedView : SkipTask
	{
		// Token: 0x06027066 RID: 159846 RVA: 0x00AECD9C File Offset: 0x00AEAF9C
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			string s = (string)data[0];
			string param1 = (string)data[1];
			string param2 = (string)data[2];
			switch (int.Parse(s))
			{
			case 1:
				this.OpenViewInMainViewAndSailing(this.OpenQuestView);
				break;
			case 2:
				this.OpenViewInMainViewAndSailing(this.OpenHandBookView);
				break;
			case 3:
				this.OpenViewInMainView(delegate
				{
					if (this.CheckViewExistAndReset(EUiViewName.FishingTechRootView))
					{
						return;
					}
					int type = int.Parse(param1);
					int nodeId = int.Parse(param2);
					FishingTechOpenParam param = new FishingTechOpenParam
					{
						Type = type,
						NodeId = nodeId
					};
					UiManager.Instance.OpenView(EUiViewName.FishingTechRootView, param, null);
				});
				break;
			case 4:
				this.OpenViewInMainViewAndSailing(this.OpenDockyardView);
				break;
			case 5:
				this.OpenViewInMainView(this.OpenShopShopBuyView);
				break;
			case 6:
				this.OpenViewInMainView(this.OpenShopSellView);
				break;
			}
			base.Finish();
		}

		// Token: 0x06027067 RID: 159847 RVA: 0x00AECE60 File Offset: 0x00AEB060
		protected bool CheckMainViewOpen()
		{
			return UiManager.Instance.GetViewByName(EUiViewName.FishingDockView) != null;
		}

		// Token: 0x06027068 RID: 159848 RVA: 0x00AECE74 File Offset: 0x00AEB074
		protected bool CheckIsInSailing()
		{
			FishingShipData shipData = FishingModel.Instance.GetShipData();
			return shipData != null && shipData.IsShipDriving();
		}

		// Token: 0x06027069 RID: 159849 RVA: 0x00AECE8C File Offset: 0x00AEB08C
		protected void SkipToMap()
		{
			int num = FishingModel.Instance.GetShipData().GetLastPortId();
			if (num <= 0)
			{
				num = 1;
			}
			FishingPort fishingPortConfig = FishingConfig.Instance.GetFishingPortConfig(num);
			WorldMapViewOpenParams data = new WorldMapViewOpenParams
			{
				MarkId = new int?(fishingPortConfig.MarkId),
				MarkType = EMarkType.FishingDock
			};
			WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data, null);
		}

		// Token: 0x0602706A RID: 159850 RVA: 0x00AECEE9 File Offset: 0x00AEB0E9
		private void OpenViewInMainView(Action openViewFunc)
		{
			if (this.CheckMainViewOpen())
			{
				openViewFunc();
				return;
			}
			this.SkipToMap();
		}

		// Token: 0x0602706B RID: 159851 RVA: 0x00AECF00 File Offset: 0x00AEB100
		private void OpenViewInMainViewAndSailing(Action openViewFunc)
		{
			if (this.CheckMainViewOpen() || this.CheckIsInSailing())
			{
				openViewFunc();
				return;
			}
			this.SkipToMap();
		}

		// Token: 0x0602706C RID: 159852 RVA: 0x00AECF1F File Offset: 0x00AEB11F
		private bool CheckViewExistAndReset(EUiViewName viewName)
		{
			if (UiManager.Instance.IsViewOpen(viewName))
			{
				return true;
			}
			if (UiManager.Instance.GetViewByName(viewName) != null)
			{
				UiManager.Instance.NormalResetToView(viewName, null, true);
				return true;
			}
			return false;
		}

		// Token: 0x0602706D RID: 159853 RVA: 0x00AECF50 File Offset: 0x00AEB150
		public SkipTaskFishingRelatedView()
		{
			this.OpenQuestView = delegate()
			{
				if (this.CheckViewExistAndReset(EUiViewName.FishingQuestView))
				{
					return;
				}
				UiManager.Instance.OpenView(EUiViewName.FishingQuestView, null, null);
			};
			this.OpenHandBookView = delegate()
			{
				if (this.CheckViewExistAndReset(EUiViewName.FishingHandBookView))
				{
					return;
				}
				UiManager.Instance.OpenView(EUiViewName.FishingHandBookView, null, null);
			};
			this.OpenDockyardView = delegate()
			{
				if (this.CheckViewExistAndReset(EUiViewName.DockyardView))
				{
					return;
				}
				FishingController.Instance.OpenDockyardView();
			};
			this.OpenShopShopBuyView = delegate()
			{
				if (this.CheckViewExistAndReset(EUiViewName.DockyardShopMainView))
				{
					return;
				}
				FishingController.Instance.OpenDockyardShopView(new EDockyardShopTabType?(EDockyardShopTabType.Buy));
			};
			this.OpenShopSellView = delegate()
			{
				if (this.CheckViewExistAndReset(EUiViewName.DockyardShopMainView))
				{
					return;
				}
				FishingController.Instance.OpenDockyardShopView(new EDockyardShopTabType?(EDockyardShopTabType.Sell));
			};
		}

		// Token: 0x040154DA RID: 87258
		private const int DEFAULT_PORT_ID = 1;

		// Token: 0x040154DB RID: 87259
		private readonly Action OpenQuestView;

		// Token: 0x040154DC RID: 87260
		private readonly Action OpenHandBookView;

		// Token: 0x040154DD RID: 87261
		private readonly Action OpenDockyardView;

		// Token: 0x040154DE RID: 87262
		private readonly Action OpenShopShopBuyView;

		// Token: 0x040154DF RID: 87263
		private readonly Action OpenShopSellView;

		// Token: 0x020097ED RID: 38893
		[NullableContext(0)]
		private enum EFishingViewDefine
		{
			// Token: 0x0402F643 RID: 194115
			Quest = 1,
			// Token: 0x0402F644 RID: 194116
			HandBook,
			// Token: 0x0402F645 RID: 194117
			TechView,
			// Token: 0x0402F646 RID: 194118
			WareHouse,
			// Token: 0x0402F647 RID: 194119
			ShopBuy,
			// Token: 0x0402F648 RID: 194120
			ShopSell
		}
	}
}
