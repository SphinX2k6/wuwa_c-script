using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B70 RID: 15216
	public class SkipToDetectionMaterial : SkipTask
	{
		// Token: 0x060270AC RID: 159916 RVA: 0x00AEE2E4 File Offset: 0x00AEC4E4
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			string text = (string)data[0];
			int confId = (text != null) ? int.Parse(text) : 0;
			AdventureGuideModel.Instance.SetFromManualDetect(true);
			AdventureGuideController.Instance.RequestForDetection(DetectionType.Material, Array.Empty<int>(), confId);
		}
	}
}
