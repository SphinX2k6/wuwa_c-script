using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002CA0 RID: 11424
[NullableContext(1)]
[Nullable(0)]
public class UiMotorDataComponent : UiModelComponentBase
{
	// Token: 0x06017DFD RID: 97789 RVA: 0x00611DCC File Offset: 0x0060FFCC
	public int NextLoadSeq()
	{
		int num = this.LoadSeqInternal + 1;
		this.LoadSeqInternal = num;
		return num;
	}

	// Token: 0x06017DFE RID: 97790 RVA: 0x00611DEA File Offset: 0x0060FFEA
	public int GetLoadSeq()
	{
		return this.LoadSeqInternal;
	}

	// Token: 0x06017DFF RID: 97791 RVA: 0x00611DF2 File Offset: 0x0060FFF2
	public void SetRequestedFrameId(int frameId)
	{
		this.RequestedFrameIdInternal = frameId;
	}

	// Token: 0x06017E00 RID: 97792 RVA: 0x00611DFB File Offset: 0x0060FFFB
	public int GetRequestedFrameId()
	{
		return this.RequestedFrameIdInternal;
	}

	// Token: 0x06017E01 RID: 97793 RVA: 0x00611E03 File Offset: 0x00610003
	public int GetSkinId()
	{
		return this.SkinIdInternal;
	}

	// Token: 0x06017E02 RID: 97794 RVA: 0x00611E0B File Offset: 0x0061000B
	public int GetFrameId()
	{
		return this.FrameIdInternal;
	}

	// Token: 0x06017E03 RID: 97795 RVA: 0x00611E13 File Offset: 0x00610013
	public List<int> GetStickerIdList()
	{
		return this.StickerIdListInternal;
	}

	// Token: 0x06017E04 RID: 97796 RVA: 0x00611E1B File Offset: 0x0061001B
	public List<int> GetDecorateIdList()
	{
		return this.DecorateIdListInternal;
	}

	// Token: 0x06017E05 RID: 97797 RVA: 0x00611E23 File Offset: 0x00610023
	public void SetSkinId(int skinId)
	{
		this.SkinIdInternal = skinId;
	}

	// Token: 0x06017E06 RID: 97798 RVA: 0x00611E2C File Offset: 0x0061002C
	public void SetFrameId(int frameId)
	{
		this.FrameIdInternal = frameId;
	}

	// Token: 0x06017E07 RID: 97799 RVA: 0x00611E35 File Offset: 0x00610035
	public void SetStickerIdList(List<int> stickerIdList)
	{
		this.StickerIdListInternal = stickerIdList;
	}

	// Token: 0x06017E08 RID: 97800 RVA: 0x00611E3E File Offset: 0x0061003E
	public void SetDecorateIdList(List<int> decorateIdList)
	{
		this.DecorateIdListInternal = decorateIdList;
	}

	// Token: 0x06017E09 RID: 97801 RVA: 0x00611E48 File Offset: 0x00610048
	public void SetDecorationId(int partId, int decorationId)
	{
		int num = partId - 1;
		while (this.DecorateIdListInternal.Count <= num)
		{
			this.DecorateIdListInternal.Add(0);
		}
		this.DecorateIdListInternal[num] = decorationId;
	}

	// Token: 0x06017E0A RID: 97802 RVA: 0x00611E84 File Offset: 0x00610084
	public bool IsSameDecorationId(int partId, int decorationId)
	{
		int num = partId - 1;
		return num >= 0 && num < this.DecorateIdListInternal.Count && this.DecorateIdListInternal[num] == decorationId;
	}

	// Token: 0x06017E0B RID: 97803 RVA: 0x00611EB8 File Offset: 0x006100B8
	[NullableContext(2)]
	public void SetRoleData(int roleId, int skinId, string animPath = null)
	{
		this.RoleIdInternal = roleId;
		this.RoleSkinIdInternal = skinId;
		this.AnimPathInternal = (animPath ?? string.Empty);
	}

	// Token: 0x06017E0C RID: 97804 RVA: 0x00611ED8 File Offset: 0x006100D8
	public int GetRoleId()
	{
		return this.RoleIdInternal;
	}

	// Token: 0x06017E0D RID: 97805 RVA: 0x00611EE0 File Offset: 0x006100E0
	public int GetRoleSkinId()
	{
		return this.RoleSkinIdInternal;
	}

	// Token: 0x06017E0E RID: 97806 RVA: 0x00611EE8 File Offset: 0x006100E8
	public string GetAnimPath()
	{
		return this.AnimPathInternal;
	}

	// Token: 0x0400B1FD RID: 45565
	private int SkinIdInternal;

	// Token: 0x0400B1FE RID: 45566
	private List<int> StickerIdListInternal = new List<int>();

	// Token: 0x0400B1FF RID: 45567
	private int FrameIdInternal;

	// Token: 0x0400B200 RID: 45568
	private List<int> DecorateIdListInternal = new List<int>();

	// Token: 0x0400B201 RID: 45569
	private int RoleIdInternal;

	// Token: 0x0400B202 RID: 45570
	private int RoleSkinIdInternal;

	// Token: 0x0400B203 RID: 45571
	private string AnimPathInternal = "";

	// Token: 0x0400B204 RID: 45572
	private int LoadSeqInternal;

	// Token: 0x0400B205 RID: 45573
	private int RequestedFrameIdInternal;
}
