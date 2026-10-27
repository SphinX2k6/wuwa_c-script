using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003502 RID: 13570
[NullableContext(1)]
[Nullable(0)]
public class GameBudgetAllocatorConfigMobileCreator : IGamebudgetAllocatorConfigPlatformCreator
{
	// Token: 0x0601DC15 RID: 121877 RVA: 0x00855690 File Offset: 0x00853890
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

	// Token: 0x0601DC16 RID: 121878 RVA: 0x00855764 File Offset: 0x00853964
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

	// Token: 0x0601DC17 RID: 121879 RVA: 0x008558C8 File Offset: 0x00853AC8
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

	// Token: 0x0601DC18 RID: 121880 RVA: 0x00855A0C File Offset: 0x00853C0C
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

	// Token: 0x0601DC19 RID: 121881 RVA: 0x00855AB8 File Offset: 0x00853CB8
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

	// Token: 0x0601DC1A RID: 121882 RVA: 0x00855B42 File Offset: 0x00853D42
	public TsGameBudgetAllocatorTickIntervalDetailConfig CreateFightEffectConfig()
	{
		return new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 1U, 1U, 1U, 0f, 0f);
	}

	// Token: 0x0601DC1B RID: 121883 RVA: 0x00855B58 File Offset: 0x00853D58
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

	// Token: 0x0601DC1C RID: 121884 RVA: 0x00855C74 File Offset: 0x00853E74
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

	// Token: 0x0601DC1D RID: 121885 RVA: 0x00855DAC File Offset: 0x00853FAC
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

	// Token: 0x0601DC1E RID: 121886 RVA: 0x00855E18 File Offset: 0x00854018
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

	// Token: 0x0601DC1F RID: 121887 RVA: 0x00855E84 File Offset: 0x00854084
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

	// Token: 0x0601DC20 RID: 121888 RVA: 0x00855F2B File Offset: 0x0085412B
	public TsGameBudgetAllocatorTickIntervalDetailConfig CreatePlayerAlwaysTickConfig()
	{
		return new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 1U, 1U, 1U, 0f, 0f);
	}

	// Token: 0x0601DC21 RID: 121889 RVA: 0x00855F44 File Offset: 0x00854144
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

	// Token: 0x0601DC22 RID: 121890 RVA: 0x00855FB0 File Offset: 0x008541B0
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

	// Token: 0x0601DC23 RID: 121891 RVA: 0x00856037 File Offset: 0x00854237
	public TsGameBudgetAllocatorTickIntervalDetailConfig CreateAlwaysTickConfig()
	{
		return new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 1U, 1U, 1U, 0f, 0f);
	}

	// Token: 0x0601DC24 RID: 121892 RVA: 0x0085604D File Offset: 0x0085424D
	public TsGameBudgetAllocatorTickIntervalDetailConfig CreateCameraAlwaysTickConfig()
	{
		return new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 1U, 1U, 1U, 0f, 0f);
	}

	// Token: 0x0601DC25 RID: 121893 RVA: 0x00856063 File Offset: 0x00854263
	public TsGameBudgetAllocatorTickIntervalDetailConfig CreateIdleExecConfig()
	{
		return new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 30U, 1U, 1U, 0f, 0f);
	}

	// Token: 0x0601DC26 RID: 121894 RVA: 0x0085607A File Offset: 0x0085427A
	public TsGameBudgetAllocatorTickIntervalDetailConfig CreateHUDTickConfig()
	{
		return new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 5U, 2000U, 300U, 0f, 0f);
	}

	// Token: 0x0601DC27 RID: 121895 RVA: 0x00856098 File Offset: 0x00854298
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

	// Token: 0x0601DC28 RID: 121896 RVA: 0x008561C8 File Offset: 0x008543C8
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

	// Token: 0x0601DC29 RID: 121897 RVA: 0x008562F3 File Offset: 0x008544F3
	public TsGameBudgetAllocatorTickIntervalDetailConfig CreateBattleHeadViewConfig()
	{
		return new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 5U, 2000U, 300U, 0f, 0f);
	}

	// Token: 0x0601DC2A RID: 121898 RVA: 0x00856314 File Offset: 0x00854514
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

	// Token: 0x0601DC2B RID: 121899 RVA: 0x008563AF File Offset: 0x008545AF
	public TsGameBudgetAllocatorTickIntervalDetailConfig CreateBlueprintSingletonConfig()
	{
		return new TsGameBudgetAllocatorTickIntervalDetailConfig(EGameBudgetAllocatorGlobalMode.GBA_GlobalMode_Normal, EGameBudgetAllocatorActorMode.GBA_ActorMode_Rendered, 1U, 1U, 1U, 0f, 0f);
	}

	// Token: 0x0601DC2C RID: 121900 RVA: 0x008563C8 File Offset: 0x008545C8
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

	// Token: 0x0601DC2D RID: 121901 RVA: 0x00856474 File Offset: 0x00854674
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

	// Token: 0x0601DC2E RID: 121902 RVA: 0x00856520 File Offset: 0x00854720
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

	// Token: 0x0601DC2F RID: 121903 RVA: 0x008565CC File Offset: 0x008547CC
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

	// Token: 0x0601DC30 RID: 121904 RVA: 0x00856674 File Offset: 0x00854874
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

	// Token: 0x0601DC31 RID: 121905 RVA: 0x00856718 File Offset: 0x00854918
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

	// Token: 0x0601DC32 RID: 121906 RVA: 0x008567C4 File Offset: 0x008549C4
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
}
