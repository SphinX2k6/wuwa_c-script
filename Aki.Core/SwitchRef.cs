using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000D8 RID: 216
[NullableContext(1)]
[Nullable(0)]
public class SwitchRef : IClear
{
	// Token: 0x060006C7 RID: 1735 RVA: 0x0002403E File Offset: 0x0002223E
	public SwitchRef(string group, string stateInternal)
	{
		this.Group = group;
		this.StateInternal = stateInternal;
	}

	// Token: 0x170000DE RID: 222
	// (get) Token: 0x060006C8 RID: 1736 RVA: 0x00024054 File Offset: 0x00022254
	// (set) Token: 0x060006C9 RID: 1737 RVA: 0x0002405C File Offset: 0x0002225C
	public string State
	{
		get
		{
			return this.StateInternal;
		}
		set
		{
			AActor actor = this.Actor;
			if (actor == null || !actor.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Audio;
				ELogAuthor author = ELogAuthor.MSY;
				string message = "[Core.SwitchRef] 绑定对象无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Group", this.Group);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (this.StateInternal != value)
			{
				this.StateInternal = value;
				AudioSystem.Instance.SetSwitch(this.Group, this.State, this.Actor);
			}
		}
	}

	// Token: 0x060006CA RID: 1738 RVA: 0x000240DE File Offset: 0x000222DE
	public void Bind(AActor actor)
	{
		this.Actor = actor;
		AudioSystem.Instance.SetSwitch(this.Group, this.State, this.Actor);
	}

	// Token: 0x060006CB RID: 1739 RVA: 0x00024103 File Offset: 0x00022303
	public bool ClearObject()
	{
		this.Actor = null;
		return true;
	}

	// Token: 0x0400056E RID: 1390
	[Nullable(2)]
	private AActor Actor;

	// Token: 0x0400056F RID: 1391
	private readonly string Group;

	// Token: 0x04000570 RID: 1392
	private string StateInternal;
}
