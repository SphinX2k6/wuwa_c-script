using System;
using System.Runtime.CompilerServices;

// Token: 0x02002885 RID: 10373
[NullableContext(1)]
[Nullable(0)]
public class FightAssetManager
{
	// Token: 0x0601A4B8 RID: 107704 RVA: 0x00824380 File Offset: 0x00822580
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

	// Token: 0x0601A4B9 RID: 107705 RVA: 0x008243A7 File Offset: 0x008225A7
	public void Clear()
	{
		this.SkillAssetManager.Clear();
		this.BulletAssetManager.Clear();
	}

	// Token: 0x0400E6EE RID: 59118
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public readonly OneOf<EntityAssetElement, PbEntityAssetElement> EntityAssetElement;

	// Token: 0x0400E6EF RID: 59119
	public SkillAssetManager SkillAssetManager;

	// Token: 0x0400E6F0 RID: 59120
	public BulletAssetManager BulletAssetManager;
}
