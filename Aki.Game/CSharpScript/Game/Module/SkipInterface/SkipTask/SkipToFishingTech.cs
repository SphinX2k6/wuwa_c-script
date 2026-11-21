using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B75 RID: 15221
	public class SkipToFishingTech : SkipTask
	{
		// Token: 0x060270B6 RID: 159926 RVA: 0x00AEE6C4 File Offset: 0x00AEC8C4
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			string s = (string)data[0];
			string s2 = (string)data[1];
			int type = int.Parse(s);
			int nodeId = int.Parse(s2);
			FishingTechOpenParam param = new FishingTechOpenParam
			{
				Type = type,
				NodeId = nodeId
			};
			UiManager.Instance.OpenView(EUiViewName.FishingTechRootView, param, null);
			base.Finish();
		}
	}
}
