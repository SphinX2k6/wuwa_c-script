using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FF7 RID: 4087
	public static class IBtNodeExtensions
	{
		// Token: 0x06005983 RID: 22915 RVA: 0x000DA84C File Offset: 0x000D8A4C
		public static IReadOnlyList<ActionInfo> GetFinishActions(this IBtNode p)
		{
			IQuestSucceedBtNode questSucceedBtNode = p as IQuestSucceedBtNode;
			List<ActionInfo> finishActions;
			if (questSucceedBtNode == null)
			{
				IQuestFailedBtNode questFailedBtNode = p as IQuestFailedBtNode;
				if (questFailedBtNode == null)
				{
					IChildQuestBtNode childQuestBtNode = p as IChildQuestBtNode;
					if (childQuestBtNode == null)
					{
						throw new NotImplementedException("获取类型:" + p.GetType().Name + "的FinishActions的字段失败");
					}
					finishActions = childQuestBtNode.FinishActions;
				}
				else
				{
					finishActions = questFailedBtNode.FinishActions;
				}
			}
			else
			{
				finishActions = questSucceedBtNode.FinishActions;
			}
			return finishActions;
		}
	}
}
