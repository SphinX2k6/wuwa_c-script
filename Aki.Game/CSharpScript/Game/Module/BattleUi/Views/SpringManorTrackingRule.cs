using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CC5 RID: 23749
	[NullableContext(1)]
	[Nullable(0)]
	public class SpringManorTrackingRule : TrackingDisplayRuleBase
	{
		// Token: 0x17008DFB RID: 36347
		// (get) Token: 0x0603C0D1 RID: 245969 RVA: 0x00E5CA82 File Offset: 0x00E5AC82
		public override EMissionRuleId Id
		{
			get
			{
				return EMissionRuleId.SpringManor;
			}
		}

		// Token: 0x17008DFC RID: 36348
		// (get) Token: 0x0603C0D2 RID: 245970 RVA: 0x00E5CA85 File Offset: 0x00E5AC85
		public override bool Enabled
		{
			get
			{
				return SpringManorModel.Instance.CheckInInstance();
			}
		}

		// Token: 0x17008DFD RID: 36349
		// (get) Token: 0x0603C0D3 RID: 245971 RVA: 0x00E5CA91 File Offset: 0x00E5AC91
		public override int Priority
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x0603C0D4 RID: 245972 RVA: 0x00E5CA94 File Offset: 0x00E5AC94
		public override EMissionItemView? CustomTypeCheck(IMissionItemViewShowData showData, ETreeTextExpressReason? reason = null)
		{
			BehaviorTreeViewShowData behaviorTreeViewShowData = showData as BehaviorTreeViewShowData;
			if (behaviorTreeViewShowData == null)
			{
				return null;
			}
			long id = showData.Id;
			BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(id), false);
			if (behaviorTree == null || behaviorTree.BtType == BtType.Invalid)
			{
				return null;
			}
			if (behaviorTree.BtType != BtType.Quest && !behaviorTree.GetBlackBoard().IsTrackBoundToParent)
			{
				return new EMissionItemView?(EMissionItemView.ThirdRow);
			}
			if (SpringManorModel.Instance.IsSubQuest(behaviorTreeViewShowData.TreeConfigId))
			{
				return new EMissionItemView?(EMissionItemView.SecondRow);
			}
			if (reason.GetValueOrDefault() == ETreeTextExpressReason.InRange)
			{
				return new EMissionItemView?(EMissionItemView.ThirdRow);
			}
			return new EMissionItemView?(EMissionItemView.FirstRow);
		}

		// Token: 0x0603C0D5 RID: 245973 RVA: 0x00E5CB30 File Offset: 0x00E5AD30
		public override void SortShowData(List<IMissionItemViewShowData> showData)
		{
			showData.Sort(delegate(IMissionItemViewShowData a, IMissionItemViewShowData b)
			{
				if (a.DataSource != b.DataSource)
				{
					return a.DataSource - b.DataSource;
				}
				return a.ShowPriority - b.ShowPriority;
			});
		}
	}
}
