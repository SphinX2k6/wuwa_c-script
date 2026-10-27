using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020034B0 RID: 13488
[NullableContext(1)]
[Nullable(0)]
public class CombatScriptHelperBase
{
	// Token: 0x0601D60D RID: 120333 RVA: 0x00831E54 File Offset: 0x00830054
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

	// Token: 0x0601D60E RID: 120334 RVA: 0x00831F18 File Offset: 0x00830118
	private void Clear()
	{
		this.CombatScripts.Clear();
		this.CombatScriptNames.Clear();
		this.UeCombatScriptNames.Empty(true);
	}

	// Token: 0x0601D60F RID: 120335 RVA: 0x00831F3C File Offset: 0x0083013C
	public virtual void OnInit()
	{
	}

	// Token: 0x0601D610 RID: 120336 RVA: 0x00831F40 File Offset: 0x00830140
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

	// Token: 0x170028BC RID: 10428
	// (get) Token: 0x0601D611 RID: 120337 RVA: 0x0083202C File Offset: 0x0083022C
	public TArray<string> CombatScriptIndexes
	{
		get
		{
			this.Init();
			return this.UeCombatScriptNames;
		}
	}

	// Token: 0x0601D612 RID: 120338 RVA: 0x0083203C File Offset: 0x0083023C
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

	// Token: 0x0400E769 RID: 59241
	protected readonly List<CombatScriptSet> CombatScripts = new List<CombatScriptSet>();

	// Token: 0x0400E76A RID: 59242
	protected readonly List<string> CombatScriptNames = new List<string>();

	// Token: 0x0400E76B RID: 59243
	protected readonly TArray<string> UeCombatScriptNames = new TArray<string>();

	// Token: 0x0400E76C RID: 59244
	protected bool IsInit;
}
