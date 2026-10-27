using System;
using Aki.Config;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F85 RID: 20357
	public interface IQuickHackTimeScaleManager
	{
		// Token: 0x06034202 RID: 213506
		void BeginTimeScale(QuickHackDevice config, int ownerEntityId);

		// Token: 0x06034203 RID: 213507
		void EndTimeScale();
	}
}
