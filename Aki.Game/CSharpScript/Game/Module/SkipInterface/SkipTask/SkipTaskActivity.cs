using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B4E RID: 15182
	public class SkipTaskActivity : SkipTask
	{
		// Token: 0x06027056 RID: 159830 RVA: 0x00AEC6CC File Offset: 0x00AEA8CC
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			string text = data[0] as string;
			int num = (text != null) ? int.Parse(text) : ((int)data[0]);
			if (num > 0)
			{
				ActivityBaseData activityById = ActivityModel.Instance.GetActivityById(num);
				if (activityById == null || !activityById.CheckIfInShowTime())
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("ActivityAdvice", Array.Empty<object>());
				}
			}
			ActivityController.Instance.OpenActivityById(num, EActivityViewOpenType.Other, null, null);
			base.Finish();
		}
	}
}
