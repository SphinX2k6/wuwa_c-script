using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BED RID: 3053
	[NullableContext(1)]
	[Nullable(0)]
	public class BubbleComponent : IComponentBase
	{
		// Token: 0x06004617 RID: 17943 RVA: 0x000B12E1 File Offset: 0x000AF4E1
		public static BubbleComponent Create(IBubbleComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new BubbleComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013FA RID: 5114
		// (get) Token: 0x06004618 RID: 17944 RVA: 0x000B1300 File Offset: 0x000AF500
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

		// Token: 0x170013FB RID: 5115
		// (get) Token: 0x06004619 RID: 17945 RVA: 0x000B1338 File Offset: 0x000AF538
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013FC RID: 5116
		// (get) Token: 0x0600461A RID: 17946 RVA: 0x000B1350 File Offset: 0x000AF550
		public virtual List<int> NpcIds
		{
			get
			{
				if (this._NpcIdsInited)
				{
					return this._NpcIdsCache;
				}
				this._NpcIdsInited = true;
				int npcIdsLength = this.Instance.NpcIdsLength;
				this._NpcIdsCache = new List<int>(npcIdsLength);
				for (int i = 0; i < npcIdsLength; i++)
				{
					this._NpcIdsCache.Add(this.Instance.NpcIds(i));
				}
				return this._NpcIdsCache;
			}
		}

		// Token: 0x170013FD RID: 5117
		// (get) Token: 0x0600461B RID: 17947 RVA: 0x000B13B4 File Offset: 0x000AF5B4
		public virtual float EnterRange
		{
			get
			{
				return this.Instance.EnterRange;
			}
		}

		// Token: 0x170013FE RID: 5118
		// (get) Token: 0x0600461C RID: 17948 RVA: 0x000B13C1 File Offset: 0x000AF5C1
		public virtual float LeaveRange
		{
			get
			{
				return this.Instance.LeaveRange;
			}
		}

		// Token: 0x170013FF RID: 5119
		// (get) Token: 0x0600461D RID: 17949 RVA: 0x000B13D0 File Offset: 0x000AF5D0
		public virtual bool? IsRangeFollowEntity
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsRangeFollowEntity);
			}
		}

		// Token: 0x17001400 RID: 5120
		// (get) Token: 0x0600461E RID: 17950 RVA: 0x000B1408 File Offset: 0x000AF608
		public virtual List<IConditionBubbleData> Flows
		{
			get
			{
				if (this._FlowsInited)
				{
					return this._FlowsCache;
				}
				this._FlowsInited = true;
				int flowsLength = this.Instance.FlowsLength;
				this._FlowsCache = new List<IConditionBubbleData>(flowsLength);
				for (int i = 0; i < flowsLength; i++)
				{
					this._FlowsCache.Add(IConditionBubbleData.Create(this.Instance.Flows(i)));
				}
				return this._FlowsCache;
			}
		}

		// Token: 0x17001401 RID: 5121
		// (get) Token: 0x0600461F RID: 17951 RVA: 0x000B1474 File Offset: 0x000AF674
		public virtual int? TimberId
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new int?(this.Instance.TimberId);
			}
		}

		// Token: 0x17001402 RID: 5122
		// (get) Token: 0x06004620 RID: 17952 RVA: 0x000B14AC File Offset: 0x000AF6AC
		public virtual float? Scale
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Scale);
			}
		}

		// Token: 0x17001403 RID: 5123
		// (get) Token: 0x06004621 RID: 17953 RVA: 0x000B14E4 File Offset: 0x000AF6E4
		public virtual bool? IsAudioOccludedByScene
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsAudioOccludedByScene);
			}
		}

		// Token: 0x17001404 RID: 5124
		// (get) Token: 0x06004622 RID: 17954 RVA: 0x000B151B File Offset: 0x000AF71B
		[Nullable(2)]
		public virtual IBubbleRangeCylinderConfig TriggerCylinderConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._TriggerCylinderConfigInited)
				{
					return this._TriggerCylinderConfigCache;
				}
				this._TriggerCylinderConfigInited = true;
				this._TriggerCylinderConfigCache = IBubbleRangeCylinderConfig.Create(this.Instance.TriggerCylinderConfig);
				return this._TriggerCylinderConfigCache;
			}
		}

		// Token: 0x17001405 RID: 5125
		// (get) Token: 0x06004623 RID: 17955 RVA: 0x000B1550 File Offset: 0x000AF750
		public virtual bool? IsPlayMouthAnim
		{
			get
			{
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsPlayMouthAnim);
			}
		}

		// Token: 0x040027EE RID: 10222
		private IBubbleComponent Instance;

		// Token: 0x040027EF RID: 10223
		private List<int> _NpcIdsCache;

		// Token: 0x040027F0 RID: 10224
		private bool _NpcIdsInited;

		// Token: 0x040027F1 RID: 10225
		private List<IConditionBubbleData> _FlowsCache;

		// Token: 0x040027F2 RID: 10226
		private bool _FlowsInited;

		// Token: 0x040027F3 RID: 10227
		[Nullable(2)]
		private IBubbleRangeCylinderConfig _TriggerCylinderConfigCache;

		// Token: 0x040027F4 RID: 10228
		private bool _TriggerCylinderConfigInited;
	}
}
