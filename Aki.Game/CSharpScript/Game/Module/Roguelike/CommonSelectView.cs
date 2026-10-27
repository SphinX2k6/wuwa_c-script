using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DD2 RID: 19922
	[NullableContext(2)]
	[Nullable(0)]
	public class CommonSelectView : RogueSelectBaseView
	{
		// Token: 0x060336B4 RID: 210612 RVA: 0x00C01A62 File Offset: 0x00BFFC62
		[NullableContext(1)]
		public CommonSelectView(UiViewInfo Info) : base(Info)
		{
		}

		// Token: 0x060336B5 RID: 210613 RVA: 0x00C01A74 File Offset: 0x00BFFC74
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060336B6 RID: 210614 RVA: 0x00C01BC8 File Offset: 0x00BFFDC8
		private void ConfirmBtn(int _)
		{
			CommonSelectItem commonSelectItem = this.GetCommonSelectItem();
			if (commonSelectItem == null)
			{
				return;
			}
			RoguelikeModel.Instance.CurrentRogueGainEntry = commonSelectItem.RogueGainEntry;
			RoguelikeController.Instance.RogueChooseDataResultRequest(EPerkType.Phantom);
		}

		// Token: 0x060336B7 RID: 210615 RVA: 0x00C01BFC File Offset: 0x00BFFDFC
		private void RefreshBtn(int _)
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			if (serverTime - this.LastRefreshTime < 1.0 && this.LastRefreshTime != 0.0)
			{
				return;
			}
			this.LastRefreshTime = serverTime;
			RoguelikeController.Instance.RoguelikeRefreshGainRequest(this.RoguelikeChooseData.Index);
		}

		// Token: 0x060336B8 RID: 210616 RVA: 0x00C01C58 File Offset: 0x00BFFE58
		private CommonSelectItem GetCommonSelectItem()
		{
			foreach (CommonSelectItem commonSelectItem in this.CommonSelectItemLayout.GetLayoutItemList())
			{
				if (commonSelectItem.IsSelect())
				{
					return commonSelectItem;
				}
			}
			return null;
		}

		// Token: 0x060336B9 RID: 210617 RVA: 0x00C01CB8 File Offset: 0x00BFFEB8
		protected override UniTask OnBeforeStartAsync()
		{
			CommonSelectView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CommonSelectView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060336BA RID: 210618 RVA: 0x00C01CFC File Offset: 0x00BFFEFC
		protected unsafe override void OnStart()
		{
			RoguelikeModel.Instance.CurrentRogueGainEntry = null;
			this.RoguelikeChooseData = (this.OpenParam as RoguelikeChooseData);
			this.TopPanel.CloseCallback = new Action(base.CloseMySelf);
			this.PhantomInfoPanel.Update(RoguelikeModel.Instance.RogueInfo.PhantomEntry);
			this.ButtonItem = new ButtonItem(base.GetButton(5).GetRootComponent());
			this.ButtonItem.SetFunction(new Action<int>(this.ConfirmBtn));
			this.RefreshButtonItem = new ButtonItem(base.GetButton(6).GetRootComponent());
			this.RefreshButtonItem.SetFunction(new Action<int>(this.RefreshBtn));
			this.CommonSelectItemLayout = new GenericLayout<CommonSelectItem, RogueGainEntry>(base.GetHorizontalLayout(2), new Func<CommonSelectItem>(this.CreateCommonSelectItem), null, false, true);
			TopPanel topPanel = this.TopPanel;
			if (topPanel != null)
			{
				int num = 1;
				List<int> list = new List<int>(num);
				CollectionsMarshal.SetCount<int>(list, num);
				Span<int> span = CollectionsMarshal.AsSpan<int>(list);
				int index = 0;
				*span[index] = 80100000;
				topPanel.RefreshCurrency(list);
			}
			this.Refresh();
		}

		// Token: 0x060336BB RID: 210619 RVA: 0x00C01E11 File Offset: 0x00C00011
		protected override void OnBeforeShow()
		{
			if (!this.IsFirstOpen)
			{
				TopPanel topPanel = this.TopPanel;
				if (topPanel != null)
				{
					topPanel.RefreshTabBtn();
				}
				this.OnDescModelChange();
				return;
			}
			this.IsFirstOpen = false;
		}

		// Token: 0x060336BC RID: 210620 RVA: 0x00C01E3A File Offset: 0x00C0003A
		[NullableContext(1)]
		protected CommonSelectItem CreateCommonSelectItem()
		{
			CommonSelectItem commonSelectItem = new CommonSelectItem();
			commonSelectItem.SetClickCallBack(new Action<CommonSelectItem>(this.RefreshPreview));
			return commonSelectItem;
		}

		// Token: 0x060336BD RID: 210621 RVA: 0x00C01E53 File Offset: 0x00C00053
		protected override void OnBeforeDestroy()
		{
			this.TopPanel.Destroy(null);
			this.ElementPanel.Destroy(null);
			this.PhantomInfoPanel.Destroy(null);
		}

		// Token: 0x060336BE RID: 210622 RVA: 0x00C01E7C File Offset: 0x00C0007C
		[NullableContext(1)]
		protected override void RoguelikeChooseDataResult(RogueGainEntry newRogueGainEntry, RogueGainEntry oldRogueGainEntry, bool isSuccess, int bindId, RoguelikeChooseDataResultResponse response)
		{
			if (isSuccess)
			{
				RoguelikeChooseData roguelikeChooseData = this.RoguelikeChooseData;
				int? num = (roguelikeChooseData != null) ? new int?(roguelikeChooseData.Index) : null;
				if (bindId == num.GetValueOrDefault() & num != null)
				{
					CommonSelectItem commonSelectItem = this.GetCommonSelectItem();
					if (commonSelectItem == null)
					{
						return;
					}
					RogueSelectResult rogueSelectResult = new RogueSelectResult(newRogueGainEntry, oldRogueGainEntry, commonSelectItem.RogueGainEntry, false);
					bool flag = response.ExtraRogueGainEntrys.Count > 0;
					if (flag)
					{
						rogueSelectResult.IsShowCommon = true;
						using (IEnumerator<RogueGainEntry> enumerator = response.ExtraRogueGainEntrys.GetEnumerator())
						{
							if (enumerator.MoveNext())
							{
								RogueGainEntry rogueGainEntry = enumerator.Current;
								rogueSelectResult.ExtraRogueGainEntry = new RogueGainEntry(rogueGainEntry, null);
							}
						}
					}
					if (rogueSelectResult.GetNewUnlockAffixEntry().Count <= 0 && !flag)
					{
						UiManager.Instance.CloseView(this.ViewInfo.Name, null);
						return;
					}
					UiManager.Instance.OpenView(EUiViewName.CommonSelectResultView, rogueSelectResult, delegate(bool _, int _)
					{
						base.CloseMe(null);
					});
					return;
				}
			}
		}

		// Token: 0x060336BF RID: 210623 RVA: 0x00C01F94 File Offset: 0x00C00194
		protected override void OnDescModelChange()
		{
			foreach (CommonSelectItem commonSelectItem in this.CommonSelectItemLayout.GetLayoutItemList())
			{
				commonSelectItem.RefreshPanel();
			}
			this.RefreshPreview(this.CurSelectItem);
		}

		// Token: 0x060336C0 RID: 210624 RVA: 0x00C01FF8 File Offset: 0x00C001F8
		protected override void RoguelikeRefreshGain(int index)
		{
			RoguelikeModel.Instance.CurrentRogueGainEntry = null;
			RoguelikeChooseData roguelikeChooseDataById = RoguelikeModel.Instance.GetRoguelikeChooseDataById(index);
			this.RoguelikeChooseData = roguelikeChooseDataById;
			this.Refresh();
		}

		// Token: 0x060336C1 RID: 210625 RVA: 0x00C02029 File Offset: 0x00C00229
		private void Refresh()
		{
			this.RefreshPhantomSelectItemList();
			this.RefreshTopPanel();
			this.RefreshElementPanel();
			this.RefreshPhantomInfoPanel();
			this.RefreshPreview(this.CurSelectItem);
			this.RefreshBtnText();
			this.RefreshRefreshBtnText();
		}

		// Token: 0x060336C2 RID: 210626 RVA: 0x00C0205B File Offset: 0x00C0025B
		protected void RefreshPhantomSelectItemList()
		{
			this.CommonSelectItemLayout.RefreshByData(this.RoguelikeChooseData.RogueGainEntryList ?? new List<RogueGainEntry>(), delegate
			{
				GenericLayout<CommonSelectItem, RogueGainEntry> commonSelectItemLayout = this.CommonSelectItemLayout;
				if (commonSelectItemLayout == null)
				{
					return;
				}
				UUIInturnAnimController uiAnimController = commonSelectItemLayout.GetUiAnimController();
				if (uiAnimController == null)
				{
					return;
				}
				uiAnimController.Play("", -1, false);
			}, false);
		}

		// Token: 0x060336C3 RID: 210627 RVA: 0x00C0208C File Offset: 0x00C0028C
		protected void RefreshTopPanel()
		{
			bool flag = false;
			foreach (RogueGainEntry rogueGainEntry in this.RoguelikeChooseData.RogueGainEntryList)
			{
				RogueBuffPool? rogueBuffConfig = RoguelikeConfig.Instance.GetRogueBuffConfig(rogueGainEntry.ConfigId);
				if (rogueBuffConfig != null && rogueBuffConfig.GetValueOrDefault().PerkType == 5)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				this.TopPanel.RefreshTitle("RoguelikeView_11_Text");
				this.TopPanel.RefreshSelectTipsText("RoguelikeView_12_Text", false, Array.Empty<object>());
				return;
			}
			this.TopPanel.RefreshTitle("RoguelikeView_9_Text");
			this.TopPanel.RefreshSelectTipsText("RoguelikeView_10_Text", false, new object[]
			{
				SceneTeamModel.Instance.GetTeamLength() - 1
			});
		}

		// Token: 0x060336C4 RID: 210628 RVA: 0x00C0217C File Offset: 0x00C0037C
		protected void RefreshElementPanel()
		{
			this.ElementPanel.Refresh(null);
		}

		// Token: 0x060336C5 RID: 210629 RVA: 0x00C0218A File Offset: 0x00C0038A
		protected void RefreshPhantomInfoPanel()
		{
			this.PhantomInfoPanel.Refresh();
		}

		// Token: 0x060336C6 RID: 210630 RVA: 0x00C02197 File Offset: 0x00C00397
		protected void RefreshBtnText()
		{
			this.ButtonItem.SetShowText("RoguelikeView_13_Text");
		}

		// Token: 0x060336C7 RID: 210631 RVA: 0x00C021AC File Offset: 0x00C003AC
		protected void RefreshRefreshBtnText()
		{
			int? useTime = this.RoguelikeChooseData.UseTime;
			int? maxTime = this.RoguelikeChooseData.MaxTime;
			UiPanelBase refreshButtonItem = this.RefreshButtonItem;
			int? num = maxTime;
			int num2 = 0;
			refreshButtonItem.SetActive(num.GetValueOrDefault() > num2 & num != null);
			int? num3 = maxTime - useTime;
			int? num4 = num3;
			num2 = 0;
			if (num4.GetValueOrDefault() <= num2 & num4 != null)
			{
				this.RefreshButtonItem.SetLocalTextNew("RoguelikeView_29_Text", new object[]
				{
					num3,
					maxTime
				});
			}
			else
			{
				this.RefreshButtonItem.SetLocalTextNew("RoguelikeView_28_Text", new object[]
				{
					num3,
					maxTime
				});
			}
			IReadOnlyList<NumItem> costCurrency = this.RoguelikeChooseData.CostCurrency;
			if (costCurrency.Count > 0)
			{
				NumItem numItem = costCurrency[0];
				bool flag = InventoryModel.Instance.GetItemCountByConfigId(numItem.Id, 0) >= numItem.Count;
				string textStringId = flag ? "RogueSpecialRefreshCost" : "RogueSpecialRefreshCost_Not";
				LguiUtil.Instance.SetLocalTextNew(base.GetText(8), textStringId, new <>z__ReadOnlySingleElementList<object>(numItem.Count));
				ButtonItem refreshButtonItem2 = this.RefreshButtonItem;
				num4 = num3;
				num2 = 0;
				refreshButtonItem2.SetEnableClick((num4.GetValueOrDefault() > num2 & num4 != null) && flag);
				base.SetTextureByPath(RoguelikeConfig.Instance.GetRogueCurrencyConfig(numItem.Id).Value.IconSmall, base.GetTexture(7), null, null);
			}
		}

		// Token: 0x060336C8 RID: 210632 RVA: 0x00C02374 File Offset: 0x00C00574
		protected void RefreshPreview(CommonSelectItem selectItem = null)
		{
			if (selectItem == null)
			{
				this.ButtonItem.SetEnableClick(false);
				this.PhantomInfoPanel.RefreshPhantomEntryItemRefreshPreview(null);
				this.ElementPanel.Refresh(null);
				return;
			}
			this.CurSelectItem = (selectItem.IsSelect() ? selectItem : null);
			this.ButtonItem.SetEnableClick(selectItem.IsSelect());
			RogueGainEntry rogueGainEntry = (selectItem != null) ? selectItem.RogueGainEntry : null;
			this.PhantomInfoPanel.RefreshPhantomEntryItemRefreshPreview((rogueGainEntry != null) ? rogueGainEntry.ElementDict : null);
			this.ElementPanel.Refresh(rogueGainEntry);
		}

		// Token: 0x060336C9 RID: 210633 RVA: 0x00C023FC File Offset: 0x00C005FC
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			int num;
			if (configParams.Length != 2 && int.TryParse(configParams[0], out num))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Guide;
				ELogAuthor author = ELogAuthor.JT;
				string message = "聚焦引导extraParam项配置有误";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configParams", configParams);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			UUIItem uuiitem = null;
			if (configParams[1] == "Attribute")
			{
				PhantomInfoPanel phantomInfoPanel = this.PhantomInfoPanel;
				uuiitem = ((phantomInfoPanel != null) ? phantomInfoPanel.GetAttributeItem(int.Parse(configParams[0])) : null);
			}
			else if (configParams[1] == "Cost")
			{
				TopPanel topPanel = this.TopPanel;
				uuiitem = ((topPanel != null) ? topPanel.GetCostItemByIndex(int.Parse(configParams[0])) : null);
			}
			if (uuiitem != null)
			{
				return new UUIItem[]
				{
					uuiitem,
					uuiitem
				};
			}
			return null;
		}

		// Token: 0x0401B4C8 RID: 111816
		protected RoguelikeChooseData RoguelikeChooseData;

		// Token: 0x0401B4C9 RID: 111817
		protected TopPanel TopPanel;

		// Token: 0x0401B4CA RID: 111818
		protected ElementPanel ElementPanel;

		// Token: 0x0401B4CB RID: 111819
		protected PhantomInfoPanel PhantomInfoPanel;

		// Token: 0x0401B4CC RID: 111820
		protected ButtonItem ButtonItem;

		// Token: 0x0401B4CD RID: 111821
		protected ButtonItem RefreshButtonItem;

		// Token: 0x0401B4CE RID: 111822
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<CommonSelectItem, RogueGainEntry> CommonSelectItemLayout;

		// Token: 0x0401B4CF RID: 111823
		protected CommonSelectItem CurSelectItem;

		// Token: 0x0401B4D0 RID: 111824
		protected double LastRefreshTime;

		// Token: 0x0401B4D1 RID: 111825
		protected bool IsFirstOpen = true;

		// Token: 0x0200AF4A RID: 44874
		[NullableContext(0)]
		private class ECommonSelectViewCom
		{
			// Token: 0x04035399 RID: 218009
			public const int PhantomPanelItem = 0;

			// Token: 0x0403539A RID: 218010
			public const int TopPanelItem = 1;

			// Token: 0x0403539B RID: 218011
			public const int CommonSelectItemListLayout = 2;

			// Token: 0x0403539C RID: 218012
			public const int CommonSelectItem = 3;

			// Token: 0x0403539D RID: 218013
			public const int ElementPanelItem = 4;

			// Token: 0x0403539E RID: 218014
			public const int ConfirmBtn = 5;

			// Token: 0x0403539F RID: 218015
			public const int RefreshBtn = 6;

			// Token: 0x040353A0 RID: 218016
			public const int RefreshCostTexture = 7;

			// Token: 0x040353A1 RID: 218017
			public const int RefreshCostText = 8;
		}
	}
}
