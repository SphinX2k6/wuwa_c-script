using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C44 RID: 7236
	[NullableContext(1)]
	[Nullable(0)]
	public class IMovingCameraTimeParams
	{
		// Token: 0x06009B39 RID: 39737 RVA: 0x001649D8 File Offset: 0x00162BD8
		private IMovingCameraTimeParams_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMovingCameraTimeParams 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMovingCameraTimeParams_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMovingCameraTimeParams_SetValue());
			}
			return result;
		}

		// Token: 0x06009B3A RID: 39738 RVA: 0x00164A10 File Offset: 0x00162C10
		public static IMovingCameraTimeParams Create([Nullable(2)] IMovingCameraTimeParams instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMovingCameraTimeParams
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009B3B RID: 39739 RVA: 0x00164A23 File Offset: 0x00162C23
		public static IMovingCameraTimeParams CreateFromSetValue([Nullable(2)] IMovingCameraTimeParams_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMovingCameraTimeParams
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009B3C RID: 39740 RVA: 0x00164A36 File Offset: 0x00162C36
		public IMovingCameraTimeParams_SetValue ToSetValue()
		{
			return new IMovingCameraTimeParams_SetValue
			{
				FadeInTime = this.FadeInTime,
				AfterFadeInStayTime = this.AfterFadeInStayTime,
				FadeOutTime = this.FadeOutTime,
				BeforeFadeOutStayTime = this.BeforeFadeOutStayTime
			};
		}

		// Token: 0x1700308D RID: 12429
		// (get) Token: 0x06009B3D RID: 39741 RVA: 0x00164A6D File Offset: 0x00162C6D
		// (set) Token: 0x06009B3E RID: 39742 RVA: 0x00164A9C File Offset: 0x00162C9C
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

		// Token: 0x1700308E RID: 12430
		// (get) Token: 0x06009B3F RID: 39743 RVA: 0x00164AAA File Offset: 0x00162CAA
		// (set) Token: 0x06009B40 RID: 39744 RVA: 0x00164AD9 File Offset: 0x00162CD9
		public virtual float AfterFadeInStayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AfterFadeInStayTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.AfterFadeInStayTime;
			}
			set
			{
				this.GetOrCreatePoco().AfterFadeInStayTime = value;
			}
		}

		// Token: 0x1700308F RID: 12431
		// (get) Token: 0x06009B41 RID: 39745 RVA: 0x00164AE7 File Offset: 0x00162CE7
		// (set) Token: 0x06009B42 RID: 39746 RVA: 0x00164B16 File Offset: 0x00162D16
		public virtual float FadeOutTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeOutTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.FadeOutTime;
			}
			set
			{
				this.GetOrCreatePoco().FadeOutTime = value;
			}
		}

		// Token: 0x17003090 RID: 12432
		// (get) Token: 0x06009B43 RID: 39747 RVA: 0x00164B24 File Offset: 0x00162D24
		// (set) Token: 0x06009B44 RID: 39748 RVA: 0x00164B53 File Offset: 0x00162D53
		public virtual float BeforeFadeOutStayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BeforeFadeOutStayTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.BeforeFadeOutStayTime;
			}
			set
			{
				this.GetOrCreatePoco().BeforeFadeOutStayTime = value;
			}
		}

		// Token: 0x04005E4E RID: 24142
		[Nullable(2)]
		protected IMovingCameraTimeParams FbInstance;

		// Token: 0x04005E4F RID: 24143
		[Nullable(2)]
		protected IMovingCameraTimeParams_SetValue PocoInterface;
	}
}
