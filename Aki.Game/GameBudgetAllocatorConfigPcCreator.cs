using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002A78 RID: 10872
[NullableContext(1)]
[Nullable(0)]
public class GameBudgetAllocatorConfigPcCreator : IGamebudgetAllocatorConfigPlatformCreator
{
	// Token: 0x0601B94D RID: 112973 RVA: 0x0087ED48 File Offset: 0x0087CF48
	public GameBudgetAllocatorConfig CreateNormalEntityConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 60U, 500U, 100U, 0f, 0f),
			Normal_Render = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 60U, 500U, 100U, 0f, 0f),
			Normal_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 1000U, 500U, 10U, 0f, 0f),
			Normal_Fighting = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Fighting, 60U, 2000U, 100U, 0f, 0f),
			Fighting_Rendered = null,
			Fighting_NotRendered = null,
			Fighting_Fighting = null,
			Cutscene_Rendered = null,
			Cutscene_Fighting = null,
			Cutscene_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 1000U, 500U, 10U, 0f, 0f)
		};
	}

	// Token: 0x0601B94E RID: 112974 RVA: 0x0087EE24 File Offset: 0x0087D024
	public GameBudgetAllocatorConfig CreateBossEntityConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 60U, 5000U, 500U, 0f, 0f),
			Normal_Render = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 60U, 5000U, 500U, 0f, 0f),
			Normal_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 120U, 1500U, 300U, 0f, 0f),
			Normal_Fighting = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Fighting, 10U, 5000U, 700U, 0f, 0f),
			Fighting_Rendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 60U, 3000U, 300U, 0f, 0f),
			Fighting_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 120U, 1500U, 150U, 0f, 0f),
			Fighting_Fighting = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_Fighting, 1U, 1U, 1U, 0f, 0f),
			Cutscene_Rendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 5U, 5000U, 700U, 0f, 0f),
			Cutscene_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 10U, 3000U, 300U, 0f, 0f),
			Cutscene_Fighting = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_Fighting, 5U, 7000U, 700U, 0f, 0f)
		};
	}

	// Token: 0x0601B94F RID: 112975 RVA: 0x0087EF8C File Offset: 0x0087D18C
	public GameBudgetAllocatorConfig CreateCharacterEntityConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 60U, 3000U, 300U, 0f, 0f),
			Normal_Render = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 60U, 3000U, 300U, 0f, 0f),
			Normal_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 120U, 2000U, 200U, 0f, 0f),
			Normal_Fighting = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Fighting, 60U, 5000U, 500U, 0f, 0f),
			Fighting_Rendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 120U, 2000U, 200U, 0f, 0f),
			Fighting_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 120U, 1000U, 100U, 0f, 0f),
			Fighting_Fighting = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_Fighting, 20U, 3000U, 500U, 0f, 0f),
			Cutscene_Rendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 20U, 5000U, 700U, 0f, 0f),
			Cutscene_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 120U, 2000U, 200U, 0f, 0f)
		};
	}

	// Token: 0x0601B950 RID: 112976 RVA: 0x0087F0D8 File Offset: 0x0087D2D8
	public GameBudgetAllocatorConfig CreateNormalNpcEntityConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 60U, 1000U, 200U, 0f, 0f),
			Normal_Render = null,
			Normal_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 240U, 1000U, 100U, 0f, 0f),
			Normal_Fighting = null,
			Fighting_Rendered = null,
			Fighting_NotRendered = null,
			Fighting_Fighting = null,
			Cutscene_Rendered = null,
			Cutscene_Fighting = null,
			Cutscene_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 240U, 1000U, 100U, 0f, 0f)
		};
	}

	// Token: 0x0601B951 RID: 112977 RVA: 0x0087F184 File Offset: 0x0087D384
	public GameBudgetAllocatorConfig CreateSimpleNpcEntityConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 20U, 1000U, 200U, 0f, 0f),
			Normal_Render = null,
			Normal_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 60U, 500U, 30U, 0f, 0f),
			Normal_Fighting = null,
			Fighting_Rendered = null,
			Fighting_NotRendered = null,
			Fighting_Fighting = null,
			Cutscene_Rendered = null,
			Cutscene_NotRendered = null,
			Cutscene_Fighting = null
		};
	}

	// Token: 0x0601B952 RID: 112978 RVA: 0x0087F211 File Offset: 0x0087D411
	public TsGameBudgetAllocatorTickIntervalDetailConfig CreateFightEffectConfig()
	{
		return new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 1U, 1U, 1U, 0f, 0f);
	}

	// Token: 0x0601B953 RID: 112979 RVA: 0x0087F228 File Offset: 0x0087D428
	public GameBudgetAllocatorConfig CreateEffectConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 180U, 500U, 100U, 0f, 0f),
			Normal_Render = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 60U, 2000U, 300U, 0f, 0f),
			Normal_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 300U, 200U, 50U, 0f, 0f),
			Normal_Fighting = null,
			Cutscene_Fighting = null,
			Fighting_Rendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 300U, 500U, 50U, 0f, 0f),
			Fighting_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 600U, 200U, 20U, 0f, 0f),
			Fighting_Fighting = null,
			Cutscene_Rendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 20U, 4500U, 500U, 0f, 0f),
			Cutscene_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 120U, 1000U, 50U, 0f, 0f)
		};
	}

	// Token: 0x0601B954 RID: 112980 RVA: 0x0087F344 File Offset: 0x0087D544
	public GameBudgetAllocatorConfig CreateEffectImportanceConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 100U, 30000U, 3000U, 0f, 0f),
			Normal_Render = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 100U, 50000U, 5000U, 0f, 0f),
			Normal_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 300U, 1000U, 100U, 0f, 0f),
			Normal_Fighting = null,
			Cutscene_Fighting = null,
			Fighting_Rendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 100U, 5000U, 1000U, 0f, 0f),
			Fighting_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 600U, 500U, 100U, 0f, 0f),
			Fighting_Fighting = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_Fighting, 100U, 5000U, 1000U, 0f, 0f),
			Cutscene_Rendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 100U, 50000U, 5000U, 0f, 0f),
			Cutscene_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 300U, 1000U, 100U, 0f, 0f)
		};
	}

	// Token: 0x0601B955 RID: 112981 RVA: 0x0087F47C File Offset: 0x0087D67C
	public GameBudgetAllocatorConfig CreateStabilizeLowEntityConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 10U, 1U, 1U, 0f, 0f),
			Normal_Render = null,
			Normal_NotRendered = null,
			Normal_Fighting = null,
			Fighting_Rendered = null,
			Fighting_NotRendered = null,
			Fighting_Fighting = null,
			Cutscene_Rendered = null,
			Cutscene_NotRendered = null,
			Cutscene_Fighting = null
		};
	}

	// Token: 0x0601B956 RID: 112982 RVA: 0x0087F4E8 File Offset: 0x0087D6E8
	public GameBudgetAllocatorConfig CreateAlwaysTickHotfixConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 1U, 1U, 1U, 0f, 0f),
			Normal_Render = null,
			Normal_NotRendered = null,
			Normal_Fighting = null,
			Fighting_Rendered = null,
			Fighting_NotRendered = null,
			Fighting_Fighting = null,
			Cutscene_Rendered = null,
			Cutscene_NotRendered = null,
			Cutscene_Fighting = null
		};
	}

	// Token: 0x0601B957 RID: 112983 RVA: 0x0087F554 File Offset: 0x0087D754
	public GameBudgetAllocatorConfig CreateMoveSceneItemEntityConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 3U, 10000U, 5000U, 0f, 0f),
			Normal_Render = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 3U, 10000U, 5000U, 0f, 0f),
			Normal_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 60U, 500U, 10U, 0f, 0f),
			Normal_Fighting = null,
			Fighting_Rendered = null,
			Fighting_NotRendered = null,
			Fighting_Fighting = null,
			Cutscene_Rendered = null,
			Cutscene_NotRendered = null,
			Cutscene_Fighting = null
		};
	}

	// Token: 0x0601B958 RID: 112984 RVA: 0x0087F5FB File Offset: 0x0087D7FB
	public TsGameBudgetAllocatorTickIntervalDetailConfig CreatePlayerAlwaysTickConfig()
	{
		return new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 1U, 1U, 1U, 0f, 0f);
	}

	// Token: 0x0601B959 RID: 112985 RVA: 0x0087F614 File Offset: 0x0087D814
	public GameBudgetAllocatorConfig CreateNormalEntityAlwaysTickConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 1U, 1U, 1U, 0f, 0f),
			Normal_Render = null,
			Normal_NotRendered = null,
			Normal_Fighting = null,
			Fighting_Rendered = null,
			Fighting_NotRendered = null,
			Fighting_Fighting = null,
			Cutscene_Rendered = null,
			Cutscene_NotRendered = null,
			Cutscene_Fighting = null
		};
	}

	// Token: 0x0601B95A RID: 112986 RVA: 0x0087F680 File Offset: 0x0087D880
	public GameBudgetAllocatorConfig CreateNormalEntityAlwaysTickWithoutNotRenderedConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 1U, 1U, 1U, 0f, 0f),
			Normal_Render = null,
			Normal_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 1000U, 500U, 10U, 0f, 0f),
			Normal_Fighting = null,
			Fighting_Rendered = null,
			Fighting_NotRendered = null,
			Fighting_Fighting = null,
			Cutscene_Rendered = null,
			Cutscene_NotRendered = null,
			Cutscene_Fighting = null
		};
	}

	// Token: 0x0601B95B RID: 112987 RVA: 0x0087F707 File Offset: 0x0087D907
	public TsGameBudgetAllocatorTickIntervalDetailConfig CreateAlwaysTickConfig()
	{
		return new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 1U, 1U, 1U, 0f, 0f);
	}

	// Token: 0x0601B95C RID: 112988 RVA: 0x0087F71D File Offset: 0x0087D91D
	public TsGameBudgetAllocatorTickIntervalDetailConfig CreateCameraAlwaysTickConfig()
	{
		return new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 1U, 1U, 1U, 0f, 0f);
	}

	// Token: 0x0601B95D RID: 112989 RVA: 0x0087F733 File Offset: 0x0087D933
	public TsGameBudgetAllocatorTickIntervalDetailConfig CreateIdleExecConfig()
	{
		return new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 30U, 1U, 1U, 0f, 0f);
	}

	// Token: 0x0601B95E RID: 112990 RVA: 0x0087F74A File Offset: 0x0087D94A
	public TsGameBudgetAllocatorTickIntervalDetailConfig CreateHUDTickConfig()
	{
		return new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 5U, 3500U, 500U, 0f, 0f);
	}

	// Token: 0x0601B95F RID: 112991 RVA: 0x0087F768 File Offset: 0x0087D968
	public GameBudgetAllocatorConfig CreateCharacterRenderConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 60U, 5000U, 300U, 0f, 0f),
			Normal_Render = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 60U, 5000U, 300U, 0f, 0f),
			Normal_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 300U, 1000U, 200U, 0f, 0f),
			Normal_Fighting = null,
			Cutscene_Fighting = null,
			Fighting_Rendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 60U, 5000U, 500U, 0f, 0f),
			Fighting_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 300U, 500U, 200U, 0f, 0f),
			Fighting_Fighting = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_Fighting, 60U, 13000U, 700U, 0f, 0f),
			Cutscene_Rendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 5U, 13000U, 1300U, 0f, 0f),
			Cutscene_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 300U, 500U, 200U, 0f, 0f)
		};
	}

	// Token: 0x0601B960 RID: 112992 RVA: 0x0087F8A8 File Offset: 0x0087DAA8
	public GameBudgetAllocatorConfig CreateNpcRenderConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 30U, 1500U, 500U, 0f, 0f),
			Normal_Render = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 30U, 1500U, 500U, 0f, 0f),
			Normal_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 300U, 300U, 100U, 0f, 0f),
			Normal_Fighting = null,
			Cutscene_Fighting = null,
			Fighting_Rendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 60U, 1500U, 200U, 0f, 0f),
			Fighting_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 300U, 300U, 100U, 0f, 0f),
			Fighting_Fighting = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_Fighting, 60U, 1500U, 200U, 0f, 0f),
			Cutscene_Rendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 5U, 10000U, 1000U, 0f, 0f),
			Cutscene_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 300U, 300U, 100U, 0f, 0f)
		};
	}

	// Token: 0x0601B961 RID: 112993 RVA: 0x0087F9DF File Offset: 0x0087DBDF
	public TsGameBudgetAllocatorTickIntervalDetailConfig CreateBattleHeadViewConfig()
	{
		return new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 5U, 3000U, 500U, 0f, 0f);
	}

	// Token: 0x0601B962 RID: 112994 RVA: 0x0087FA00 File Offset: 0x0087DC00
	public GameBudgetAllocatorConfig CreateCollisionPlantConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 3U, 300U, 100U, 0f, 0f),
			Normal_Render = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 3U, 300U, 100U, 0f, 0f),
			Normal_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 3U, 1U, 1U, 0f, 0f),
			Normal_Fighting = null,
			Fighting_Rendered = null,
			Fighting_NotRendered = null,
			Fighting_Fighting = null,
			Cutscene_Rendered = null,
			Cutscene_NotRendered = null,
			Cutscene_Fighting = null
		};
	}

	// Token: 0x0601B963 RID: 112995 RVA: 0x0087FA9B File Offset: 0x0087DC9B
	public TsGameBudgetAllocatorTickIntervalDetailConfig CreateBlueprintSingletonConfig()
	{
		return new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 1U, 1U, 1U, 0f, 0f);
	}

	// Token: 0x0601B964 RID: 112996 RVA: 0x0087FAB4 File Offset: 0x0087DCB4
	public GameBudgetAllocatorConfig CreateSceneBlueprintActorConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 20U, 2000U, 400U, 0f, 0f),
			Normal_Render = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 20U, 2000U, 400U, 0f, 0f),
			Normal_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 60U, 1000U, 200U, 0f, 0f),
			Normal_Fighting = null,
			Fighting_Rendered = null,
			Fighting_NotRendered = null,
			Fighting_Fighting = null,
			Cutscene_Rendered = null,
			Cutscene_NotRendered = null,
			Cutscene_Fighting = null
		};
	}

	// Token: 0x0601B965 RID: 112997 RVA: 0x0087FB60 File Offset: 0x0087DD60
	public GameBudgetAllocatorConfig CreateFarBlueprintActorConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 20U, 8000U, 1000U, 0.2f, 0.005f),
			Normal_Render = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 20U, 8000U, 1000U, 0.2f, 0.005f),
			Normal_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 120U, 2000U, 200U, 0f, 0f),
			Normal_Fighting = null,
			Fighting_Rendered = null,
			Fighting_NotRendered = null,
			Fighting_Fighting = null,
			Cutscene_Rendered = null,
			Cutscene_NotRendered = null,
			Cutscene_Fighting = null
		};
	}

	// Token: 0x0601B966 RID: 112998 RVA: 0x0087FC0C File Offset: 0x0087DE0C
	public GameBudgetAllocatorConfig CreateSuperFarBlueprintActorConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 20U, 50000U, 30000U, 0.2f, 0.008f),
			Normal_Render = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 20U, 50000U, 30000U, 0.2f, 0.008f),
			Normal_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 60U, 5000U, 5000U, 0f, 0f),
			Normal_Fighting = null,
			Fighting_Rendered = null,
			Fighting_NotRendered = null,
			Fighting_Fighting = null,
			Cutscene_Rendered = null,
			Cutscene_NotRendered = null,
			Cutscene_Fighting = null
		};
	}

	// Token: 0x0601B967 RID: 112999 RVA: 0x0087FCB8 File Offset: 0x0087DEB8
	public GameBudgetAllocatorConfig CreateDynamicPhysicsInteractionActorConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 5U, 1000U, 300U, 0f, 0f),
			Normal_Render = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 5U, 1000U, 300U, 0f, 0f),
			Normal_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 60U, 300U, 50U, 0f, 0f),
			Normal_Fighting = null,
			Fighting_Rendered = null,
			Fighting_NotRendered = null,
			Fighting_Fighting = null,
			Cutscene_Rendered = null,
			Cutscene_NotRendered = null
		};
	}

	// Token: 0x0601B968 RID: 113000 RVA: 0x0087FD58 File Offset: 0x0087DF58
	public GameBudgetAllocatorConfig CreateStaticPhysicsInteractionActorConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 10U, 500U, 100U, 0f, 0f),
			Normal_Render = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 10U, 500U, 100U, 0f, 0f),
			Normal_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 60U, 300U, 25U, 0f, 0f),
			Normal_Fighting = null,
			Fighting_Rendered = null,
			Fighting_NotRendered = null,
			Fighting_Fighting = null,
			Cutscene_Rendered = null,
			Cutscene_NotRendered = null,
			Cutscene_Fighting = null
		};
	}

	// Token: 0x0601B969 RID: 113001 RVA: 0x0087FDFC File Offset: 0x0087DFFC
	public GameBudgetAllocatorConfig CreateHighPriorityPhysicsInteractionActorConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 10U, 2000U, 300U, 0f, 0f),
			Normal_Render = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 10U, 2000U, 300U, 0f, 0f),
			Normal_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 60U, 300U, 25U, 0f, 0f),
			Normal_Fighting = null,
			Fighting_Rendered = null,
			Fighting_NotRendered = null,
			Fighting_Fighting = null,
			Cutscene_Rendered = null,
			Cutscene_NotRendered = null,
			Cutscene_Fighting = null
		};
	}

	// Token: 0x0601B96A RID: 113002 RVA: 0x0087FEA8 File Offset: 0x0087E0A8
	public GameBudgetAllocatorConfig CreateSpecialBlueprintActorConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 1U, 1U, 1U, 0f, 0f),
			Normal_Render = null,
			Normal_NotRendered = null,
			Normal_Fighting = null,
			Fighting_Rendered = null,
			Fighting_NotRendered = null,
			Fighting_Fighting = null,
			Cutscene_Rendered = null,
			Cutscene_NotRendered = null,
			Cutscene_Fighting = null
		};
	}

	// Token: 0x0601B96B RID: 113003 RVA: 0x0087FF14 File Offset: 0x0087E114
	public GameBudgetAllocatorConfig CreateScreenDecalActorConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 1U, 1U, 1U, 0f, 0f),
			Normal_Render = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 1U, 1U, 1U, 0f, 0f),
			Normal_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 10U, 1U, 1U, 0f, 0f),
			Normal_Fighting = null,
			Fighting_Rendered = null,
			Fighting_NotRendered = null,
			Fighting_Fighting = null,
			Cutscene_Rendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 1U, 1U, 1U, 0f, 0f),
			Cutscene_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 10U, 1U, 1U, 0f, 0f),
			Cutscene_Fighting = null
		};
	}
}
