using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Roguelike;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B60 RID: 15200
	public class SkipTaskRogueActivity : SkipTask
	{
		// Token: 0x0602708B RID: 159883 RVA: 0x00AED88A File Offset: 0x00AEBA8A
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
