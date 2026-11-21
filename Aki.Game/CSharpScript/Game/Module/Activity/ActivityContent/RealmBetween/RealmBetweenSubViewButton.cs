using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x020051F8 RID: 20984
	[NullableContext(1)]
	[Nullable(0)]
	public class RealmBetweenSubViewButton : UiPanelBase
	{
		// Token: 0x06034435 RID: 214069 RVA: 0x00E9ED9A File Offset: 0x00E9CF9A
		public RealmBetweenSubViewButton(ERealmBetweenSubType type)
		{
			this.Type = type;
		}

		// Token: 0x06034436 RID: 214070 RVA: 0x00E9EDAC File Offset: 0x00E9CFAC
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

		// Token: 0x06034437 RID: 214071 RVA: 0x00E9EE3F File Offset: 0x00E9D03F
		public void SetProgressText(string text)
		{
			base.GetText(1).SetText(text, true);
		}

		// Token: 0x06034438 RID: 214072 RVA: 0x00E9EE4F File Offset: 0x00E9D04F
		public void SeFinishIconState(bool b)
		{
			base.GetSprite(3).SetUIActive(b);
		}

		// Token: 0x06034439 RID: 214073 RVA: 0x00E9EE5E File Offset: 0x00E9D05E
		public void RefreshRedDot(bool bVisible)
		{
			base.GetItem(2).SetUIActive(bVisible);
		}

		// Token: 0x0603443A RID: 214074 RVA: 0x00E9EE6D File Offset: 0x00E9D06D
		public void SetFunction(Action<ERealmBetweenSubType> func)
		{
			this.ClickedFunc = func;
		}

		// Token: 0x0603443B RID: 214075 RVA: 0x00E9EE76 File Offset: 0x00E9D076
		private void OnClickedButton()
		{
			Action<ERealmBetweenSubType> clickedFunc = this.ClickedFunc;
			if (clickedFunc == null)
			{
				return;
			}
			clickedFunc(this.Type);
		}

		// Token: 0x0401BBD2 RID: 113618
		[Nullable(2)]
		private Action<ERealmBetweenSubType> ClickedFunc;

		// Token: 0x0401BBD3 RID: 113619
		protected ERealmBetweenSubType Type;
	}
}
