using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007C5 RID: 1989
	[NullableContext(1)]
	[Nullable(0)]
	public class IViewDistanceMode
	{
		// Token: 0x06002B21 RID: 11041 RVA: 0x00070A08 File Offset: 0x0006EC08
		private IViewDistanceMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IViewDistanceMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IViewDistanceMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IViewDistanceMode_SetValue());
			}
			return result;
		}

		// Token: 0x06002B22 RID: 11042 RVA: 0x00070A40 File Offset: 0x0006EC40
		public static IViewDistanceMode Create([Nullable(2)] IViewDistanceMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IViewDistanceMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002B23 RID: 11043 RVA: 0x00070A53 File Offset: 0x0006EC53
		public static IViewDistanceMode CreateFromSetValue([Nullable(2)] IViewDistanceMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IViewDistanceMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002B24 RID: 11044 RVA: 0x00070A66 File Offset: 0x0006EC66
		public IViewDistanceMode_SetValue ToSetValue()
		{
			return new IViewDistanceMode_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06002B25 RID: 11045 RVA: 0x00070A79 File Offset: 0x0006EC79
		// (set) Token: 0x06002B26 RID: 11046 RVA: 0x00070AA4 File Offset: 0x0006ECA4
		public virtual EViewDistanceType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EViewDistanceType.Low;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001CA8 RID: 7336
		[Nullable(2)]
		protected IViewDistanceMode FbInstance;

		// Token: 0x04001CA9 RID: 7337
		[Nullable(2)]
		protected IViewDistanceMode_SetValue PocoInterface;
	}
}
