using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CBC RID: 3260
	public class BubbleComponent : IComponentBase
	{
		// Token: 0x06004A75 RID: 19061 RVA: 0x000BB45D File Offset: 0x000B965D
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

		// Token: 0x170014F8 RID: 5368
		// (get) Token: 0x06004A76 RID: 19062 RVA: 0x000BB47C File Offset: 0x000B967C
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

		// Token: 0x170014F9 RID: 5369
		// (get) Token: 0x06004A77 RID: 19063 RVA: 0x000BB4B4 File Offset: 0x000B96B4
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170014FA RID: 5370
		// (get) Token: 0x06004A78 RID: 19064 RVA: 0x000BB4CC File Offset: 0x000B96CC
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

		// Token: 0x170014FB RID: 5371
		// (get) Token: 0x06004A79 RID: 19065 RVA: 0x000BB530 File Offset: 0x000B9730
		public virtual float EnterRange
		{
			get
			{
				return this.Instance.EnterRange;
			}
		}

		// Token: 0x170014FC RID: 5372
		// (get) Token: 0x06004A7A RID: 19066 RVA: 0x000BB53D File Offset: 0x000B973D
		public virtual float LeaveRange
		{
			get
			{
				return this.Instance.LeaveRange;
			}
		}

		// Token: 0x170014FD RID: 5373
		// (get) Token: 0x06004A7B RID: 19067 RVA: 0x000BB54C File Offset: 0x000B974C
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

		// Token: 0x170014FE RID: 5374
		// (get) Token: 0x06004A7C RID: 19068 RVA: 0x000BB584 File Offset: 0x000B9784
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

		// Token: 0x170014FF RID: 5375
		// (get) Token: 0x06004A7D RID: 19069 RVA: 0x000BB5F0 File Offset: 0x000B97F0
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

		// Token: 0x17001500 RID: 5376
		// (get) Token: 0x06004A7E RID: 19070 RVA: 0x000BB628 File Offset: 0x000B9828
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

		// Token: 0x17001501 RID: 5377
		// (get) Token: 0x06004A7F RID: 19071 RVA: 0x000BB660 File Offset: 0x000B9860
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

		// Token: 0x17001502 RID: 5378
		// (get) Token: 0x06004A80 RID: 19072 RVA: 0x000BB697 File Offset: 0x000B9897
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

		// Token: 0x17001503 RID: 5379
		// (get) Token: 0x06004A81 RID: 19073 RVA: 0x000BB6CC File Offset: 0x000B98CC
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

		// Token: 0x04002A39 RID: 10809
		private IBubbleComponent Instance;

		// Token: 0x04002A3A RID: 10810
		private List<int> _NpcIdsCache;

		// Token: 0x04002A3B RID: 10811
		private bool _NpcIdsInited;

		// Token: 0x04002A3C RID: 10812
		private List<IConditionBubbleData> _FlowsCache;

		// Token: 0x04002A3D RID: 10813
		private bool _FlowsInited;

		// Token: 0x04002A3E RID: 10814
		[Nullable(2)]
		private IBubbleRangeCylinderConfig _TriggerCylinderConfigCache;

		// Token: 0x04002A3F RID: 10815
		private bool _TriggerCylinderConfigInited;
	}
}
