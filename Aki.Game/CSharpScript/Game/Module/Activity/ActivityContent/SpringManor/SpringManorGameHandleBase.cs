using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x0200602F RID: 24623
	public abstract class SpringManorGameHandleBase
	{
		// Token: 0x0603E509 RID: 255241
		public abstract int GetCurrentProgress();

		// Token: 0x0603E50A RID: 255242
		public abstract int GetTotalProgress();

		// Token: 0x0603E50B RID: 255243
		public abstract void EnterGame();

		// Token: 0x0603E50C RID: 255244
		public abstract ERedDotName? GetRedDotName();
	}
}
