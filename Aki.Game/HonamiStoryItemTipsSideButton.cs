using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001EAE RID: 7854
public class HonamiStoryItemTipsSideButton : UiPanelBase
{
	// Token: 0x0600F172 RID: 61810 RVA: 0x003A13D0 File Offset: 0x0039F5D0
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

	// Token: 0x0600F173 RID: 61811 RVA: 0x003A1450 File Offset: 0x0039F650
	[NullableContext(1)]
	public void SetSpriteByResourceId(string resourceId)
	{
		UiResourceConfig instance = UiResourceConfig.Instance;
		string path = ((instance != null) ? instance.GetResourcePath(resourceId) : null) ?? string.Empty;
		this.SetSpriteByPath(path, base.GetSprite(1), false, null, null);
	}

	// Token: 0x0600F174 RID: 61812 RVA: 0x003A1492 File Offset: 0x0039F692
	[NullableContext(1)]
	public void SetLocalTextNew(string key)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), key, Array.Empty<object>());
	}

	// Token: 0x0600F175 RID: 61813 RVA: 0x003A14AB File Offset: 0x0039F6AB
	private void OnClicked()
	{
		Action onClickedCb = this.OnClickedCb;
		if (onClickedCb == null)
		{
			return;
		}
		onClickedCb();
	}

	// Token: 0x04006FAE RID: 28590
	[Nullable(2)]
	public Action OnClickedCb;

	// Token: 0x02008483 RID: 33923
	private enum EBtn
	{
		// Token: 0x0402B224 RID: 176676
		Btn,
		// Token: 0x0402B225 RID: 176677
		Sprite,
		// Token: 0x0402B226 RID: 176678
		Txt
	}
}
