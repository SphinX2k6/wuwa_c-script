using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000656 RID: 1622
	[NullableContext(1)]
	[Nullable(0)]
	public class IRandomPoolChoose : IMonsterChooseType
	{
		// Token: 0x060022B4 RID: 8884 RVA: 0x0005F580 File Offset: 0x0005D780
		private IRandomPoolChoose_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRandomPoolChoose 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRandomPoolChoose_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRandomPoolChoose_SetValue());
			}
			return result;
		}

		// Token: 0x060022B5 RID: 8885 RVA: 0x0005F5B8 File Offset: 0x0005D7B8
		public static IRandomPoolChoose Create([Nullable(2)] IRandomPoolChoose instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRandomPoolChoose
			{
				FbInstance = instance
			};
		}

		// Token: 0x060022B6 RID: 8886 RVA: 0x0005F5CB File Offset: 0x0005D7CB
		public static IRandomPoolChoose CreateFromSetValue([Nullable(2)] IRandomPoolChoose_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRandomPoolChoose
			{
				PocoInterface = value
			};
		}

		// Token: 0x060022B7 RID: 8887 RVA: 0x0005F5DE File Offset: 0x0005D7DE
		public new IRandomPoolChoose_SetValue ToSetValue()
		{
			return new IRandomPoolChoose_SetValue
			{
				Type = this.Type,
				RandomPoolConfigs = this.RandomPoolConfigs
			};
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x060022B8 RID: 8888 RVA: 0x0005F5FD File Offset: 0x0005D7FD
		// (set) Token: 0x060022B9 RID: 8889 RVA: 0x0005F628 File Offset: 0x0005D828
		public override EMonsterChooseType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMonsterChooseType.RandomPoolChoose;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x060022BA RID: 8890 RVA: 0x0005F638 File Offset: 0x0005D838
		// (set) Token: 0x060022BB RID: 8891 RVA: 0x0005F6CB File Offset: 0x0005D8CB
		public virtual List<IRandomPoolConfig> RandomPoolConfigs
		{
			get
			{
				if (this._RandomPoolConfigsInited)
				{
					return this._RandomPoolConfigsCache;
				}
				this._RandomPoolConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<IRandomPoolConfig> randomPoolConfigs = this.FbInstance.RandomPoolConfigs;
					if (randomPoolConfigs != null)
					{
						this._RandomPoolConfigsCache = new List<IRandomPoolConfig>(randomPoolConfigs.Count);
						for (int i = 0; i < randomPoolConfigs.Count; i++)
						{
							this._RandomPoolConfigsCache.Add(IRandomPoolConfig.Create(randomPoolConfigs[i]));
						}
					}
				}
				else
				{
					IRandomPoolChoose_SetValue pocoInterface = this.PocoInterface;
					this._RandomPoolConfigsCache = ((pocoInterface != null) ? pocoInterface.RandomPoolConfigs : null);
				}
				return this._RandomPoolConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().RandomPoolConfigs = value;
				this._RandomPoolConfigsInited = false;
			}
		}

		// Token: 0x0400181A RID: 6170
		[Nullable(2)]
		protected new IRandomPoolChoose FbInstance;

		// Token: 0x0400181B RID: 6171
		[Nullable(2)]
		protected new IRandomPoolChoose_SetValue PocoInterface;

		// Token: 0x0400181C RID: 6172
		private List<IRandomPoolConfig> _RandomPoolConfigsCache;

		// Token: 0x0400181D RID: 6173
		private bool _RandomPoolConfigsInited;
	}
}
