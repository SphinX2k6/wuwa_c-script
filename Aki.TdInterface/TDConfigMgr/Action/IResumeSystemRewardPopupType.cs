using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FD1 RID: 8145
	public class IResumeSystemRewardPopupType
	{
		// Token: 0x0600AD0D RID: 44301 RVA: 0x00186D80 File Offset: 0x00184F80
		private IResumeSystemRewardPopupType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IResumeSystemRewardPopupType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IResumeSystemRewardPopupType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IResumeSystemRewardPopupType_SetValue());
			}
			return result;
		}

		// Token: 0x0600AD0E RID: 44302 RVA: 0x00186DB8 File Offset: 0x00184FB8
		public static IResumeSystemRewardPopupType Create([Nullable(2)] IResumeSystemRewardPopupType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResumeSystemRewardPopupType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AD0F RID: 44303 RVA: 0x00186DCB File Offset: 0x00184FCB
		public static IResumeSystemRewardPopupType CreateFromSetValue([Nullable(2)] IResumeSystemRewardPopupType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IResumeSystemRewardPopupType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AD10 RID: 44304 RVA: 0x00186DDE File Offset: 0x00184FDE
		public IResumeSystemRewardPopupType_SetValue ToSetValue()
		{
			return new IResumeSystemRewardPopupType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170034DB RID: 13531
		// (get) Token: 0x0600AD11 RID: 44305 RVA: 0x00186DF1 File Offset: 0x00184FF1
		// (set) Token: 0x0600AD12 RID: 44306 RVA: 0x00186E1C File Offset: 0x0018501C
		public virtual ESystemType Type
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

		// Token: 0x04006758 RID: 26456
		[Nullable(2)]
		protected IResumeSystemRewardPopupType FbInstance;

		// Token: 0x04006759 RID: 26457
		[Nullable(2)]
		protected IResumeSystemRewardPopupType_SetValue PocoInterface;
	}
}
