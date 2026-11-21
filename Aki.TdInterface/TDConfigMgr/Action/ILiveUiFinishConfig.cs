using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D75 RID: 7541
	public class ILiveUiFinishConfig : ILiveUiConfig
	{
		// Token: 0x0600A019 RID: 40985 RVA: 0x0016F564 File Offset: 0x0016D764
		private ILiveUiFinishConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiveUiFinishConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiveUiFinishConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiveUiFinishConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A01A RID: 40986 RVA: 0x0016F59C File Offset: 0x0016D79C
		public static ILiveUiFinishConfig Create([Nullable(2)] ILiveUiFinishConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveUiFinishConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A01B RID: 40987 RVA: 0x0016F5AF File Offset: 0x0016D7AF
		public static ILiveUiFinishConfig CreateFromSetValue([Nullable(2)] ILiveUiFinishConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiveUiFinishConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A01C RID: 40988 RVA: 0x0016F5C2 File Offset: 0x0016D7C2
		public new ILiveUiFinishConfig_SetValue ToSetValue()
		{
			return new ILiveUiFinishConfig_SetValue
			{
				Type = this.Type,
				SettlementId = this.SettlementId
			};
		}

		// Token: 0x170031EB RID: 12779
		// (get) Token: 0x0600A01D RID: 40989 RVA: 0x0016F5E1 File Offset: 0x0016D7E1
		// (set) Token: 0x0600A01E RID: 40990 RVA: 0x0016F60C File Offset: 0x0016D80C
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

		// Token: 0x170031EC RID: 12780
		// (get) Token: 0x0600A01F RID: 40991 RVA: 0x0016F61A File Offset: 0x0016D81A
		// (set) Token: 0x0600A020 RID: 40992 RVA: 0x0016F645 File Offset: 0x0016D845
		public virtual int SettlementId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SettlementId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SettlementId;
			}
			set
			{
				this.GetOrCreatePoco().SettlementId = value;
			}
		}

		// Token: 0x0400615A RID: 24922
		[Nullable(2)]
		protected new ILiveUiFinishConfig FbInstance;

		// Token: 0x0400615B RID: 24923
		[Nullable(2)]
		protected new ILiveUiFinishConfig_SetValue PocoInterface;
	}
}
