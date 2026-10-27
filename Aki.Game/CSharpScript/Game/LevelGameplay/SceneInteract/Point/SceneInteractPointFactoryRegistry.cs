using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SceneInteract.Point.Context;
using CSharpScript.Game.LevelGamePlay.SceneInteractExplore;
using CSharpScript.Game.LevelGamePlay.SceneInteractExplorePlaced;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract.Point
{
	// Token: 0x02006A86 RID: 27270
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneInteractPointFactoryRegistry : Singleton
	{
		// Token: 0x06043C53 RID: 277587 RVA: 0x010967EC File Offset: 0x010949EC
		[return: Nullable(2)]
		public ISceneInteractPoint Create(SceneInteractPointContext context)
		{
			return this.Factories[context.GetInteractPointType()].Create(context);
		}

		// Token: 0x1700993B RID: 39227
		// (get) Token: 0x06043C54 RID: 277588 RVA: 0x01096805 File Offset: 0x01094A05
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

		// Token: 0x06043C55 RID: 277589 RVA: 0x01096828 File Offset: 0x01094A28
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06043C56 RID: 277590 RVA: 0x0109682A File Offset: 0x01094A2A
		public static void ResetStaticDefaultValue()
		{
			SceneInteractPointFactoryRegistry instance = SceneInteractPointFactoryRegistry._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			SceneInteractPointFactoryRegistry._instance = null;
		}

		// Token: 0x06043C57 RID: 277591 RVA: 0x01096843 File Offset: 0x01094A43
		static SceneInteractPointFactoryRegistry()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneInteractPointFactoryRegistry.CreateStaticDefaultValue), new Action(SceneInteractPointFactoryRegistry.ResetStaticDefaultValue));
		}

		// Token: 0x06043C58 RID: 277592 RVA: 0x01096862 File Offset: 0x01094A62
		public SceneInteractPointFactoryRegistry()
		{
			Dictionary<ESceneInteractPointType, SceneInteractPointFactory> dictionary = new Dictionary<ESceneInteractPointType, SceneInteractPointFactory>();
			dictionary[ESceneInteractPointType.ExploreInteractPoint] = new ExploreInteractPointFactory();
			dictionary[ESceneInteractPointType.PlacedExploreInteractPoint] = new PlacedExploreInteractPointFactory();
			this.Factories = dictionary;
			base..ctor();
		}

		// Token: 0x0402367E RID: 145022
		private readonly Dictionary<ESceneInteractPointType, SceneInteractPointFactory> Factories;

		// Token: 0x0402367F RID: 145023
		[Nullable(2)]
		private static SceneInteractPointFactoryRegistry _instance;
	}
}
