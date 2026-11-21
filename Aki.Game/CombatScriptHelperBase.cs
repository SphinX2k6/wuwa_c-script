using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002A24 RID: 10788
[NullableContext(1)]
[Nullable(0)]
public class CombatScriptHelperBase
{
	// Token: 0x0601B30C RID: 111372 RVA: 0x00859274 File Offset: 0x00857474
	public void Init()
	{
		if (this.IsInit)
		{
			return;
		}
		this.Clear();
		this.OnInit();
		foreach (CombatScriptSet combatScriptSet in this.CombatScripts)
		{
			foreach (CombatScriptUnit combatScriptUnit in combatScriptSet.CombatScriptUnits)
			{
				this.CombatScriptNames.Add(combatScriptUnit.Cmd);
				this.UeCombatScriptNames.Add(combatScriptUnit.Cmd);
			}
		}
		this.IsInit = true;
	}

	// Token: 0x0601B30D RID: 111373 RVA: 0x00859338 File Offset: 0x00857538
	private void Clear()
	{
		this.CombatScripts.Clear();
		this.CombatScriptNames.Clear();
		this.UeCombatScriptNames.Empty(true);
	}

	// Token: 0x0601B30E RID: 111374 RVA: 0x0085935C File Offset: 0x0085755C
	public virtual void OnInit()
	{
	}

	// Token: 0x0601B30F RID: 111375 RVA: 0x00859360 File Offset: 0x00857560
	public string FilterCmd(string cmd)
	{
		string text = cmd;
		foreach (CombatScriptSet combatScriptSet in this.CombatScripts)
		{
			if (cmd == combatScriptSet.GetType().Name)
			{
				return combatScriptSet.OnFilterCmd();
			}
			foreach (CombatScriptUnit combatScriptUnit in combatScriptSet.CombatScriptUnits)
			{
				int num = text.IndexOf(combatScriptUnit.Cmd, StringComparison.Ordinal);
				if (num >= 0)
				{
					text = text.Remove(num, combatScriptUnit.Cmd.Length).Insert(num, combatScriptUnit.Body);
				}
			}
		}
		return text;
	}

	// Token: 0x17002C54 RID: 11348
	// (get) Token: 0x0601B310 RID: 111376 RVA: 0x0085944C File Offset: 0x0085764C
	public TArray<string> CombatScriptIndexes
	{
		get
		{
			this.Init();
			return this.UeCombatScriptNames;
		}
	}

	// Token: 0x0601B311 RID: 111377 RVA: 0x0085945C File Offset: 0x0085765C
	[return: Nullable(2)]
	public CombatScriptSet GetCombatScriptBaseByName(string name)
	{
		foreach (CombatScriptSet combatScriptSet in this.CombatScripts)
		{
			if (combatScriptSet.GetType().Name == name)
			{
				return combatScriptSet;
			}
		}
		return null;
	}

	// Token: 0x0400EC1D RID: 60445
	protected readonly List<CombatScriptSet> CombatScripts = new List<CombatScriptSet>();

	// Token: 0x0400EC1E RID: 60446
	protected readonly List<string> CombatScriptNames = new List<string>();

	// Token: 0x0400EC1F RID: 60447
	protected readonly TArray<string> UeCombatScriptNames = new TArray<string>();

	// Token: 0x0400EC20 RID: 60448
	protected bool IsInit;
}
