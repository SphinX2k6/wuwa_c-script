using System;
using System.Runtime.CompilerServices;

// Token: 0x02002A59 RID: 10841
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleOrnamentGridItem : LoopScrollSmallItemGrid<IRoleOrnamentGridData>
{
	// Token: 0x06016975 RID: 92533 RVA: 0x005B9924 File Offset: 0x005B7B24
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

	// Token: 0x06016976 RID: 92534 RVA: 0x005B997C File Offset: 0x005B7B7C
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x06016977 RID: 92535 RVA: 0x005B9988 File Offset: 0x005B7B88
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

	// Token: 0x06016978 RID: 92536 RVA: 0x005B9A24 File Offset: 0x005B7C24
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

	// Token: 0x06016979 RID: 92537 RVA: 0x005B9A6E File Offset: 0x005B7C6E
	[return: Nullable(2)]
	public override object GetKey(IRoleOrnamentGridData data, int gridIndex)
	{
		return data.OrnamentId;
	}
}
