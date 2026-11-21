using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002326 RID: 8998
	public class LiveSetSc : ActionParams
	{
		// Token: 0x0600C3F2 RID: 50162 RVA: 0x001C1CB4 File Offset: 0x001BFEB4
		private LiveSetSc_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("LiveSetSc 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			LiveSetSc_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new LiveSetSc_SetValue());
			}
			return result;
		}

		// Token: 0x0600C3F3 RID: 50163 RVA: 0x001C1CEC File Offset: 0x001BFEEC
		public static LiveSetSc Create([Nullable(2)] LiveSetSc instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LiveSetSc
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C3F4 RID: 50164 RVA: 0x001C1CFF File Offset: 0x001BFEFF
		public static LiveSetSc CreateFromSetValue([Nullable(2)] LiveSetSc_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new LiveSetSc
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C3F5 RID: 50165 RVA: 0x001C1D12 File Offset: 0x001BFF12
		public LiveSetSc_SetValue ToSetValue()
		{
			return new LiveSetSc_SetValue
			{
				Operation = this.Operation
			};
		}

		// Token: 0x17003B50 RID: 15184
		// (get) Token: 0x0600C3F6 RID: 50166 RVA: 0x001C1D25 File Offset: 0x001BFF25
		// (set) Token: 0x0600C3F7 RID: 50167 RVA: 0x001C1D4C File Offset: 0x001BFF4C
		public virtual ILiveScOperation Operation
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Operation;
				}
				LiveSetSc_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Operation;
			}
			set
			{
				this.GetOrCreatePoco().Operation = value;
			}
		}

		// Token: 0x040074B9 RID: 29881
		[Nullable(2)]
		protected new LiveSetSc FbInstance;

		// Token: 0x040074BA RID: 29882
		[Nullable(2)]
		protected LiveSetSc_SetValue PocoInterface;
	}
}
