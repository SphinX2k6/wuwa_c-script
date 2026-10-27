using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Roguelike;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BB6 RID: 19382
	public class SkipTaskRogueActivity : SkipTask
	{
		// Token: 0x060322FA RID: 205562 RVA: 0x00BA95DE File Offset: 0x00BA77DE
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			RoguelikeController.Instance.OpenRoguelikeActivityView();
			base.Finish();
		}
	}
}
