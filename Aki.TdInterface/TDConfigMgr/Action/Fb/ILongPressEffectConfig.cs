using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028D1 RID: 10449
	[NullableContext(2)]
	[Nullable(0)]
	public class ILongPressEffectConfig
	{
		// Token: 0x0600E895 RID: 59541 RVA: 0x00225DF2 File Offset: 0x00223FF2
		[NullableContext(0)]
		public static ILongPressEffectConfig Create(ILongPressEffectConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILongPressEffectConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043A1 RID: 17313
		// (get) Token: 0x0600E896 RID: 59542 RVA: 0x00225E11 File Offset: 0x00224011
		public virtual string CameraShakeBpPath
		{
			get
			{
				return this.Instance.CameraShakeBpPath;
			}
		}

		// Token: 0x170043A2 RID: 17314
		// (get) Token: 0x0600E897 RID: 59543 RVA: 0x00225E1E File Offset: 0x0022401E
		public virtual string LongPressSound
		{
			get
			{
				return this.Instance.LongPressSound;
			}
		}

		// Token: 0x170043A3 RID: 17315
		// (get) Token: 0x0600E898 RID: 59544 RVA: 0x00225E2B File Offset: 0x0022402B
		public virtual IGamePadInteractVibration GamePadVibration
		{
			get
			{
				if (this._GamePadVibrationInited)
				{
					return this._GamePadVibrationCache;
				}
				this._GamePadVibrationInited = true;
				this._GamePadVibrationCache = IGamePadInteractVibration.Create(this.Instance.GamePadVibration);
				return this._GamePadVibrationCache;
			}
		}

		// Token: 0x170043A4 RID: 17316
		// (get) Token: 0x0600E899 RID: 59545 RVA: 0x00225E5F File Offset: 0x0022405F
		public virtual string LongPressScreenEffect
		{
			get
			{
				return this.Instance.LongPressScreenEffect;
			}
		}

		// Token: 0x170043A5 RID: 17317
		// (get) Token: 0x0600E89A RID: 59546 RVA: 0x00225E6C File Offset: 0x0022406C
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<string> PlayEffects
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._PlayEffectsInited)
				{
					return this._PlayEffectsCache;
				}
				this._PlayEffectsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int playEffectsLength = this.Instance.PlayEffectsLength;
				this._PlayEffectsCache = new List<string>(playEffectsLength);
				for (int i = 0; i < playEffectsLength; i++)
				{
					this._PlayEffectsCache.Add(this.Instance.PlayEffects(i));
				}
				return this._PlayEffectsCache;
			}
		}

		// Token: 0x0400801D RID: 32797
		private ILongPressEffectConfig Instance;

		// Token: 0x0400801E RID: 32798
		private IGamePadInteractVibration _GamePadVibrationCache;

		// Token: 0x0400801F RID: 32799
		private bool _GamePadVibrationInited;

		// Token: 0x04008020 RID: 32800
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<string> _PlayEffectsCache;

		// Token: 0x04008021 RID: 32801
		private bool _PlayEffectsInited;
	}
}
