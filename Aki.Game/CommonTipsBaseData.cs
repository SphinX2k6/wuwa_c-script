using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E87 RID: 3719
[NullableContext(1)]
[Nullable(0)]
public class CommonTipsBaseData
{
	// Token: 0x04005742 RID: 22338
	public int? IncId = new int?(0);

	// Token: 0x04005743 RID: 22339
	public int ConfigId;

	// Token: 0x04005744 RID: 22340
	public string Name = "";

	// Token: 0x04005745 RID: 22341
	public int QualityId;

	// Token: 0x04005746 RID: 22342
	public CommonComponentDefine.ECommonTipsType ItemType = CommonComponentDefine.ECommonTipsType.Weapon;

	// Token: 0x04005747 RID: 22343
	public string BgDescription = "";

	// Token: 0x04005748 RID: 22344
	public string LevelText = "";

	// Token: 0x04005749 RID: 22345
	public string MaxLevelText = "";

	// Token: 0x0400574A RID: 22346
	public string Type = "";

	// Token: 0x0400574B RID: 22347
	public int EquippedId;

	// Token: 0x0400574C RID: 22348
	public string EquippedIcon = "";

	// Token: 0x0400574D RID: 22349
	public string EquippedName = "";
}
