using System;
using Aki.Config;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02005EBC RID: 24252
	public class SilentAreaDetectionRecord : DetectionRecord<SilentAreaDetection>
	{
		// Token: 0x0603DAFE RID: 252670 RVA: 0x00EE5232 File Offset: 0x00EE3432
		public SilentAreaDetectionRecord(SilentAreaDetection conf, bool isLock, long? refreshTime) : base(conf, isLock, refreshTime)
		{
		}
	}
}
