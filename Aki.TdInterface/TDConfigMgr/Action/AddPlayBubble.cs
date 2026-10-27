using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001495 RID: 5269
	[NullableContext(1)]
	[Nullable(0)]
	public class AddPlayBubble : ActionParams
	{
		// Token: 0x060077DA RID: 30682 RVA: 0x0011F854 File Offset: 0x0011DA54
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

		// Token: 0x060077DB RID: 30683 RVA: 0x0011F88C File Offset: 0x0011DA8C
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

		// Token: 0x060077DC RID: 30684 RVA: 0x0011F89F File Offset: 0x0011DA9F
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

		// Token: 0x060077DD RID: 30685 RVA: 0x0011F8B4 File Offset: 0x0011DAB4
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

		// Token: 0x17002843 RID: 10307
		// (get) Token: 0x060077DE RID: 30686 RVA: 0x0011F93E File Offset: 0x0011DB3E
		// (set) Token: 0x060077DF RID: 30687 RVA: 0x0011F965 File Offset: 0x0011DB65
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

		// Token: 0x17002844 RID: 10308
		// (get) Token: 0x060077E0 RID: 30688 RVA: 0x0011F974 File Offset: 0x0011DB74
		// (set) Token: 0x060077E1 RID: 30689 RVA: 0x0011F9AE File Offset: 0x0011DBAE
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

		// Token: 0x17002845 RID: 10309
		// (get) Token: 0x060077E2 RID: 30690 RVA: 0x0011F9BC File Offset: 0x0011DBBC
		// (set) Token: 0x060077E3 RID: 30691 RVA: 0x0011F9F6 File Offset: 0x0011DBF6
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

		// Token: 0x17002846 RID: 10310
		// (get) Token: 0x060077E4 RID: 30692 RVA: 0x0011FA04 File Offset: 0x0011DC04
		// (set) Token: 0x060077E5 RID: 30693 RVA: 0x0011FA3E File Offset: 0x0011DC3E
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

		// Token: 0x17002847 RID: 10311
		// (get) Token: 0x060077E6 RID: 30694 RVA: 0x0011FA4C File Offset: 0x0011DC4C
		// (set) Token: 0x060077E7 RID: 30695 RVA: 0x0011FAAD File Offset: 0x0011DCAD
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

		// Token: 0x17002848 RID: 10312
		// (get) Token: 0x060077E8 RID: 30696 RVA: 0x0011FAC4 File Offset: 0x0011DCC4
		// (set) Token: 0x060077E9 RID: 30697 RVA: 0x0011FAFE File Offset: 0x0011DCFE
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

		// Token: 0x17002849 RID: 10313
		// (get) Token: 0x060077EA RID: 30698 RVA: 0x0011FB0C File Offset: 0x0011DD0C
		// (set) Token: 0x060077EB RID: 30699 RVA: 0x0011FB46 File Offset: 0x0011DD46
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

		// Token: 0x1700284A RID: 10314
		// (get) Token: 0x060077EC RID: 30700 RVA: 0x0011FB54 File Offset: 0x0011DD54
		// (set) Token: 0x060077ED RID: 30701 RVA: 0x0011FB8E File Offset: 0x0011DD8E
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

		// Token: 0x1700284B RID: 10315
		// (get) Token: 0x060077EE RID: 30702 RVA: 0x0011FB9C File Offset: 0x0011DD9C
		// (set) Token: 0x060077EF RID: 30703 RVA: 0x0011FBFD File Offset: 0x0011DDFD
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

		// Token: 0x1700284C RID: 10316
		// (get) Token: 0x060077F0 RID: 30704 RVA: 0x0011FC14 File Offset: 0x0011DE14
		// (set) Token: 0x060077F1 RID: 30705 RVA: 0x0011FC4E File Offset: 0x0011DE4E
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

		// Token: 0x040045AF RID: 17839
		[Nullable(2)]
		protected new AddPlayBubble FbInstance;

		// Token: 0x040045B0 RID: 17840
		[Nullable(2)]
		protected AddPlayBubble_SetValue PocoInterface;

		// Token: 0x040045B1 RID: 17841
		private IBubbleIndex _FlowCache;

		// Token: 0x040045B2 RID: 17842
		private bool _FlowInited;

		// Token: 0x040045B3 RID: 17843
		private IBubbleRangeCylinderConfig _TriggerCylinderConfigCache;

		// Token: 0x040045B4 RID: 17844
		private bool _TriggerCylinderConfigInited;
	}
}
