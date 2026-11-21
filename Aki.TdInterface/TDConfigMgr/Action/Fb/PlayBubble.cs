using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029DF RID: 10719
	public class PlayBubble : ActionParams
	{
		// Token: 0x0600ED2B RID: 60715 RVA: 0x0022DF93 File Offset: 0x0022C193
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

		// Token: 0x1700461B RID: 17947
		// (get) Token: 0x0600ED2C RID: 60716 RVA: 0x0022DFB4 File Offset: 0x0022C1B4
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

		// Token: 0x1700461C RID: 17948
		// (get) Token: 0x0600ED2D RID: 60717 RVA: 0x0022DFEA File Offset: 0x0022C1EA
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

		// Token: 0x1700461D RID: 17949
		// (get) Token: 0x0600ED2E RID: 60718 RVA: 0x0022E020 File Offset: 0x0022C220
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

		// Token: 0x1700461E RID: 17950
		// (get) Token: 0x0600ED2F RID: 60719 RVA: 0x0022E058 File Offset: 0x0022C258
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

		// Token: 0x1700461F RID: 17951
		// (get) Token: 0x0600ED30 RID: 60720 RVA: 0x0022E08E File Offset: 0x0022C28E
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

		// Token: 0x17004620 RID: 17952
		// (get) Token: 0x0600ED31 RID: 60721 RVA: 0x0022E0C4 File Offset: 0x0022C2C4
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

		// Token: 0x04008289 RID: 33417
		private IPlayBubble Instance;

		// Token: 0x0400828A RID: 33418
		[Nullable(2)]
		private IBubbleIndex _FlowCache;

		// Token: 0x0400828B RID: 33419
		private bool _FlowInited;

		// Token: 0x0400828C RID: 33420
		[Nullable(2)]
		private IBubbleRangeCylinderConfig _TriggerCylinderConfigCache;

		// Token: 0x0400828D RID: 33421
		private bool _TriggerCylinderConfigInited;
	}
}
