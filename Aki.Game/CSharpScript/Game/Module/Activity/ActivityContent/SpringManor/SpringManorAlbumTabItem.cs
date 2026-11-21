using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02004FD8 RID: 20440
	public class SpringManorAlbumTabItem : UiPanelBase
	{
		// Token: 0x0603334D RID: 209741 RVA: 0x00E5A074 File Offset: 0x00E58274
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

		// Token: 0x0603334E RID: 209742 RVA: 0x00E5A0E4 File Offset: 0x00E582E4
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

		// Token: 0x0603334F RID: 209743 RVA: 0x00E5A0F8 File Offset: 0x00E582F8
		public void InitProgress(int curNum, int maxNum)
		{
			this.MaxNum = maxNum;
			this.SetCurProgress(curNum);
		}

		// Token: 0x06033350 RID: 209744 RVA: 0x00E5A108 File Offset: 0x00E58308
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

		// Token: 0x06033351 RID: 209745 RVA: 0x00E5A158 File Offset: 0x00E58358
		public void SetSelected(bool isSelected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06033352 RID: 209746 RVA: 0x00E5A176 File Offset: 0x00E58376
		public void SetRedDotActive(bool hasRedDot)
		{
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(hasRedDot);
		}

		// Token: 0x0401B2F2 RID: 111346
		private int MaxNum;
	}
}
