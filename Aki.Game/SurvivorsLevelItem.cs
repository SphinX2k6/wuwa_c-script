using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002096 RID: 8342
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsLevelItem : UiPanelBase
{
	// Token: 0x060148FC RID: 84220 RVA: 0x005FE300 File Offset: 0x005FC500
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

	// Token: 0x060148FD RID: 84221 RVA: 0x005FE393 File Offset: 0x005FC593
	private void OnButtonClicked()
	{
		Action<int> onButtonClickedCallback = this.OnButtonClickedCallback;
		if (onButtonClickedCallback == null)
		{
			return;
		}
		onButtonClickedCallback(this.LevelId);
	}

	// Token: 0x060148FE RID: 84222 RVA: 0x005FE3AB File Offset: 0x005FC5AB
	public void SetButtonInteractive(bool bEnable)
	{
		base.GetButton(0).SetSelfInteractive(bEnable);
	}

	// Token: 0x060148FF RID: 84223 RVA: 0x005FE3BA File Offset: 0x005FC5BA
	public void Refresh(int levelId, bool isEndless)
	{
		this.LevelId = levelId;
		base.GetItem(1).SetUIActive(!isEndless);
		base.GetItem(2).SetUIActive(isEndless);
	}

	// Token: 0x06014900 RID: 84224 RVA: 0x005FE3E0 File Offset: 0x005FC5E0
	public UUIItem GetBottomPosItem()
	{
		return base.GetItem(3);
	}

	// Token: 0x0400AE8B RID: 44683
	protected int LevelId;

	// Token: 0x0400AE8C RID: 44684
	public Action<int> OnButtonClickedCallback;
}
