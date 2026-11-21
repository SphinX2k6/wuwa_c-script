using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019BF RID: 6591
	public class IBvbSelectCard : IBvbPlayerOperationType
	{
		// Token: 0x06008C1D RID: 35869 RVA: 0x0014BF0C File Offset: 0x0014A10C
		private IBvbSelectCard_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBvbSelectCard 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBvbSelectCard_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBvbSelectCard_SetValue());
			}
			return result;
		}

		// Token: 0x06008C1E RID: 35870 RVA: 0x0014BF44 File Offset: 0x0014A144
		public static IBvbSelectCard Create([Nullable(2)] IBvbSelectCard instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbSelectCard
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008C1F RID: 35871 RVA: 0x0014BF57 File Offset: 0x0014A157
		public static IBvbSelectCard CreateFromSetValue([Nullable(2)] IBvbSelectCard_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBvbSelectCard
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008C20 RID: 35872 RVA: 0x0014BF6A File Offset: 0x0014A16A
		public new IBvbSelectCard_SetValue ToSetValue()
		{
			return new IBvbSelectCard_SetValue
			{
				Type = this.Type,
				CardIdList = this.CardIdList
			};
		}

		// Token: 0x17002D7C RID: 11644
		// (get) Token: 0x06008C21 RID: 35873 RVA: 0x0014BF89 File Offset: 0x0014A189
		// (set) Token: 0x06008C22 RID: 35874 RVA: 0x0014BFB4 File Offset: 0x0014A1B4
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

		// Token: 0x17002D7D RID: 11645
		// (get) Token: 0x06008C23 RID: 35875 RVA: 0x0014BFC2 File Offset: 0x0014A1C2
		// (set) Token: 0x06008C24 RID: 35876 RVA: 0x0014BFE9 File Offset: 0x0014A1E9
		[Nullable(2)]
		public virtual List<int> CardIdList
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CardIdList;
				}
				IBvbSelectCard_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CardIdList;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().CardIdList = value;
			}
		}

		// Token: 0x04005859 RID: 22617
		[Nullable(2)]
		protected new IBvbSelectCard FbInstance;

		// Token: 0x0400585A RID: 22618
		[Nullable(2)]
		protected new IBvbSelectCard_SetValue PocoInterface;
	}
}
