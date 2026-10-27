using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BA4 RID: 19364
	public class SkipTaskActivity : SkipTask
	{
		// Token: 0x060322C5 RID: 205509 RVA: 0x00BA8484 File Offset: 0x00BA6684
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
