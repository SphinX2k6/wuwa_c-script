using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006081 RID: 24705
	public class DollGrabMachinePauseCaptionPanel : UiPanelBase
	{
		// Token: 0x0603B489 RID: 242825 RVA: 0x010C6848 File Offset: 0x010C4A48
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnBackButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603B48A RID: 242826 RVA: 0x010C69B4 File Offset: 0x010C4BB4
		protected override void OnBeforeCreate()
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(true);
		}

		// Token: 0x0603B48B RID: 242827 RVA: 0x010C69C7 File Offset: 0x010C4BC7
		private void OnBackButtonClick()
		{
			UiManager.Instance.CloseView(EUiViewName.DollGrabMachinePauseView, null);
			DollGrabMachineController.Instance.ResumeDollGrabMachine();
		}

		// Token: 0x0200B95B RID: 47451
		private enum ECaptionPanelComponent
		{
			// Token: 0x040392AC RID: 234156
			SprTitleIcon,
			// Token: 0x040392AD RID: 234157
			TxtTitle,
			// Token: 0x040392AE RID: 234158
			BtnHelpInfo,
			// Token: 0x040392AF RID: 234159
			BtnBack,
			// Token: 0x040392B0 RID: 234160
			PnlCost,
			// Token: 0x040392B1 RID: 234161
			PnlTabInfo,
			// Token: 0x040392B2 RID: 234162
			PnlHome,
			// Token: 0x040392B3 RID: 234163
			PnlTabInfoNoInter
		}
	}
}
