using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061D7 RID: 25047
	[NullableContext(1)]
	[Nullable(0)]
	public class RoadBookSubViewButton : UiPanelBase
	{
		// Token: 0x0603F3FD RID: 259069 RVA: 0x00F48836 File Offset: 0x00F46A36
		public RoadBookSubViewButton(ERoadBookSubType type)
		{
			this.Type = type;
		}

		// Token: 0x0603F3FE RID: 259070 RVA: 0x00F48848 File Offset: 0x00F46A48
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickedButton))
			};
		}

		// Token: 0x0603F3FF RID: 259071 RVA: 0x00F488DB File Offset: 0x00F46ADB
		public void SetProgressText(string text)
		{
			base.GetText(1).SetText(text, true);
		}

		// Token: 0x0603F400 RID: 259072 RVA: 0x00F488EB File Offset: 0x00F46AEB
		public void RefreshRedDot(bool bVisible)
		{
			base.GetItem(2).SetUIActive(bVisible);
		}

		// Token: 0x0603F401 RID: 259073 RVA: 0x00F488FA File Offset: 0x00F46AFA
		public void SetFunction(Action<ERoadBookSubType> func)
		{
			this.ClickedFunc = func;
		}

		// Token: 0x0603F402 RID: 259074 RVA: 0x00F48903 File Offset: 0x00F46B03
		private void OnClickedButton()
		{
			Action<ERoadBookSubType> clickedFunc = this.ClickedFunc;
			if (clickedFunc == null)
			{
				return;
			}
			clickedFunc(this.Type);
		}

		// Token: 0x04020F9A RID: 135066
		[Nullable(2)]
		private Action<ERoadBookSubType> ClickedFunc;

		// Token: 0x04020F9B RID: 135067
		protected ERoadBookSubType Type;
	}
}
