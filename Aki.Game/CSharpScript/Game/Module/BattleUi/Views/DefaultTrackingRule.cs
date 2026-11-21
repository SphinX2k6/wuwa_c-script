using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CA5 RID: 19621
	[NullableContext(1)]
	[Nullable(0)]
	public class DefaultTrackingRule : TrackingDisplayRuleBase
	{
		// Token: 0x170061C7 RID: 25031
		// (get) Token: 0x0603101A RID: 200730 RVA: 0x00DACFA8 File Offset: 0x00DAB1A8
		public override EMissionRuleId Id
		{
			get
			{
				return EMissionRuleId.Default;
			}
		}

		// Token: 0x170061C8 RID: 25032
		// (get) Token: 0x0603101B RID: 200731 RVA: 0x00DACFAB File Offset: 0x00DAB1AB
		public override bool Enabled
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170061C9 RID: 25033
		// (get) Token: 0x0603101C RID: 200732 RVA: 0x00DACFAE File Offset: 0x00DAB1AE
		public override int Priority
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x0603101D RID: 200733 RVA: 0x00DACFB4 File Offset: 0x00DAB1B4
		public override EMissionItemView? CustomTypeCheck(IMissionItemViewShowData showData, ETreeTextExpressReason? reason = null)
		{
			EMissionItemView? result = null;
			EMissionItemViewDataSource dataSource = showData.DataSource;
			if (dataSource != EMissionItemViewDataSource.BehaviorTree)
			{
				if (dataSource == EMissionItemViewDataSource.FishingEntrust)
				{
					result = new EMissionItemView?(EMissionItemView.SecondRow);
				}
			}
			else
			{
				long id = showData.Id;
				BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(id), false);
				if (behaviorTree == null || behaviorTree.BtType == BtType.Invalid)
				{
					return null;
				}
				if (behaviorTree.BtType == BtType.Quest || behaviorTree.BtType == BtType.Recall || behaviorTree.GetBlackBoard().IsTrackBoundToParent)
				{
					result = new EMissionItemView?((reason.GetValueOrDefault() == ETreeTextExpressReason.InRange) ? EMissionItemView.SecondRow : EMissionItemView.FirstRow);
				}
				else
				{
					result = new EMissionItemView?(EMissionItemView.SecondRow);
				}
			}
			return result;
		}

		// Token: 0x0603101E RID: 200734 RVA: 0x00DAD051 File Offset: 0x00DAB251
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
