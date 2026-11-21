using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002A77 RID: 10871
[NullableContext(1)]
[Nullable(0)]
public class GameBudgetAllocatorConfigMobileCreator : IGamebudgetAllocatorConfigPlatformCreator
{
	// Token: 0x0601B92D RID: 112941 RVA: 0x0087DAE4 File Offset: 0x0087BCE4
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
			Cutscene_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 1000U, 500U, 10U, 0f, 0f)
		};
	}

	// Token: 0x0601B92E RID: 112942 RVA: 0x0087DBB8 File Offset: 0x0087BDB8
	public GameBudgetAllocatorConfig CreateBossEntityConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 60U, 3000U, 300U, 0f, 0f),
			Normal_Render = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 60U, 3000U, 300U, 0f, 0f),
			Normal_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 120U, 1000U, 200U, 0f, 0f),
			Normal_Fighting = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Fighting, 10U, 3000U, 500U, 0f, 0f),
			Fighting_Rendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 60U, 2000U, 200U, 0f, 0f),
			Fighting_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 120U, 1000U, 100U, 0f, 0f),
			Fighting_Fighting = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_Fighting, 1U, 1U, 1U, 0f, 0f),
			Cutscene_Rendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 5U, 3000U, 500U, 0f, 0f),
			Cutscene_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 10U, 2000U, 200U, 0f, 0f),
			Cutscene_Fighting = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_Fighting, 5U, 5000U, 500U, 0f, 0f)
		};
	}

	// Token: 0x0601B92F RID: 112943 RVA: 0x0087DD1C File Offset: 0x0087BF1C
	public GameBudgetAllocatorConfig CreateCharacterEntityConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 60U, 2000U, 200U, 0f, 0f),
			Normal_Render = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 60U, 2000U, 200U, 0f, 0f),
			Normal_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 120U, 1000U, 100U, 0f, 0f),
			Normal_Fighting = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Fighting, 60U, 3000U, 300U, 0f, 0f),
			Fighting_Rendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 120U, 1000U, 100U, 0f, 0f),
			Fighting_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 120U, 500U, 50U, 0f, 0f),
			Fighting_Fighting = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_Fighting, 20U, 2000U, 300U, 0f, 0f),
			Cutscene_Rendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 20U, 3500U, 500U, 0f, 0f),
			Cutscene_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 120U, 1000U, 100U, 0f, 0f)
		};
	}

	// Token: 0x0601B930 RID: 112944 RVA: 0x0087DE60 File Offset: 0x0087C060
	public GameBudgetAllocatorConfig CreateNormalNpcEntityConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 60U, 500U, 100U, 0f, 0f),
			Normal_Render = null,
			Normal_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 240U, 500U, 50U, 0f, 0f),
			Normal_Fighting = null,
			Fighting_Rendered = null,
			Fighting_NotRendered = null,
			Fighting_Fighting = null,
			Cutscene_Fighting = null,
			Cutscene_Rendered = null,
			Cutscene_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 240U, 500U, 50U, 0f, 0f)
		};
	}

	// Token: 0x0601B931 RID: 112945 RVA: 0x0087DF0C File Offset: 0x0087C10C
	public GameBudgetAllocatorConfig CreateSimpleNpcEntityConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 20U, 500U, 100U, 0f, 0f),
			Normal_Render = null,
			Normal_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 60U, 300U, 20U, 0f, 0f),
			Normal_Fighting = null,
			Fighting_Rendered = null,
			Fighting_NotRendered = null,
			Fighting_Fighting = null,
			Cutscene_Rendered = null,
			Cutscene_NotRendered = null,
			Cutscene_Fighting = null
		};
	}

	// Token: 0x0601B932 RID: 112946 RVA: 0x0087DF96 File Offset: 0x0087C196
	public TsGameBudgetAllocatorTickIntervalDetailConfig CreateFightEffectConfig()
	{
		return new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 1U, 1U, 1U, 0f, 0f);
	}

	// Token: 0x0601B933 RID: 112947 RVA: 0x0087DFAC File Offset: 0x0087C1AC
	public GameBudgetAllocatorConfig CreateEffectConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 180U, 500U, 100U, 0f, 0f),
			Normal_Render = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 60U, 2000U, 300U, 0f, 0f),
			Normal_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 300U, 200U, 50U, 0f, 0f),
			Normal_Fighting = null,
			Fighting_Rendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 300U, 500U, 50U, 0f, 0f),
			Fighting_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 600U, 200U, 20U, 0f, 0f),
			Fighting_Fighting = null,
			Cutscene_Fighting = null,
			Cutscene_Rendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 20U, 4500U, 500U, 0f, 0f),
			Cutscene_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 120U, 1000U, 50U, 0f, 0f)
		};
	}

	// Token: 0x0601B934 RID: 112948 RVA: 0x0087E0C8 File Offset: 0x0087C2C8
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

	// Token: 0x0601B935 RID: 112949 RVA: 0x0087E200 File Offset: 0x0087C400
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

	// Token: 0x0601B936 RID: 112950 RVA: 0x0087E26C File Offset: 0x0087C46C
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

	// Token: 0x0601B937 RID: 112951 RVA: 0x0087E2D8 File Offset: 0x0087C4D8
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

	// Token: 0x0601B938 RID: 112952 RVA: 0x0087E37F File Offset: 0x0087C57F
	public TsGameBudgetAllocatorTickIntervalDetailConfig CreatePlayerAlwaysTickConfig()
	{
		return new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 1U, 1U, 1U, 0f, 0f);
	}

	// Token: 0x0601B939 RID: 112953 RVA: 0x0087E398 File Offset: 0x0087C598
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

	// Token: 0x0601B93A RID: 112954 RVA: 0x0087E404 File Offset: 0x0087C604
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

	// Token: 0x0601B93B RID: 112955 RVA: 0x0087E48B File Offset: 0x0087C68B
	public TsGameBudgetAllocatorTickIntervalDetailConfig CreateAlwaysTickConfig()
	{
		return new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 1U, 1U, 1U, 0f, 0f);
	}

	// Token: 0x0601B93C RID: 112956 RVA: 0x0087E4A1 File Offset: 0x0087C6A1
	public TsGameBudgetAllocatorTickIntervalDetailConfig CreateCameraAlwaysTickConfig()
	{
		return new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 1U, 1U, 1U, 0f, 0f);
	}

	// Token: 0x0601B93D RID: 112957 RVA: 0x0087E4B7 File Offset: 0x0087C6B7
	public TsGameBudgetAllocatorTickIntervalDetailConfig CreateIdleExecConfig()
	{
		return new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 30U, 1U, 1U, 0f, 0f);
	}

	// Token: 0x0601B93E RID: 112958 RVA: 0x0087E4CE File Offset: 0x0087C6CE
	public TsGameBudgetAllocatorTickIntervalDetailConfig CreateHUDTickConfig()
	{
		return new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 5U, 2000U, 300U, 0f, 0f);
	}

	// Token: 0x0601B93F RID: 112959 RVA: 0x0087E4EC File Offset: 0x0087C6EC
	public GameBudgetAllocatorConfig CreateCharacterRenderConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 60U, 3000U, 500U, 0f, 0f),
			Normal_Render = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 60U, 3000U, 500U, 0f, 0f),
			Normal_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 300U, 500U, 100U, 0f, 0f),
			Normal_Fighting = null,
			Fighting_Rendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 60U, 3000U, 300U, 0f, 0f),
			Fighting_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 300U, 300U, 100U, 0f, 0f),
			Fighting_Fighting = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_Fighting, 60U, 10000U, 500U, 0f, 0f),
			Cutscene_Rendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 5U, 10000U, 1000U, 0f, 0f),
			Cutscene_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 300U, 300U, 100U, 0f, 0f)
		};
	}

	// Token: 0x0601B940 RID: 112960 RVA: 0x0087E61C File Offset: 0x0087C81C
	public GameBudgetAllocatorConfig CreateNpcRenderConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 30U, 1000U, 300U, 0f, 0f),
			Normal_Render = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 30U, 1000U, 300U, 0f, 0f),
			Normal_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 300U, 100U, 100U, 0f, 0f),
			Normal_Fighting = null,
			Cutscene_Fighting = null,
			Fighting_Rendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 60U, 1000U, 100U, 0f, 0f),
			Fighting_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 300U, 100U, 100U, 0f, 0f),
			Fighting_Fighting = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Fighting, EGameBudgetAllocatorActorMode.GBA_ActorMode_Fighting, 60U, 1000U, 100U, 0f, 0f),
			Cutscene_Rendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 5U, 10000U, 1000U, 0f, 0f),
			Cutscene_NotRendered = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Cutscene, EGameBudgetAllocatorActorMode.GBA_ActorMode_NotRendered, 300U, 300U, 100U, 0f, 0f)
		};
	}

	// Token: 0x0601B941 RID: 112961 RVA: 0x0087E747 File Offset: 0x0087C947
	public TsGameBudgetAllocatorTickIntervalDetailConfig CreateBattleHeadViewConfig()
	{
		return new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 5U, 2000U, 300U, 0f, 0f);
	}

	// Token: 0x0601B942 RID: 112962 RVA: 0x0087E768 File Offset: 0x0087C968
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

	// Token: 0x0601B943 RID: 112963 RVA: 0x0087E803 File Offset: 0x0087CA03
	public TsGameBudgetAllocatorTickIntervalDetailConfig CreateBlueprintSingletonConfig()
	{
		return new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 1U, 1U, 1U, 0f, 0f);
	}

	// Token: 0x0601B944 RID: 112964 RVA: 0x0087E81C File Offset: 0x0087CA1C
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

	// Token: 0x0601B945 RID: 112965 RVA: 0x0087E8C8 File Offset: 0x0087CAC8
	public GameBudgetAllocatorConfig CreateFarBlueprintActorConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 20U, 8000U, 1000U, 0.3f, 0.01f),
			Normal_Render = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 20U, 8000U, 1000U, 0.3f, 0.01f),
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

	// Token: 0x0601B946 RID: 112966 RVA: 0x0087E974 File Offset: 0x0087CB74
	public GameBudgetAllocatorConfig CreateSuperFarBlueprintActorConfig()
	{
		return new GameBudgetAllocatorConfig
		{
			Default = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 20U, 50000U, 30000U, 0.3f, 0.01f),
			Normal_Render = new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 20U, 50000U, 30000U, 0.3f, 0.01f),
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

	// Token: 0x0601B947 RID: 112967 RVA: 0x0087EA20 File Offset: 0x0087CC20
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
			Cutscene_NotRendered = null,
			Cutscene_Fighting = null
		};
	}

	// Token: 0x0601B948 RID: 112968 RVA: 0x0087EAC8 File Offset: 0x0087CCC8
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

	// Token: 0x0601B949 RID: 112969 RVA: 0x0087EB6C File Offset: 0x0087CD6C
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

	// Token: 0x0601B94A RID: 112970 RVA: 0x0087EC18 File Offset: 0x0087CE18
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

	// Token: 0x0601B94B RID: 112971 RVA: 0x0087EC84 File Offset: 0x0087CE84
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
