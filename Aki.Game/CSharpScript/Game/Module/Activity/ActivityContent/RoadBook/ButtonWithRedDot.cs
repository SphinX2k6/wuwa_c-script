using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x02005156 RID: 20822
	public class ButtonWithRedDot : UiPanelBase
	{
		// Token: 0x060340C4 RID: 213188 RVA: 0x00E8F874 File Offset: 0x00E8DA74
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

		// Token: 0x060340C5 RID: 213189 RVA: 0x00E8F8DB File Offset: 0x00E8DADB
		private void ButtonClick()
		{
			if (this.ButtonFunction != null)
			{
				this.ButtonFunction();
			}
		}

		// Token: 0x060340C6 RID: 213190 RVA: 0x00E8F8F0 File Offset: 0x00E8DAF0
		[NullableContext(1)]
		public void SetFunction(Action buttonFunction)
		{
			this.ButtonFunction = buttonFunction;
		}

		// Token: 0x060340C7 RID: 213191 RVA: 0x00E8F8F9 File Offset: 0x00E8DAF9
		public void SetRedDotVisible(bool bVisible)
		{
			base.GetItem(1).SetUIActive(bVisible);
		}

		// Token: 0x0401B8CB RID: 112843
		[Nullable(2)]
		private Action ButtonFunction;
	}
}
