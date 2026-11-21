using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BF9 RID: 11257
	[NullableContext(2)]
	[Nullable(0)]
	public class IMp4GamepadShake : IGamepadShakeConfig
	{
		// Token: 0x0600F7EA RID: 63466 RVA: 0x00241032 File Offset: 0x0023F232
		[NullableContext(0)]
		public static IMp4GamepadShake Create(IMp4GamepadShake? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMp4GamepadShake
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CA6 RID: 19622
		// (get) Token: 0x0600F7EB RID: 63467 RVA: 0x00241051 File Offset: 0x0023F251
		public override EGamepadShakeType Type
		{
			get
			{
				return (EGamepadShakeType)this.Instance.Type;
			}
		}

		// Token: 0x17004CA7 RID: 19623
		// (get) Token: 0x0600F7EC RID: 63468 RVA: 0x0024105E File Offset: 0x0023F25E
		public virtual IMp4GamepadShakeFadeInConfig FadeInConfig
		{
			get
			{
				if (this._FadeInConfigInited)
				{
					return this._FadeInConfigCache;
				}
				this._FadeInConfigInited = true;
				this._FadeInConfigCache = IMp4GamepadShakeFadeInConfig.Create(this.Instance.FadeInConfig);
				return this._FadeInConfigCache;
			}
		}

		// Token: 0x17004CA8 RID: 19624
		// (get) Token: 0x0600F7ED RID: 63469 RVA: 0x00241092 File Offset: 0x0023F292
		public virtual IMp4GamepadShakeFadeOutConfig FadeOutConfig
		{
			get
			{
				if (this._FadeOutConfigInited)
				{
					return this._FadeOutConfigCache;
				}
				this._FadeOutConfigInited = true;
				this._FadeOutConfigCache = IMp4GamepadShakeFadeOutConfig.Create(this.Instance.FadeOutConfig);
				return this._FadeOutConfigCache;
			}
		}

		// Token: 0x17004CA9 RID: 19625
		// (get) Token: 0x0600F7EE RID: 63470 RVA: 0x002410C8 File Offset: 0x0023F2C8
		public virtual float? ShakeScale
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.ShakeScale);
			}
		}

		// Token: 0x040087B1 RID: 34737
		private IMp4GamepadShake Instance;

		// Token: 0x040087B2 RID: 34738
		private IMp4GamepadShakeFadeInConfig _FadeInConfigCache;

		// Token: 0x040087B3 RID: 34739
		private bool _FadeInConfigInited;

		// Token: 0x040087B4 RID: 34740
		private IMp4GamepadShakeFadeOutConfig _FadeOutConfigCache;

		// Token: 0x040087B5 RID: 34741
		private bool _FadeOutConfigInited;
	}
}
