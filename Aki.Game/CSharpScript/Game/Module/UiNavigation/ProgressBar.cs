using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020048EC RID: 18668
	public class ProgressBar : UiPanelBase
	{
		// Token: 0x06030D17 RID: 199959 RVA: 0x00B5601F File Offset: 0x00B5421F
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite))
			};
		}

		// Token: 0x06030D18 RID: 199960 RVA: 0x00B56042 File Offset: 0x00B54242
		protected override void OnStart()
		{
			this.SetPercent(0f);
		}

		// Token: 0x06030D19 RID: 199961 RVA: 0x00B5604F File Offset: 0x00B5424F
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
