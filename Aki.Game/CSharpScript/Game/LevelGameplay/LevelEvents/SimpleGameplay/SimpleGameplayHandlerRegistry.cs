using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay.LevelEvents.SimpleGameplay.Handlers;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.SimpleGameplay
{
	// Token: 0x02006BBF RID: 27583
	public class SimpleGameplayHandlerRegistry : IStaticVariableResetter
	{
		// Token: 0x06044352 RID: 279378 RVA: 0x010D0297 File Offset: 0x010CE497
		private static void RegisterAllGenerated()
		{
			SimpleGameplayHandlerRegistry.Open.Register(new DragActorOpenHandler());
		}

		// Token: 0x06044353 RID: 279379 RVA: 0x010D02A8 File Offset: 0x010CE4A8
		static SimpleGameplayHandlerRegistry()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SimpleGameplayHandlerRegistry.CreateStaticDefaultValue), new Action(SimpleGameplayHandlerRegistry.ResetStaticDefaultValue));
		}

		// Token: 0x06044354 RID: 279380 RVA: 0x010D02C7 File Offset: 0x010CE4C7
		public static void CreateStaticDefaultValue()
		{
			SimpleGameplayHandlerRegistry.Open = new SimpleGameplayHandlerMap<ISimpleGameplayOpenHandler>();
			SimpleGameplayHandlerRegistry.RegisterAllGenerated();
		}

		// Token: 0x06044355 RID: 279381 RVA: 0x010D02D8 File Offset: 0x010CE4D8
		public static void ResetStaticDefaultValue()
		{
			SimpleGameplayHandlerRegistry.Open = null;
		}

		// Token: 0x06044356 RID: 279382 RVA: 0x010D02E0 File Offset: 0x010CE4E0
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

		// Token: 0x04023985 RID: 145797
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static SimpleGameplayHandlerMap<ISimpleGameplayOpenHandler> Open;
	}
}
