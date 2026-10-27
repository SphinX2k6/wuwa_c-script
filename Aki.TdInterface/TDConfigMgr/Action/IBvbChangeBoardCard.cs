using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001824 RID: 6180
	[NullableContext(2)]
	[Nullable(0)]
	public class IBvbChangeBoardCard : IBvbPlayerOperationType
	{
		// Token: 0x0600849F RID: 33951 RVA: 0x0013BD88 File Offset: 0x00139F88
		[NullableContext(1)]
		private IBvbChangeBoardCard_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBvbChangeBoardCard 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBvbChangeBoardCard_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBvbChangeBoardCard_SetValue());
			}
			return result;
		}

		// Token: 0x060084A0 RID: 33952 RVA: 0x0013BDC0 File Offset: 0x00139FC0
		[NullableContext(1)]
		public static IBvbChangeBoardCard Create([Nullable(2)] IBvbChangeBoardCard instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbChangeBoardCard
			{
				FbInstance = instance
			};
		}

		// Token: 0x060084A1 RID: 33953 RVA: 0x0013BDD3 File Offset: 0x00139FD3
		[NullableContext(1)]
		public static IBvbChangeBoardCard CreateFromSetValue([Nullable(2)] IBvbChangeBoardCard_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBvbChangeBoardCard
			{
				PocoInterface = value
			};
		}

		// Token: 0x060084A2 RID: 33954 RVA: 0x0013BDE6 File Offset: 0x00139FE6
		[NullableContext(1)]
		public new IBvbChangeBoardCard_SetValue ToSetValue()
		{
			return new IBvbChangeBoardCard_SetValue
			{
				Type = this.Type,
				BoardPosIndex = this.BoardPosIndex,
				BoardPosIndexList = this.BoardPosIndexList
			};
		}

		// Token: 0x17002B6E RID: 11118
		// (get) Token: 0x060084A3 RID: 33955 RVA: 0x0013BE11 File Offset: 0x0013A011
		// (set) Token: 0x060084A4 RID: 33956 RVA: 0x0013BE3C File Offset: 0x0013A03C
		public override EBvbPlayerOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBvbPlayerOperationType.BvbDeploy;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002B6F RID: 11119
		// (get) Token: 0x060084A5 RID: 33957 RVA: 0x0013BE4C File Offset: 0x0013A04C
		// (set) Token: 0x060084A6 RID: 33958 RVA: 0x0013BE86 File Offset: 0x0013A086
		public virtual int? BoardPosIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BoardPosIndex;
				}
				IBvbChangeBoardCard_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BoardPosIndex;
			}
			set
			{
				this.GetOrCreatePoco().BoardPosIndex = value;
			}
		}

		// Token: 0x17002B70 RID: 11120
		// (get) Token: 0x060084A7 RID: 33959 RVA: 0x0013BE94 File Offset: 0x0013A094
		// (set) Token: 0x060084A8 RID: 33960 RVA: 0x0013BEBB File Offset: 0x0013A0BB
		public virtual List<int> BoardPosIndexList
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BoardPosIndexList;
				}
				IBvbChangeBoardCard_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BoardPosIndexList;
			}
			set
			{
				this.GetOrCreatePoco().BoardPosIndexList = value;
			}
		}

		// Token: 0x040053E9 RID: 21481
		protected new IBvbChangeBoardCard FbInstance;

		// Token: 0x040053EA RID: 21482
		protected new IBvbChangeBoardCard_SetValue PocoInterface;
	}
}
