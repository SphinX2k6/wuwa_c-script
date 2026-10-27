using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200029F RID: 671
	[NullableContext(1)]
	[Nullable(0)]
	public class ICustomViewDistance : IViewDistanceMode
	{
		// Token: 0x06000C87 RID: 3207 RVA: 0x000305A4 File Offset: 0x0002E7A4
		private ICustomViewDistance_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICustomViewDistance 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICustomViewDistance_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICustomViewDistance_SetValue());
			}
			return result;
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x000305DC File Offset: 0x0002E7DC
		public static ICustomViewDistance Create([Nullable(2)] ICustomViewDistance instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomViewDistance
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x000305EF File Offset: 0x0002E7EF
		public static ICustomViewDistance CreateFromSetValue([Nullable(2)] ICustomViewDistance_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICustomViewDistance
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x00030602 File Offset: 0x0002E802
		public new ICustomViewDistance_SetValue ToSetValue()
		{
			return new ICustomViewDistance_SetValue
			{
				Type = this.Type,
				Distance = this.Distance
			};
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000C8B RID: 3211 RVA: 0x00030621 File Offset: 0x0002E821
		// (set) Token: 0x06000C8C RID: 3212 RVA: 0x0003064C File Offset: 0x0002E84C
		public override EViewDistanceType Type
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

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000C8D RID: 3213 RVA: 0x0003065A File Offset: 0x0002E85A
		// (set) Token: 0x06000C8E RID: 3214 RVA: 0x00030685 File Offset: 0x0002E885
		public virtual int Distance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Distance;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Distance;
			}
			set
			{
				this.GetOrCreatePoco().Distance = value;
			}
		}

		// Token: 0x04000BB7 RID: 2999
		[Nullable(2)]
		protected new ICustomViewDistance FbInstance;

		// Token: 0x04000BB8 RID: 3000
		[Nullable(2)]
		protected new ICustomViewDistance_SetValue PocoInterface;
	}
}
