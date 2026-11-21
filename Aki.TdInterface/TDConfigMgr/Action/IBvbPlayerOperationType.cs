using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019B9 RID: 6585
	public class IBvbPlayerOperationType
	{
		// Token: 0x06008BFF RID: 35839 RVA: 0x0014BBEC File Offset: 0x00149DEC
		private IBvbPlayerOperationType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBvbPlayerOperationType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBvbPlayerOperationType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBvbPlayerOperationType_SetValue());
			}
			return result;
		}

		// Token: 0x06008C00 RID: 35840 RVA: 0x0014BC24 File Offset: 0x00149E24
		public static IBvbPlayerOperationType Create([Nullable(2)] IBvbPlayerOperationType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbPlayerOperationType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008C01 RID: 35841 RVA: 0x0014BC37 File Offset: 0x00149E37
		public static IBvbPlayerOperationType CreateFromSetValue([Nullable(2)] IBvbPlayerOperationType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBvbPlayerOperationType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008C02 RID: 35842 RVA: 0x0014BC4A File Offset: 0x00149E4A
		public IBvbPlayerOperationType_SetValue ToSetValue()
		{
			return new IBvbPlayerOperationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D76 RID: 11638
		// (get) Token: 0x06008C03 RID: 35843 RVA: 0x0014BC5D File Offset: 0x00149E5D
		// (set) Token: 0x06008C04 RID: 35844 RVA: 0x0014BC88 File Offset: 0x00149E88
		public virtual EBvbPlayerOperationType Type
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

		// Token: 0x0400584D RID: 22605
		[Nullable(2)]
		protected IBvbPlayerOperationType FbInstance;

		// Token: 0x0400584E RID: 22606
		[Nullable(2)]
		protected IBvbPlayerOperationType_SetValue PocoInterface;
	}
}
