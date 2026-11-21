using System;
using System.Runtime.CompilerServices;

// Token: 0x020000D9 RID: 217
[NullableContext(1)]
[Nullable(0)]
public class StateRef : IClear
{
	// Token: 0x06000704 RID: 1796 RVA: 0x000245C3 File Offset: 0x000227C3
	public StateRef(string group, string initState)
	{
		this.Group = group;
		this._State = initState;
	}

	// Token: 0x170000EF RID: 239
	// (get) Token: 0x06000705 RID: 1797 RVA: 0x000245D9 File Offset: 0x000227D9
	// (set) Token: 0x06000706 RID: 1798 RVA: 0x000245E1 File Offset: 0x000227E1
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

	// Token: 0x06000707 RID: 1799 RVA: 0x0002460F File Offset: 0x0002280F
	public bool ClearObject()
	{
		return true;
	}

	// Token: 0x0400057B RID: 1403
	private string Group;

	// Token: 0x0400057C RID: 1404
	private string _State;
}
