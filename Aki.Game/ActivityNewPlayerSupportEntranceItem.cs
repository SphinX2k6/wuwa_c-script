using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200086D RID: 2157
public class ActivityNewPlayerSupportEntranceItem : UiPanelBase
{
	// Token: 0x06006204 RID: 25092 RVA: 0x001F46C4 File Offset: 0x001F28C4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnEntranceBtnClick))
		};
	}

	// Token: 0x06006205 RID: 25093 RVA: 0x001F4741 File Offset: 0x001F2941
	protected override void OnBeforeDestroy()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(2), 0);
			this.RedDotName = null;
		}
	}

	// Token: 0x06006206 RID: 25094 RVA: 0x001F4779 File Offset: 0x001F2979
	[NullableContext(1)]
	public void SetEntranceFunc(Action func)
	{
		this.EntranceFunc = func;
	}

	// Token: 0x06006207 RID: 25095 RVA: 0x001F4782 File Offset: 0x001F2982
	public void BindRedDot(ERedDotName redDotName)
	{
		this.RedDotName = new ERedDotName?(redDotName);
		RedDotController.Instance.BindRedDot(redDotName, base.GetItem(2), null, 0);
	}

	// Token: 0x06006208 RID: 25096 RVA: 0x001F47A4 File Offset: 0x001F29A4
	private void OnEntranceBtnClick()
	{
		Action entranceFunc = this.EntranceFunc;
		if (entranceFunc == null)
		{
			return;
		}
		entranceFunc();
	}

	// Token: 0x04003FA4 RID: 16292
	[Nullable(2)]
	private Action EntranceFunc;

	// Token: 0x04003FA5 RID: 16293
	private ERedDotName? RedDotName;

	// Token: 0x02006BB6 RID: 27574
	private static class EEntranceComponentType
	{
		// Token: 0x040236A1 RID: 145057
		public const int EntranceBtn = 0;

		// Token: 0x040236A2 RID: 145058
		public const int EntranceText = 1;

		// Token: 0x040236A3 RID: 145059
		public const int RedDotItem = 2;
	}
}
