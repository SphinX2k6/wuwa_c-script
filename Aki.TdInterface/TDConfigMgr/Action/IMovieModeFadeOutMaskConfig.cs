using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E39 RID: 7737
	public class IMovieModeFadeOutMaskConfig
	{
		// Token: 0x0600A487 RID: 42119 RVA: 0x00177BF8 File Offset: 0x00175DF8
		private IMovieModeFadeOutMaskConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMovieModeFadeOutMaskConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMovieModeFadeOutMaskConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMovieModeFadeOutMaskConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A488 RID: 42120 RVA: 0x00177C30 File Offset: 0x00175E30
		public static IMovieModeFadeOutMaskConfig Create([Nullable(2)] IMovieModeFadeOutMaskConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMovieModeFadeOutMaskConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A489 RID: 42121 RVA: 0x00177C43 File Offset: 0x00175E43
		public static IMovieModeFadeOutMaskConfig CreateFromSetValue([Nullable(2)] IMovieModeFadeOutMaskConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMovieModeFadeOutMaskConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A48A RID: 42122 RVA: 0x00177C56 File Offset: 0x00175E56
		public IMovieModeFadeOutMaskConfig_SetValue ToSetValue()
		{
			return new IMovieModeFadeOutMaskConfig_SetValue
			{
				IsEnableMask = this.IsEnableMask,
				TransitionTime = this.TransitionTime
			};
		}

		// Token: 0x170032FC RID: 13052
		// (get) Token: 0x0600A48B RID: 42123 RVA: 0x00177C78 File Offset: 0x00175E78
		// (set) Token: 0x0600A48C RID: 42124 RVA: 0x00177CB2 File Offset: 0x00175EB2
		public virtual bool? IsEnableMask
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsEnableMask;
				}
				IMovieModeFadeOutMaskConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsEnableMask;
			}
			set
			{
				this.GetOrCreatePoco().IsEnableMask = value;
			}
		}

		// Token: 0x170032FD RID: 13053
		// (get) Token: 0x0600A48D RID: 42125 RVA: 0x00177CC0 File Offset: 0x00175EC0
		// (set) Token: 0x0600A48E RID: 42126 RVA: 0x00177CFA File Offset: 0x00175EFA
		public virtual float? TransitionTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TransitionTime;
				}
				IMovieModeFadeOutMaskConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TransitionTime;
			}
			set
			{
				this.GetOrCreatePoco().TransitionTime = value;
			}
		}

		// Token: 0x04006381 RID: 25473
		[Nullable(2)]
		protected IMovieModeFadeOutMaskConfig FbInstance;

		// Token: 0x04006382 RID: 25474
		[Nullable(2)]
		protected IMovieModeFadeOutMaskConfig_SetValue PocoInterface;
	}
}
