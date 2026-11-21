using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SlidingBlocks.View
{
	// Token: 0x02003B38 RID: 15160
	public class CaptionItem : UiPanelBase
	{
		// Token: 0x06026F91 RID: 159633 RVA: 0x00AE8FB8 File Offset: 0x00AE71B8
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

		// Token: 0x06026F92 RID: 159634 RVA: 0x00AE9064 File Offset: 0x00AE7264
		protected override UniTask OnBeforeStartAsync()
		{
			CaptionItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CaptionItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026F93 RID: 159635 RVA: 0x00AE90A7 File Offset: 0x00AE72A7
		private void OnHelpInfoButtonClick()
		{
			HelpController.Instance.OpenHelpById(581);
		}

		// Token: 0x06026F94 RID: 159636 RVA: 0x00AE90B8 File Offset: 0x00AE72B8
		private void OnCloseButtonClick()
		{
			SlidingBlocksController.Instance.SendGameEnd(SlidingBlocksDefine.EGameEndReason.ClickClose);
		}

		// Token: 0x04015497 RID: 87191
		private const int TETRISGAME_HELP_ID = 581;

		// Token: 0x020097B0 RID: 38832
		private enum EViewComponent
		{
			// Token: 0x0402F519 RID: 193817
			SpriteTitleIcon,
			// Token: 0x0402F51A RID: 193818
			TitleText,
			// Token: 0x0402F51B RID: 193819
			HelpInfoButton,
			// Token: 0x0402F51C RID: 193820
			CloseButton
		}
	}
}
