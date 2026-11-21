using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200207A RID: 8314
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsItemGrid : GridProxyAbstract<SurvivorsItemGainData>
{
	// Token: 0x06014870 RID: 84080 RVA: 0x005FB5DC File Offset: 0x005F97DC
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

	// Token: 0x06014871 RID: 84081 RVA: 0x005FB6DD File Offset: 0x005F98DD
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

	// Token: 0x06014872 RID: 84082 RVA: 0x005FB70D File Offset: 0x005F990D
	public void SetClickCallback(Action<int, int> callback)
	{
		this.OnClick = callback;
	}

	// Token: 0x06014873 RID: 84083 RVA: 0x005FB716 File Offset: 0x005F9916
	public void SetCanExecuteChange(Func<int, bool> callback)
	{
		this.CanExecuteChange = callback;
	}

	// Token: 0x06014874 RID: 84084 RVA: 0x005FB71F File Offset: 0x005F991F
	public void SetToggleStateForce(bool isSelected, bool bFire = false, bool bJumpToLastFrame = false)
	{
		UUIExtendToggle toggle = this.Toggle;
		if (toggle == null)
		{
			return;
		}
		toggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, bFire, false, bJumpToLastFrame);
	}

	// Token: 0x06014875 RID: 84085 RVA: 0x005FB73B File Offset: 0x005F993B
	private void OnExtendToggleStateChanged(EToggleState state)
	{
		if (this.OnClick != null)
		{
			this.OnClick(base.GridIndex, this.CachedItemId);
		}
	}

	// Token: 0x06014876 RID: 84086 RVA: 0x005FB75C File Offset: 0x005F995C
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

	// Token: 0x06014877 RID: 84087 RVA: 0x005FB805 File Offset: 0x005F9A05
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleStateForce(false, false, false);
	}

	// Token: 0x0400ADF8 RID: 44536
	private int CachedItemId = -1;

	// Token: 0x0400ADF9 RID: 44537
	[Nullable(2)]
	private Action<int, int> OnClick;

	// Token: 0x0400ADFA RID: 44538
	[Nullable(2)]
	private Func<int, bool> CanExecuteChange;

	// Token: 0x0400ADFB RID: 44539
	[Nullable(2)]
	private UUIExtendToggle Toggle;

	// Token: 0x0200834F RID: 33615
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402A6C0 RID: 173760
		public const int QualitySprite = 0;

		// Token: 0x0402A6C1 RID: 173761
		public const int ItemTexture = 1;

		// Token: 0x0402A6C2 RID: 173762
		public const int BottomText = 2;

		// Token: 0x0402A6C3 RID: 173763
		public const int BgSprite = 3;

		// Token: 0x0402A6C4 RID: 173764
		public const int TopAdditionItem = 4;

		// Token: 0x0402A6C5 RID: 173765
		public const int BottomAdditionItem = 5;

		// Token: 0x0402A6C6 RID: 173766
		public const int ExtendToggle = 6;

		// Token: 0x0402A6C7 RID: 173767
		public const int UnderTextAdditionItem = 7;

		// Token: 0x0402A6C8 RID: 173768
		public const int SkinQualitySprite = 8;
	}
}
