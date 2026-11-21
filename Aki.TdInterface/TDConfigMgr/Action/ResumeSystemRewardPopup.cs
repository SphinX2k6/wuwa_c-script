using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023CF RID: 9167
	public class ResumeSystemRewardPopup : ActionParams
	{
		// Token: 0x0600C7CA RID: 51146 RVA: 0x001C93D0 File Offset: 0x001C75D0
		private ResumeSystemRewardPopup_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ResumeSystemRewardPopup 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ResumeSystemRewardPopup_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ResumeSystemRewardPopup_SetValue());
			}
			return result;
		}

		// Token: 0x0600C7CB RID: 51147 RVA: 0x001C9408 File Offset: 0x001C7608
		public static ResumeSystemRewardPopup Create([Nullable(2)] ResumeSystemRewardPopup instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ResumeSystemRewardPopup
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C7CC RID: 51148 RVA: 0x001C941B File Offset: 0x001C761B
		public static ResumeSystemRewardPopup CreateFromSetValue([Nullable(2)] ResumeSystemRewardPopup_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ResumeSystemRewardPopup
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C7CD RID: 51149 RVA: 0x001C942E File Offset: 0x001C762E
		public ResumeSystemRewardPopup_SetValue ToSetValue()
		{
			return new ResumeSystemRewardPopup_SetValue
			{
				SystemType = this.SystemType
			};
		}

		// Token: 0x17003C44 RID: 15428
		// (get) Token: 0x0600C7CE RID: 51150 RVA: 0x001C9444 File Offset: 0x001C7644
		// (set) Token: 0x0600C7CF RID: 51151 RVA: 0x001C94A5 File Offset: 0x001C76A5
		public virtual IResumeGiantDeliveryRewardPopup SystemType
		{
			get
			{
				if (this._SystemTypeInited)
				{
					return this._SystemTypeCache;
				}
				this._SystemTypeInited = true;
				if (this.FbInstance != null)
				{
					this._SystemTypeCache = IResumeGiantDeliveryRewardPopup.Create(this.FbInstance.SystemType);
				}
				else
				{
					ResumeSystemRewardPopup_SetValue pocoInterface = this.PocoInterface;
					this._SystemTypeCache = ((pocoInterface != null) ? pocoInterface.SystemType : null);
				}
				return this._SystemTypeCache;
			}
			set
			{
				this.GetOrCreatePoco().SystemType = value;
				this._SystemTypeInited = false;
			}
		}

		// Token: 0x040076A6 RID: 30374
		[Nullable(2)]
		protected new ResumeSystemRewardPopup FbInstance;

		// Token: 0x040076A7 RID: 30375
		[Nullable(2)]
		protected ResumeSystemRewardPopup_SetValue PocoInterface;

		// Token: 0x040076A8 RID: 30376
		private IResumeGiantDeliveryRewardPopup _SystemTypeCache;

		// Token: 0x040076A9 RID: 30377
		private bool _SystemTypeInited;
	}
}
