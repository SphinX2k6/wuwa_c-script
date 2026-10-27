using System;
using System.Runtime.CompilerServices;

// Token: 0x02003313 RID: 13075
[NullableContext(1)]
[Nullable(0)]
public class FightAssetManager
{
	// Token: 0x0601C7BF RID: 116671 RVA: 0x007FDE14 File Offset: 0x007FC014
	public FightAssetManager([Nullable(new byte[]
	{
		0,
		1,
		1
	})] OneOf<EntityAssetElement, PbEntityAssetElement> entityAssetElement)
	{
		this.EntityAssetElement = entityAssetElement;
		this.SkillAssetManager = new SkillAssetManager(this);
		this.BulletAssetManager = new BulletAssetManager(this);
	}

	// Token: 0x0601C7C0 RID: 116672 RVA: 0x007FDE3B File Offset: 0x007FC03B
	public void Clear()
	{
		this.SkillAssetManager.Clear();
		this.BulletAssetManager.Clear();
	}

	// Token: 0x0400E23D RID: 57917
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public readonly OneOf<EntityAssetElement, PbEntityAssetElement> EntityAssetElement;

	// Token: 0x0400E23E RID: 57918
	public SkillAssetManager SkillAssetManager;

	// Token: 0x0400E23F RID: 57919
	public BulletAssetManager BulletAssetManager;
}
