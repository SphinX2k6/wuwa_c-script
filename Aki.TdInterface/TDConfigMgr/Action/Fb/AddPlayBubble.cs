using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029DE RID: 10718
	public class AddPlayBubble : ActionParams
	{
		// Token: 0x0600ED1F RID: 60703 RVA: 0x0022DD19 File Offset: 0x0022BF19
		public static AddPlayBubble Create(IAddPlayBubble? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AddPlayBubble
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004611 RID: 17937
		// (get) Token: 0x0600ED20 RID: 60704 RVA: 0x0022DD38 File Offset: 0x0022BF38
		public virtual List<int> EntityIds
		{
			get
			{
				if (this._EntityIdsInited)
				{
					return this._EntityIdsCache;
				}
				this._EntityIdsInited = true;
				int entityIdsLength = this.Instance.EntityIdsLength;
				this._EntityIdsCache = new List<int>(entityIdsLength);
				for (int i = 0; i < entityIdsLength; i++)
				{
					this._EntityIdsCache.Add(this.Instance.EntityIds(i));
				}
				return this._EntityIdsCache;
			}
		}

		// Token: 0x17004612 RID: 17938
		// (get) Token: 0x0600ED21 RID: 60705 RVA: 0x0022DD9C File Offset: 0x0022BF9C
		public virtual float? EnterRadius
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.EnterRadius);
			}
		}

		// Token: 0x17004613 RID: 17939
		// (get) Token: 0x0600ED22 RID: 60706 RVA: 0x0022DDD4 File Offset: 0x0022BFD4
		public virtual float? LeaveRadius
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.LeaveRadius);
			}
		}

		// Token: 0x17004614 RID: 17940
		// (get) Token: 0x0600ED23 RID: 60707 RVA: 0x0022DE0C File Offset: 0x0022C00C
		public virtual bool? IsRangeFollowEntity
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsRangeFollowEntity);
			}
		}

		// Token: 0x17004615 RID: 17941
		// (get) Token: 0x0600ED24 RID: 60708 RVA: 0x0022DE42 File Offset: 0x0022C042
		public virtual IBubbleIndex Flow
		{
			get
			{
				if (this._FlowInited)
				{
					return this._FlowCache;
				}
				this._FlowInited = true;
				this._FlowCache = IBubbleIndex.Create(this.Instance.Flow);
				return this._FlowCache;
			}
		}

		// Token: 0x17004616 RID: 17942
		// (get) Token: 0x0600ED25 RID: 60709 RVA: 0x0022DE78 File Offset: 0x0022C078
		public virtual int? WaitTime
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new int?(this.Instance.WaitTime);
			}
		}

		// Token: 0x17004617 RID: 17943
		// (get) Token: 0x0600ED26 RID: 60710 RVA: 0x0022DEB0 File Offset: 0x0022C0B0
		public virtual bool? RedDot
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.RedDot);
			}
		}

		// Token: 0x17004618 RID: 17944
		// (get) Token: 0x0600ED27 RID: 60711 RVA: 0x0022DEE8 File Offset: 0x0022C0E8
		public virtual bool? IsAudioOccludedByScene
		{
			get
			{
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsAudioOccludedByScene);
			}
		}

		// Token: 0x17004619 RID: 17945
		// (get) Token: 0x0600ED28 RID: 60712 RVA: 0x0022DF1F File Offset: 0x0022C11F
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

		// Token: 0x1700461A RID: 17946
		// (get) Token: 0x0600ED29 RID: 60713 RVA: 0x0022DF54 File Offset: 0x0022C154
		public virtual bool? IsPlayMouthAnim
		{
			get
			{
				if ((this.Instance.NullMask & 64) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsPlayMouthAnim);
			}
		}

		// Token: 0x04008282 RID: 33410
		private IAddPlayBubble Instance;

		// Token: 0x04008283 RID: 33411
		private List<int> _EntityIdsCache;

		// Token: 0x04008284 RID: 33412
		private bool _EntityIdsInited;

		// Token: 0x04008285 RID: 33413
		[Nullable(2)]
		private IBubbleIndex _FlowCache;

		// Token: 0x04008286 RID: 33414
		private bool _FlowInited;

		// Token: 0x04008287 RID: 33415
		[Nullable(2)]
		private IBubbleRangeCylinderConfig _TriggerCylinderConfigCache;

		// Token: 0x04008288 RID: 33416
		private bool _TriggerCylinderConfigInited;
	}
}
