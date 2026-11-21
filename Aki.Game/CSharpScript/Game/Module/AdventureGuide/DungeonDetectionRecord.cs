using System;
using Aki.Config;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02004EA0 RID: 20128
	public class DungeonDetectionRecord : DetectionRecord<DungeonDetection>
	{
		// Token: 0x06032A8D RID: 207501 RVA: 0x00E36772 File Offset: 0x00E34972
		public DungeonDetectionRecord(DungeonDetection conf, bool isLock, long? refreshTime) : base(conf, isLock, refreshTime)
		{
		}
	}
}
