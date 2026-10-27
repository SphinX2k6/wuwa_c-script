using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000FD1 RID: 4049
public class FurnitureGetWayButtonItem : UiPanelBase
{
	// Token: 0x06006802 RID: 26626 RVA: 0x0014A928 File Offset: 0x00148B28
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickJumpButton))
		};
	}

	// Token: 0x06006803 RID: 26627 RVA: 0x0014A9A8 File Offset: 0x00148BA8
	[NullableContext(1)]
	public void Refresh(IFurnitureGetWayButtonItemData data)
	{
		this.Data = data;
		if (this.Data.NameTextId != null)
		{
			if (this.Data.NameTextParams != null)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), this.Data.NameTextId, this.Data.NameTextParams);
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), this.Data.NameTextId, Array.Empty<object>());
		}
	}

	// Token: 0x06006804 RID: 26628 RVA: 0x0014AA1F File Offset: 0x00148C1F
	private void OnClickJumpButton()
	{
		IFurnitureGetWayButtonItemData data = this.Data;
		if (data == null)
		{
			return;
		}
		Action jumpFunction = data.JumpFunction;
		if (jumpFunction == null)
		{
			return;
		}
		jumpFunction();
	}

	// Token: 0x04002F6D RID: 12141
	[Nullable(2)]
	private IFurnitureGetWayButtonItemData Data;
}
