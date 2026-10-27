using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021EF RID: 8687
	[NullableContext(2)]
	[Nullable(0)]
	public class SetWeather : ActionParams
	{
		// Token: 0x0600BECD RID: 48845 RVA: 0x001B709C File Offset: 0x001B529C
		[NullableContext(1)]
		private SetWeather_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetWeather 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetWeather_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetWeather_SetValue());
			}
			return result;
		}

		// Token: 0x0600BECE RID: 48846 RVA: 0x001B70D4 File Offset: 0x001B52D4
		[NullableContext(1)]
		public static SetWeather Create([Nullable(2)] SetWeather instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetWeather
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BECF RID: 48847 RVA: 0x001B70E7 File Offset: 0x001B52E7
		[NullableContext(1)]
		public static SetWeather CreateFromSetValue([Nullable(2)] SetWeather_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetWeather
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BED0 RID: 48848 RVA: 0x001B70FA File Offset: 0x001B52FA
		[NullableContext(1)]
		public SetWeather_SetValue ToSetValue()
		{
			return new SetWeather_SetValue
			{
				WeatherId = this.WeatherId,
				AreaIds = this.AreaIds
			};
		}

		// Token: 0x170039E2 RID: 14818
		// (get) Token: 0x0600BED1 RID: 48849 RVA: 0x001B7119 File Offset: 0x001B5319
		// (set) Token: 0x0600BED2 RID: 48850 RVA: 0x001B7144 File Offset: 0x001B5344
		public virtual int WeatherId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WeatherId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.WeatherId;
			}
			set
			{
				this.GetOrCreatePoco().WeatherId = value;
			}
		}

		// Token: 0x170039E3 RID: 14819
		// (get) Token: 0x0600BED3 RID: 48851 RVA: 0x001B7152 File Offset: 0x001B5352
		// (set) Token: 0x0600BED4 RID: 48852 RVA: 0x001B7179 File Offset: 0x001B5379
		public virtual List<int> AreaIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AreaIds;
				}
				SetWeather_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AreaIds;
			}
			set
			{
				this.GetOrCreatePoco().AreaIds = value;
			}
		}

		// Token: 0x040071CF RID: 29135
		protected new SetWeather FbInstance;

		// Token: 0x040071D0 RID: 29136
		protected SetWeather_SetValue PocoInterface;
	}
}
