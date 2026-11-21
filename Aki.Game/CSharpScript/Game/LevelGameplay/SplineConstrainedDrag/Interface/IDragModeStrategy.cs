using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Define;

namespace CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface
{
	// Token: 0x02005B9A RID: 23450
	[NullableContext(1)]
	public interface IDragModeStrategy
	{
		// Token: 0x17006DF5 RID: 28149
		// (get) Token: 0x06039ADA RID: 236250
		EKuroSplineConstrainedDragMode Mode { get; }

		// Token: 0x06039ADB RID: 236251
		void OnActivate(IKuroSplineConstrainedDrag host);

		// Token: 0x06039ADC RID: 236252
		void OnDeactivate();

		// Token: 0x06039ADD RID: 236253
		void BeginDrag();

		// Token: 0x06039ADE RID: 236254
		void SetCurrentScreenPosition(Vector screenPosition);

		// Token: 0x06039ADF RID: 236255
		void ApplyScreenDelta(Vector screenDelta);

		// Token: 0x06039AE0 RID: 236256
		void EndDrag();
	}
}
