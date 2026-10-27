using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x0200627B RID: 25211
	public class ButtonWithRedDot : UiPanelBase
	{
		// Token: 0x0603F77B RID: 259963 RVA: 0x00F57F34 File Offset: 0x00F56134
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

		// Token: 0x0603F77C RID: 259964 RVA: 0x00F57F9B File Offset: 0x00F5619B
		private void ButtonClick()
		{
			if (this.ButtonFunction != null)
			{
				this.ButtonFunction();
			}
		}

		// Token: 0x0603F77D RID: 259965 RVA: 0x00F57FB0 File Offset: 0x00F561B0
		[NullableContext(1)]
		public void SetFunction(Action buttonFunction)
		{
			this.ButtonFunction = buttonFunction;
		}

		// Token: 0x0603F77E RID: 259966 RVA: 0x00F57FB9 File Offset: 0x00F561B9
		public void SetRedDotVisible(bool bVisible)
		{
			base.GetItem(1).SetUIActive(bVisible);
		}

		// Token: 0x040212A5 RID: 135845
		[Nullable(2)]
		private Action ButtonFunction;
	}
}
