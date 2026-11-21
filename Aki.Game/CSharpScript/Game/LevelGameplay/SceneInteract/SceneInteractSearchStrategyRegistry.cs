using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SceneInteractExplore;
using CSharpScript.Game.LevelGamePlay.SceneInteractExplorePlaced;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02005BDC RID: 23516
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneInteractSearchStrategyRegistry : Singleton
	{
		// Token: 0x06039C7C RID: 236668 RVA: 0x0103A7B4 File Offset: 0x010389B4
		public SceneInteractSearchStrategy GetStrategyByType(ESceneInteractSearchStrategyType strategyType)
		{
			return this.Strategies[strategyType];
		}

		// Token: 0x06039C7D RID: 236669 RVA: 0x0103A7C4 File Offset: 0x010389C4
		public void Clear()
		{
			foreach (SceneInteractSearchStrategy sceneInteractSearchStrategy in this.Strategies.Values)
			{
				sceneInteractSearchStrategy.Dispose();
			}
			this.Strategies.Clear();
		}

		// Token: 0x17006E1F RID: 28191
		// (get) Token: 0x06039C7E RID: 236670 RVA: 0x0103A824 File Offset: 0x01038A24
		public static SceneInteractSearchStrategyRegistry Instance
		{
			get
			{
				if (SceneInteractSearchStrategyRegistry._instance == null)
				{
					SceneInteractSearchStrategyRegistry._instance = new SceneInteractSearchStrategyRegistry();
					SceneInteractSearchStrategyRegistry._instance.OnInit();
				}
				return SceneInteractSearchStrategyRegistry._instance;
			}
		}

		// Token: 0x06039C7F RID: 236671 RVA: 0x0103A847 File Offset: 0x01038A47
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039C80 RID: 236672 RVA: 0x0103A849 File Offset: 0x01038A49
		public static void ResetStaticDefaultValue()
		{
			SceneInteractSearchStrategyRegistry instance = SceneInteractSearchStrategyRegistry._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			SceneInteractSearchStrategyRegistry._instance = null;
		}

		// Token: 0x06039C81 RID: 236673 RVA: 0x0103A862 File Offset: 0x01038A62
		static SceneInteractSearchStrategyRegistry()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneInteractSearchStrategyRegistry.CreateStaticDefaultValue), new Action(SceneInteractSearchStrategyRegistry.ResetStaticDefaultValue));
		}

		// Token: 0x06039C82 RID: 236674 RVA: 0x0103A881 File Offset: 0x01038A81
		public SceneInteractSearchStrategyRegistry()
		{
			Dictionary<ESceneInteractSearchStrategyType, SceneInteractSearchStrategy> dictionary = new Dictionary<ESceneInteractSearchStrategyType, SceneInteractSearchStrategy>();
			dictionary[ESceneInteractSearchStrategyType.PlacedExploreInteractPoint] = new PlacedExploreInteractPointSearchStrategy();
			dictionary[ESceneInteractSearchStrategyType.ExploreInteractPoint] = new ExploreInteractSearchStrategy();
			this.Strategies = dictionary;
			base..ctor();
		}

		// Token: 0x0401E861 RID: 125025
		private readonly Dictionary<ESceneInteractSearchStrategyType, SceneInteractSearchStrategy> Strategies;

		// Token: 0x0401E862 RID: 125026
		[Nullable(2)]
		private static SceneInteractSearchStrategyRegistry _instance;
	}
}
