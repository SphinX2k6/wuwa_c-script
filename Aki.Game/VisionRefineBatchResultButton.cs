using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001777 RID: 6007
internal class VisionRefineBatchResultButton : UiPanelBase
{
	// Token: 0x0600AE32 RID: 44594 RVA: 0x002741E0 File Offset: 0x002723E0
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

	// Token: 0x0600AE33 RID: 44595 RVA: 0x0027425D File Offset: 0x0027245D
	[NullableContext(1)]
	public void SetText(string textId)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, Array.Empty<object>());
	}

	// Token: 0x0600AE34 RID: 44596 RVA: 0x00274276 File Offset: 0x00272476
	private void OnClick()
	{
		if (this.OnClickCallback != null)
		{
			this.OnClickCallback();
		}
	}

	// Token: 0x04004F2F RID: 20271
	[Nullable(2)]
	public Action OnClickCallback;
}
