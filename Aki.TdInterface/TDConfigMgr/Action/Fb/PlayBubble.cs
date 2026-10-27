using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002718 RID: 10008
	[NullableContext(2)]
	[Nullable(0)]
	public class PlayBubble : ActionParams
	{
		// Token: 0x0600DF3F RID: 57151 RVA: 0x002115EB File Offset: 0x0020F7EB
		[NullableContext(1)]
		public static PlayBubble Create(IPlayBubble? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayBubble
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042D1 RID: 17105
		// (get) Token: 0x0600DF40 RID: 57152 RVA: 0x0021160C File Offset: 0x0020F80C
		public virtual int? EntityId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.EntityId);
			}
		}

		// Token: 0x170042D2 RID: 17106
		// (get) Token: 0x0600DF41 RID: 57153 RVA: 0x00211642 File Offset: 0x0020F842
		[Nullable(1)]
		public virtual IBubbleIndex Flow
		{
			[NullableContext(1)]
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

		// Token: 0x170042D3 RID: 17107
		// (get) Token: 0x0600DF42 RID: 57154 RVA: 0x00211678 File Offset: 0x0020F878
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

		// Token: 0x170042D4 RID: 17108
		// (get) Token: 0x0600DF43 RID: 57155 RVA: 0x002116B0 File Offset: 0x0020F8B0
		public virtual bool? IsAudioOccludedByScene
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsAudioOccludedByScene);
			}
		}

		// Token: 0x170042D5 RID: 17109
		// (get) Token: 0x0600DF44 RID: 57156 RVA: 0x002116E6 File Offset: 0x0020F8E6
		public virtual IBubbleRangeCylinderConfig TriggerCylinderConfig
		{
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

		// Token: 0x170042D6 RID: 17110
		// (get) Token: 0x0600DF45 RID: 57157 RVA: 0x0021171C File Offset: 0x0020F91C
		public virtual bool? IsPlayMouthAnim
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsPlayMouthAnim);
			}
		}

		// Token: 0x04007BE4 RID: 31716
		private IPlayBubble Instance;

		// Token: 0x04007BE5 RID: 31717
		private IBubbleIndex _FlowCache;

		// Token: 0x04007BE6 RID: 31718
		private bool _FlowInited;

		// Token: 0x04007BE7 RID: 31719
		private IBubbleRangeCylinderConfig _TriggerCylinderConfigCache;

		// Token: 0x04007BE8 RID: 31720
		private bool _TriggerCylinderConfigInited;
	}
}
