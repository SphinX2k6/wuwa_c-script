using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BDB RID: 19419
	public class SkipToTaskViewDirect : SkipToMoonChasingBase
	{
		// Token: 0x06032347 RID: 205639 RVA: 0x00BAA9DC File Offset: 0x00BA8BDC
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			string s = (string)data[0];
			if (!base.CheckMainViewOpen())
			{
				base.SkipToMap(int.Parse(s));
				return;
			}
			MoonChasingController.Instance.OpenTaskView(EMoonChasingTaskType.MainLine, 0, false);
		}
	}
}
