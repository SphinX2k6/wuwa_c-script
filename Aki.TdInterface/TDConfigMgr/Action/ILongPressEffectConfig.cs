using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D85 RID: 7557
	[NullableContext(2)]
	[Nullable(0)]
	public class ILongPressEffectConfig
	{
		// Token: 0x0600A05F RID: 41055 RVA: 0x0016FC10 File Offset: 0x0016DE10
		[NullableContext(0)]
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

		// Token: 0x0600A060 RID: 41056 RVA: 0x0016FC48 File Offset: 0x0016DE48
		[NullableContext(0)]
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

		// Token: 0x0600A061 RID: 41057 RVA: 0x0016FC5B File Offset: 0x0016DE5B
		[NullableContext(0)]
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

		// Token: 0x0600A062 RID: 41058 RVA: 0x0016FC70 File Offset: 0x0016DE70
		[NullableContext(0)]
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

		// Token: 0x170031F6 RID: 12790
		// (get) Token: 0x0600A063 RID: 41059 RVA: 0x0016FCBE File Offset: 0x0016DEBE
		// (set) Token: 0x0600A064 RID: 41060 RVA: 0x0016FCE5 File Offset: 0x0016DEE5
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

		// Token: 0x170031F7 RID: 12791
		// (get) Token: 0x0600A065 RID: 41061 RVA: 0x0016FCF3 File Offset: 0x0016DEF3
		// (set) Token: 0x0600A066 RID: 41062 RVA: 0x0016FD1A File Offset: 0x0016DF1A
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

		// Token: 0x170031F8 RID: 12792
		// (get) Token: 0x0600A067 RID: 41063 RVA: 0x0016FD28 File Offset: 0x0016DF28
		// (set) Token: 0x0600A068 RID: 41064 RVA: 0x0016FD89 File Offset: 0x0016DF89
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

		// Token: 0x170031F9 RID: 12793
		// (get) Token: 0x0600A069 RID: 41065 RVA: 0x0016FD9E File Offset: 0x0016DF9E
		// (set) Token: 0x0600A06A RID: 41066 RVA: 0x0016FDC5 File Offset: 0x0016DFC5
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

		// Token: 0x170031FA RID: 12794
		// (get) Token: 0x0600A06B RID: 41067 RVA: 0x0016FDD3 File Offset: 0x0016DFD3
		// (set) Token: 0x0600A06C RID: 41068 RVA: 0x0016FDFA File Offset: 0x0016DFFA
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().PlayEffects = value;
			}
		}

		// Token: 0x04006175 RID: 24949
		protected ILongPressEffectConfig FbInstance;

		// Token: 0x04006176 RID: 24950
		protected ILongPressEffectConfig_SetValue PocoInterface;

		// Token: 0x04006177 RID: 24951
		[Nullable(0)]
		private IGamePadInteractVibration _GamePadVibrationCache;

		// Token: 0x04006178 RID: 24952
		private bool _GamePadVibrationInited;
	}
}
