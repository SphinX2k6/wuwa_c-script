using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200082E RID: 2094
	public class ITimeScheduleNpcSource
	{
		// Token: 0x06002D12 RID: 11538 RVA: 0x00075864 File Offset: 0x00073A64
		private ITimeScheduleNpcSource_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITimeScheduleNpcSource 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITimeScheduleNpcSource_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITimeScheduleNpcSource_SetValue());
			}
			return result;
		}

		// Token: 0x06002D13 RID: 11539 RVA: 0x0007589C File Offset: 0x00073A9C
		public static ITimeScheduleNpcSource Create([Nullable(2)] ITimeScheduleNpcSource instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScheduleNpcSource
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002D14 RID: 11540 RVA: 0x000758AF File Offset: 0x00073AAF
		public static ITimeScheduleNpcSource CreateFromSetValue([Nullable(2)] ITimeScheduleNpcSource_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITimeScheduleNpcSource
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002D15 RID: 11541 RVA: 0x000758C2 File Offset: 0x00073AC2
		public ITimeScheduleNpcSource_SetValue ToSetValue()
		{
			return new ITimeScheduleNpcSource_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x06002D16 RID: 11542 RVA: 0x000758D5 File Offset: 0x00073AD5
		// (set) Token: 0x06002D17 RID: 11543 RVA: 0x00075900 File Offset: 0x00073B00
		public virtual ETimeScheduleNpcSourceType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETimeScheduleNpcSourceType.EntityTemplate;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001E1F RID: 7711
		[Nullable(2)]
		protected ITimeScheduleNpcSource FbInstance;

		// Token: 0x04001E20 RID: 7712
		[Nullable(2)]
		protected ITimeScheduleNpcSource_SetValue PocoInterface;
	}
}
