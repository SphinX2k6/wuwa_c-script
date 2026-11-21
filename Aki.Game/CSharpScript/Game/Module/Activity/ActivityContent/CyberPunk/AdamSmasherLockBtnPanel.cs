using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x020057FB RID: 22523
	public class AdamSmasherLockBtnPanel : UiPanelBase
	{
		// Token: 0x0603793D RID: 227645 RVA: 0x00F892F4 File Offset: 0x00F874F4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0603793E RID: 227646 RVA: 0x00F8934E File Offset: 0x00F8754E
		protected override void OnStart()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "AdamChallenge_Lock", Array.Empty<object>());
			base.GetItem(2).SetUIActive(false);
		}

		// Token: 0x0200B445 RID: 46149
		private enum ELockBtnItemComponent
		{
			// Token: 0x04037C37 RID: 228407
			LockIcon,
			// Token: 0x04037C38 RID: 228408
			Txt,
			// Token: 0x04037C39 RID: 228409
			Button
		}
	}
}
