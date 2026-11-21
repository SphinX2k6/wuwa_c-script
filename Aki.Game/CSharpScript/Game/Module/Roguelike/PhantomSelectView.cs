using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DBA RID: 15802
	[NullableContext(2)]
	[Nullable(0)]
	public class PhantomSelectView : RogueSelectBaseView
	{
		// Token: 0x06028640 RID: 165440 RVA: 0x00B5125D File Offset: 0x00B4F45D
		[NullableContext(1)]
		public PhantomSelectView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x17005275 RID: 21109
		// (get) Token: 0x06028642 RID: 165442 RVA: 0x00B512A7 File Offset: 0x00B4F4A7
		// (set) Token: 0x06028641 RID: 165441 RVA: 0x00B51270 File Offset: 0x00B4F470
		private int SelectIndex
		{
			get
			{
				return this.SelectIndexInternal;
			}
			set
			{
				this.SelectIndexInternal = value;
				int configId = this.RoguelikeChooseData.RogueGainEntryList[value].ConfigId;
				LocalStorage.SetPlayer<int>(ELocalStoragePlayerKey.RoguelikeSelectPhantomId, configId);
			}
		}

		// Token: 0x06028643 RID: 165443 RVA: 0x00B512B0 File Offset: 0x00B4F4B0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickBtnLeft));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickBtnRight));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06028644 RID: 165444 RVA: 0x00B51464 File Offset: 0x00B4F664
		private void OnClickBtnLeft()
		{
			this.PhantomSelectItemLayout.DeselectCurrentGridProxy();
			if (this.SelectIndex - 1 < 0)
			{
				this.SelectIndex = this.RoguelikeChooseData.RogueGainEntryList.Count - 1;
			}
			else
			{
				int selectIndex = this.SelectIndex;
				this.SelectIndex = selectIndex - 1;
			}
			this.PhantomSelectItemLayout.SelectGridProxy(this.SelectIndex, false);
			this.RefreshPhantom(true);
			this.RefreshBtnEnableClick();
		}

		// Token: 0x06028645 RID: 165445 RVA: 0x00B514D0 File Offset: 0x00B4F6D0
		private void OnClickBtnRight()
		{
			this.PhantomSelectItemLayout.DeselectCurrentGridProxy();
			if (this.SelectIndex + 1 >= this.RoguelikeChooseData.RogueGainEntryList.Count)
			{
				this.SelectIndex = 0;
			}
			else
			{
				int selectIndex = this.SelectIndex;
				this.SelectIndex = selectIndex + 1;
			}
			this.PhantomSelectItemLayout.SelectGridProxy(this.SelectIndex, false);
			this.RefreshPhantom(true);
			this.RefreshBtnEnableClick();
		}

		// Token: 0x06028646 RID: 165446 RVA: 0x00B5153C File Offset: 0x00B4F73C
		protected virtual void ConfirmBtn(int _)
		{
			if (this.SelectIndex < 0)
			{
				Log.Instance.Error(ELogModule.Roguelike, ELogAuthor.ZJC, "当前没有选中的声骸", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			RogueGainEntry currentRogueGainEntry = this.RoguelikeChooseData.RogueGainEntryList[this.SelectIndex];
			RoguelikeModel.Instance.CurrentRogueGainEntry = currentRogueGainEntry;
			RoguelikeController.Instance.RogueChooseDataResultRequest(EPerkType.Phantom);
		}

		// Token: 0x06028647 RID: 165447 RVA: 0x00B515A0 File Offset: 0x00B4F7A0
		protected virtual void RefreshBtnEnableClick()
		{
			RogueGainEntry rogueGainEntry = this.RoguelikeChooseData.RogueGainEntryList[this.SelectIndex];
			if (!rogueGainEntry.IsValid)
			{
				RoguePokemon? roguePhantomConfig = RoguelikeConfig.Instance.GetRoguePhantomConfig(rogueGainEntry.ConfigId);
				this.ButtonItem.SetUiActive(false);
				this.LockItem.SetTextByTextId(roguePhantomConfig.Value.UnlockTips, Array.Empty<string>());
				this.LockItem.SetUiActive(true);
				return;
			}
			this.ButtonItem.SetUiActive(true);
			this.LockItem.SetUiActive(false);
		}

		// Token: 0x06028648 RID: 165448 RVA: 0x00B51630 File Offset: 0x00B4F830
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomSelectView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomSelectView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028649 RID: 165449 RVA: 0x00B51674 File Offset: 0x00B4F874
		protected override void OnStart()
		{
			this.SelectIndexInternal = this.GetCacheSelectIndex().GetValueOrDefault();
			this.PhantomSelectItemLayout.SelectGridProxy(this.SelectIndex, true);
		}

		// Token: 0x0602864A RID: 165450 RVA: 0x00B516A8 File Offset: 0x00B4F8A8
		private int? GetCacheSelectIndex()
		{
			int player = LocalStorage.GetPlayer<int>(ELocalStoragePlayerKey.RoguelikeSelectPhantomId, 0);
			if (player != 0)
			{
				int num = -1;
				for (int i = 0; i < this.RoguelikeChooseData.RogueGainEntryList.Count; i++)
				{
					if (this.RoguelikeChooseData.RogueGainEntryList[i].ConfigId == player)
					{
						num = i;
						break;
					}
				}
				if (num >= 0)
				{
					return new int?(num);
				}
			}
			return null;
		}

		// Token: 0x0602864B RID: 165451 RVA: 0x00B51712 File Offset: 0x00B4F912
		protected override void OnBeforeShow()
		{
			this.Refresh();
		}

		// Token: 0x0602864C RID: 165452 RVA: 0x00B5171A File Offset: 0x00B4F91A
		protected override void OnBeforeDestroy()
		{
			this.TopPanel.Destroy(null);
			this.ElementPanel.Destroy(null);
			base.RecycleUiPoolActor();
		}

		// Token: 0x0602864D RID: 165453 RVA: 0x00B5173A File Offset: 0x00B4F93A
		private bool CanToggleStateChange(bool bState)
		{
			return false;
		}

		// Token: 0x0602864E RID: 165454 RVA: 0x00B5173D File Offset: 0x00B4F93D
		[NullableContext(1)]
		private RoguelikePhantomSelectDragItem CreatePhantomSelectDragItem()
		{
			return new RoguelikePhantomSelectDragItem
			{
				OnSelectCallback = new Action<IPhantomSelectItemData, bool>(this.OnSelectItem)
			};
		}

		// Token: 0x0602864F RID: 165455 RVA: 0x00B51756 File Offset: 0x00B4F956
		[NullableContext(1)]
		private void OnSelectItem(IPhantomSelectItemData entry, bool isSelected)
		{
			if (!isSelected)
			{
				return;
			}
			this.PhantomSelectItemLayout.DeselectCurrentGridProxy();
			this.SelectIndex = entry.Index;
			this.PhantomSelectItemLayout.SelectGridProxy(this.SelectIndex, false);
			this.RefreshPhantom(true);
			this.RefreshBtnEnableClick();
		}

		// Token: 0x06028650 RID: 165456 RVA: 0x00B51794 File Offset: 0x00B4F994
		[NullableContext(1)]
		protected override void RoguelikeChooseDataResult(RogueGainEntry newRogueGainEntry, RogueGainEntry oldRogueGainEntry, bool isSuccess, int bindId, RoguelikeChooseDataResultResponse response)
		{
			if (isSuccess)
			{
				RoguelikeChooseData roguelikeChooseData = this.RoguelikeChooseData;
				int? num = (roguelikeChooseData != null) ? new int?(roguelikeChooseData.Index) : null;
				if (bindId == num.GetValueOrDefault() & num != null)
				{
					if (this.IsShowChooseTips)
					{
						RogueGainEntry selectRogueGainEntry = this.RoguelikeChooseData.RogueGainEntryList[this.SelectIndex];
						UiManager.Instance.CloseAndOpenView(this.ViewInfo.Name, EUiViewName.RoguePhantomSelectResultView, new RogueSelectResult(newRogueGainEntry, oldRogueGainEntry, selectRogueGainEntry, false), null, true);
						return;
					}
					UiManager.Instance.CloseView(this.ViewInfo.Name, null);
					return;
				}
			}
		}

		// Token: 0x06028651 RID: 165457 RVA: 0x00B51835 File Offset: 0x00B4FA35
		protected override void OnDescModelChange()
		{
			this.Refresh();
		}

		// Token: 0x06028652 RID: 165458 RVA: 0x00B5183D File Offset: 0x00B4FA3D
		private void Refresh()
		{
			this.RefreshTopPanel();
			this.RefreshPhantom(false);
			this.RefreshElementPanel();
			this.RefreshBtnEnableClick();
		}

		// Token: 0x06028653 RID: 165459 RVA: 0x00B51858 File Offset: 0x00B4FA58
		protected virtual void RefreshTopPanel()
		{
			this.TopPanel.RefreshTitle("RoguelikeView_5_Text");
			this.TopPanel.RefreshSelectTipsText("RoguelikeView_6_Text", false, Array.Empty<object>());
			this.TopPanel.RefreshTabBtn();
		}

		// Token: 0x06028654 RID: 165460 RVA: 0x00B5188C File Offset: 0x00B4FA8C
		private void RefreshPhantom(bool animSwitch = false)
		{
			RogueGainEntry rogueGainEntry = this.RoguelikeChooseData.RogueGainEntryList[this.SelectIndex];
			PhantomSelectItemContextData data = new PhantomSelectItemContextData
			{
				RogueGainEntry = rogueGainEntry,
				RoguelikeInfo = RoguelikeModel.Instance.RogueInfo
			};
			this.PhantomSelectItem.Update(data);
			if (animSwitch)
			{
				this.PhantomSelectItem.PlaySequenceByName("Start");
			}
			base.GetItem(8).SetUIActive(!rogueGainEntry.IsValid);
		}

		// Token: 0x06028655 RID: 165461 RVA: 0x00B51901 File Offset: 0x00B4FB01
		protected void RefreshElementPanel()
		{
			this.ElementPanel.Refresh(null);
		}

		// Token: 0x06028656 RID: 165462 RVA: 0x00B51910 File Offset: 0x00B4FB10
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
			PhantomSelectItem phantomSelectItem = this.PhantomSelectItem;
			if (phantomSelectItem != null)
			{
				if (configParams[1] == "All")
				{
					return new UUIItem[]
					{
						phantomSelectItem.GetRootItem(),
						phantomSelectItem.GetRootItem()
					};
				}
				if (configParams[1] == "Sub")
				{
					PhantomSelectItem phantomSelectItem2 = this.PhantomSelectItem;
					UUIItem uuiitem = (phantomSelectItem2 != null) ? phantomSelectItem2.GetSubItem() : null;
					if (uuiitem != null)
					{
						return new UUIItem[]
						{
							uuiitem,
							uuiitem
						};
					}
				}
			}
			return null;
		}

		// Token: 0x04015F09 RID: 89865
		protected RoguelikeChooseData RoguelikeChooseData;

		// Token: 0x04015F0A RID: 89866
		protected TopPanel TopPanel;

		// Token: 0x04015F0B RID: 89867
		protected ElementPanel ElementPanel;

		// Token: 0x04015F0C RID: 89868
		protected ButtonItem ButtonItem;

		// Token: 0x04015F0D RID: 89869
		private PhantomSelectItem PhantomSelectItem;

		// Token: 0x04015F0E RID: 89870
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoguelikePhantomSelectDragItem, IPhantomSelectItemData> PhantomSelectItemLayout;

		// Token: 0x04015F0F RID: 89871
		private RoguelikePhantomLockItem LockItem;

		// Token: 0x04015F10 RID: 89872
		protected bool IsShowChooseTips;

		// Token: 0x04015F11 RID: 89873
		private int SelectIndexInternal = -1;

		// Token: 0x020099AC RID: 39340
		[NullableContext(0)]
		private class EPhantomSelectViewCom
		{
			// Token: 0x0402FEAA RID: 196266
			public const int TopPanelItem = 0;

			// Token: 0x0402FEAB RID: 196267
			public const int PhantomLayout = 1;

			// Token: 0x0402FEAC RID: 196268
			public const int ConfirmBtn = 2;

			// Token: 0x0402FEAD RID: 196269
			public const int ElementPanelItem = 3;

			// Token: 0x0402FEAE RID: 196270
			public const int BtnLeft = 4;

			// Token: 0x0402FEAF RID: 196271
			public const int BtnRight = 5;

			// Token: 0x0402FEB0 RID: 196272
			public const int PanelLock = 6;

			// Token: 0x0402FEB1 RID: 196273
			public const int PhantomItem = 7;

			// Token: 0x0402FEB2 RID: 196274
			public const int PhantomItemLock = 8;
		}
	}
}
