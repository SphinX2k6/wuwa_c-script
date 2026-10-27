using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Ui.HotFix;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.SdkView
{
	// Token: 0x020000C7 RID: 199
	[NullableContext(1)]
	[Nullable(0)]
	internal class ProtocolItem : LaunchComponentsAction
	{
		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x000380C8 File Offset: 0x000362C8
		public SdkProtocolView Owner { get; }

		// Token: 0x0600069A RID: 1690 RVA: 0x000380D0 File Offset: 0x000362D0
		public ProtocolItem(SdkProtocolView owner)
		{
			this.Owner = owner;
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x000380DF File Offset: 0x000362DF
		public void SetActor(AActor actor)
		{
			base.SetRootActorLaunchComponentsAction(actor);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x000380E8 File Offset: 0x000362E8
		protected override void OnStart()
		{
			this.ClickButton = base.GetButton(0);
			UUIButtonComponent clickButton = this.ClickButton;
			if (clickButton != null)
			{
				clickButton.OnClickCallBack.Bind(new Action(this.OnClickButton));
			}
			this.DescText = base.GetText(1);
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00038126 File Offset: 0x00036326
		private void OnClickButton()
		{
			SdkProtocolViewLayoutData data = this.Data;
			if (data == null)
			{
				return;
			}
			Action<SdkProtocolView> clickCallBack = data.ClickCallBack;
			if (clickCallBack == null)
			{
				return;
			}
			clickCallBack(this.Owner);
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00038148 File Offset: 0x00036348
		public void Refresh(SdkProtocolViewLayoutData data)
		{
			this.Data = data;
			HotFixManager.SetLocalText(this.DescText, data.TextId, Array.Empty<string>());
		}

		// Token: 0x040003FC RID: 1020
		[Nullable(2)]
		public SdkProtocolViewLayoutData Data;

		// Token: 0x040003FD RID: 1021
		[Nullable(2)]
		private UUIButtonComponent ClickButton;

		// Token: 0x040003FE RID: 1022
		[Nullable(2)]
		private UUIText DescText;

		// Token: 0x0200035E RID: 862
		[NullableContext(0)]
		private static class EProtocolItemComponents
		{
			// Token: 0x0400115A RID: 4442
			public const int ClickButton = 0;

			// Token: 0x0400115B RID: 4443
			public const int DescText = 1;
		}
	}
}
