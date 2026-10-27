using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200078D RID: 1933
	[NullableContext(1)]
	[Nullable(0)]
	public class ITimeScheduleNpcSource
	{
		// Token: 0x060029EC RID: 10732 RVA: 0x0006E608 File Offset: 0x0006C808
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

		// Token: 0x060029ED RID: 10733 RVA: 0x0006E640 File Offset: 0x0006C840
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

		// Token: 0x060029EE RID: 10734 RVA: 0x0006E653 File Offset: 0x0006C853
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

		// Token: 0x060029EF RID: 10735 RVA: 0x0006E666 File Offset: 0x0006C866
		public ITimeScheduleNpcSource_SetValue ToSetValue()
		{
			return new ITimeScheduleNpcSource_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x060029F0 RID: 10736 RVA: 0x0006E679 File Offset: 0x0006C879
		// (set) Token: 0x060029F1 RID: 10737 RVA: 0x0006E6A4 File Offset: 0x0006C8A4
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

		// Token: 0x04001C17 RID: 7191
		[Nullable(2)]
		protected ITimeScheduleNpcSource FbInstance;

		// Token: 0x04001C18 RID: 7192
		[Nullable(2)]
		protected ITimeScheduleNpcSource_SetValue PocoInterface;
	}
}
