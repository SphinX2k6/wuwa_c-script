using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049C9 RID: 18889
	public class IRollBlockGridBase_UnionUnion
	{
		// Token: 0x17008443 RID: 33859
		// (get) Token: 0x0601C3C8 RID: 115656 RVA: 0x003FCC2E File Offset: 0x003FAE2E
		// (set) Token: 0x0601C3C9 RID: 115657 RVA: 0x003FCC36 File Offset: 0x003FAE36
		public IRollBlockGridBase_Union Type { get; set; }

		// Token: 0x17008444 RID: 33860
		// (get) Token: 0x0601C3CA RID: 115658 RVA: 0x003FCC3F File Offset: 0x003FAE3F
		// (set) Token: 0x0601C3CB RID: 115659 RVA: 0x003FCC47 File Offset: 0x003FAE47
		public object Value { get; set; }

		// Token: 0x0601C3CC RID: 115660 RVA: 0x003FCC50 File Offset: 0x003FAE50
		public IRollBlockGridBase_UnionUnion()
		{
			this.Type = IRollBlockGridBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601C3CD RID: 115661 RVA: 0x003FCC66 File Offset: 0x003FAE66
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601C3CE RID: 115662 RVA: 0x003FCC78 File Offset: 0x003FAE78
		public IRollBlockGridBaseT AsIRollBlockGridBase()
		{
			return this.As<IRollBlockGridBaseT>();
		}

		// Token: 0x0601C3CF RID: 115663 RVA: 0x003FCC80 File Offset: 0x003FAE80
		public static IRollBlockGridBase_UnionUnion FromIRollBlockGridBase(IRollBlockGridBaseT _irollblockgridbase)
		{
			return new IRollBlockGridBase_UnionUnion
			{
				Type = IRollBlockGridBase_Union.IRollBlockGridBase,
				Value = _irollblockgridbase
			};
		}

		// Token: 0x0601C3D0 RID: 115664 RVA: 0x003FCC95 File Offset: 0x003FAE95
		public IRollBlockGridEmptyT AsIRollBlockGridEmpty()
		{
			return this.As<IRollBlockGridEmptyT>();
		}

		// Token: 0x0601C3D1 RID: 115665 RVA: 0x003FCC9D File Offset: 0x003FAE9D
		public static IRollBlockGridBase_UnionUnion FromIRollBlockGridEmpty(IRollBlockGridEmptyT _irollblockgridempty)
		{
			return new IRollBlockGridBase_UnionUnion
			{
				Type = IRollBlockGridBase_Union.IRollBlockGridEmpty,
				Value = _irollblockgridempty
			};
		}

		// Token: 0x0601C3D2 RID: 115666 RVA: 0x003FCCB2 File Offset: 0x003FAEB2
		public IRollBlockGridFloorT AsIRollBlockGridFloor()
		{
			return this.As<IRollBlockGridFloorT>();
		}

		// Token: 0x0601C3D3 RID: 115667 RVA: 0x003FCCBA File Offset: 0x003FAEBA
		public static IRollBlockGridBase_UnionUnion FromIRollBlockGridFloor(IRollBlockGridFloorT _irollblockgridfloor)
		{
			return new IRollBlockGridBase_UnionUnion
			{
				Type = IRollBlockGridBase_Union.IRollBlockGridFloor,
				Value = _irollblockgridfloor
			};
		}

		// Token: 0x0601C3D4 RID: 115668 RVA: 0x003FCCCF File Offset: 0x003FAECF
		public IRollBlockGridGoalT AsIRollBlockGridGoal()
		{
			return this.As<IRollBlockGridGoalT>();
		}

		// Token: 0x0601C3D5 RID: 115669 RVA: 0x003FCCD7 File Offset: 0x003FAED7
		public static IRollBlockGridBase_UnionUnion FromIRollBlockGridGoal(IRollBlockGridGoalT _irollblockgridgoal)
		{
			return new IRollBlockGridBase_UnionUnion
			{
				Type = IRollBlockGridBase_Union.IRollBlockGridGoal,
				Value = _irollblockgridgoal
			};
		}

		// Token: 0x0601C3D6 RID: 115670 RVA: 0x003FCCEC File Offset: 0x003FAEEC
		public IRollBlockGridLinkGoalT AsIRollBlockGridLinkGoal()
		{
			return this.As<IRollBlockGridLinkGoalT>();
		}

		// Token: 0x0601C3D7 RID: 115671 RVA: 0x003FCCF4 File Offset: 0x003FAEF4
		public static IRollBlockGridBase_UnionUnion FromIRollBlockGridLinkGoal(IRollBlockGridLinkGoalT _irollblockgridlinkgoal)
		{
			return new IRollBlockGridBase_UnionUnion
			{
				Type = IRollBlockGridBase_Union.IRollBlockGridLinkGoal,
				Value = _irollblockgridlinkgoal
			};
		}

		// Token: 0x0601C3D8 RID: 115672 RVA: 0x003FCD09 File Offset: 0x003FAF09
		public IRollBlockGridJumpFloorT AsIRollBlockGridJumpFloor()
		{
			return this.As<IRollBlockGridJumpFloorT>();
		}

		// Token: 0x0601C3D9 RID: 115673 RVA: 0x003FCD11 File Offset: 0x003FAF11
		public static IRollBlockGridBase_UnionUnion FromIRollBlockGridJumpFloor(IRollBlockGridJumpFloorT _irollblockgridjumpfloor)
		{
			return new IRollBlockGridBase_UnionUnion
			{
				Type = IRollBlockGridBase_Union.IRollBlockGridJumpFloor,
				Value = _irollblockgridjumpfloor
			};
		}

		// Token: 0x0601C3DA RID: 115674 RVA: 0x003FCD26 File Offset: 0x003FAF26
		public IRollBlockGridFallFloorT AsIRollBlockGridFallFloor()
		{
			return this.As<IRollBlockGridFallFloorT>();
		}

		// Token: 0x0601C3DB RID: 115675 RVA: 0x003FCD2E File Offset: 0x003FAF2E
		public static IRollBlockGridBase_UnionUnion FromIRollBlockGridFallFloor(IRollBlockGridFallFloorT _irollblockgridfallfloor)
		{
			return new IRollBlockGridBase_UnionUnion
			{
				Type = IRollBlockGridBase_Union.IRollBlockGridFallFloor,
				Value = _irollblockgridfallfloor
			};
		}

		// Token: 0x0601C3DC RID: 115676 RVA: 0x003FCD43 File Offset: 0x003FAF43
		public IRollBlockGridBreakTriggerT AsIRollBlockGridBreakTrigger()
		{
			return this.As<IRollBlockGridBreakTriggerT>();
		}

		// Token: 0x0601C3DD RID: 115677 RVA: 0x003FCD4B File Offset: 0x003FAF4B
		public static IRollBlockGridBase_UnionUnion FromIRollBlockGridBreakTrigger(IRollBlockGridBreakTriggerT _irollblockgridbreaktrigger)
		{
			return new IRollBlockGridBase_UnionUnion
			{
				Type = IRollBlockGridBase_Union.IRollBlockGridBreakTrigger,
				Value = _irollblockgridbreaktrigger
			};
		}

		// Token: 0x0601C3DE RID: 115678 RVA: 0x003FCD60 File Offset: 0x003FAF60
		public IRollBlockGridQuantumT AsIRollBlockGridQuantum()
		{
			return this.As<IRollBlockGridQuantumT>();
		}

		// Token: 0x0601C3DF RID: 115679 RVA: 0x003FCD68 File Offset: 0x003FAF68
		public static IRollBlockGridBase_UnionUnion FromIRollBlockGridQuantum(IRollBlockGridQuantumT _irollblockgridquantum)
		{
			return new IRollBlockGridBase_UnionUnion
			{
				Type = IRollBlockGridBase_Union.IRollBlockGridQuantum,
				Value = _irollblockgridquantum
			};
		}

		// Token: 0x0601C3E0 RID: 115680 RVA: 0x003FCD7E File Offset: 0x003FAF7E
		public IRollBlockGridLaserT AsIRollBlockGridLaser()
		{
			return this.As<IRollBlockGridLaserT>();
		}

		// Token: 0x0601C3E1 RID: 115681 RVA: 0x003FCD86 File Offset: 0x003FAF86
		public static IRollBlockGridBase_UnionUnion FromIRollBlockGridLaser(IRollBlockGridLaserT _irollblockgridlaser)
		{
			return new IRollBlockGridBase_UnionUnion
			{
				Type = IRollBlockGridBase_Union.IRollBlockGridLaser,
				Value = _irollblockgridlaser
			};
		}

		// Token: 0x0601C3E2 RID: 115682 RVA: 0x003FCD9C File Offset: 0x003FAF9C
		public static int Pack(FlatBufferBuilder builder, IRollBlockGridBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IRollBlockGridBase_Union.IRollBlockGridBase:
				return IRollBlockGridBase.Pack(builder, _o.AsIRollBlockGridBase()).Value;
			case IRollBlockGridBase_Union.IRollBlockGridEmpty:
				return IRollBlockGridEmpty.Pack(builder, _o.AsIRollBlockGridEmpty()).Value;
			case IRollBlockGridBase_Union.IRollBlockGridFloor:
				return IRollBlockGridFloor.Pack(builder, _o.AsIRollBlockGridFloor()).Value;
			case IRollBlockGridBase_Union.IRollBlockGridGoal:
				return IRollBlockGridGoal.Pack(builder, _o.AsIRollBlockGridGoal()).Value;
			case IRollBlockGridBase_Union.IRollBlockGridLinkGoal:
				return IRollBlockGridLinkGoal.Pack(builder, _o.AsIRollBlockGridLinkGoal()).Value;
			case IRollBlockGridBase_Union.IRollBlockGridJumpFloor:
				return IRollBlockGridJumpFloor.Pack(builder, _o.AsIRollBlockGridJumpFloor()).Value;
			case IRollBlockGridBase_Union.IRollBlockGridFallFloor:
				return IRollBlockGridFallFloor.Pack(builder, _o.AsIRollBlockGridFallFloor()).Value;
			case IRollBlockGridBase_Union.IRollBlockGridBreakTrigger:
				return IRollBlockGridBreakTrigger.Pack(builder, _o.AsIRollBlockGridBreakTrigger()).Value;
			case IRollBlockGridBase_Union.IRollBlockGridQuantum:
				return IRollBlockGridQuantum.Pack(builder, _o.AsIRollBlockGridQuantum()).Value;
			case IRollBlockGridBase_Union.IRollBlockGridLaser:
				return IRollBlockGridLaser.Pack(builder, _o.AsIRollBlockGridLaser()).Value;
			default:
				return 0;
			}
		}
	}
}
