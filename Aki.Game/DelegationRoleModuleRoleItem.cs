using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020007CA RID: 1994
public class DelegationRoleModuleRoleItem : UiPanelBase
{
	// Token: 0x06005B1C RID: 23324 RVA: 0x001D7AD8 File Offset: 0x001D5CD8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClick))
		};
	}

	// Token: 0x06005B1D RID: 23325 RVA: 0x001D7B55 File Offset: 0x001D5D55
	private void OnClick()
	{
		Action clickFunction = this.ClickFunction;
		if (clickFunction == null)
		{
			return;
		}
		clickFunction();
	}

	// Token: 0x06005B1E RID: 23326 RVA: 0x001D7B68 File Offset: 0x001D5D68
	public void Refresh(int? roleId)
	{
		bool flag = roleId != null;
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(!flag);
		}
		UUITexture texture = base.GetTexture(1);
		if (texture != null)
		{
			texture.SetUIActive(flag);
		}
		if (flag)
		{
			base.SetTextureByPath(BusinessConfig.Instance.GetEntrustRoleById(roleId.Value).Icon, base.GetTexture(1), null, null);
		}
	}

	// Token: 0x06005B1F RID: 23327 RVA: 0x001D7BD9 File Offset: 0x001D5DD9
	[NullableContext(1)]
	public void BindClickFunction(Action clickFunction)
	{
		this.ClickFunction = clickFunction;
	}

	// Token: 0x04003D0A RID: 15626
	[Nullable(2)]
	private Action ClickFunction;

	// Token: 0x02006AE9 RID: 27369
	private static class ERoleItemDefine
	{
		// Token: 0x040232C6 RID: 144070
		public const int Button = 0;

		// Token: 0x040232C7 RID: 144071
		public const int Texture = 1;

		// Token: 0x040232C8 RID: 144072
		public const int EmptyItem = 2;
	}
}
