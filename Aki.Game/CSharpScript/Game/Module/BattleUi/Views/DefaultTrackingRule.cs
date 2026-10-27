using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CC3 RID: 23747
	[NullableContext(1)]
	[Nullable(0)]
	public class DefaultTrackingRule : TrackingDisplayRuleBase
	{
		// Token: 0x17008DF5 RID: 36341
		// (get) Token: 0x0603C0C5 RID: 245957 RVA: 0x00E5C894 File Offset: 0x00E5AA94
		public override EMissionRuleId Id
		{
			get
			{
				return EMissionRuleId.Default;
			}
		}

		// Token: 0x17008DF6 RID: 36342
		// (get) Token: 0x0603C0C6 RID: 245958 RVA: 0x00E5C897 File Offset: 0x00E5AA97
		public override bool Enabled
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17008DF7 RID: 36343
		// (get) Token: 0x0603C0C7 RID: 245959 RVA: 0x00E5C89A File Offset: 0x00E5AA9A
		public override int Priority
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x0603C0C8 RID: 245960 RVA: 0x00E5C8A0 File Offset: 0x00E5AAA0
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

		// Token: 0x0603C0C9 RID: 245961 RVA: 0x00E5C93D File Offset: 0x00E5AB3D
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
