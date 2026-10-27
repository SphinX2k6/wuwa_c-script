using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001E4D RID: 7757
internal class HandBookTab : GridProxyAbstract<int>
{
	// Token: 0x0600EBEA RID: 60394 RVA: 0x003801C8 File Offset: 0x0037E3C8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnToggleClick))
		};
	}

	// Token: 0x0600EBEB RID: 60395 RVA: 0x00380248 File Offset: 0x0037E448
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		if (data == 0)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("WeaponHandBookTabSprite");
			this.SetSpriteByPath(resourcePath, base.GetSprite(0), false, null, delegate(bool _)
			{
				(base.GetSprite(0).GetOwner().GetComponentByClass(UUIExtendToggleSpriteTransition.StaticClass()) as UUIExtendToggleSpriteTransition).SetAllStateSprite(base.GetSprite(0).GetSprite());
			});
		}
		if (data == 1)
		{
			string resourcePath2 = UiResourceConfig.Instance.GetResourcePath("WeaponSkinHandBookTabSprite");
			this.SetSpriteByPath(resourcePath2, base.GetSprite(0), false, null, delegate(bool _)
			{
				(base.GetSprite(0).GetOwner().GetComponentByClass(UUIExtendToggleSpriteTransition.StaticClass()) as UUIExtendToggleSpriteTransition).SetAllStateSprite(base.GetSprite(0).GetSprite());
			});
		}
		this.CurrentType = data;
	}

	// Token: 0x0600EBEC RID: 60396 RVA: 0x003802CB File Offset: 0x0037E4CB
	private void OnToggleClick(EToggleState toggleState)
	{
		Action<UUIExtendToggle, int> onClickCallBack = this.OnClickCallBack;
		if (onClickCallBack == null)
		{
			return;
		}
		onClickCallBack(base.GetExtendToggle(1), this.CurrentType);
	}

	// Token: 0x0600EBED RID: 60397 RVA: 0x003802EA File Offset: 0x0037E4EA
	public void SelectToggle()
	{
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_Checked, true, false, false);
	}

	// Token: 0x04006D69 RID: 28009
	private int CurrentType;

	// Token: 0x04006D6A RID: 28010
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<UUIExtendToggle, int> OnClickCallBack;

	// Token: 0x02008402 RID: 33794
	private class EHandBookTabDefine
	{
		// Token: 0x0402AF88 RID: 176008
		public const int Sprite = 0;

		// Token: 0x0402AF89 RID: 176009
		public const int Toggle = 1;

		// Token: 0x0402AF8A RID: 176010
		public const int RedDotItem = 2;
	}
}
