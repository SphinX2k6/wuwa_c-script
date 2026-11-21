using System;
using System.Runtime.CompilerServices;

// Token: 0x02000FC8 RID: 4040
[NullableContext(2)]
[Nullable(0)]
public class FloroRanchTipData
{
	// Token: 0x0600A183 RID: 41347 RVA: 0x002F820F File Offset: 0x002F640F
	public FloroRanchTipData()
	{
		this.TipType = EFloroRanchTipType.None;
		this.MainEntityData = null;
		this.SubEntityData = null;
		this.LastTipType = EFloroRanchTipType.None;
		this.LastMainEntityData = null;
		this.LastSubEntityData = null;
	}

	// Token: 0x0600A184 RID: 41348 RVA: 0x002F8241 File Offset: 0x002F6441
	public void ChangeTipInfo(EFloroRanchTipType tipType, FloroRanchEntityBase mainEntityData, FloroRanchEntityBase subEntityData)
	{
		this.LastTipType = this.TipType;
		this.LastMainEntityData = this.MainEntityData;
		this.LastSubEntityData = this.SubEntityData;
		this.TipType = tipType;
		this.MainEntityData = mainEntityData;
		this.SubEntityData = subEntityData;
	}

	// Token: 0x0600A185 RID: 41349 RVA: 0x002F827C File Offset: 0x002F647C
	public void Clear()
	{
		this.ChangeTipInfo(EFloroRanchTipType.None, null, null);
	}

	// Token: 0x04005F0C RID: 24332
	public EFloroRanchTipType TipType;

	// Token: 0x04005F0D RID: 24333
	public FloroRanchEntityBase MainEntityData;

	// Token: 0x04005F0E RID: 24334
	public FloroRanchEntityBase SubEntityData;

	// Token: 0x04005F0F RID: 24335
	public EFloroRanchTipType LastTipType;

	// Token: 0x04005F10 RID: 24336
	public FloroRanchEntityBase LastMainEntityData;

	// Token: 0x04005F11 RID: 24337
	public FloroRanchEntityBase LastSubEntityData;
}
