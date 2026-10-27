using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200291D RID: 10525
	[NullableContext(2)]
	[Nullable(0)]
	public class IMp4GamepadShake : IGamepadShakeConfig
	{
		// Token: 0x0600E998 RID: 59800 RVA: 0x00223CDA File Offset: 0x00221EDA
		[NullableContext(1)]
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

		// Token: 0x17004920 RID: 18720
		// (get) Token: 0x0600E999 RID: 59801 RVA: 0x00223CF9 File Offset: 0x00221EF9
		public override EGamepadShakeType Type
		{
			get
			{
				return (EGamepadShakeType)this.Instance.Type;
			}
		}

		// Token: 0x17004921 RID: 18721
		// (get) Token: 0x0600E99A RID: 59802 RVA: 0x00223D06 File Offset: 0x00221F06
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

		// Token: 0x17004922 RID: 18722
		// (get) Token: 0x0600E99B RID: 59803 RVA: 0x00223D3A File Offset: 0x00221F3A
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

		// Token: 0x17004923 RID: 18723
		// (get) Token: 0x0600E99C RID: 59804 RVA: 0x00223D70 File Offset: 0x00221F70
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

		// Token: 0x040080E3 RID: 32995
		private IMp4GamepadShake Instance;

		// Token: 0x040080E4 RID: 32996
		private IMp4GamepadShakeFadeInConfig _FadeInConfigCache;

		// Token: 0x040080E5 RID: 32997
		private bool _FadeInConfigInited;

		// Token: 0x040080E6 RID: 32998
		private IMp4GamepadShakeFadeOutConfig _FadeOutConfigCache;

		// Token: 0x040080E7 RID: 32999
		private bool _FadeOutConfigInited;
	}
}
