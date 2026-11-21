using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200029C RID: 668
	public class IComponentBase
	{
		// Token: 0x06000C02 RID: 3074 RVA: 0x0002F498 File Offset: 0x0002D698
		private IComponentBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IComponentBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IComponentBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IComponentBase_SetValue());
			}
			return result;
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x0002F4D0 File Offset: 0x0002D6D0
		public static IComponentBase Create([Nullable(2)] IComponentBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IComponentBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x0002F4E3 File Offset: 0x0002D6E3
		public static IComponentBase CreateFromSetValue([Nullable(2)] IComponentBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IComponentBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x0002F4F6 File Offset: 0x0002D6F6
		public IComponentBase_SetValue ToSetValue()
		{
			return new IComponentBase_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked
			};
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000C06 RID: 3078 RVA: 0x0002F518 File Offset: 0x0002D718
		// (set) Token: 0x06000C07 RID: 3079 RVA: 0x0002F552 File Offset: 0x0002D752
		public virtual bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				IComponentBase_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x0002F560 File Offset: 0x0002D760
		// (set) Token: 0x06000C09 RID: 3081 RVA: 0x0002F58A File Offset: 0x0002D78A
		public virtual bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x04000B91 RID: 2961
		[Nullable(2)]
		protected IComponentBase FbInstance;

		// Token: 0x04000B92 RID: 2962
		[Nullable(2)]
		protected IComponentBase_SetValue PocoInterface;
	}
}
