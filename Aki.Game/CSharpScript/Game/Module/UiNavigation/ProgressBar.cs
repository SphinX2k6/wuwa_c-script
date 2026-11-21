using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003863 RID: 14435
	public class ProgressBar : UiPanelBase
	{
		// Token: 0x06025844 RID: 153668 RVA: 0x00A90E8F File Offset: 0x00A8F08F
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite))
			};
		}

		// Token: 0x06025845 RID: 153669 RVA: 0x00A90EB2 File Offset: 0x00A8F0B2
		protected override void OnStart()
		{
			this.SetPercent(0f);
		}

		// Token: 0x06025846 RID: 153670 RVA: 0x00A90EBF File Offset: 0x00A8F0BF
		public void SetPercent(float value)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount(value);
		}
	}
}
