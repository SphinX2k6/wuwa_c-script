using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005FB2 RID: 24498
	public class TotalTopUpRecharge37InfoItem : UiPanelBase
	{
		// Token: 0x0603E1A7 RID: 254375 RVA: 0x00EFF324 File Offset: 0x00EFD524
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(3, new Action(this.OnClickHelp))
			};
		}

		// Token: 0x0603E1A8 RID: 254376 RVA: 0x00EFF3B8 File Offset: 0x00EFD5B8
		public void SetScore(int score)
		{
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(score);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0603E1A9 RID: 254377 RVA: 0x00EFF3EF File Offset: 0x00EFD5EF
		public void SetHelpVisible(bool visible)
		{
			base.SetButtonUiActive(3, visible);
		}

		// Token: 0x0603E1AA RID: 254378 RVA: 0x00EFF3F9 File Offset: 0x00EFD5F9
		[NullableContext(1)]
		public void SetHelpCallback(Action callback)
		{
			this.HelpCallback = callback;
		}

		// Token: 0x0603E1AB RID: 254379 RVA: 0x00EFF402 File Offset: 0x00EFD602
		private void OnClickHelp()
		{
			Action helpCallback = this.HelpCallback;
			if (helpCallback == null)
			{
				return;
			}
			helpCallback();
		}

		// Token: 0x0402071E RID: 132894
		[Nullable(2)]
		private Action HelpCallback;
	}
}
