using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200189A RID: 6298
	[JsonConverter(typeof(FadeOutScreenConverter))]
	public class FadeOutScreen : ActionParams
	{
		// Token: 0x06008439 RID: 33849 RVA: 0x0013BDE0 File Offset: 0x00139FE0
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

		// Token: 0x0600843A RID: 33850 RVA: 0x0013BE18 File Offset: 0x0013A018
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

		// Token: 0x0600843B RID: 33851 RVA: 0x0013BE2B File Offset: 0x0013A02B
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

		// Token: 0x0600843C RID: 33852 RVA: 0x0013BE3E File Offset: 0x0013A03E
		public FadeOutScreen_SetValue ToSetValue()
		{
			return new FadeOutScreen_SetValue
			{
				Ease = this.Ease,
				OnlyLowMemoryDeviceExecute = this.OnlyLowMemoryDeviceExecute
			};
		}

		// Token: 0x17002B3D RID: 11069
		// (get) Token: 0x0600843D RID: 33853 RVA: 0x0013BE60 File Offset: 0x0013A060
		// (set) Token: 0x0600843E RID: 33854 RVA: 0x0013BEC1 File Offset: 0x0013A0C1
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

		// Token: 0x17002B3E RID: 11070
		// (get) Token: 0x0600843F RID: 33855 RVA: 0x0013BED8 File Offset: 0x0013A0D8
		// (set) Token: 0x06008440 RID: 33856 RVA: 0x0013BF12 File Offset: 0x0013A112
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

		// Token: 0x04005433 RID: 21555
		[Nullable(2)]
		protected new FadeOutScreen FbInstance;

		// Token: 0x04005434 RID: 21556
		[Nullable(2)]
		protected FadeOutScreen_SetValue PocoInterface;

		// Token: 0x04005435 RID: 21557
		private IEaseData _EaseCache;

		// Token: 0x04005436 RID: 21558
		private bool _EaseInited;
	}
}
