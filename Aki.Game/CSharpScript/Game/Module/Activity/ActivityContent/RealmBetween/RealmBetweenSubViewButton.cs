using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x0200627A RID: 25210
	[NullableContext(1)]
	[Nullable(0)]
	public class RealmBetweenSubViewButton : UiPanelBase
	{
		// Token: 0x0603F774 RID: 259956 RVA: 0x00F57E3E File Offset: 0x00F5603E
		public RealmBetweenSubViewButton(ERealmBetweenSubType type)
		{
			this.Type = type;
		}

		// Token: 0x0603F775 RID: 259957 RVA: 0x00F57E50 File Offset: 0x00F56050
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUISprite))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickedButton))
			};
		}

		// Token: 0x0603F776 RID: 259958 RVA: 0x00F57EE3 File Offset: 0x00F560E3
		public void SetProgressText(string text)
		{
			base.GetText(1).SetText(text, true);
		}

		// Token: 0x0603F777 RID: 259959 RVA: 0x00F57EF3 File Offset: 0x00F560F3
		public void SeFinishIconState(bool b)
		{
			base.GetSprite(3).SetUIActive(b);
		}

		// Token: 0x0603F778 RID: 259960 RVA: 0x00F57F02 File Offset: 0x00F56102
		public void RefreshRedDot(bool bVisible)
		{
			base.GetItem(2).SetUIActive(bVisible);
		}

		// Token: 0x0603F779 RID: 259961 RVA: 0x00F57F11 File Offset: 0x00F56111
		public void SetFunction(Action<ERealmBetweenSubType> func)
		{
			this.ClickedFunc = func;
		}

		// Token: 0x0603F77A RID: 259962 RVA: 0x00F57F1A File Offset: 0x00F5611A
		private void OnClickedButton()
		{
			Action<ERealmBetweenSubType> clickedFunc = this.ClickedFunc;
			if (clickedFunc == null)
			{
				return;
			}
			clickedFunc(this.Type);
		}

		// Token: 0x040212A3 RID: 135843
		[Nullable(2)]
		private Action<ERealmBetweenSubType> ClickedFunc;

		// Token: 0x040212A4 RID: 135844
		protected ERealmBetweenSubType Type;
	}
}
