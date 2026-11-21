using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D77 RID: 7543
	public class ILiveUiHideConfig : ILiveUiConfig
	{
		// Token: 0x0600A023 RID: 40995 RVA: 0x0016F664 File Offset: 0x0016D864
		private ILiveUiHideConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiveUiHideConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiveUiHideConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiveUiHideConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A024 RID: 40996 RVA: 0x0016F69C File Offset: 0x0016D89C
		public static ILiveUiHideConfig Create([Nullable(2)] ILiveUiHideConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveUiHideConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A025 RID: 40997 RVA: 0x0016F6AF File Offset: 0x0016D8AF
		public static ILiveUiHideConfig CreateFromSetValue([Nullable(2)] ILiveUiHideConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiveUiHideConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A026 RID: 40998 RVA: 0x0016F6C2 File Offset: 0x0016D8C2
		public new ILiveUiHideConfig_SetValue ToSetValue()
		{
			return new ILiveUiHideConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031ED RID: 12781
		// (get) Token: 0x0600A027 RID: 40999 RVA: 0x0016F6D5 File Offset: 0x0016D8D5
		// (set) Token: 0x0600A028 RID: 41000 RVA: 0x0016F700 File Offset: 0x0016D900
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

		// Token: 0x0400615E RID: 24926
		[Nullable(2)]
		protected new ILiveUiHideConfig FbInstance;

		// Token: 0x0400615F RID: 24927
		[Nullable(2)]
		protected new ILiveUiHideConfig_SetValue PocoInterface;
	}
}
