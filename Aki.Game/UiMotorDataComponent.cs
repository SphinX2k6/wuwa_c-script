using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020021F9 RID: 8697
[NullableContext(1)]
[Nullable(0)]
public class UiMotorDataComponent : UiModelComponentBase
{
	// Token: 0x06015671 RID: 87665 RVA: 0x00637950 File Offset: 0x00635B50
	public int NextLoadSeq()
	{
		int num = this.LoadSeqInternal + 1;
		this.LoadSeqInternal = num;
		return num;
	}

	// Token: 0x06015672 RID: 87666 RVA: 0x0063796E File Offset: 0x00635B6E
	public int GetLoadSeq()
	{
		return this.LoadSeqInternal;
	}

	// Token: 0x06015673 RID: 87667 RVA: 0x00637976 File Offset: 0x00635B76
	public void SetRequestedFrameId(int frameId)
	{
		this.RequestedFrameIdInternal = frameId;
	}

	// Token: 0x06015674 RID: 87668 RVA: 0x0063797F File Offset: 0x00635B7F
	public int GetRequestedFrameId()
	{
		return this.RequestedFrameIdInternal;
	}

	// Token: 0x06015675 RID: 87669 RVA: 0x00637987 File Offset: 0x00635B87
	public int GetSkinId()
	{
		return this.SkinIdInternal;
	}

	// Token: 0x06015676 RID: 87670 RVA: 0x0063798F File Offset: 0x00635B8F
	public int GetFrameId()
	{
		return this.FrameIdInternal;
	}

	// Token: 0x06015677 RID: 87671 RVA: 0x00637997 File Offset: 0x00635B97
	public List<int> GetStickerIdList()
	{
		return this.StickerIdListInternal;
	}

	// Token: 0x06015678 RID: 87672 RVA: 0x0063799F File Offset: 0x00635B9F
	public List<int> GetDecorateIdList()
	{
		return this.DecorateIdListInternal;
	}

	// Token: 0x06015679 RID: 87673 RVA: 0x006379A7 File Offset: 0x00635BA7
	public void SetSkinId(int skinId)
	{
		this.SkinIdInternal = skinId;
	}

	// Token: 0x0601567A RID: 87674 RVA: 0x006379B0 File Offset: 0x00635BB0
	public void SetFrameId(int frameId)
	{
		this.FrameIdInternal = frameId;
	}

	// Token: 0x0601567B RID: 87675 RVA: 0x006379B9 File Offset: 0x00635BB9
	public void SetStickerIdList(List<int> stickerIdList)
	{
		this.StickerIdListInternal = stickerIdList;
	}

	// Token: 0x0601567C RID: 87676 RVA: 0x006379C2 File Offset: 0x00635BC2
	public void SetDecorateIdList(List<int> decorateIdList)
	{
		this.DecorateIdListInternal = decorateIdList;
	}

	// Token: 0x0601567D RID: 87677 RVA: 0x006379CC File Offset: 0x00635BCC
	public void SetDecorationId(int partId, int decorationId)
	{
		int num = partId - 1;
		while (this.DecorateIdListInternal.Count <= num)
		{
			this.DecorateIdListInternal.Add(0);
		}
		this.DecorateIdListInternal[num] = decorationId;
	}

	// Token: 0x0601567E RID: 87678 RVA: 0x00637A08 File Offset: 0x00635C08
	public bool IsSameDecorationId(int partId, int decorationId)
	{
		int num = partId - 1;
		return num >= 0 && num < this.DecorateIdListInternal.Count && this.DecorateIdListInternal[num] == decorationId;
	}

	// Token: 0x0601567F RID: 87679 RVA: 0x00637A3C File Offset: 0x00635C3C
	[NullableContext(2)]
	public void SetRoleData(int roleId, int skinId, string animPath = null)
	{
		this.RoleIdInternal = roleId;
		this.RoleSkinIdInternal = skinId;
		this.AnimPathInternal = (animPath ?? string.Empty);
	}

	// Token: 0x06015680 RID: 87680 RVA: 0x00637A5C File Offset: 0x00635C5C
	public int GetRoleId()
	{
		return this.RoleIdInternal;
	}

	// Token: 0x06015681 RID: 87681 RVA: 0x00637A64 File Offset: 0x00635C64
	public int GetRoleSkinId()
	{
		return this.RoleSkinIdInternal;
	}

	// Token: 0x06015682 RID: 87682 RVA: 0x00637A6C File Offset: 0x00635C6C
	public string GetAnimPath()
	{
		return this.AnimPathInternal;
	}

	// Token: 0x0400B568 RID: 46440
	private int SkinIdInternal;

	// Token: 0x0400B569 RID: 46441
	private List<int> StickerIdListInternal = new List<int>();

	// Token: 0x0400B56A RID: 46442
	private int FrameIdInternal;

	// Token: 0x0400B56B RID: 46443
	private List<int> DecorateIdListInternal = new List<int>();

	// Token: 0x0400B56C RID: 46444
	private int RoleIdInternal;

	// Token: 0x0400B56D RID: 46445
	private int RoleSkinIdInternal;

	// Token: 0x0400B56E RID: 46446
	private string AnimPathInternal = "";

	// Token: 0x0400B56F RID: 46447
	private int LoadSeqInternal;

	// Token: 0x0400B570 RID: 46448
	private int RequestedFrameIdInternal;
}
