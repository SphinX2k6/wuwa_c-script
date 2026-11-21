using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019B3 RID: 6579
	public class IBvbDeploy : IBvbPlayerOperationType
	{
		// Token: 0x06008BDB RID: 35803 RVA: 0x0014B7E0 File Offset: 0x001499E0
		private IBvbDeploy_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBvbDeploy 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBvbDeploy_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBvbDeploy_SetValue());
			}
			return result;
		}

		// Token: 0x06008BDC RID: 35804 RVA: 0x0014B818 File Offset: 0x00149A18
		public static IBvbDeploy Create([Nullable(2)] IBvbDeploy instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbDeploy
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008BDD RID: 35805 RVA: 0x0014B82B File Offset: 0x00149A2B
		public static IBvbDeploy CreateFromSetValue([Nullable(2)] IBvbDeploy_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBvbDeploy
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008BDE RID: 35806 RVA: 0x0014B83E File Offset: 0x00149A3E
		public new IBvbDeploy_SetValue ToSetValue()
		{
			return new IBvbDeploy_SetValue
			{
				Type = this.Type,
				HandCardIndex = this.HandCardIndex,
				BoardPosIndex = this.BoardPosIndex,
				BoardPosIndexList = this.BoardPosIndexList
			};
		}

		// Token: 0x17002D6D RID: 11629
		// (get) Token: 0x06008BDF RID: 35807 RVA: 0x0014B875 File Offset: 0x00149A75
		// (set) Token: 0x06008BE0 RID: 35808 RVA: 0x0014B8A0 File Offset: 0x00149AA0
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

		// Token: 0x17002D6E RID: 11630
		// (get) Token: 0x06008BE1 RID: 35809 RVA: 0x0014B8B0 File Offset: 0x00149AB0
		// (set) Token: 0x06008BE2 RID: 35810 RVA: 0x0014B8EA File Offset: 0x00149AEA
		public virtual int? HandCardIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HandCardIndex;
				}
				IBvbDeploy_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002D6F RID: 11631
		// (get) Token: 0x06008BE3 RID: 35811 RVA: 0x0014B8F8 File Offset: 0x00149AF8
		// (set) Token: 0x06008BE4 RID: 35812 RVA: 0x0014B932 File Offset: 0x00149B32
		public virtual int? BoardPosIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BoardPosIndex;
				}
				IBvbDeploy_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002D70 RID: 11632
		// (get) Token: 0x06008BE5 RID: 35813 RVA: 0x0014B940 File Offset: 0x00149B40
		// (set) Token: 0x06008BE6 RID: 35814 RVA: 0x0014B967 File Offset: 0x00149B67
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
				IBvbDeploy_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400583E RID: 22590
		[Nullable(2)]
		protected new IBvbDeploy FbInstance;

		// Token: 0x0400583F RID: 22591
		[Nullable(2)]
		protected new IBvbDeploy_SetValue PocoInterface;
	}
}
