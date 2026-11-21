using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002364 RID: 9060
	public class PlayBubble : ActionParams
	{
		// Token: 0x0600C572 RID: 50546 RVA: 0x001C4C70 File Offset: 0x001C2E70
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

		// Token: 0x0600C573 RID: 50547 RVA: 0x001C4CA8 File Offset: 0x001C2EA8
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

		// Token: 0x0600C574 RID: 50548 RVA: 0x001C4CBB File Offset: 0x001C2EBB
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

		// Token: 0x0600C575 RID: 50549 RVA: 0x001C4CD0 File Offset: 0x001C2ED0
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

		// Token: 0x17003BB4 RID: 15284
		// (get) Token: 0x0600C576 RID: 50550 RVA: 0x001C4D2C File Offset: 0x001C2F2C
		// (set) Token: 0x0600C577 RID: 50551 RVA: 0x001C4D66 File Offset: 0x001C2F66
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

		// Token: 0x17003BB5 RID: 15285
		// (get) Token: 0x0600C578 RID: 50552 RVA: 0x001C4D74 File Offset: 0x001C2F74
		// (set) Token: 0x0600C579 RID: 50553 RVA: 0x001C4DD5 File Offset: 0x001C2FD5
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

		// Token: 0x17003BB6 RID: 15286
		// (get) Token: 0x0600C57A RID: 50554 RVA: 0x001C4DEC File Offset: 0x001C2FEC
		// (set) Token: 0x0600C57B RID: 50555 RVA: 0x001C4E26 File Offset: 0x001C3026
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

		// Token: 0x17003BB7 RID: 15287
		// (get) Token: 0x0600C57C RID: 50556 RVA: 0x001C4E34 File Offset: 0x001C3034
		// (set) Token: 0x0600C57D RID: 50557 RVA: 0x001C4E6E File Offset: 0x001C306E
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

		// Token: 0x17003BB8 RID: 15288
		// (get) Token: 0x0600C57E RID: 50558 RVA: 0x001C4E7C File Offset: 0x001C307C
		// (set) Token: 0x0600C57F RID: 50559 RVA: 0x001C4EDD File Offset: 0x001C30DD
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

		// Token: 0x17003BB9 RID: 15289
		// (get) Token: 0x0600C580 RID: 50560 RVA: 0x001C4EF4 File Offset: 0x001C30F4
		// (set) Token: 0x0600C581 RID: 50561 RVA: 0x001C4F2E File Offset: 0x001C312E
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

		// Token: 0x04007583 RID: 30083
		[Nullable(2)]
		protected new PlayBubble FbInstance;

		// Token: 0x04007584 RID: 30084
		[Nullable(2)]
		protected PlayBubble_SetValue PocoInterface;

		// Token: 0x04007585 RID: 30085
		private IBubbleIndex _FlowCache;

		// Token: 0x04007586 RID: 30086
		private bool _FlowInited;

		// Token: 0x04007587 RID: 30087
		private IBubbleRangeCylinderConfig _TriggerCylinderConfigCache;

		// Token: 0x04007588 RID: 30088
		private bool _TriggerCylinderConfigInited;
	}
}
