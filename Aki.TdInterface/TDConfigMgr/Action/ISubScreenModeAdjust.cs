using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002112 RID: 8466
	public class ISubScreenModeAdjust : ISubScreenModeConfig
	{
		// Token: 0x0600B3CC RID: 46028 RVA: 0x00193424 File Offset: 0x00191624
		private ISubScreenModeAdjust_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISubScreenModeAdjust 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISubScreenModeAdjust_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISubScreenModeAdjust_SetValue());
			}
			return result;
		}

		// Token: 0x0600B3CD RID: 46029 RVA: 0x0019345C File Offset: 0x0019165C
		public static ISubScreenModeAdjust Create([Nullable(2)] ISubScreenModeAdjust instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubScreenModeAdjust
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B3CE RID: 46030 RVA: 0x0019346F File Offset: 0x0019166F
		public static ISubScreenModeAdjust CreateFromSetValue([Nullable(2)] ISubScreenModeAdjust_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISubScreenModeAdjust
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B3CF RID: 46031 RVA: 0x00193482 File Offset: 0x00191682
		public new ISubScreenModeAdjust_SetValue ToSetValue()
		{
			return new ISubScreenModeAdjust_SetValue
			{
				Type = this.Type,
				AdjustConfigs = this.AdjustConfigs
			};
		}

		// Token: 0x1700365A RID: 13914
		// (get) Token: 0x0600B3D0 RID: 46032 RVA: 0x001934A1 File Offset: 0x001916A1
		// (set) Token: 0x0600B3D1 RID: 46033 RVA: 0x001934CC File Offset: 0x001916CC
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

		// Token: 0x1700365B RID: 13915
		// (get) Token: 0x0600B3D2 RID: 46034 RVA: 0x001934DC File Offset: 0x001916DC
		// (set) Token: 0x0600B3D3 RID: 46035 RVA: 0x0019356F File Offset: 0x0019176F
		public virtual List<ISetSubScreenData> AdjustConfigs
		{
			get
			{
				if (this._AdjustConfigsInited)
				{
					return this._AdjustConfigsCache;
				}
				this._AdjustConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<ISetSubScreenData> adjustConfigs = this.FbInstance.AdjustConfigs;
					if (adjustConfigs != null)
					{
						this._AdjustConfigsCache = new List<ISetSubScreenData>(adjustConfigs.Count);
						for (int i = 0; i < adjustConfigs.Count; i++)
						{
							this._AdjustConfigsCache.Add(ISetSubScreenData.Create(adjustConfigs[i]));
						}
					}
				}
				else
				{
					ISubScreenModeAdjust_SetValue pocoInterface = this.PocoInterface;
					this._AdjustConfigsCache = ((pocoInterface != null) ? pocoInterface.AdjustConfigs : null);
				}
				return this._AdjustConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().AdjustConfigs = value;
				this._AdjustConfigsInited = false;
			}
		}

		// Token: 0x04006A89 RID: 27273
		[Nullable(2)]
		protected new ISubScreenModeAdjust FbInstance;

		// Token: 0x04006A8A RID: 27274
		[Nullable(2)]
		protected new ISubScreenModeAdjust_SetValue PocoInterface;

		// Token: 0x04006A8B RID: 27275
		private List<ISetSubScreenData> _AdjustConfigsCache;

		// Token: 0x04006A8C RID: 27276
		private bool _AdjustConfigsInited;
	}
}
