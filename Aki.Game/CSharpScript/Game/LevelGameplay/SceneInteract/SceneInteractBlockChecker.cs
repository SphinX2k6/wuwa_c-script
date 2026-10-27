using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02006A7A RID: 27258
	public abstract class SceneInteractBlockChecker
	{
		// Token: 0x06043C13 RID: 277523
		[NullableContext(1)]
		public abstract bool IsBlocked(Vector destLocation, ISceneInteractSearchParams @params, bool useAscendSegment, Func<bool, UTraceBaseElement, bool> filterTraceResult, bool debugDraw, [Nullable(2)] AActor describeIgnoreActor = null);

		// Token: 0x06043C14 RID: 277524 RVA: 0x01095B85 File Offset: 0x01093D85
		public virtual void Dispose()
		{
		}
	}
}
