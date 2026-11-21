using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D79 RID: 7545
	public class ILiveUiPauseConfig : ILiveUiConfig
	{
		// Token: 0x0600A02B RID: 41003 RVA: 0x0016F720 File Offset: 0x0016D920
		private ILiveUiPauseConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiveUiPauseConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiveUiPauseConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiveUiPauseConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A02C RID: 41004 RVA: 0x0016F758 File Offset: 0x0016D958
		public static ILiveUiPauseConfig Create([Nullable(2)] ILiveUiPauseConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveUiPauseConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A02D RID: 41005 RVA: 0x0016F76B File Offset: 0x0016D96B
		public static ILiveUiPauseConfig CreateFromSetValue([Nullable(2)] ILiveUiPauseConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiveUiPauseConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A02E RID: 41006 RVA: 0x0016F77E File Offset: 0x0016D97E
		public new ILiveUiPauseConfig_SetValue ToSetValue()
		{
			return new ILiveUiPauseConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031EE RID: 12782
		// (get) Token: 0x0600A02F RID: 41007 RVA: 0x0016F791 File Offset: 0x0016D991
		// (set) Token: 0x0600A030 RID: 41008 RVA: 0x0016F7BC File Offset: 0x0016D9BC
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

		// Token: 0x04006161 RID: 24929
		[Nullable(2)]
		protected new ILiveUiPauseConfig FbInstance;

		// Token: 0x04006162 RID: 24930
		[Nullable(2)]
		protected new ILiveUiPauseConfig_SetValue PocoInterface;
	}
}
