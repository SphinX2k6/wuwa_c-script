using System;
using System.Runtime.CompilerServices;

// Token: 0x02003305 RID: 13061
[NullableContext(1)]
[Nullable(0)]
public class SkillAssetRecord
{
	// Token: 0x0400E200 RID: 57856
	public int SkillId;

	// Token: 0x0400E201 RID: 57857
	public string ActorBlueprint = "";

	// Token: 0x0400E202 RID: 57858
	public int LoadType;

	// Token: 0x0400E203 RID: 57859
	public bool IsCommon;

	// Token: 0x0400E204 RID: 57860
	public bool HasMontagePath;

	// Token: 0x0400E205 RID: 57861
	public AssetRecord AssetRecord = new AssetRecord();
}
