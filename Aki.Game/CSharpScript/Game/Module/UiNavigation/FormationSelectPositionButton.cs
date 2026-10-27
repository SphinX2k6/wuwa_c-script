using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200491E RID: 18718
	public class FormationSelectPositionButton : NavigationButton
	{
		// Token: 0x06030E89 RID: 200329 RVA: 0x00B5B10A File Offset: 0x00B5930A
		[NullableContext(1)]
		public FormationSelectPositionButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030E8A RID: 200330 RVA: 0x00B5B115 File Offset: 0x00B59315
		protected override void OnInit()
		{
			base.OnInit();
		}

		// Token: 0x06030E8B RID: 200331 RVA: 0x00B5B11D File Offset: 0x00B5931D
		protected override void OnNotifyFocusListener(bool isSameListener)
		{
			FormationViewDragController.SetGamePadSelectPosition(int.Parse(this.ParamList[0]));
		}
	}
}
