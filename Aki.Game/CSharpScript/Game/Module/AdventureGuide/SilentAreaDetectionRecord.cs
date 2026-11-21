using System;
using Aki.Config;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02004EA1 RID: 20129
	public class SilentAreaDetectionRecord : DetectionRecord<SilentAreaDetection>
	{
		// Token: 0x06032A8E RID: 207502 RVA: 0x00E3677E File Offset: 0x00E3497E
		public SilentAreaDetectionRecord(SilentAreaDetection conf, bool isLock, long? refreshTime) : base(conf, isLock, refreshTime)
		{
		}
	}
}
