using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000C30 RID: 3120
internal class VisionRefineBatchResultButton : UiPanelBase
{
	// Token: 0x06008219 RID: 33305 RVA: 0x0027E6A4 File Offset: 0x0027C8A4
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
			new ValueTuple<int, Delegate>(0, new Action(this.OnClick))
		};
	}

	// Token: 0x0600821A RID: 33306 RVA: 0x0027E721 File Offset: 0x0027C921
	[NullableContext(1)]
	public void SetText(string textId)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, Array.Empty<object>());
	}

	// Token: 0x0600821B RID: 33307 RVA: 0x0027E73A File Offset: 0x0027C93A
	private void OnClick()
	{
		if (this.OnClickCallback != null)
		{
			this.OnClickCallback();
		}
	}

	// Token: 0x04004FD9 RID: 20441
	[Nullable(2)]
	public Action OnClickCallback;
}
