using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D57 RID: 7511
	public class ILiveInteractDanmakuListenerGroup
	{
		// Token: 0x06009F7B RID: 40827 RVA: 0x0016E350 File Offset: 0x0016C550
		private ILiveInteractDanmakuListenerGroup_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiveInteractDanmakuListenerGroup 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiveInteractDanmakuListenerGroup_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiveInteractDanmakuListenerGroup_SetValue());
			}
			return result;
		}

		// Token: 0x06009F7C RID: 40828 RVA: 0x0016E388 File Offset: 0x0016C588
		public static ILiveInteractDanmakuListenerGroup Create([Nullable(2)] ILiveInteractDanmakuListenerGroup instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveInteractDanmakuListenerGroup
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009F7D RID: 40829 RVA: 0x0016E39B File Offset: 0x0016C59B
		public static ILiveInteractDanmakuListenerGroup CreateFromSetValue([Nullable(2)] ILiveInteractDanmakuListenerGroup_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiveInteractDanmakuListenerGroup
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009F7E RID: 40830 RVA: 0x0016E3AE File Offset: 0x0016C5AE
		public ILiveInteractDanmakuListenerGroup_SetValue ToSetValue()
		{
			return new ILiveInteractDanmakuListenerGroup_SetValue
			{
				Trigger = this.Trigger,
				DanmakuPoolId = this.DanmakuPoolId,
				TriggerCount = this.TriggerCount,
				MaxTriggerCount = this.MaxTriggerCount
			};
		}

		// Token: 0x170031C9 RID: 12745
		// (get) Token: 0x06009F7F RID: 40831 RVA: 0x0016E3E5 File Offset: 0x0016C5E5
		// (set) Token: 0x06009F80 RID: 40832 RVA: 0x0016E40C File Offset: 0x0016C60C
		public virtual ILiveInteractDanmakuTrigger Trigger
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Trigger;
				}
				ILiveInteractDanmakuListenerGroup_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Trigger;
			}
			set
			{
				this.GetOrCreatePoco().Trigger = value;
			}
		}

		// Token: 0x170031CA RID: 12746
		// (get) Token: 0x06009F81 RID: 40833 RVA: 0x0016E41A File Offset: 0x0016C61A
		// (set) Token: 0x06009F82 RID: 40834 RVA: 0x0016E445 File Offset: 0x0016C645
		public virtual int DanmakuPoolId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DanmakuPoolId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.DanmakuPoolId;
			}
			set
			{
				this.GetOrCreatePoco().DanmakuPoolId = value;
			}
		}

		// Token: 0x170031CB RID: 12747
		// (get) Token: 0x06009F83 RID: 40835 RVA: 0x0016E453 File Offset: 0x0016C653
		// (set) Token: 0x06009F84 RID: 40836 RVA: 0x0016E47E File Offset: 0x0016C67E
		public virtual int TriggerCount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TriggerCount;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TriggerCount;
			}
			set
			{
				this.GetOrCreatePoco().TriggerCount = value;
			}
		}

		// Token: 0x170031CC RID: 12748
		// (get) Token: 0x06009F85 RID: 40837 RVA: 0x0016E48C File Offset: 0x0016C68C
		// (set) Token: 0x06009F86 RID: 40838 RVA: 0x0016E4B7 File Offset: 0x0016C6B7
		public virtual int MaxTriggerCount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxTriggerCount;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MaxTriggerCount;
			}
			set
			{
				this.GetOrCreatePoco().MaxTriggerCount = value;
			}
		}

		// Token: 0x04006112 RID: 24850
		[Nullable(2)]
		protected ILiveInteractDanmakuListenerGroup FbInstance;

		// Token: 0x04006113 RID: 24851
		[Nullable(2)]
		protected ILiveInteractDanmakuListenerGroup_SetValue PocoInterface;
	}
}
