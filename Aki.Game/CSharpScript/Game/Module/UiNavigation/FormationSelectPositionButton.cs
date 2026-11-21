using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003895 RID: 14485
	public class FormationSelectPositionButton : NavigationButton
	{
		// Token: 0x060259B6 RID: 154038 RVA: 0x00A95F7A File Offset: 0x00A9417A
		[NullableContext(1)]
		public FormationSelectPositionButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x060259B7 RID: 154039 RVA: 0x00A95F85 File Offset: 0x00A94185
		protected override void OnInit()
		{
			base.OnInit();
		}

		// Token: 0x060259B8 RID: 154040 RVA: 0x00A95F8D File Offset: 0x00A9418D
		protected override void OnNotifyFocusListener(bool isSameListener)
		{
			FormationViewDragController.SetGamePadSelectPosition(int.Parse(this.ParamList[0]));
		}
	}
}
