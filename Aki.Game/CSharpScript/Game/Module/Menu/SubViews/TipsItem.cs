using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02004423 RID: 17443
	public class TipsItem : UiPanelBase
	{
		// Token: 0x0602C067 RID: 180327 RVA: 0x00C5C520 File Offset: 0x00C5A720
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent))
			};
		}

		// Token: 0x0602C068 RID: 180328 RVA: 0x00C5C57A File Offset: 0x00C5A77A
		protected override void OnBeforeShow()
		{
			base.GetSprite(0).SetUIActive(false);
			base.SetButtonUiActive(2, false);
		}
	}
}
