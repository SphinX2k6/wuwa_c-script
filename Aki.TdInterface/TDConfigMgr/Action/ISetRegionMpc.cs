using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002073 RID: 8307
	public class ISetRegionMpc : SetRegionConfig
	{
		// Token: 0x0600B061 RID: 45153 RVA: 0x0018D0B8 File Offset: 0x0018B2B8
		private ISetRegionMpc_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetRegionMpc 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetRegionMpc_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetRegionMpc_SetValue());
			}
			return result;
		}

		// Token: 0x0600B062 RID: 45154 RVA: 0x0018D0F0 File Offset: 0x0018B2F0
		public static ISetRegionMpc Create([Nullable(2)] ISetRegionMpc instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetRegionMpc
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B063 RID: 45155 RVA: 0x0018D103 File Offset: 0x0018B303
		public static ISetRegionMpc CreateFromSetValue([Nullable(2)] ISetRegionMpc_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetRegionMpc
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B064 RID: 45156 RVA: 0x0018D116 File Offset: 0x0018B316
		public new ISetRegionMpc_SetValue ToSetValue()
		{
			return new ISetRegionMpc_SetValue
			{
				Type = this.Type,
				RegionMpcId = this.RegionMpcId
			};
		}

		// Token: 0x17003592 RID: 13714
		// (get) Token: 0x0600B065 RID: 45157 RVA: 0x0018D135 File Offset: 0x0018B335
		// (set) Token: 0x0600B066 RID: 45158 RVA: 0x0018D160 File Offset: 0x0018B360
		public override ERegionConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERegionConfigType.Mpc;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003593 RID: 13715
		// (get) Token: 0x0600B067 RID: 45159 RVA: 0x0018D16E File Offset: 0x0018B36E
		// (set) Token: 0x0600B068 RID: 45160 RVA: 0x0018D199 File Offset: 0x0018B399
		public virtual int RegionMpcId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RegionMpcId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RegionMpcId;
			}
			set
			{
				this.GetOrCreatePoco().RegionMpcId = value;
			}
		}

		// Token: 0x040068F1 RID: 26865
		[Nullable(2)]
		protected new ISetRegionMpc FbInstance;

		// Token: 0x040068F2 RID: 26866
		[Nullable(2)]
		protected new ISetRegionMpc_SetValue PocoInterface;
	}
}
