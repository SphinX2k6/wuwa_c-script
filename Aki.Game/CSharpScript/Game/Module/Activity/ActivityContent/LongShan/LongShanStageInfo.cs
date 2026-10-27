using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LongShan
{
	// Token: 0x0200654B RID: 25931
	[NullableContext(1)]
	[Nullable(0)]
	public class LongShanStageInfo
	{
		// Token: 0x06040FD6 RID: 266198 RVA: 0x00FBFA80 File Offset: 0x00FBDC80
		public LongShanStageInfo(LongShanStageInfo stateInfo)
		{
			this.ProtoStageInfo = stateInfo;
			RepeatedField<LongShanTaskInfo> tasks = this.ProtoStageInfo.Tasks;
			if (tasks != null)
			{
				foreach (LongShanTaskInfo longShanTaskInfo in tasks)
				{
					this.TaskInfoMap[longShanTaskInfo.Id] = longShanTaskInfo;
				}
			}
		}

		// Token: 0x04021E33 RID: 138803
		[Nullable(2)]
		public LongShanStageInfo ProtoStageInfo;

		// Token: 0x04021E34 RID: 138804
		public Dictionary<int, LongShanTaskInfo> TaskInfoMap = new Dictionary<int, LongShanTaskInfo>();
	}
}
