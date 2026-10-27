using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020019CB RID: 6603
[NullableContext(1)]
[Nullable(0)]
public class PhantomTipsData : CommonTipsBaseData
{
	// Token: 0x040056A0 RID: 22176
	public int PhantomId;

	// Token: 0x040056A1 RID: 22177
	public int Level;

	// Token: 0x040056A2 RID: 22178
	public string RarityId = "";

	// Token: 0x040056A3 RID: 22179
	public string PropertyTexture = "";

	// Token: 0x040056A4 RID: 22180
	public int PropertyId;

	// Token: 0x040056A5 RID: 22181
	public bool IsBreak;

	// Token: 0x040056A6 RID: 22182
	public List<CommonComponentDefine.TipsAttributeData> BreakAttributeList = new List<CommonComponentDefine.TipsAttributeData>();

	// Token: 0x040056A7 RID: 22183
	public bool IsMain;

	// Token: 0x040056A8 RID: 22184
	public List<CommonComponentDefine.TipsAttributeData> MainAttributeList = new List<CommonComponentDefine.TipsAttributeData>();

	// Token: 0x040056A9 RID: 22185
	public string MainSkillText = "";

	// Token: 0x040056AA RID: 22186
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] MainSkillParameter;

	// Token: 0x040056AB RID: 22187
	public string SkillIcon = "";

	// Token: 0x040056AC RID: 22188
	public bool IsSub;

	// Token: 0x040056AD RID: 22189
	public List<CommonComponentDefine.TipsAttributeData> SubAttributeList = new List<CommonComponentDefine.TipsAttributeData>();

	// Token: 0x040056AE RID: 22190
	public bool IsUnlockSub;

	// Token: 0x040056AF RID: 22191
	public string UnlockSubTips = "";
}
