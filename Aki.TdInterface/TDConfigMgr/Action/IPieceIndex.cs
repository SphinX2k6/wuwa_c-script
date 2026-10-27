using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CF6 RID: 7414
	[NullableContext(1)]
	[Nullable(0)]
	public class IPieceIndex
	{
		// Token: 0x06009F1D RID: 40733 RVA: 0x0016BA28 File Offset: 0x00169C28
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

		// Token: 0x06009F1E RID: 40734 RVA: 0x0016BA60 File Offset: 0x00169C60
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

		// Token: 0x06009F1F RID: 40735 RVA: 0x0016BA73 File Offset: 0x00169C73
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

		// Token: 0x06009F20 RID: 40736 RVA: 0x0016BA86 File Offset: 0x00169C86
		public IPieceIndex_SetValue ToSetValue()
		{
			return new IPieceIndex_SetValue
			{
				RowIndex = this.RowIndex,
				ColumnIndex = this.ColumnIndex
			};
		}

		// Token: 0x17003174 RID: 12660
		// (get) Token: 0x06009F21 RID: 40737 RVA: 0x0016BAA5 File Offset: 0x00169CA5
		// (set) Token: 0x06009F22 RID: 40738 RVA: 0x0016BAD0 File Offset: 0x00169CD0
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

		// Token: 0x17003175 RID: 12661
		// (get) Token: 0x06009F23 RID: 40739 RVA: 0x0016BADE File Offset: 0x00169CDE
		// (set) Token: 0x06009F24 RID: 40740 RVA: 0x0016BB09 File Offset: 0x00169D09
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

		// Token: 0x04006017 RID: 24599
		[Nullable(2)]
		protected IPieceIndex FbInstance;

		// Token: 0x04006018 RID: 24600
		[Nullable(2)]
		protected IPieceIndex_SetValue PocoInterface;
	}
}
