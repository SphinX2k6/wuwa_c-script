using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AD7 RID: 2775
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityStateAudioConfig
	{
		// Token: 0x06003FF0 RID: 16368 RVA: 0x000A377A File Offset: 0x000A197A
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

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x06003FF1 RID: 16369 RVA: 0x000A3799 File Offset: 0x000A1999
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x06003FF2 RID: 16370 RVA: 0x000A37A6 File Offset: 0x000A19A6
		public virtual string AkEvent
		{
			get
			{
				return this.Instance.AkEvent;
			}
		}

		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x06003FF3 RID: 16371 RVA: 0x000A37B3 File Offset: 0x000A19B3
		[Nullable(2)]
		public virtual string LeaveAkEvent
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.LeaveAkEvent;
			}
		}

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x06003FF4 RID: 16372 RVA: 0x000A37C0 File Offset: 0x000A19C0
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

		// Token: 0x17001003 RID: 4099
		// (get) Token: 0x06003FF5 RID: 16373 RVA: 0x000A37F4 File Offset: 0x000A19F4
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

		// Token: 0x0400239A RID: 9114
		private IEntityStateAudioConfig Instance;

		// Token: 0x0400239B RID: 9115
		[Nullable(2)]
		private IAudioFade _AudioFadeCache;

		// Token: 0x0400239C RID: 9116
		private bool _AudioFadeInited;
	}
}
