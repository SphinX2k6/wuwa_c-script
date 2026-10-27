using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002103 RID: 8451
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayBubble : ActionParams
	{
		// Token: 0x0600B9E6 RID: 47590 RVA: 0x001ADB10 File Offset: 0x001ABD10
		private PlayBubble_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PlayBubble 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PlayBubble_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PlayBubble_SetValue());
			}
			return result;
		}

		// Token: 0x0600B9E7 RID: 47591 RVA: 0x001ADB48 File Offset: 0x001ABD48
		public static PlayBubble Create([Nullable(2)] PlayBubble instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayBubble
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B9E8 RID: 47592 RVA: 0x001ADB5B File Offset: 0x001ABD5B
		public static PlayBubble CreateFromSetValue([Nullable(2)] PlayBubble_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PlayBubble
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B9E9 RID: 47593 RVA: 0x001ADB70 File Offset: 0x001ABD70
		public PlayBubble_SetValue ToSetValue()
		{
			return new PlayBubble_SetValue
			{
				EntityId = this.EntityId,
				Flow = this.Flow,
				IsRangeFollowEntity = this.IsRangeFollowEntity,
				IsAudioOccludedByScene = this.IsAudioOccludedByScene,
				TriggerCylinderConfig = this.TriggerCylinderConfig,
				IsPlayMouthAnim = this.IsPlayMouthAnim
			};
		}

		// Token: 0x170038C8 RID: 14536
		// (get) Token: 0x0600B9EA RID: 47594 RVA: 0x001ADBCC File Offset: 0x001ABDCC
		// (set) Token: 0x0600B9EB RID: 47595 RVA: 0x001ADC06 File Offset: 0x001ABE06
		public virtual int? EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				PlayBubble_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x170038C9 RID: 14537
		// (get) Token: 0x0600B9EC RID: 47596 RVA: 0x001ADC14 File Offset: 0x001ABE14
		// (set) Token: 0x0600B9ED RID: 47597 RVA: 0x001ADC75 File Offset: 0x001ABE75
		public virtual IBubbleIndex Flow
		{
			get
			{
				if (this._FlowInited)
				{
					return this._FlowCache;
				}
				this._FlowInited = true;
				if (this.FbInstance != null)
				{
					this._FlowCache = IBubbleIndex.Create(this.FbInstance.Flow);
				}
				else
				{
					PlayBubble_SetValue pocoInterface = this.PocoInterface;
					this._FlowCache = ((pocoInterface != null) ? pocoInterface.Flow : null);
				}
				return this._FlowCache;
			}
			set
			{
				this.GetOrCreatePoco().Flow = value;
				this._FlowInited = false;
			}
		}

		// Token: 0x170038CA RID: 14538
		// (get) Token: 0x0600B9EE RID: 47598 RVA: 0x001ADC8C File Offset: 0x001ABE8C
		// (set) Token: 0x0600B9EF RID: 47599 RVA: 0x001ADCC6 File Offset: 0x001ABEC6
		public virtual bool? IsRangeFollowEntity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsRangeFollowEntity;
				}
				PlayBubble_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsRangeFollowEntity;
			}
			set
			{
				this.GetOrCreatePoco().IsRangeFollowEntity = value;
			}
		}

		// Token: 0x170038CB RID: 14539
		// (get) Token: 0x0600B9F0 RID: 47600 RVA: 0x001ADCD4 File Offset: 0x001ABED4
		// (set) Token: 0x0600B9F1 RID: 47601 RVA: 0x001ADD0E File Offset: 0x001ABF0E
		public virtual bool? IsAudioOccludedByScene
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsAudioOccludedByScene;
				}
				PlayBubble_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsAudioOccludedByScene;
			}
			set
			{
				this.GetOrCreatePoco().IsAudioOccludedByScene = value;
			}
		}

		// Token: 0x170038CC RID: 14540
		// (get) Token: 0x0600B9F2 RID: 47602 RVA: 0x001ADD1C File Offset: 0x001ABF1C
		// (set) Token: 0x0600B9F3 RID: 47603 RVA: 0x001ADD7D File Offset: 0x001ABF7D
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
				if (this.FbInstance != null)
				{
					this._TriggerCylinderConfigCache = IBubbleRangeCylinderConfig.Create(this.FbInstance.TriggerCylinderConfig);
				}
				else
				{
					PlayBubble_SetValue pocoInterface = this.PocoInterface;
					this._TriggerCylinderConfigCache = ((pocoInterface != null) ? pocoInterface.TriggerCylinderConfig : null);
				}
				return this._TriggerCylinderConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().TriggerCylinderConfig = value;
				this._TriggerCylinderConfigInited = false;
			}
		}

		// Token: 0x170038CD RID: 14541
		// (get) Token: 0x0600B9F4 RID: 47604 RVA: 0x001ADD94 File Offset: 0x001ABF94
		// (set) Token: 0x0600B9F5 RID: 47605 RVA: 0x001ADDCE File Offset: 0x001ABFCE
		public virtual bool? IsPlayMouthAnim
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsPlayMouthAnim;
				}
				PlayBubble_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsPlayMouthAnim;
			}
			set
			{
				this.GetOrCreatePoco().IsPlayMouthAnim = value;
			}
		}

		// Token: 0x04006F4F RID: 28495
		[Nullable(2)]
		protected new PlayBubble FbInstance;

		// Token: 0x04006F50 RID: 28496
		[Nullable(2)]
		protected PlayBubble_SetValue PocoInterface;

		// Token: 0x04006F51 RID: 28497
		private IBubbleIndex _FlowCache;

		// Token: 0x04006F52 RID: 28498
		private bool _FlowInited;

		// Token: 0x04006F53 RID: 28499
		private IBubbleRangeCylinderConfig _TriggerCylinderConfigCache;

		// Token: 0x04006F54 RID: 28500
		private bool _TriggerCylinderConfigInited;
	}
}
