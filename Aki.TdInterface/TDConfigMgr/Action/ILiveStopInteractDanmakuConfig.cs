using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D71 RID: 7537
	public class ILiveStopInteractDanmakuConfig : ILiveDanmakuOperation
	{
		// Token: 0x0600A007 RID: 40967 RVA: 0x0016F3A8 File Offset: 0x0016D5A8
		private ILiveStopInteractDanmakuConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiveStopInteractDanmakuConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiveStopInteractDanmakuConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiveStopInteractDanmakuConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A008 RID: 40968 RVA: 0x0016F3E0 File Offset: 0x0016D5E0
		public static ILiveStopInteractDanmakuConfig Create([Nullable(2)] ILiveStopInteractDanmakuConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveStopInteractDanmakuConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A009 RID: 40969 RVA: 0x0016F3F3 File Offset: 0x0016D5F3
		public static ILiveStopInteractDanmakuConfig CreateFromSetValue([Nullable(2)] ILiveStopInteractDanmakuConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiveStopInteractDanmakuConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A00A RID: 40970 RVA: 0x0016F406 File Offset: 0x0016D606
		public new ILiveStopInteractDanmakuConfig_SetValue ToSetValue()
		{
			return new ILiveStopInteractDanmakuConfig_SetValue
			{
				Type = this.Type,
				ClearType = this.ClearType
			};
		}

		// Token: 0x170031E8 RID: 12776
		// (get) Token: 0x0600A00B RID: 40971 RVA: 0x0016F425 File Offset: 0x0016D625
		// (set) Token: 0x0600A00C RID: 40972 RVA: 0x0016F450 File Offset: 0x0016D650
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

		// Token: 0x170031E9 RID: 12777
		// (get) Token: 0x0600A00D RID: 40973 RVA: 0x0016F45E File Offset: 0x0016D65E
		// (set) Token: 0x0600A00E RID: 40974 RVA: 0x0016F489 File Offset: 0x0016D689
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

		// Token: 0x04006153 RID: 24915
		[Nullable(2)]
		protected new ILiveStopInteractDanmakuConfig FbInstance;

		// Token: 0x04006154 RID: 24916
		[Nullable(2)]
		protected new ILiveStopInteractDanmakuConfig_SetValue PocoInterface;
	}
}
