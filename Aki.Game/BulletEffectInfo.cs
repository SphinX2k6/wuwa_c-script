using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;

// Token: 0x02002E0B RID: 11787
public class BulletEffectInfo
{
	// Token: 0x06018CA4 RID: 101540 RVA: 0x0065A8B0 File Offset: 0x00658AB0
	public void Clear()
	{
		if (EffectSystem.Instance.IsValid(this.EffectExtremity))
		{
			EffectSystem.Instance.StopEffectById(this.EffectExtremity, "[BulletEffectInfo.Clear]", true, null);
		}
		if (EffectSystem.Instance.IsValid(this.EffectBlock))
		{
			EffectSystem.Instance.StopEffectById(this.EffectBlock, "[BulletEffectInfo.Clear]", true, null);
		}
		this.EffectData = null;
		this.Effect = 0;
		this.EffectExtremity = 0;
		this.EffectBlock = 0;
		this.HandOver = false;
		this.IsFinishAuto = false;
		this.EffectOriginSize = 0f;
		this.IsEffectDestroy = false;
		this.DisablePostProcess = false;
	}

	// Token: 0x0400B954 RID: 47444
	[Nullable(2)]
	public BulletDataRender EffectData;

	// Token: 0x0400B955 RID: 47445
	public int Effect;

	// Token: 0x0400B956 RID: 47446
	public int EffectExtremity;

	// Token: 0x0400B957 RID: 47447
	public int EffectBlock;

	// Token: 0x0400B958 RID: 47448
	public bool HandOver;

	// Token: 0x0400B959 RID: 47449
	public bool IsFinishAuto;

	// Token: 0x0400B95A RID: 47450
	public float EffectOriginSize;

	// Token: 0x0400B95B RID: 47451
	public bool IsEffectDestroy;

	// Token: 0x0400B95C RID: 47452
	public bool DisablePostProcess;
}
