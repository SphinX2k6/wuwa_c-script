using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019B5 RID: 6581
	public class IBvbEndTurn : IBvbPlayerOperationType
	{
		// Token: 0x06008BE9 RID: 35817 RVA: 0x0014B988 File Offset: 0x00149B88
		private IBvbEndTurn_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBvbEndTurn 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBvbEndTurn_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBvbEndTurn_SetValue());
			}
			return result;
		}

		// Token: 0x06008BEA RID: 35818 RVA: 0x0014B9C0 File Offset: 0x00149BC0
		public static IBvbEndTurn Create([Nullable(2)] IBvbEndTurn instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbEndTurn
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008BEB RID: 35819 RVA: 0x0014B9D3 File Offset: 0x00149BD3
		public static IBvbEndTurn CreateFromSetValue([Nullable(2)] IBvbEndTurn_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBvbEndTurn
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008BEC RID: 35820 RVA: 0x0014B9E6 File Offset: 0x00149BE6
		public new IBvbEndTurn_SetValue ToSetValue()
		{
			return new IBvbEndTurn_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D71 RID: 11633
		// (get) Token: 0x06008BED RID: 35821 RVA: 0x0014B9F9 File Offset: 0x00149BF9
		// (set) Token: 0x06008BEE RID: 35822 RVA: 0x0014BA24 File Offset: 0x00149C24
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

		// Token: 0x04005844 RID: 22596
		[Nullable(2)]
		protected new IBvbEndTurn FbInstance;

		// Token: 0x04005845 RID: 22597
		[Nullable(2)]
		protected new IBvbEndTurn_SetValue PocoInterface;
	}
}
