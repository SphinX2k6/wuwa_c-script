using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.GameMainView.DangoBrawl.Item
{
	// Token: 0x02005A13 RID: 23059
	public class DangoBrawlPlayRateButton : UiPanelBase
	{
		// Token: 0x0603A79F RID: 239519 RVA: 0x00DEA768 File Offset: 0x00DE8968
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedSpeed));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603A7A0 RID: 239520 RVA: 0x00DEA850 File Offset: 0x00DE8A50
		protected override void OnStart()
		{
			this.RefreshPlayRateShow();
		}

		// Token: 0x0603A7A1 RID: 239521 RVA: 0x00DEA858 File Offset: 0x00DE8A58
		public void RefreshPlayRateShow()
		{
			float playRate = DangoBrawlModel.Instance.GetPlayRate();
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.SetText(playRate.ToString("F1") + "X", true);
			}
			bool flag = playRate != 1f;
			if (text != null)
			{
				UUIItem uuiitem = text;
				bool bUseChangeColor = flag;
				FColor? fcolor = new FColor?(text.changeColor);
				uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			}
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(!flag);
		}

		// Token: 0x0603A7A2 RID: 239522 RVA: 0x00DEA8E4 File Offset: 0x00DE8AE4
		private void OnClickedSpeed()
		{
			DangoBrawlModel.Instance.SetPlayRate();
			this.RefreshPlayRateShow();
		}

		// Token: 0x0200BC83 RID: 48259
		private enum EComp
		{
			// Token: 0x04038E05 RID: 232965
			BtnSpeed,
			// Token: 0x04038E06 RID: 232966
			PanelOn,
			// Token: 0x04038E07 RID: 232967
			PanelOff,
			// Token: 0x04038E08 RID: 232968
			TxtSpeed
		}
	}
}
