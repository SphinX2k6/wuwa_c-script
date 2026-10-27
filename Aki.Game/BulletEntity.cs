using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.World.Define;

// Token: 0x02002DEF RID: 11759
[NullableContext(1)]
[Nullable(0)]
public class BulletEntity : Entity
{
	// Token: 0x06018B14 RID: 101140 RVA: 0x006579E3 File Offset: 0x00655BE3
	public BulletEntity(int id, int index) : base(id, index)
	{
	}

	// Token: 0x170021BF RID: 8639
	// (get) Token: 0x06018B15 RID: 101141 RVA: 0x006579FF File Offset: 0x00655BFF
	public override bool UsePool { get; } = 1;

	// Token: 0x06018B16 RID: 101142 RVA: 0x00657A07 File Offset: 0x00655C07
	protected override TsGameBudgetGroupConfig StaticGameBudgetConfig()
	{
		return new TsGameBudgetGroupConfig(GameBudgetAllocatorConfigCreator.Instance.TsAlwaysTickConfig);
	}

	// Token: 0x06018B17 RID: 101143 RVA: 0x00657A18 File Offset: 0x00655C18
	public BulletInfo GetBulletInfo()
	{
		return this.Info;
	}

	// Token: 0x170021C0 RID: 8640
	// (get) Token: 0x06018B18 RID: 101144 RVA: 0x00657A20 File Offset: 0x00655C20
	public BulletDataMain Data
	{
		get
		{
			return this.Info.BulletDataMain;
		}
	}

	// Token: 0x170021C1 RID: 8641
	// (get) Token: 0x06018B19 RID: 101145 RVA: 0x00657A2D File Offset: 0x00655C2D
	public Entity BulletOwner
	{
		get
		{
			return this.Info.BulletInitParams.Owner;
		}
	}

	// Token: 0x170021C2 RID: 8642
	// (get) Token: 0x06018B1A RID: 101146 RVA: 0x00657A3F File Offset: 0x00655C3F
	public bool NeedDestroy
	{
		get
		{
			return this.Info.NeedDestroy;
		}
	}

	// Token: 0x06018B1B RID: 101147 RVA: 0x00657A4C File Offset: 0x00655C4C
	[NullableContext(2)]
	protected override bool OnCreate(IEntityArgs args = null)
	{
		if (!base.AddComponent<BulletActorComponent>(null, null))
		{
			return false;
		}
		if (!base.AddComponent<BulletActionLogicComponent>(null, null))
		{
			return false;
		}
		base.RegisterToGameBudgetController(null);
		return true;
	}

	// Token: 0x06018B1C RID: 101148 RVA: 0x00657A93 File Offset: 0x00655C93
	protected override bool OnStart()
	{
		base.SetTimeDilation(Time.Instance.TimeDilation);
		return true;
	}

	// Token: 0x06018B1D RID: 101149 RVA: 0x00657AA6 File Offset: 0x00655CA6
	protected override bool OnClear()
	{
		this.Info.Clear();
		return true;
	}

	// Token: 0x06018B1E RID: 101150 RVA: 0x00657AB4 File Offset: 0x00655CB4
	[NullableContext(2)]
	public override bool Respawn(IEntityArgs args = null)
	{
		base.RegisterToGameBudgetController(null);
		return base.Respawn(args);
	}

	// Token: 0x0400B822 RID: 47138
	private readonly BulletInfo Info = new BulletInfo();
}
