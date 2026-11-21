using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace Aki.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02002F95 RID: 12181
	[NullableContext(1)]
	public interface IDecorationFollowerConfig
	{
		// Token: 0x17002DC0 RID: 11712
		// (get) Token: 0x0601CE49 RID: 118345
		bool IsLoaded { get; }

		// Token: 0x17002DC1 RID: 11713
		// (get) Token: 0x0601CE4A RID: 118346
		bool NeedExternalPerformanceControl { get; }

		// Token: 0x0601CE4B RID: 118347
		void ApplyRawConfig(IFollowDecorationChairConfig config);

		// Token: 0x0601CE4C RID: 118348
		void Load(Action onLoaded);
	}
}
