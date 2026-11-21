using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019B7 RID: 6583
	public class IBvbEvolution : IBvbPlayerOperationType
	{
		// Token: 0x06008BF1 RID: 35825 RVA: 0x0014BA44 File Offset: 0x00149C44
		private IBvbEvolution_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBvbEvolution 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBvbEvolution_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBvbEvolution_SetValue());
			}
			return result;
		}

		// Token: 0x06008BF2 RID: 35826 RVA: 0x0014BA7C File Offset: 0x00149C7C
		public static IBvbEvolution Create([Nullable(2)] IBvbEvolution instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbEvolution
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008BF3 RID: 35827 RVA: 0x0014BA8F File Offset: 0x00149C8F
		public static IBvbEvolution CreateFromSetValue([Nullable(2)] IBvbEvolution_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBvbEvolution
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008BF4 RID: 35828 RVA: 0x0014BAA2 File Offset: 0x00149CA2
		public new IBvbEvolution_SetValue ToSetValue()
		{
			return new IBvbEvolution_SetValue
			{
				Type = this.Type,
				HandCardIndex = this.HandCardIndex,
				BoardPosIndex = this.BoardPosIndex,
				BoardPosIndexList = this.BoardPosIndexList
			};
		}

		// Token: 0x17002D72 RID: 11634
		// (get) Token: 0x06008BF5 RID: 35829 RVA: 0x0014BAD9 File Offset: 0x00149CD9
		// (set) Token: 0x06008BF6 RID: 35830 RVA: 0x0014BB04 File Offset: 0x00149D04
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

		// Token: 0x17002D73 RID: 11635
		// (get) Token: 0x06008BF7 RID: 35831 RVA: 0x0014BB14 File Offset: 0x00149D14
		// (set) Token: 0x06008BF8 RID: 35832 RVA: 0x0014BB4E File Offset: 0x00149D4E
		public virtual int? HandCardIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HandCardIndex;
				}
				IBvbEvolution_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HandCardIndex;
			}
			set
			{
				this.GetOrCreatePoco().HandCardIndex = value;
			}
		}

		// Token: 0x17002D74 RID: 11636
		// (get) Token: 0x06008BF9 RID: 35833 RVA: 0x0014BB5C File Offset: 0x00149D5C
		// (set) Token: 0x06008BFA RID: 35834 RVA: 0x0014BB96 File Offset: 0x00149D96
		public virtual int? BoardPosIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BoardPosIndex;
				}
				IBvbEvolution_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002D75 RID: 11637
		// (get) Token: 0x06008BFB RID: 35835 RVA: 0x0014BBA4 File Offset: 0x00149DA4
		// (set) Token: 0x06008BFC RID: 35836 RVA: 0x0014BBCB File Offset: 0x00149DCB
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
				IBvbEvolution_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04005847 RID: 22599
		[Nullable(2)]
		protected new IBvbEvolution FbInstance;

		// Token: 0x04005848 RID: 22600
		[Nullable(2)]
		protected new IBvbEvolution_SetValue PocoInterface;
	}
}
