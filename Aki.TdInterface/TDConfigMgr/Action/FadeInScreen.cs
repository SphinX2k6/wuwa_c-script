using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001898 RID: 6296
	[NullableContext(2)]
	[Nullable(0)]
	[JsonConverter(typeof(FadeInScreenConverter))]
	public class FadeInScreen : ActionParams
	{
		// Token: 0x06008425 RID: 33829 RVA: 0x0013BAF0 File Offset: 0x00139CF0
		[NullableContext(0)]
		private FadeInScreen_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("FadeInScreen 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			FadeInScreen_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new FadeInScreen_SetValue());
			}
			return result;
		}

		// Token: 0x06008426 RID: 33830 RVA: 0x0013BB28 File Offset: 0x00139D28
		[NullableContext(0)]
		public static FadeInScreen Create([Nullable(2)] FadeInScreen instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FadeInScreen
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008427 RID: 33831 RVA: 0x0013BB3B File Offset: 0x00139D3B
		[NullableContext(0)]
		public static FadeInScreen CreateFromSetValue([Nullable(2)] FadeInScreen_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new FadeInScreen
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008428 RID: 33832 RVA: 0x0013BB50 File Offset: 0x00139D50
		[NullableContext(0)]
		public FadeInScreen_SetValue ToSetValue()
		{
			return new FadeInScreen_SetValue
			{
				TypeOverride = this.TypeOverride,
				Ease = this.Ease,
				ScreenType = this.ScreenType,
				KeepFadeAfterTreeEnd = this.KeepFadeAfterTreeEnd,
				KeepFadeAfterTreeRollBack = this.KeepFadeAfterTreeRollBack,
				FadeBackground = this.FadeBackground,
				OnlyLowMemoryDeviceExecute = this.OnlyLowMemoryDeviceExecute
			};
		}

		// Token: 0x17002B36 RID: 11062
		// (get) Token: 0x06008429 RID: 33833 RVA: 0x0013BBB8 File Offset: 0x00139DB8
		// (set) Token: 0x0600842A RID: 33834 RVA: 0x0013BBF2 File Offset: 0x00139DF2
		public virtual EFadeUiOverride? TypeOverride
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TypeOverride;
				}
				FadeInScreen_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TypeOverride;
			}
			set
			{
				this.GetOrCreatePoco().TypeOverride = value;
			}
		}

		// Token: 0x17002B37 RID: 11063
		// (get) Token: 0x0600842B RID: 33835 RVA: 0x0013BC00 File Offset: 0x00139E00
		// (set) Token: 0x0600842C RID: 33836 RVA: 0x0013BC61 File Offset: 0x00139E61
		public virtual IEaseData Ease
		{
			get
			{
				if (this._EaseInited)
				{
					return this._EaseCache;
				}
				this._EaseInited = true;
				if (this.FbInstance != null)
				{
					this._EaseCache = IEaseData.Create(this.FbInstance.Ease);
				}
				else
				{
					FadeInScreen_SetValue pocoInterface = this.PocoInterface;
					this._EaseCache = ((pocoInterface != null) ? pocoInterface.Ease : null);
				}
				return this._EaseCache;
			}
			set
			{
				this.GetOrCreatePoco().Ease = value;
				this._EaseInited = false;
			}
		}

		// Token: 0x17002B38 RID: 11064
		// (get) Token: 0x0600842D RID: 33837 RVA: 0x0013BC78 File Offset: 0x00139E78
		// (set) Token: 0x0600842E RID: 33838 RVA: 0x0013BCB2 File Offset: 0x00139EB2
		public virtual EFadeInScreenShowType? ScreenType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ScreenType;
				}
				FadeInScreen_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ScreenType;
			}
			set
			{
				this.GetOrCreatePoco().ScreenType = value;
			}
		}

		// Token: 0x17002B39 RID: 11065
		// (get) Token: 0x0600842F RID: 33839 RVA: 0x0013BCC0 File Offset: 0x00139EC0
		// (set) Token: 0x06008430 RID: 33840 RVA: 0x0013BCFA File Offset: 0x00139EFA
		public virtual bool? KeepFadeAfterTreeEnd
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepFadeAfterTreeEnd;
				}
				FadeInScreen_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.KeepFadeAfterTreeEnd;
			}
			set
			{
				this.GetOrCreatePoco().KeepFadeAfterTreeEnd = value;
			}
		}

		// Token: 0x17002B3A RID: 11066
		// (get) Token: 0x06008431 RID: 33841 RVA: 0x0013BD08 File Offset: 0x00139F08
		// (set) Token: 0x06008432 RID: 33842 RVA: 0x0013BD42 File Offset: 0x00139F42
		public virtual bool? KeepFadeAfterTreeRollBack
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepFadeAfterTreeRollBack;
				}
				FadeInScreen_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.KeepFadeAfterTreeRollBack;
			}
			set
			{
				this.GetOrCreatePoco().KeepFadeAfterTreeRollBack = value;
			}
		}

		// Token: 0x17002B3B RID: 11067
		// (get) Token: 0x06008433 RID: 33843 RVA: 0x0013BD50 File Offset: 0x00139F50
		// (set) Token: 0x06008434 RID: 33844 RVA: 0x0013BD77 File Offset: 0x00139F77
		public virtual IFadeBackgroundType FadeBackground
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeBackground;
				}
				FadeInScreen_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FadeBackground;
			}
			set
			{
				this.GetOrCreatePoco().FadeBackground = value;
			}
		}

		// Token: 0x17002B3C RID: 11068
		// (get) Token: 0x06008435 RID: 33845 RVA: 0x0013BD88 File Offset: 0x00139F88
		// (set) Token: 0x06008436 RID: 33846 RVA: 0x0013BDC2 File Offset: 0x00139FC2
		public virtual bool? OnlyLowMemoryDeviceExecute
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OnlyLowMemoryDeviceExecute;
				}
				FadeInScreen_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OnlyLowMemoryDeviceExecute;
			}
			set
			{
				this.GetOrCreatePoco().OnlyLowMemoryDeviceExecute = value;
			}
		}

		// Token: 0x04005428 RID: 21544
		protected new FadeInScreen FbInstance;

		// Token: 0x04005429 RID: 21545
		protected FadeInScreen_SetValue PocoInterface;

		// Token: 0x0400542A RID: 21546
		[Nullable(0)]
		private IEaseData _EaseCache;

		// Token: 0x0400542B RID: 21547
		private bool _EaseInited;
	}
}
