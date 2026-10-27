using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020031DF RID: 12767
[NullableContext(1)]
[Nullable(0)]
public class PerformActionChangeBuffEffect : PerformAction
{
	// Token: 0x0601B895 RID: 112789 RVA: 0x0078DFFF File Offset: 0x0078C1FF
	public override void Register(Entity entity)
	{
		base.Register(entity);
		this.CueComp = entity.GetComponent<BaseGameplayCueComponent>();
	}

	// Token: 0x0601B896 RID: 112790 RVA: 0x0078E014 File Offset: 0x0078C214
	public override void UnRegister()
	{
		this.CueComp = null;
		base.UnRegister();
	}

	// Token: 0x0601B897 RID: 112791 RVA: 0x0078E024 File Offset: 0x0078C224
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

	// Token: 0x0601B898 RID: 112792 RVA: 0x0078E0AC File Offset: 0x0078C2AC
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

	// Token: 0x0400D859 RID: 55385
	public new EPerformActionType Type = EPerformActionType.ChangeBuffEffect;

	// Token: 0x0400D85A RID: 55386
	public List<int> BuffEffectIds = new List<int>();

	// Token: 0x0400D85B RID: 55387
	[Nullable(2)]
	public BaseGameplayCueComponent CueComp;

	// Token: 0x0400D85C RID: 55388
	private readonly List<int> CueHandles = new List<int>();
}
