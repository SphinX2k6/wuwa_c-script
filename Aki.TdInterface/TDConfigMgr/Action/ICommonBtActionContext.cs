using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A7F RID: 6783
	public class ICommonBtActionContext : IActionContextType
	{
		// Token: 0x06009019 RID: 36889 RVA: 0x00153190 File Offset: 0x00151390
		private ICommonBtActionContext_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonBtActionContext 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonBtActionContext_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonBtActionContext_SetValue());
			}
			return result;
		}

		// Token: 0x0600901A RID: 36890 RVA: 0x001531C8 File Offset: 0x001513C8
		public static ICommonBtActionContext Create([Nullable(2)] ICommonBtActionContext instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonBtActionContext
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600901B RID: 36891 RVA: 0x001531DB File Offset: 0x001513DB
		public static ICommonBtActionContext CreateFromSetValue([Nullable(2)] ICommonBtActionContext_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonBtActionContext
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600901C RID: 36892 RVA: 0x001531EE File Offset: 0x001513EE
		public new ICommonBtActionContext_SetValue ToSetValue()
		{
			return new ICommonBtActionContext_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E5A RID: 11866
		// (get) Token: 0x0600901D RID: 36893 RVA: 0x00153201 File Offset: 0x00151401
		// (set) Token: 0x0600901E RID: 36894 RVA: 0x0015322C File Offset: 0x0015142C
		public new virtual string Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005A31 RID: 23089
		[Nullable(2)]
		protected new ICommonBtActionContext FbInstance;

		// Token: 0x04005A32 RID: 23090
		[Nullable(2)]
		protected new ICommonBtActionContext_SetValue PocoInterface;
	}
}
