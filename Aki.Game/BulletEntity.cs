using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.World.Define;

// Token: 0x0200234A RID: 9034
[NullableContext(1)]
[Nullable(0)]
public class BulletEntity : Entity
{
	// Token: 0x060163C9 RID: 91081 RVA: 0x0067DA65 File Offset: 0x0067BC65
	public BulletEntity(int id, int index) : base(id, index)
	{
	}

	// Token: 0x17002223 RID: 8739
	// (get) Token: 0x060163CA RID: 91082 RVA: 0x0067DA81 File Offset: 0x0067BC81
	public override bool UsePool { get; } = 1;

	// Token: 0x060163CB RID: 91083 RVA: 0x0067DA89 File Offset: 0x0067BC89
	protected override TsGameBudgetGroupConfig StaticGameBudgetConfig()
	{
		return new TsGameBudgetGroupConfig(GameBudgetAllocatorConfigCreator.Instance.TsAlwaysTickConfig);
	}

	// Token: 0x060163CC RID: 91084 RVA: 0x0067DA9A File Offset: 0x0067BC9A
	public BulletInfo GetBulletInfo()
	{
		return this.Info;
	}

	// Token: 0x17002224 RID: 8740
	// (get) Token: 0x060163CD RID: 91085 RVA: 0x0067DAA2 File Offset: 0x0067BCA2
	public BulletDataMain Data
	{
		get
		{
			return this.Info.BulletDataMain;
		}
	}

	// Token: 0x17002225 RID: 8741
	// (get) Token: 0x060163CE RID: 91086 RVA: 0x0067DAAF File Offset: 0x0067BCAF
	public Entity BulletOwner
	{
		get
		{
			return this.Info.BulletInitParams.Owner;
		}
	}

	// Token: 0x17002226 RID: 8742
	// (get) Token: 0x060163CF RID: 91087 RVA: 0x0067DAC1 File Offset: 0x0067BCC1
	public bool NeedDestroy
	{
		get
		{
			return this.Info.NeedDestroy;
		}
	}

	// Token: 0x060163D0 RID: 91088 RVA: 0x0067DAD0 File Offset: 0x0067BCD0
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

	// Token: 0x060163D1 RID: 91089 RVA: 0x0067DB17 File Offset: 0x0067BD17
	protected override bool OnStart()
	{
		base.SetTimeDilation(Time.Instance.TimeDilation);
		return true;
	}

	// Token: 0x060163D2 RID: 91090 RVA: 0x0067DB2A File Offset: 0x0067BD2A
	protected override bool OnClear()
	{
		this.Info.Clear();
		return true;
	}

	// Token: 0x060163D3 RID: 91091 RVA: 0x0067DB38 File Offset: 0x0067BD38
	[NullableContext(2)]
	public override bool Respawn(IEntityArgs args = null)
	{
		base.RegisterToGameBudgetController(null);
		return base.Respawn(args);
	}

	// Token: 0x0400BBA8 RID: 48040
	private readonly BulletInfo Info = new BulletInfo();
}
