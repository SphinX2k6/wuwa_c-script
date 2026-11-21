using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.View
{
	// Token: 0x02003653 RID: 13907
	public class WuWaGoPauseCaptionPanel : UiPanelBase
	{
		// Token: 0x06024131 RID: 147761 RVA: 0x00A358F0 File Offset: 0x00A33AF0
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

		// Token: 0x06024132 RID: 147762 RVA: 0x00A35A5C File Offset: 0x00A33C5C
		protected override void OnBeforeCreate()
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(true);
		}

		// Token: 0x06024133 RID: 147763 RVA: 0x00A35A6F File Offset: 0x00A33C6F
		private void OnBackButtonClick()
		{
			UiManager.Instance.CloseView(EUiViewName.WuWaGoPauseView, null);
		}

		// Token: 0x0200932D RID: 37677
		private enum ECaptionPanelComponent
		{
			// Token: 0x0402E0C6 RID: 188614
			SprTitleIcon,
			// Token: 0x0402E0C7 RID: 188615
			TxtTitle,
			// Token: 0x0402E0C8 RID: 188616
			BtnHelpInfo,
			// Token: 0x0402E0C9 RID: 188617
			BtnBack,
			// Token: 0x0402E0CA RID: 188618
			PnlCost,
			// Token: 0x0402E0CB RID: 188619
			PnlTabInfo,
			// Token: 0x0402E0CC RID: 188620
			PnlHome,
			// Token: 0x0402E0CD RID: 188621
			PnlTabInfoNoInter
		}
	}
}
