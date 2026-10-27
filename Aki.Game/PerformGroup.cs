using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020031E1 RID: 12769
[NullableContext(1)]
[Nullable(0)]
public class PerformGroup : IStaticVariableResetter
{
	// Token: 0x0601B89B RID: 112795 RVA: 0x0078E154 File Offset: 0x0078C354
	static PerformGroup()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PerformGroup.CreateStaticDefaultValue), new Action(PerformGroup.ResetStaticDefaultValue));
	}

	// Token: 0x0601B89C RID: 112796 RVA: 0x0078E174 File Offset: 0x0078C374
	public void Register(Entity entity)
	{
		this.Entity = entity;
		foreach (PerformAction performAction in this.ActionList)
		{
			performAction.Register(entity);
		}
	}

	// Token: 0x0601B89D RID: 112797 RVA: 0x0078E1CC File Offset: 0x0078C3CC
	public void UnRegister()
	{
		foreach (PerformAction performAction in this.ActionList)
		{
			performAction.UnRegister();
		}
		this.Entity = null;
	}

	// Token: 0x0601B89E RID: 112798 RVA: 0x0078E224 File Offset: 0x0078C424
	public void AddAction(PerformAction action)
	{
		this.ActionList.Add(action);
		if (this.Entity != null)
		{
			action.Register(this.Entity);
		}
	}

	// Token: 0x0601B89F RID: 112799 RVA: 0x0078E248 File Offset: 0x0078C448
	public void Start()
	{
		foreach (PerformAction performAction in this.ActionList)
		{
			performAction.Begin();
		}
	}

	// Token: 0x0601B8A0 RID: 112800 RVA: 0x0078E298 File Offset: 0x0078C498
	public void Tick(double delta)
	{
		foreach (PerformAction performAction in this.ActionList)
		{
			performAction.Tick(delta);
		}
	}

	// Token: 0x0601B8A1 RID: 112801 RVA: 0x0078E2EC File Offset: 0x0078C4EC
	public void Stop()
	{
		foreach (PerformAction performAction in this.ActionList)
		{
			performAction.End();
		}
	}

	// Token: 0x0601B8A2 RID: 112802 RVA: 0x0078E33C File Offset: 0x0078C53C
	public static void CreateStaticDefaultValue()
	{
		PerformGroup.IdGenerator = 0;
	}

	// Token: 0x0601B8A3 RID: 112803 RVA: 0x0078E344 File Offset: 0x0078C544
	public static void ResetStaticDefaultValue()
	{
		PerformGroup.IdGenerator = 0;
	}

	// Token: 0x0400D85E RID: 55390
	private static int IdGenerator;

	// Token: 0x0400D85F RID: 55391
	public int Id = ++PerformGroup.IdGenerator;

	// Token: 0x0400D860 RID: 55392
	[Nullable(2)]
	public Entity Entity;

	// Token: 0x0400D861 RID: 55393
	public string SwitchKey = "None";

	// Token: 0x0400D862 RID: 55394
	public List<PerformAction> ActionList = new List<PerformAction>();
}
