using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002B1A RID: 11034
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsLevelItem : UiPanelBase
{
	// Token: 0x06016ECB RID: 93899 RVA: 0x005D1784 File Offset: 0x005CF984
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnButtonClicked))
		};
	}

	// Token: 0x06016ECC RID: 93900 RVA: 0x005D1817 File Offset: 0x005CFA17
	private void OnButtonClicked()
	{
		Action<int> onButtonClickedCallback = this.OnButtonClickedCallback;
		if (onButtonClickedCallback == null)
		{
			return;
		}
		onButtonClickedCallback(this.LevelId);
	}

	// Token: 0x06016ECD RID: 93901 RVA: 0x005D182F File Offset: 0x005CFA2F
	public void SetButtonInteractive(bool bEnable)
	{
		base.GetButton(0).SetSelfInteractive(bEnable);
	}

	// Token: 0x06016ECE RID: 93902 RVA: 0x005D183E File Offset: 0x005CFA3E
	public void Refresh(int levelId, bool isEndless)
	{
		this.LevelId = levelId;
		base.GetItem(1).SetUIActive(!isEndless);
		base.GetItem(2).SetUIActive(isEndless);
	}

	// Token: 0x06016ECF RID: 93903 RVA: 0x005D1864 File Offset: 0x005CFA64
	public UUIItem GetBottomPosItem()
	{
		return base.GetItem(3);
	}

	// Token: 0x0400AA85 RID: 43653
	protected int LevelId;

	// Token: 0x0400AA86 RID: 43654
	public Action<int> OnButtonClickedCallback;
}
