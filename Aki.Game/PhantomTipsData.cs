using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000E8A RID: 3722
[NullableContext(1)]
[Nullable(0)]
public class PhantomTipsData : CommonTipsBaseData
{
	// Token: 0x04005752 RID: 22354
	public int PhantomId;

	// Token: 0x04005753 RID: 22355
	public int Level;

	// Token: 0x04005754 RID: 22356
	public string RarityId = "";

	// Token: 0x04005755 RID: 22357
	public string PropertyTexture = "";

	// Token: 0x04005756 RID: 22358
	public int PropertyId;

	// Token: 0x04005757 RID: 22359
	public bool IsBreak;

	// Token: 0x04005758 RID: 22360
	public List<CommonComponentDefine.TipsAttributeData> BreakAttributeList = new List<CommonComponentDefine.TipsAttributeData>();

	// Token: 0x04005759 RID: 22361
	public bool IsMain;

	// Token: 0x0400575A RID: 22362
	public List<CommonComponentDefine.TipsAttributeData> MainAttributeList = new List<CommonComponentDefine.TipsAttributeData>();

	// Token: 0x0400575B RID: 22363
	public string MainSkillText = "";

	// Token: 0x0400575C RID: 22364
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] MainSkillParameter;

	// Token: 0x0400575D RID: 22365
	public string SkillIcon = "";

	// Token: 0x0400575E RID: 22366
	public bool IsSub;

	// Token: 0x0400575F RID: 22367
	public List<CommonComponentDefine.TipsAttributeData> SubAttributeList = new List<CommonComponentDefine.TipsAttributeData>();

	// Token: 0x04005760 RID: 22368
	public bool IsUnlockSub;

	// Token: 0x04005761 RID: 22369
	public string UnlockSubTips = "";
}
