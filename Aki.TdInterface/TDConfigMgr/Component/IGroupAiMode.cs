using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000449 RID: 1097
	public class IGroupAiMode
	{
		// Token: 0x060015E7 RID: 5607 RVA: 0x00044DAC File Offset: 0x00042FAC
		private IGroupAiMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGroupAiMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGroupAiMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGroupAiMode_SetValue());
			}
			return result;
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x00044DE4 File Offset: 0x00042FE4
		public static IGroupAiMode Create([Nullable(2)] IGroupAiMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupAiMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00044DF7 File Offset: 0x00042FF7
		public static IGroupAiMode CreateFromSetValue([Nullable(2)] IGroupAiMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGroupAiMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00044E0A File Offset: 0x0004300A
		public IGroupAiMode_SetValue ToSetValue()
		{
			return new IGroupAiMode_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x060015EB RID: 5611 RVA: 0x00044E1D File Offset: 0x0004301D
		// (set) Token: 0x060015EC RID: 5612 RVA: 0x00044E48 File Offset: 0x00043048
		public virtual EGroupAiMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EGroupAiMode.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001121 RID: 4385
		[Nullable(2)]
		protected IGroupAiMode FbInstance;

		// Token: 0x04001122 RID: 4386
		[Nullable(2)]
		protected IGroupAiMode_SetValue PocoInterface;
	}
}
