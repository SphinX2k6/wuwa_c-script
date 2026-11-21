using System;
using System.Runtime.CompilerServices;

// Token: 0x02001FD4 RID: 8148
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleOrnamentGridItem : LoopScrollSmallItemGrid<IRoleOrnamentGridData>
{
	// Token: 0x06014396 RID: 82838 RVA: 0x005E5AA8 File Offset: 0x005E3CA8
	public override void OnSelected(bool fireEvent)
	{
		if (fireEvent)
		{
			this.SetSelected(true, true);
		}
		if (this.Data != null)
		{
			int ornamentId = ((IRoleOrnamentGridData)this.Data).OrnamentId;
			RoleOrnamentModel instance = RoleOrnamentModel.Instance;
			if (instance.IsOrnamentNewlyAcquired(ornamentId))
			{
				instance.SetOrnamentNewlyAcquired(ornamentId, false);
			}
			if (instance.IsOrnamentNewlyAdded(ornamentId))
			{
				instance.SetOrnamentNewlyViewed(ornamentId);
			}
		}
	}

	// Token: 0x06014397 RID: 82839 RVA: 0x005E5B00 File Offset: 0x005E3D00
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x06014398 RID: 82840 RVA: 0x005E5B0C File Offset: 0x005E3D0C
	protected override void OnRefresh(IRoleOrnamentGridData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		int ornamentId = data.OrnamentId;
		int skinId = data.SkinId;
		CharacterOrnamentSmallItemGrid parameters = new CharacterOrnamentSmallItemGrid
		{
			Data = data,
			ItemConfigId = new int?(ornamentId),
			IsLockVisibleBlack = new bool?(!RoleOrnamentModel.Instance.IsOwnOrnament(ornamentId)),
			IsOrnamentConflictVisible = new bool?(skinId != 0 && RoleOrnamentModel.Instance.IsOrnamentConflictOnSkin(ornamentId, skinId, false))
		};
		base.Apply<CharacterOrnamentSmallItemGrid>(parameters);
		base.SetSelectVisible(RoleOrnamentModel.Instance.IsSkinWearingOrnament(ornamentId, skinId, true));
		this.SetSelected(isSelected, false);
		this.RefreshRedDotVisible();
	}

	// Token: 0x06014399 RID: 82841 RVA: 0x005E5BA8 File Offset: 0x005E3DA8
	public void RefreshRedDotVisible()
	{
		IRoleOrnamentGridData roleOrnamentGridData = this.Data as IRoleOrnamentGridData;
		if (roleOrnamentGridData == null)
		{
			return;
		}
		int ornamentId = roleOrnamentGridData.OrnamentId;
		RoleOrnamentModel instance = RoleOrnamentModel.Instance;
		bool value = instance.IsOrnamentNewlyAdded(ornamentId) || instance.IsOrnamentNewlyAcquired(ornamentId);
		base.SetRedDotVisible(new bool?(value));
	}

	// Token: 0x0601439A RID: 82842 RVA: 0x005E5BF2 File Offset: 0x005E3DF2
	[return: Nullable(2)]
	public override object GetKey(IRoleOrnamentGridData data, int gridIndex)
	{
		return data.OrnamentId;
	}
}
