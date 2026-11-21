using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002116 RID: 8470
	public class ISubScreenModeExit : ISubScreenModeConfig
	{
		// Token: 0x0600B3DE RID: 46046 RVA: 0x00193650 File Offset: 0x00191850
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

		// Token: 0x0600B3DF RID: 46047 RVA: 0x00193688 File Offset: 0x00191888
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

		// Token: 0x0600B3E0 RID: 46048 RVA: 0x0019369B File Offset: 0x0019189B
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

		// Token: 0x0600B3E1 RID: 46049 RVA: 0x001936AE File Offset: 0x001918AE
		public new ISubScreenModeExit_SetValue ToSetValue()
		{
			return new ISubScreenModeExit_SetValue
			{
				Type = this.Type,
				ExitConfigs = this.ExitConfigs
			};
		}

		// Token: 0x1700365D RID: 13917
		// (get) Token: 0x0600B3E2 RID: 46050 RVA: 0x001936CD File Offset: 0x001918CD
		// (set) Token: 0x0600B3E3 RID: 46051 RVA: 0x001936F8 File Offset: 0x001918F8
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

		// Token: 0x1700365E RID: 13918
		// (get) Token: 0x0600B3E4 RID: 46052 RVA: 0x00193708 File Offset: 0x00191908
		// (set) Token: 0x0600B3E5 RID: 46053 RVA: 0x0019379B File Offset: 0x0019199B
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

		// Token: 0x04006A92 RID: 27282
		[Nullable(2)]
		protected new ISubScreenModeExit FbInstance;

		// Token: 0x04006A93 RID: 27283
		[Nullable(2)]
		protected new ISubScreenModeExit_SetValue PocoInterface;

		// Token: 0x04006A94 RID: 27284
		private List<ISetSubScreenData> _ExitConfigsCache;

		// Token: 0x04006A95 RID: 27285
		private bool _ExitConfigsInited;
	}
}
