using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B85 RID: 15237
	public class SkipToTaskViewDirect : SkipToMoonChasingBase
	{
		// Token: 0x060270D8 RID: 159960 RVA: 0x00AEEC94 File Offset: 0x00AECE94
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
