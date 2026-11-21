using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002251 RID: 8785
	public class ITuningStandGridBoard
	{
		// Token: 0x0600BF80 RID: 49024 RVA: 0x001B9E88 File Offset: 0x001B8088
		private ITuningStandGridBoard_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITuningStandGridBoard 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITuningStandGridBoard_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITuningStandGridBoard_SetValue());
			}
			return result;
		}

		// Token: 0x0600BF81 RID: 49025 RVA: 0x001B9EC0 File Offset: 0x001B80C0
		public static ITuningStandGridBoard Create([Nullable(2)] ITuningStandGridBoard instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITuningStandGridBoard
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BF82 RID: 49026 RVA: 0x001B9ED3 File Offset: 0x001B80D3
		public static ITuningStandGridBoard CreateFromSetValue([Nullable(2)] ITuningStandGridBoard_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITuningStandGridBoard
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BF83 RID: 49027 RVA: 0x001B9EE6 File Offset: 0x001B80E6
		public ITuningStandGridBoard_SetValue ToSetValue()
		{
			return new ITuningStandGridBoard_SetValue
			{
				Grids = this.Grids
			};
		}

		// Token: 0x17003A56 RID: 14934
		// (get) Token: 0x0600BF84 RID: 49028 RVA: 0x001B9EF9 File Offset: 0x001B80F9
		// (set) Token: 0x0600BF85 RID: 49029 RVA: 0x001B9F20 File Offset: 0x001B8120
		public virtual List<ETuningStandGridType> Grids
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Grids;
				}
				ITuningStandGridBoard_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Grids;
			}
			set
			{
				this.GetOrCreatePoco().Grids = value;
			}
		}

		// Token: 0x040072BF RID: 29375
		[Nullable(2)]
		protected ITuningStandGridBoard FbInstance;

		// Token: 0x040072C0 RID: 29376
		[Nullable(2)]
		protected ITuningStandGridBoard_SetValue PocoInterface;
	}
}
