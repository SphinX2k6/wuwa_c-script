using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EEA RID: 3818
	public class FlowerPollutionComponent : IComponentBase
	{
		// Token: 0x060055ED RID: 21997 RVA: 0x000D2EF5 File Offset: 0x000D10F5
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

		// Token: 0x17001C14 RID: 7188
		// (get) Token: 0x060055EE RID: 21998 RVA: 0x000D2F14 File Offset: 0x000D1114
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

		// Token: 0x17001C15 RID: 7189
		// (get) Token: 0x060055EF RID: 21999 RVA: 0x000D2F4C File Offset: 0x000D114C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C16 RID: 7190
		// (get) Token: 0x060055F0 RID: 22000 RVA: 0x000D2F62 File Offset: 0x000D1162
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

		// Token: 0x17001C17 RID: 7191
		// (get) Token: 0x060055F1 RID: 22001 RVA: 0x000D2F96 File Offset: 0x000D1196
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

		// Token: 0x17001C18 RID: 7192
		// (get) Token: 0x060055F2 RID: 22002 RVA: 0x000D2FCC File Offset: 0x000D11CC
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

		// Token: 0x17001C19 RID: 7193
		// (get) Token: 0x060055F3 RID: 22003 RVA: 0x000D3030 File Offset: 0x000D1230
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

		// Token: 0x17001C1A RID: 7194
		// (get) Token: 0x060055F4 RID: 22004 RVA: 0x000D3094 File Offset: 0x000D1294
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> OnEnterPollutionRangeActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x17001C1B RID: 7195
		// (get) Token: 0x060055F5 RID: 22005 RVA: 0x000D3110 File Offset: 0x000D1310
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> OnLeavePollutionRangeActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x17001C1C RID: 7196
		// (get) Token: 0x060055F6 RID: 22006 RVA: 0x000D318A File Offset: 0x000D138A
		public virtual string BakeData
		{
			get
			{
				return this.Instance.BakeData;
			}
		}

		// Token: 0x0400312D RID: 12589
		private IFlowerPollutionComponent Instance;

		// Token: 0x0400312E RID: 12590
		[Nullable(2)]
		private IFlowerPollutionSplineConfig _SplineConfigsCache;

		// Token: 0x0400312F RID: 12591
		private bool _SplineConfigsInited;

		// Token: 0x04003130 RID: 12592
		[Nullable(2)]
		private IFlowerPollutionPointLightConfig _PointLightConfigCache;

		// Token: 0x04003131 RID: 12593
		private bool _PointLightConfigInited;

		// Token: 0x04003132 RID: 12594
		private List<int> _ObstacleEntityIdsCache;

		// Token: 0x04003133 RID: 12595
		private bool _ObstacleEntityIdsInited;

		// Token: 0x04003134 RID: 12596
		private List<int> _PollutionSourceEntityIdsCache;

		// Token: 0x04003135 RID: 12597
		private bool _PollutionSourceEntityIdsInited;

		// Token: 0x04003136 RID: 12598
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _OnEnterPollutionRangeActionsCache;

		// Token: 0x04003137 RID: 12599
		private bool _OnEnterPollutionRangeActionsInited;

		// Token: 0x04003138 RID: 12600
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _OnLeavePollutionRangeActionsCache;

		// Token: 0x04003139 RID: 12601
		private bool _OnLeavePollutionRangeActionsInited;
	}
}
