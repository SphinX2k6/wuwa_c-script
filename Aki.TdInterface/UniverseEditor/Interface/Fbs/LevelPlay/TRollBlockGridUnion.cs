using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A7D RID: 19069
	public class TRollBlockGridUnion
	{
		// Token: 0x170085AE RID: 34222
		// (get) Token: 0x0601CAA6 RID: 117414 RVA: 0x0040B25E File Offset: 0x0040945E
		// (set) Token: 0x0601CAA7 RID: 117415 RVA: 0x0040B266 File Offset: 0x00409466
		public TRollBlockGrid Type { get; set; }

		// Token: 0x170085AF RID: 34223
		// (get) Token: 0x0601CAA8 RID: 117416 RVA: 0x0040B26F File Offset: 0x0040946F
		// (set) Token: 0x0601CAA9 RID: 117417 RVA: 0x0040B277 File Offset: 0x00409477
		public object Value { get; set; }

		// Token: 0x0601CAAA RID: 117418 RVA: 0x0040B280 File Offset: 0x00409480
		public TRollBlockGridUnion()
		{
			this.Type = TRollBlockGrid.NONE;
			this.Value = null;
		}

		// Token: 0x0601CAAB RID: 117419 RVA: 0x0040B296 File Offset: 0x00409496
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601CAAC RID: 117420 RVA: 0x0040B2A8 File Offset: 0x004094A8
		public IRollBlockGridBreakTriggerT AsIRollBlockGridBreakTrigger()
		{
			return this.As<IRollBlockGridBreakTriggerT>();
		}

		// Token: 0x0601CAAD RID: 117421 RVA: 0x0040B2B0 File Offset: 0x004094B0
		public static TRollBlockGridUnion FromIRollBlockGridBreakTrigger(IRollBlockGridBreakTriggerT _irollblockgridbreaktrigger)
		{
			return new TRollBlockGridUnion
			{
				Type = TRollBlockGrid.IRollBlockGridBreakTrigger,
				Value = _irollblockgridbreaktrigger
			};
		}

		// Token: 0x0601CAAE RID: 117422 RVA: 0x0040B2C5 File Offset: 0x004094C5
		public IRollBlockGridEmptyT AsIRollBlockGridEmpty()
		{
			return this.As<IRollBlockGridEmptyT>();
		}

		// Token: 0x0601CAAF RID: 117423 RVA: 0x0040B2CD File Offset: 0x004094CD
		public static TRollBlockGridUnion FromIRollBlockGridEmpty(IRollBlockGridEmptyT _irollblockgridempty)
		{
			return new TRollBlockGridUnion
			{
				Type = TRollBlockGrid.IRollBlockGridEmpty,
				Value = _irollblockgridempty
			};
		}

		// Token: 0x0601CAB0 RID: 117424 RVA: 0x0040B2E2 File Offset: 0x004094E2
		public IRollBlockGridFallFloorT AsIRollBlockGridFallFloor()
		{
			return this.As<IRollBlockGridFallFloorT>();
		}

		// Token: 0x0601CAB1 RID: 117425 RVA: 0x0040B2EA File Offset: 0x004094EA
		public static TRollBlockGridUnion FromIRollBlockGridFallFloor(IRollBlockGridFallFloorT _irollblockgridfallfloor)
		{
			return new TRollBlockGridUnion
			{
				Type = TRollBlockGrid.IRollBlockGridFallFloor,
				Value = _irollblockgridfallfloor
			};
		}

		// Token: 0x0601CAB2 RID: 117426 RVA: 0x0040B2FF File Offset: 0x004094FF
		public IRollBlockGridFloorT AsIRollBlockGridFloor()
		{
			return this.As<IRollBlockGridFloorT>();
		}

		// Token: 0x0601CAB3 RID: 117427 RVA: 0x0040B307 File Offset: 0x00409507
		public static TRollBlockGridUnion FromIRollBlockGridFloor(IRollBlockGridFloorT _irollblockgridfloor)
		{
			return new TRollBlockGridUnion
			{
				Type = TRollBlockGrid.IRollBlockGridFloor,
				Value = _irollblockgridfloor
			};
		}

		// Token: 0x0601CAB4 RID: 117428 RVA: 0x0040B31C File Offset: 0x0040951C
		public IRollBlockGridGoalT AsIRollBlockGridGoal()
		{
			return this.As<IRollBlockGridGoalT>();
		}

		// Token: 0x0601CAB5 RID: 117429 RVA: 0x0040B324 File Offset: 0x00409524
		public static TRollBlockGridUnion FromIRollBlockGridGoal(IRollBlockGridGoalT _irollblockgridgoal)
		{
			return new TRollBlockGridUnion
			{
				Type = TRollBlockGrid.IRollBlockGridGoal,
				Value = _irollblockgridgoal
			};
		}

		// Token: 0x0601CAB6 RID: 117430 RVA: 0x0040B339 File Offset: 0x00409539
		public IRollBlockGridJumpFloorT AsIRollBlockGridJumpFloor()
		{
			return this.As<IRollBlockGridJumpFloorT>();
		}

		// Token: 0x0601CAB7 RID: 117431 RVA: 0x0040B341 File Offset: 0x00409541
		public static TRollBlockGridUnion FromIRollBlockGridJumpFloor(IRollBlockGridJumpFloorT _irollblockgridjumpfloor)
		{
			return new TRollBlockGridUnion
			{
				Type = TRollBlockGrid.IRollBlockGridJumpFloor,
				Value = _irollblockgridjumpfloor
			};
		}

		// Token: 0x0601CAB8 RID: 117432 RVA: 0x0040B356 File Offset: 0x00409556
		public IRollBlockGridLaserT AsIRollBlockGridLaser()
		{
			return this.As<IRollBlockGridLaserT>();
		}

		// Token: 0x0601CAB9 RID: 117433 RVA: 0x0040B35E File Offset: 0x0040955E
		public static TRollBlockGridUnion FromIRollBlockGridLaser(IRollBlockGridLaserT _irollblockgridlaser)
		{
			return new TRollBlockGridUnion
			{
				Type = TRollBlockGrid.IRollBlockGridLaser,
				Value = _irollblockgridlaser
			};
		}

		// Token: 0x0601CABA RID: 117434 RVA: 0x0040B373 File Offset: 0x00409573
		public IRollBlockGridLinkGoalT AsIRollBlockGridLinkGoal()
		{
			return this.As<IRollBlockGridLinkGoalT>();
		}

		// Token: 0x0601CABB RID: 117435 RVA: 0x0040B37B File Offset: 0x0040957B
		public static TRollBlockGridUnion FromIRollBlockGridLinkGoal(IRollBlockGridLinkGoalT _irollblockgridlinkgoal)
		{
			return new TRollBlockGridUnion
			{
				Type = TRollBlockGrid.IRollBlockGridLinkGoal,
				Value = _irollblockgridlinkgoal
			};
		}

		// Token: 0x0601CABC RID: 117436 RVA: 0x0040B390 File Offset: 0x00409590
		public IRollBlockGridQuantumT AsIRollBlockGridQuantum()
		{
			return this.As<IRollBlockGridQuantumT>();
		}

		// Token: 0x0601CABD RID: 117437 RVA: 0x0040B398 File Offset: 0x00409598
		public static TRollBlockGridUnion FromIRollBlockGridQuantum(IRollBlockGridQuantumT _irollblockgridquantum)
		{
			return new TRollBlockGridUnion
			{
				Type = TRollBlockGrid.IRollBlockGridQuantum,
				Value = _irollblockgridquantum
			};
		}

		// Token: 0x0601CABE RID: 117438 RVA: 0x0040B3B0 File Offset: 0x004095B0
		public static int Pack(FlatBufferBuilder builder, TRollBlockGridUnion _o)
		{
			switch (_o.Type)
			{
			case TRollBlockGrid.IRollBlockGridBreakTrigger:
				return IRollBlockGridBreakTrigger.Pack(builder, _o.AsIRollBlockGridBreakTrigger()).Value;
			case TRollBlockGrid.IRollBlockGridEmpty:
				return IRollBlockGridEmpty.Pack(builder, _o.AsIRollBlockGridEmpty()).Value;
			case TRollBlockGrid.IRollBlockGridFallFloor:
				return IRollBlockGridFallFloor.Pack(builder, _o.AsIRollBlockGridFallFloor()).Value;
			case TRollBlockGrid.IRollBlockGridFloor:
				return IRollBlockGridFloor.Pack(builder, _o.AsIRollBlockGridFloor()).Value;
			case TRollBlockGrid.IRollBlockGridGoal:
				return IRollBlockGridGoal.Pack(builder, _o.AsIRollBlockGridGoal()).Value;
			case TRollBlockGrid.IRollBlockGridJumpFloor:
				return IRollBlockGridJumpFloor.Pack(builder, _o.AsIRollBlockGridJumpFloor()).Value;
			case TRollBlockGrid.IRollBlockGridLaser:
				return IRollBlockGridLaser.Pack(builder, _o.AsIRollBlockGridLaser()).Value;
			case TRollBlockGrid.IRollBlockGridLinkGoal:
				return IRollBlockGridLinkGoal.Pack(builder, _o.AsIRollBlockGridLinkGoal()).Value;
			case TRollBlockGrid.IRollBlockGridQuantum:
				return IRollBlockGridQuantum.Pack(builder, _o.AsIRollBlockGridQuantum()).Value;
			default:
				return 0;
			}
		}
	}
}
