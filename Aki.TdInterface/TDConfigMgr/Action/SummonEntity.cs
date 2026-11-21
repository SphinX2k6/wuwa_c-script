using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002491 RID: 9361
	public class SummonEntity : ActionParams
	{
		// Token: 0x0600CBA0 RID: 52128 RVA: 0x001D06EC File Offset: 0x001CE8EC
		private SummonEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SummonEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SummonEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SummonEntity_SetValue());
			}
			return result;
		}

		// Token: 0x0600CBA1 RID: 52129 RVA: 0x001D0724 File Offset: 0x001CE924
		public static SummonEntity Create([Nullable(2)] SummonEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SummonEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CBA2 RID: 52130 RVA: 0x001D0737 File Offset: 0x001CE937
		public static SummonEntity CreateFromSetValue([Nullable(2)] SummonEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SummonEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CBA3 RID: 52131 RVA: 0x001D074A File Offset: 0x001CE94A
		public SummonEntity_SetValue ToSetValue()
		{
			return new SummonEntity_SetValue
			{
				SummonEntityConfig = this.SummonEntityConfig
			};
		}

		// Token: 0x17003D13 RID: 15635
		// (get) Token: 0x0600CBA4 RID: 52132 RVA: 0x001D0760 File Offset: 0x001CE960
		// (set) Token: 0x0600CBA5 RID: 52133 RVA: 0x001D07C1 File Offset: 0x001CE9C1
		public virtual ISummonVehicle SummonEntityConfig
		{
			get
			{
				if (this._SummonEntityConfigInited)
				{
					return this._SummonEntityConfigCache;
				}
				this._SummonEntityConfigInited = true;
				if (this.FbInstance != null)
				{
					this._SummonEntityConfigCache = ISummonVehicle.Create(this.FbInstance.SummonEntityConfig);
				}
				else
				{
					SummonEntity_SetValue pocoInterface = this.PocoInterface;
					this._SummonEntityConfigCache = ((pocoInterface != null) ? pocoInterface.SummonEntityConfig : null);
				}
				return this._SummonEntityConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().SummonEntityConfig = value;
				this._SummonEntityConfigInited = false;
			}
		}

		// Token: 0x040078B3 RID: 30899
		[Nullable(2)]
		protected new SummonEntity FbInstance;

		// Token: 0x040078B4 RID: 30900
		[Nullable(2)]
		protected SummonEntity_SetValue PocoInterface;

		// Token: 0x040078B5 RID: 30901
		private ISummonVehicle _SummonEntityConfigCache;

		// Token: 0x040078B6 RID: 30902
		private bool _SummonEntityConfigInited;
	}
}
