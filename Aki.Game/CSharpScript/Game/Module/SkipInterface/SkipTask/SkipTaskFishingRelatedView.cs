using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BAB RID: 19371
	[NullableContext(1)]
	[Nullable(0)]
	public class SkipTaskFishingRelatedView : SkipTask
	{
		// Token: 0x060322D5 RID: 205525 RVA: 0x00BA8B28 File Offset: 0x00BA6D28
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

		// Token: 0x060322D6 RID: 205526 RVA: 0x00BA8BEC File Offset: 0x00BA6DEC
		protected bool CheckMainViewOpen()
		{
			return UiManager.Instance.GetViewByName(EUiViewName.FishingDockView) != null;
		}

		// Token: 0x060322D7 RID: 205527 RVA: 0x00BA8C00 File Offset: 0x00BA6E00
		protected bool CheckIsInSailing()
		{
			FishingShipData shipData = FishingModel.Instance.GetShipData();
			return shipData != null && shipData.IsShipDriving();
		}

		// Token: 0x060322D8 RID: 205528 RVA: 0x00BA8C18 File Offset: 0x00BA6E18
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

		// Token: 0x060322D9 RID: 205529 RVA: 0x00BA8C75 File Offset: 0x00BA6E75
		private void OpenViewInMainView(Action openViewFunc)
		{
			if (this.CheckMainViewOpen())
			{
				openViewFunc();
				return;
			}
			this.SkipToMap();
		}

		// Token: 0x060322DA RID: 205530 RVA: 0x00BA8C8C File Offset: 0x00BA6E8C
		private void OpenViewInMainViewAndSailing(Action openViewFunc)
		{
			if (this.CheckMainViewOpen() || this.CheckIsInSailing())
			{
				openViewFunc();
				return;
			}
			this.SkipToMap();
		}

		// Token: 0x060322DB RID: 205531 RVA: 0x00BA8CAB File Offset: 0x00BA6EAB
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

		// Token: 0x060322DC RID: 205532 RVA: 0x00BA8CDC File Offset: 0x00BA6EDC
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

		// Token: 0x0401AB85 RID: 109445
		private const int DEFAULT_PORT_ID = 1;

		// Token: 0x0401AB86 RID: 109446
		private readonly Action OpenQuestView;

		// Token: 0x0401AB87 RID: 109447
		private readonly Action OpenHandBookView;

		// Token: 0x0401AB88 RID: 109448
		private readonly Action OpenDockyardView;

		// Token: 0x0401AB89 RID: 109449
		private readonly Action OpenShopShopBuyView;

		// Token: 0x0401AB8A RID: 109450
		private readonly Action OpenShopSellView;

		// Token: 0x0200ADCE RID: 44494
		[NullableContext(0)]
		private enum EFishingViewDefine
		{
			// Token: 0x04034C9C RID: 216220
			Quest = 1,
			// Token: 0x04034C9D RID: 216221
			HandBook,
			// Token: 0x04034C9E RID: 216222
			TechView,
			// Token: 0x04034C9F RID: 216223
			WareHouse,
			// Token: 0x04034CA0 RID: 216224
			ShopBuy,
			// Token: 0x04034CA1 RID: 216225
			ShopSell
		}
	}
}
