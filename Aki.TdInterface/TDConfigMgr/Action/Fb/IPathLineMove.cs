using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BAF RID: 11183
	public class IPathLineMove : ISplineMovePattern
	{
		// Token: 0x0600F669 RID: 63081 RVA: 0x0023E467 File Offset: 0x0023C667
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

		// Token: 0x17004BB9 RID: 19385
		// (get) Token: 0x0600F66A RID: 63082 RVA: 0x0023E486 File Offset: 0x0023C686
		public override ESplineMovePattern Type
		{
			get
			{
				return (ESplineMovePattern)this.Instance.Type;
			}
		}

		// Token: 0x17004BBA RID: 19386
		// (get) Token: 0x0600F66B RID: 63083 RVA: 0x0023E494 File Offset: 0x0023C694
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

		// Token: 0x17004BBB RID: 19387
		// (get) Token: 0x0600F66C RID: 63084 RVA: 0x0023E4CC File Offset: 0x0023C6CC
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

		// Token: 0x17004BBC RID: 19388
		// (get) Token: 0x0600F66D RID: 63085 RVA: 0x0023E504 File Offset: 0x0023C704
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

		// Token: 0x17004BBD RID: 19389
		// (get) Token: 0x0600F66E RID: 63086 RVA: 0x0023E53C File Offset: 0x0023C73C
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

		// Token: 0x17004BBE RID: 19390
		// (get) Token: 0x0600F66F RID: 63087 RVA: 0x0023E574 File Offset: 0x0023C774
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

		// Token: 0x17004BBF RID: 19391
		// (get) Token: 0x0600F670 RID: 63088 RVA: 0x0023E5AC File Offset: 0x0023C7AC
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

		// Token: 0x17004BC0 RID: 19392
		// (get) Token: 0x0600F671 RID: 63089 RVA: 0x0023E5E3 File Offset: 0x0023C7E3
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

		// Token: 0x17004BC1 RID: 19393
		// (get) Token: 0x0600F672 RID: 63090 RVA: 0x0023E612 File Offset: 0x0023C812
		[Nullable(2)]
		public virtual string SplineMoveConfigDaPath
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.SplineMoveConfigDaPath;
			}
		}

		// Token: 0x17004BC2 RID: 19394
		// (get) Token: 0x0600F673 RID: 63091 RVA: 0x0023E620 File Offset: 0x0023C820
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

		// Token: 0x17004BC3 RID: 19395
		// (get) Token: 0x0600F674 RID: 63092 RVA: 0x0023E658 File Offset: 0x0023C858
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

		// Token: 0x17004BC4 RID: 19396
		// (get) Token: 0x0600F675 RID: 63093 RVA: 0x0023E694 File Offset: 0x0023C894
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

		// Token: 0x04008717 RID: 34583
		private IPathLineMove Instance;

		// Token: 0x04008718 RID: 34584
		private IPathLineFacingType _FacingConfigCache;

		// Token: 0x04008719 RID: 34585
		private bool _FacingConfigInited;
	}
}
