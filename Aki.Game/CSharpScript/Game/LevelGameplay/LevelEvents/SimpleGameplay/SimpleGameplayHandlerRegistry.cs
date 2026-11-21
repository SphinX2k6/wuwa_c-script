using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay.LevelEvents.SimpleGameplay.Handlers;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.SimpleGameplay
{
	// Token: 0x02005D38 RID: 23864
	public class SimpleGameplayHandlerRegistry : IStaticVariableResetter
	{
		// Token: 0x0603A4AA RID: 238762 RVA: 0x0107A1EB File Offset: 0x010783EB
		private static void RegisterAllGenerated()
		{
			SimpleGameplayHandlerRegistry.Open.Register(new DragActorOpenHandler());
		}

		// Token: 0x0603A4AB RID: 238763 RVA: 0x0107A1FC File Offset: 0x010783FC
		static SimpleGameplayHandlerRegistry()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SimpleGameplayHandlerRegistry.CreateStaticDefaultValue), new Action(SimpleGameplayHandlerRegistry.ResetStaticDefaultValue));
		}

		// Token: 0x0603A4AC RID: 238764 RVA: 0x0107A21B File Offset: 0x0107841B
		public static void CreateStaticDefaultValue()
		{
			SimpleGameplayHandlerRegistry.Open = new SimpleGameplayHandlerMap<ISimpleGameplayOpenHandler>();
			SimpleGameplayHandlerRegistry.RegisterAllGenerated();
		}

		// Token: 0x0603A4AD RID: 238765 RVA: 0x0107A22C File Offset: 0x0107842C
		public static void ResetStaticDefaultValue()
		{
			SimpleGameplayHandlerRegistry.Open = null;
		}

		// Token: 0x0603A4AE RID: 238766 RVA: 0x0107A234 File Offset: 0x01078434
		[NullableContext(1)]
		public static void RegisterOpen<[Nullable(0)] TConfig>(ISimpleGameplayOpenHandler<TConfig> handler) where TConfig : IUiGame
		{
			SimpleGameplayHandlerMap<ISimpleGameplayOpenHandler> open = SimpleGameplayHandlerRegistry.Open;
			if (open == null)
			{
				return;
			}
			open.Register(handler);
		}

		// Token: 0x0401EC27 RID: 125991
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static SimpleGameplayHandlerMap<ISimpleGameplayOpenHandler> Open;
	}
}
