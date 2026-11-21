using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FCF RID: 8143
	public class IResumeGiantDeliveryRewardPopup : IResumeSystemRewardPopupType
	{
		// Token: 0x0600AD05 RID: 44293 RVA: 0x00186CC4 File Offset: 0x00184EC4
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

		// Token: 0x0600AD06 RID: 44294 RVA: 0x00186CFC File Offset: 0x00184EFC
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

		// Token: 0x0600AD07 RID: 44295 RVA: 0x00186D0F File Offset: 0x00184F0F
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

		// Token: 0x0600AD08 RID: 44296 RVA: 0x00186D22 File Offset: 0x00184F22
		public new IResumeGiantDeliveryRewardPopup_SetValue ToSetValue()
		{
			return new IResumeGiantDeliveryRewardPopup_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170034DA RID: 13530
		// (get) Token: 0x0600AD09 RID: 44297 RVA: 0x00186D35 File Offset: 0x00184F35
		// (set) Token: 0x0600AD0A RID: 44298 RVA: 0x00186D60 File Offset: 0x00184F60
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

		// Token: 0x04006755 RID: 26453
		[Nullable(2)]
		protected new IResumeGiantDeliveryRewardPopup FbInstance;

		// Token: 0x04006756 RID: 26454
		[Nullable(2)]
		protected new IResumeGiantDeliveryRewardPopup_SetValue PocoInterface;
	}
}
