using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001830 RID: 6192
	[NullableContext(2)]
	[Nullable(0)]
	public class IBvbRecycleBoardCard : IBvbPlayerOperationType
	{
		// Token: 0x060084E1 RID: 34017 RVA: 0x0013C4B4 File Offset: 0x0013A6B4
		[NullableContext(1)]
		private IBvbRecycleBoardCard_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBvbRecycleBoardCard 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBvbRecycleBoardCard_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBvbRecycleBoardCard_SetValue());
			}
			return result;
		}

		// Token: 0x060084E2 RID: 34018 RVA: 0x0013C4EC File Offset: 0x0013A6EC
		[NullableContext(1)]
		public static IBvbRecycleBoardCard Create([Nullable(2)] IBvbRecycleBoardCard instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbRecycleBoardCard
			{
				FbInstance = instance
			};
		}

		// Token: 0x060084E3 RID: 34019 RVA: 0x0013C4FF File Offset: 0x0013A6FF
		[NullableContext(1)]
		public static IBvbRecycleBoardCard CreateFromSetValue([Nullable(2)] IBvbRecycleBoardCard_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBvbRecycleBoardCard
			{
				PocoInterface = value
			};
		}

		// Token: 0x060084E4 RID: 34020 RVA: 0x0013C512 File Offset: 0x0013A712
		[NullableContext(1)]
		public new IBvbRecycleBoardCard_SetValue ToSetValue()
		{
			return new IBvbRecycleBoardCard_SetValue
			{
				Type = this.Type,
				BoardPosIndex = this.BoardPosIndex,
				BoardPosIndexList = this.BoardPosIndexList
			};
		}

		// Token: 0x17002B7D RID: 11133
		// (get) Token: 0x060084E5 RID: 34021 RVA: 0x0013C53D File Offset: 0x0013A73D
		// (set) Token: 0x060084E6 RID: 34022 RVA: 0x0013C568 File Offset: 0x0013A768
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

		// Token: 0x17002B7E RID: 11134
		// (get) Token: 0x060084E7 RID: 34023 RVA: 0x0013C578 File Offset: 0x0013A778
		// (set) Token: 0x060084E8 RID: 34024 RVA: 0x0013C5B2 File Offset: 0x0013A7B2
		public virtual int? BoardPosIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BoardPosIndex;
				}
				IBvbRecycleBoardCard_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002B7F RID: 11135
		// (get) Token: 0x060084E9 RID: 34025 RVA: 0x0013C5C0 File Offset: 0x0013A7C0
		// (set) Token: 0x060084EA RID: 34026 RVA: 0x0013C5E7 File Offset: 0x0013A7E7
		public virtual List<int> BoardPosIndexList
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BoardPosIndexList;
				}
				IBvbRecycleBoardCard_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04005404 RID: 21508
		protected new IBvbRecycleBoardCard FbInstance;

		// Token: 0x04005405 RID: 21509
		protected new IBvbRecycleBoardCard_SetValue PocoInterface;
	}
}
