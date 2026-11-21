using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000594 RID: 1428
[Nullable(new byte[]
{
	0,
	1
})]
public class AdvanceNoticeThumbItem : GridProxyAbstract<AdvanceNoticeThumbItemData>
{
	// Token: 0x06004419 RID: 17433 RVA: 0x00177D68 File Offset: 0x00175F68
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnItemToggleClickInternal))
		};
	}

	// Token: 0x0600441A RID: 17434 RVA: 0x00177E27 File Offset: 0x00176027
	protected override void OnStart()
	{
		base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanItemToggleChangeInternal));
	}

	// Token: 0x0600441B RID: 17435 RVA: 0x00177E48 File Offset: 0x00176048
	[NullableContext(1)]
	public override void Refresh(AdvanceNoticeThumbItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		base.SetTextureByPath(data.BgTexturePath, base.GetTexture(1), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.NameTextId, Array.Empty<object>());
		base.GetItem(3).SetUIActive(data.ShowLine);
		this.RefreshToggleState(data.IsSelected);
	}

	// Token: 0x0600441C RID: 17436 RVA: 0x00177EB3 File Offset: 0x001760B3
	private void OnItemToggleClickInternal(EToggleState _)
	{
		if (this.Data == null)
		{
			return;
		}
		Action<AdvanceNoticeThumbItemData, int> onItemToggleClickDelegate = this.OnItemToggleClickDelegate;
		if (onItemToggleClickDelegate == null)
		{
			return;
		}
		onItemToggleClickDelegate(this.Data, base.GridIndex);
	}

	// Token: 0x0600441D RID: 17437 RVA: 0x00177EDA File Offset: 0x001760DA
	public void RefreshToggleState(bool isSelected)
	{
		base.GetSprite(4).SetUIActive(isSelected);
		base.GetExtendToggle(0).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600441E RID: 17438 RVA: 0x00177F00 File Offset: 0x00176100
	private bool CanItemToggleChangeInternal()
	{
		if (this.Data == null)
		{
			return false;
		}
		Func<AdvanceNoticeThumbItemData, int, bool> canItemToggleChangeDelegate = this.CanItemToggleChangeDelegate;
		return canItemToggleChangeDelegate == null || canItemToggleChangeDelegate(this.Data, base.GridIndex);
	}

	// Token: 0x040034C2 RID: 13506
	[Nullable(2)]
	private AdvanceNoticeThumbItemData Data;

	// Token: 0x040034C3 RID: 13507
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<AdvanceNoticeThumbItemData, int> OnItemToggleClickDelegate;

	// Token: 0x040034C4 RID: 13508
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<AdvanceNoticeThumbItemData, int, bool> CanItemToggleChangeDelegate;

	// Token: 0x0200683C RID: 26684
	private class EComponent
	{
		// Token: 0x040225DB RID: 140763
		public const int ItemToggle = 0;

		// Token: 0x040225DC RID: 140764
		public const int ItemTexture = 1;

		// Token: 0x040225DD RID: 140765
		public const int NameText = 2;

		// Token: 0x040225DE RID: 140766
		public const int LineItem = 3;

		// Token: 0x040225DF RID: 140767
		public const int SpriteArrow = 4;

		// Token: 0x040225E0 RID: 140768
		public const int SpriteSele = 5;
	}
}
