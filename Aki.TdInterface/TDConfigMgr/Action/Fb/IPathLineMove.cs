using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028DA RID: 10458
	[NullableContext(1)]
	[Nullable(0)]
	public class IPathLineMove : ISplineMovePattern
	{
		// Token: 0x0600E83A RID: 59450 RVA: 0x002214E7 File Offset: 0x0021F6E7
		public static IPathLineMove Create(IPathLineMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPathLineMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004848 RID: 18504
		// (get) Token: 0x0600E83B RID: 59451 RVA: 0x00221506 File Offset: 0x0021F706
		public override ESplineMovePattern Type
		{
			get
			{
				return (ESplineMovePattern)this.Instance.Type;
			}
		}

		// Token: 0x17004849 RID: 18505
		// (get) Token: 0x0600E83C RID: 59452 RVA: 0x00221514 File Offset: 0x0021F714
		public override float? MaxOffsetDistance
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.MaxOffsetDistance);
			}
		}

		// Token: 0x1700484A RID: 18506
		// (get) Token: 0x0600E83D RID: 59453 RVA: 0x0022154C File Offset: 0x0021F74C
		public override bool? IsOneWay
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsOneWay);
			}
		}

		// Token: 0x1700484B RID: 18507
		// (get) Token: 0x0600E83E RID: 59454 RVA: 0x00221584 File Offset: 0x0021F784
		public override float? LayerVerticalLimit
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new float?(this.Instance.LayerVerticalLimit);
			}
		}

		// Token: 0x1700484C RID: 18508
		// (get) Token: 0x0600E83F RID: 59455 RVA: 0x002215BC File Offset: 0x0021F7BC
		public override bool? DynamicGravity
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DynamicGravity);
			}
		}

		// Token: 0x1700484D RID: 18509
		// (get) Token: 0x0600E840 RID: 59456 RVA: 0x002215F4 File Offset: 0x0021F7F4
		public override float? GravitySwitchAngularVelocity
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new float?(this.Instance.GravitySwitchAngularVelocity);
			}
		}

		// Token: 0x1700484E RID: 18510
		// (get) Token: 0x0600E841 RID: 59457 RVA: 0x0022162C File Offset: 0x0021F82C
		public override int? AutoExitDistance
		{
			get
			{
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				return new int?(this.Instance.AutoExitDistance);
			}
		}

		// Token: 0x1700484F RID: 18511
		// (get) Token: 0x0600E842 RID: 59458 RVA: 0x00221663 File Offset: 0x0021F863
		public virtual IPathLineFacingType FacingConfig
		{
			get
			{
				if (this._FacingConfigInited)
				{
					return this._FacingConfigCache;
				}
				this._FacingConfigInited = true;
				this._FacingConfigCache = ActionReadHelper.ReadIPathLineMove_FacingConfig(this.Instance);
				return this._FacingConfigCache;
			}
		}

		// Token: 0x17004850 RID: 18512
		// (get) Token: 0x0600E843 RID: 59459 RVA: 0x00221692 File Offset: 0x0021F892
		[Nullable(2)]
		public virtual string SplineMoveConfigDaPath
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.SplineMoveConfigDaPath;
			}
		}

		// Token: 0x17004851 RID: 18513
		// (get) Token: 0x0600E844 RID: 59460 RVA: 0x002216A0 File Offset: 0x0021F8A0
		public virtual bool? IsAdaptiveClimbInput
		{
			get
			{
				if ((this.Instance.NullMask & 64) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsAdaptiveClimbInput);
			}
		}

		// Token: 0x17004852 RID: 18514
		// (get) Token: 0x0600E845 RID: 59461 RVA: 0x002216D8 File Offset: 0x0021F8D8
		public virtual bool? IsDisableStopAnim
		{
			get
			{
				if ((this.Instance.NullMask & 128) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsDisableStopAnim);
			}
		}

		// Token: 0x17004853 RID: 18515
		// (get) Token: 0x0600E846 RID: 59462 RVA: 0x00221714 File Offset: 0x0021F914
		public virtual bool? IsAllowEarlyExitClimb
		{
			get
			{
				if ((this.Instance.NullMask & 256) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsAllowEarlyExitClimb);
			}
		}

		// Token: 0x04008058 RID: 32856
		private IPathLineMove Instance;

		// Token: 0x04008059 RID: 32857
		private IPathLineFacingType _FacingConfigCache;

		// Token: 0x0400805A RID: 32858
		private bool _FacingConfigInited;
	}
}
