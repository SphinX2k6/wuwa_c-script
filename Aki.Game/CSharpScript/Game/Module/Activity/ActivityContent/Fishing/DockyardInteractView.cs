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
	// Token: 0x020065AB RID: 26027
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardInteractView : UiViewBase
	{
		// Token: 0x0604142D RID: 267309 RVA: 0x00FD0A5B File Offset: 0x00FCEC5B
		public DockyardInteractView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0604142E RID: 267310 RVA: 0x00FD0A64 File Offset: 0x00FCEC64
		protected unsafe override void OnRegisterComponent()
		{
			this.InitViewModel();
			int num = 4;
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
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0604142F RID: 267311 RVA: 0x00FD0B15 File Offset: 0x00FCED15
		private void InitViewModel()
		{
			this.Vm = (this.OpenParam as DockyardInteractViewModel);
			this.Vm.RegisterView(this);
		}

		// Token: 0x06041430 RID: 267312 RVA: 0x00FD0B34 File Offset: 0x00FCED34
		private UniTask InitFishingCurrencyItem()
		{
			DockyardInteractView.<InitFishingCurrencyItem>d__9 <InitFishingCurrencyItem>d__;
			<InitFishingCurrencyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitFishingCurrencyItem>d__.<>4__this = this;
			<InitFishingCurrencyItem>d__.<>1__state = -1;
			<InitFishingCurrencyItem>d__.<>t__builder.Start<DockyardInteractView.<InitFishingCurrencyItem>d__9>(ref <InitFishingCurrencyItem>d__);
			return <InitFishingCurrencyItem>d__.<>t__builder.Task;
		}

		// Token: 0x06041431 RID: 267313 RVA: 0x00FD0B78 File Offset: 0x00FCED78
		private UniTask InitCaption()
		{
			DockyardInteractView.<InitCaption>d__10 <InitCaption>d__;
			<InitCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCaption>d__.<>4__this = this;
			<InitCaption>d__.<>1__state = -1;
			<InitCaption>d__.<>t__builder.Start<DockyardInteractView.<InitCaption>d__10>(ref <InitCaption>d__);
			return <InitCaption>d__.<>t__builder.Task;
		}

		// Token: 0x06041432 RID: 267314 RVA: 0x00FD0BBC File Offset: 0x00FCEDBC
		private UniTask InitInteractPanel()
		{
			DockyardInteractView.<InitInteractPanel>d__11 <InitInteractPanel>d__;
			<InitInteractPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitInteractPanel>d__.<>4__this = this;
			<InitInteractPanel>d__.<>1__state = -1;
			<InitInteractPanel>d__.<>t__builder.Start<DockyardInteractView.<InitInteractPanel>d__11>(ref <InitInteractPanel>d__);
			return <InitInteractPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06041433 RID: 267315 RVA: 0x00FD0C00 File Offset: 0x00FCEE00
		private UniTask InitBackpackPanel()
		{
			DockyardInteractView.<InitBackpackPanel>d__12 <InitBackpackPanel>d__;
			<InitBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBackpackPanel>d__.<>4__this = this;
			<InitBackpackPanel>d__.<>1__state = -1;
			<InitBackpackPanel>d__.<>t__builder.Start<DockyardInteractView.<InitBackpackPanel>d__12>(ref <InitBackpackPanel>d__);
			return <InitBackpackPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06041434 RID: 267316 RVA: 0x00FD0C44 File Offset: 0x00FCEE44
		private UniTask InitTipsPanel()
		{
			DockyardInteractView.<InitTipsPanel>d__13 <InitTipsPanel>d__;
			<InitTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTipsPanel>d__.<>4__this = this;
			<InitTipsPanel>d__.<>1__state = -1;
			<InitTipsPanel>d__.<>t__builder.Start<DockyardInteractView.<InitTipsPanel>d__13>(ref <InitTipsPanel>d__);
			return <InitTipsPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06041435 RID: 267317 RVA: 0x00FD0C88 File Offset: 0x00FCEE88
		protected override UniTask OnBeforeStartAsync()
		{
			DockyardInteractView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DockyardInteractView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06041436 RID: 267318 RVA: 0x00FD0CCB File Offset: 0x00FCEECB
		protected override void OnBeforeDestroy()
		{
			GeneralLogicTreeController.Instance.OpenSystemBoardResultRequest((this.Vm.IsComplete > false) ? 1 : 0, this.Vm.ActionIncId);
		}

		// Token: 0x06041437 RID: 267319 RVA: 0x00FD0CF0 File Offset: 0x00FCEEF0
		public void ShowTipsPanel(int id)
		{
			DockyardItemBlockOriginalData itemBlockDataByIncId = this.Vm.GetItemBlockDataByIncId(id);
			this.TipsPanel.Refresh(itemBlockDataByIncId);
			this.TipsPanel.SetPanelVisible(true);
		}

		// Token: 0x06041438 RID: 267320 RVA: 0x00FD0D22 File Offset: 0x00FCEF22
		public void HideTipsPanel()
		{
			this.TipsPanel.SetPanelVisible(false);
		}

		// Token: 0x06041439 RID: 267321 RVA: 0x00FD0D30 File Offset: 0x00FCEF30
		public void OpenInteractFinishTipsView()
		{
			DockyardInteractFinishTipsViewModel dockyardInteractFinishTipsViewModel = new DockyardInteractFinishTipsViewModel();
			dockyardInteractFinishTipsViewModel.CloseCallback = delegate()
			{
				base.CloseMe(null);
			};
			UiManager.Instance.OpenView(EUiViewName.DockyardInteractFinishTipsView, dockyardInteractFinishTipsViewModel, null);
		}

		// Token: 0x04021F95 RID: 139157
		private DockyardInteractPanel InteractPanel;

		// Token: 0x04021F96 RID: 139158
		private PopupCaptionItem CaptionItem;

		// Token: 0x04021F97 RID: 139159
		private DockyardBackpackPanel BackpackPanel;

		// Token: 0x04021F98 RID: 139160
		private DockyardTipsPanel TipsPanel;

		// Token: 0x04021F99 RID: 139161
		private DockyardInteractViewModel Vm;

		// Token: 0x0200C7AB RID: 51115
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403C50E RID: 247054
			public const int CaptionItem = 0;

			// Token: 0x0403C50F RID: 247055
			public const int InteractItem = 1;

			// Token: 0x0403C510 RID: 247056
			public const int BackpackItem = 2;

			// Token: 0x0403C511 RID: 247057
			public const int TipsItem = 3;
		}
	}
}
