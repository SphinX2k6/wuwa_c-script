using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SceneInteract.Point.Context;
using CSharpScript.Game.LevelGamePlay.SceneInteractExplore;
using CSharpScript.Game.LevelGamePlay.SceneInteractExplorePlaced;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract.Point
{
	// Token: 0x02005BE3 RID: 23523
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneInteractPointFactoryRegistry : Singleton
	{
		// Token: 0x06039CA1 RID: 236705 RVA: 0x0103B02C File Offset: 0x0103922C
		[return: Nullable(2)]
		public ISceneInteractPoint Create(SceneInteractPointContext context)
		{
			return this.Factories[context.GetInteractPointType()].Create(context);
		}

		// Token: 0x17006E20 RID: 28192
		// (get) Token: 0x06039CA2 RID: 236706 RVA: 0x0103B045 File Offset: 0x01039245
		public static SceneInteractPointFactoryRegistry Instance
		{
			get
			{
				if (SceneInteractPointFactoryRegistry._instance == null)
				{
					SceneInteractPointFactoryRegistry._instance = new SceneInteractPointFactoryRegistry();
					SceneInteractPointFactoryRegistry._instance.OnInit();
				}
				return SceneInteractPointFactoryRegistry._instance;
			}
		}

		// Token: 0x06039CA3 RID: 236707 RVA: 0x0103B068 File Offset: 0x01039268
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039CA4 RID: 236708 RVA: 0x0103B06A File Offset: 0x0103926A
		public static void ResetStaticDefaultValue()
		{
			SceneInteractPointFactoryRegistry instance = SceneInteractPointFactoryRegistry._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			SceneInteractPointFactoryRegistry._instance = null;
		}

		// Token: 0x06039CA5 RID: 236709 RVA: 0x0103B083 File Offset: 0x01039283
		static SceneInteractPointFactoryRegistry()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneInteractPointFactoryRegistry.CreateStaticDefaultValue), new Action(SceneInteractPointFactoryRegistry.ResetStaticDefaultValue));
		}

		// Token: 0x06039CA6 RID: 236710 RVA: 0x0103B0A2 File Offset: 0x010392A2
		public SceneInteractPointFactoryRegistry()
		{
			Dictionary<ESceneInteractPointType, SceneInteractPointFactory> dictionary = new Dictionary<ESceneInteractPointType, SceneInteractPointFactory>();
			dictionary[ESceneInteractPointType.ExploreInteractPoint] = new ExploreInteractPointFactory();
			dictionary[ESceneInteractPointType.PlacedExploreInteractPoint] = new PlacedExploreInteractPointFactory();
			this.Factories = dictionary;
			base..ctor();
		}

		// Token: 0x0401E870 RID: 125040
		private readonly Dictionary<ESceneInteractPointType, SceneInteractPointFactory> Factories;

		// Token: 0x0401E871 RID: 125041
		[Nullable(2)]
		private static SceneInteractPointFactoryRegistry _instance;
	}
}
