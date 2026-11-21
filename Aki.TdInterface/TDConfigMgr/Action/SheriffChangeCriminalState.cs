using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002462 RID: 9314
	public class SheriffChangeCriminalState : ActionParams
	{
		// Token: 0x0600CAB1 RID: 51889 RVA: 0x001CEB20 File Offset: 0x001CCD20
		private SheriffChangeCriminalState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SheriffChangeCriminalState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SheriffChangeCriminalState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SheriffChangeCriminalState_SetValue());
			}
			return result;
		}

		// Token: 0x0600CAB2 RID: 51890 RVA: 0x001CEB58 File Offset: 0x001CCD58
		public static SheriffChangeCriminalState Create([Nullable(2)] SheriffChangeCriminalState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SheriffChangeCriminalState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CAB3 RID: 51891 RVA: 0x001CEB6B File Offset: 0x001CCD6B
		public static SheriffChangeCriminalState CreateFromSetValue([Nullable(2)] SheriffChangeCriminalState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SheriffChangeCriminalState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CAB4 RID: 51892 RVA: 0x001CEB7E File Offset: 0x001CCD7E
		public SheriffChangeCriminalState_SetValue ToSetValue()
		{
			return new SheriffChangeCriminalState_SetValue
			{
				CriminalId = this.CriminalId,
				CriminalState = this.CriminalState
			};
		}

		// Token: 0x17003CDF RID: 15583
		// (get) Token: 0x0600CAB5 RID: 51893 RVA: 0x001CEB9D File Offset: 0x001CCD9D
		// (set) Token: 0x0600CAB6 RID: 51894 RVA: 0x001CEBC8 File Offset: 0x001CCDC8
		public virtual int CriminalId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CriminalId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.CriminalId;
			}
			set
			{
				this.GetOrCreatePoco().CriminalId = value;
			}
		}

		// Token: 0x17003CE0 RID: 15584
		// (get) Token: 0x0600CAB7 RID: 51895 RVA: 0x001CEBD6 File Offset: 0x001CCDD6
		// (set) Token: 0x0600CAB8 RID: 51896 RVA: 0x001CEC01 File Offset: 0x001CCE01
		public virtual ESheriffCriminalState CriminalState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CriminalState;
				}
				if (this.PocoInterface == null)
				{
					return (ESheriffCriminalState)0;
				}
				return this.PocoInterface.CriminalState;
			}
			set
			{
				this.GetOrCreatePoco().CriminalState = value;
			}
		}

		// Token: 0x04007828 RID: 30760
		[Nullable(2)]
		protected new SheriffChangeCriminalState FbInstance;

		// Token: 0x04007829 RID: 30761
		[Nullable(2)]
		protected SheriffChangeCriminalState_SetValue PocoInterface;
	}
}
