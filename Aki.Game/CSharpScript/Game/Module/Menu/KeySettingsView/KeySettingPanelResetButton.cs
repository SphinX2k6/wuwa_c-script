using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x02004447 RID: 17479
	public class KeySettingPanelResetButton : UiPanelBase
	{
		// Token: 0x0602C18A RID: 180618 RVA: 0x00C612EC File Offset: 0x00C5F4EC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0602C18B RID: 180619 RVA: 0x00C61346 File Offset: 0x00C5F546
		[NullableContext(1)]
		public void SetConfirmText(string textId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, Array.Empty<object>());
		}

		// Token: 0x0200A112 RID: 41234
		public class EComponent
		{
			// Token: 0x040320A3 RID: 204963
			public const int Button = 0;

			// Token: 0x040320A4 RID: 204964
			public const int TxtConfirm = 1;

			// Token: 0x040320A5 RID: 204965
			public const int RedDot = 2;
		}
	}
}
