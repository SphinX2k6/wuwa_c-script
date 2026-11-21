using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200274E RID: 10062
[NullableContext(1)]
[Nullable(0)]
public class PerformActionChangeBuffEffect : PerformAction
{
	// Token: 0x0601940E RID: 103438 RVA: 0x007B68F7 File Offset: 0x007B4AF7
	public override void Register(Entity entity)
	{
		base.Register(entity);
		this.CueComp = entity.GetComponent<BaseGameplayCueComponent>();
	}

	// Token: 0x0601940F RID: 103439 RVA: 0x007B690C File Offset: 0x007B4B0C
	public override void UnRegister()
	{
		this.CueComp = null;
		base.UnRegister();
	}

	// Token: 0x06019410 RID: 103440 RVA: 0x007B691C File Offset: 0x007B4B1C
	public override void Begin()
	{
		if (this.Entity == null)
		{
			return;
		}
		foreach (int num in this.BuffEffectIds)
		{
			BaseGameplayCueComponent cueComp = this.CueComp;
			int num2 = (cueComp != null) ? cueComp.AddCue((long)num, null) : 0;
			if (num2 != 0 && num2 != -1)
			{
				this.CueHandles.Add(num2);
			}
		}
	}

	// Token: 0x06019411 RID: 103441 RVA: 0x007B69A4 File Offset: 0x007B4BA4
	public override void End()
	{
		if (this.Entity == null)
		{
			return;
		}
		foreach (int num in this.CueHandles)
		{
			BaseGameplayCueComponent cueComp = this.CueComp;
			if (cueComp != null)
			{
				cueComp.RemoveCueByHandle((long)num);
			}
		}
		this.CueHandles.Clear();
	}

	// Token: 0x0400DCF7 RID: 56567
	public new EPerformActionType Type = EPerformActionType.ChangeBuffEffect;

	// Token: 0x0400DCF8 RID: 56568
	public List<int> BuffEffectIds = new List<int>();

	// Token: 0x0400DCF9 RID: 56569
	[Nullable(2)]
	public BaseGameplayCueComponent CueComp;

	// Token: 0x0400DCFA RID: 56570
	private readonly List<int> CueHandles = new List<int>();
}
