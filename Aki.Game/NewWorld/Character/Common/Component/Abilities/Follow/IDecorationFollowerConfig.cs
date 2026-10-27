using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace Aki.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x020044C3 RID: 17603
	[NullableContext(1)]
	public interface IDecorationFollowerConfig
	{
		// Token: 0x1700739F RID: 29599
		// (get) Token: 0x0602D620 RID: 185888
		bool IsLoaded { get; }

		// Token: 0x170073A0 RID: 29600
		// (get) Token: 0x0602D621 RID: 185889
		bool NeedExternalPerformanceControl { get; }

		// Token: 0x0602D622 RID: 185890
		void ApplyRawConfig(IFollowDecorationChairConfig config);

		// Token: 0x0602D623 RID: 185891
		void Load(Action onLoaded);
	}
}
