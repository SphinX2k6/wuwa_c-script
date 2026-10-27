using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061D8 RID: 25048
	public class ButtonWithRedDot : UiPanelBase
	{
		// Token: 0x0603F403 RID: 259075 RVA: 0x00F4891C File Offset: 0x00F46B1C
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

		// Token: 0x0603F404 RID: 259076 RVA: 0x00F48983 File Offset: 0x00F46B83
		private void ButtonClick()
		{
			if (this.ButtonFunction != null)
			{
				this.ButtonFunction();
			}
		}

		// Token: 0x0603F405 RID: 259077 RVA: 0x00F48998 File Offset: 0x00F46B98
		[NullableContext(1)]
		public void SetFunction(Action buttonFunction)
		{
			this.ButtonFunction = buttonFunction;
		}

		// Token: 0x0603F406 RID: 259078 RVA: 0x00F489A1 File Offset: 0x00F46BA1
		public void SetRedDotVisible(bool bVisible)
		{
			base.GetItem(1).SetUIActive(bVisible);
		}

		// Token: 0x04020F9C RID: 135068
		[Nullable(2)]
		private Action ButtonFunction;
	}
}
