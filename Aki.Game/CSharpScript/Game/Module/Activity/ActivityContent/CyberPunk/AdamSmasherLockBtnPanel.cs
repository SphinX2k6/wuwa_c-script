using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x020068AB RID: 26795
	public class AdamSmasherLockBtnPanel : UiPanelBase
	{
		// Token: 0x06042DE5 RID: 273893 RVA: 0x01047CE4 File Offset: 0x01045EE4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x06042DE6 RID: 273894 RVA: 0x01047D3E File Offset: 0x01045F3E
		protected override void OnStart()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "AdamChallenge_Lock", Array.Empty<object>());
			base.GetItem(2).SetUIActive(false);
		}

		// Token: 0x0200CA7D RID: 51837
		private enum ELockBtnItemComponent
		{
			// Token: 0x0403D35C RID: 250716
			LockIcon,
			// Token: 0x0403D35D RID: 250717
			Txt,
			// Token: 0x0403D35E RID: 250718
			Button
		}
	}
}
