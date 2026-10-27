using System;
using System.Runtime.CompilerServices;

// Token: 0x02001B09 RID: 6921
[NullableContext(2)]
[Nullable(0)]
public class FloroRanchTipData
{
	// Token: 0x0600CD72 RID: 52594 RVA: 0x002ED123 File Offset: 0x002EB323
	public FloroRanchTipData()
	{
		this.TipType = EFloroRanchTipType.None;
		this.MainEntityData = null;
		this.SubEntityData = null;
		this.LastTipType = EFloroRanchTipType.None;
		this.LastMainEntityData = null;
		this.LastSubEntityData = null;
	}

	// Token: 0x0600CD73 RID: 52595 RVA: 0x002ED155 File Offset: 0x002EB355
	public void ChangeTipInfo(EFloroRanchTipType tipType, FloroRanchEntityBase mainEntityData, FloroRanchEntityBase subEntityData)
	{
		this.LastTipType = this.TipType;
		this.LastMainEntityData = this.MainEntityData;
		this.LastSubEntityData = this.SubEntityData;
		this.TipType = tipType;
		this.MainEntityData = mainEntityData;
		this.SubEntityData = subEntityData;
	}

	// Token: 0x0600CD74 RID: 52596 RVA: 0x002ED190 File Offset: 0x002EB390
	public void Clear()
	{
		this.ChangeTipInfo(EFloroRanchTipType.None, null, null);
	}

	// Token: 0x04005E3D RID: 24125
	public EFloroRanchTipType TipType;

	// Token: 0x04005E3E RID: 24126
	public FloroRanchEntityBase MainEntityData;

	// Token: 0x04005E3F RID: 24127
	public FloroRanchEntityBase SubEntityData;

	// Token: 0x04005E40 RID: 24128
	public EFloroRanchTipType LastTipType;

	// Token: 0x04005E41 RID: 24129
	public FloroRanchEntityBase LastMainEntityData;

	// Token: 0x04005E42 RID: 24130
	public FloroRanchEntityBase LastSubEntityData;
}
