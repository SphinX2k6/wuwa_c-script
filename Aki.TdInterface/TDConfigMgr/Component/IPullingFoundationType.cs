using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006CF RID: 1743
	public class IPullingFoundationType
	{
		// Token: 0x060024EC RID: 9452 RVA: 0x000644FC File Offset: 0x000626FC
		private IPullingFoundationType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPullingFoundationType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPullingFoundationType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPullingFoundationType_SetValue());
			}
			return result;
		}

		// Token: 0x060024ED RID: 9453 RVA: 0x00064534 File Offset: 0x00062734
		public static IPullingFoundationType Create([Nullable(2)] IPullingFoundationType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPullingFoundationType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060024EE RID: 9454 RVA: 0x00064547 File Offset: 0x00062747
		public static IPullingFoundationType CreateFromSetValue([Nullable(2)] IPullingFoundationType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPullingFoundationType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060024EF RID: 9455 RVA: 0x0006455A File Offset: 0x0006275A
		public IPullingFoundationType_SetValue ToSetValue()
		{
			return new IPullingFoundationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x060024F0 RID: 9456 RVA: 0x0006456D File Offset: 0x0006276D
		// (set) Token: 0x060024F1 RID: 9457 RVA: 0x00064598 File Offset: 0x00062798
		public virtual EPullingFoundation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPullingFoundation.CategoryMatching;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400198D RID: 6541
		[Nullable(2)]
		protected IPullingFoundationType FbInstance;

		// Token: 0x0400198E RID: 6542
		[Nullable(2)]
		protected IPullingFoundationType_SetValue PocoInterface;
	}
}
