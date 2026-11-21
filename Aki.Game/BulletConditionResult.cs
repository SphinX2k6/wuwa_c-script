using System;

// Token: 0x02002365 RID: 9061
public class BulletConditionResult
{
	// Token: 0x06016557 RID: 91479 RVA: 0x0068033E File Offset: 0x0067E53E
	public void Clear()
	{
		this.HasConstResult = false;
		this.ConstResult = false;
		this.KeepEnable = false;
		this.KeepDisable = false;
	}

	// Token: 0x0400BCA8 RID: 48296
	public bool HasConstResult;

	// Token: 0x0400BCA9 RID: 48297
	public bool ConstResult;

	// Token: 0x0400BCAA RID: 48298
	public bool KeepEnable;

	// Token: 0x0400BCAB RID: 48299
	public bool KeepDisable;
}
