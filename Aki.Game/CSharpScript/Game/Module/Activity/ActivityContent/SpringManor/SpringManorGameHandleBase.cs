using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02004FAD RID: 20397
	public abstract class SpringManorGameHandleBase
	{
		// Token: 0x060331CD RID: 209357
		public abstract int GetCurrentProgress();

		// Token: 0x060331CE RID: 209358
		public abstract int GetTotalProgress();

		// Token: 0x060331CF RID: 209359
		public abstract void EnterGame();

		// Token: 0x060331D0 RID: 209360
		public abstract ERedDotName? GetRedDotName();
	}
}
