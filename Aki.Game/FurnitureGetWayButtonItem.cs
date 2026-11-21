using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000486 RID: 1158
public class FurnitureGetWayButtonItem : UiPanelBase
{
	// Token: 0x06003B9A RID: 15258 RVA: 0x001531EC File Offset: 0x001513EC
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

	// Token: 0x06003B9B RID: 15259 RVA: 0x0015326C File Offset: 0x0015146C
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

	// Token: 0x06003B9C RID: 15260 RVA: 0x001532E3 File Offset: 0x001514E3
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

	// Token: 0x04003006 RID: 12294
	[Nullable(2)]
	private IFurnitureGetWayButtonItemData Data;
}
