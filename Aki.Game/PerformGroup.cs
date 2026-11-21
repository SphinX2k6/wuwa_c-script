using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002750 RID: 10064
[NullableContext(1)]
[Nullable(0)]
public class PerformGroup : IStaticVariableResetter
{
	// Token: 0x06019414 RID: 103444 RVA: 0x007B6A4C File Offset: 0x007B4C4C
	static PerformGroup()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PerformGroup.CreateStaticDefaultValue), new Action(PerformGroup.ResetStaticDefaultValue));
	}

	// Token: 0x06019415 RID: 103445 RVA: 0x007B6A6C File Offset: 0x007B4C6C
	public void Register(Entity entity)
	{
		this.Entity = entity;
		foreach (PerformAction performAction in this.ActionList)
		{
			performAction.Register(entity);
		}
	}

	// Token: 0x06019416 RID: 103446 RVA: 0x007B6AC4 File Offset: 0x007B4CC4
	public void UnRegister()
	{
		foreach (PerformAction performAction in this.ActionList)
		{
			performAction.UnRegister();
		}
		this.Entity = null;
	}

	// Token: 0x06019417 RID: 103447 RVA: 0x007B6B1C File Offset: 0x007B4D1C
	public void AddAction(PerformAction action)
	{
		this.ActionList.Add(action);
		if (this.Entity != null)
		{
			action.Register(this.Entity);
		}
	}

	// Token: 0x06019418 RID: 103448 RVA: 0x007B6B40 File Offset: 0x007B4D40
	public void Start()
	{
		foreach (PerformAction performAction in this.ActionList)
		{
			performAction.Begin();
		}
	}

	// Token: 0x06019419 RID: 103449 RVA: 0x007B6B90 File Offset: 0x007B4D90
	public void Tick(double delta)
	{
		foreach (PerformAction performAction in this.ActionList)
		{
			performAction.Tick(delta);
		}
	}

	// Token: 0x0601941A RID: 103450 RVA: 0x007B6BE4 File Offset: 0x007B4DE4
	public void Stop()
	{
		foreach (PerformAction performAction in this.ActionList)
		{
			performAction.End();
		}
	}

	// Token: 0x0601941B RID: 103451 RVA: 0x007B6C34 File Offset: 0x007B4E34
	public static void CreateStaticDefaultValue()
	{
		PerformGroup.IdGenerator = 0;
	}

	// Token: 0x0601941C RID: 103452 RVA: 0x007B6C3C File Offset: 0x007B4E3C
	public static void ResetStaticDefaultValue()
	{
		PerformGroup.IdGenerator = 0;
	}

	// Token: 0x0400DCFC RID: 56572
	private static int IdGenerator;

	// Token: 0x0400DCFD RID: 56573
	public int Id = ++PerformGroup.IdGenerator;

	// Token: 0x0400DCFE RID: 56574
	[Nullable(2)]
	public Entity Entity;

	// Token: 0x0400DCFF RID: 56575
	public string SwitchKey = "None";

	// Token: 0x0400DD00 RID: 56576
	public List<PerformAction> ActionList = new List<PerformAction>();
}
