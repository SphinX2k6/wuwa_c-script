using System;
using System.Runtime.CompilerServices;

namespace Aki.Game.NewWorld.Character.Custom.Components.Range
{
	// Token: 0x02002F79 RID: 12153
	public interface IExternalRangeActorShape : IRangeActorShape
	{
		// Token: 0x0601CC62 RID: 117858
		[NullableContext(1)]
		void RegisterExternalRangeActorLifecycleCallbacks(Action onLost, Action onRestored);

		// Token: 0x0601CC63 RID: 117859
		void UnregisterExternalRangeActorLifecycleCallbacks();
	}
}
