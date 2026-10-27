using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BCB RID: 19403
	public class SkipToFishingTech : SkipTask
	{
		// Token: 0x06032325 RID: 205605 RVA: 0x00BAA40C File Offset: 0x00BA860C
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
