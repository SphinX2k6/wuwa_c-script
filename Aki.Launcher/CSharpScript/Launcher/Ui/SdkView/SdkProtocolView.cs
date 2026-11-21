using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Ui.HotFix;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.SdkView
{
	// Token: 0x020000C9 RID: 201
	[NullableContext(2)]
	[Nullable(0)]
	public class SdkProtocolView : LaunchComponentsAction
	{
		// Token: 0x060006A9 RID: 1705 RVA: 0x000398A4 File Offset: 0x00037AA4
		[NullableContext(1)]
		public void SetViewData(SdkProtocolViewData data)
		{
			this.ViewData = data;
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x000398B0 File Offset: 0x00037AB0
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

		// Token: 0x060006AB RID: 1707 RVA: 0x00039903 File Offset: 0x00037B03
		[NullableContext(1)]
		private void OnViewLoadCallback(AActor actor)
		{
			base.SetRootActorLaunchComponentsAction(actor);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x0003990C File Offset: 0x00037B0C
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

		// Token: 0x060006AD RID: 1709 RVA: 0x00039A91 File Offset: 0x00037C91
		public void RefreshView()
		{
			this.RefreshDesc();
			this.RefreshTitle();
			this.RefreshLayout();
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00039AA5 File Offset: 0x00037CA5
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

		// Token: 0x060006AF RID: 1711 RVA: 0x00039AC1 File Offset: 0x00037CC1
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

		// Token: 0x060006B0 RID: 1712 RVA: 0x00039AE0 File Offset: 0x00037CE0
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

		// Token: 0x060006B1 RID: 1713 RVA: 0x00039B73 File Offset: 0x00037D73
		private void RefreshTitle()
		{
			if (this.ViewData != null && this.TitleText != null)
			{
				HotFixManager.SetLocalText(this.TitleText, this.ViewData.TitleId, Array.Empty<string>());
			}
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00039BA0 File Offset: 0x00037DA0
		private void RefreshDesc()
		{
			if (this.ViewData != null && this.DescText != null)
			{
				HotFixManager.SetLocalText(this.DescText, this.ViewData.DescTextId, Array.Empty<string>());
			}
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00039BCD File Offset: 0x00037DCD
		protected override void OnBeforeDestroy()
		{
			this.CurrentCopyProtocolArray.Clear();
		}

		// Token: 0x0400041E RID: 1054
		private SdkProtocolViewData ViewData;

		// Token: 0x0400041F RID: 1055
		private UUIText DescText;

		// Token: 0x04000420 RID: 1056
		private UUIText TitleText;

		// Token: 0x04000421 RID: 1057
		private UUIButtonComponent EnterButton;

		// Token: 0x04000422 RID: 1058
		private UUIButtonComponent CancelButton;

		// Token: 0x04000423 RID: 1059
		private UUIButtonComponent ButtonL1;

		// Token: 0x04000424 RID: 1060
		private UUIButtonComponent ButtonR1;

		// Token: 0x04000425 RID: 1061
		private UUIButtonComponent ButtonTriangle;

		// Token: 0x04000426 RID: 1062
		private UUIButtonComponent ButtonL2;

		// Token: 0x04000427 RID: 1063
		private UUIButtonComponent ButtonR2;

		// Token: 0x04000428 RID: 1064
		[Nullable(1)]
		private readonly List<UUIButtonComponent> LayoutButtonList = new List<UUIButtonComponent>();

		// Token: 0x04000429 RID: 1065
		[Nullable(1)]
		private readonly List<ProtocolItem> CurrentCopyProtocolArray = new List<ProtocolItem>();

		// Token: 0x02000367 RID: 871
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x040011AA RID: 4522
			public const int EnterButton = 0;

			// Token: 0x040011AB RID: 4523
			public const int CancelButton = 1;

			// Token: 0x040011AC RID: 4524
			public const int ButtonL1 = 2;

			// Token: 0x040011AD RID: 4525
			public const int DescText = 3;

			// Token: 0x040011AE RID: 4526
			public const int VerticalLayout = 4;

			// Token: 0x040011AF RID: 4527
			public const int TitleText = 5;

			// Token: 0x040011B0 RID: 4528
			public const int ButtonR1 = 6;

			// Token: 0x040011B1 RID: 4529
			public const int ButtonTriangle = 7;

			// Token: 0x040011B2 RID: 4530
			public const int ButtonL2 = 8;

			// Token: 0x040011B3 RID: 4531
			public const int ButtonR2 = 9;

			// Token: 0x040011B4 RID: 4532
			public const int LeftButtonText = 10;

			// Token: 0x040011B5 RID: 4533
			public const int RightButtonText = 11;
		}
	}
}
