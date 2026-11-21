using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CA7 RID: 19623
	[NullableContext(1)]
	[Nullable(0)]
	public class SpringManorTrackingRule : TrackingDisplayRuleBase
	{
		// Token: 0x170061CD RID: 25037
		// (get) Token: 0x06031026 RID: 200742 RVA: 0x00DAD196 File Offset: 0x00DAB396
		public override EMissionRuleId Id
		{
			get
			{
				return EMissionRuleId.SpringManor;
			}
		}

		// Token: 0x170061CE RID: 25038
		// (get) Token: 0x06031027 RID: 200743 RVA: 0x00DAD199 File Offset: 0x00DAB399
		public override bool Enabled
		{
			get
			{
				return SpringManorModel.Instance.CheckInInstance();
			}
		}

		// Token: 0x170061CF RID: 25039
		// (get) Token: 0x06031028 RID: 200744 RVA: 0x00DAD1A5 File Offset: 0x00DAB3A5
		public override int Priority
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06031029 RID: 200745 RVA: 0x00DAD1A8 File Offset: 0x00DAB3A8
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

		// Token: 0x0603102A RID: 200746 RVA: 0x00DAD244 File Offset: 0x00DAB444
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
