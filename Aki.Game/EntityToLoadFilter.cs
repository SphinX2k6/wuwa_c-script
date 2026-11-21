using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002A31 RID: 10801
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class EntityToLoadFilter : Filter<EntityHandle>, IEntityToLoadParam
{
	// Token: 0x17002C61 RID: 11361
	// (get) Token: 0x0601B36E RID: 111470 RVA: 0x0085B3A8 File Offset: 0x008595A8
	public override string DebugName
	{
		get
		{
			return "EntityToLoadFilter";
		}
	}

	// Token: 0x17002C62 RID: 11362
	// (get) Token: 0x0601B36F RID: 111471 RVA: 0x0085B3AF File Offset: 0x008595AF
	public string MaxLoadingDebugName
	{
		get
		{
			return this.DebugName;
		}
	}

	// Token: 0x17002C63 RID: 11363
	// (get) Token: 0x0601B370 RID: 111472 RVA: 0x0085B3B7 File Offset: 0x008595B7
	public string LoadingIntervalDebugName
	{
		get
		{
			return this.DebugName;
		}
	}

	// Token: 0x17002C64 RID: 11364
	// (get) Token: 0x0601B371 RID: 111473 RVA: 0x0085B3BF File Offset: 0x008595BF
	// (set) Token: 0x0601B372 RID: 111474 RVA: 0x0085B3C7 File Offset: 0x008595C7
	public long MaxLoadingCount
	{
		get
		{
			return this.MaxLoadingCountInternal;
		}
		set
		{
			if (this.MaxLoadingCountInternal != value)
			{
				this.MaxLoadingCountInternal = value;
				EventSystem.Instance.Emit<IEntityToLoadParam>(EEventName.EntityToLoadParamUpdated, this);
			}
		}
	}

	// Token: 0x17002C65 RID: 11365
	// (get) Token: 0x0601B373 RID: 111475 RVA: 0x0085B3EA File Offset: 0x008595EA
	// (set) Token: 0x0601B374 RID: 111476 RVA: 0x0085B3F2 File Offset: 0x008595F2
	public long LoadingInterval
	{
		get
		{
			return this.LoadingIntervalInternal;
		}
		set
		{
			if (this.LoadingIntervalInternal != value)
			{
				this.LoadingIntervalInternal = value;
				EventSystem.Instance.Emit<IEntityToLoadParam>(EEventName.EntityToLoadParamUpdated, this);
			}
		}
	}

	// Token: 0x0601B375 RID: 111477 RVA: 0x0085B415 File Offset: 0x00859615
	protected override bool OnInit()
	{
		EventSystem.Instance.Emit<EntityToLoadFilter>(EEventName.EntityToLoadFilterCreated, this);
		return true;
	}

	// Token: 0x0601B376 RID: 111478 RVA: 0x0085B429 File Offset: 0x00859629
	protected override bool OnCleanup()
	{
		EventSystem.Instance.Emit<EntityToLoadFilter>(EEventName.EntityToLoadFilterDestroyed, this);
		return true;
	}

	// Token: 0x0601B377 RID: 111479 RVA: 0x0085B43D File Offset: 0x0085963D
	public static EntityToLoadFilter Create()
	{
		EntityToLoadFilter entityToLoadFilter = new EntityToLoadFilter();
		entityToLoadFilter.Init();
		return entityToLoadFilter;
	}

	// Token: 0x0400EC5F RID: 60511
	public const long MAX_LOADING_ENTITY_COUNT = 4L;

	// Token: 0x0400EC60 RID: 60512
	public const long LOADING_INTERVAL = 0L;

	// Token: 0x0400EC61 RID: 60513
	private long MaxLoadingCountInternal = 4L;

	// Token: 0x0400EC62 RID: 60514
	private long LoadingIntervalInternal;
}
