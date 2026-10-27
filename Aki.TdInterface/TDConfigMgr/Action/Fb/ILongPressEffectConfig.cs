using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002611 RID: 9745
	[NullableContext(2)]
	[Nullable(0)]
	public class ILongPressEffectConfig
	{
		// Token: 0x0600DAC8 RID: 56008 RVA: 0x0020969E File Offset: 0x0020789E
		[NullableContext(1)]
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

		// Token: 0x17004068 RID: 16488
		// (get) Token: 0x0600DAC9 RID: 56009 RVA: 0x002096BD File Offset: 0x002078BD
		public virtual string CameraShakeBpPath
		{
			get
			{
				return this.Instance.CameraShakeBpPath;
			}
		}

		// Token: 0x17004069 RID: 16489
		// (get) Token: 0x0600DACA RID: 56010 RVA: 0x002096CA File Offset: 0x002078CA
		public virtual string LongPressSound
		{
			get
			{
				return this.Instance.LongPressSound;
			}
		}

		// Token: 0x1700406A RID: 16490
		// (get) Token: 0x0600DACB RID: 56011 RVA: 0x002096D7 File Offset: 0x002078D7
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

		// Token: 0x1700406B RID: 16491
		// (get) Token: 0x0600DACC RID: 56012 RVA: 0x0020970B File Offset: 0x0020790B
		public virtual string LongPressScreenEffect
		{
			get
			{
				return this.Instance.LongPressScreenEffect;
			}
		}

		// Token: 0x1700406C RID: 16492
		// (get) Token: 0x0600DACD RID: 56013 RVA: 0x00209718 File Offset: 0x00207918
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<string> PlayEffects
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x04007983 RID: 31107
		private ILongPressEffectConfig Instance;

		// Token: 0x04007984 RID: 31108
		private IGamePadInteractVibration _GamePadVibrationCache;

		// Token: 0x04007985 RID: 31109
		private bool _GamePadVibrationInited;

		// Token: 0x04007986 RID: 31110
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> _PlayEffectsCache;

		// Token: 0x04007987 RID: 31111
		private bool _PlayEffectsInited;
	}
}
