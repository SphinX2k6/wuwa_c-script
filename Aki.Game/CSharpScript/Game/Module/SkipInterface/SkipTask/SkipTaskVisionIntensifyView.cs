using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B64 RID: 15204
	public class SkipTaskVisionIntensifyView : SkipTask
	{
		// Token: 0x06027094 RID: 159892 RVA: 0x00AEDB04 File Offset: 0x00AEBD04
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
