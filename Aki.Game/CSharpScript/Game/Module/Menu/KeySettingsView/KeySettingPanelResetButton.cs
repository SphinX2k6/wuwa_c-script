using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x02005464 RID: 21604
	public class KeySettingPanelResetButton : UiPanelBase
	{
		// Token: 0x06037241 RID: 225857 RVA: 0x00D11ED4 File Offset: 0x00D100D4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x06037242 RID: 225858 RVA: 0x00D11F2E File Offset: 0x00D1012E
		[NullableContext(1)]
		public void SetConfirmText(string textId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, Array.Empty<object>());
		}

		// Token: 0x0200B6DA RID: 46810
		public class EComponent
		{
			// Token: 0x0403764E RID: 226894
			public const int Button = 0;

			// Token: 0x0403764F RID: 226895
			public const int TxtConfirm = 1;

			// Token: 0x04037650 RID: 226896
			public const int RedDot = 2;
		}
	}
}
