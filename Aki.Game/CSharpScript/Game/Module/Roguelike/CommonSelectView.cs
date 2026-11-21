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
	// Token: 0x02003D9B RID: 15771
	[NullableContext(2)]
	[Nullable(0)]
	public class CommonSelectView : RogueSelectBaseView
	{
		// Token: 0x06028521 RID: 165153 RVA: 0x00B4AFBA File Offset: 0x00B491BA
		[NullableContext(1)]
		public CommonSelectView(UiViewInfo Info) : base(Info)
		{
		}

		// Token: 0x06028522 RID: 165154 RVA: 0x00B4AFCC File Offset: 0x00B491CC
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

		// Token: 0x06028523 RID: 165155 RVA: 0x00B4B120 File Offset: 0x00B49320
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

		// Token: 0x06028524 RID: 165156 RVA: 0x00B4B154 File Offset: 0x00B49354
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

		// Token: 0x06028525 RID: 165157 RVA: 0x00B4B1B0 File Offset: 0x00B493B0
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

		// Token: 0x06028526 RID: 165158 RVA: 0x00B4B210 File Offset: 0x00B49410
		protected override UniTask OnBeforeStartAsync()
		{
			CommonSelectView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CommonSelectView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028527 RID: 165159 RVA: 0x00B4B254 File Offset: 0x00B49454
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

		// Token: 0x06028528 RID: 165160 RVA: 0x00B4B369 File Offset: 0x00B49569
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

		// Token: 0x06028529 RID: 165161 RVA: 0x00B4B392 File Offset: 0x00B49592
		[NullableContext(1)]
		protected CommonSelectItem CreateCommonSelectItem()
		{
			CommonSelectItem commonSelectItem = new CommonSelectItem();
			commonSelectItem.SetClickCallBack(new Action<CommonSelectItem>(this.RefreshPreview));
			return commonSelectItem;
		}

		// Token: 0x0602852A RID: 165162 RVA: 0x00B4B3AB File Offset: 0x00B495AB
		protected override void OnBeforeDestroy()
		{
			this.TopPanel.Destroy(null);
			this.ElementPanel.Destroy(null);
			this.PhantomInfoPanel.Destroy(null);
		}

		// Token: 0x0602852B RID: 165163 RVA: 0x00B4B3D4 File Offset: 0x00B495D4
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

		// Token: 0x0602852C RID: 165164 RVA: 0x00B4B4EC File Offset: 0x00B496EC
		protected override void OnDescModelChange()
		{
			foreach (CommonSelectItem commonSelectItem in this.CommonSelectItemLayout.GetLayoutItemList())
			{
				commonSelectItem.RefreshPanel();
			}
			this.RefreshPreview(this.CurSelectItem);
		}

		// Token: 0x0602852D RID: 165165 RVA: 0x00B4B550 File Offset: 0x00B49750
		protected override void RoguelikeRefreshGain(int index)
		{
			RoguelikeModel.Instance.CurrentRogueGainEntry = null;
			RoguelikeChooseData roguelikeChooseDataById = RoguelikeModel.Instance.GetRoguelikeChooseDataById(index);
			this.RoguelikeChooseData = roguelikeChooseDataById;
			this.Refresh();
		}

		// Token: 0x0602852E RID: 165166 RVA: 0x00B4B581 File Offset: 0x00B49781
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

		// Token: 0x0602852F RID: 165167 RVA: 0x00B4B5B3 File Offset: 0x00B497B3
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

		// Token: 0x06028530 RID: 165168 RVA: 0x00B4B5E4 File Offset: 0x00B497E4
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

		// Token: 0x06028531 RID: 165169 RVA: 0x00B4B6D4 File Offset: 0x00B498D4
		protected void RefreshElementPanel()
		{
			this.ElementPanel.Refresh(null);
		}

		// Token: 0x06028532 RID: 165170 RVA: 0x00B4B6E2 File Offset: 0x00B498E2
		protected void RefreshPhantomInfoPanel()
		{
			this.PhantomInfoPanel.Refresh();
		}

		// Token: 0x06028533 RID: 165171 RVA: 0x00B4B6EF File Offset: 0x00B498EF
		protected void RefreshBtnText()
		{
			this.ButtonItem.SetShowText("RoguelikeView_13_Text");
		}

		// Token: 0x06028534 RID: 165172 RVA: 0x00B4B704 File Offset: 0x00B49904
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

		// Token: 0x06028535 RID: 165173 RVA: 0x00B4B8CC File Offset: 0x00B49ACC
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

		// Token: 0x06028536 RID: 165174 RVA: 0x00B4B954 File Offset: 0x00B49B54
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

		// Token: 0x04015E9B RID: 89755
		protected RoguelikeChooseData RoguelikeChooseData;

		// Token: 0x04015E9C RID: 89756
		protected TopPanel TopPanel;

		// Token: 0x04015E9D RID: 89757
		protected ElementPanel ElementPanel;

		// Token: 0x04015E9E RID: 89758
		protected PhantomInfoPanel PhantomInfoPanel;

		// Token: 0x04015E9F RID: 89759
		protected ButtonItem ButtonItem;

		// Token: 0x04015EA0 RID: 89760
		protected ButtonItem RefreshButtonItem;

		// Token: 0x04015EA1 RID: 89761
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<CommonSelectItem, RogueGainEntry> CommonSelectItemLayout;

		// Token: 0x04015EA2 RID: 89762
		protected CommonSelectItem CurSelectItem;

		// Token: 0x04015EA3 RID: 89763
		protected double LastRefreshTime;

		// Token: 0x04015EA4 RID: 89764
		protected bool IsFirstOpen = true;

		// Token: 0x0200997F RID: 39295
		[NullableContext(0)]
		private class ECommonSelectViewCom
		{
			// Token: 0x0402FDCE RID: 196046
			public const int PhantomPanelItem = 0;

			// Token: 0x0402FDCF RID: 196047
			public const int TopPanelItem = 1;

			// Token: 0x0402FDD0 RID: 196048
			public const int CommonSelectItemListLayout = 2;

			// Token: 0x0402FDD1 RID: 196049
			public const int CommonSelectItem = 3;

			// Token: 0x0402FDD2 RID: 196050
			public const int ElementPanelItem = 4;

			// Token: 0x0402FDD3 RID: 196051
			public const int ConfirmBtn = 5;

			// Token: 0x0402FDD4 RID: 196052
			public const int RefreshBtn = 6;

			// Token: 0x0402FDD5 RID: 196053
			public const int RefreshCostTexture = 7;

			// Token: 0x0402FDD6 RID: 196054
			public const int RefreshCostText = 8;
		}
	}
}
