using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020010E0 RID: 4320
[Nullable(new byte[]
{
	0,
	1
})]
public class AdvanceNoticeThumbItem : GridProxyAbstract<AdvanceNoticeThumbItemData>
{
	// Token: 0x06007083 RID: 28803 RVA: 0x0016F3AC File Offset: 0x0016D5AC
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

	// Token: 0x06007084 RID: 28804 RVA: 0x0016F46B File Offset: 0x0016D66B
	protected override void OnStart()
	{
		base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanItemToggleChangeInternal));
	}

	// Token: 0x06007085 RID: 28805 RVA: 0x0016F48C File Offset: 0x0016D68C
	[NullableContext(1)]
	public override void Refresh(AdvanceNoticeThumbItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		base.SetTextureByPath(data.BgTexturePath, base.GetTexture(1), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.NameTextId, Array.Empty<object>());
		base.GetItem(3).SetUIActive(data.ShowLine);
		this.RefreshToggleState(data.IsSelected);
	}

	// Token: 0x06007086 RID: 28806 RVA: 0x0016F4F7 File Offset: 0x0016D6F7
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

	// Token: 0x06007087 RID: 28807 RVA: 0x0016F51E File Offset: 0x0016D71E
	public void RefreshToggleState(bool isSelected)
	{
		base.GetSprite(4).SetUIActive(isSelected);
		base.GetExtendToggle(0).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06007088 RID: 28808 RVA: 0x0016F544 File Offset: 0x0016D744
	private bool CanItemToggleChangeInternal()
	{
		if (this.Data == null)
		{
			return false;
		}
		Func<AdvanceNoticeThumbItemData, int, bool> canItemToggleChangeDelegate = this.CanItemToggleChangeDelegate;
		return canItemToggleChangeDelegate == null || canItemToggleChangeDelegate(this.Data, base.GridIndex);
	}

	// Token: 0x04003429 RID: 13353
	[Nullable(2)]
	private AdvanceNoticeThumbItemData Data;

	// Token: 0x0400342A RID: 13354
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<AdvanceNoticeThumbItemData, int> OnItemToggleClickDelegate;

	// Token: 0x0400342B RID: 13355
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<AdvanceNoticeThumbItemData, int, bool> CanItemToggleChangeDelegate;

	// Token: 0x020076A8 RID: 30376
	private class EComponent
	{
		// Token: 0x04027292 RID: 160402
		public const int ItemToggle = 0;

		// Token: 0x04027293 RID: 160403
		public const int ItemTexture = 1;

		// Token: 0x04027294 RID: 160404
		public const int NameText = 2;

		// Token: 0x04027295 RID: 160405
		public const int LineItem = 3;

		// Token: 0x04027296 RID: 160406
		public const int SpriteArrow = 4;

		// Token: 0x04027297 RID: 160407
		public const int SpriteSele = 5;
	}
}
