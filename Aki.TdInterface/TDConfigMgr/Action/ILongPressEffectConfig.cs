using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B9E RID: 7070
	[NullableContext(2)]
	[Nullable(0)]
	public class ILongPressEffectConfig
	{
		// Token: 0x0600975B RID: 38747 RVA: 0x0015D150 File Offset: 0x0015B350
		[NullableContext(1)]
		private ILongPressEffectConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILongPressEffectConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILongPressEffectConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILongPressEffectConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600975C RID: 38748 RVA: 0x0015D188 File Offset: 0x0015B388
		[NullableContext(1)]
		public static ILongPressEffectConfig Create([Nullable(2)] ILongPressEffectConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILongPressEffectConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600975D RID: 38749 RVA: 0x0015D19B File Offset: 0x0015B39B
		[NullableContext(1)]
		public static ILongPressEffectConfig CreateFromSetValue([Nullable(2)] ILongPressEffectConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILongPressEffectConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600975E RID: 38750 RVA: 0x0015D1B0 File Offset: 0x0015B3B0
		[NullableContext(1)]
		public ILongPressEffectConfig_SetValue ToSetValue()
		{
			return new ILongPressEffectConfig_SetValue
			{
				CameraShakeBpPath = this.CameraShakeBpPath,
				LongPressSound = this.LongPressSound,
				GamePadVibration = this.GamePadVibration,
				LongPressScreenEffect = this.LongPressScreenEffect,
				PlayEffects = this.PlayEffects
			};
		}

		// Token: 0x17002F97 RID: 12183
		// (get) Token: 0x0600975F RID: 38751 RVA: 0x0015D1FE File Offset: 0x0015B3FE
		// (set) Token: 0x06009760 RID: 38752 RVA: 0x0015D225 File Offset: 0x0015B425
		public virtual string CameraShakeBpPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CameraShakeBpPath;
				}
				ILongPressEffectConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CameraShakeBpPath;
			}
			set
			{
				this.GetOrCreatePoco().CameraShakeBpPath = value;
			}
		}

		// Token: 0x17002F98 RID: 12184
		// (get) Token: 0x06009761 RID: 38753 RVA: 0x0015D233 File Offset: 0x0015B433
		// (set) Token: 0x06009762 RID: 38754 RVA: 0x0015D25A File Offset: 0x0015B45A
		public virtual string LongPressSound
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LongPressSound;
				}
				ILongPressEffectConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LongPressSound;
			}
			set
			{
				this.GetOrCreatePoco().LongPressSound = value;
			}
		}

		// Token: 0x17002F99 RID: 12185
		// (get) Token: 0x06009763 RID: 38755 RVA: 0x0015D268 File Offset: 0x0015B468
		// (set) Token: 0x06009764 RID: 38756 RVA: 0x0015D2C9 File Offset: 0x0015B4C9
		public virtual IGamePadInteractVibration GamePadVibration
		{
			get
			{
				if (this._GamePadVibrationInited)
				{
					return this._GamePadVibrationCache;
				}
				this._GamePadVibrationInited = true;
				if (this.FbInstance != null)
				{
					this._GamePadVibrationCache = IGamePadInteractVibration.Create(this.FbInstance.GamePadVibration);
				}
				else
				{
					ILongPressEffectConfig_SetValue pocoInterface = this.PocoInterface;
					this._GamePadVibrationCache = ((pocoInterface != null) ? pocoInterface.GamePadVibration : null);
				}
				return this._GamePadVibrationCache;
			}
			set
			{
				this.GetOrCreatePoco().GamePadVibration = value;
				this._GamePadVibrationInited = false;
			}
		}

		// Token: 0x17002F9A RID: 12186
		// (get) Token: 0x06009765 RID: 38757 RVA: 0x0015D2DE File Offset: 0x0015B4DE
		// (set) Token: 0x06009766 RID: 38758 RVA: 0x0015D305 File Offset: 0x0015B505
		public virtual string LongPressScreenEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LongPressScreenEffect;
				}
				ILongPressEffectConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LongPressScreenEffect;
			}
			set
			{
				this.GetOrCreatePoco().LongPressScreenEffect = value;
			}
		}

		// Token: 0x17002F9B RID: 12187
		// (get) Token: 0x06009767 RID: 38759 RVA: 0x0015D313 File Offset: 0x0015B513
		// (set) Token: 0x06009768 RID: 38760 RVA: 0x0015D33A File Offset: 0x0015B53A
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
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlayEffects;
				}
				ILongPressEffectConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PlayEffects;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().PlayEffects = value;
			}
		}

		// Token: 0x04005C60 RID: 23648
		protected ILongPressEffectConfig FbInstance;

		// Token: 0x04005C61 RID: 23649
		protected ILongPressEffectConfig_SetValue PocoInterface;

		// Token: 0x04005C62 RID: 23650
		[Nullable(1)]
		private IGamePadInteractVibration _GamePadVibrationCache;

		// Token: 0x04005C63 RID: 23651
		private bool _GamePadVibrationInited;
	}
}
