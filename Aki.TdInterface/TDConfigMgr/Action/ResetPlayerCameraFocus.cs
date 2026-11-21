using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023C3 RID: 9155
	public class ResetPlayerCameraFocus : ActionParams
	{
		// Token: 0x0600C790 RID: 51088 RVA: 0x001C8D48 File Offset: 0x001C6F48
		private ResetPlayerCameraFocus_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ResetPlayerCameraFocus 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ResetPlayerCameraFocus_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ResetPlayerCameraFocus_SetValue());
			}
			return result;
		}

		// Token: 0x0600C791 RID: 51089 RVA: 0x001C8D80 File Offset: 0x001C6F80
		public static ResetPlayerCameraFocus Create([Nullable(2)] ResetPlayerCameraFocus instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ResetPlayerCameraFocus
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C792 RID: 51090 RVA: 0x001C8D93 File Offset: 0x001C6F93
		public static ResetPlayerCameraFocus CreateFromSetValue([Nullable(2)] ResetPlayerCameraFocus_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ResetPlayerCameraFocus
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C793 RID: 51091 RVA: 0x001C8DA6 File Offset: 0x001C6FA6
		public ResetPlayerCameraFocus_SetValue ToSetValue()
		{
			return new ResetPlayerCameraFocus_SetValue
			{
				ResetType = this.ResetType,
				FadeInTime = this.FadeInTime,
				CannotInterrupt = this.CannotInterrupt,
				Duration = this.Duration
			};
		}

		// Token: 0x17003C38 RID: 15416
		// (get) Token: 0x0600C794 RID: 51092 RVA: 0x001C8DDD File Offset: 0x001C6FDD
		// (set) Token: 0x0600C795 RID: 51093 RVA: 0x001C8E04 File Offset: 0x001C7004
		public virtual IResetPlayerFocusType ResetType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ResetType;
				}
				ResetPlayerCameraFocus_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ResetType;
			}
			set
			{
				this.GetOrCreatePoco().ResetType = value;
			}
		}

		// Token: 0x17003C39 RID: 15417
		// (get) Token: 0x0600C796 RID: 51094 RVA: 0x001C8E12 File Offset: 0x001C7012
		// (set) Token: 0x0600C797 RID: 51095 RVA: 0x001C8E41 File Offset: 0x001C7041
		public virtual float FadeInTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeInTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.FadeInTime;
			}
			set
			{
				this.GetOrCreatePoco().FadeInTime = value;
			}
		}

		// Token: 0x17003C3A RID: 15418
		// (get) Token: 0x0600C798 RID: 51096 RVA: 0x001C8E50 File Offset: 0x001C7050
		// (set) Token: 0x0600C799 RID: 51097 RVA: 0x001C8E8A File Offset: 0x001C708A
		public virtual bool? CannotInterrupt
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CannotInterrupt;
				}
				ResetPlayerCameraFocus_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CannotInterrupt;
			}
			set
			{
				this.GetOrCreatePoco().CannotInterrupt = value;
			}
		}

		// Token: 0x17003C3B RID: 15419
		// (get) Token: 0x0600C79A RID: 51098 RVA: 0x001C8E98 File Offset: 0x001C7098
		// (set) Token: 0x0600C79B RID: 51099 RVA: 0x001C8ED2 File Offset: 0x001C70D2
		public virtual float? Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				ResetPlayerCameraFocus_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x0400768A RID: 30346
		[Nullable(2)]
		protected new ResetPlayerCameraFocus FbInstance;

		// Token: 0x0400768B RID: 30347
		[Nullable(2)]
		protected ResetPlayerCameraFocus_SetValue PocoInterface;
	}
}
