using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x020051F9 RID: 20985
	public class ButtonWithRedDot : UiPanelBase
	{
		// Token: 0x0603443C RID: 214076 RVA: 0x00E9EE90 File Offset: 0x00E9D090
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.ButtonClick))
			};
		}

		// Token: 0x0603443D RID: 214077 RVA: 0x00E9EEF7 File Offset: 0x00E9D0F7
		private void ButtonClick()
		{
			if (this.ButtonFunction != null)
			{
				this.ButtonFunction();
			}
		}

		// Token: 0x0603443E RID: 214078 RVA: 0x00E9EF0C File Offset: 0x00E9D10C
		[NullableContext(1)]
		public void SetFunction(Action buttonFunction)
		{
			this.ButtonFunction = buttonFunction;
		}

		// Token: 0x0603443F RID: 214079 RVA: 0x00E9EF15 File Offset: 0x00E9D115
		public void SetRedDotVisible(bool bVisible)
		{
			base.GetItem(1).SetUIActive(bVisible);
		}

		// Token: 0x0401BBD4 RID: 113620
		[Nullable(2)]
		private Action ButtonFunction;
	}
}
