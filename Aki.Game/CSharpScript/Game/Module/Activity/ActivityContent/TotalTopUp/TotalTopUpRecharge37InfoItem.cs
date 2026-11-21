using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004F99 RID: 20377
	public class TotalTopUpRecharge37InfoItem : UiPanelBase
	{
		// Token: 0x06033141 RID: 209217 RVA: 0x00E50FE0 File Offset: 0x00E4F1E0
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

		// Token: 0x06033142 RID: 209218 RVA: 0x00E51074 File Offset: 0x00E4F274
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

		// Token: 0x06033143 RID: 209219 RVA: 0x00E510AB File Offset: 0x00E4F2AB
		public void SetHelpVisible(bool visible)
		{
			base.SetButtonUiActive(3, visible);
		}

		// Token: 0x06033144 RID: 209220 RVA: 0x00E510B5 File Offset: 0x00E4F2B5
		[NullableContext(1)]
		public void SetHelpCallback(Action callback)
		{
			this.HelpCallback = callback;
		}

		// Token: 0x06033145 RID: 209221 RVA: 0x00E510BE File Offset: 0x00E4F2BE
		private void OnClickHelp()
		{
			Action helpCallback = this.HelpCallback;
			if (helpCallback == null)
			{
				return;
			}
			helpCallback();
		}

		// Token: 0x0401B1F0 RID: 111088
		[Nullable(2)]
		private Action HelpCallback;
	}
}
