using System;
using Aki.Config;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02004E9F RID: 20127
	public class MonsterDetectionRecord : DetectionRecord<MonsterDetection>
	{
		// Token: 0x06032A8C RID: 207500 RVA: 0x00E36766 File Offset: 0x00E34966
		public MonsterDetectionRecord(MonsterDetection conf, bool isLock, long? refreshTime) : base(conf, isLock, refreshTime)
		{
		}
	}
}
