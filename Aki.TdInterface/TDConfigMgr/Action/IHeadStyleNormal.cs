using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AF1 RID: 6897
	[NullableContext(1)]
	[Nullable(0)]
	public class IHeadStyleNormal : IHeadStyle
	{
		// Token: 0x060093BE RID: 37822 RVA: 0x00156A10 File Offset: 0x00154C10
		private IHeadStyleNormal_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHeadStyleNormal 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHeadStyleNormal_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHeadStyleNormal_SetValue());
			}
			return result;
		}

		// Token: 0x060093BF RID: 37823 RVA: 0x00156A48 File Offset: 0x00154C48
		public static IHeadStyleNormal Create([Nullable(2)] IHeadStyleNormal instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHeadStyleNormal
			{
				FbInstance = instance
			};
		}

		// Token: 0x060093C0 RID: 37824 RVA: 0x00156A5B File Offset: 0x00154C5B
		public static IHeadStyleNormal CreateFromSetValue([Nullable(2)] IHeadStyleNormal_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHeadStyleNormal
			{
				PocoInterface = value
			};
		}

		// Token: 0x060093C1 RID: 37825 RVA: 0x00156A6E File Offset: 0x00154C6E
		public new IHeadStyleNormal_SetValue ToSetValue()
		{
			return new IHeadStyleNormal_SetValue
			{
				Type = this.Type,
				WhoId = this.WhoId
			};
		}

		// Token: 0x17002ECB RID: 11979
		// (get) Token: 0x060093C2 RID: 37826 RVA: 0x00156A8D File Offset: 0x00154C8D
		// (set) Token: 0x060093C3 RID: 37827 RVA: 0x00156AB8 File Offset: 0x00154CB8
		public override EHeadStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHeadStyle.Normal;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002ECC RID: 11980
		// (get) Token: 0x060093C4 RID: 37828 RVA: 0x00156AC6 File Offset: 0x00154CC6
		// (set) Token: 0x060093C5 RID: 37829 RVA: 0x00156AF1 File Offset: 0x00154CF1
		public virtual int WhoId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WhoId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.WhoId;
			}
			set
			{
				this.GetOrCreatePoco().WhoId = value;
			}
		}

		// Token: 0x04005ABA RID: 23226
		[Nullable(2)]
		protected new IHeadStyleNormal FbInstance;

		// Token: 0x04005ABB RID: 23227
		[Nullable(2)]
		protected new IHeadStyleNormal_SetValue PocoInterface;
	}
}
