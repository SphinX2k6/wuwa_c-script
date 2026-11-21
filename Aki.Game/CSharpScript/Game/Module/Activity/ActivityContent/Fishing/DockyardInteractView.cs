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
	// Token: 0x02005529 RID: 21801
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardInteractView : UiViewBase
	{
		// Token: 0x060360F2 RID: 221426 RVA: 0x00F17A5F File Offset: 0x00F15C5F
		public DockyardInteractView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060360F3 RID: 221427 RVA: 0x00F17A68 File Offset: 0x00F15C68
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

		// Token: 0x060360F4 RID: 221428 RVA: 0x00F17B19 File Offset: 0x00F15D19
		private void InitViewModel()
		{
			this.Vm = (this.OpenParam as DockyardInteractViewModel);
			this.Vm.RegisterView(this);
		}

		// Token: 0x060360F5 RID: 221429 RVA: 0x00F17B38 File Offset: 0x00F15D38
		private UniTask InitFishingCurrencyItem()
		{
			DockyardInteractView.<InitFishingCurrencyItem>d__9 <InitFishingCurrencyItem>d__;
			<InitFishingCurrencyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitFishingCurrencyItem>d__.<>4__this = this;
			<InitFishingCurrencyItem>d__.<>1__state = -1;
			<InitFishingCurrencyItem>d__.<>t__builder.Start<DockyardInteractView.<InitFishingCurrencyItem>d__9>(ref <InitFishingCurrencyItem>d__);
			return <InitFishingCurrencyItem>d__.<>t__builder.Task;
		}

		// Token: 0x060360F6 RID: 221430 RVA: 0x00F17B7C File Offset: 0x00F15D7C
		private UniTask InitCaption()
		{
			DockyardInteractView.<InitCaption>d__10 <InitCaption>d__;
			<InitCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCaption>d__.<>4__this = this;
			<InitCaption>d__.<>1__state = -1;
			<InitCaption>d__.<>t__builder.Start<DockyardInteractView.<InitCaption>d__10>(ref <InitCaption>d__);
			return <InitCaption>d__.<>t__builder.Task;
		}

		// Token: 0x060360F7 RID: 221431 RVA: 0x00F17BC0 File Offset: 0x00F15DC0
		private UniTask InitInteractPanel()
		{
			DockyardInteractView.<InitInteractPanel>d__11 <InitInteractPanel>d__;
			<InitInteractPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitInteractPanel>d__.<>4__this = this;
			<InitInteractPanel>d__.<>1__state = -1;
			<InitInteractPanel>d__.<>t__builder.Start<DockyardInteractView.<InitInteractPanel>d__11>(ref <InitInteractPanel>d__);
			return <InitInteractPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060360F8 RID: 221432 RVA: 0x00F17C04 File Offset: 0x00F15E04
		private UniTask InitBackpackPanel()
		{
			DockyardInteractView.<InitBackpackPanel>d__12 <InitBackpackPanel>d__;
			<InitBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBackpackPanel>d__.<>4__this = this;
			<InitBackpackPanel>d__.<>1__state = -1;
			<InitBackpackPanel>d__.<>t__builder.Start<DockyardInteractView.<InitBackpackPanel>d__12>(ref <InitBackpackPanel>d__);
			return <InitBackpackPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060360F9 RID: 221433 RVA: 0x00F17C48 File Offset: 0x00F15E48
		private UniTask InitTipsPanel()
		{
			DockyardInteractView.<InitTipsPanel>d__13 <InitTipsPanel>d__;
			<InitTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTipsPanel>d__.<>4__this = this;
			<InitTipsPanel>d__.<>1__state = -1;
			<InitTipsPanel>d__.<>t__builder.Start<DockyardInteractView.<InitTipsPanel>d__13>(ref <InitTipsPanel>d__);
			return <InitTipsPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060360FA RID: 221434 RVA: 0x00F17C8C File Offset: 0x00F15E8C
		protected override UniTask OnBeforeStartAsync()
		{
			DockyardInteractView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DockyardInteractView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060360FB RID: 221435 RVA: 0x00F17CCF File Offset: 0x00F15ECF
		protected override void OnBeforeDestroy()
		{
			GeneralLogicTreeController.Instance.OpenSystemBoardResultRequest((this.Vm.IsComplete > false) ? 1 : 0, this.Vm.ActionIncId);
		}

		// Token: 0x060360FC RID: 221436 RVA: 0x00F17CF4 File Offset: 0x00F15EF4
		public void ShowTipsPanel(int id)
		{
			DockyardItemBlockOriginalData itemBlockDataByIncId = this.Vm.GetItemBlockDataByIncId(id);
			this.TipsPanel.Refresh(itemBlockDataByIncId);
			this.TipsPanel.SetPanelVisible(true);
		}

		// Token: 0x060360FD RID: 221437 RVA: 0x00F17D26 File Offset: 0x00F15F26
		public void HideTipsPanel()
		{
			this.TipsPanel.SetPanelVisible(false);
		}

		// Token: 0x060360FE RID: 221438 RVA: 0x00F17D34 File Offset: 0x00F15F34
		public void OpenInteractFinishTipsView()
		{
			DockyardInteractFinishTipsViewModel dockyardInteractFinishTipsViewModel = new DockyardInteractFinishTipsViewModel();
			dockyardInteractFinishTipsViewModel.CloseCallback = delegate()
			{
				base.CloseMe(null);
			};
			UiManager.Instance.OpenView(EUiViewName.DockyardInteractFinishTipsView, dockyardInteractFinishTipsViewModel, null);
		}

		// Token: 0x0401C8C6 RID: 116934
		private DockyardInteractPanel InteractPanel;

		// Token: 0x0401C8C7 RID: 116935
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401C8C8 RID: 116936
		private DockyardBackpackPanel BackpackPanel;

		// Token: 0x0401C8C9 RID: 116937
		private DockyardTipsPanel TipsPanel;

		// Token: 0x0401C8CA RID: 116938
		private DockyardInteractViewModel Vm;

		// Token: 0x0200B190 RID: 45456
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036E5F RID: 224863
			public const int CaptionItem = 0;

			// Token: 0x04036E60 RID: 224864
			public const int InteractItem = 1;

			// Token: 0x04036E61 RID: 224865
			public const int BackpackItem = 2;

			// Token: 0x04036E62 RID: 224866
			public const int TipsItem = 3;
		}
	}
}
