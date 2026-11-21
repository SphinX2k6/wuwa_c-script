using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020004D4 RID: 1236
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerGroupAction : GuessJokerActionBase
{
	// Token: 0x06003DA1 RID: 15777 RVA: 0x0015CC07 File Offset: 0x0015AE07
	public GuessJokerGroupAction(GuessJokerActionBase[] actions)
	{
		this.Actions.AddRange(actions);
	}

	// Token: 0x06003DA2 RID: 15778 RVA: 0x0015CC28 File Offset: 0x0015AE28
	protected override void OnStart()
	{
		if (this.Actions.Count == 0)
		{
			this.Done = true;
			return;
		}
		for (int i = 0; i < this.Actions.Count; i++)
		{
			this.Actions[i].Start();
		}
	}

	// Token: 0x06003DA3 RID: 15779 RVA: 0x0015CC74 File Offset: 0x0015AE74
	protected override void OnTick(float delta)
	{
		for (int i = 0; i < this.Actions.Count; i++)
		{
			this.Actions[i].Tick(delta);
		}
		bool flag = true;
		for (int j = 0; j < this.Actions.Count; j++)
		{
			if (!this.Actions[j].IsDone())
			{
				flag = false;
				break;
			}
		}
		if (flag)
		{
			this.Done = true;
		}
	}

	// Token: 0x06003DA4 RID: 15780 RVA: 0x0015CCE4 File Offset: 0x0015AEE4
	protected override void OnFinish()
	{
		for (int i = 0; i < this.Actions.Count; i++)
		{
			this.Actions[i].Finish();
		}
	}

	// Token: 0x04003178 RID: 12664
	private readonly List<GuessJokerActionBase> Actions = new List<GuessJokerActionBase>();
}
