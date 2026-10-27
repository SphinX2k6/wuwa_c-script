using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000EE1 RID: 3809
	public static class IBtNodeExtensions
	{
		// Token: 0x06005407 RID: 21511 RVA: 0x000CE6A4 File Offset: 0x000CC8A4
		[NullableContext(1)]
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
