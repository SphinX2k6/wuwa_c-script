using System;
using System.Runtime.CompilerServices;

// Token: 0x020000D7 RID: 215
[NullableContext(1)]
[Nullable(0)]
public class StateRef : IClear
{
	// Token: 0x060006C3 RID: 1731 RVA: 0x00023FEF File Offset: 0x000221EF
	public StateRef(string group, string initState)
	{
		this.Group = group;
		this._State = initState;
	}

	// Token: 0x170000DD RID: 221
	// (get) Token: 0x060006C4 RID: 1732 RVA: 0x00024005 File Offset: 0x00022205
	// (set) Token: 0x060006C5 RID: 1733 RVA: 0x0002400D File Offset: 0x0002220D
	public string State
	{
		get
		{
			return this._State;
		}
		set
		{
			if (this._State != value)
			{
				this._State = value;
				AudioSystem.Instance.SetState(this.Group, this._State, true);
			}
		}
	}

	// Token: 0x060006C6 RID: 1734 RVA: 0x0002403B File Offset: 0x0002223B
	public bool ClearObject()
	{
		return true;
	}

	// Token: 0x0400056C RID: 1388
	private string Group;

	// Token: 0x0400056D RID: 1389
	private string _State;
}
