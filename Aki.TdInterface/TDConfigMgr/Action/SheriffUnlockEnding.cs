using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021FB RID: 8699
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffUnlockEnding : ActionParams
	{
		// Token: 0x0600BF07 RID: 48903 RVA: 0x001B7650 File Offset: 0x001B5850
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

		// Token: 0x0600BF08 RID: 48904 RVA: 0x001B7688 File Offset: 0x001B5888
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

		// Token: 0x0600BF09 RID: 48905 RVA: 0x001B769B File Offset: 0x001B589B
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

		// Token: 0x0600BF0A RID: 48906 RVA: 0x001B76AE File Offset: 0x001B58AE
		public SheriffUnlockEnding_SetValue ToSetValue()
		{
			return new SheriffUnlockEnding_SetValue
			{
				EndingId = this.EndingId
			};
		}

		// Token: 0x170039ED RID: 14829
		// (get) Token: 0x0600BF0B RID: 48907 RVA: 0x001B76C1 File Offset: 0x001B58C1
		// (set) Token: 0x0600BF0C RID: 48908 RVA: 0x001B76EC File Offset: 0x001B58EC
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

		// Token: 0x040071E6 RID: 29158
		[Nullable(2)]
		protected new SheriffUnlockEnding FbInstance;

		// Token: 0x040071E7 RID: 29159
		[Nullable(2)]
		protected SheriffUnlockEnding_SetValue PocoInterface;
	}
}
