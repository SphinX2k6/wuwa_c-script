using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A83 RID: 6787
	public class ICommonBtContext : IVarContext
	{
		// Token: 0x0600902B RID: 36907 RVA: 0x0015334C File Offset: 0x0015154C
		private ICommonBtContext_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonBtContext 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonBtContext_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonBtContext_SetValue());
			}
			return result;
		}

		// Token: 0x0600902C RID: 36908 RVA: 0x00153384 File Offset: 0x00151584
		public static ICommonBtContext Create([Nullable(2)] ICommonBtContext instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonBtContext
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600902D RID: 36909 RVA: 0x00153397 File Offset: 0x00151597
		public static ICommonBtContext CreateFromSetValue([Nullable(2)] ICommonBtContext_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonBtContext
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600902E RID: 36910 RVA: 0x001533AA File Offset: 0x001515AA
		public new ICommonBtContext_SetValue ToSetValue()
		{
			return new ICommonBtContext_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17002E5D RID: 11869
		// (get) Token: 0x0600902F RID: 36911 RVA: 0x001533C9 File Offset: 0x001515C9
		// (set) Token: 0x06009030 RID: 36912 RVA: 0x001533F4 File Offset: 0x001515F4
		public override EVarContext Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return (EVarContext)0;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002E5E RID: 11870
		// (get) Token: 0x06009031 RID: 36913 RVA: 0x00153402 File Offset: 0x00151602
		// (set) Token: 0x06009032 RID: 36914 RVA: 0x0015342D File Offset: 0x0015162D
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x04005A38 RID: 23096
		[Nullable(2)]
		protected new ICommonBtContext FbInstance;

		// Token: 0x04005A39 RID: 23097
		[Nullable(2)]
		protected new ICommonBtContext_SetValue PocoInterface;
	}
}
