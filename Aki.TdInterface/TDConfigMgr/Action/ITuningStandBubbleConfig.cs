using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002008 RID: 8200
	[NullableContext(1)]
	[Nullable(0)]
	public class ITuningStandBubbleConfig
	{
		// Token: 0x0600B45E RID: 46174 RVA: 0x001A3784 File Offset: 0x001A1984
		private ITuningStandBubbleConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITuningStandBubbleConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITuningStandBubbleConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITuningStandBubbleConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600B45F RID: 46175 RVA: 0x001A37BC File Offset: 0x001A19BC
		public static ITuningStandBubbleConfig Create([Nullable(2)] ITuningStandBubbleConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITuningStandBubbleConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B460 RID: 46176 RVA: 0x001A37CF File Offset: 0x001A19CF
		public static ITuningStandBubbleConfig CreateFromSetValue([Nullable(2)] ITuningStandBubbleConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITuningStandBubbleConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B461 RID: 46177 RVA: 0x001A37E2 File Offset: 0x001A19E2
		public ITuningStandBubbleConfig_SetValue ToSetValue()
		{
			return new ITuningStandBubbleConfig_SetValue
			{
				TriggerType = this.TriggerType,
				Flow = this.Flow
			};
		}

		// Token: 0x1700377B RID: 14203
		// (get) Token: 0x0600B462 RID: 46178 RVA: 0x001A3801 File Offset: 0x001A1A01
		// (set) Token: 0x0600B463 RID: 46179 RVA: 0x001A382C File Offset: 0x001A1A2C
		public virtual ETuningStandBubbleTriggerType TriggerType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TriggerType;
				}
				if (this.PocoInterface == null)
				{
					return ETuningStandBubbleTriggerType.Enter;
				}
				return this.PocoInterface.TriggerType;
			}
			set
			{
				this.GetOrCreatePoco().TriggerType = value;
			}
		}

		// Token: 0x1700377C RID: 14204
		// (get) Token: 0x0600B464 RID: 46180 RVA: 0x001A383C File Offset: 0x001A1A3C
		// (set) Token: 0x0600B465 RID: 46181 RVA: 0x001A389D File Offset: 0x001A1A9D
		public virtual PlayFlow Flow
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
					this._FlowCache = PlayFlow.Create(this.FbInstance.Flow);
				}
				else
				{
					ITuningStandBubbleConfig_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04006CB6 RID: 27830
		[Nullable(2)]
		protected ITuningStandBubbleConfig FbInstance;

		// Token: 0x04006CB7 RID: 27831
		[Nullable(2)]
		protected ITuningStandBubbleConfig_SetValue PocoInterface;

		// Token: 0x04006CB8 RID: 27832
		private PlayFlow _FlowCache;

		// Token: 0x04006CB9 RID: 27833
		private bool _FlowInited;
	}
}
