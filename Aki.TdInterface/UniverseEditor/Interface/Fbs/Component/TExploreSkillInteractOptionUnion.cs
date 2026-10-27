using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C19 RID: 23577
	public class TExploreSkillInteractOptionUnion
	{
		// Token: 0x1700B1EE RID: 45550
		// (get) Token: 0x060286F1 RID: 165617 RVA: 0x005909F2 File Offset: 0x0058EBF2
		// (set) Token: 0x060286F2 RID: 165618 RVA: 0x005909FA File Offset: 0x0058EBFA
		public TExploreSkillInteractOption Type { get; set; }

		// Token: 0x1700B1EF RID: 45551
		// (get) Token: 0x060286F3 RID: 165619 RVA: 0x00590A03 File Offset: 0x0058EC03
		// (set) Token: 0x060286F4 RID: 165620 RVA: 0x00590A0B File Offset: 0x0058EC0B
		public object Value { get; set; }

		// Token: 0x060286F5 RID: 165621 RVA: 0x00590A14 File Offset: 0x0058EC14
		public TExploreSkillInteractOptionUnion()
		{
			this.Type = TExploreSkillInteractOption.NONE;
			this.Value = null;
		}

		// Token: 0x060286F6 RID: 165622 RVA: 0x00590A2A File Offset: 0x0058EC2A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060286F7 RID: 165623 RVA: 0x00590A3C File Offset: 0x0058EC3C
		public IExploreSkillArrowInteractPointT AsIExploreSkillArrowInteractPoint()
		{
			return this.As<IExploreSkillArrowInteractPointT>();
		}

		// Token: 0x060286F8 RID: 165624 RVA: 0x00590A44 File Offset: 0x0058EC44
		public static TExploreSkillInteractOptionUnion FromIExploreSkillArrowInteractPoint(IExploreSkillArrowInteractPointT _iexploreskillarrowinteractpoint)
		{
			return new TExploreSkillInteractOptionUnion
			{
				Type = TExploreSkillInteractOption.IExploreSkillArrowInteractPoint,
				Value = _iexploreskillarrowinteractpoint
			};
		}

		// Token: 0x060286F9 RID: 165625 RVA: 0x00590A59 File Offset: 0x0058EC59
		public IExploreSkillCustomT AsIExploreSkillCustom()
		{
			return this.As<IExploreSkillCustomT>();
		}

		// Token: 0x060286FA RID: 165626 RVA: 0x00590A61 File Offset: 0x0058EC61
		public static TExploreSkillInteractOptionUnion FromIExploreSkillCustom(IExploreSkillCustomT _iexploreskillcustom)
		{
			return new TExploreSkillInteractOptionUnion
			{
				Type = TExploreSkillInteractOption.IExploreSkillCustom,
				Value = _iexploreskillcustom
			};
		}

		// Token: 0x060286FB RID: 165627 RVA: 0x00590A76 File Offset: 0x0058EC76
		public IExploreSkillEavesdropT AsIExploreSkillEavesdrop()
		{
			return this.As<IExploreSkillEavesdropT>();
		}

		// Token: 0x060286FC RID: 165628 RVA: 0x00590A7E File Offset: 0x0058EC7E
		public static TExploreSkillInteractOptionUnion FromIExploreSkillEavesdrop(IExploreSkillEavesdropT _iexploreskilleavesdrop)
		{
			return new TExploreSkillInteractOptionUnion
			{
				Type = TExploreSkillInteractOption.IExploreSkillEavesdrop,
				Value = _iexploreskilleavesdrop
			};
		}

		// Token: 0x060286FD RID: 165629 RVA: 0x00590A93 File Offset: 0x0058EC93
		public IExploreSkillLonelyDollPollutantT AsIExploreSkillLonelyDollPollutant()
		{
			return this.As<IExploreSkillLonelyDollPollutantT>();
		}

		// Token: 0x060286FE RID: 165630 RVA: 0x00590A9B File Offset: 0x0058EC9B
		public static TExploreSkillInteractOptionUnion FromIExploreSkillLonelyDollPollutant(IExploreSkillLonelyDollPollutantT _iexploreskilllonelydollpollutant)
		{
			return new TExploreSkillInteractOptionUnion
			{
				Type = TExploreSkillInteractOption.IExploreSkillLonelyDollPollutant,
				Value = _iexploreskilllonelydollpollutant
			};
		}

		// Token: 0x060286FF RID: 165631 RVA: 0x00590AB0 File Offset: 0x0058ECB0
		public IExploreSkillMechascoutDragT AsIExploreSkillMechascoutDrag()
		{
			return this.As<IExploreSkillMechascoutDragT>();
		}

		// Token: 0x06028700 RID: 165632 RVA: 0x00590AB8 File Offset: 0x0058ECB8
		public static TExploreSkillInteractOptionUnion FromIExploreSkillMechascoutDrag(IExploreSkillMechascoutDragT _iexploreskillmechascoutdrag)
		{
			return new TExploreSkillInteractOptionUnion
			{
				Type = TExploreSkillInteractOption.IExploreSkillMechascoutDrag,
				Value = _iexploreskillmechascoutdrag
			};
		}

		// Token: 0x06028701 RID: 165633 RVA: 0x00590ACD File Offset: 0x0058ECCD
		public IExploreSkillPullGiantT AsIExploreSkillPullGiant()
		{
			return this.As<IExploreSkillPullGiantT>();
		}

		// Token: 0x06028702 RID: 165634 RVA: 0x00590AD5 File Offset: 0x0058ECD5
		public static TExploreSkillInteractOptionUnion FromIExploreSkillPullGiant(IExploreSkillPullGiantT _iexploreskillpullgiant)
		{
			return new TExploreSkillInteractOptionUnion
			{
				Type = TExploreSkillInteractOption.IExploreSkillPullGiant,
				Value = _iexploreskillpullgiant
			};
		}

		// Token: 0x06028703 RID: 165635 RVA: 0x00590AEA File Offset: 0x0058ECEA
		public IExploreSkillPullStatueT AsIExploreSkillPullStatue()
		{
			return this.As<IExploreSkillPullStatueT>();
		}

		// Token: 0x06028704 RID: 165636 RVA: 0x00590AF2 File Offset: 0x0058ECF2
		public static TExploreSkillInteractOptionUnion FromIExploreSkillPullStatue(IExploreSkillPullStatueT _iexploreskillpullstatue)
		{
			return new TExploreSkillInteractOptionUnion
			{
				Type = TExploreSkillInteractOption.IExploreSkillPullStatue,
				Value = _iexploreskillpullstatue
			};
		}

		// Token: 0x06028705 RID: 165637 RVA: 0x00590B07 File Offset: 0x0058ED07
		public IExploreSkillQuantumDiffusionT AsIExploreSkillQuantumDiffusion()
		{
			return this.As<IExploreSkillQuantumDiffusionT>();
		}

		// Token: 0x06028706 RID: 165638 RVA: 0x00590B0F File Offset: 0x0058ED0F
		public static TExploreSkillInteractOptionUnion FromIExploreSkillQuantumDiffusion(IExploreSkillQuantumDiffusionT _iexploreskillquantumdiffusion)
		{
			return new TExploreSkillInteractOptionUnion
			{
				Type = TExploreSkillInteractOption.IExploreSkillQuantumDiffusion,
				Value = _iexploreskillquantumdiffusion
			};
		}

		// Token: 0x06028707 RID: 165639 RVA: 0x00590B24 File Offset: 0x0058ED24
		public IExploreSkillRagDollCrushingRockT AsIExploreSkillRagDollCrushingRock()
		{
			return this.As<IExploreSkillRagDollCrushingRockT>();
		}

		// Token: 0x06028708 RID: 165640 RVA: 0x00590B2C File Offset: 0x0058ED2C
		public static TExploreSkillInteractOptionUnion FromIExploreSkillRagDollCrushingRock(IExploreSkillRagDollCrushingRockT _iexploreskillragdollcrushingrock)
		{
			return new TExploreSkillInteractOptionUnion
			{
				Type = TExploreSkillInteractOption.IExploreSkillRagDollCrushingRock,
				Value = _iexploreskillragdollcrushingrock
			};
		}

		// Token: 0x06028709 RID: 165641 RVA: 0x00590B42 File Offset: 0x0058ED42
		public IExploreSkillRagDollDestroySolidRockT AsIExploreSkillRagDollDestroySolidRock()
		{
			return this.As<IExploreSkillRagDollDestroySolidRockT>();
		}

		// Token: 0x0602870A RID: 165642 RVA: 0x00590B4A File Offset: 0x0058ED4A
		public static TExploreSkillInteractOptionUnion FromIExploreSkillRagDollDestroySolidRock(IExploreSkillRagDollDestroySolidRockT _iexploreskillragdolldestroysolidrock)
		{
			return new TExploreSkillInteractOptionUnion
			{
				Type = TExploreSkillInteractOption.IExploreSkillRagDollDestroySolidRock,
				Value = _iexploreskillragdolldestroysolidrock
			};
		}

		// Token: 0x0602870B RID: 165643 RVA: 0x00590B60 File Offset: 0x0058ED60
		public IExploreSkillStatueInteractPointT AsIExploreSkillStatueInteractPoint()
		{
			return this.As<IExploreSkillStatueInteractPointT>();
		}

		// Token: 0x0602870C RID: 165644 RVA: 0x00590B68 File Offset: 0x0058ED68
		public static TExploreSkillInteractOptionUnion FromIExploreSkillStatueInteractPoint(IExploreSkillStatueInteractPointT _iexploreskillstatueinteractpoint)
		{
			return new TExploreSkillInteractOptionUnion
			{
				Type = TExploreSkillInteractOption.IExploreSkillStatueInteractPoint,
				Value = _iexploreskillstatueinteractpoint
			};
		}

		// Token: 0x0602870D RID: 165645 RVA: 0x00590B7E File Offset: 0x0058ED7E
		public IFollowShooterInteractPointT AsIFollowShooterInteractPoint()
		{
			return this.As<IFollowShooterInteractPointT>();
		}

		// Token: 0x0602870E RID: 165646 RVA: 0x00590B86 File Offset: 0x0058ED86
		public static TExploreSkillInteractOptionUnion FromIFollowShooterInteractPoint(IFollowShooterInteractPointT _ifollowshooterinteractpoint)
		{
			return new TExploreSkillInteractOptionUnion
			{
				Type = TExploreSkillInteractOption.IFollowShooterInteractPoint,
				Value = _ifollowshooterinteractpoint
			};
		}

		// Token: 0x0602870F RID: 165647 RVA: 0x00590B9C File Offset: 0x0058ED9C
		public IFoxJumpInteractPointT AsIFoxJumpInteractPoint()
		{
			return this.As<IFoxJumpInteractPointT>();
		}

		// Token: 0x06028710 RID: 165648 RVA: 0x00590BA4 File Offset: 0x0058EDA4
		public static TExploreSkillInteractOptionUnion FromIFoxJumpInteractPoint(IFoxJumpInteractPointT _ifoxjumpinteractpoint)
		{
			return new TExploreSkillInteractOptionUnion
			{
				Type = TExploreSkillInteractOption.IFoxJumpInteractPoint,
				Value = _ifoxjumpinteractpoint
			};
		}

		// Token: 0x06028711 RID: 165649 RVA: 0x00590BBA File Offset: 0x0058EDBA
		public IMonsterSummonInteractPointT AsIMonsterSummonInteractPoint()
		{
			return this.As<IMonsterSummonInteractPointT>();
		}

		// Token: 0x06028712 RID: 165650 RVA: 0x00590BC2 File Offset: 0x0058EDC2
		public static TExploreSkillInteractOptionUnion FromIMonsterSummonInteractPoint(IMonsterSummonInteractPointT _imonstersummoninteractpoint)
		{
			return new TExploreSkillInteractOptionUnion
			{
				Type = TExploreSkillInteractOption.IMonsterSummonInteractPoint,
				Value = _imonstersummoninteractpoint
			};
		}

		// Token: 0x06028713 RID: 165651 RVA: 0x00590BD8 File Offset: 0x0058EDD8
		public static int Pack(FlatBufferBuilder builder, TExploreSkillInteractOptionUnion _o)
		{
			switch (_o.Type)
			{
			case TExploreSkillInteractOption.IExploreSkillArrowInteractPoint:
				return IExploreSkillArrowInteractPoint.Pack(builder, _o.AsIExploreSkillArrowInteractPoint()).Value;
			case TExploreSkillInteractOption.IExploreSkillCustom:
				return IExploreSkillCustom.Pack(builder, _o.AsIExploreSkillCustom()).Value;
			case TExploreSkillInteractOption.IExploreSkillEavesdrop:
				return IExploreSkillEavesdrop.Pack(builder, _o.AsIExploreSkillEavesdrop()).Value;
			case TExploreSkillInteractOption.IExploreSkillLonelyDollPollutant:
				return IExploreSkillLonelyDollPollutant.Pack(builder, _o.AsIExploreSkillLonelyDollPollutant()).Value;
			case TExploreSkillInteractOption.IExploreSkillMechascoutDrag:
				return IExploreSkillMechascoutDrag.Pack(builder, _o.AsIExploreSkillMechascoutDrag()).Value;
			case TExploreSkillInteractOption.IExploreSkillPullGiant:
				return IExploreSkillPullGiant.Pack(builder, _o.AsIExploreSkillPullGiant()).Value;
			case TExploreSkillInteractOption.IExploreSkillPullStatue:
				return IExploreSkillPullStatue.Pack(builder, _o.AsIExploreSkillPullStatue()).Value;
			case TExploreSkillInteractOption.IExploreSkillQuantumDiffusion:
				return IExploreSkillQuantumDiffusion.Pack(builder, _o.AsIExploreSkillQuantumDiffusion()).Value;
			case TExploreSkillInteractOption.IExploreSkillRagDollCrushingRock:
				return IExploreSkillRagDollCrushingRock.Pack(builder, _o.AsIExploreSkillRagDollCrushingRock()).Value;
			case TExploreSkillInteractOption.IExploreSkillRagDollDestroySolidRock:
				return IExploreSkillRagDollDestroySolidRock.Pack(builder, _o.AsIExploreSkillRagDollDestroySolidRock()).Value;
			case TExploreSkillInteractOption.IExploreSkillStatueInteractPoint:
				return IExploreSkillStatueInteractPoint.Pack(builder, _o.AsIExploreSkillStatueInteractPoint()).Value;
			case TExploreSkillInteractOption.IFollowShooterInteractPoint:
				return IFollowShooterInteractPoint.Pack(builder, _o.AsIFollowShooterInteractPoint()).Value;
			case TExploreSkillInteractOption.IFoxJumpInteractPoint:
				return IFoxJumpInteractPoint.Pack(builder, _o.AsIFoxJumpInteractPoint()).Value;
			case TExploreSkillInteractOption.IMonsterSummonInteractPoint:
				return IMonsterSummonInteractPoint.Pack(builder, _o.AsIMonsterSummonInteractPoint()).Value;
			default:
				return 0;
			}
		}
	}
}
