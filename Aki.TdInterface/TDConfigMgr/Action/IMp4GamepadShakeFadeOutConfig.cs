using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C4E RID: 7246
	[NullableContext(1)]
	[Nullable(0)]
	public class IMp4GamepadShakeFadeOutConfig
	{
		// Token: 0x06009B73 RID: 39795 RVA: 0x00165120 File Offset: 0x00163320
		private IMp4GamepadShakeFadeOutConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMp4GamepadShakeFadeOutConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMp4GamepadShakeFadeOutConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMp4GamepadShakeFadeOutConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009B74 RID: 39796 RVA: 0x00165158 File Offset: 0x00163358
		public static IMp4GamepadShakeFadeOutConfig Create([Nullable(2)] IMp4GamepadShakeFadeOutConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMp4GamepadShakeFadeOutConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009B75 RID: 39797 RVA: 0x0016516B File Offset: 0x0016336B
		public static IMp4GamepadShakeFadeOutConfig CreateFromSetValue([Nullable(2)] IMp4GamepadShakeFadeOutConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMp4GamepadShakeFadeOutConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009B76 RID: 39798 RVA: 0x0016517E File Offset: 0x0016337E
		public IMp4GamepadShakeFadeOutConfig_SetValue ToSetValue()
		{
			return new IMp4GamepadShakeFadeOutConfig_SetValue
			{
				FadeOutTime = this.FadeOutTime,
				FadeOutCurve = this.FadeOutCurve
			};
		}

		// Token: 0x1700309B RID: 12443
		// (get) Token: 0x06009B77 RID: 39799 RVA: 0x001651A0 File Offset: 0x001633A0
		// (set) Token: 0x06009B78 RID: 39800 RVA: 0x001651DA File Offset: 0x001633DA
		public virtual float? FadeOutTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeOutTime;
				}
				IMp4GamepadShakeFadeOutConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FadeOutTime;
			}
			set
			{
				this.GetOrCreatePoco().FadeOutTime = value;
			}
		}

		// Token: 0x1700309C RID: 12444
		// (get) Token: 0x06009B79 RID: 39801 RVA: 0x001651E8 File Offset: 0x001633E8
		// (set) Token: 0x06009B7A RID: 39802 RVA: 0x00165222 File Offset: 0x00163422
		public virtual EMp4GamepadShakeCurve? FadeOutCurve
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeOutCurve;
				}
				IMp4GamepadShakeFadeOutConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FadeOutCurve;
			}
			set
			{
				this.GetOrCreatePoco().FadeOutCurve = value;
			}
		}

		// Token: 0x04005E6C RID: 24172
		[Nullable(2)]
		protected IMp4GamepadShakeFadeOutConfig FbInstance;

		// Token: 0x04005E6D RID: 24173
		[Nullable(2)]
		protected IMp4GamepadShakeFadeOutConfig_SetValue PocoInterface;
	}
}
