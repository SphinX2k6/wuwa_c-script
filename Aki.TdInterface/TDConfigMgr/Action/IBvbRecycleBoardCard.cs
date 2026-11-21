using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019BB RID: 6587
	public class IBvbRecycleBoardCard : IBvbPlayerOperationType
	{
		// Token: 0x06008C07 RID: 35847 RVA: 0x0014BCA8 File Offset: 0x00149EA8
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

		// Token: 0x06008C08 RID: 35848 RVA: 0x0014BCE0 File Offset: 0x00149EE0
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

		// Token: 0x06008C09 RID: 35849 RVA: 0x0014BCF3 File Offset: 0x00149EF3
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

		// Token: 0x06008C0A RID: 35850 RVA: 0x0014BD06 File Offset: 0x00149F06
		public new IBvbRecycleBoardCard_SetValue ToSetValue()
		{
			return new IBvbRecycleBoardCard_SetValue
			{
				Type = this.Type,
				BoardPosIndex = this.BoardPosIndex,
				BoardPosIndexList = this.BoardPosIndexList
			};
		}

		// Token: 0x17002D77 RID: 11639
		// (get) Token: 0x06008C0B RID: 35851 RVA: 0x0014BD31 File Offset: 0x00149F31
		// (set) Token: 0x06008C0C RID: 35852 RVA: 0x0014BD5C File Offset: 0x00149F5C
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

		// Token: 0x17002D78 RID: 11640
		// (get) Token: 0x06008C0D RID: 35853 RVA: 0x0014BD6C File Offset: 0x00149F6C
		// (set) Token: 0x06008C0E RID: 35854 RVA: 0x0014BDA6 File Offset: 0x00149FA6
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

		// Token: 0x17002D79 RID: 11641
		// (get) Token: 0x06008C0F RID: 35855 RVA: 0x0014BDB4 File Offset: 0x00149FB4
		// (set) Token: 0x06008C10 RID: 35856 RVA: 0x0014BDDB File Offset: 0x00149FDB
		[Nullable(2)]
		public virtual List<int> BoardPosIndexList
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().BoardPosIndexList = value;
			}
		}

		// Token: 0x04005850 RID: 22608
		[Nullable(2)]
		protected new IBvbRecycleBoardCard FbInstance;

		// Token: 0x04005851 RID: 22609
		[Nullable(2)]
		protected new IBvbRecycleBoardCard_SetValue PocoInterface;
	}
}
