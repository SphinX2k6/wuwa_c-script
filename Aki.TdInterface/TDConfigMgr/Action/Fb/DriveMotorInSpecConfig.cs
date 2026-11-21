using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DA0 RID: 11680
	public class DriveMotorInSpecConfig : ActionParams
	{
		// Token: 0x0600FE87 RID: 65159 RVA: 0x0024B644 File Offset: 0x00249844
		public static DriveMotorInSpecConfig Create(IDriveMotorInSpecConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DriveMotorInSpecConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004FF5 RID: 20469
		// (get) Token: 0x0600FE88 RID: 65160 RVA: 0x0024B663 File Offset: 0x00249863
		public virtual IMotorParamsChangeConfig MotorParamsChangeConfig
		{
			get
			{
				if (this._MotorParamsChangeConfigInited)
				{
					return this._MotorParamsChangeConfigCache;
				}
				this._MotorParamsChangeConfigInited = true;
				this._MotorParamsChangeConfigCache = ActionReadHelper.ReadDriveMotorInSpecConfig_MotorParamsChangeConfig(this.Instance);
				return this._MotorParamsChangeConfigCache;
			}
		}

		// Token: 0x17004FF6 RID: 20470
		// (get) Token: 0x0600FE89 RID: 65161 RVA: 0x0024B694 File Offset: 0x00249894
		public virtual bool? IsEnableNitrogen
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsEnableNitrogen);
			}
		}

		// Token: 0x17004FF7 RID: 20471
		// (get) Token: 0x0600FE8A RID: 65162 RVA: 0x0024B6CC File Offset: 0x002498CC
		[Nullable(2)]
		public virtual List<EPlayerInputConstraintType> DisableInput
		{
			[NullableContext(2)]
			get
			{
				if (this._DisableInputInited)
				{
					return this._DisableInputCache;
				}
				this._DisableInputInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int disableInputLength = this.Instance.DisableInputLength;
				this._DisableInputCache = new List<EPlayerInputConstraintType>(disableInputLength);
				for (int i = 0; i < disableInputLength; i++)
				{
					this._DisableInputCache.Add((EPlayerInputConstraintType)this.Instance.DisableInput(i));
				}
				return this._DisableInputCache;
			}
		}

		// Token: 0x17004FF8 RID: 20472
		// (get) Token: 0x0600FE8B RID: 65163 RVA: 0x0024B741 File Offset: 0x00249941
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x17004FF9 RID: 20473
		// (get) Token: 0x0600FE8C RID: 65164 RVA: 0x0024B750 File Offset: 0x00249950
		public virtual bool? IsAffectedByTimeStop
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsAffectedByTimeStop);
			}
		}

		// Token: 0x17004FFA RID: 20474
		// (get) Token: 0x0600FE8D RID: 65165 RVA: 0x0024B788 File Offset: 0x00249988
		public virtual bool? CanBeInterrupted
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.CanBeInterrupted);
			}
		}

		// Token: 0x04008AF2 RID: 35570
		private IDriveMotorInSpecConfig Instance;

		// Token: 0x04008AF3 RID: 35571
		private IMotorParamsChangeConfig _MotorParamsChangeConfigCache;

		// Token: 0x04008AF4 RID: 35572
		private bool _MotorParamsChangeConfigInited;

		// Token: 0x04008AF5 RID: 35573
		[Nullable(2)]
		private List<EPlayerInputConstraintType> _DisableInputCache;

		// Token: 0x04008AF6 RID: 35574
		private bool _DisableInputInited;
	}
}
