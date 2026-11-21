using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002320 RID: 8992
	public class LimitPlayerOperation : ActionParams
	{
		// Token: 0x0600C3DA RID: 50138 RVA: 0x001C1A8C File Offset: 0x001BFC8C
		private LimitPlayerOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("LimitPlayerOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			LimitPlayerOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new LimitPlayerOperation_SetValue());
			}
			return result;
		}

		// Token: 0x0600C3DB RID: 50139 RVA: 0x001C1AC4 File Offset: 0x001BFCC4
		public static LimitPlayerOperation Create([Nullable(2)] LimitPlayerOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LimitPlayerOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C3DC RID: 50140 RVA: 0x001C1AD7 File Offset: 0x001BFCD7
		public static LimitPlayerOperation CreateFromSetValue([Nullable(2)] LimitPlayerOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new LimitPlayerOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C3DD RID: 50141 RVA: 0x001C1AEA File Offset: 0x001BFCEA
		public LimitPlayerOperation_SetValue ToSetValue()
		{
			return new LimitPlayerOperation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003B4D RID: 15181
		// (get) Token: 0x0600C3DE RID: 50142 RVA: 0x001C1AFD File Offset: 0x001BFCFD
		// (set) Token: 0x0600C3DF RID: 50143 RVA: 0x001C1B24 File Offset: 0x001BFD24
		public virtual ILimitPlayerOption Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				LimitPlayerOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040074B0 RID: 29872
		[Nullable(2)]
		protected new LimitPlayerOperation FbInstance;

		// Token: 0x040074B1 RID: 29873
		[Nullable(2)]
		protected LimitPlayerOperation_SetValue PocoInterface;
	}
}
