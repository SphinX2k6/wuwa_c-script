using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001993 RID: 6547
	public class IBehaviorTreeFragmentContext : IVarContext
	{
		// Token: 0x06008B35 RID: 35637 RVA: 0x0014A5C0 File Offset: 0x001487C0
		private IBehaviorTreeFragmentContext_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBehaviorTreeFragmentContext 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBehaviorTreeFragmentContext_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBehaviorTreeFragmentContext_SetValue());
			}
			return result;
		}

		// Token: 0x06008B36 RID: 35638 RVA: 0x0014A5F8 File Offset: 0x001487F8
		public static IBehaviorTreeFragmentContext Create([Nullable(2)] IBehaviorTreeFragmentContext instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBehaviorTreeFragmentContext
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008B37 RID: 35639 RVA: 0x0014A60B File Offset: 0x0014880B
		public static IBehaviorTreeFragmentContext CreateFromSetValue([Nullable(2)] IBehaviorTreeFragmentContext_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBehaviorTreeFragmentContext
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008B38 RID: 35640 RVA: 0x0014A61E File Offset: 0x0014881E
		public new IBehaviorTreeFragmentContext_SetValue ToSetValue()
		{
			return new IBehaviorTreeFragmentContext_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17002D4A RID: 11594
		// (get) Token: 0x06008B39 RID: 35641 RVA: 0x0014A63D File Offset: 0x0014883D
		// (set) Token: 0x06008B3A RID: 35642 RVA: 0x0014A668 File Offset: 0x00148868
		public override EVarContext Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return (EVarContext)0;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002D4B RID: 11595
		// (get) Token: 0x06008B3B RID: 35643 RVA: 0x0014A676 File Offset: 0x00148876
		// (set) Token: 0x06008B3C RID: 35644 RVA: 0x0014A6A1 File Offset: 0x001488A1
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x040057F3 RID: 22515
		[Nullable(2)]
		protected new IBehaviorTreeFragmentContext FbInstance;

		// Token: 0x040057F4 RID: 22516
		[Nullable(2)]
		protected new IBehaviorTreeFragmentContext_SetValue PocoInterface;
	}
}
