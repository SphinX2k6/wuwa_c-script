using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200171B RID: 5915
	[NullableContext(2)]
	[Nullable(0)]
	[JsonConverter(typeof(FadeInScreenConverter))]
	public class FadeInScreen : ActionParams
	{
		// Token: 0x06007D47 RID: 32071 RVA: 0x0012CA44 File Offset: 0x0012AC44
		[NullableContext(1)]
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

		// Token: 0x06007D48 RID: 32072 RVA: 0x0012CA7C File Offset: 0x0012AC7C
		[NullableContext(1)]
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

		// Token: 0x06007D49 RID: 32073 RVA: 0x0012CA8F File Offset: 0x0012AC8F
		[NullableContext(1)]
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

		// Token: 0x06007D4A RID: 32074 RVA: 0x0012CAA4 File Offset: 0x0012ACA4
		[NullableContext(1)]
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

		// Token: 0x1700294B RID: 10571
		// (get) Token: 0x06007D4B RID: 32075 RVA: 0x0012CB0C File Offset: 0x0012AD0C
		// (set) Token: 0x06007D4C RID: 32076 RVA: 0x0012CB46 File Offset: 0x0012AD46
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

		// Token: 0x1700294C RID: 10572
		// (get) Token: 0x06007D4D RID: 32077 RVA: 0x0012CB54 File Offset: 0x0012AD54
		// (set) Token: 0x06007D4E RID: 32078 RVA: 0x0012CBB5 File Offset: 0x0012ADB5
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

		// Token: 0x1700294D RID: 10573
		// (get) Token: 0x06007D4F RID: 32079 RVA: 0x0012CBCC File Offset: 0x0012ADCC
		// (set) Token: 0x06007D50 RID: 32080 RVA: 0x0012CC06 File Offset: 0x0012AE06
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

		// Token: 0x1700294E RID: 10574
		// (get) Token: 0x06007D51 RID: 32081 RVA: 0x0012CC14 File Offset: 0x0012AE14
		// (set) Token: 0x06007D52 RID: 32082 RVA: 0x0012CC4E File Offset: 0x0012AE4E
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

		// Token: 0x1700294F RID: 10575
		// (get) Token: 0x06007D53 RID: 32083 RVA: 0x0012CC5C File Offset: 0x0012AE5C
		// (set) Token: 0x06007D54 RID: 32084 RVA: 0x0012CC96 File Offset: 0x0012AE96
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

		// Token: 0x17002950 RID: 10576
		// (get) Token: 0x06007D55 RID: 32085 RVA: 0x0012CCA4 File Offset: 0x0012AEA4
		// (set) Token: 0x06007D56 RID: 32086 RVA: 0x0012CCCB File Offset: 0x0012AECB
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

		// Token: 0x17002951 RID: 10577
		// (get) Token: 0x06007D57 RID: 32087 RVA: 0x0012CCDC File Offset: 0x0012AEDC
		// (set) Token: 0x06007D58 RID: 32088 RVA: 0x0012CD16 File Offset: 0x0012AF16
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

		// Token: 0x04004FF9 RID: 20473
		protected new FadeInScreen FbInstance;

		// Token: 0x04004FFA RID: 20474
		protected FadeInScreen_SetValue PocoInterface;

		// Token: 0x04004FFB RID: 20475
		[Nullable(1)]
		private IEaseData _EaseCache;

		// Token: 0x04004FFC RID: 20476
		private bool _EaseInited;
	}
}
