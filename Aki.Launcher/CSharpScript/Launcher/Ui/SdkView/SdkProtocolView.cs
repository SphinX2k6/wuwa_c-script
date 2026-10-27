using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Ui.HotFix;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.SdkView
{
	// Token: 0x020000C6 RID: 198
	[NullableContext(2)]
	[Nullable(0)]
	public class SdkProtocolView : LaunchComponentsAction
	{
		// Token: 0x0600068D RID: 1677 RVA: 0x00037D74 File Offset: 0x00035F74
		[NullableContext(1)]
		public void SetViewData(SdkProtocolViewData data)
		{
			this.ViewData = data;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00037D80 File Offset: 0x00035F80
		[NullableContext(1)]
		public UniTask Init(UObject worldContext, [Nullable(2)] USceneComponent root)
		{
			SdkProtocolView.<Init>d__14 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.worldContext = worldContext;
			<Init>d__.root = root;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<SdkProtocolView.<Init>d__14>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00037DD3 File Offset: 0x00035FD3
		[NullableContext(1)]
		private void OnViewLoadCallback(AActor actor)
		{
			base.SetRootActorLaunchComponentsAction(actor);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00037DDC File Offset: 0x00035FDC
		protected override void OnStart()
		{
			this.DescText = base.GetText(3);
			this.TitleText = base.GetText(5);
			this.EnterButton = base.GetButton(0);
			this.CancelButton = base.GetButton(1);
			UUIButtonComponent enterButton = this.EnterButton;
			if (enterButton != null)
			{
				enterButton.OnClickCallBack.Bind(new Action(this.OnClickEnterButton));
			}
			UUIButtonComponent cancelButton = this.CancelButton;
			if (cancelButton != null)
			{
				cancelButton.OnClickCallBack.Bind(new Action(this.OnClickCancelButton));
			}
			this.ButtonL1 = base.GetButton(2);
			this.ButtonR1 = base.GetButton(6);
			this.ButtonTriangle = base.GetButton(7);
			this.ButtonL2 = base.GetButton(8);
			this.ButtonR2 = base.GetButton(9);
			this.LayoutButtonList.Add(this.ButtonL1);
			this.LayoutButtonList.Add(this.ButtonR1);
			this.LayoutButtonList.Add(this.ButtonTriangle);
			this.LayoutButtonList.Add(this.ButtonL2);
			this.LayoutButtonList.Add(this.ButtonR2);
			for (int i = 0; i < this.LayoutButtonList.Count; i++)
			{
				this.LayoutButtonList[i].RootUIComp.Get().SetUIActive(false);
			}
			HotFixManager.SetLocalText(base.GetText(10), "SdkProtocolRefuse", Array.Empty<string>());
			HotFixManager.SetLocalText(base.GetText(11), "SdkProtocolConfirm", Array.Empty<string>());
			this.RefreshView();
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00037F61 File Offset: 0x00036161
		public void RefreshView()
		{
			this.RefreshDesc();
			this.RefreshTitle();
			this.RefreshLayout();
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00037F75 File Offset: 0x00036175
		private void OnClickEnterButton()
		{
			SdkProtocolViewData viewData = this.ViewData;
			if (viewData == null)
			{
				return;
			}
			Action enterCallback = viewData.EnterCallback;
			if (enterCallback == null)
			{
				return;
			}
			enterCallback();
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00037F91 File Offset: 0x00036191
		private void OnClickCancelButton()
		{
			SdkProtocolViewData viewData = this.ViewData;
			if (viewData == null)
			{
				return;
			}
			Action cancelCallback = viewData.CancelCallback;
			if (cancelCallback == null)
			{
				return;
			}
			cancelCallback();
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00037FB0 File Offset: 0x000361B0
		private void RefreshLayout()
		{
			SdkProtocolViewData viewData = this.ViewData;
			if (((viewData != null) ? viewData.LayoutData : null) != null)
			{
				int count = this.ViewData.LayoutData.Count;
				for (int i = 0; i < count; i++)
				{
					ProtocolItem protocolItem = new ProtocolItem(this);
					protocolItem.SetActor(this.LayoutButtonList[i].RootUIComp.Get().GetOwner());
					protocolItem.SetActive(true);
					protocolItem.Refresh(this.ViewData.LayoutData[i]);
					this.CurrentCopyProtocolArray.Add(protocolItem);
				}
			}
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00038043 File Offset: 0x00036243
		private void RefreshTitle()
		{
			if (this.ViewData != null && this.TitleText != null)
			{
				HotFixManager.SetLocalText(this.TitleText, this.ViewData.TitleId, Array.Empty<string>());
			}
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00038070 File Offset: 0x00036270
		private void RefreshDesc()
		{
			if (this.ViewData != null && this.DescText != null)
			{
				HotFixManager.SetLocalText(this.DescText, this.ViewData.DescTextId, Array.Empty<string>());
			}
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0003809D File Offset: 0x0003629D
		protected override void OnBeforeDestroy()
		{
			this.CurrentCopyProtocolArray.Clear();
		}

		// Token: 0x040003EF RID: 1007
		private SdkProtocolViewData ViewData;

		// Token: 0x040003F0 RID: 1008
		private UUIText DescText;

		// Token: 0x040003F1 RID: 1009
		private UUIText TitleText;

		// Token: 0x040003F2 RID: 1010
		private UUIButtonComponent EnterButton;

		// Token: 0x040003F3 RID: 1011
		private UUIButtonComponent CancelButton;

		// Token: 0x040003F4 RID: 1012
		private UUIButtonComponent ButtonL1;

		// Token: 0x040003F5 RID: 1013
		private UUIButtonComponent ButtonR1;

		// Token: 0x040003F6 RID: 1014
		private UUIButtonComponent ButtonTriangle;

		// Token: 0x040003F7 RID: 1015
		private UUIButtonComponent ButtonL2;

		// Token: 0x040003F8 RID: 1016
		private UUIButtonComponent ButtonR2;

		// Token: 0x040003F9 RID: 1017
		[Nullable(1)]
		private readonly List<UUIButtonComponent> LayoutButtonList = new List<UUIButtonComponent>();

		// Token: 0x040003FA RID: 1018
		[Nullable(1)]
		private readonly List<ProtocolItem> CurrentCopyProtocolArray = new List<ProtocolItem>();

		// Token: 0x0200035C RID: 860
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04001148 RID: 4424
			public const int EnterButton = 0;

			// Token: 0x04001149 RID: 4425
			public const int CancelButton = 1;

			// Token: 0x0400114A RID: 4426
			public const int ButtonL1 = 2;

			// Token: 0x0400114B RID: 4427
			public const int DescText = 3;

			// Token: 0x0400114C RID: 4428
			public const int VerticalLayout = 4;

			// Token: 0x0400114D RID: 4429
			public const int TitleText = 5;

			// Token: 0x0400114E RID: 4430
			public const int ButtonR1 = 6;

			// Token: 0x0400114F RID: 4431
			public const int ButtonTriangle = 7;

			// Token: 0x04001150 RID: 4432
			public const int ButtonL2 = 8;

			// Token: 0x04001151 RID: 4433
			public const int ButtonR2 = 9;

			// Token: 0x04001152 RID: 4434
			public const int LeftButtonText = 10;

			// Token: 0x04001153 RID: 4435
			public const int RightButtonText = 11;
		}
	}
}
