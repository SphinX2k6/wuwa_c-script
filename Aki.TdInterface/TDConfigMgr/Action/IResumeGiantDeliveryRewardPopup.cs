using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DB8 RID: 7608
	[NullableContext(1)]
	[Nullable(0)]
	public class IResumeGiantDeliveryRewardPopup : IResumeSystemRewardPopupType
	{
		// Token: 0x0600A2FB RID: 41723 RVA: 0x0017259C File Offset: 0x0017079C
		private IResumeGiantDeliveryRewardPopup_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IResumeGiantDeliveryRewardPopup 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IResumeGiantDeliveryRewardPopup_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IResumeGiantDeliveryRewardPopup_SetValue());
			}
			return result;
		}

		// Token: 0x0600A2FC RID: 41724 RVA: 0x001725D4 File Offset: 0x001707D4
		public static IResumeGiantDeliveryRewardPopup Create([Nullable(2)] IResumeGiantDeliveryRewardPopup instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResumeGiantDeliveryRewardPopup
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A2FD RID: 41725 RVA: 0x001725E7 File Offset: 0x001707E7
		public static IResumeGiantDeliveryRewardPopup CreateFromSetValue([Nullable(2)] IResumeGiantDeliveryRewardPopup_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IResumeGiantDeliveryRewardPopup
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A2FE RID: 41726 RVA: 0x001725FA File Offset: 0x001707FA
		public new IResumeGiantDeliveryRewardPopup_SetValue ToSetValue()
		{
			return new IResumeGiantDeliveryRewardPopup_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003240 RID: 12864
		// (get) Token: 0x0600A2FF RID: 41727 RVA: 0x0017260D File Offset: 0x0017080D
		// (set) Token: 0x0600A300 RID: 41728 RVA: 0x00172638 File Offset: 0x00170838
		public override ESystemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESystemType.Shop;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040061CD RID: 25037
		[Nullable(2)]
		protected new IResumeGiantDeliveryRewardPopup FbInstance;

		// Token: 0x040061CE RID: 25038
		[Nullable(2)]
		protected new IResumeGiantDeliveryRewardPopup_SetValue PocoInterface;
	}
}
