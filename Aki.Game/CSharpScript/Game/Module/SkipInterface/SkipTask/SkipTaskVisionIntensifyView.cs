using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BBA RID: 19386
	public class SkipTaskVisionIntensifyView : SkipTask
	{
		// Token: 0x06032303 RID: 205571 RVA: 0x00BA9858 File Offset: 0x00BA7A58
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			int uniqueId = (int)data[0];
			VisionIntensifyViewPassData visionIntensifyViewPassData = new VisionIntensifyViewPassData();
			visionIntensifyViewPassData.UniqueId = uniqueId;
			UiManager.Instance.OpenView(EUiViewName.VisionIntensifyView, visionIntensifyViewPassData, null);
			base.Finish();
		}
	}
}
