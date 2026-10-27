using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BC6 RID: 19398
	public class SkipToDetectionMaterial : SkipTask
	{
		// Token: 0x0603231B RID: 205595 RVA: 0x00BAA02C File Offset: 0x00BA822C
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
