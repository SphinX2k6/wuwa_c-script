using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019AF RID: 6575
	public class IBvbChangeBoardCard : IBvbPlayerOperationType
	{
		// Token: 0x06008BC5 RID: 35781 RVA: 0x0014B57C File Offset: 0x0014977C
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

		// Token: 0x06008BC6 RID: 35782 RVA: 0x0014B5B4 File Offset: 0x001497B4
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

		// Token: 0x06008BC7 RID: 35783 RVA: 0x0014B5C7 File Offset: 0x001497C7
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

		// Token: 0x06008BC8 RID: 35784 RVA: 0x0014B5DA File Offset: 0x001497DA
		public new IBvbChangeBoardCard_SetValue ToSetValue()
		{
			return new IBvbChangeBoardCard_SetValue
			{
				Type = this.Type,
				BoardPosIndex = this.BoardPosIndex,
				BoardPosIndexList = this.BoardPosIndexList
			};
		}

		// Token: 0x17002D68 RID: 11624
		// (get) Token: 0x06008BC9 RID: 35785 RVA: 0x0014B605 File Offset: 0x00149805
		// (set) Token: 0x06008BCA RID: 35786 RVA: 0x0014B630 File Offset: 0x00149830
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

		// Token: 0x17002D69 RID: 11625
		// (get) Token: 0x06008BCB RID: 35787 RVA: 0x0014B640 File Offset: 0x00149840
		// (set) Token: 0x06008BCC RID: 35788 RVA: 0x0014B67A File Offset: 0x0014987A
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

		// Token: 0x17002D6A RID: 11626
		// (get) Token: 0x06008BCD RID: 35789 RVA: 0x0014B688 File Offset: 0x00149888
		// (set) Token: 0x06008BCE RID: 35790 RVA: 0x0014B6AF File Offset: 0x001498AF
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
				IBvbChangeBoardCard_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04005835 RID: 22581
		[Nullable(2)]
		protected new IBvbChangeBoardCard FbInstance;

		// Token: 0x04005836 RID: 22582
		[Nullable(2)]
		protected new IBvbChangeBoardCard_SetValue PocoInterface;
	}
}
