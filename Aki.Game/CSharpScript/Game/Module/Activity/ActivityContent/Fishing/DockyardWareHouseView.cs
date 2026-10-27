using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065D3 RID: 26067
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardWareHouseView : UiTickViewBase
	{
		// Token: 0x060415F0 RID: 267760 RVA: 0x00FD7670 File Offset: 0x00FD5870
		public DockyardWareHouseView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060415F1 RID: 267761 RVA: 0x00FD7680 File Offset: 0x00FD5880
		protected unsafe override void OnRegisterComponent()
		{
			this.InitViewModel();
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060415F2 RID: 267762 RVA: 0x00FD7773 File Offset: 0x00FD5973
		private void InitViewModel()
		{
			this.Vm = (this.OpenParam as DockyardWareHouseViewModelBase);
			this.Vm.RegisterView(this);
		}

		// Token: 0x060415F3 RID: 267763 RVA: 0x00FD7794 File Offset: 0x00FD5994
		private UniTask InitFishingCurrencyItem()
		{
			DockyardWareHouseView.<InitFishingCurrencyItem>d__15 <InitFishingCurrencyItem>d__;
			<InitFishingCurrencyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitFishingCurrencyItem>d__.<>4__this = this;
			<InitFishingCurrencyItem>d__.<>1__state = -1;
			<InitFishingCurrencyItem>d__.<>t__builder.Start<DockyardWareHouseView.<InitFishingCurrencyItem>d__15>(ref <InitFishingCurrencyItem>d__);
			return <InitFishingCurrencyItem>d__.<>t__builder.Task;
		}

		// Token: 0x060415F4 RID: 267764 RVA: 0x00FD77D8 File Offset: 0x00FD59D8
		private UniTask InitCaption()
		{
			DockyardWareHouseView.<InitCaption>d__16 <InitCaption>d__;
			<InitCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCaption>d__.<>4__this = this;
			<InitCaption>d__.<>1__state = -1;
			<InitCaption>d__.<>t__builder.Start<DockyardWareHouseView.<InitCaption>d__16>(ref <InitCaption>d__);
			return <InitCaption>d__.<>t__builder.Task;
		}

		// Token: 0x060415F5 RID: 267765 RVA: 0x00FD781C File Offset: 0x00FD5A1C
		private UniTask InitBackpackPanel()
		{
			DockyardWareHouseView.<InitBackpackPanel>d__17 <InitBackpackPanel>d__;
			<InitBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBackpackPanel>d__.<>4__this = this;
			<InitBackpackPanel>d__.<>1__state = -1;
			<InitBackpackPanel>d__.<>t__builder.Start<DockyardWareHouseView.<InitBackpackPanel>d__17>(ref <InitBackpackPanel>d__);
			return <InitBackpackPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060415F6 RID: 267766 RVA: 0x00FD7860 File Offset: 0x00FD5A60
		private UniTask InitLoopScroll()
		{
			DockyardWareHouseView.<InitLoopScroll>d__18 <InitLoopScroll>d__;
			<InitLoopScroll>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLoopScroll>d__.<>4__this = this;
			<InitLoopScroll>d__.<>1__state = -1;
			<InitLoopScroll>d__.<>t__builder.Start<DockyardWareHouseView.<InitLoopScroll>d__18>(ref <InitLoopScroll>d__);
			return <InitLoopScroll>d__.<>t__builder.Task;
		}

		// Token: 0x060415F7 RID: 267767 RVA: 0x00FD78A4 File Offset: 0x00FD5AA4
		private UniTask InitTipsPanel()
		{
			DockyardWareHouseView.<InitTipsPanel>d__19 <InitTipsPanel>d__;
			<InitTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTipsPanel>d__.<>4__this = this;
			<InitTipsPanel>d__.<>1__state = -1;
			<InitTipsPanel>d__.<>t__builder.Start<DockyardWareHouseView.<InitTipsPanel>d__19>(ref <InitTipsPanel>d__);
			return <InitTipsPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060415F8 RID: 267768 RVA: 0x00FD78E7 File Offset: 0x00FD5AE7
		private IDockyardLeftTipsInterface GetLeftInfoPanel()
		{
			if (this.QteSkipPanel != null)
			{
				return this.QteSkipPanel;
			}
			return this.QuestPanel;
		}

		// Token: 0x060415F9 RID: 267769 RVA: 0x00FD7900 File Offset: 0x00FD5B00
		protected override UniTask OnBeforeStartAsync()
		{
			DockyardWareHouseView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DockyardWareHouseView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060415FA RID: 267770 RVA: 0x00FD7943 File Offset: 0x00FD5B43
		protected override void OnBeforeShow()
		{
			DockyardQuestInfoPanel questPanel = this.QuestPanel;
			if (questPanel == null)
			{
				return;
			}
			questPanel.Refresh();
		}

		// Token: 0x060415FB RID: 267771 RVA: 0x00FD7958 File Offset: 0x00FD5B58
		protected override void OnTick(float delta)
		{
			if (this.TipDirty)
			{
				if (this.LeftTipsType == 0)
				{
					DockyardItemBlockOriginalData itemBlockData = this.Vm.GetItemBlockData(this.CacheId);
					if (itemBlockData != null)
					{
						this.TipsPanel.Refresh(itemBlockData);
						this.TipsPanel.SetPanelVisible(true);
						this.GetLeftInfoPanel().SetPanelVisible(false);
					}
				}
				else if (this.LeftTipsType == 1)
				{
					this.TipsPanel.SetPanelVisible(false);
					this.GetLeftInfoPanel().SetPanelVisible(true);
				}
				this.TipDirty = false;
				this.CacheId = 0;
			}
		}

		// Token: 0x060415FC RID: 267772 RVA: 0x00FD79DF File Offset: 0x00FD5BDF
		public void ShowTipsPanel(int id)
		{
			this.TipDirty = true;
			this.LeftTipsType = 0;
			this.CacheId = id;
		}

		// Token: 0x060415FD RID: 267773 RVA: 0x00FD79F6 File Offset: 0x00FD5BF6
		public void HideTipsPanel()
		{
			this.TipDirty = true;
			this.LeftTipsType = 1;
		}

		// Token: 0x060415FE RID: 267774 RVA: 0x00FD7A06 File Offset: 0x00FD5C06
		public UUIItem GetPanelParentItem()
		{
			return base.GetItem(4);
		}

		// Token: 0x060415FF RID: 267775 RVA: 0x00FD7A10 File Offset: 0x00FD5C10
		public void NotifyQuicklySellActive(bool isActive)
		{
			IDockyardLeftTipsInterface leftInfoPanel = this.GetLeftInfoPanel();
			IDockyardLeftTipsInterface dockyardLeftTipsInterface;
			if (this.LeftTipsType != 0)
			{
				dockyardLeftTipsInterface = leftInfoPanel;
			}
			else
			{
				IDockyardLeftTipsInterface tipsPanel = this.TipsPanel;
				dockyardLeftTipsInterface = tipsPanel;
			}
			IDockyardLeftTipsInterface dockyardLeftTipsInterface2 = dockyardLeftTipsInterface;
			if (isActive)
			{
				dockyardLeftTipsInterface2.SetPanelVisible(false);
				leftInfoPanel.LockState = true;
				this.TipsPanel.LockState = true;
				return;
			}
			leftInfoPanel.LockState = false;
			this.TipsPanel.LockState = false;
			dockyardLeftTipsInterface2.SetPanelVisible(true);
		}

		// Token: 0x06041600 RID: 267776 RVA: 0x00FD7A70 File Offset: 0x00FD5C70
		public UniTask CreateQteSkipPanel()
		{
			DockyardWareHouseView.<CreateQteSkipPanel>d__28 <CreateQteSkipPanel>d__;
			<CreateQteSkipPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateQteSkipPanel>d__.<>4__this = this;
			<CreateQteSkipPanel>d__.<>1__state = -1;
			<CreateQteSkipPanel>d__.<>t__builder.Start<DockyardWareHouseView.<CreateQteSkipPanel>d__28>(ref <CreateQteSkipPanel>d__);
			return <CreateQteSkipPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06041601 RID: 267777 RVA: 0x00FD7AB4 File Offset: 0x00FD5CB4
		public UniTask CreateQuestPanel(bool withExitButton)
		{
			DockyardWareHouseView.<CreateQuestPanel>d__29 <CreateQuestPanel>d__;
			<CreateQuestPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateQuestPanel>d__.<>4__this = this;
			<CreateQuestPanel>d__.withExitButton = withExitButton;
			<CreateQuestPanel>d__.<>1__state = -1;
			<CreateQuestPanel>d__.<>t__builder.Start<DockyardWareHouseView.<CreateQuestPanel>d__29>(ref <CreateQuestPanel>d__);
			return <CreateQuestPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06041602 RID: 267778 RVA: 0x00FD7AFF File Offset: 0x00FD5CFF
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			return this.ListPanel.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x06041603 RID: 267779 RVA: 0x00FD7B0D File Offset: 0x00FD5D0D
		[CompilerGenerated]
		private void <CreateQteSkipPanel>g__continueFunc|28_0()
		{
			base.CloseMe(null);
		}

		// Token: 0x06041604 RID: 267780 RVA: 0x00FD7B16 File Offset: 0x00FD5D16
		[CompilerGenerated]
		private void <CreateQteSkipPanel>g__exitFunc|28_1()
		{
			FishingController.Instance.ShowConfirmBoxAndRequestFishingExit(delegate(bool success)
			{
				if (success)
				{
					base.CloseMe(null);
				}
			});
		}

		// Token: 0x06041606 RID: 267782 RVA: 0x00FD7B3A File Offset: 0x00FD5D3A
		[CompilerGenerated]
		private void <CreateQuestPanel>g__exitFunc|29_0()
		{
			FishingController.Instance.ShowConfirmBoxAndRequestFishingExit(delegate(bool success)
			{
				if (success)
				{
					base.CloseMe(null);
				}
			});
		}

		// Token: 0x04022025 RID: 139301
		private PopupCaptionItem CaptionItem;

		// Token: 0x04022026 RID: 139302
		private DockyardBackpackPanel BackpackPanel;

		// Token: 0x04022027 RID: 139303
		private DockyardItemListPanel ListPanel;

		// Token: 0x04022028 RID: 139304
		private DockyardTipsPanel TipsPanel;

		// Token: 0x04022029 RID: 139305
		[Nullable(2)]
		private DockyardQteSkipPanel QteSkipPanel;

		// Token: 0x0402202A RID: 139306
		[Nullable(2)]
		private DockyardQuestInfoPanel QuestPanel;

		// Token: 0x0402202B RID: 139307
		private DockyardWareHouseViewModelBase Vm;

		// Token: 0x0402202C RID: 139308
		private int LeftTipsType = 1;

		// Token: 0x0402202D RID: 139309
		private bool TipDirty;

		// Token: 0x0402202E RID: 139310
		private int CacheId;

		// Token: 0x0200C7F8 RID: 51192
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403C646 RID: 247366
			public const int CaptionItem = 0;

			// Token: 0x0403C647 RID: 247367
			public const int BackpackItem = 1;

			// Token: 0x0403C648 RID: 247368
			public const int ListItem = 2;

			// Token: 0x0403C649 RID: 247369
			public const int TipsItem = 3;

			// Token: 0x0403C64A RID: 247370
			public const int ParentItem = 4;

			// Token: 0x0403C64B RID: 247371
			public const int PanelRootItem = 5;
		}

		// Token: 0x0200C7F9 RID: 51193
		[NullableContext(0)]
		private class ELeftTipsType
		{
			// Token: 0x0403C64C RID: 247372
			public const int ItemTips = 0;

			// Token: 0x0403C64D RID: 247373
			public const int InfoTips = 1;
		}
	}
}
