using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200171D RID: 5917
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(FadeOutScreenConverter))]
	public class FadeOutScreen : ActionParams
	{
		// Token: 0x06007D5B RID: 32091 RVA: 0x0012CD34 File Offset: 0x0012AF34
		private FadeOutScreen_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("FadeOutScreen 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			FadeOutScreen_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new FadeOutScreen_SetValue());
			}
			return result;
		}

		// Token: 0x06007D5C RID: 32092 RVA: 0x0012CD6C File Offset: 0x0012AF6C
		public static FadeOutScreen Create([Nullable(2)] FadeOutScreen instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FadeOutScreen
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007D5D RID: 32093 RVA: 0x0012CD7F File Offset: 0x0012AF7F
		public static FadeOutScreen CreateFromSetValue([Nullable(2)] FadeOutScreen_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new FadeOutScreen
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007D5E RID: 32094 RVA: 0x0012CD92 File Offset: 0x0012AF92
		public FadeOutScreen_SetValue ToSetValue()
		{
			return new FadeOutScreen_SetValue
			{
				Ease = this.Ease,
				OnlyLowMemoryDeviceExecute = this.OnlyLowMemoryDeviceExecute
			};
		}

		// Token: 0x17002952 RID: 10578
		// (get) Token: 0x06007D5F RID: 32095 RVA: 0x0012CDB4 File Offset: 0x0012AFB4
		// (set) Token: 0x06007D60 RID: 32096 RVA: 0x0012CE15 File Offset: 0x0012B015
		[Nullable(2)]
		public virtual IEaseData Ease
		{
			[NullableContext(2)]
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
					FadeOutScreen_SetValue pocoInterface = this.PocoInterface;
					this._EaseCache = ((pocoInterface != null) ? pocoInterface.Ease : null);
				}
				return this._EaseCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().Ease = value;
				this._EaseInited = false;
			}
		}

		// Token: 0x17002953 RID: 10579
		// (get) Token: 0x06007D61 RID: 32097 RVA: 0x0012CE2C File Offset: 0x0012B02C
		// (set) Token: 0x06007D62 RID: 32098 RVA: 0x0012CE66 File Offset: 0x0012B066
		public virtual bool? OnlyLowMemoryDeviceExecute
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OnlyLowMemoryDeviceExecute;
				}
				FadeOutScreen_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04005004 RID: 20484
		[Nullable(2)]
		protected new FadeOutScreen FbInstance;

		// Token: 0x04005005 RID: 20485
		[Nullable(2)]
		protected FadeOutScreen_SetValue PocoInterface;

		// Token: 0x04005006 RID: 20486
		private IEaseData _EaseCache;

		// Token: 0x04005007 RID: 20487
		private bool _EaseInited;
	}
}
