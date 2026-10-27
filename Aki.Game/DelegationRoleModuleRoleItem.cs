using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001316 RID: 4886
public class DelegationRoleModuleRoleItem : UiPanelBase
{
	// Token: 0x06008781 RID: 34689 RVA: 0x001CEC6C File Offset: 0x001CCE6C
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

	// Token: 0x06008782 RID: 34690 RVA: 0x001CECE9 File Offset: 0x001CCEE9
	private void OnClick()
	{
		Action clickFunction = this.ClickFunction;
		if (clickFunction == null)
		{
			return;
		}
		clickFunction();
	}

	// Token: 0x06008783 RID: 34691 RVA: 0x001CECFC File Offset: 0x001CCEFC
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

	// Token: 0x06008784 RID: 34692 RVA: 0x001CED6D File Offset: 0x001CCF6D
	[NullableContext(1)]
	public void BindClickFunction(Action clickFunction)
	{
		this.ClickFunction = clickFunction;
	}

	// Token: 0x04003C72 RID: 15474
	[Nullable(2)]
	private Action ClickFunction;

	// Token: 0x0200795F RID: 31071
	private static class ERoleItemDefine
	{
		// Token: 0x04027F99 RID: 163737
		public const int Button = 0;

		// Token: 0x04027F9A RID: 163738
		public const int Texture = 1;

		// Token: 0x04027F9B RID: 163739
		public const int EmptyItem = 2;
	}
}
