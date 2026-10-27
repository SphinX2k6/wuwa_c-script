using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002717 RID: 10007
	[NullableContext(1)]
	[Nullable(0)]
	public class AddPlayBubble : ActionParams
	{
		// Token: 0x0600DF33 RID: 57139 RVA: 0x00211371 File Offset: 0x0020F571
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

		// Token: 0x170042C7 RID: 17095
		// (get) Token: 0x0600DF34 RID: 57140 RVA: 0x00211390 File Offset: 0x0020F590
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

		// Token: 0x170042C8 RID: 17096
		// (get) Token: 0x0600DF35 RID: 57141 RVA: 0x002113F4 File Offset: 0x0020F5F4
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

		// Token: 0x170042C9 RID: 17097
		// (get) Token: 0x0600DF36 RID: 57142 RVA: 0x0021142C File Offset: 0x0020F62C
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

		// Token: 0x170042CA RID: 17098
		// (get) Token: 0x0600DF37 RID: 57143 RVA: 0x00211464 File Offset: 0x0020F664
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

		// Token: 0x170042CB RID: 17099
		// (get) Token: 0x0600DF38 RID: 57144 RVA: 0x0021149A File Offset: 0x0020F69A
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

		// Token: 0x170042CC RID: 17100
		// (get) Token: 0x0600DF39 RID: 57145 RVA: 0x002114D0 File Offset: 0x0020F6D0
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

		// Token: 0x170042CD RID: 17101
		// (get) Token: 0x0600DF3A RID: 57146 RVA: 0x00211508 File Offset: 0x0020F708
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

		// Token: 0x170042CE RID: 17102
		// (get) Token: 0x0600DF3B RID: 57147 RVA: 0x00211540 File Offset: 0x0020F740
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

		// Token: 0x170042CF RID: 17103
		// (get) Token: 0x0600DF3C RID: 57148 RVA: 0x00211577 File Offset: 0x0020F777
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

		// Token: 0x170042D0 RID: 17104
		// (get) Token: 0x0600DF3D RID: 57149 RVA: 0x002115AC File Offset: 0x0020F7AC
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

		// Token: 0x04007BDD RID: 31709
		private IAddPlayBubble Instance;

		// Token: 0x04007BDE RID: 31710
		private List<int> _EntityIdsCache;

		// Token: 0x04007BDF RID: 31711
		private bool _EntityIdsInited;

		// Token: 0x04007BE0 RID: 31712
		[Nullable(2)]
		private IBubbleIndex _FlowCache;

		// Token: 0x04007BE1 RID: 31713
		private bool _FlowInited;

		// Token: 0x04007BE2 RID: 31714
		[Nullable(2)]
		private IBubbleRangeCylinderConfig _TriggerCylinderConfigCache;

		// Token: 0x04007BE3 RID: 31715
		private bool _TriggerCylinderConfigInited;
	}
}
