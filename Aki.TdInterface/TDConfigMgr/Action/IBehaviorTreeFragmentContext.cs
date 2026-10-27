using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001808 RID: 6152
	[NullableContext(1)]
	[Nullable(0)]
	public class IBehaviorTreeFragmentContext : IVarContext
	{
		// Token: 0x06008411 RID: 33809 RVA: 0x0013AE1C File Offset: 0x0013901C
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

		// Token: 0x06008412 RID: 33810 RVA: 0x0013AE54 File Offset: 0x00139054
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

		// Token: 0x06008413 RID: 33811 RVA: 0x0013AE67 File Offset: 0x00139067
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

		// Token: 0x06008414 RID: 33812 RVA: 0x0013AE7A File Offset: 0x0013907A
		public new IBehaviorTreeFragmentContext_SetValue ToSetValue()
		{
			return new IBehaviorTreeFragmentContext_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17002B51 RID: 11089
		// (get) Token: 0x06008415 RID: 33813 RVA: 0x0013AE99 File Offset: 0x00139099
		// (set) Token: 0x06008416 RID: 33814 RVA: 0x0013AEC4 File Offset: 0x001390C4
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

		// Token: 0x17002B52 RID: 11090
		// (get) Token: 0x06008417 RID: 33815 RVA: 0x0013AED2 File Offset: 0x001390D2
		// (set) Token: 0x06008418 RID: 33816 RVA: 0x0013AEFD File Offset: 0x001390FD
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

		// Token: 0x040053A8 RID: 21416
		[Nullable(2)]
		protected new IBehaviorTreeFragmentContext FbInstance;

		// Token: 0x040053A9 RID: 21417
		[Nullable(2)]
		protected new IBehaviorTreeFragmentContext_SetValue PocoInterface;
	}
}
