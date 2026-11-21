using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D81 RID: 7553
	public class ILiveUnloadDanmakuConfig : ILiveDanmakuOperation
	{
		// Token: 0x0600A04B RID: 41035 RVA: 0x0016FA10 File Offset: 0x0016DC10
		private ILiveUnloadDanmakuConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiveUnloadDanmakuConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiveUnloadDanmakuConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiveUnloadDanmakuConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A04C RID: 41036 RVA: 0x0016FA48 File Offset: 0x0016DC48
		public static ILiveUnloadDanmakuConfig Create([Nullable(2)] ILiveUnloadDanmakuConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveUnloadDanmakuConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A04D RID: 41037 RVA: 0x0016FA5B File Offset: 0x0016DC5B
		public static ILiveUnloadDanmakuConfig CreateFromSetValue([Nullable(2)] ILiveUnloadDanmakuConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiveUnloadDanmakuConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A04E RID: 41038 RVA: 0x0016FA6E File Offset: 0x0016DC6E
		public new ILiveUnloadDanmakuConfig_SetValue ToSetValue()
		{
			return new ILiveUnloadDanmakuConfig_SetValue
			{
				Type = this.Type,
				ClearType = this.ClearType
			};
		}

		// Token: 0x170031F2 RID: 12786
		// (get) Token: 0x0600A04F RID: 41039 RVA: 0x0016FA8D File Offset: 0x0016DC8D
		// (set) Token: 0x0600A050 RID: 41040 RVA: 0x0016FAB8 File Offset: 0x0016DCB8
		public override ELiveDanmakuOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELiveDanmakuOperationType.Load;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170031F3 RID: 12787
		// (get) Token: 0x0600A051 RID: 41041 RVA: 0x0016FAC6 File Offset: 0x0016DCC6
		// (set) Token: 0x0600A052 RID: 41042 RVA: 0x0016FAF1 File Offset: 0x0016DCF1
		public virtual ELiveDanmakuClearType ClearType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ClearType;
				}
				if (this.PocoInterface == null)
				{
					return ELiveDanmakuClearType.FinishCurrent;
				}
				return this.PocoInterface.ClearType;
			}
			set
			{
				this.GetOrCreatePoco().ClearType = value;
			}
		}

		// Token: 0x0400616D RID: 24941
		[Nullable(2)]
		protected new ILiveUnloadDanmakuConfig FbInstance;

		// Token: 0x0400616E RID: 24942
		[Nullable(2)]
		protected new ILiveUnloadDanmakuConfig_SetValue PocoInterface;
	}
}
