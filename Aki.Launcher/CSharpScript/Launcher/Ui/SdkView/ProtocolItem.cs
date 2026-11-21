using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Ui.HotFix;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.SdkView
{
	// Token: 0x020000CA RID: 202
	[NullableContext(1)]
	[Nullable(0)]
	internal class ProtocolItem : LaunchComponentsAction
	{
		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x00039BF8 File Offset: 0x00037DF8
		public SdkProtocolView Owner { get; }

		// Token: 0x060006B6 RID: 1718 RVA: 0x00039C00 File Offset: 0x00037E00
		public ProtocolItem(SdkProtocolView owner)
		{
			this.Owner = owner;
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00039C0F File Offset: 0x00037E0F
		public void SetActor(AActor actor)
		{
			base.SetRootActorLaunchComponentsAction(actor);
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00039C18 File Offset: 0x00037E18
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

		// Token: 0x060006B9 RID: 1721 RVA: 0x00039C56 File Offset: 0x00037E56
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

		// Token: 0x060006BA RID: 1722 RVA: 0x00039C78 File Offset: 0x00037E78
		public void Refresh(SdkProtocolViewLayoutData data)
		{
			this.Data = data;
			HotFixManager.SetLocalText(this.DescText, data.TextId, Array.Empty<string>());
		}

		// Token: 0x0400042B RID: 1067
		[Nullable(2)]
		public SdkProtocolViewLayoutData Data;

		// Token: 0x0400042C RID: 1068
		[Nullable(2)]
		private UUIButtonComponent ClickButton;

		// Token: 0x0400042D RID: 1069
		[Nullable(2)]
		private UUIText DescText;

		// Token: 0x02000369 RID: 873
		[NullableContext(0)]
		private static class EProtocolItemComponents
		{
			// Token: 0x040011BC RID: 4540
			public const int ClickButton = 0;

			// Token: 0x040011BD RID: 4541
			public const int DescText = 1;
		}
	}
}
