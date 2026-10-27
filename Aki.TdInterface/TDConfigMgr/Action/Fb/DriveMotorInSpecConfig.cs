using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AAC RID: 10924
	[NullableContext(1)]
	[Nullable(0)]
	public class DriveMotorInSpecConfig : ActionParams
	{
		// Token: 0x0600EFD1 RID: 61393 RVA: 0x0022D938 File Offset: 0x0022BB38
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

		// Token: 0x17004C3B RID: 19515
		// (get) Token: 0x0600EFD2 RID: 61394 RVA: 0x0022D957 File Offset: 0x0022BB57
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

		// Token: 0x17004C3C RID: 19516
		// (get) Token: 0x0600EFD3 RID: 61395 RVA: 0x0022D988 File Offset: 0x0022BB88
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

		// Token: 0x17004C3D RID: 19517
		// (get) Token: 0x0600EFD4 RID: 61396 RVA: 0x0022D9C0 File Offset: 0x0022BBC0
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

		// Token: 0x17004C3E RID: 19518
		// (get) Token: 0x0600EFD5 RID: 61397 RVA: 0x0022DA35 File Offset: 0x0022BC35
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x17004C3F RID: 19519
		// (get) Token: 0x0600EFD6 RID: 61398 RVA: 0x0022DA44 File Offset: 0x0022BC44
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

		// Token: 0x17004C40 RID: 19520
		// (get) Token: 0x0600EFD7 RID: 61399 RVA: 0x0022DA7C File Offset: 0x0022BC7C
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

		// Token: 0x040083EE RID: 33774
		private IDriveMotorInSpecConfig Instance;

		// Token: 0x040083EF RID: 33775
		private IMotorParamsChangeConfig _MotorParamsChangeConfigCache;

		// Token: 0x040083F0 RID: 33776
		private bool _MotorParamsChangeConfigInited;

		// Token: 0x040083F1 RID: 33777
		[Nullable(2)]
		private List<EPlayerInputConstraintType> _DisableInputCache;

		// Token: 0x040083F2 RID: 33778
		private bool _DisableInputInited;
	}
}
