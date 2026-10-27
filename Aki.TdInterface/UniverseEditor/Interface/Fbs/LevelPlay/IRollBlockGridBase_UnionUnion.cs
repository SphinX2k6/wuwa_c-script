using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004561 RID: 17761
	public class IRollBlockGridBase_UnionUnion
	{
		// Token: 0x17007E02 RID: 32258
		// (get) Token: 0x0601ABF3 RID: 109555 RVA: 0x003D0992 File Offset: 0x003CEB92
		// (set) Token: 0x0601ABF4 RID: 109556 RVA: 0x003D099A File Offset: 0x003CEB9A
		public IRollBlockGridBase_Union Type { get; set; }

		// Token: 0x17007E03 RID: 32259
		// (get) Token: 0x0601ABF5 RID: 109557 RVA: 0x003D09A3 File Offset: 0x003CEBA3
		// (set) Token: 0x0601ABF6 RID: 109558 RVA: 0x003D09AB File Offset: 0x003CEBAB
		public object Value { get; set; }

		// Token: 0x0601ABF7 RID: 109559 RVA: 0x003D09B4 File Offset: 0x003CEBB4
		public IRollBlockGridBase_UnionUnion()
		{
			this.Type = IRollBlockGridBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601ABF8 RID: 109560 RVA: 0x003D09CA File Offset: 0x003CEBCA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601ABF9 RID: 109561 RVA: 0x003D09DC File Offset: 0x003CEBDC
		public IRollBlockGridBaseT AsIRollBlockGridBase()
		{
			return this.As<IRollBlockGridBaseT>();
		}

		// Token: 0x0601ABFA RID: 109562 RVA: 0x003D09E4 File Offset: 0x003CEBE4
		public static IRollBlockGridBase_UnionUnion FromIRollBlockGridBase(IRollBlockGridBaseT _irollblockgridbase)
		{
			return new IRollBlockGridBase_UnionUnion
			{
				Type = IRollBlockGridBase_Union.IRollBlockGridBase,
				Value = _irollblockgridbase
			};
		}

		// Token: 0x0601ABFB RID: 109563 RVA: 0x003D09F9 File Offset: 0x003CEBF9
		public IRollBlockGridEmptyT AsIRollBlockGridEmpty()
		{
			return this.As<IRollBlockGridEmptyT>();
		}

		// Token: 0x0601ABFC RID: 109564 RVA: 0x003D0A01 File Offset: 0x003CEC01
		public static IRollBlockGridBase_UnionUnion FromIRollBlockGridEmpty(IRollBlockGridEmptyT _irollblockgridempty)
		{
			return new IRollBlockGridBase_UnionUnion
			{
				Type = IRollBlockGridBase_Union.IRollBlockGridEmpty,
				Value = _irollblockgridempty
			};
		}

		// Token: 0x0601ABFD RID: 109565 RVA: 0x003D0A16 File Offset: 0x003CEC16
		public IRollBlockGridFloorT AsIRollBlockGridFloor()
		{
			return this.As<IRollBlockGridFloorT>();
		}

		// Token: 0x0601ABFE RID: 109566 RVA: 0x003D0A1E File Offset: 0x003CEC1E
		public static IRollBlockGridBase_UnionUnion FromIRollBlockGridFloor(IRollBlockGridFloorT _irollblockgridfloor)
		{
			return new IRollBlockGridBase_UnionUnion
			{
				Type = IRollBlockGridBase_Union.IRollBlockGridFloor,
				Value = _irollblockgridfloor
			};
		}

		// Token: 0x0601ABFF RID: 109567 RVA: 0x003D0A33 File Offset: 0x003CEC33
		public IRollBlockGridGoalT AsIRollBlockGridGoal()
		{
			return this.As<IRollBlockGridGoalT>();
		}

		// Token: 0x0601AC00 RID: 109568 RVA: 0x003D0A3B File Offset: 0x003CEC3B
		public static IRollBlockGridBase_UnionUnion FromIRollBlockGridGoal(IRollBlockGridGoalT _irollblockgridgoal)
		{
			return new IRollBlockGridBase_UnionUnion
			{
				Type = IRollBlockGridBase_Union.IRollBlockGridGoal,
				Value = _irollblockgridgoal
			};
		}

		// Token: 0x0601AC01 RID: 109569 RVA: 0x003D0A50 File Offset: 0x003CEC50
		public IRollBlockGridLinkGoalT AsIRollBlockGridLinkGoal()
		{
			return this.As<IRollBlockGridLinkGoalT>();
		}

		// Token: 0x0601AC02 RID: 109570 RVA: 0x003D0A58 File Offset: 0x003CEC58
		public static IRollBlockGridBase_UnionUnion FromIRollBlockGridLinkGoal(IRollBlockGridLinkGoalT _irollblockgridlinkgoal)
		{
			return new IRollBlockGridBase_UnionUnion
			{
				Type = IRollBlockGridBase_Union.IRollBlockGridLinkGoal,
				Value = _irollblockgridlinkgoal
			};
		}

		// Token: 0x0601AC03 RID: 109571 RVA: 0x003D0A6D File Offset: 0x003CEC6D
		public IRollBlockGridJumpFloorT AsIRollBlockGridJumpFloor()
		{
			return this.As<IRollBlockGridJumpFloorT>();
		}

		// Token: 0x0601AC04 RID: 109572 RVA: 0x003D0A75 File Offset: 0x003CEC75
		public static IRollBlockGridBase_UnionUnion FromIRollBlockGridJumpFloor(IRollBlockGridJumpFloorT _irollblockgridjumpfloor)
		{
			return new IRollBlockGridBase_UnionUnion
			{
				Type = IRollBlockGridBase_Union.IRollBlockGridJumpFloor,
				Value = _irollblockgridjumpfloor
			};
		}

		// Token: 0x0601AC05 RID: 109573 RVA: 0x003D0A8A File Offset: 0x003CEC8A
		public IRollBlockGridFallFloorT AsIRollBlockGridFallFloor()
		{
			return this.As<IRollBlockGridFallFloorT>();
		}

		// Token: 0x0601AC06 RID: 109574 RVA: 0x003D0A92 File Offset: 0x003CEC92
		public static IRollBlockGridBase_UnionUnion FromIRollBlockGridFallFloor(IRollBlockGridFallFloorT _irollblockgridfallfloor)
		{
			return new IRollBlockGridBase_UnionUnion
			{
				Type = IRollBlockGridBase_Union.IRollBlockGridFallFloor,
				Value = _irollblockgridfallfloor
			};
		}

		// Token: 0x0601AC07 RID: 109575 RVA: 0x003D0AA7 File Offset: 0x003CECA7
		public IRollBlockGridBreakTriggerT AsIRollBlockGridBreakTrigger()
		{
			return this.As<IRollBlockGridBreakTriggerT>();
		}

		// Token: 0x0601AC08 RID: 109576 RVA: 0x003D0AAF File Offset: 0x003CECAF
		public static IRollBlockGridBase_UnionUnion FromIRollBlockGridBreakTrigger(IRollBlockGridBreakTriggerT _irollblockgridbreaktrigger)
		{
			return new IRollBlockGridBase_UnionUnion
			{
				Type = IRollBlockGridBase_Union.IRollBlockGridBreakTrigger,
				Value = _irollblockgridbreaktrigger
			};
		}

		// Token: 0x0601AC09 RID: 109577 RVA: 0x003D0AC4 File Offset: 0x003CECC4
		public IRollBlockGridQuantumT AsIRollBlockGridQuantum()
		{
			return this.As<IRollBlockGridQuantumT>();
		}

		// Token: 0x0601AC0A RID: 109578 RVA: 0x003D0ACC File Offset: 0x003CECCC
		public static IRollBlockGridBase_UnionUnion FromIRollBlockGridQuantum(IRollBlockGridQuantumT _irollblockgridquantum)
		{
			return new IRollBlockGridBase_UnionUnion
			{
				Type = IRollBlockGridBase_Union.IRollBlockGridQuantum,
				Value = _irollblockgridquantum
			};
		}

		// Token: 0x0601AC0B RID: 109579 RVA: 0x003D0AE2 File Offset: 0x003CECE2
		public IRollBlockGridLaserT AsIRollBlockGridLaser()
		{
			return this.As<IRollBlockGridLaserT>();
		}

		// Token: 0x0601AC0C RID: 109580 RVA: 0x003D0AEA File Offset: 0x003CECEA
		public static IRollBlockGridBase_UnionUnion FromIRollBlockGridLaser(IRollBlockGridLaserT _irollblockgridlaser)
		{
			return new IRollBlockGridBase_UnionUnion
			{
				Type = IRollBlockGridBase_Union.IRollBlockGridLaser,
				Value = _irollblockgridlaser
			};
		}

		// Token: 0x0601AC0D RID: 109581 RVA: 0x003D0B00 File Offset: 0x003CED00
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
