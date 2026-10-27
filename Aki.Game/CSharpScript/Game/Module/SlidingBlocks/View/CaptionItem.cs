using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SlidingBlocks.View
{
	// Token: 0x02004B8E RID: 19342
	public class CaptionItem : UiPanelBase
	{
		// Token: 0x06032201 RID: 205313 RVA: 0x00BA4E6C File Offset: 0x00BA306C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(2, new Action(this.OnHelpInfoButtonClick)),
				new ValueTuple<int, Delegate>(3, new Action(this.OnCloseButtonClick))
			};
		}

		// Token: 0x06032202 RID: 205314 RVA: 0x00BA4F18 File Offset: 0x00BA3118
		protected override UniTask OnBeforeStartAsync()
		{
			CaptionItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CaptionItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032203 RID: 205315 RVA: 0x00BA4F5B File Offset: 0x00BA315B
		private void OnHelpInfoButtonClick()
		{
			HelpController.Instance.OpenHelpById(581);
		}

		// Token: 0x06032204 RID: 205316 RVA: 0x00BA4F6C File Offset: 0x00BA316C
		private void OnCloseButtonClick()
		{
			SlidingBlocksController.Instance.SendGameEnd(SlidingBlocksDefine.EGameEndReason.ClickClose);
		}

		// Token: 0x0401AB43 RID: 109379
		private const int TETRISGAME_HELP_ID = 581;

		// Token: 0x0200AD91 RID: 44433
		private enum EViewComponent
		{
			// Token: 0x04034B72 RID: 215922
			SpriteTitleIcon,
			// Token: 0x04034B73 RID: 215923
			TitleText,
			// Token: 0x04034B74 RID: 215924
			HelpInfoButton,
			// Token: 0x04034B75 RID: 215925
			CloseButton
		}
	}
}
