using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EEB RID: 7915
	public class IPhoneBoardTypeBase
	{
		// Token: 0x0600A87D RID: 43133 RVA: 0x0017EDA0 File Offset: 0x0017CFA0
		private IPhoneBoardTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPhoneBoardTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPhoneBoardTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPhoneBoardTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600A87E RID: 43134 RVA: 0x0017EDD8 File Offset: 0x0017CFD8
		public static IPhoneBoardTypeBase Create([Nullable(2)] IPhoneBoardTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhoneBoardTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A87F RID: 43135 RVA: 0x0017EDEB File Offset: 0x0017CFEB
		public static IPhoneBoardTypeBase CreateFromSetValue([Nullable(2)] IPhoneBoardTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPhoneBoardTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A880 RID: 43136 RVA: 0x0017EDFE File Offset: 0x0017CFFE
		public IPhoneBoardTypeBase_SetValue ToSetValue()
		{
			return new IPhoneBoardTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170033EC RID: 13292
		// (get) Token: 0x0600A881 RID: 43137 RVA: 0x0017EE11 File Offset: 0x0017D011
		// (set) Token: 0x0600A882 RID: 43138 RVA: 0x0017EE3C File Offset: 0x0017D03C
		public virtual EPhoneBoardType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPhoneBoardType.MessageBoard;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006549 RID: 25929
		[Nullable(2)]
		protected IPhoneBoardTypeBase FbInstance;

		// Token: 0x0400654A RID: 25930
		[Nullable(2)]
		protected IPhoneBoardTypeBase_SetValue PocoInterface;
	}
}
