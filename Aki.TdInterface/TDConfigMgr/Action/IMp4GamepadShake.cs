using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C4A RID: 7242
	[NullableContext(2)]
	[Nullable(0)]
	public class IMp4GamepadShake : IGamepadShakeConfig
	{
		// Token: 0x06009B5B RID: 39771 RVA: 0x00164DE8 File Offset: 0x00162FE8
		[NullableContext(1)]
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

		// Token: 0x06009B5C RID: 39772 RVA: 0x00164E20 File Offset: 0x00163020
		[NullableContext(1)]
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

		// Token: 0x06009B5D RID: 39773 RVA: 0x00164E33 File Offset: 0x00163033
		[NullableContext(1)]
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

		// Token: 0x06009B5E RID: 39774 RVA: 0x00164E46 File Offset: 0x00163046
		[NullableContext(1)]
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

		// Token: 0x17003095 RID: 12437
		// (get) Token: 0x06009B5F RID: 39775 RVA: 0x00164E7D File Offset: 0x0016307D
		// (set) Token: 0x06009B60 RID: 39776 RVA: 0x00164EA8 File Offset: 0x001630A8
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

		// Token: 0x17003096 RID: 12438
		// (get) Token: 0x06009B61 RID: 39777 RVA: 0x00164EB8 File Offset: 0x001630B8
		// (set) Token: 0x06009B62 RID: 39778 RVA: 0x00164F19 File Offset: 0x00163119
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

		// Token: 0x17003097 RID: 12439
		// (get) Token: 0x06009B63 RID: 39779 RVA: 0x00164F30 File Offset: 0x00163130
		// (set) Token: 0x06009B64 RID: 39780 RVA: 0x00164F91 File Offset: 0x00163191
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

		// Token: 0x17003098 RID: 12440
		// (get) Token: 0x06009B65 RID: 39781 RVA: 0x00164FA8 File Offset: 0x001631A8
		// (set) Token: 0x06009B66 RID: 39782 RVA: 0x00164FE2 File Offset: 0x001631E2
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

		// Token: 0x04005E5E RID: 24158
		protected new IMp4GamepadShake FbInstance;

		// Token: 0x04005E5F RID: 24159
		protected new IMp4GamepadShake_SetValue PocoInterface;

		// Token: 0x04005E60 RID: 24160
		[Nullable(1)]
		private IMp4GamepadShakeFadeInConfig _FadeInConfigCache;

		// Token: 0x04005E61 RID: 24161
		private bool _FadeInConfigInited;

		// Token: 0x04005E62 RID: 24162
		[Nullable(1)]
		private IMp4GamepadShakeFadeOutConfig _FadeOutConfigCache;

		// Token: 0x04005E63 RID: 24163
		private bool _FadeOutConfigInited;
	}
}
