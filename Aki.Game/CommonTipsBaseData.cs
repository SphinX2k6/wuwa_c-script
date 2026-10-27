using System;
using System.Runtime.CompilerServices;

// Token: 0x020019C8 RID: 6600
[NullableContext(1)]
[Nullable(0)]
public class CommonTipsBaseData
{
	// Token: 0x04005690 RID: 22160
	public int? IncId = new int?(0);

	// Token: 0x04005691 RID: 22161
	public int ConfigId;

	// Token: 0x04005692 RID: 22162
	public string Name = "";

	// Token: 0x04005693 RID: 22163
	public int QualityId;

	// Token: 0x04005694 RID: 22164
	public CommonComponentDefine.ECommonTipsType ItemType = CommonComponentDefine.ECommonTipsType.Weapon;

	// Token: 0x04005695 RID: 22165
	public string BgDescription = "";

	// Token: 0x04005696 RID: 22166
	public string LevelText = "";

	// Token: 0x04005697 RID: 22167
	public string MaxLevelText = "";

	// Token: 0x04005698 RID: 22168
	public string Type = "";

	// Token: 0x04005699 RID: 22169
	public int EquippedId;

	// Token: 0x0400569A RID: 22170
	public string EquippedIcon = "";

	// Token: 0x0400569B RID: 22171
	public string EquippedName = "";
}
