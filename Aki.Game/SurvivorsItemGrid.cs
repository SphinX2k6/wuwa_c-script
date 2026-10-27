using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002AFE RID: 11006
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsItemGrid : GridProxyAbstract<SurvivorsItemGainData>
{
	// Token: 0x06016E3F RID: 93759 RVA: 0x005CEA5C File Offset: 0x005CCC5C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(6, new Action<EToggleState>(this.OnExtendToggleStateChanged))
		};
	}

	// Token: 0x06016E40 RID: 93760 RVA: 0x005CEB5D File Offset: 0x005CCD5D
	protected override void OnStart()
	{
		this.Toggle = base.GetExtendToggle(6);
		UUIExtendToggle toggle = this.Toggle;
		if (toggle == null)
		{
			return;
		}
		toggle.CanExecuteChange.Bind(() => this.CanExecuteChange == null || this.CanExecuteChange(base.GridIndex));
	}

	// Token: 0x06016E41 RID: 93761 RVA: 0x005CEB8D File Offset: 0x005CCD8D
	public void SetClickCallback(Action<int, int> callback)
	{
		this.OnClick = callback;
	}

	// Token: 0x06016E42 RID: 93762 RVA: 0x005CEB96 File Offset: 0x005CCD96
	public void SetCanExecuteChange(Func<int, bool> callback)
	{
		this.CanExecuteChange = callback;
	}

	// Token: 0x06016E43 RID: 93763 RVA: 0x005CEB9F File Offset: 0x005CCD9F
	public void SetToggleStateForce(bool isSelected, bool bFire = false, bool bJumpToLastFrame = false)
	{
		UUIExtendToggle toggle = this.Toggle;
		if (toggle == null)
		{
			return;
		}
		toggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, bFire, false, bJumpToLastFrame);
	}

	// Token: 0x06016E44 RID: 93764 RVA: 0x005CEBBB File Offset: 0x005CCDBB
	private void OnExtendToggleStateChanged(EToggleState state)
	{
		if (this.OnClick != null)
		{
			this.OnClick(base.GridIndex, this.CachedItemId);
		}
	}

	// Token: 0x06016E45 RID: 93765 RVA: 0x005CEBDC File Offset: 0x005CCDDC
	public override void Refresh(SurvivorsItemGainData data, bool isSelected, int gridIndex)
	{
		this.CachedItemId = data.ConfigId;
		SurvivorsItem? survivorsItem = SurvivorsRogueConfig.Instance.GetSurvivorsItem(this.CachedItemId);
		base.SetTextureByPath(survivorsItem.Value.Icon, base.GetTexture(1), null, null);
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.ShowTextNew(survivorsItem.Value.Name);
		}
		base.SetQualityIconById(base.GetSprite(0), survivorsItem.Value.Quality, null, null, null);
		this.SetToggleStateForce(isSelected, false, true);
	}

	// Token: 0x06016E46 RID: 93766 RVA: 0x005CEC85 File Offset: 0x005CCE85
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleStateForce(false, false, false);
	}

	// Token: 0x0400A9F2 RID: 43506
	private int CachedItemId = -1;

	// Token: 0x0400A9F3 RID: 43507
	[Nullable(2)]
	private Action<int, int> OnClick;

	// Token: 0x0400A9F4 RID: 43508
	[Nullable(2)]
	private Func<int, bool> CanExecuteChange;

	// Token: 0x0400A9F5 RID: 43509
	[Nullable(2)]
	private UUIExtendToggle Toggle;

	// Token: 0x0200910C RID: 37132
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402EFBB RID: 192443
		public const int QualitySprite = 0;

		// Token: 0x0402EFBC RID: 192444
		public const int ItemTexture = 1;

		// Token: 0x0402EFBD RID: 192445
		public const int BottomText = 2;

		// Token: 0x0402EFBE RID: 192446
		public const int BgSprite = 3;

		// Token: 0x0402EFBF RID: 192447
		public const int TopAdditionItem = 4;

		// Token: 0x0402EFC0 RID: 192448
		public const int BottomAdditionItem = 5;

		// Token: 0x0402EFC1 RID: 192449
		public const int ExtendToggle = 6;

		// Token: 0x0402EFC2 RID: 192450
		public const int UnderTextAdditionItem = 7;

		// Token: 0x0402EFC3 RID: 192451
		public const int SkinQualitySprite = 8;
	}
}
