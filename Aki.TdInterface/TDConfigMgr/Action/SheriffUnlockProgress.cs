using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002468 RID: 9320
	public class SheriffUnlockProgress : ActionParams
	{
		// Token: 0x0600CACB RID: 51915 RVA: 0x001CED98 File Offset: 0x001CCF98
		private SheriffUnlockProgress_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SheriffUnlockProgress 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SheriffUnlockProgress_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SheriffUnlockProgress_SetValue());
			}
			return result;
		}

		// Token: 0x0600CACC RID: 51916 RVA: 0x001CEDD0 File Offset: 0x001CCFD0
		public static SheriffUnlockProgress Create([Nullable(2)] SheriffUnlockProgress instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SheriffUnlockProgress
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CACD RID: 51917 RVA: 0x001CEDE3 File Offset: 0x001CCFE3
		public static SheriffUnlockProgress CreateFromSetValue([Nullable(2)] SheriffUnlockProgress_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SheriffUnlockProgress
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CACE RID: 51918 RVA: 0x001CEDF6 File Offset: 0x001CCFF6
		public SheriffUnlockProgress_SetValue ToSetValue()
		{
			return new SheriffUnlockProgress_SetValue
			{
				ProgressId = this.ProgressId
			};
		}

		// Token: 0x17003CE3 RID: 15587
		// (get) Token: 0x0600CACF RID: 51919 RVA: 0x001CEE09 File Offset: 0x001CD009
		// (set) Token: 0x0600CAD0 RID: 51920 RVA: 0x001CEE34 File Offset: 0x001CD034
		public virtual int ProgressId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ProgressId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ProgressId;
			}
			set
			{
				this.GetOrCreatePoco().ProgressId = value;
			}
		}

		// Token: 0x04007832 RID: 30770
		[Nullable(2)]
		protected new SheriffUnlockProgress FbInstance;

		// Token: 0x04007833 RID: 30771
		[Nullable(2)]
		protected SheriffUnlockProgress_SetValue PocoInterface;
	}
}
