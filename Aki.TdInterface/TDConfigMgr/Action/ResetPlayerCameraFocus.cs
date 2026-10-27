using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002162 RID: 8546
	[NullableContext(1)]
	[Nullable(0)]
	public class ResetPlayerCameraFocus : ActionParams
	{
		// Token: 0x0600BC02 RID: 48130 RVA: 0x001B1B94 File Offset: 0x001AFD94
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

		// Token: 0x0600BC03 RID: 48131 RVA: 0x001B1BCC File Offset: 0x001AFDCC
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

		// Token: 0x0600BC04 RID: 48132 RVA: 0x001B1BDF File Offset: 0x001AFDDF
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

		// Token: 0x0600BC05 RID: 48133 RVA: 0x001B1BF2 File Offset: 0x001AFDF2
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

		// Token: 0x1700394B RID: 14667
		// (get) Token: 0x0600BC06 RID: 48134 RVA: 0x001B1C29 File Offset: 0x001AFE29
		// (set) Token: 0x0600BC07 RID: 48135 RVA: 0x001B1C50 File Offset: 0x001AFE50
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

		// Token: 0x1700394C RID: 14668
		// (get) Token: 0x0600BC08 RID: 48136 RVA: 0x001B1C5E File Offset: 0x001AFE5E
		// (set) Token: 0x0600BC09 RID: 48137 RVA: 0x001B1C8D File Offset: 0x001AFE8D
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

		// Token: 0x1700394D RID: 14669
		// (get) Token: 0x0600BC0A RID: 48138 RVA: 0x001B1C9C File Offset: 0x001AFE9C
		// (set) Token: 0x0600BC0B RID: 48139 RVA: 0x001B1CD6 File Offset: 0x001AFED6
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

		// Token: 0x1700394E RID: 14670
		// (get) Token: 0x0600BC0C RID: 48140 RVA: 0x001B1CE4 File Offset: 0x001AFEE4
		// (set) Token: 0x0600BC0D RID: 48141 RVA: 0x001B1D1E File Offset: 0x001AFF1E
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

		// Token: 0x04007055 RID: 28757
		[Nullable(2)]
		protected new ResetPlayerCameraFocus FbInstance;

		// Token: 0x04007056 RID: 28758
		[Nullable(2)]
		protected ResetPlayerCameraFocus_SetValue PocoInterface;
	}
}
