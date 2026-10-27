using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02005440 RID: 21568
	public class TipsItem : UiPanelBase
	{
		// Token: 0x0603711E RID: 225566 RVA: 0x00D0D100 File Offset: 0x00D0B300
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent))
			};
		}

		// Token: 0x0603711F RID: 225567 RVA: 0x00D0D15A File Offset: 0x00D0B35A
		protected override void OnBeforeShow()
		{
			base.GetSprite(0).SetUIActive(false);
			base.SetButtonUiActive(2, false);
		}
	}
}
