using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B35 RID: 27445
	internal static class LeaveAreaItemInfoIds
	{
		// Token: 0x0604413A RID: 278842 RVA: 0x010BD038 File Offset: 0x010BB238
		[NullableContext(2)]
		public static ILeaveAreaItem Get(int itemId)
		{
			ILeaveAreaItem result;
			LeaveAreaItemInfoIds.leaveAreaItemInfoIds.TryGetValue(itemId, out result);
			return result;
		}

		// Token: 0x0604413B RID: 278843 RVA: 0x010BD054 File Offset: 0x010BB254
		// Note: this type is marked as 'beforefieldinit'.
		static LeaveAreaItemInfoIds()
		{
			Dictionary<int, ILeaveAreaItem> dictionary = new Dictionary<int, ILeaveAreaItem>();
			dictionary[70140080] = new LeaveAreaItem
			{
				QuestId = 172000001,
				NodeId = 37,
				LeaveAreaId = 3215,
				NodeState = NodeStatus.BeforeActivate
			};
			LeaveAreaItemInfoIds.leaveAreaItemInfoIds = dictionary;
		}

		// Token: 0x04023905 RID: 145669
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<int, ILeaveAreaItem> leaveAreaItemInfoIds;
	}
}
