using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019BD RID: 6589
	public class IBvbRecycleHandCard : IBvbPlayerOperationType
	{
		// Token: 0x06008C13 RID: 35859 RVA: 0x0014BDFC File Offset: 0x00149FFC
		private IBvbRecycleHandCard_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBvbRecycleHandCard 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBvbRecycleHandCard_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBvbRecycleHandCard_SetValue());
			}
			return result;
		}

		// Token: 0x06008C14 RID: 35860 RVA: 0x0014BE34 File Offset: 0x0014A034
		public static IBvbRecycleHandCard Create([Nullable(2)] IBvbRecycleHandCard instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbRecycleHandCard
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008C15 RID: 35861 RVA: 0x0014BE47 File Offset: 0x0014A047
		public static IBvbRecycleHandCard CreateFromSetValue([Nullable(2)] IBvbRecycleHandCard_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBvbRecycleHandCard
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008C16 RID: 35862 RVA: 0x0014BE5A File Offset: 0x0014A05A
		public new IBvbRecycleHandCard_SetValue ToSetValue()
		{
			return new IBvbRecycleHandCard_SetValue
			{
				Type = this.Type,
				HandCardIndex = this.HandCardIndex
			};
		}

		// Token: 0x17002D7A RID: 11642
		// (get) Token: 0x06008C17 RID: 35863 RVA: 0x0014BE79 File Offset: 0x0014A079
		// (set) Token: 0x06008C18 RID: 35864 RVA: 0x0014BEA4 File Offset: 0x0014A0A4
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

		// Token: 0x17002D7B RID: 11643
		// (get) Token: 0x06008C19 RID: 35865 RVA: 0x0014BEB4 File Offset: 0x0014A0B4
		// (set) Token: 0x06008C1A RID: 35866 RVA: 0x0014BEEE File Offset: 0x0014A0EE
		public virtual int? HandCardIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HandCardIndex;
				}
				IBvbRecycleHandCard_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04005855 RID: 22613
		[Nullable(2)]
		protected new IBvbRecycleHandCard FbInstance;

		// Token: 0x04005856 RID: 22614
		[Nullable(2)]
		protected new IBvbRecycleHandCard_SetValue PocoInterface;
	}
}
