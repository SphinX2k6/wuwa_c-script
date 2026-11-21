using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000418 RID: 1048
public class DrinksQTEButton : UiPanelBase
{
	// Token: 0x06003868 RID: 14440 RVA: 0x00148884 File Offset: 0x00146A84
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickedBtn))
		};
	}

	// Token: 0x06003869 RID: 14441 RVA: 0x001488EB File Offset: 0x00146AEB
	protected override void OnStart()
	{
		this.SetSelfActive(true);
	}

	// Token: 0x0600386A RID: 14442 RVA: 0x001488F4 File Offset: 0x00146AF4
	public void SetSelfActive(bool isActive)
	{
		UUISprite sprite = base.GetSprite(1);
		if (sprite != null)
		{
			sprite.SetFillAmount(isActive > false);
		}
		this.CanClick = isActive;
		UUIButtonComponent button = base.GetButton(0);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(isActive);
	}

	// Token: 0x0600386B RID: 14443 RVA: 0x00148926 File Offset: 0x00146B26
	public void OnTick(float percent)
	{
		UUISprite sprite = base.GetSprite(1);
		if (sprite != null)
		{
			sprite.SetFillAmount(Math.Max(0f, percent));
		}
		if (percent <= 0f)
		{
			this.OnClickedBtn();
		}
	}

	// Token: 0x0600386C RID: 14444 RVA: 0x00148953 File Offset: 0x00146B53
	public void OnClickedBtn()
	{
		if (this.OnClickedCb != null && this.CanClick)
		{
			this.CanClick = false;
			this.OnClickedCb();
		}
	}

	// Token: 0x04002E5C RID: 11868
	[Nullable(2)]
	public Action OnClickedCb;

	// Token: 0x04002E5D RID: 11869
	protected bool CanClick;

	// Token: 0x02006744 RID: 26436
	private static class EBtn
	{
		// Token: 0x040221AA RID: 139690
		public const int Btn = 0;

		// Token: 0x040221AB RID: 139691
		public const int SpriteBar = 1;
	}
}
