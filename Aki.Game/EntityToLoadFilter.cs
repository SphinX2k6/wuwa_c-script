using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020034BD RID: 13501
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class EntityToLoadFilter : Filter<EntityHandle>, IEntityToLoadParam
{
	// Token: 0x170028C9 RID: 10441
	// (get) Token: 0x0601D66F RID: 120431 RVA: 0x00833F00 File Offset: 0x00832100
	public override string DebugName
	{
		get
		{
			return "EntityToLoadFilter";
		}
	}

	// Token: 0x170028CA RID: 10442
	// (get) Token: 0x0601D670 RID: 120432 RVA: 0x00833F07 File Offset: 0x00832107
	public string MaxLoadingDebugName
	{
		get
		{
			return this.DebugName;
		}
	}

	// Token: 0x170028CB RID: 10443
	// (get) Token: 0x0601D671 RID: 120433 RVA: 0x00833F0F File Offset: 0x0083210F
	public string LoadingIntervalDebugName
	{
		get
		{
			return this.DebugName;
		}
	}

	// Token: 0x170028CC RID: 10444
	// (get) Token: 0x0601D672 RID: 120434 RVA: 0x00833F17 File Offset: 0x00832117
	// (set) Token: 0x0601D673 RID: 120435 RVA: 0x00833F1F File Offset: 0x0083211F
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

	// Token: 0x170028CD RID: 10445
	// (get) Token: 0x0601D674 RID: 120436 RVA: 0x00833F42 File Offset: 0x00832142
	// (set) Token: 0x0601D675 RID: 120437 RVA: 0x00833F4A File Offset: 0x0083214A
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

	// Token: 0x0601D676 RID: 120438 RVA: 0x00833F6D File Offset: 0x0083216D
	protected override bool OnInit()
	{
		EventSystem.Instance.Emit<EntityToLoadFilter>(EEventName.EntityToLoadFilterCreated, this);
		return true;
	}

	// Token: 0x0601D677 RID: 120439 RVA: 0x00833F81 File Offset: 0x00832181
	protected override bool OnCleanup()
	{
		EventSystem.Instance.Emit<EntityToLoadFilter>(EEventName.EntityToLoadFilterDestroyed, this);
		return true;
	}

	// Token: 0x0601D678 RID: 120440 RVA: 0x00833F95 File Offset: 0x00832195
	public static EntityToLoadFilter Create()
	{
		EntityToLoadFilter entityToLoadFilter = new EntityToLoadFilter();
		entityToLoadFilter.Init();
		return entityToLoadFilter;
	}

	// Token: 0x0400E7AB RID: 59307
	public const long MAX_LOADING_ENTITY_COUNT = 4L;

	// Token: 0x0400E7AC RID: 59308
	public const long LOADING_INTERVAL = 0L;

	// Token: 0x0400E7AD RID: 59309
	private long MaxLoadingCountInternal = 4L;

	// Token: 0x0400E7AE RID: 59310
	private long LoadingIntervalInternal;
}
