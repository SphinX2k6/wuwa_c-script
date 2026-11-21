using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A55 RID: 6741
	public class IClientModifyTarget
	{
		// Token: 0x06008F49 RID: 36681 RVA: 0x00151B70 File Offset: 0x0014FD70
		private IClientModifyTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientModifyTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientModifyTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientModifyTarget_SetValue());
			}
			return result;
		}

		// Token: 0x06008F4A RID: 36682 RVA: 0x00151BA8 File Offset: 0x0014FDA8
		public static IClientModifyTarget Create([Nullable(2)] IClientModifyTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientModifyTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008F4B RID: 36683 RVA: 0x00151BBB File Offset: 0x0014FDBB
		public static IClientModifyTarget CreateFromSetValue([Nullable(2)] IClientModifyTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientModifyTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008F4C RID: 36684 RVA: 0x00151BCE File Offset: 0x0014FDCE
		public IClientModifyTarget_SetValue ToSetValue()
		{
			return new IClientModifyTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E31 RID: 11825
		// (get) Token: 0x06008F4D RID: 36685 RVA: 0x00151BE1 File Offset: 0x0014FDE1
		// (set) Token: 0x06008F4E RID: 36686 RVA: 0x00151C0C File Offset: 0x0014FE0C
		public virtual EClientModifyTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EClientModifyTargetType.Self;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040059D6 RID: 22998
		[Nullable(2)]
		protected IClientModifyTarget FbInstance;

		// Token: 0x040059D7 RID: 22999
		[Nullable(2)]
		protected IClientModifyTarget_SetValue PocoInterface;
	}
}
