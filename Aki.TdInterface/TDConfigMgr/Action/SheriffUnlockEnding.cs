using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002466 RID: 9318
	public class SheriffUnlockEnding : ActionParams
	{
		// Token: 0x0600CAC3 RID: 51907 RVA: 0x001CECDC File Offset: 0x001CCEDC
		private SheriffUnlockEnding_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SheriffUnlockEnding 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SheriffUnlockEnding_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SheriffUnlockEnding_SetValue());
			}
			return result;
		}

		// Token: 0x0600CAC4 RID: 51908 RVA: 0x001CED14 File Offset: 0x001CCF14
		public static SheriffUnlockEnding Create([Nullable(2)] SheriffUnlockEnding instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SheriffUnlockEnding
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CAC5 RID: 51909 RVA: 0x001CED27 File Offset: 0x001CCF27
		public static SheriffUnlockEnding CreateFromSetValue([Nullable(2)] SheriffUnlockEnding_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SheriffUnlockEnding
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CAC6 RID: 51910 RVA: 0x001CED3A File Offset: 0x001CCF3A
		public SheriffUnlockEnding_SetValue ToSetValue()
		{
			return new SheriffUnlockEnding_SetValue
			{
				EndingId = this.EndingId
			};
		}

		// Token: 0x17003CE2 RID: 15586
		// (get) Token: 0x0600CAC7 RID: 51911 RVA: 0x001CED4D File Offset: 0x001CCF4D
		// (set) Token: 0x0600CAC8 RID: 51912 RVA: 0x001CED78 File Offset: 0x001CCF78
		public virtual int EndingId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EndingId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EndingId;
			}
			set
			{
				this.GetOrCreatePoco().EndingId = value;
			}
		}

		// Token: 0x0400782F RID: 30767
		[Nullable(2)]
		protected new SheriffUnlockEnding FbInstance;

		// Token: 0x04007830 RID: 30768
		[Nullable(2)]
		protected SheriffUnlockEnding_SetValue PocoInterface;
	}
}
