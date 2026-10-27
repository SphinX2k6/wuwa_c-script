using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006F08 RID: 28424
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabDeliveryView : UiViewBase
	{
		// Token: 0x060452FB RID: 283387 RVA: 0x0111D30D File Offset: 0x0111B50D
		public DollGrabDeliveryView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060452FC RID: 283388 RVA: 0x0111D318 File Offset: 0x0111B518
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIText)),
				new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(10, typeof(UUITexture)),
				new ValueTuple<int, Type>(11, typeof(UUITexture)),
				new ValueTuple<int, Type>(12, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(13, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(4, new Action(this.OnClickedConfirmButton)),
				new ValueTuple<int, Delegate>(9, new Action(this.OnClickedBackButton))
			};
		}

		// Token: 0x060452FD RID: 283389 RVA: 0x0111D4A8 File Offset: 0x0111B6A8
		protected override void OnStart()
		{
			UUILayoutBase layout = base.GetItem(3).GetOwner().GetComponentByClass(UUILayoutBase.StaticClass()) as UUILayoutBase;
			this.RewardItemScrollView = new GenericLayout<DollCollectSmallItemGrid, IDollRewardItemData>(layout, new Func<DollCollectSmallItemGrid>(this.OnCreateRewardItem), null, false, true);
			this.ProgressBarSprite = base.GetSprite(0);
			this.Refresh();
		}

		// Token: 0x060452FE RID: 283390 RVA: 0x0111D504 File Offset: 0x0111B704
		private void Refresh()
		{
			this.RefreshProgressBar();
			this.RefreshReward();
			this.RefreshConfirmButton();
		}

		// Token: 0x060452FF RID: 283391 RVA: 0x0111D518 File Offset: 0x0111B718
		private void RefreshReward()
		{
			Dictionary<int, IDollRewardItemData> dictionary = new Dictionary<int, IDollRewardItemData>();
			List<IShowcaseDeliveryReward> deliveryRewards = DollGrabShowcaseController.Instance.DeliveryRewards;
			if (deliveryRewards == null)
			{
				this.RewardItemScrollView.SetActive(false);
				return;
			}
			IDollCollectData collectData = DollGrabShowcaseController.Instance.GetCollectData();
			if (collectData == null)
			{
				return;
			}
			int num = 0;
			List<int> list = new List<int>();
			foreach (IShowcaseDeliveryReward showcaseDeliveryReward in deliveryRewards)
			{
				num += showcaseDeliveryReward.AchievedDollCount;
				list.Add(showcaseDeliveryReward.DropId);
				Dictionary<int, int> dropPackagePreview = RewardConfig.Instance.GetDropPackagePreview(showcaseDeliveryReward.DropId);
				if (dropPackagePreview != null && dropPackagePreview.Count > 0)
				{
					foreach (KeyValuePair<int, int> keyValuePair in dropPackagePreview)
					{
						int num2;
						int num3;
						keyValuePair.Deconstruct(out num2, out num3);
						int num4 = num2;
						int num5 = num3;
						if (!dictionary.ContainsKey(num4))
						{
							dictionary.Add(num4, new IDollRewardItemData
							{
								ItemInfo = InventoryConfig.Instance.GetItemConfigData(num4),
								Count = num5
							});
						}
						else
						{
							dictionary[num4].Count += num5;
						}
					}
				}
			}
			bool flag = collectData.CurrentCollectItemCount >= num;
			List<IDollRewardItemData> list2 = new List<IDollRewardItemData>();
			foreach (IDollRewardItemData item in dictionary.Values)
			{
				list2.Add(item);
			}
			this.RewardItemScrollView.RefreshByData(list2, null, false);
			if (flag)
			{
				int displayGridNum = this.RewardItemScrollView.GetDisplayGridNum();
				for (int i = 0; i < displayGridNum; i++)
				{
					this.RewardItemScrollView.GetLayoutItemByIndex(i).SetReceivableVisible(true);
				}
			}
		}

		// Token: 0x06045300 RID: 283392 RVA: 0x0111D714 File Offset: 0x0111B914
		private DollCollectSmallItemGrid OnCreateRewardItem()
		{
			DollCollectSmallItemGrid dollCollectSmallItemGrid = new DollCollectSmallItemGrid();
			dollCollectSmallItemGrid.BindOnExtendToggleRelease(new Action<MediumItemGridExtendCallback>(this.OnExtendToggleRelease));
			dollCollectSmallItemGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			return dollCollectSmallItemGrid;
		}

		// Token: 0x06045301 RID: 283393 RVA: 0x0111D754 File Offset: 0x0111B954
		private void OnExtendToggleRelease(MediumItemGridExtendCallback callback)
		{
			if (!callback.MediumItemGrid.IsHover)
			{
				return;
			}
			IDollRewardItemData dollRewardItemData = callback.Data as IDollRewardItemData;
			if (dollRewardItemData == null)
			{
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(dollRewardItemData.ItemInfo.Id, true, null);
		}

		// Token: 0x06045302 RID: 283394 RVA: 0x0111D798 File Offset: 0x0111B998
		private void RefreshProgressBar()
		{
			IDollCollectData collectData = DollGrabShowcaseController.Instance.GetCollectData();
			if (collectData == null)
			{
				return;
			}
			int currentCollectItemCount = collectData.CurrentCollectItemCount;
			int totalCollectItemCount = collectData.TotalCollectItemCount;
			UUIText text = base.GetText(2);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(currentCollectItemCount);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(totalCollectItemCount);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			UUISprite progressBarSprite = this.ProgressBarSprite;
			if (progressBarSprite != null)
			{
				progressBarSprite.SetFillAmount((totalCollectItemCount == 0) ? 0f : ((float)currentCollectItemCount / (float)totalCollectItemCount));
			}
			UUIItem item = base.GetItem(13);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(currentCollectItemCount >= totalCollectItemCount);
		}

		// Token: 0x06045303 RID: 283395 RVA: 0x0111D83C File Offset: 0x0111BA3C
		private void RefreshConfirmButton()
		{
			IDollCollectData collectData = DollGrabShowcaseController.Instance.GetCollectData();
			if (collectData == null)
			{
				return;
			}
			if (collectData.CurrentCollectCount >= collectData.TotalCollectCount)
			{
				UUIText text = base.GetText(5);
				if (text != null)
				{
					text.ShowTextNew("KClawDeliver_Btn_Complete_Text");
				}
				UUIButtonComponent button = base.GetButton(4);
				if (button != null)
				{
					button.SetSelfInteractive(false);
				}
				object obj;
				if (button == null)
				{
					obj = null;
				}
				else
				{
					AActor owner = button.GetOwner();
					obj = ((owner != null) ? owner.GetComponentByClass(UUIItem.StaticClass()) : null);
				}
				UUIItem uuiitem = obj as UUIItem;
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(false);
				}
				this.RefreshCountText(0);
				return;
			}
			int deliveryItemCount = this.GetDeliveryItemCount();
			this.RefreshCountText(deliveryItemCount);
			if (deliveryItemCount > 0)
			{
				UUIText text2 = base.GetText(5);
				if (text2 != null)
				{
					text2.ShowTextNew("KClawDeliver_Btn_Text");
				}
				UUIButtonComponent button2 = base.GetButton(4);
				if (button2 == null)
				{
					return;
				}
				button2.SetSelfInteractive(true);
				return;
			}
			else
			{
				UUIText text3 = base.GetText(5);
				if (text3 != null)
				{
					text3.ShowTextNew("KClawDeliver_Btn_Lack_Text");
				}
				UUIButtonComponent button3 = base.GetButton(4);
				if (button3 == null)
				{
					return;
				}
				button3.SetSelfInteractive(false);
				return;
			}
		}

		// Token: 0x06045304 RID: 283396 RVA: 0x0111D938 File Offset: 0x0111BB38
		private int GetDeliveryItemCount()
		{
			int num = 0;
			foreach (int itemConfigId in DollGrabShowcaseController.Instance.GetShowcaseBindingItemIds())
			{
				if (InventoryModel.Instance.GetItemCountByConfigId(itemConfigId, 0) > 0)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06045305 RID: 283397 RVA: 0x0111D9A0 File Offset: 0x0111BBA0
		private void RefreshCountText(int count)
		{
			UUIText text = base.GetText(7);
			if (text == null)
			{
				return;
			}
			text.SetText(count.ToString(), true);
		}

		// Token: 0x06045306 RID: 283398 RVA: 0x0111D9BC File Offset: 0x0111BBBC
		private void OnClickedConfirmButton()
		{
			if (this.IsRequesting)
			{
				return;
			}
			this.IsRequesting = true;
			UUIButtonComponent button = base.GetButton(4);
			if (button != null)
			{
				button.SetSelfInteractive(false);
			}
			UUIButtonComponent button2 = base.GetButton(9);
			if (button2 != null)
			{
				button2.SetSelfInteractive(false);
			}
			EventSystem.Instance.Once<bool, bool>(EEventName.OnDollGrabMachineDelivery, new Action<bool, bool>(this.OnDollGrabMachineDelivery));
			EventSystem.Instance.Once<bool>(EEventName.OnDollGrabMachineDeliveryFinish, new Action<bool>(this.OnDollGrabMachineDeliveryFinish));
			DollGrabShowcaseController.Instance.OnClickDelivery();
		}

		// Token: 0x06045307 RID: 283399 RVA: 0x0111DA42 File Offset: 0x0111BC42
		private void OnDollGrabMachineDelivery(bool isAlreadyFirst, bool isComplete)
		{
			this.IsRequesting = false;
			this.Refresh();
		}

		// Token: 0x06045308 RID: 283400 RVA: 0x0111DA51 File Offset: 0x0111BC51
		private void OnDollGrabMachineDeliveryFinish(bool isSuccess)
		{
			if (isSuccess)
			{
				DollGrabShowcaseController.Instance.StartDollGrabShowcaseViewByDelivery();
				return;
			}
			base.GetButton(4).SetSelfInteractive(true);
			base.GetButton(9).SetSelfInteractive(true);
		}

		// Token: 0x06045309 RID: 283401 RVA: 0x0111DA7C File Offset: 0x0111BC7C
		private void OnClickedBackButton()
		{
			base.CloseMe(null);
		}

		// Token: 0x040240EE RID: 147694
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DollCollectSmallItemGrid, IDollRewardItemData> RewardItemScrollView;

		// Token: 0x040240EF RID: 147695
		[Nullable(2)]
		private UUISprite ProgressBarSprite;

		// Token: 0x040240F0 RID: 147696
		private bool IsRequesting;
	}
}
