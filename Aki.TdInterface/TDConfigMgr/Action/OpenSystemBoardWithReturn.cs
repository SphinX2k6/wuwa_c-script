using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002353 RID: 9043
	public class OpenSystemBoardWithReturn : ActionParams
	{
		// Token: 0x0600C524 RID: 50468 RVA: 0x001C43CC File Offset: 0x001C25CC
		private OpenSystemBoardWithReturn_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("OpenSystemBoardWithReturn 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			OpenSystemBoardWithReturn_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new OpenSystemBoardWithReturn_SetValue());
			}
			return result;
		}

		// Token: 0x0600C525 RID: 50469 RVA: 0x001C4404 File Offset: 0x001C2604
		public static OpenSystemBoardWithReturn Create([Nullable(2)] OpenSystemBoardWithReturn instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new OpenSystemBoardWithReturn
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C526 RID: 50470 RVA: 0x001C4417 File Offset: 0x001C2617
		public static OpenSystemBoardWithReturn CreateFromSetValue([Nullable(2)] OpenSystemBoardWithReturn_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new OpenSystemBoardWithReturn
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C527 RID: 50471 RVA: 0x001C442A File Offset: 0x001C262A
		public OpenSystemBoardWithReturn_SetValue ToSetValue()
		{
			return new OpenSystemBoardWithReturn_SetValue
			{
				SystemType = this.SystemType
			};
		}

		// Token: 0x17003BA6 RID: 15270
		// (get) Token: 0x0600C528 RID: 50472 RVA: 0x001C443D File Offset: 0x001C263D
		// (set) Token: 0x0600C529 RID: 50473 RVA: 0x001C4464 File Offset: 0x001C2664
		public virtual IOpenSystemBoardWithReturnType SystemType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SystemType;
				}
				OpenSystemBoardWithReturn_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SystemType;
			}
			set
			{
				this.GetOrCreatePoco().SystemType = value;
			}
		}

		// Token: 0x0400755E RID: 30046
		[Nullable(2)]
		protected new OpenSystemBoardWithReturn FbInstance;

		// Token: 0x0400755F RID: 30047
		[Nullable(2)]
		protected OpenSystemBoardWithReturn_SetValue PocoInterface;
	}
}
