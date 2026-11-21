using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000945 RID: 2373
public class ActivityRegressMainTabTitlePanel : UiPanelBase
{
	// Token: 0x060068BF RID: 26815 RVA: 0x0020BC3C File Offset: 0x00209E3C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
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
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnBackBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060068C0 RID: 26816 RVA: 0x0020BD48 File Offset: 0x00209F48
	[NullableContext(1)]
	public void UpdateIcon(string iconPath)
	{
		if (!StringUtils.IsEmpty(iconPath))
		{
			this.SetSpriteByPath(iconPath, base.GetSprite(0), false, null, null);
		}
	}

	// Token: 0x060068C1 RID: 26817 RVA: 0x0020BD78 File Offset: 0x00209F78
	[NullableContext(2)]
	public void UpdateTitle(CommonTabTitleData titleData)
	{
		UUIText text = base.GetText(1);
		if (titleData != null)
		{
			text.SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(text, titleData.TextId, titleData.Args);
			return;
		}
		text.SetUIActive(false);
	}

	// Token: 0x060068C2 RID: 26818 RVA: 0x0020BDB6 File Offset: 0x00209FB6
	private void OnBackBtnClick()
	{
		Action onBackBtnCallBack = this.OnBackBtnCallBack;
		if (onBackBtnCallBack == null)
		{
			return;
		}
		onBackBtnCallBack();
	}

	// Token: 0x04004296 RID: 17046
	[Nullable(2)]
	public Action OnBackBtnCallBack;

	// Token: 0x02006C45 RID: 27717
	private class EComponents
	{
		// Token: 0x0402394E RID: 145742
		public const int SprTitleIcon = 0;

		// Token: 0x0402394F RID: 145743
		public const int TxtTitle = 1;

		// Token: 0x04023950 RID: 145744
		public const int BtnHelpInfo = 2;

		// Token: 0x04023951 RID: 145745
		public const int BtnBack = 3;

		// Token: 0x04023952 RID: 145746
		public const int PnlCost = 4;
	}
}
