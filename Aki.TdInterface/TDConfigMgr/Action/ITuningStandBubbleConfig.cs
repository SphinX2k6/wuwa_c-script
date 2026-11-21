using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200224F RID: 8783
	public class ITuningStandBubbleConfig
	{
		// Token: 0x0600BF76 RID: 49014 RVA: 0x001B9D48 File Offset: 0x001B7F48
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

		// Token: 0x0600BF77 RID: 49015 RVA: 0x001B9D80 File Offset: 0x001B7F80
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

		// Token: 0x0600BF78 RID: 49016 RVA: 0x001B9D93 File Offset: 0x001B7F93
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

		// Token: 0x0600BF79 RID: 49017 RVA: 0x001B9DA6 File Offset: 0x001B7FA6
		public ITuningStandBubbleConfig_SetValue ToSetValue()
		{
			return new ITuningStandBubbleConfig_SetValue
			{
				TriggerType = this.TriggerType,
				Flow = this.Flow
			};
		}

		// Token: 0x17003A54 RID: 14932
		// (get) Token: 0x0600BF7A RID: 49018 RVA: 0x001B9DC5 File Offset: 0x001B7FC5
		// (set) Token: 0x0600BF7B RID: 49019 RVA: 0x001B9DF0 File Offset: 0x001B7FF0
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

		// Token: 0x17003A55 RID: 14933
		// (get) Token: 0x0600BF7C RID: 49020 RVA: 0x001B9E00 File Offset: 0x001B8000
		// (set) Token: 0x0600BF7D RID: 49021 RVA: 0x001B9E61 File Offset: 0x001B8061
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

		// Token: 0x040072B9 RID: 29369
		[Nullable(2)]
		protected ITuningStandBubbleConfig FbInstance;

		// Token: 0x040072BA RID: 29370
		[Nullable(2)]
		protected ITuningStandBubbleConfig_SetValue PocoInterface;

		// Token: 0x040072BB RID: 29371
		private PlayFlow _FlowCache;

		// Token: 0x040072BC RID: 29372
		private bool _FlowInited;
	}
}
