using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ED9 RID: 7897
	[NullableContext(1)]
	[Nullable(0)]
	public class ISubScreenModeAdjust : ISubScreenModeConfig
	{
		// Token: 0x0600A8FA RID: 43258 RVA: 0x0017D42C File Offset: 0x0017B62C
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

		// Token: 0x0600A8FB RID: 43259 RVA: 0x0017D464 File Offset: 0x0017B664
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

		// Token: 0x0600A8FC RID: 43260 RVA: 0x0017D477 File Offset: 0x0017B677
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

		// Token: 0x0600A8FD RID: 43261 RVA: 0x0017D48A File Offset: 0x0017B68A
		public new ISubScreenModeAdjust_SetValue ToSetValue()
		{
			return new ISubScreenModeAdjust_SetValue
			{
				Type = this.Type,
				AdjustConfigs = this.AdjustConfigs
			};
		}

		// Token: 0x1700338F RID: 13199
		// (get) Token: 0x0600A8FE RID: 43262 RVA: 0x0017D4A9 File Offset: 0x0017B6A9
		// (set) Token: 0x0600A8FF RID: 43263 RVA: 0x0017D4D4 File Offset: 0x0017B6D4
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

		// Token: 0x17003390 RID: 13200
		// (get) Token: 0x0600A900 RID: 43264 RVA: 0x0017D4E4 File Offset: 0x0017B6E4
		// (set) Token: 0x0600A901 RID: 43265 RVA: 0x0017D577 File Offset: 0x0017B777
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

		// Token: 0x0400649A RID: 25754
		[Nullable(2)]
		protected new ISubScreenModeAdjust FbInstance;

		// Token: 0x0400649B RID: 25755
		[Nullable(2)]
		protected new ISubScreenModeAdjust_SetValue PocoInterface;

		// Token: 0x0400649C RID: 25756
		private List<ISetSubScreenData> _AdjustConfigsCache;

		// Token: 0x0400649D RID: 25757
		private bool _AdjustConfigsInited;
	}
}
