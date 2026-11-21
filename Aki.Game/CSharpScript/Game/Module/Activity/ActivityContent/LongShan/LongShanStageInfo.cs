using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LongShan
{
	// Token: 0x020054C9 RID: 21705
	[NullableContext(1)]
	[Nullable(0)]
	public class LongShanStageInfo
	{
		// Token: 0x06035C9B RID: 220315 RVA: 0x00F06A70 File Offset: 0x00F04C70
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

		// Token: 0x0401C764 RID: 116580
		[Nullable(2)]
		public LongShanStageInfo ProtoStageInfo;

		// Token: 0x0401C765 RID: 116581
		public Dictionary<int, LongShanTaskInfo> TaskInfoMap = new Dictionary<int, LongShanTaskInfo>();
	}
}
