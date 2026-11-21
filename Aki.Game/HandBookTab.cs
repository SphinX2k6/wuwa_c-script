using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200130F RID: 4879
internal class HandBookTab : GridProxyAbstract<int>
{
	// Token: 0x0600C009 RID: 49161 RVA: 0x0038BE60 File Offset: 0x0038A060
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

	// Token: 0x0600C00A RID: 49162 RVA: 0x0038BEE0 File Offset: 0x0038A0E0
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

	// Token: 0x0600C00B RID: 49163 RVA: 0x0038BF63 File Offset: 0x0038A163
	private void OnToggleClick(EToggleState toggleState)
	{
		Action<UUIExtendToggle, int> onClickCallBack = this.OnClickCallBack;
		if (onClickCallBack == null)
		{
			return;
		}
		onClickCallBack(base.GetExtendToggle(1), this.CurrentType);
	}

	// Token: 0x0600C00C RID: 49164 RVA: 0x0038BF82 File Offset: 0x0038A182
	public void SelectToggle()
	{
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_Checked, true, false, false);
	}

	// Token: 0x04006E4A RID: 28234
	private int CurrentType;

	// Token: 0x04006E4B RID: 28235
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<UUIExtendToggle, int> OnClickCallBack;

	// Token: 0x02007587 RID: 30087
	private class EHandBookTabDefine
	{
		// Token: 0x040262AC RID: 156332
		public const int Sprite = 0;

		// Token: 0x040262AD RID: 156333
		public const int Toggle = 1;

		// Token: 0x040262AE RID: 156334
		public const int RedDotItem = 2;
	}
}
