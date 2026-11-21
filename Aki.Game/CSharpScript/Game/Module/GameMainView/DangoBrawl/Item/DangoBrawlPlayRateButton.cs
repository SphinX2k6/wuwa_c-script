using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.GameMainView.DangoBrawl.Item
{
	// Token: 0x020049EF RID: 18927
	public class DangoBrawlPlayRateButton : UiPanelBase
	{
		// Token: 0x0602F6E8 RID: 194280 RVA: 0x00D3AD00 File Offset: 0x00D38F00
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

		// Token: 0x0602F6E9 RID: 194281 RVA: 0x00D3ADE8 File Offset: 0x00D38FE8
		protected override void OnStart()
		{
			this.RefreshPlayRateShow();
		}

		// Token: 0x0602F6EA RID: 194282 RVA: 0x00D3ADF0 File Offset: 0x00D38FF0
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

		// Token: 0x0602F6EB RID: 194283 RVA: 0x00D3AE7C File Offset: 0x00D3907C
		private void OnClickedSpeed()
		{
			DangoBrawlModel.Instance.SetPlayRate();
			this.RefreshPlayRateShow();
		}

		// Token: 0x0200A68C RID: 42636
		private enum EComp
		{
			// Token: 0x040337D0 RID: 210896
			BtnSpeed,
			// Token: 0x040337D1 RID: 210897
			PanelOn,
			// Token: 0x040337D2 RID: 210898
			PanelOff,
			// Token: 0x040337D3 RID: 210899
			TxtSpeed
		}
	}
}
