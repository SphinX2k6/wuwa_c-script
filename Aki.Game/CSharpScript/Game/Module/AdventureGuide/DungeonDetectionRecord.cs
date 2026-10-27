using System;
using Aki.Config;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02005EBB RID: 24251
	public class DungeonDetectionRecord : DetectionRecord<DungeonDetection>
	{
		// Token: 0x0603DAFD RID: 252669 RVA: 0x00EE5226 File Offset: 0x00EE3426
		public DungeonDetectionRecord(DungeonDetection conf, bool isLock, long? refreshTime) : base(conf, isLock, refreshTime)
		{
		}
	}
}
