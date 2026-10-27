using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001491 RID: 5265
public class ActivityRegressMainTabTitlePanel : UiPanelBase
{
	// Token: 0x0600952A RID: 38186 RVA: 0x00202CD4 File Offset: 0x00200ED4
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

	// Token: 0x0600952B RID: 38187 RVA: 0x00202DE0 File Offset: 0x00200FE0
	[NullableContext(1)]
	public void UpdateIcon(string iconPath)
	{
		if (!StringUtils.IsEmpty(iconPath))
		{
			this.SetSpriteByPath(iconPath, base.GetSprite(0), false, null, null);
		}
	}

	// Token: 0x0600952C RID: 38188 RVA: 0x00202E10 File Offset: 0x00201010
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

	// Token: 0x0600952D RID: 38189 RVA: 0x00202E4E File Offset: 0x0020104E
	private void OnBackBtnClick()
	{
		Action onBackBtnCallBack = this.OnBackBtnCallBack;
		if (onBackBtnCallBack == null)
		{
			return;
		}
		onBackBtnCallBack();
	}

	// Token: 0x040041FE RID: 16894
	[Nullable(2)]
	public Action OnBackBtnCallBack;

	// Token: 0x02007AC1 RID: 31425
	private class EComponents
	{
		// Token: 0x04028634 RID: 165428
		public const int SprTitleIcon = 0;

		// Token: 0x04028635 RID: 165429
		public const int TxtTitle = 1;

		// Token: 0x04028636 RID: 165430
		public const int BtnHelpInfo = 2;

		// Token: 0x04028637 RID: 165431
		public const int BtnBack = 3;

		// Token: 0x04028638 RID: 165432
		public const int PnlCost = 4;
	}
}
