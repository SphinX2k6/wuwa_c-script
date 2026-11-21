using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02005BD7 RID: 23511
	public abstract class SceneInteractBlockChecker
	{
		// Token: 0x06039C61 RID: 236641
		[NullableContext(1)]
		public abstract bool IsBlocked(Vector destLocation, ISceneInteractSearchParams @params, bool useAscendSegment, Func<bool, UTraceBaseElement, bool> filterTraceResult, bool debugDraw, [Nullable(2)] AActor describeIgnoreActor = null);

		// Token: 0x06039C62 RID: 236642 RVA: 0x0103A3C5 File Offset: 0x010385C5
		public virtual void Dispose()
		{
		}
	}
}
