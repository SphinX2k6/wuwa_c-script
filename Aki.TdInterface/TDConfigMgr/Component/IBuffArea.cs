using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001FF RID: 511
	[NullableContext(1)]
	[Nullable(0)]
	public class IBuffArea : IEffectAreaMode
	{
		// Token: 0x06000872 RID: 2162 RVA: 0x00026D40 File Offset: 0x00024F40
		private IBuffArea_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBuffArea 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBuffArea_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBuffArea_SetValue());
			}
			return result;
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00026D78 File Offset: 0x00024F78
		public static IBuffArea Create([Nullable(2)] IBuffArea instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBuffArea
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00026D8B File Offset: 0x00024F8B
		public static IBuffArea CreateFromSetValue([Nullable(2)] IBuffArea_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBuffArea
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00026D9E File Offset: 0x00024F9E
		public new IBuffArea_SetValue ToSetValue()
		{
			return new IBuffArea_SetValue
			{
				Type = this.Type,
				BuffConfigs = this.BuffConfigs
			};
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000876 RID: 2166 RVA: 0x00026DBD File Offset: 0x00024FBD
		// (set) Token: 0x06000877 RID: 2167 RVA: 0x00026DE8 File Offset: 0x00024FE8
		public override EEffectAreaType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEffectAreaType.BuffArea;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x00026DF8 File Offset: 0x00024FF8
		// (set) Token: 0x06000879 RID: 2169 RVA: 0x00026E8B File Offset: 0x0002508B
		public virtual List<IBuffAreaStateConfig> BuffConfigs
		{
			get
			{
				if (this._BuffConfigsInited)
				{
					return this._BuffConfigsCache;
				}
				this._BuffConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<IBuffAreaStateConfig> buffConfigs = this.FbInstance.BuffConfigs;
					if (buffConfigs != null)
					{
						this._BuffConfigsCache = new List<IBuffAreaStateConfig>(buffConfigs.Count);
						for (int i = 0; i < buffConfigs.Count; i++)
						{
							this._BuffConfigsCache.Add(IBuffAreaStateConfig.Create(buffConfigs[i]));
						}
					}
				}
				else
				{
					IBuffArea_SetValue pocoInterface = this.PocoInterface;
					this._BuffConfigsCache = ((pocoInterface != null) ? pocoInterface.BuffConfigs : null);
				}
				return this._BuffConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().BuffConfigs = value;
				this._BuffConfigsInited = false;
			}
		}

		// Token: 0x04000924 RID: 2340
		[Nullable(2)]
		protected new IBuffArea FbInstance;

		// Token: 0x04000925 RID: 2341
		[Nullable(2)]
		protected new IBuffArea_SetValue PocoInterface;

		// Token: 0x04000926 RID: 2342
		private List<IBuffAreaStateConfig> _BuffConfigsCache;

		// Token: 0x04000927 RID: 2343
		private bool _BuffConfigsInited;
	}
}
