using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CAD RID: 23725
	internal static class LeaveAreaItemInfoIds
	{
		// Token: 0x0603A28C RID: 238220 RVA: 0x010668C4 File Offset: 0x01064AC4
		[NullableContext(2)]
		public static ILeaveAreaItem Get(int itemId)
		{
			ILeaveAreaItem result;
			LeaveAreaItemInfoIds.leaveAreaItemInfoIds.TryGetValue(itemId, out result);
			return result;
		}

		// Token: 0x0603A28D RID: 238221 RVA: 0x010668E0 File Offset: 0x01064AE0
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

		// Token: 0x0401EBA7 RID: 125863
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<int, ILeaveAreaItem> leaveAreaItemInfoIds;
	}
}
