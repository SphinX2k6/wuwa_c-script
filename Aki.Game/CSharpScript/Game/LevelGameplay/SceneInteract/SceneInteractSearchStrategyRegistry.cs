using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SceneInteractExplore;
using CSharpScript.Game.LevelGamePlay.SceneInteractExplorePlaced;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02006A7F RID: 27263
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneInteractSearchStrategyRegistry : Singleton
	{
		// Token: 0x06043C2E RID: 277550 RVA: 0x01095F74 File Offset: 0x01094174
		public SceneInteractSearchStrategy GetStrategyByType(ESceneInteractSearchStrategyType strategyType)
		{
			return this.Strategies[strategyType];
		}

		// Token: 0x06043C2F RID: 277551 RVA: 0x01095F84 File Offset: 0x01094184
		public void Clear()
		{
			foreach (SceneInteractSearchStrategy sceneInteractSearchStrategy in this.Strategies.Values)
			{
				sceneInteractSearchStrategy.Dispose();
			}
			this.Strategies.Clear();
		}

		// Token: 0x1700993A RID: 39226
		// (get) Token: 0x06043C30 RID: 277552 RVA: 0x01095FE4 File Offset: 0x010941E4
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

		// Token: 0x06043C31 RID: 277553 RVA: 0x01096007 File Offset: 0x01094207
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06043C32 RID: 277554 RVA: 0x01096009 File Offset: 0x01094209
		public static void ResetStaticDefaultValue()
		{
			SceneInteractSearchStrategyRegistry instance = SceneInteractSearchStrategyRegistry._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			SceneInteractSearchStrategyRegistry._instance = null;
		}

		// Token: 0x06043C33 RID: 277555 RVA: 0x01096022 File Offset: 0x01094222
		static SceneInteractSearchStrategyRegistry()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneInteractSearchStrategyRegistry.CreateStaticDefaultValue), new Action(SceneInteractSearchStrategyRegistry.ResetStaticDefaultValue));
		}

		// Token: 0x06043C34 RID: 277556 RVA: 0x01096041 File Offset: 0x01094241
		public SceneInteractSearchStrategyRegistry()
		{
			Dictionary<ESceneInteractSearchStrategyType, SceneInteractSearchStrategy> dictionary = new Dictionary<ESceneInteractSearchStrategyType, SceneInteractSearchStrategy>();
			dictionary[ESceneInteractSearchStrategyType.PlacedExploreInteractPoint] = new PlacedExploreInteractPointSearchStrategy();
			dictionary[ESceneInteractSearchStrategyType.ExploreInteractPoint] = new ExploreInteractSearchStrategy();
			this.Strategies = dictionary;
			base..ctor();
		}

		// Token: 0x0402366F RID: 145007
		private readonly Dictionary<ESceneInteractSearchStrategyType, SceneInteractSearchStrategy> Strategies;

		// Token: 0x04023670 RID: 145008
		[Nullable(2)]
		private static SceneInteractSearchStrategyRegistry _instance;
	}
}
