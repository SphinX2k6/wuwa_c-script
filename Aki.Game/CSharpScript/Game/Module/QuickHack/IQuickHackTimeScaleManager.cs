using System;
using Aki.Config;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F4E RID: 16206
	public interface IQuickHackTimeScaleManager
	{
		// Token: 0x06029070 RID: 168048
		void BeginTimeScale(QuickHackDevice config, int ownerEntityId);

		// Token: 0x06029071 RID: 168049
		void EndTimeScale();
	}
}
