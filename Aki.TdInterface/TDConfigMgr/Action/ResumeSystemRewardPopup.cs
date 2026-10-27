using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200216E RID: 8558
	[NullableContext(1)]
	[Nullable(0)]
	public class ResumeSystemRewardPopup : ActionParams
	{
		// Token: 0x0600BC3C RID: 48188 RVA: 0x001B221C File Offset: 0x001B041C
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

		// Token: 0x0600BC3D RID: 48189 RVA: 0x001B2254 File Offset: 0x001B0454
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

		// Token: 0x0600BC3E RID: 48190 RVA: 0x001B2267 File Offset: 0x001B0467
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

		// Token: 0x0600BC3F RID: 48191 RVA: 0x001B227A File Offset: 0x001B047A
		public ResumeSystemRewardPopup_SetValue ToSetValue()
		{
			return new ResumeSystemRewardPopup_SetValue
			{
				SystemType = this.SystemType
			};
		}

		// Token: 0x17003957 RID: 14679
		// (get) Token: 0x0600BC40 RID: 48192 RVA: 0x001B2290 File Offset: 0x001B0490
		// (set) Token: 0x0600BC41 RID: 48193 RVA: 0x001B22F1 File Offset: 0x001B04F1
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

		// Token: 0x04007071 RID: 28785
		[Nullable(2)]
		protected new ResumeSystemRewardPopup FbInstance;

		// Token: 0x04007072 RID: 28786
		[Nullable(2)]
		protected ResumeSystemRewardPopup_SetValue PocoInterface;

		// Token: 0x04007073 RID: 28787
		private IResumeGiantDeliveryRewardPopup _SystemTypeCache;

		// Token: 0x04007074 RID: 28788
		private bool _SystemTypeInited;
	}
}
