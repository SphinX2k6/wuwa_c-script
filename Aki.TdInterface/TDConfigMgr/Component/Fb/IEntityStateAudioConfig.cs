using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BA1 RID: 2977
	public class IEntityStateAudioConfig
	{
		// Token: 0x0600441A RID: 17434 RVA: 0x000ACD6E File Offset: 0x000AAF6E
		public static IEntityStateAudioConfig Create(IEntityStateAudioConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityStateAudioConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170010D3 RID: 4307
		// (get) Token: 0x0600441B RID: 17435 RVA: 0x000ACD8D File Offset: 0x000AAF8D
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x170010D4 RID: 4308
		// (get) Token: 0x0600441C RID: 17436 RVA: 0x000ACD9A File Offset: 0x000AAF9A
		public virtual string AkEvent
		{
			get
			{
				return this.Instance.AkEvent;
			}
		}

		// Token: 0x170010D5 RID: 4309
		// (get) Token: 0x0600441D RID: 17437 RVA: 0x000ACDA7 File Offset: 0x000AAFA7
		[Nullable(2)]
		public virtual string LeaveAkEvent
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.LeaveAkEvent;
			}
		}

		// Token: 0x170010D6 RID: 4310
		// (get) Token: 0x0600441E RID: 17438 RVA: 0x000ACDB4 File Offset: 0x000AAFB4
		[Nullable(2)]
		public virtual IAudioFade AudioFade
		{
			[NullableContext(2)]
			get
			{
				if (this._AudioFadeInited)
				{
					return this._AudioFadeCache;
				}
				this._AudioFadeInited = true;
				this._AudioFadeCache = IAudioFade.Create(this.Instance.AudioFade);
				return this._AudioFadeCache;
			}
		}

		// Token: 0x170010D7 RID: 4311
		// (get) Token: 0x0600441F RID: 17439 RVA: 0x000ACDE8 File Offset: 0x000AAFE8
		public virtual bool? IsBanVehicleRadio
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsBanVehicleRadio);
			}
		}

		// Token: 0x040025B6 RID: 9654
		private IEntityStateAudioConfig Instance;

		// Token: 0x040025B7 RID: 9655
		[Nullable(2)]
		private IAudioFade _AudioFadeCache;

		// Token: 0x040025B8 RID: 9656
		private bool _AudioFadeInited;
	}
}
