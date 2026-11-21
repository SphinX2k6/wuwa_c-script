using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SceneInteract.Point.Context;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02005BD2 RID: 23506
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class SceneInteractPointFactory<[Nullable(0)] TContext> : SceneInteractPointFactory where TContext : SceneInteractPointContext
	{
		// Token: 0x06039C38 RID: 236600 RVA: 0x0103933F File Offset: 0x0103753F
		[return: Nullable(2)]
		public override ISceneInteractPoint Create(SceneInteractPointContext context)
		{
			return this.CreateTyped((TContext)((object)context));
		}

		// Token: 0x06039C39 RID: 236601
		[return: Nullable(2)]
		protected abstract ISceneInteractPoint CreateTyped(TContext context);
	}
}
