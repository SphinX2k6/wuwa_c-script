using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005758 RID: 22360
	public class IExploreSkillInteractType_UnionUnion
	{
		// Token: 0x1700A1A0 RID: 41376
		// (get) Token: 0x0602408C RID: 147596 RVA: 0x004F4EA5 File Offset: 0x004F30A5
		// (set) Token: 0x0602408D RID: 147597 RVA: 0x004F4EAD File Offset: 0x004F30AD
		public IExploreSkillInteractType_Union Type { get; set; }

		// Token: 0x1700A1A1 RID: 41377
		// (get) Token: 0x0602408E RID: 147598 RVA: 0x004F4EB6 File Offset: 0x004F30B6
		// (set) Token: 0x0602408F RID: 147599 RVA: 0x004F4EBE File Offset: 0x004F30BE
		public object Value { get; set; }

		// Token: 0x06024090 RID: 147600 RVA: 0x004F4EC7 File Offset: 0x004F30C7
		public IExploreSkillInteractType_UnionUnion()
		{
			this.Type = IExploreSkillInteractType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06024091 RID: 147601 RVA: 0x004F4EDD File Offset: 0x004F30DD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06024092 RID: 147602 RVA: 0x004F4EEF File Offset: 0x004F30EF
		public IExploreSkillInteractTypeT AsIExploreSkillInteractType()
		{
			return this.As<IExploreSkillInteractTypeT>();
		}

		// Token: 0x06024093 RID: 147603 RVA: 0x004F4EF7 File Offset: 0x004F30F7
		public static IExploreSkillInteractType_UnionUnion FromIExploreSkillInteractType(IExploreSkillInteractTypeT _iexploreskillinteracttype)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IExploreSkillInteractType,
				Value = _iexploreskillinteracttype
			};
		}

		// Token: 0x06024094 RID: 147604 RVA: 0x004F4F0C File Offset: 0x004F310C
		public IExploreSkillPullGiantT AsIExploreSkillPullGiant()
		{
			return this.As<IExploreSkillPullGiantT>();
		}

		// Token: 0x06024095 RID: 147605 RVA: 0x004F4F14 File Offset: 0x004F3114
		public static IExploreSkillInteractType_UnionUnion FromIExploreSkillPullGiant(IExploreSkillPullGiantT _iexploreskillpullgiant)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IExploreSkillPullGiant,
				Value = _iexploreskillpullgiant
			};
		}

		// Token: 0x06024096 RID: 147606 RVA: 0x004F4F29 File Offset: 0x004F3129
		public IExploreSkillStatueInteractPointT AsIExploreSkillStatueInteractPoint()
		{
			return this.As<IExploreSkillStatueInteractPointT>();
		}

		// Token: 0x06024097 RID: 147607 RVA: 0x004F4F31 File Offset: 0x004F3131
		public static IExploreSkillInteractType_UnionUnion FromIExploreSkillStatueInteractPoint(IExploreSkillStatueInteractPointT _iexploreskillstatueinteractpoint)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IExploreSkillStatueInteractPoint,
				Value = _iexploreskillstatueinteractpoint
			};
		}

		// Token: 0x06024098 RID: 147608 RVA: 0x004F4F46 File Offset: 0x004F3146
		public IExploreSkillPullStatueT AsIExploreSkillPullStatue()
		{
			return this.As<IExploreSkillPullStatueT>();
		}

		// Token: 0x06024099 RID: 147609 RVA: 0x004F4F4E File Offset: 0x004F314E
		public static IExploreSkillInteractType_UnionUnion FromIExploreSkillPullStatue(IExploreSkillPullStatueT _iexploreskillpullstatue)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IExploreSkillPullStatue,
				Value = _iexploreskillpullstatue
			};
		}

		// Token: 0x0602409A RID: 147610 RVA: 0x004F4F63 File Offset: 0x004F3163
		public IExploreSkillRagDollCrushingRockT AsIExploreSkillRagDollCrushingRock()
		{
			return this.As<IExploreSkillRagDollCrushingRockT>();
		}

		// Token: 0x0602409B RID: 147611 RVA: 0x004F4F6B File Offset: 0x004F316B
		public static IExploreSkillInteractType_UnionUnion FromIExploreSkillRagDollCrushingRock(IExploreSkillRagDollCrushingRockT _iexploreskillragdollcrushingrock)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IExploreSkillRagDollCrushingRock,
				Value = _iexploreskillragdollcrushingrock
			};
		}

		// Token: 0x0602409C RID: 147612 RVA: 0x004F4F80 File Offset: 0x004F3180
		public IExploreSkillRagDollDestroySolidRockT AsIExploreSkillRagDollDestroySolidRock()
		{
			return this.As<IExploreSkillRagDollDestroySolidRockT>();
		}

		// Token: 0x0602409D RID: 147613 RVA: 0x004F4F88 File Offset: 0x004F3188
		public static IExploreSkillInteractType_UnionUnion FromIExploreSkillRagDollDestroySolidRock(IExploreSkillRagDollDestroySolidRockT _iexploreskillragdolldestroysolidrock)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IExploreSkillRagDollDestroySolidRock,
				Value = _iexploreskillragdolldestroysolidrock
			};
		}

		// Token: 0x0602409E RID: 147614 RVA: 0x004F4F9D File Offset: 0x004F319D
		public IExploreSkillLonelyDollPollutantT AsIExploreSkillLonelyDollPollutant()
		{
			return this.As<IExploreSkillLonelyDollPollutantT>();
		}

		// Token: 0x0602409F RID: 147615 RVA: 0x004F4FA5 File Offset: 0x004F31A5
		public static IExploreSkillInteractType_UnionUnion FromIExploreSkillLonelyDollPollutant(IExploreSkillLonelyDollPollutantT _iexploreskilllonelydollpollutant)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IExploreSkillLonelyDollPollutant,
				Value = _iexploreskilllonelydollpollutant
			};
		}

		// Token: 0x060240A0 RID: 147616 RVA: 0x004F4FBA File Offset: 0x004F31BA
		public IExploreSkillQuantumDiffusionT AsIExploreSkillQuantumDiffusion()
		{
			return this.As<IExploreSkillQuantumDiffusionT>();
		}

		// Token: 0x060240A1 RID: 147617 RVA: 0x004F4FC2 File Offset: 0x004F31C2
		public static IExploreSkillInteractType_UnionUnion FromIExploreSkillQuantumDiffusion(IExploreSkillQuantumDiffusionT _iexploreskillquantumdiffusion)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IExploreSkillQuantumDiffusion,
				Value = _iexploreskillquantumdiffusion
			};
		}

		// Token: 0x060240A2 RID: 147618 RVA: 0x004F4FD7 File Offset: 0x004F31D7
		public IExploreSkillCustomT AsIExploreSkillCustom()
		{
			return this.As<IExploreSkillCustomT>();
		}

		// Token: 0x060240A3 RID: 147619 RVA: 0x004F4FDF File Offset: 0x004F31DF
		public static IExploreSkillInteractType_UnionUnion FromIExploreSkillCustom(IExploreSkillCustomT _iexploreskillcustom)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IExploreSkillCustom,
				Value = _iexploreskillcustom
			};
		}

		// Token: 0x060240A4 RID: 147620 RVA: 0x004F4FF5 File Offset: 0x004F31F5
		public IExploreSkillMechascoutDragT AsIExploreSkillMechascoutDrag()
		{
			return this.As<IExploreSkillMechascoutDragT>();
		}

		// Token: 0x060240A5 RID: 147621 RVA: 0x004F4FFD File Offset: 0x004F31FD
		public static IExploreSkillInteractType_UnionUnion FromIExploreSkillMechascoutDrag(IExploreSkillMechascoutDragT _iexploreskillmechascoutdrag)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IExploreSkillMechascoutDrag,
				Value = _iexploreskillmechascoutdrag
			};
		}

		// Token: 0x060240A6 RID: 147622 RVA: 0x004F5013 File Offset: 0x004F3213
		public IExploreSkillArrowInteractPointT AsIExploreSkillArrowInteractPoint()
		{
			return this.As<IExploreSkillArrowInteractPointT>();
		}

		// Token: 0x060240A7 RID: 147623 RVA: 0x004F501B File Offset: 0x004F321B
		public static IExploreSkillInteractType_UnionUnion FromIExploreSkillArrowInteractPoint(IExploreSkillArrowInteractPointT _iexploreskillarrowinteractpoint)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IExploreSkillArrowInteractPoint,
				Value = _iexploreskillarrowinteractpoint
			};
		}

		// Token: 0x060240A8 RID: 147624 RVA: 0x004F5031 File Offset: 0x004F3231
		public IFollowShooterInteractPointT AsIFollowShooterInteractPoint()
		{
			return this.As<IFollowShooterInteractPointT>();
		}

		// Token: 0x060240A9 RID: 147625 RVA: 0x004F5039 File Offset: 0x004F3239
		public static IExploreSkillInteractType_UnionUnion FromIFollowShooterInteractPoint(IFollowShooterInteractPointT _ifollowshooterinteractpoint)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IFollowShooterInteractPoint,
				Value = _ifollowshooterinteractpoint
			};
		}

		// Token: 0x060240AA RID: 147626 RVA: 0x004F504F File Offset: 0x004F324F
		public IFoxJumpInteractPointT AsIFoxJumpInteractPoint()
		{
			return this.As<IFoxJumpInteractPointT>();
		}

		// Token: 0x060240AB RID: 147627 RVA: 0x004F5057 File Offset: 0x004F3257
		public static IExploreSkillInteractType_UnionUnion FromIFoxJumpInteractPoint(IFoxJumpInteractPointT _ifoxjumpinteractpoint)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IFoxJumpInteractPoint,
				Value = _ifoxjumpinteractpoint
			};
		}

		// Token: 0x060240AC RID: 147628 RVA: 0x004F506D File Offset: 0x004F326D
		public IMonsterSummonInteractPointT AsIMonsterSummonInteractPoint()
		{
			return this.As<IMonsterSummonInteractPointT>();
		}

		// Token: 0x060240AD RID: 147629 RVA: 0x004F5075 File Offset: 0x004F3275
		public static IExploreSkillInteractType_UnionUnion FromIMonsterSummonInteractPoint(IMonsterSummonInteractPointT _imonstersummoninteractpoint)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IMonsterSummonInteractPoint,
				Value = _imonstersummoninteractpoint
			};
		}

		// Token: 0x060240AE RID: 147630 RVA: 0x004F508B File Offset: 0x004F328B
		public IExploreSkillEavesdropT AsIExploreSkillEavesdrop()
		{
			return this.As<IExploreSkillEavesdropT>();
		}

		// Token: 0x060240AF RID: 147631 RVA: 0x004F5093 File Offset: 0x004F3293
		public static IExploreSkillInteractType_UnionUnion FromIExploreSkillEavesdrop(IExploreSkillEavesdropT _iexploreskilleavesdrop)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IExploreSkillEavesdrop,
				Value = _iexploreskilleavesdrop
			};
		}

		// Token: 0x060240B0 RID: 147632 RVA: 0x004F50A9 File Offset: 0x004F32A9
		public IExploreSkillGraffitiPuzzleT AsIExploreSkillGraffitiPuzzle()
		{
			return this.As<IExploreSkillGraffitiPuzzleT>();
		}

		// Token: 0x060240B1 RID: 147633 RVA: 0x004F50B1 File Offset: 0x004F32B1
		public static IExploreSkillInteractType_UnionUnion FromIExploreSkillGraffitiPuzzle(IExploreSkillGraffitiPuzzleT _iexploreskillgraffitipuzzle)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IExploreSkillGraffitiPuzzle,
				Value = _iexploreskillgraffitipuzzle
			};
		}

		// Token: 0x060240B2 RID: 147634 RVA: 0x004F50C8 File Offset: 0x004F32C8
		public static int Pack(FlatBufferBuilder builder, IExploreSkillInteractType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IExploreSkillInteractType_Union.IExploreSkillInteractType:
				return IExploreSkillInteractType.Pack(builder, _o.AsIExploreSkillInteractType()).Value;
			case IExploreSkillInteractType_Union.IExploreSkillPullGiant:
				return IExploreSkillPullGiant.Pack(builder, _o.AsIExploreSkillPullGiant()).Value;
			case IExploreSkillInteractType_Union.IExploreSkillStatueInteractPoint:
				return IExploreSkillStatueInteractPoint.Pack(builder, _o.AsIExploreSkillStatueInteractPoint()).Value;
			case IExploreSkillInteractType_Union.IExploreSkillPullStatue:
				return IExploreSkillPullStatue.Pack(builder, _o.AsIExploreSkillPullStatue()).Value;
			case IExploreSkillInteractType_Union.IExploreSkillRagDollCrushingRock:
				return IExploreSkillRagDollCrushingRock.Pack(builder, _o.AsIExploreSkillRagDollCrushingRock()).Value;
			case IExploreSkillInteractType_Union.IExploreSkillRagDollDestroySolidRock:
				return IExploreSkillRagDollDestroySolidRock.Pack(builder, _o.AsIExploreSkillRagDollDestroySolidRock()).Value;
			case IExploreSkillInteractType_Union.IExploreSkillLonelyDollPollutant:
				return IExploreSkillLonelyDollPollutant.Pack(builder, _o.AsIExploreSkillLonelyDollPollutant()).Value;
			case IExploreSkillInteractType_Union.IExploreSkillQuantumDiffusion:
				return IExploreSkillQuantumDiffusion.Pack(builder, _o.AsIExploreSkillQuantumDiffusion()).Value;
			case IExploreSkillInteractType_Union.IExploreSkillCustom:
				return IExploreSkillCustom.Pack(builder, _o.AsIExploreSkillCustom()).Value;
			case IExploreSkillInteractType_Union.IExploreSkillMechascoutDrag:
				return IExploreSkillMechascoutDrag.Pack(builder, _o.AsIExploreSkillMechascoutDrag()).Value;
			case IExploreSkillInteractType_Union.IExploreSkillArrowInteractPoint:
				return IExploreSkillArrowInteractPoint.Pack(builder, _o.AsIExploreSkillArrowInteractPoint()).Value;
			case IExploreSkillInteractType_Union.IFollowShooterInteractPoint:
				return IFollowShooterInteractPoint.Pack(builder, _o.AsIFollowShooterInteractPoint()).Value;
			case IExploreSkillInteractType_Union.IFoxJumpInteractPoint:
				return IFoxJumpInteractPoint.Pack(builder, _o.AsIFoxJumpInteractPoint()).Value;
			case IExploreSkillInteractType_Union.IMonsterSummonInteractPoint:
				return IMonsterSummonInteractPoint.Pack(builder, _o.AsIMonsterSummonInteractPoint()).Value;
			case IExploreSkillInteractType_Union.IExploreSkillEavesdrop:
				return IExploreSkillEavesdrop.Pack(builder, _o.AsIExploreSkillEavesdrop()).Value;
			case IExploreSkillInteractType_Union.IExploreSkillGraffitiPuzzle:
				return IExploreSkillGraffitiPuzzle.Pack(builder, _o.AsIExploreSkillGraffitiPuzzle()).Value;
			default:
				return 0;
			}
		}
	}
}
