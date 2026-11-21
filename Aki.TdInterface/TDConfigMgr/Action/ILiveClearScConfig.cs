using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D49 RID: 7497
	public class ILiveClearScConfig : ILiveScOperation
	{
		// Token: 0x06009F33 RID: 40755 RVA: 0x0016DBFC File Offset: 0x0016BDFC
		private ILiveClearScConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiveClearScConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiveClearScConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiveClearScConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009F34 RID: 40756 RVA: 0x0016DC34 File Offset: 0x0016BE34
		public static ILiveClearScConfig Create([Nullable(2)] ILiveClearScConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveClearScConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009F35 RID: 40757 RVA: 0x0016DC47 File Offset: 0x0016BE47
		public static ILiveClearScConfig CreateFromSetValue([Nullable(2)] ILiveClearScConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiveClearScConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009F36 RID: 40758 RVA: 0x0016DC5A File Offset: 0x0016BE5A
		public new ILiveClearScConfig_SetValue ToSetValue()
		{
			return new ILiveClearScConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031BA RID: 12730
		// (get) Token: 0x06009F37 RID: 40759 RVA: 0x0016DC6D File Offset: 0x0016BE6D
		// (set) Token: 0x06009F38 RID: 40760 RVA: 0x0016DC98 File Offset: 0x0016BE98
		public override ELiveScOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELiveScOperationType.Send;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040060F5 RID: 24821
		[Nullable(2)]
		protected new ILiveClearScConfig FbInstance;

		// Token: 0x040060F6 RID: 24822
		[Nullable(2)]
		protected new ILiveClearScConfig_SetValue PocoInterface;
	}
}
