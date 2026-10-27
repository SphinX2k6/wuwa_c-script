using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E0C RID: 7692
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetAreaTimeBase
	{
		// Token: 0x0600A491 RID: 42129 RVA: 0x001752EC File Offset: 0x001734EC
		private ISetAreaTimeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetAreaTimeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetAreaTimeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetAreaTimeBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600A492 RID: 42130 RVA: 0x00175324 File Offset: 0x00173524
		public static ISetAreaTimeBase Create([Nullable(2)] ISetAreaTimeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetAreaTimeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A493 RID: 42131 RVA: 0x00175337 File Offset: 0x00173537
		public static ISetAreaTimeBase CreateFromSetValue([Nullable(2)] ISetAreaTimeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetAreaTimeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A494 RID: 42132 RVA: 0x0017534A File Offset: 0x0017354A
		public ISetAreaTimeBase_SetValue ToSetValue()
		{
			return new ISetAreaTimeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700328D RID: 12941
		// (get) Token: 0x0600A495 RID: 42133 RVA: 0x0017535D File Offset: 0x0017355D
		// (set) Token: 0x0600A496 RID: 42134 RVA: 0x00175388 File Offset: 0x00173588
		public virtual ESetAreaTime Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetAreaTime.Lock;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006286 RID: 25222
		[Nullable(2)]
		protected ISetAreaTimeBase FbInstance;

		// Token: 0x04006287 RID: 25223
		[Nullable(2)]
		protected ISetAreaTimeBase_SetValue PocoInterface;
	}
}
