using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200170F RID: 5903
	[NullableContext(1)]
	[Nullable(0)]
	public class ExecResurrection : ActionParams
	{
		// Token: 0x06007D17 RID: 32023 RVA: 0x0012C538 File Offset: 0x0012A738
		private ExecResurrection_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ExecResurrection 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ExecResurrection_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ExecResurrection_SetValue());
			}
			return result;
		}

		// Token: 0x06007D18 RID: 32024 RVA: 0x0012C570 File Offset: 0x0012A770
		public static ExecResurrection Create([Nullable(2)] ExecResurrection instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExecResurrection
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007D19 RID: 32025 RVA: 0x0012C583 File Offset: 0x0012A783
		public static ExecResurrection CreateFromSetValue([Nullable(2)] ExecResurrection_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ExecResurrection
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007D1A RID: 32026 RVA: 0x0012C596 File Offset: 0x0012A796
		public ExecResurrection_SetValue ToSetValue()
		{
			return new ExecResurrection_SetValue
			{
				ReviveId = this.ReviveId
			};
		}

		// Token: 0x17002944 RID: 10564
		// (get) Token: 0x06007D1B RID: 32027 RVA: 0x0012C5A9 File Offset: 0x0012A7A9
		// (set) Token: 0x06007D1C RID: 32028 RVA: 0x0012C5D4 File Offset: 0x0012A7D4
		public virtual int ReviveId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ReviveId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ReviveId;
			}
			set
			{
				this.GetOrCreatePoco().ReviveId = value;
			}
		}

		// Token: 0x04004FE2 RID: 20450
		[Nullable(2)]
		protected new ExecResurrection FbInstance;

		// Token: 0x04004FE3 RID: 20451
		[Nullable(2)]
		protected ExecResurrection_SetValue PocoInterface;
	}
}
