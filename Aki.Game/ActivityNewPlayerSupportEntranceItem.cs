using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020013B9 RID: 5049
public class ActivityNewPlayerSupportEntranceItem : UiPanelBase
{
	// Token: 0x06008E6F RID: 36463 RVA: 0x001EBBA4 File Offset: 0x001E9DA4
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

	// Token: 0x06008E70 RID: 36464 RVA: 0x001EBC21 File Offset: 0x001E9E21
	protected override void OnBeforeDestroy()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(2), 0);
			this.RedDotName = null;
		}
	}

	// Token: 0x06008E71 RID: 36465 RVA: 0x001EBC59 File Offset: 0x001E9E59
	[NullableContext(1)]
	public void SetEntranceFunc(Action func)
	{
		this.EntranceFunc = func;
	}

	// Token: 0x06008E72 RID: 36466 RVA: 0x001EBC62 File Offset: 0x001E9E62
	public void BindRedDot(ERedDotName redDotName)
	{
		this.RedDotName = new ERedDotName?(redDotName);
		RedDotController.Instance.BindRedDot(redDotName, base.GetItem(2), null, 0);
	}

	// Token: 0x06008E73 RID: 36467 RVA: 0x001EBC84 File Offset: 0x001E9E84
	private void OnEntranceBtnClick()
	{
		Action entranceFunc = this.EntranceFunc;
		if (entranceFunc == null)
		{
			return;
		}
		entranceFunc();
	}

	// Token: 0x04003F0C RID: 16140
	[Nullable(2)]
	private Action EntranceFunc;

	// Token: 0x04003F0D RID: 16141
	private ERedDotName? RedDotName;

	// Token: 0x02007A30 RID: 31280
	private static class EEntranceComponentType
	{
		// Token: 0x04028384 RID: 164740
		public const int EntranceBtn = 0;

		// Token: 0x04028385 RID: 164741
		public const int EntranceText = 1;

		// Token: 0x04028386 RID: 164742
		public const int RedDotItem = 2;
	}
}
