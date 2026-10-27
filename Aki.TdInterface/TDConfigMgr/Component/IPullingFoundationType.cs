using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000632 RID: 1586
	[NullableContext(1)]
	[Nullable(0)]
	public class IPullingFoundationType
	{
		// Token: 0x060021E6 RID: 8678 RVA: 0x0005D7E8 File Offset: 0x0005B9E8
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

		// Token: 0x060021E7 RID: 8679 RVA: 0x0005D820 File Offset: 0x0005BA20
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

		// Token: 0x060021E8 RID: 8680 RVA: 0x0005D833 File Offset: 0x0005BA33
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

		// Token: 0x060021E9 RID: 8681 RVA: 0x0005D846 File Offset: 0x0005BA46
		public IPullingFoundationType_SetValue ToSetValue()
		{
			return new IPullingFoundationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x060021EA RID: 8682 RVA: 0x0005D859 File Offset: 0x0005BA59
		// (set) Token: 0x060021EB RID: 8683 RVA: 0x0005D884 File Offset: 0x0005BA84
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

		// Token: 0x0400179B RID: 6043
		[Nullable(2)]
		protected IPullingFoundationType FbInstance;

		// Token: 0x0400179C RID: 6044
		[Nullable(2)]
		protected IPullingFoundationType_SetValue PocoInterface;
	}
}
