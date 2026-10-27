using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200200A RID: 8202
	[NullableContext(1)]
	[Nullable(0)]
	public class ITuningStandGridBoard
	{
		// Token: 0x0600B468 RID: 46184 RVA: 0x001A38C4 File Offset: 0x001A1AC4
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

		// Token: 0x0600B469 RID: 46185 RVA: 0x001A38FC File Offset: 0x001A1AFC
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

		// Token: 0x0600B46A RID: 46186 RVA: 0x001A390F File Offset: 0x001A1B0F
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

		// Token: 0x0600B46B RID: 46187 RVA: 0x001A3922 File Offset: 0x001A1B22
		public ITuningStandGridBoard_SetValue ToSetValue()
		{
			return new ITuningStandGridBoard_SetValue
			{
				Grids = this.Grids
			};
		}

		// Token: 0x1700377D RID: 14205
		// (get) Token: 0x0600B46C RID: 46188 RVA: 0x001A3935 File Offset: 0x001A1B35
		// (set) Token: 0x0600B46D RID: 46189 RVA: 0x001A395C File Offset: 0x001A1B5C
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

		// Token: 0x04006CBC RID: 27836
		[Nullable(2)]
		protected ITuningStandGridBoard FbInstance;

		// Token: 0x04006CBD RID: 27837
		[Nullable(2)]
		protected ITuningStandGridBoard_SetValue PocoInterface;
	}
}
