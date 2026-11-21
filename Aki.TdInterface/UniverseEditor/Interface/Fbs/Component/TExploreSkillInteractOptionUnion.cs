using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006238 RID: 25144
	public class TExploreSkillInteractOptionUnion
	{
		// Token: 0x1700BB3C RID: 47932
		// (get) Token: 0x0602ACE1 RID: 175329 RVA: 0x005D893A File Offset: 0x005D6B3A
		// (set) Token: 0x0602ACE2 RID: 175330 RVA: 0x005D8942 File Offset: 0x005D6B42
		public TExploreSkillInteractOption Type { get; set; }

		// Token: 0x1700BB3D RID: 47933
		// (get) Token: 0x0602ACE3 RID: 175331 RVA: 0x005D894B File Offset: 0x005D6B4B
		// (set) Token: 0x0602ACE4 RID: 175332 RVA: 0x005D8953 File Offset: 0x005D6B53
		public object Value { get; set; }

		// Token: 0x0602ACE5 RID: 175333 RVA: 0x005D895C File Offset: 0x005D6B5C
		public TExploreSkillInteractOptionUnion()
		{
			this.Type = TExploreSkillInteractOption.NONE;
			this.Value = null;
		}

		// Token: 0x0602ACE6 RID: 175334 RVA: 0x005D8972 File Offset: 0x005D6B72
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602ACE7 RID: 175335 RVA: 0x005D8984 File Offset: 0x005D6B84
		public IExploreSkillArrowInteractPointT AsIExploreSkillArrowInteractPoint()
		{
			return this.As<IExploreSkillArrowInteractPointT>();
		}

		// Token: 0x0602ACE8 RID: 175336 RVA: 0x005D898C File Offset: 0x005D6B8C
		public static TExploreSkillInteractOptionUnion FromIExploreSkillArrowInteractPoint(IExploreSkillArrowInteractPointT _iexploreskillarrowinteractpoint)
		{
			return new TExploreSkillInteractOptionUnion
			{
				Type = TExploreSkillInteractOption.IExploreSkillArrowInteractPoint,
				Value = _iexploreskillarrowinteractpoint
			};
		}

		// Token: 0x0602ACE9 RID: 175337 RVA: 0x005D89A1 File Offset: 0x005D6BA1
		public IExploreSkillCustomT AsIExploreSkillCustom()
		{
			return this.As<IExploreSkillCustomT>();
		}

		// Token: 0x0602ACEA RID: 175338 RVA: 0x005D89A9 File Offset: 0x005D6BA9
		public static TExploreSkillInteractOptionUnion FromIExploreSkillCustom(IExploreSkillCustomT _iexploreskillcustom)
		{
			return new TExploreSkillInteractOptionUnion
			{
				Type = TExploreSkillInteractOption.IExploreSkillCustom,
				Value = _iexploreskillcustom
			};
		}

		// Token: 0x0602ACEB RID: 175339 RVA: 0x005D89BE File Offset: 0x005D6BBE
		public IExploreSkillEavesdropT AsIExploreSkillEavesdrop()
		{
			return this.As<IExploreSkillEavesdropT>();
		}

		// Token: 0x0602ACEC RID: 175340 RVA: 0x005D89C6 File Offset: 0x005D6BC6
		public static TExploreSkillInteractOptionUnion FromIExploreSkillEavesdrop(IExploreSkillEavesdropT _iexploreskilleavesdrop)
		{
			return new TExploreSkillInteractOptionUnion
			{
				Type = TExploreSkillInteractOption.IExploreSkillEavesdrop,
				Value = _iexploreskilleavesdrop
			};
		}

		// Token: 0x0602ACED RID: 175341 RVA: 0x005D89DB File Offset: 0x005D6BDB
		public IExploreSkillGraffitiPuzzleT AsIExploreSkillGraffitiPuzzle()
		{
			return this.As<IExploreSkillGraffitiPuzzleT>();
		}

		// Token: 0x0602ACEE RID: 175342 RVA: 0x005D89E3 File Offset: 0x005D6BE3
		public static TExploreSkillInteractOptionUnion FromIExploreSkillGraffitiPuzzle(IExploreSkillGraffitiPuzzleT _iexploreskillgraffitipuzzle)
		{
			return new TExploreSkillInteractOptionUnion
			{
				Type = TExploreSkillInteractOption.IExploreSkillGraffitiPuzzle,
				Value = _iexploreskillgraffitipuzzle
			};
		}

		// Token: 0x0602ACEF RID: 175343 RVA: 0x005D89F8 File Offset: 0x005D6BF8
		public IExploreSkillLonelyDollPollutantT AsIExploreSkillLonelyDollPollutant()
		{
			return this.As<IExploreSkillLonelyDollPollutantT>();
		}

		// Token: 0x0602ACF0 RID: 175344 RVA: 0x005D8A00 File Offset: 0x005D6C00
		public static TExploreSkillInteractOptionUnion FromIExploreSkillLonelyDollPollutant(IExploreSkillLonelyDollPollutantT _iexploreskilllonelydollpollutant)
		{
			return new TExploreSkillInteractOptionUnion
			{
				Type = TExploreSkillInteractOption.IExploreSkillLonelyDollPollutant,
				Value = _iexploreskilllonelydollpollutant
			};
		}

		// Token: 0x0602ACF1 RID: 175345 RVA: 0x005D8A15 File Offset: 0x005D6C15
		public IExploreSkillMechascoutDragT AsIExploreSkillMechascoutDrag()
		{
			return this.As<IExploreSkillMechascoutDragT>();
		}

		// Token: 0x0602ACF2 RID: 175346 RVA: 0x005D8A1D File Offset: 0x005D6C1D
		public static TExploreSkillInteractOptionUnion FromIExploreSkillMechascoutDrag(IExploreSkillMechascoutDragT _iexploreskillmechascoutdrag)
		{
			return new TExploreSkillInteractOptionUnion
			{
				Type = TExploreSkillInteractOption.IExploreSkillMechascoutDrag,
				Value = _iexploreskillmechascoutdrag
			};
		}

		// Token: 0x0602ACF3 RID: 175347 RVA: 0x005D8A32 File Offset: 0x005D6C32
		public IExploreSkillPullGiantT AsIExploreSkillPullGiant()
		{
			return this.As<IExploreSkillPullGiantT>();
		}

		// Token: 0x0602ACF4 RID: 175348 RVA: 0x005D8A3A File Offset: 0x005D6C3A
		public static TExploreSkillInteractOptionUnion FromIExploreSkillPullGiant(IExploreSkillPullGiantT _iexploreskillpullgiant)
		{
			return new TExploreSkillInteractOptionUnion
			{
				Type = TExploreSkillInteractOption.IExploreSkillPullGiant,
				Value = _iexploreskillpullgiant
			};
		}

		// Token: 0x0602ACF5 RID: 175349 RVA: 0x005D8A4F File Offset: 0x005D6C4F
		public IExploreSkillPullStatueT AsIExploreSkillPullStatue()
		{
			return this.As<IExploreSkillPullStatueT>();
		}

		// Token: 0x0602ACF6 RID: 175350 RVA: 0x005D8A57 File Offset: 0x005D6C57
		public static TExploreSkillInteractOptionUnion FromIExploreSkillPullStatue(IExploreSkillPullStatueT _iexploreskillpullstatue)
		{
			return new TExploreSkillInteractOptionUnion
			{
				Type = TExploreSkillInteractOption.IExploreSkillPullStatue,
				Value = _iexploreskillpullstatue
			};
		}

		// Token: 0x0602ACF7 RID: 175351 RVA: 0x005D8A6C File Offset: 0x005D6C6C
		public IExploreSkillQuantumDiffusionT AsIExploreSkillQuantumDiffusion()
		{
			return this.As<IExploreSkillQuantumDiffusionT>();
		}

		// Token: 0x0602ACF8 RID: 175352 RVA: 0x005D8A74 File Offset: 0x005D6C74
		public static TExploreSkillInteractOptionUnion FromIExploreSkillQuantumDiffusion(IExploreSkillQuantumDiffusionT _iexploreskillquantumdiffusion)
		{
			return new TExploreSkillInteractOptionUnion
			{
				Type = TExploreSkillInteractOption.IExploreSkillQuantumDiffusion,
				Value = _iexploreskillquantumdiffusion
			};
		}

		// Token: 0x0602ACF9 RID: 175353 RVA: 0x005D8A8A File Offset: 0x005D6C8A
		public IExploreSkillRagDollCrushingRockT AsIExploreSkillRagDollCrushingRock()
		{
			return this.As<IExploreSkillRagDollCrushingRockT>();
		}

		// Token: 0x0602ACFA RID: 175354 RVA: 0x005D8A92 File Offset: 0x005D6C92
		public static TExploreSkillInteractOptionUnion FromIExploreSkillRagDollCrushingRock(IExploreSkillRagDollCrushingRockT _iexploreskillragdollcrushingrock)
		{
			return new TExploreSkillInteractOptionUnion
			{
				Type = TExploreSkillInteractOption.IExploreSkillRagDollCrushingRock,
				Value = _iexploreskillragdollcrushingrock
			};
		}

		// Token: 0x0602ACFB RID: 175355 RVA: 0x005D8AA8 File Offset: 0x005D6CA8
		public IExploreSkillRagDollDestroySolidRockT AsIExploreSkillRagDollDestroySolidRock()
		{
			return this.As<IExploreSkillRagDollDestroySolidRockT>();
		}

		// Token: 0x0602ACFC RID: 175356 RVA: 0x005D8AB0 File Offset: 0x005D6CB0
		public static TExploreSkillInteractOptionUnion FromIExploreSkillRagDollDestroySolidRock(IExploreSkillRagDollDestroySolidRockT _iexploreskillragdolldestroysolidrock)
		{
			return new TExploreSkillInteractOptionUnion
			{
				Type = TExploreSkillInteractOption.IExploreSkillRagDollDestroySolidRock,
				Value = _iexploreskillragdolldestroysolidrock
			};
		}

		// Token: 0x0602ACFD RID: 175357 RVA: 0x005D8AC6 File Offset: 0x005D6CC6
		public IExploreSkillStatueInteractPointT AsIExploreSkillStatueInteractPoint()
		{
			return this.As<IExploreSkillStatueInteractPointT>();
		}

		// Token: 0x0602ACFE RID: 175358 RVA: 0x005D8ACE File Offset: 0x005D6CCE
		public static TExploreSkillInteractOptionUnion FromIExploreSkillStatueInteractPoint(IExploreSkillStatueInteractPointT _iexploreskillstatueinteractpoint)
		{
			return new TExploreSkillInteractOptionUnion
			{
				Type = TExploreSkillInteractOption.IExploreSkillStatueInteractPoint,
				Value = _iexploreskillstatueinteractpoint
			};
		}

		// Token: 0x0602ACFF RID: 175359 RVA: 0x005D8AE4 File Offset: 0x005D6CE4
		public IFollowShooterInteractPointT AsIFollowShooterInteractPoint()
		{
			return this.As<IFollowShooterInteractPointT>();
		}

		// Token: 0x0602AD00 RID: 175360 RVA: 0x005D8AEC File Offset: 0x005D6CEC
		public static TExploreSkillInteractOptionUnion FromIFollowShooterInteractPoint(IFollowShooterInteractPointT _ifollowshooterinteractpoint)
		{
			return new TExploreSkillInteractOptionUnion
			{
				Type = TExploreSkillInteractOption.IFollowShooterInteractPoint,
				Value = _ifollowshooterinteractpoint
			};
		}

		// Token: 0x0602AD01 RID: 175361 RVA: 0x005D8B02 File Offset: 0x005D6D02
		public IFoxJumpInteractPointT AsIFoxJumpInteractPoint()
		{
			return this.As<IFoxJumpInteractPointT>();
		}

		// Token: 0x0602AD02 RID: 175362 RVA: 0x005D8B0A File Offset: 0x005D6D0A
		public static TExploreSkillInteractOptionUnion FromIFoxJumpInteractPoint(IFoxJumpInteractPointT _ifoxjumpinteractpoint)
		{
			return new TExploreSkillInteractOptionUnion
			{
				Type = TExploreSkillInteractOption.IFoxJumpInteractPoint,
				Value = _ifoxjumpinteractpoint
			};
		}

		// Token: 0x0602AD03 RID: 175363 RVA: 0x005D8B20 File Offset: 0x005D6D20
		public IMonsterSummonInteractPointT AsIMonsterSummonInteractPoint()
		{
			return this.As<IMonsterSummonInteractPointT>();
		}

		// Token: 0x0602AD04 RID: 175364 RVA: 0x005D8B28 File Offset: 0x005D6D28
		public static TExploreSkillInteractOptionUnion FromIMonsterSummonInteractPoint(IMonsterSummonInteractPointT _imonstersummoninteractpoint)
		{
			return new TExploreSkillInteractOptionUnion
			{
				Type = TExploreSkillInteractOption.IMonsterSummonInteractPoint,
				Value = _imonstersummoninteractpoint
			};
		}

		// Token: 0x0602AD05 RID: 175365 RVA: 0x005D8B40 File Offset: 0x005D6D40
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
			case TExploreSkillInteractOption.IExploreSkillGraffitiPuzzle:
				return IExploreSkillGraffitiPuzzle.Pack(builder, _o.AsIExploreSkillGraffitiPuzzle()).Value;
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
