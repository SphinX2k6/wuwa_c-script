using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D7D RID: 7549
	public class ILiveUiShowConfig : ILiveUiConfig
	{
		// Token: 0x0600A03B RID: 41019 RVA: 0x0016F898 File Offset: 0x0016DA98
		private ILiveUiShowConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiveUiShowConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiveUiShowConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiveUiShowConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A03C RID: 41020 RVA: 0x0016F8D0 File Offset: 0x0016DAD0
		public static ILiveUiShowConfig Create([Nullable(2)] ILiveUiShowConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveUiShowConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A03D RID: 41021 RVA: 0x0016F8E3 File Offset: 0x0016DAE3
		public static ILiveUiShowConfig CreateFromSetValue([Nullable(2)] ILiveUiShowConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiveUiShowConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A03E RID: 41022 RVA: 0x0016F8F6 File Offset: 0x0016DAF6
		public new ILiveUiShowConfig_SetValue ToSetValue()
		{
			return new ILiveUiShowConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031F0 RID: 12784
		// (get) Token: 0x0600A03F RID: 41023 RVA: 0x0016F909 File Offset: 0x0016DB09
		// (set) Token: 0x0600A040 RID: 41024 RVA: 0x0016F934 File Offset: 0x0016DB34
		public override ELiveUiType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELiveUiType.Start;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006167 RID: 24935
		[Nullable(2)]
		protected new ILiveUiShowConfig FbInstance;

		// Token: 0x04006168 RID: 24936
		[Nullable(2)]
		protected new ILiveUiShowConfig_SetValue PocoInterface;
	}
}
