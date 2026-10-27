using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EE3 RID: 7907
	[NullableContext(1)]
	[Nullable(0)]
	public class ISubScreenTransition
	{
		// Token: 0x0600A92C RID: 43308 RVA: 0x0017DA08 File Offset: 0x0017BC08
		private ISubScreenTransition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISubScreenTransition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISubScreenTransition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISubScreenTransition_SetValue());
			}
			return result;
		}

		// Token: 0x0600A92D RID: 43309 RVA: 0x0017DA40 File Offset: 0x0017BC40
		public static ISubScreenTransition Create([Nullable(2)] ISubScreenTransition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubScreenTransition
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A92E RID: 43310 RVA: 0x0017DA53 File Offset: 0x0017BC53
		public static ISubScreenTransition CreateFromSetValue([Nullable(2)] ISubScreenTransition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISubScreenTransition
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A92F RID: 43311 RVA: 0x0017DA66 File Offset: 0x0017BC66
		public ISubScreenTransition_SetValue ToSetValue()
		{
			return new ISubScreenTransition_SetValue
			{
				TransitionDuration = this.TransitionDuration,
				TransitionCurve = this.TransitionCurve
			};
		}

		// Token: 0x17003399 RID: 13209
		// (get) Token: 0x0600A930 RID: 43312 RVA: 0x0017DA85 File Offset: 0x0017BC85
		// (set) Token: 0x0600A931 RID: 43313 RVA: 0x0017DAB4 File Offset: 0x0017BCB4
		public virtual float TransitionDuration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TransitionDuration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.TransitionDuration;
			}
			set
			{
				this.GetOrCreatePoco().TransitionDuration = value;
			}
		}

		// Token: 0x1700339A RID: 13210
		// (get) Token: 0x0600A932 RID: 43314 RVA: 0x0017DAC2 File Offset: 0x0017BCC2
		// (set) Token: 0x0600A933 RID: 43315 RVA: 0x0017DAED File Offset: 0x0017BCED
		public virtual string TransitionCurve
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TransitionCurve;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TransitionCurve;
			}
			set
			{
				this.GetOrCreatePoco().TransitionCurve = value;
			}
		}

		// Token: 0x040064B2 RID: 25778
		[Nullable(2)]
		protected ISubScreenTransition FbInstance;

		// Token: 0x040064B3 RID: 25779
		[Nullable(2)]
		protected ISubScreenTransition_SetValue PocoInterface;
	}
}
