using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200072D RID: 1837
	[NullableContext(1)]
	[Nullable(0)]
	public class IStreamingWaitConfig
	{
		// Token: 0x060027A9 RID: 10153 RVA: 0x000696D0 File Offset: 0x000678D0
		private IStreamingWaitConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStreamingWaitConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStreamingWaitConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStreamingWaitConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060027AA RID: 10154 RVA: 0x00069708 File Offset: 0x00067908
		public static IStreamingWaitConfig Create([Nullable(2)] IStreamingWaitConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStreamingWaitConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x0006971B File Offset: 0x0006791B
		public static IStreamingWaitConfig CreateFromSetValue([Nullable(2)] IStreamingWaitConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStreamingWaitConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060027AC RID: 10156 RVA: 0x0006972E File Offset: 0x0006792E
		public IStreamingWaitConfig_SetValue ToSetValue()
		{
			return new IStreamingWaitConfig_SetValue
			{
				MinWaitStreamDuration = this.MinWaitStreamDuration,
				MaxWaitStreamDuration = this.MaxWaitStreamDuration
			};
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x060027AD RID: 10157 RVA: 0x0006974D File Offset: 0x0006794D
		// (set) Token: 0x060027AE RID: 10158 RVA: 0x0006977C File Offset: 0x0006797C
		public virtual float MinWaitStreamDuration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MinWaitStreamDuration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MinWaitStreamDuration;
			}
			set
			{
				this.GetOrCreatePoco().MinWaitStreamDuration = value;
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x060027AF RID: 10159 RVA: 0x0006978A File Offset: 0x0006798A
		// (set) Token: 0x060027B0 RID: 10160 RVA: 0x000697B9 File Offset: 0x000679B9
		public virtual float MaxWaitStreamDuration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxWaitStreamDuration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MaxWaitStreamDuration;
			}
			set
			{
				this.GetOrCreatePoco().MaxWaitStreamDuration = value;
			}
		}

		// Token: 0x04001ABF RID: 6847
		[Nullable(2)]
		protected IStreamingWaitConfig FbInstance;

		// Token: 0x04001AC0 RID: 6848
		[Nullable(2)]
		protected IStreamingWaitConfig_SetValue PocoInterface;
	}
}
