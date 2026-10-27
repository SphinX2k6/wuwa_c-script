using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EDD RID: 7901
	[NullableContext(1)]
	[Nullable(0)]
	public class ISubScreenModeExit : ISubScreenModeConfig
	{
		// Token: 0x0600A90C RID: 43276 RVA: 0x0017D658 File Offset: 0x0017B858
		private ISubScreenModeExit_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISubScreenModeExit 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISubScreenModeExit_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISubScreenModeExit_SetValue());
			}
			return result;
		}

		// Token: 0x0600A90D RID: 43277 RVA: 0x0017D690 File Offset: 0x0017B890
		public static ISubScreenModeExit Create([Nullable(2)] ISubScreenModeExit instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubScreenModeExit
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A90E RID: 43278 RVA: 0x0017D6A3 File Offset: 0x0017B8A3
		public static ISubScreenModeExit CreateFromSetValue([Nullable(2)] ISubScreenModeExit_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISubScreenModeExit
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A90F RID: 43279 RVA: 0x0017D6B6 File Offset: 0x0017B8B6
		public new ISubScreenModeExit_SetValue ToSetValue()
		{
			return new ISubScreenModeExit_SetValue
			{
				Type = this.Type,
				ExitConfigs = this.ExitConfigs
			};
		}

		// Token: 0x17003392 RID: 13202
		// (get) Token: 0x0600A910 RID: 43280 RVA: 0x0017D6D5 File Offset: 0x0017B8D5
		// (set) Token: 0x0600A911 RID: 43281 RVA: 0x0017D700 File Offset: 0x0017B900
		public override ESubScreenOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESubScreenOperationType.Init;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003393 RID: 13203
		// (get) Token: 0x0600A912 RID: 43282 RVA: 0x0017D710 File Offset: 0x0017B910
		// (set) Token: 0x0600A913 RID: 43283 RVA: 0x0017D7A3 File Offset: 0x0017B9A3
		public virtual List<ISetSubScreenData> ExitConfigs
		{
			get
			{
				if (this._ExitConfigsInited)
				{
					return this._ExitConfigsCache;
				}
				this._ExitConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<ISetSubScreenData> exitConfigs = this.FbInstance.ExitConfigs;
					if (exitConfigs != null)
					{
						this._ExitConfigsCache = new List<ISetSubScreenData>(exitConfigs.Count);
						for (int i = 0; i < exitConfigs.Count; i++)
						{
							this._ExitConfigsCache.Add(ISetSubScreenData.Create(exitConfigs[i]));
						}
					}
				}
				else
				{
					ISubScreenModeExit_SetValue pocoInterface = this.PocoInterface;
					this._ExitConfigsCache = ((pocoInterface != null) ? pocoInterface.ExitConfigs : null);
				}
				return this._ExitConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().ExitConfigs = value;
				this._ExitConfigsInited = false;
			}
		}

		// Token: 0x040064A3 RID: 25763
		[Nullable(2)]
		protected new ISubScreenModeExit FbInstance;

		// Token: 0x040064A4 RID: 25764
		[Nullable(2)]
		protected new ISubScreenModeExit_SetValue PocoInterface;

		// Token: 0x040064A5 RID: 25765
		private List<ISetSubScreenData> _ExitConfigsCache;

		// Token: 0x040064A6 RID: 25766
		private bool _ExitConfigsInited;
	}
}
