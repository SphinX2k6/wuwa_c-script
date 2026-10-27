using System;
using Aki.Config;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02005EBA RID: 24250
	public class MonsterDetectionRecord : DetectionRecord<MonsterDetection>
	{
		// Token: 0x0603DAFC RID: 252668 RVA: 0x00EE521A File Offset: 0x00EE341A
		public MonsterDetectionRecord(MonsterDetection conf, bool isLock, long? refreshTime) : base(conf, isLock, refreshTime)
		{
		}
	}
}
