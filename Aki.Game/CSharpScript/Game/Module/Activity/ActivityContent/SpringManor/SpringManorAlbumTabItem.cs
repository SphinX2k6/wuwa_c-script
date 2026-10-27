using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x0200605A RID: 24666
	public class SpringManorAlbumTabItem : UiPanelBase
	{
		// Token: 0x0603E689 RID: 255625 RVA: 0x00F132B0 File Offset: 0x00F114B0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
		}

		// Token: 0x0603E68A RID: 255626 RVA: 0x00F13320 File Offset: 0x00F11520
		[NullableContext(1)]
		public void SetTitle(string title)
		{
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew(title);
		}

		// Token: 0x0603E68B RID: 255627 RVA: 0x00F13334 File Offset: 0x00F11534
		public void InitProgress(int curNum, int maxNum)
		{
			this.MaxNum = maxNum;
			this.SetCurProgress(curNum);
		}

		// Token: 0x0603E68C RID: 255628 RVA: 0x00F13344 File Offset: 0x00F11544
		public void SetCurProgress(int curNum)
		{
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(curNum);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.MaxNum);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0603E68D RID: 255629 RVA: 0x00F13394 File Offset: 0x00F11594
		public void SetSelected(bool isSelected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603E68E RID: 255630 RVA: 0x00F133B2 File Offset: 0x00F115B2
		public void SetRedDotActive(bool hasRedDot)
		{
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(hasRedDot);
		}

		// Token: 0x040209C5 RID: 133573
		private int MaxNum;
	}
}
