using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001716 RID: 5910
	[NullableContext(2)]
	[Nullable(0)]
	public class ExitMovieMode : ActionParams
	{
		// Token: 0x06007D31 RID: 32049 RVA: 0x0012C798 File Offset: 0x0012A998
		[NullableContext(1)]
		private ExitMovieMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ExitMovieMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ExitMovieMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ExitMovieMode_SetValue());
			}
			return result;
		}

		// Token: 0x06007D32 RID: 32050 RVA: 0x0012C7D0 File Offset: 0x0012A9D0
		[NullableContext(1)]
		public static ExitMovieMode Create([Nullable(2)] ExitMovieMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExitMovieMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007D33 RID: 32051 RVA: 0x0012C7E3 File Offset: 0x0012A9E3
		[NullableContext(1)]
		public static ExitMovieMode CreateFromSetValue([Nullable(2)] ExitMovieMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ExitMovieMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007D34 RID: 32052 RVA: 0x0012C7F6 File Offset: 0x0012A9F6
		[NullableContext(1)]
		public ExitMovieMode_SetValue ToSetValue()
		{
			return new ExitMovieMode_SetValue
			{
				BorderAnimDuration = this.BorderAnimDuration,
				DurationType = this.DurationType,
				FadeOutMaskConfig = this.FadeOutMaskConfig
			};
		}

		// Token: 0x17002947 RID: 10567
		// (get) Token: 0x06007D35 RID: 32053 RVA: 0x0012C824 File Offset: 0x0012AA24
		// (set) Token: 0x06007D36 RID: 32054 RVA: 0x0012C85E File Offset: 0x0012AA5E
		public virtual float? BorderAnimDuration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BorderAnimDuration;
				}
				ExitMovieMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BorderAnimDuration;
			}
			set
			{
				this.GetOrCreatePoco().BorderAnimDuration = value;
			}
		}

		// Token: 0x17002948 RID: 10568
		// (get) Token: 0x06007D37 RID: 32055 RVA: 0x0012C86C File Offset: 0x0012AA6C
		// (set) Token: 0x06007D38 RID: 32056 RVA: 0x0012C893 File Offset: 0x0012AA93
		public virtual IEnterMovieModeDurationType DurationType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DurationType;
				}
				ExitMovieMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DurationType;
			}
			set
			{
				this.GetOrCreatePoco().DurationType = value;
			}
		}

		// Token: 0x17002949 RID: 10569
		// (get) Token: 0x06007D39 RID: 32057 RVA: 0x0012C8A4 File Offset: 0x0012AAA4
		// (set) Token: 0x06007D3A RID: 32058 RVA: 0x0012C905 File Offset: 0x0012AB05
		public virtual IMovieModeFadeOutMaskConfig FadeOutMaskConfig
		{
			get
			{
				if (this._FadeOutMaskConfigInited)
				{
					return this._FadeOutMaskConfigCache;
				}
				this._FadeOutMaskConfigInited = true;
				if (this.FbInstance != null)
				{
					this._FadeOutMaskConfigCache = IMovieModeFadeOutMaskConfig.Create(this.FbInstance.FadeOutMaskConfig);
				}
				else
				{
					ExitMovieMode_SetValue pocoInterface = this.PocoInterface;
					this._FadeOutMaskConfigCache = ((pocoInterface != null) ? pocoInterface.FadeOutMaskConfig : null);
				}
				return this._FadeOutMaskConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().FadeOutMaskConfig = value;
				this._FadeOutMaskConfigInited = false;
			}
		}

		// Token: 0x04004FEC RID: 20460
		protected new ExitMovieMode FbInstance;

		// Token: 0x04004FED RID: 20461
		protected ExitMovieMode_SetValue PocoInterface;

		// Token: 0x04004FEE RID: 20462
		[Nullable(1)]
		private IMovieModeFadeOutMaskConfig _FadeOutMaskConfigCache;

		// Token: 0x04004FEF RID: 20463
		private bool _FadeOutMaskConfigInited;
	}
}
