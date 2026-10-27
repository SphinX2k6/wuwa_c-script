using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C42 RID: 7234
	[NullableContext(1)]
	[Nullable(0)]
	public class IMovieModeFadeOutMaskConfig
	{
		// Token: 0x06009B2F RID: 39727 RVA: 0x001648B8 File Offset: 0x00162AB8
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

		// Token: 0x06009B30 RID: 39728 RVA: 0x001648F0 File Offset: 0x00162AF0
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

		// Token: 0x06009B31 RID: 39729 RVA: 0x00164903 File Offset: 0x00162B03
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

		// Token: 0x06009B32 RID: 39730 RVA: 0x00164916 File Offset: 0x00162B16
		public IMovieModeFadeOutMaskConfig_SetValue ToSetValue()
		{
			return new IMovieModeFadeOutMaskConfig_SetValue
			{
				IsEnableMask = this.IsEnableMask,
				TransitionTime = this.TransitionTime
			};
		}

		// Token: 0x1700308B RID: 12427
		// (get) Token: 0x06009B33 RID: 39731 RVA: 0x00164938 File Offset: 0x00162B38
		// (set) Token: 0x06009B34 RID: 39732 RVA: 0x00164972 File Offset: 0x00162B72
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

		// Token: 0x1700308C RID: 12428
		// (get) Token: 0x06009B35 RID: 39733 RVA: 0x00164980 File Offset: 0x00162B80
		// (set) Token: 0x06009B36 RID: 39734 RVA: 0x001649BA File Offset: 0x00162BBA
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

		// Token: 0x04005E4A RID: 24138
		[Nullable(2)]
		protected IMovieModeFadeOutMaskConfig FbInstance;

		// Token: 0x04005E4B RID: 24139
		[Nullable(2)]
		protected IMovieModeFadeOutMaskConfig_SetValue PocoInterface;
	}
}
