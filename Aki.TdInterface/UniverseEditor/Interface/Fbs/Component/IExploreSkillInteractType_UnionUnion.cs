using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051F0 RID: 20976
	public class IExploreSkillInteractType_UnionUnion
	{
		// Token: 0x170099A4 RID: 39332
		// (get) Token: 0x060220F8 RID: 139512 RVA: 0x004BA425 File Offset: 0x004B8625
		// (set) Token: 0x060220F9 RID: 139513 RVA: 0x004BA42D File Offset: 0x004B862D
		public IExploreSkillInteractType_Union Type { get; set; }

		// Token: 0x170099A5 RID: 39333
		// (get) Token: 0x060220FA RID: 139514 RVA: 0x004BA436 File Offset: 0x004B8636
		// (set) Token: 0x060220FB RID: 139515 RVA: 0x004BA43E File Offset: 0x004B863E
		public object Value { get; set; }

		// Token: 0x060220FC RID: 139516 RVA: 0x004BA447 File Offset: 0x004B8647
		public IExploreSkillInteractType_UnionUnion()
		{
			this.Type = IExploreSkillInteractType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060220FD RID: 139517 RVA: 0x004BA45D File Offset: 0x004B865D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060220FE RID: 139518 RVA: 0x004BA46F File Offset: 0x004B866F
		public IExploreSkillInteractTypeT AsIExploreSkillInteractType()
		{
			return this.As<IExploreSkillInteractTypeT>();
		}

		// Token: 0x060220FF RID: 139519 RVA: 0x004BA477 File Offset: 0x004B8677
		public static IExploreSkillInteractType_UnionUnion FromIExploreSkillInteractType(IExploreSkillInteractTypeT _iexploreskillinteracttype)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IExploreSkillInteractType,
				Value = _iexploreskillinteracttype
			};
		}

		// Token: 0x06022100 RID: 139520 RVA: 0x004BA48C File Offset: 0x004B868C
		public IExploreSkillPullGiantT AsIExploreSkillPullGiant()
		{
			return this.As<IExploreSkillPullGiantT>();
		}

		// Token: 0x06022101 RID: 139521 RVA: 0x004BA494 File Offset: 0x004B8694
		public static IExploreSkillInteractType_UnionUnion FromIExploreSkillPullGiant(IExploreSkillPullGiantT _iexploreskillpullgiant)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IExploreSkillPullGiant,
				Value = _iexploreskillpullgiant
			};
		}

		// Token: 0x06022102 RID: 139522 RVA: 0x004BA4A9 File Offset: 0x004B86A9
		public IExploreSkillStatueInteractPointT AsIExploreSkillStatueInteractPoint()
		{
			return this.As<IExploreSkillStatueInteractPointT>();
		}

		// Token: 0x06022103 RID: 139523 RVA: 0x004BA4B1 File Offset: 0x004B86B1
		public static IExploreSkillInteractType_UnionUnion FromIExploreSkillStatueInteractPoint(IExploreSkillStatueInteractPointT _iexploreskillstatueinteractpoint)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IExploreSkillStatueInteractPoint,
				Value = _iexploreskillstatueinteractpoint
			};
		}

		// Token: 0x06022104 RID: 139524 RVA: 0x004BA4C6 File Offset: 0x004B86C6
		public IExploreSkillPullStatueT AsIExploreSkillPullStatue()
		{
			return this.As<IExploreSkillPullStatueT>();
		}

		// Token: 0x06022105 RID: 139525 RVA: 0x004BA4CE File Offset: 0x004B86CE
		public static IExploreSkillInteractType_UnionUnion FromIExploreSkillPullStatue(IExploreSkillPullStatueT _iexploreskillpullstatue)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IExploreSkillPullStatue,
				Value = _iexploreskillpullstatue
			};
		}

		// Token: 0x06022106 RID: 139526 RVA: 0x004BA4E3 File Offset: 0x004B86E3
		public IExploreSkillRagDollCrushingRockT AsIExploreSkillRagDollCrushingRock()
		{
			return this.As<IExploreSkillRagDollCrushingRockT>();
		}

		// Token: 0x06022107 RID: 139527 RVA: 0x004BA4EB File Offset: 0x004B86EB
		public static IExploreSkillInteractType_UnionUnion FromIExploreSkillRagDollCrushingRock(IExploreSkillRagDollCrushingRockT _iexploreskillragdollcrushingrock)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IExploreSkillRagDollCrushingRock,
				Value = _iexploreskillragdollcrushingrock
			};
		}

		// Token: 0x06022108 RID: 139528 RVA: 0x004BA500 File Offset: 0x004B8700
		public IExploreSkillRagDollDestroySolidRockT AsIExploreSkillRagDollDestroySolidRock()
		{
			return this.As<IExploreSkillRagDollDestroySolidRockT>();
		}

		// Token: 0x06022109 RID: 139529 RVA: 0x004BA508 File Offset: 0x004B8708
		public static IExploreSkillInteractType_UnionUnion FromIExploreSkillRagDollDestroySolidRock(IExploreSkillRagDollDestroySolidRockT _iexploreskillragdolldestroysolidrock)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IExploreSkillRagDollDestroySolidRock,
				Value = _iexploreskillragdolldestroysolidrock
			};
		}

		// Token: 0x0602210A RID: 139530 RVA: 0x004BA51D File Offset: 0x004B871D
		public IExploreSkillLonelyDollPollutantT AsIExploreSkillLonelyDollPollutant()
		{
			return this.As<IExploreSkillLonelyDollPollutantT>();
		}

		// Token: 0x0602210B RID: 139531 RVA: 0x004BA525 File Offset: 0x004B8725
		public static IExploreSkillInteractType_UnionUnion FromIExploreSkillLonelyDollPollutant(IExploreSkillLonelyDollPollutantT _iexploreskilllonelydollpollutant)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IExploreSkillLonelyDollPollutant,
				Value = _iexploreskilllonelydollpollutant
			};
		}

		// Token: 0x0602210C RID: 139532 RVA: 0x004BA53A File Offset: 0x004B873A
		public IExploreSkillQuantumDiffusionT AsIExploreSkillQuantumDiffusion()
		{
			return this.As<IExploreSkillQuantumDiffusionT>();
		}

		// Token: 0x0602210D RID: 139533 RVA: 0x004BA542 File Offset: 0x004B8742
		public static IExploreSkillInteractType_UnionUnion FromIExploreSkillQuantumDiffusion(IExploreSkillQuantumDiffusionT _iexploreskillquantumdiffusion)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IExploreSkillQuantumDiffusion,
				Value = _iexploreskillquantumdiffusion
			};
		}

		// Token: 0x0602210E RID: 139534 RVA: 0x004BA557 File Offset: 0x004B8757
		public IExploreSkillCustomT AsIExploreSkillCustom()
		{
			return this.As<IExploreSkillCustomT>();
		}

		// Token: 0x0602210F RID: 139535 RVA: 0x004BA55F File Offset: 0x004B875F
		public static IExploreSkillInteractType_UnionUnion FromIExploreSkillCustom(IExploreSkillCustomT _iexploreskillcustom)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IExploreSkillCustom,
				Value = _iexploreskillcustom
			};
		}

		// Token: 0x06022110 RID: 139536 RVA: 0x004BA575 File Offset: 0x004B8775
		public IExploreSkillMechascoutDragT AsIExploreSkillMechascoutDrag()
		{
			return this.As<IExploreSkillMechascoutDragT>();
		}

		// Token: 0x06022111 RID: 139537 RVA: 0x004BA57D File Offset: 0x004B877D
		public static IExploreSkillInteractType_UnionUnion FromIExploreSkillMechascoutDrag(IExploreSkillMechascoutDragT _iexploreskillmechascoutdrag)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IExploreSkillMechascoutDrag,
				Value = _iexploreskillmechascoutdrag
			};
		}

		// Token: 0x06022112 RID: 139538 RVA: 0x004BA593 File Offset: 0x004B8793
		public IExploreSkillArrowInteractPointT AsIExploreSkillArrowInteractPoint()
		{
			return this.As<IExploreSkillArrowInteractPointT>();
		}

		// Token: 0x06022113 RID: 139539 RVA: 0x004BA59B File Offset: 0x004B879B
		public static IExploreSkillInteractType_UnionUnion FromIExploreSkillArrowInteractPoint(IExploreSkillArrowInteractPointT _iexploreskillarrowinteractpoint)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IExploreSkillArrowInteractPoint,
				Value = _iexploreskillarrowinteractpoint
			};
		}

		// Token: 0x06022114 RID: 139540 RVA: 0x004BA5B1 File Offset: 0x004B87B1
		public IFollowShooterInteractPointT AsIFollowShooterInteractPoint()
		{
			return this.As<IFollowShooterInteractPointT>();
		}

		// Token: 0x06022115 RID: 139541 RVA: 0x004BA5B9 File Offset: 0x004B87B9
		public static IExploreSkillInteractType_UnionUnion FromIFollowShooterInteractPoint(IFollowShooterInteractPointT _ifollowshooterinteractpoint)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IFollowShooterInteractPoint,
				Value = _ifollowshooterinteractpoint
			};
		}

		// Token: 0x06022116 RID: 139542 RVA: 0x004BA5CF File Offset: 0x004B87CF
		public IFoxJumpInteractPointT AsIFoxJumpInteractPoint()
		{
			return this.As<IFoxJumpInteractPointT>();
		}

		// Token: 0x06022117 RID: 139543 RVA: 0x004BA5D7 File Offset: 0x004B87D7
		public static IExploreSkillInteractType_UnionUnion FromIFoxJumpInteractPoint(IFoxJumpInteractPointT _ifoxjumpinteractpoint)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IFoxJumpInteractPoint,
				Value = _ifoxjumpinteractpoint
			};
		}

		// Token: 0x06022118 RID: 139544 RVA: 0x004BA5ED File Offset: 0x004B87ED
		public IMonsterSummonInteractPointT AsIMonsterSummonInteractPoint()
		{
			return this.As<IMonsterSummonInteractPointT>();
		}

		// Token: 0x06022119 RID: 139545 RVA: 0x004BA5F5 File Offset: 0x004B87F5
		public static IExploreSkillInteractType_UnionUnion FromIMonsterSummonInteractPoint(IMonsterSummonInteractPointT _imonstersummoninteractpoint)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IMonsterSummonInteractPoint,
				Value = _imonstersummoninteractpoint
			};
		}

		// Token: 0x0602211A RID: 139546 RVA: 0x004BA60B File Offset: 0x004B880B
		public IExploreSkillEavesdropT AsIExploreSkillEavesdrop()
		{
			return this.As<IExploreSkillEavesdropT>();
		}

		// Token: 0x0602211B RID: 139547 RVA: 0x004BA613 File Offset: 0x004B8813
		public static IExploreSkillInteractType_UnionUnion FromIExploreSkillEavesdrop(IExploreSkillEavesdropT _iexploreskilleavesdrop)
		{
			return new IExploreSkillInteractType_UnionUnion
			{
				Type = IExploreSkillInteractType_Union.IExploreSkillEavesdrop,
				Value = _iexploreskilleavesdrop
			};
		}

		// Token: 0x0602211C RID: 139548 RVA: 0x004BA62C File Offset: 0x004B882C
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
			default:
				return 0;
			}
		}
	}
}
