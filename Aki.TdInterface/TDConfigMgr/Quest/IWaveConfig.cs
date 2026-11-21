using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200134C RID: 4940
	public class IWaveConfig
	{
		// Token: 0x06006F2B RID: 28459 RVA: 0x00107C9C File Offset: 0x00105E9C
		private IWaveConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWaveConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWaveConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWaveConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06006F2C RID: 28460 RVA: 0x00107CD4 File Offset: 0x00105ED4
		public static IWaveConfig Create([Nullable(2)] IWaveConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWaveConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006F2D RID: 28461 RVA: 0x00107CE7 File Offset: 0x00105EE7
		public static IWaveConfig CreateFromSetValue([Nullable(2)] IWaveConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWaveConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006F2E RID: 28462 RVA: 0x00107CFA File Offset: 0x00105EFA
		public IWaveConfig_SetValue ToSetValue()
		{
			return new IWaveConfig_SetValue
			{
				Id = this.Id
			};
		}

		// Token: 0x170023A3 RID: 9123
		// (get) Token: 0x06006F2F RID: 28463 RVA: 0x00107D0D File Offset: 0x00105F0D
		// (set) Token: 0x06006F30 RID: 28464 RVA: 0x00107D38 File Offset: 0x00105F38
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

		// Token: 0x0400422F RID: 16943
		[Nullable(2)]
		protected IWaveConfig FbInstance;

		// Token: 0x04004230 RID: 16944
		[Nullable(2)]
		protected IWaveConfig_SetValue PocoInterface;
	}
}
