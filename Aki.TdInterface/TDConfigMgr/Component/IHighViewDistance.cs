using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000463 RID: 1123
	public class IHighViewDistance : IViewDistanceMode
	{
		// Token: 0x0600167D RID: 5757 RVA: 0x00046020 File Offset: 0x00044220
		private IHighViewDistance_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHighViewDistance 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHighViewDistance_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHighViewDistance_SetValue());
			}
			return result;
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x00046058 File Offset: 0x00044258
		public static IHighViewDistance Create([Nullable(2)] IHighViewDistance instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHighViewDistance
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x0004606B File Offset: 0x0004426B
		public static IHighViewDistance CreateFromSetValue([Nullable(2)] IHighViewDistance_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHighViewDistance
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x0004607E File Offset: 0x0004427E
		public new IHighViewDistance_SetValue ToSetValue()
		{
			return new IHighViewDistance_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06001681 RID: 5761 RVA: 0x00046091 File Offset: 0x00044291
		// (set) Token: 0x06001682 RID: 5762 RVA: 0x000460BC File Offset: 0x000442BC
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

		// Token: 0x04001171 RID: 4465
		[Nullable(2)]
		protected new IHighViewDistance FbInstance;

		// Token: 0x04001172 RID: 4466
		[Nullable(2)]
		protected new IHighViewDistance_SetValue PocoInterface;
	}
}
