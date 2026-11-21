using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019B1 RID: 6577
	public class IBvbChangeHandCard : IBvbPlayerOperationType
	{
		// Token: 0x06008BD1 RID: 35793 RVA: 0x0014B6D0 File Offset: 0x001498D0
		private IBvbChangeHandCard_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBvbChangeHandCard 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBvbChangeHandCard_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBvbChangeHandCard_SetValue());
			}
			return result;
		}

		// Token: 0x06008BD2 RID: 35794 RVA: 0x0014B708 File Offset: 0x00149908
		public static IBvbChangeHandCard Create([Nullable(2)] IBvbChangeHandCard instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbChangeHandCard
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008BD3 RID: 35795 RVA: 0x0014B71B File Offset: 0x0014991B
		public static IBvbChangeHandCard CreateFromSetValue([Nullable(2)] IBvbChangeHandCard_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBvbChangeHandCard
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008BD4 RID: 35796 RVA: 0x0014B72E File Offset: 0x0014992E
		public new IBvbChangeHandCard_SetValue ToSetValue()
		{
			return new IBvbChangeHandCard_SetValue
			{
				Type = this.Type,
				HandCardIndex = this.HandCardIndex
			};
		}

		// Token: 0x17002D6B RID: 11627
		// (get) Token: 0x06008BD5 RID: 35797 RVA: 0x0014B74D File Offset: 0x0014994D
		// (set) Token: 0x06008BD6 RID: 35798 RVA: 0x0014B778 File Offset: 0x00149978
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

		// Token: 0x17002D6C RID: 11628
		// (get) Token: 0x06008BD7 RID: 35799 RVA: 0x0014B788 File Offset: 0x00149988
		// (set) Token: 0x06008BD8 RID: 35800 RVA: 0x0014B7C2 File Offset: 0x001499C2
		public virtual int? HandCardIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HandCardIndex;
				}
				IBvbChangeHandCard_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400583A RID: 22586
		[Nullable(2)]
		protected new IBvbChangeHandCard FbInstance;

		// Token: 0x0400583B RID: 22587
		[Nullable(2)]
		protected new IBvbChangeHandCard_SetValue PocoInterface;
	}
}
