using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DEE RID: 3566
	[NullableContext(1)]
	[Nullable(0)]
	public class FlowerPollutionComponent : IComponentBase
	{
		// Token: 0x060050C6 RID: 20678 RVA: 0x000C762D File Offset: 0x000C582D
		public static FlowerPollutionComponent Create(IFlowerPollutionComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FlowerPollutionComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001AA7 RID: 6823
		// (get) Token: 0x060050C7 RID: 20679 RVA: 0x000C764C File Offset: 0x000C584C
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001AA8 RID: 6824
		// (get) Token: 0x060050C8 RID: 20680 RVA: 0x000C7684 File Offset: 0x000C5884
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001AA9 RID: 6825
		// (get) Token: 0x060050C9 RID: 20681 RVA: 0x000C769A File Offset: 0x000C589A
		public virtual IFlowerPollutionSplineConfig SplineConfigs
		{
			get
			{
				if (this._SplineConfigsInited)
				{
					return this._SplineConfigsCache;
				}
				this._SplineConfigsInited = true;
				this._SplineConfigsCache = IFlowerPollutionSplineConfig.Create(this.Instance.SplineConfigs);
				return this._SplineConfigsCache;
			}
		}

		// Token: 0x17001AAA RID: 6826
		// (get) Token: 0x060050CA RID: 20682 RVA: 0x000C76CE File Offset: 0x000C58CE
		public virtual IFlowerPollutionPointLightConfig PointLightConfig
		{
			get
			{
				if (this._PointLightConfigInited)
				{
					return this._PointLightConfigCache;
				}
				this._PointLightConfigInited = true;
				this._PointLightConfigCache = IFlowerPollutionPointLightConfig.Create(this.Instance.PointLightConfig);
				return this._PointLightConfigCache;
			}
		}

		// Token: 0x17001AAB RID: 6827
		// (get) Token: 0x060050CB RID: 20683 RVA: 0x000C7704 File Offset: 0x000C5904
		public virtual List<int> ObstacleEntityIds
		{
			get
			{
				if (this._ObstacleEntityIdsInited)
				{
					return this._ObstacleEntityIdsCache;
				}
				this._ObstacleEntityIdsInited = true;
				int obstacleEntityIdsLength = this.Instance.ObstacleEntityIdsLength;
				this._ObstacleEntityIdsCache = new List<int>(obstacleEntityIdsLength);
				for (int i = 0; i < obstacleEntityIdsLength; i++)
				{
					this._ObstacleEntityIdsCache.Add(this.Instance.ObstacleEntityIds(i));
				}
				return this._ObstacleEntityIdsCache;
			}
		}

		// Token: 0x17001AAC RID: 6828
		// (get) Token: 0x060050CC RID: 20684 RVA: 0x000C7768 File Offset: 0x000C5968
		public virtual List<int> PollutionSourceEntityIds
		{
			get
			{
				if (this._PollutionSourceEntityIdsInited)
				{
					return this._PollutionSourceEntityIdsCache;
				}
				this._PollutionSourceEntityIdsInited = true;
				int pollutionSourceEntityIdsLength = this.Instance.PollutionSourceEntityIdsLength;
				this._PollutionSourceEntityIdsCache = new List<int>(pollutionSourceEntityIdsLength);
				for (int i = 0; i < pollutionSourceEntityIdsLength; i++)
				{
					this._PollutionSourceEntityIdsCache.Add(this.Instance.PollutionSourceEntityIds(i));
				}
				return this._PollutionSourceEntityIdsCache;
			}
		}

		// Token: 0x17001AAD RID: 6829
		// (get) Token: 0x060050CD RID: 20685 RVA: 0x000C77CC File Offset: 0x000C59CC
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> OnEnterPollutionRangeActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._OnEnterPollutionRangeActionsInited)
				{
					return this._OnEnterPollutionRangeActionsCache;
				}
				this._OnEnterPollutionRangeActionsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int onEnterPollutionRangeActionsLength = this.Instance.OnEnterPollutionRangeActionsLength;
				this._OnEnterPollutionRangeActionsCache = new List<ActionInfo>(onEnterPollutionRangeActionsLength);
				for (int i = 0; i < onEnterPollutionRangeActionsLength; i++)
				{
					this._OnEnterPollutionRangeActionsCache.Add(ActionInfo.Create(this.Instance.OnEnterPollutionRangeActions(i)));
				}
				return this._OnEnterPollutionRangeActionsCache;
			}
		}

		// Token: 0x17001AAE RID: 6830
		// (get) Token: 0x060050CE RID: 20686 RVA: 0x000C7848 File Offset: 0x000C5A48
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> OnLeavePollutionRangeActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._OnLeavePollutionRangeActionsInited)
				{
					return this._OnLeavePollutionRangeActionsCache;
				}
				this._OnLeavePollutionRangeActionsInited = true;
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int onLeavePollutionRangeActionsLength = this.Instance.OnLeavePollutionRangeActionsLength;
				this._OnLeavePollutionRangeActionsCache = new List<ActionInfo>(onLeavePollutionRangeActionsLength);
				for (int i = 0; i < onLeavePollutionRangeActionsLength; i++)
				{
					this._OnLeavePollutionRangeActionsCache.Add(ActionInfo.Create(this.Instance.OnLeavePollutionRangeActions(i)));
				}
				return this._OnLeavePollutionRangeActionsCache;
			}
		}

		// Token: 0x17001AAF RID: 6831
		// (get) Token: 0x060050CF RID: 20687 RVA: 0x000C78C2 File Offset: 0x000C5AC2
		public virtual string BakeData
		{
			get
			{
				return this.Instance.BakeData;
			}
		}

		// Token: 0x04002E65 RID: 11877
		private IFlowerPollutionComponent Instance;

		// Token: 0x04002E66 RID: 11878
		[Nullable(2)]
		private IFlowerPollutionSplineConfig _SplineConfigsCache;

		// Token: 0x04002E67 RID: 11879
		private bool _SplineConfigsInited;

		// Token: 0x04002E68 RID: 11880
		[Nullable(2)]
		private IFlowerPollutionPointLightConfig _PointLightConfigCache;

		// Token: 0x04002E69 RID: 11881
		private bool _PointLightConfigInited;

		// Token: 0x04002E6A RID: 11882
		private List<int> _ObstacleEntityIdsCache;

		// Token: 0x04002E6B RID: 11883
		private bool _ObstacleEntityIdsInited;

		// Token: 0x04002E6C RID: 11884
		private List<int> _PollutionSourceEntityIdsCache;

		// Token: 0x04002E6D RID: 11885
		private bool _PollutionSourceEntityIdsInited;

		// Token: 0x04002E6E RID: 11886
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _OnEnterPollutionRangeActionsCache;

		// Token: 0x04002E6F RID: 11887
		private bool _OnEnterPollutionRangeActionsInited;

		// Token: 0x04002E70 RID: 11888
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _OnLeavePollutionRangeActionsCache;

		// Token: 0x04002E71 RID: 11889
		private bool _OnLeavePollutionRangeActionsInited;
	}
}
