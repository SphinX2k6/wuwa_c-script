using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000613 RID: 1555
	public class IOnEntityStateChangeAttachTiming : IAttachTiming
	{
		// Token: 0x060020A4 RID: 8356 RVA: 0x0005B858 File Offset: 0x00059A58
		private IOnEntityStateChangeAttachTiming_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOnEntityStateChangeAttachTiming 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOnEntityStateChangeAttachTiming_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOnEntityStateChangeAttachTiming_SetValue());
			}
			return result;
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x0005B890 File Offset: 0x00059A90
		public static IOnEntityStateChangeAttachTiming Create([Nullable(2)] IOnEntityStateChangeAttachTiming instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOnEntityStateChangeAttachTiming
			{
				FbInstance = instance
			};
		}

		// Token: 0x060020A6 RID: 8358 RVA: 0x0005B8A3 File Offset: 0x00059AA3
		public static IOnEntityStateChangeAttachTiming CreateFromSetValue([Nullable(2)] IOnEntityStateChangeAttachTiming_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOnEntityStateChangeAttachTiming
			{
				PocoInterface = value
			};
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x0005B8B6 File Offset: 0x00059AB6
		public new IOnEntityStateChangeAttachTiming_SetValue ToSetValue()
		{
			return new IOnEntityStateChangeAttachTiming_SetValue
			{
				Type = this.Type,
				StateConfigs = this.StateConfigs
			};
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x060020A8 RID: 8360 RVA: 0x0005B8D5 File Offset: 0x00059AD5
		// (set) Token: 0x060020A9 RID: 8361 RVA: 0x0005B900 File Offset: 0x00059B00
		public override EAttachTimingType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAttachTimingType.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x060020AA RID: 8362 RVA: 0x0005B910 File Offset: 0x00059B10
		// (set) Token: 0x060020AB RID: 8363 RVA: 0x0005B9A3 File Offset: 0x00059BA3
		public virtual List<IAttachTimingEntityStateConfig> StateConfigs
		{
			get
			{
				if (this._StateConfigsInited)
				{
					return this._StateConfigsCache;
				}
				this._StateConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<IAttachTimingEntityStateConfig> stateConfigs = this.FbInstance.StateConfigs;
					if (stateConfigs != null)
					{
						this._StateConfigsCache = new List<IAttachTimingEntityStateConfig>(stateConfigs.Count);
						for (int i = 0; i < stateConfigs.Count; i++)
						{
							this._StateConfigsCache.Add(IAttachTimingEntityStateConfig.Create(stateConfigs[i]));
						}
					}
				}
				else
				{
					IOnEntityStateChangeAttachTiming_SetValue pocoInterface = this.PocoInterface;
					this._StateConfigsCache = ((pocoInterface != null) ? pocoInterface.StateConfigs : null);
				}
				return this._StateConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().StateConfigs = value;
				this._StateConfigsInited = false;
			}
		}

		// Token: 0x0400173B RID: 5947
		[Nullable(2)]
		protected new IOnEntityStateChangeAttachTiming FbInstance;

		// Token: 0x0400173C RID: 5948
		[Nullable(2)]
		protected new IOnEntityStateChangeAttachTiming_SetValue PocoInterface;

		// Token: 0x0400173D RID: 5949
		private List<IAttachTimingEntityStateConfig> _StateConfigsCache;

		// Token: 0x0400173E RID: 5950
		private bool _StateConfigsInited;
	}
}
