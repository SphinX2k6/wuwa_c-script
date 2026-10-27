using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SceneInteract.Point.Context;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02006A75 RID: 27253
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class SceneInteractPointFactory<[Nullable(0)] TContext> : SceneInteractPointFactory where TContext : SceneInteractPointContext
	{
		// Token: 0x06043BEA RID: 277482 RVA: 0x01094B13 File Offset: 0x01092D13
		[return: Nullable(2)]
		public override ISceneInteractPoint Create(SceneInteractPointContext context)
		{
			return this.CreateTyped((TContext)((object)context));
		}

		// Token: 0x06043BEB RID: 277483
		[return: Nullable(2)]
		protected abstract ISceneInteractPoint CreateTyped(TContext context);
	}
}
