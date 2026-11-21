using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001370 RID: 4976
public class HonamiStoryItemTipsSideButton : UiPanelBase
{
	// Token: 0x0600C591 RID: 50577 RVA: 0x003ACED8 File Offset: 0x003AB0D8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClicked))
		};
	}

	// Token: 0x0600C592 RID: 50578 RVA: 0x003ACF58 File Offset: 0x003AB158
	[NullableContext(1)]
	public void SetSpriteByResourceId(string resourceId)
	{
		UiResourceConfig instance = UiResourceConfig.Instance;
		string path = ((instance != null) ? instance.GetResourcePath(resourceId) : null) ?? string.Empty;
		this.SetSpriteByPath(path, base.GetSprite(1), false, null, null);
	}

	// Token: 0x0600C593 RID: 50579 RVA: 0x003ACF9A File Offset: 0x003AB19A
	[NullableContext(1)]
	public void SetLocalTextNew(string key)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), key, Array.Empty<object>());
	}

	// Token: 0x0600C594 RID: 50580 RVA: 0x003ACFB3 File Offset: 0x003AB1B3
	private void OnClicked()
	{
		Action onClickedCb = this.OnClickedCb;
		if (onClickedCb == null)
		{
			return;
		}
		onClickedCb();
	}

	// Token: 0x0400708F RID: 28815
	[Nullable(2)]
	public Action OnClickedCb;

	// Token: 0x02007608 RID: 30216
	private enum EBtn
	{
		// Token: 0x04026548 RID: 157000
		Btn,
		// Token: 0x04026549 RID: 157001
		Sprite,
		// Token: 0x0402654A RID: 157002
		Txt
	}
}
