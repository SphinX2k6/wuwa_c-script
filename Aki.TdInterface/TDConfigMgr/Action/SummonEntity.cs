using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002226 RID: 8742
	[NullableContext(1)]
	[Nullable(0)]
	public class SummonEntity : ActionParams
	{
		// Token: 0x0600BFE2 RID: 49122 RVA: 0x001B9020 File Offset: 0x001B7220
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

		// Token: 0x0600BFE3 RID: 49123 RVA: 0x001B9058 File Offset: 0x001B7258
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

		// Token: 0x0600BFE4 RID: 49124 RVA: 0x001B906B File Offset: 0x001B726B
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

		// Token: 0x0600BFE5 RID: 49125 RVA: 0x001B907E File Offset: 0x001B727E
		public SummonEntity_SetValue ToSetValue()
		{
			return new SummonEntity_SetValue
			{
				SummonEntityConfig = this.SummonEntityConfig
			};
		}

		// Token: 0x17003A1D RID: 14877
		// (get) Token: 0x0600BFE6 RID: 49126 RVA: 0x001B9094 File Offset: 0x001B7294
		// (set) Token: 0x0600BFE7 RID: 49127 RVA: 0x001B90F5 File Offset: 0x001B72F5
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

		// Token: 0x04007269 RID: 29289
		[Nullable(2)]
		protected new SummonEntity FbInstance;

		// Token: 0x0400726A RID: 29290
		[Nullable(2)]
		protected SummonEntity_SetValue PocoInterface;

		// Token: 0x0400726B RID: 29291
		private ISummonVehicle _SummonEntityConfigCache;

		// Token: 0x0400726C RID: 29292
		private bool _SummonEntityConfigInited;
	}
}
