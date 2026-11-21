using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;

// Token: 0x02002367 RID: 9063
public class BulletEffectInfo
{
	// Token: 0x06016565 RID: 91493 RVA: 0x00680A84 File Offset: 0x0067EC84
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

	// Token: 0x0400BCE2 RID: 48354
	[Nullable(2)]
	public BulletDataRender EffectData;

	// Token: 0x0400BCE3 RID: 48355
	public int Effect;

	// Token: 0x0400BCE4 RID: 48356
	public int EffectExtremity;

	// Token: 0x0400BCE5 RID: 48357
	public int EffectBlock;

	// Token: 0x0400BCE6 RID: 48358
	public bool HandOver;

	// Token: 0x0400BCE7 RID: 48359
	public bool IsFinishAuto;

	// Token: 0x0400BCE8 RID: 48360
	public float EffectOriginSize;

	// Token: 0x0400BCE9 RID: 48361
	public bool IsEffectDestroy;

	// Token: 0x0400BCEA RID: 48362
	public bool DisablePostProcess;
}
