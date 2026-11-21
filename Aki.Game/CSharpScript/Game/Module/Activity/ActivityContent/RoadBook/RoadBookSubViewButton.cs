using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x02005155 RID: 20821
	[NullableContext(1)]
	[Nullable(0)]
	public class RoadBookSubViewButton : UiPanelBase
	{
		// Token: 0x060340BE RID: 213182 RVA: 0x00E8F78E File Offset: 0x00E8D98E
		public RoadBookSubViewButton(ERoadBookSubType type)
		{
			this.Type = type;
		}

		// Token: 0x060340BF RID: 213183 RVA: 0x00E8F7A0 File Offset: 0x00E8D9A0
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

		// Token: 0x060340C0 RID: 213184 RVA: 0x00E8F833 File Offset: 0x00E8DA33
		public void SetProgressText(string text)
		{
			base.GetText(1).SetText(text, true);
		}

		// Token: 0x060340C1 RID: 213185 RVA: 0x00E8F843 File Offset: 0x00E8DA43
		public void RefreshRedDot(bool bVisible)
		{
			base.GetItem(2).SetUIActive(bVisible);
		}

		// Token: 0x060340C2 RID: 213186 RVA: 0x00E8F852 File Offset: 0x00E8DA52
		public void SetFunction(Action<ERoadBookSubType> func)
		{
			this.ClickedFunc = func;
		}

		// Token: 0x060340C3 RID: 213187 RVA: 0x00E8F85B File Offset: 0x00E8DA5B
		private void OnClickedButton()
		{
			Action<ERoadBookSubType> clickedFunc = this.ClickedFunc;
			if (clickedFunc == null)
			{
				return;
			}
			clickedFunc(this.Type);
		}

		// Token: 0x0401B8C9 RID: 112841
		[Nullable(2)]
		private Action<ERoadBookSubType> ClickedFunc;

		// Token: 0x0401B8CA RID: 112842
		protected ERoadBookSubType Type;
	}
}
