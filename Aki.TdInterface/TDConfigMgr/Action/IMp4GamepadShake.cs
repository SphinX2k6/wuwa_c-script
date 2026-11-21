using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E41 RID: 7745
	[NullableContext(2)]
	[Nullable(0)]
	public class IMp4GamepadShake : IGamepadShakeConfig
	{
		// Token: 0x0600A4B3 RID: 42163 RVA: 0x00178128 File Offset: 0x00176328
		[NullableContext(0)]
		private IMp4GamepadShake_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMp4GamepadShake 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMp4GamepadShake_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMp4GamepadShake_SetValue());
			}
			return result;
		}

		// Token: 0x0600A4B4 RID: 42164 RVA: 0x00178160 File Offset: 0x00176360
		[NullableContext(0)]
		public static IMp4GamepadShake Create([Nullable(2)] IMp4GamepadShake instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMp4GamepadShake
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A4B5 RID: 42165 RVA: 0x00178173 File Offset: 0x00176373
		[NullableContext(0)]
		public static IMp4GamepadShake CreateFromSetValue([Nullable(2)] IMp4GamepadShake_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMp4GamepadShake
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A4B6 RID: 42166 RVA: 0x00178186 File Offset: 0x00176386
		[NullableContext(0)]
		public new IMp4GamepadShake_SetValue ToSetValue()
		{
			return new IMp4GamepadShake_SetValue
			{
				Type = this.Type,
				FadeInConfig = this.FadeInConfig,
				FadeOutConfig = this.FadeOutConfig,
				ShakeScale = this.ShakeScale
			};
		}

		// Token: 0x17003306 RID: 13062
		// (get) Token: 0x0600A4B7 RID: 42167 RVA: 0x001781BD File Offset: 0x001763BD
		// (set) Token: 0x0600A4B8 RID: 42168 RVA: 0x001781E8 File Offset: 0x001763E8
		public override EGamepadShakeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EGamepadShakeType.Onetime;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003307 RID: 13063
		// (get) Token: 0x0600A4B9 RID: 42169 RVA: 0x001781F8 File Offset: 0x001763F8
		// (set) Token: 0x0600A4BA RID: 42170 RVA: 0x00178259 File Offset: 0x00176459
		public virtual IMp4GamepadShakeFadeInConfig FadeInConfig
		{
			get
			{
				if (this._FadeInConfigInited)
				{
					return this._FadeInConfigCache;
				}
				this._FadeInConfigInited = true;
				if (this.FbInstance != null)
				{
					this._FadeInConfigCache = IMp4GamepadShakeFadeInConfig.Create(this.FbInstance.FadeInConfig);
				}
				else
				{
					IMp4GamepadShake_SetValue pocoInterface = this.PocoInterface;
					this._FadeInConfigCache = ((pocoInterface != null) ? pocoInterface.FadeInConfig : null);
				}
				return this._FadeInConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().FadeInConfig = value;
				this._FadeInConfigInited = false;
			}
		}

		// Token: 0x17003308 RID: 13064
		// (get) Token: 0x0600A4BB RID: 42171 RVA: 0x00178270 File Offset: 0x00176470
		// (set) Token: 0x0600A4BC RID: 42172 RVA: 0x001782D1 File Offset: 0x001764D1
		public virtual IMp4GamepadShakeFadeOutConfig FadeOutConfig
		{
			get
			{
				if (this._FadeOutConfigInited)
				{
					return this._FadeOutConfigCache;
				}
				this._FadeOutConfigInited = true;
				if (this.FbInstance != null)
				{
					this._FadeOutConfigCache = IMp4GamepadShakeFadeOutConfig.Create(this.FbInstance.FadeOutConfig);
				}
				else
				{
					IMp4GamepadShake_SetValue pocoInterface = this.PocoInterface;
					this._FadeOutConfigCache = ((pocoInterface != null) ? pocoInterface.FadeOutConfig : null);
				}
				return this._FadeOutConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().FadeOutConfig = value;
				this._FadeOutConfigInited = false;
			}
		}

		// Token: 0x17003309 RID: 13065
		// (get) Token: 0x0600A4BD RID: 42173 RVA: 0x001782E8 File Offset: 0x001764E8
		// (set) Token: 0x0600A4BE RID: 42174 RVA: 0x00178322 File Offset: 0x00176522
		public virtual float? ShakeScale
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShakeScale;
				}
				IMp4GamepadShake_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ShakeScale;
			}
			set
			{
				this.GetOrCreatePoco().ShakeScale = value;
			}
		}

		// Token: 0x04006395 RID: 25493
		protected new IMp4GamepadShake FbInstance;

		// Token: 0x04006396 RID: 25494
		protected new IMp4GamepadShake_SetValue PocoInterface;

		// Token: 0x04006397 RID: 25495
		[Nullable(0)]
		private IMp4GamepadShakeFadeInConfig _FadeInConfigCache;

		// Token: 0x04006398 RID: 25496
		private bool _FadeInConfigInited;

		// Token: 0x04006399 RID: 25497
		[Nullable(0)]
		private IMp4GamepadShakeFadeOutConfig _FadeOutConfigCache;

		// Token: 0x0400639A RID: 25498
		private bool _FadeOutConfigInited;
	}
}
