using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015EE RID: 5614
	public class AddPlayBubble : ActionParams
	{
		// Token: 0x06007EA7 RID: 32423 RVA: 0x0012E4A0 File Offset: 0x0012C6A0
		private AddPlayBubble_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("AddPlayBubble 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			AddPlayBubble_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new AddPlayBubble_SetValue());
			}
			return result;
		}

		// Token: 0x06007EA8 RID: 32424 RVA: 0x0012E4D8 File Offset: 0x0012C6D8
		public static AddPlayBubble Create([Nullable(2)] AddPlayBubble instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AddPlayBubble
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007EA9 RID: 32425 RVA: 0x0012E4EB File Offset: 0x0012C6EB
		public static AddPlayBubble CreateFromSetValue([Nullable(2)] AddPlayBubble_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new AddPlayBubble
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007EAA RID: 32426 RVA: 0x0012E500 File Offset: 0x0012C700
		public AddPlayBubble_SetValue ToSetValue()
		{
			return new AddPlayBubble_SetValue
			{
				EntityIds = this.EntityIds,
				EnterRadius = this.EnterRadius,
				LeaveRadius = this.LeaveRadius,
				IsRangeFollowEntity = this.IsRangeFollowEntity,
				Flow = this.Flow,
				WaitTime = this.WaitTime,
				RedDot = this.RedDot,
				IsAudioOccludedByScene = this.IsAudioOccludedByScene,
				TriggerCylinderConfig = this.TriggerCylinderConfig,
				IsPlayMouthAnim = this.IsPlayMouthAnim
			};
		}

		// Token: 0x17002A2D RID: 10797
		// (get) Token: 0x06007EAB RID: 32427 RVA: 0x0012E58A File Offset: 0x0012C78A
		// (set) Token: 0x06007EAC RID: 32428 RVA: 0x0012E5B1 File Offset: 0x0012C7B1
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				AddPlayBubble_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x17002A2E RID: 10798
		// (get) Token: 0x06007EAD RID: 32429 RVA: 0x0012E5C0 File Offset: 0x0012C7C0
		// (set) Token: 0x06007EAE RID: 32430 RVA: 0x0012E5FA File Offset: 0x0012C7FA
		public virtual float? EnterRadius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EnterRadius;
				}
				AddPlayBubble_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EnterRadius;
			}
			set
			{
				this.GetOrCreatePoco().EnterRadius = value;
			}
		}

		// Token: 0x17002A2F RID: 10799
		// (get) Token: 0x06007EAF RID: 32431 RVA: 0x0012E608 File Offset: 0x0012C808
		// (set) Token: 0x06007EB0 RID: 32432 RVA: 0x0012E642 File Offset: 0x0012C842
		public virtual float? LeaveRadius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LeaveRadius;
				}
				AddPlayBubble_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LeaveRadius;
			}
			set
			{
				this.GetOrCreatePoco().LeaveRadius = value;
			}
		}

		// Token: 0x17002A30 RID: 10800
		// (get) Token: 0x06007EB1 RID: 32433 RVA: 0x0012E650 File Offset: 0x0012C850
		// (set) Token: 0x06007EB2 RID: 32434 RVA: 0x0012E68A File Offset: 0x0012C88A
		public virtual bool? IsRangeFollowEntity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsRangeFollowEntity;
				}
				AddPlayBubble_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002A31 RID: 10801
		// (get) Token: 0x06007EB3 RID: 32435 RVA: 0x0012E698 File Offset: 0x0012C898
		// (set) Token: 0x06007EB4 RID: 32436 RVA: 0x0012E6F9 File Offset: 0x0012C8F9
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
					AddPlayBubble_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002A32 RID: 10802
		// (get) Token: 0x06007EB5 RID: 32437 RVA: 0x0012E710 File Offset: 0x0012C910
		// (set) Token: 0x06007EB6 RID: 32438 RVA: 0x0012E74A File Offset: 0x0012C94A
		public virtual int? WaitTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WaitTime;
				}
				AddPlayBubble_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.WaitTime;
			}
			set
			{
				this.GetOrCreatePoco().WaitTime = value;
			}
		}

		// Token: 0x17002A33 RID: 10803
		// (get) Token: 0x06007EB7 RID: 32439 RVA: 0x0012E758 File Offset: 0x0012C958
		// (set) Token: 0x06007EB8 RID: 32440 RVA: 0x0012E792 File Offset: 0x0012C992
		public virtual bool? RedDot
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RedDot;
				}
				AddPlayBubble_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RedDot;
			}
			set
			{
				this.GetOrCreatePoco().RedDot = value;
			}
		}

		// Token: 0x17002A34 RID: 10804
		// (get) Token: 0x06007EB9 RID: 32441 RVA: 0x0012E7A0 File Offset: 0x0012C9A0
		// (set) Token: 0x06007EBA RID: 32442 RVA: 0x0012E7DA File Offset: 0x0012C9DA
		public virtual bool? IsAudioOccludedByScene
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsAudioOccludedByScene;
				}
				AddPlayBubble_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002A35 RID: 10805
		// (get) Token: 0x06007EBB RID: 32443 RVA: 0x0012E7E8 File Offset: 0x0012C9E8
		// (set) Token: 0x06007EBC RID: 32444 RVA: 0x0012E849 File Offset: 0x0012CA49
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
					AddPlayBubble_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002A36 RID: 10806
		// (get) Token: 0x06007EBD RID: 32445 RVA: 0x0012E860 File Offset: 0x0012CA60
		// (set) Token: 0x06007EBE RID: 32446 RVA: 0x0012E89A File Offset: 0x0012CA9A
		public virtual bool? IsPlayMouthAnim
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsPlayMouthAnim;
				}
				AddPlayBubble_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400494A RID: 18762
		[Nullable(2)]
		protected new AddPlayBubble FbInstance;

		// Token: 0x0400494B RID: 18763
		[Nullable(2)]
		protected AddPlayBubble_SetValue PocoInterface;

		// Token: 0x0400494C RID: 18764
		private IBubbleIndex _FlowCache;

		// Token: 0x0400494D RID: 18765
		private bool _FlowInited;

		// Token: 0x0400494E RID: 18766
		private IBubbleRangeCylinderConfig _TriggerCylinderConfigCache;

		// Token: 0x0400494F RID: 18767
		private bool _TriggerCylinderConfigInited;
	}
}
