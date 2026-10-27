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
	// Token: 0x02004DF1 RID: 19953
	[NullableContext(2)]
	[Nullable(0)]
	public class PhantomSelectView : RogueSelectBaseView
	{
		// Token: 0x060337D5 RID: 210901 RVA: 0x00C07D4D File Offset: 0x00C05F4D
		[NullableContext(1)]
		public PhantomSelectView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x17007EC5 RID: 32453
		// (get) Token: 0x060337D7 RID: 210903 RVA: 0x00C07D97 File Offset: 0x00C05F97
		// (set) Token: 0x060337D6 RID: 210902 RVA: 0x00C07D60 File Offset: 0x00C05F60
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

		// Token: 0x060337D8 RID: 210904 RVA: 0x00C07DA0 File Offset: 0x00C05FA0
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

		// Token: 0x060337D9 RID: 210905 RVA: 0x00C07F54 File Offset: 0x00C06154
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

		// Token: 0x060337DA RID: 210906 RVA: 0x00C07FC0 File Offset: 0x00C061C0
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

		// Token: 0x060337DB RID: 210907 RVA: 0x00C0802C File Offset: 0x00C0622C
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

		// Token: 0x060337DC RID: 210908 RVA: 0x00C08090 File Offset: 0x00C06290
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

		// Token: 0x060337DD RID: 210909 RVA: 0x00C08120 File Offset: 0x00C06320
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomSelectView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomSelectView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060337DE RID: 210910 RVA: 0x00C08164 File Offset: 0x00C06364
		protected override void OnStart()
		{
			this.SelectIndexInternal = this.GetCacheSelectIndex().GetValueOrDefault();
			this.PhantomSelectItemLayout.SelectGridProxy(this.SelectIndex, true);
		}

		// Token: 0x060337DF RID: 210911 RVA: 0x00C08198 File Offset: 0x00C06398
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

		// Token: 0x060337E0 RID: 210912 RVA: 0x00C08202 File Offset: 0x00C06402
		protected override void OnBeforeShow()
		{
			this.Refresh();
		}

		// Token: 0x060337E1 RID: 210913 RVA: 0x00C0820A File Offset: 0x00C0640A
		protected override void OnBeforeDestroy()
		{
			this.TopPanel.Destroy(null);
			this.ElementPanel.Destroy(null);
			base.RecycleUiPoolActor();
		}

		// Token: 0x060337E2 RID: 210914 RVA: 0x00C0822A File Offset: 0x00C0642A
		private bool CanToggleStateChange(bool bState)
		{
			return false;
		}

		// Token: 0x060337E3 RID: 210915 RVA: 0x00C0822D File Offset: 0x00C0642D
		[NullableContext(1)]
		private RoguelikePhantomSelectDragItem CreatePhantomSelectDragItem()
		{
			return new RoguelikePhantomSelectDragItem
			{
				OnSelectCallback = new Action<IPhantomSelectItemData, bool>(this.OnSelectItem)
			};
		}

		// Token: 0x060337E4 RID: 210916 RVA: 0x00C08246 File Offset: 0x00C06446
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

		// Token: 0x060337E5 RID: 210917 RVA: 0x00C08284 File Offset: 0x00C06484
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

		// Token: 0x060337E6 RID: 210918 RVA: 0x00C08325 File Offset: 0x00C06525
		protected override void OnDescModelChange()
		{
			this.Refresh();
		}

		// Token: 0x060337E7 RID: 210919 RVA: 0x00C0832D File Offset: 0x00C0652D
		private void Refresh()
		{
			this.RefreshTopPanel();
			this.RefreshPhantom(false);
			this.RefreshElementPanel();
			this.RefreshBtnEnableClick();
		}

		// Token: 0x060337E8 RID: 210920 RVA: 0x00C08348 File Offset: 0x00C06548
		protected virtual void RefreshTopPanel()
		{
			this.TopPanel.RefreshTitle("RoguelikeView_5_Text");
			this.TopPanel.RefreshSelectTipsText("RoguelikeView_6_Text", false, Array.Empty<object>());
			this.TopPanel.RefreshTabBtn();
		}

		// Token: 0x060337E9 RID: 210921 RVA: 0x00C0837C File Offset: 0x00C0657C
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

		// Token: 0x060337EA RID: 210922 RVA: 0x00C083F1 File Offset: 0x00C065F1
		protected void RefreshElementPanel()
		{
			this.ElementPanel.Refresh(null);
		}

		// Token: 0x060337EB RID: 210923 RVA: 0x00C08400 File Offset: 0x00C06600
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

		// Token: 0x0401B536 RID: 111926
		protected RoguelikeChooseData RoguelikeChooseData;

		// Token: 0x0401B537 RID: 111927
		protected TopPanel TopPanel;

		// Token: 0x0401B538 RID: 111928
		protected ElementPanel ElementPanel;

		// Token: 0x0401B539 RID: 111929
		protected ButtonItem ButtonItem;

		// Token: 0x0401B53A RID: 111930
		private PhantomSelectItem PhantomSelectItem;

		// Token: 0x0401B53B RID: 111931
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoguelikePhantomSelectDragItem, IPhantomSelectItemData> PhantomSelectItemLayout;

		// Token: 0x0401B53C RID: 111932
		private RoguelikePhantomLockItem LockItem;

		// Token: 0x0401B53D RID: 111933
		protected bool IsShowChooseTips;

		// Token: 0x0401B53E RID: 111934
		private int SelectIndexInternal = -1;

		// Token: 0x0200AF77 RID: 44919
		[NullableContext(0)]
		private class EPhantomSelectViewCom
		{
			// Token: 0x04035477 RID: 218231
			public const int TopPanelItem = 0;

			// Token: 0x04035478 RID: 218232
			public const int PhantomLayout = 1;

			// Token: 0x04035479 RID: 218233
			public const int ConfirmBtn = 2;

			// Token: 0x0403547A RID: 218234
			public const int ElementPanelItem = 3;

			// Token: 0x0403547B RID: 218235
			public const int BtnLeft = 4;

			// Token: 0x0403547C RID: 218236
			public const int BtnRight = 5;

			// Token: 0x0403547D RID: 218237
			public const int PanelLock = 6;

			// Token: 0x0403547E RID: 218238
			public const int PhantomItem = 7;

			// Token: 0x0403547F RID: 218239
			public const int PhantomItemLock = 8;
		}
	}
}
