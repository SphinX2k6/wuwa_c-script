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
	// Token: 0x02005551 RID: 21841
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardWareHouseView : UiTickViewBase
	{
		// Token: 0x060362B5 RID: 221877 RVA: 0x00F1E6B0 File Offset: 0x00F1C8B0
		public DockyardWareHouseView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060362B6 RID: 221878 RVA: 0x00F1E6C0 File Offset: 0x00F1C8C0
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

		// Token: 0x060362B7 RID: 221879 RVA: 0x00F1E7B3 File Offset: 0x00F1C9B3
		private void InitViewModel()
		{
			this.Vm = (this.OpenParam as DockyardWareHouseViewModelBase);
			this.Vm.RegisterView(this);
		}

		// Token: 0x060362B8 RID: 221880 RVA: 0x00F1E7D4 File Offset: 0x00F1C9D4
		private UniTask InitFishingCurrencyItem()
		{
			DockyardWareHouseView.<InitFishingCurrencyItem>d__15 <InitFishingCurrencyItem>d__;
			<InitFishingCurrencyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitFishingCurrencyItem>d__.<>4__this = this;
			<InitFishingCurrencyItem>d__.<>1__state = -1;
			<InitFishingCurrencyItem>d__.<>t__builder.Start<DockyardWareHouseView.<InitFishingCurrencyItem>d__15>(ref <InitFishingCurrencyItem>d__);
			return <InitFishingCurrencyItem>d__.<>t__builder.Task;
		}

		// Token: 0x060362B9 RID: 221881 RVA: 0x00F1E818 File Offset: 0x00F1CA18
		private UniTask InitCaption()
		{
			DockyardWareHouseView.<InitCaption>d__16 <InitCaption>d__;
			<InitCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCaption>d__.<>4__this = this;
			<InitCaption>d__.<>1__state = -1;
			<InitCaption>d__.<>t__builder.Start<DockyardWareHouseView.<InitCaption>d__16>(ref <InitCaption>d__);
			return <InitCaption>d__.<>t__builder.Task;
		}

		// Token: 0x060362BA RID: 221882 RVA: 0x00F1E85C File Offset: 0x00F1CA5C
		private UniTask InitBackpackPanel()
		{
			DockyardWareHouseView.<InitBackpackPanel>d__17 <InitBackpackPanel>d__;
			<InitBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBackpackPanel>d__.<>4__this = this;
			<InitBackpackPanel>d__.<>1__state = -1;
			<InitBackpackPanel>d__.<>t__builder.Start<DockyardWareHouseView.<InitBackpackPanel>d__17>(ref <InitBackpackPanel>d__);
			return <InitBackpackPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060362BB RID: 221883 RVA: 0x00F1E8A0 File Offset: 0x00F1CAA0
		private UniTask InitLoopScroll()
		{
			DockyardWareHouseView.<InitLoopScroll>d__18 <InitLoopScroll>d__;
			<InitLoopScroll>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLoopScroll>d__.<>4__this = this;
			<InitLoopScroll>d__.<>1__state = -1;
			<InitLoopScroll>d__.<>t__builder.Start<DockyardWareHouseView.<InitLoopScroll>d__18>(ref <InitLoopScroll>d__);
			return <InitLoopScroll>d__.<>t__builder.Task;
		}

		// Token: 0x060362BC RID: 221884 RVA: 0x00F1E8E4 File Offset: 0x00F1CAE4
		private UniTask InitTipsPanel()
		{
			DockyardWareHouseView.<InitTipsPanel>d__19 <InitTipsPanel>d__;
			<InitTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTipsPanel>d__.<>4__this = this;
			<InitTipsPanel>d__.<>1__state = -1;
			<InitTipsPanel>d__.<>t__builder.Start<DockyardWareHouseView.<InitTipsPanel>d__19>(ref <InitTipsPanel>d__);
			return <InitTipsPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060362BD RID: 221885 RVA: 0x00F1E927 File Offset: 0x00F1CB27
		private IDockyardLeftTipsInterface GetLeftInfoPanel()
		{
			if (this.QteSkipPanel != null)
			{
				return this.QteSkipPanel;
			}
			return this.QuestPanel;
		}

		// Token: 0x060362BE RID: 221886 RVA: 0x00F1E940 File Offset: 0x00F1CB40
		protected override UniTask OnBeforeStartAsync()
		{
			DockyardWareHouseView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DockyardWareHouseView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060362BF RID: 221887 RVA: 0x00F1E983 File Offset: 0x00F1CB83
		protected override void OnBeforeShow()
		{
			DockyardQuestInfoPanel questPanel = this.QuestPanel;
			if (questPanel == null)
			{
				return;
			}
			questPanel.Refresh();
		}

		// Token: 0x060362C0 RID: 221888 RVA: 0x00F1E998 File Offset: 0x00F1CB98
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

		// Token: 0x060362C1 RID: 221889 RVA: 0x00F1EA1F File Offset: 0x00F1CC1F
		public void ShowTipsPanel(int id)
		{
			this.TipDirty = true;
			this.LeftTipsType = 0;
			this.CacheId = id;
		}

		// Token: 0x060362C2 RID: 221890 RVA: 0x00F1EA36 File Offset: 0x00F1CC36
		public void HideTipsPanel()
		{
			this.TipDirty = true;
			this.LeftTipsType = 1;
		}

		// Token: 0x060362C3 RID: 221891 RVA: 0x00F1EA46 File Offset: 0x00F1CC46
		public UUIItem GetPanelParentItem()
		{
			return base.GetItem(4);
		}

		// Token: 0x060362C4 RID: 221892 RVA: 0x00F1EA50 File Offset: 0x00F1CC50
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

		// Token: 0x060362C5 RID: 221893 RVA: 0x00F1EAB0 File Offset: 0x00F1CCB0
		public UniTask CreateQteSkipPanel()
		{
			DockyardWareHouseView.<CreateQteSkipPanel>d__28 <CreateQteSkipPanel>d__;
			<CreateQteSkipPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateQteSkipPanel>d__.<>4__this = this;
			<CreateQteSkipPanel>d__.<>1__state = -1;
			<CreateQteSkipPanel>d__.<>t__builder.Start<DockyardWareHouseView.<CreateQteSkipPanel>d__28>(ref <CreateQteSkipPanel>d__);
			return <CreateQteSkipPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060362C6 RID: 221894 RVA: 0x00F1EAF4 File Offset: 0x00F1CCF4
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

		// Token: 0x060362C7 RID: 221895 RVA: 0x00F1EB3F File Offset: 0x00F1CD3F
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			return this.ListPanel.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x060362C8 RID: 221896 RVA: 0x00F1EB4D File Offset: 0x00F1CD4D
		[CompilerGenerated]
		private void <CreateQteSkipPanel>g__continueFunc|28_0()
		{
			base.CloseMe(null);
		}

		// Token: 0x060362C9 RID: 221897 RVA: 0x00F1EB56 File Offset: 0x00F1CD56
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

		// Token: 0x060362CB RID: 221899 RVA: 0x00F1EB7A File Offset: 0x00F1CD7A
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

		// Token: 0x0401C956 RID: 117078
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401C957 RID: 117079
		private DockyardBackpackPanel BackpackPanel;

		// Token: 0x0401C958 RID: 117080
		private DockyardItemListPanel ListPanel;

		// Token: 0x0401C959 RID: 117081
		private DockyardTipsPanel TipsPanel;

		// Token: 0x0401C95A RID: 117082
		[Nullable(2)]
		private DockyardQteSkipPanel QteSkipPanel;

		// Token: 0x0401C95B RID: 117083
		[Nullable(2)]
		private DockyardQuestInfoPanel QuestPanel;

		// Token: 0x0401C95C RID: 117084
		private DockyardWareHouseViewModelBase Vm;

		// Token: 0x0401C95D RID: 117085
		private int LeftTipsType = 1;

		// Token: 0x0401C95E RID: 117086
		private bool TipDirty;

		// Token: 0x0401C95F RID: 117087
		private int CacheId;

		// Token: 0x0200B1DB RID: 45531
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036F94 RID: 225172
			public const int CaptionItem = 0;

			// Token: 0x04036F95 RID: 225173
			public const int BackpackItem = 1;

			// Token: 0x04036F96 RID: 225174
			public const int ListItem = 2;

			// Token: 0x04036F97 RID: 225175
			public const int TipsItem = 3;

			// Token: 0x04036F98 RID: 225176
			public const int ParentItem = 4;

			// Token: 0x04036F99 RID: 225177
			public const int PanelRootItem = 5;
		}

		// Token: 0x0200B1DC RID: 45532
		[NullableContext(0)]
		private class ELeftTipsType
		{
			// Token: 0x04036F9A RID: 225178
			public const int ItemTips = 0;

			// Token: 0x04036F9B RID: 225179
			public const int InfoTips = 1;
		}
	}
}
