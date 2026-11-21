using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002322 RID: 8994
	public class LiveSetDanmaku : ActionParams
	{
		// Token: 0x0600C3E2 RID: 50146 RVA: 0x001C1B44 File Offset: 0x001BFD44
		private LiveSetDanmaku_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("LiveSetDanmaku 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			LiveSetDanmaku_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new LiveSetDanmaku_SetValue());
			}
			return result;
		}

		// Token: 0x0600C3E3 RID: 50147 RVA: 0x001C1B7C File Offset: 0x001BFD7C
		public static LiveSetDanmaku Create([Nullable(2)] LiveSetDanmaku instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LiveSetDanmaku
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C3E4 RID: 50148 RVA: 0x001C1B8F File Offset: 0x001BFD8F
		public static LiveSetDanmaku CreateFromSetValue([Nullable(2)] LiveSetDanmaku_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new LiveSetDanmaku
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C3E5 RID: 50149 RVA: 0x001C1BA2 File Offset: 0x001BFDA2
		public LiveSetDanmaku_SetValue ToSetValue()
		{
			return new LiveSetDanmaku_SetValue
			{
				Operation = this.Operation
			};
		}

		// Token: 0x17003B4E RID: 15182
		// (get) Token: 0x0600C3E6 RID: 50150 RVA: 0x001C1BB5 File Offset: 0x001BFDB5
		// (set) Token: 0x0600C3E7 RID: 50151 RVA: 0x001C1BDC File Offset: 0x001BFDDC
		public virtual ILiveDanmakuOperation Operation
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Operation;
				}
				LiveSetDanmaku_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040074B3 RID: 29875
		[Nullable(2)]
		protected new LiveSetDanmaku FbInstance;

		// Token: 0x040074B4 RID: 29876
		[Nullable(2)]
		protected LiveSetDanmaku_SetValue PocoInterface;
	}
}
