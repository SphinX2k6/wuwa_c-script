using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001020 RID: 4128
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerGroupAction : GuessJokerActionBase
{
	// Token: 0x06006A0C RID: 27148 RVA: 0x001542DF File Offset: 0x001524DF
	public GuessJokerGroupAction(GuessJokerActionBase[] actions)
	{
		this.Actions.AddRange(actions);
	}

	// Token: 0x06006A0D RID: 27149 RVA: 0x00154300 File Offset: 0x00152500
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

	// Token: 0x06006A0E RID: 27150 RVA: 0x0015434C File Offset: 0x0015254C
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

	// Token: 0x06006A0F RID: 27151 RVA: 0x001543BC File Offset: 0x001525BC
	protected override void OnFinish()
	{
		for (int i = 0; i < this.Actions.Count; i++)
		{
			this.Actions[i].Finish();
		}
	}

	// Token: 0x040030DF RID: 12511
	private readonly List<GuessJokerActionBase> Actions = new List<GuessJokerActionBase>();
}
