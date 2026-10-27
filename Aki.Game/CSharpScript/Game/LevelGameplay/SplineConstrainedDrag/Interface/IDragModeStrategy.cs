using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Define;

namespace CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface
{
	// Token: 0x02006A3D RID: 27197
	[NullableContext(1)]
	public interface IDragModeStrategy
	{
		// Token: 0x17009910 RID: 39184
		// (get) Token: 0x06043A8C RID: 277132
		EKuroSplineConstrainedDragMode Mode { get; }

		// Token: 0x06043A8D RID: 277133
		void OnActivate(IKuroSplineConstrainedDrag host);

		// Token: 0x06043A8E RID: 277134
		void OnDeactivate();

		// Token: 0x06043A8F RID: 277135
		void BeginDrag();

		// Token: 0x06043A90 RID: 277136
		void SetCurrentScreenPosition(Vector screenPosition);

		// Token: 0x06043A91 RID: 277137
		void ApplyScreenDelta(Vector screenDelta);

		// Token: 0x06043A92 RID: 277138
		void EndDrag();
	}
}
