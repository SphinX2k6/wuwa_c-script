using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F05 RID: 7941
	public class IPieceIndex
	{
		// Token: 0x0600A8FD RID: 43261 RVA: 0x0017FC88 File Offset: 0x0017DE88
		private IPieceIndex_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPieceIndex 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPieceIndex_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPieceIndex_SetValue());
			}
			return result;
		}

		// Token: 0x0600A8FE RID: 43262 RVA: 0x0017FCC0 File Offset: 0x0017DEC0
		public static IPieceIndex Create([Nullable(2)] IPieceIndex instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPieceIndex
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A8FF RID: 43263 RVA: 0x0017FCD3 File Offset: 0x0017DED3
		public static IPieceIndex CreateFromSetValue([Nullable(2)] IPieceIndex_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPieceIndex
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A900 RID: 43264 RVA: 0x0017FCE6 File Offset: 0x0017DEE6
		public IPieceIndex_SetValue ToSetValue()
		{
			return new IPieceIndex_SetValue
			{
				RowIndex = this.RowIndex,
				ColumnIndex = this.ColumnIndex
			};
		}

		// Token: 0x17003405 RID: 13317
		// (get) Token: 0x0600A901 RID: 43265 RVA: 0x0017FD05 File Offset: 0x0017DF05
		// (set) Token: 0x0600A902 RID: 43266 RVA: 0x0017FD30 File Offset: 0x0017DF30
		public virtual int RowIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RowIndex;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RowIndex;
			}
			set
			{
				this.GetOrCreatePoco().RowIndex = value;
			}
		}

		// Token: 0x17003406 RID: 13318
		// (get) Token: 0x0600A903 RID: 43267 RVA: 0x0017FD3E File Offset: 0x0017DF3E
		// (set) Token: 0x0600A904 RID: 43268 RVA: 0x0017FD69 File Offset: 0x0017DF69
		public virtual int ColumnIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ColumnIndex;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ColumnIndex;
			}
			set
			{
				this.GetOrCreatePoco().ColumnIndex = value;
			}
		}

		// Token: 0x0400658A RID: 25994
		[Nullable(2)]
		protected IPieceIndex FbInstance;

		// Token: 0x0400658B RID: 25995
		[Nullable(2)]
		protected IPieceIndex_SetValue PocoInterface;
	}
}
