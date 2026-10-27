using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004615 RID: 17941
	public class TRollBlockGridUnion
	{
		// Token: 0x17007F6D RID: 32621
		// (get) Token: 0x0601B2D1 RID: 111313 RVA: 0x003DEFC2 File Offset: 0x003DD1C2
		// (set) Token: 0x0601B2D2 RID: 111314 RVA: 0x003DEFCA File Offset: 0x003DD1CA
		public TRollBlockGrid Type { get; set; }

		// Token: 0x17007F6E RID: 32622
		// (get) Token: 0x0601B2D3 RID: 111315 RVA: 0x003DEFD3 File Offset: 0x003DD1D3
		// (set) Token: 0x0601B2D4 RID: 111316 RVA: 0x003DEFDB File Offset: 0x003DD1DB
		public object Value { get; set; }

		// Token: 0x0601B2D5 RID: 111317 RVA: 0x003DEFE4 File Offset: 0x003DD1E4
		public TRollBlockGridUnion()
		{
			this.Type = TRollBlockGrid.NONE;
			this.Value = null;
		}

		// Token: 0x0601B2D6 RID: 111318 RVA: 0x003DEFFA File Offset: 0x003DD1FA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B2D7 RID: 111319 RVA: 0x003DF00C File Offset: 0x003DD20C
		public IRollBlockGridBreakTriggerT AsIRollBlockGridBreakTrigger()
		{
			return this.As<IRollBlockGridBreakTriggerT>();
		}

		// Token: 0x0601B2D8 RID: 111320 RVA: 0x003DF014 File Offset: 0x003DD214
		public static TRollBlockGridUnion FromIRollBlockGridBreakTrigger(IRollBlockGridBreakTriggerT _irollblockgridbreaktrigger)
		{
			return new TRollBlockGridUnion
			{
				Type = TRollBlockGrid.IRollBlockGridBreakTrigger,
				Value = _irollblockgridbreaktrigger
			};
		}

		// Token: 0x0601B2D9 RID: 111321 RVA: 0x003DF029 File Offset: 0x003DD229
		public IRollBlockGridEmptyT AsIRollBlockGridEmpty()
		{
			return this.As<IRollBlockGridEmptyT>();
		}

		// Token: 0x0601B2DA RID: 111322 RVA: 0x003DF031 File Offset: 0x003DD231
		public static TRollBlockGridUnion FromIRollBlockGridEmpty(IRollBlockGridEmptyT _irollblockgridempty)
		{
			return new TRollBlockGridUnion
			{
				Type = TRollBlockGrid.IRollBlockGridEmpty,
				Value = _irollblockgridempty
			};
		}

		// Token: 0x0601B2DB RID: 111323 RVA: 0x003DF046 File Offset: 0x003DD246
		public IRollBlockGridFallFloorT AsIRollBlockGridFallFloor()
		{
			return this.As<IRollBlockGridFallFloorT>();
		}

		// Token: 0x0601B2DC RID: 111324 RVA: 0x003DF04E File Offset: 0x003DD24E
		public static TRollBlockGridUnion FromIRollBlockGridFallFloor(IRollBlockGridFallFloorT _irollblockgridfallfloor)
		{
			return new TRollBlockGridUnion
			{
				Type = TRollBlockGrid.IRollBlockGridFallFloor,
				Value = _irollblockgridfallfloor
			};
		}

		// Token: 0x0601B2DD RID: 111325 RVA: 0x003DF063 File Offset: 0x003DD263
		public IRollBlockGridFloorT AsIRollBlockGridFloor()
		{
			return this.As<IRollBlockGridFloorT>();
		}

		// Token: 0x0601B2DE RID: 111326 RVA: 0x003DF06B File Offset: 0x003DD26B
		public static TRollBlockGridUnion FromIRollBlockGridFloor(IRollBlockGridFloorT _irollblockgridfloor)
		{
			return new TRollBlockGridUnion
			{
				Type = TRollBlockGrid.IRollBlockGridFloor,
				Value = _irollblockgridfloor
			};
		}

		// Token: 0x0601B2DF RID: 111327 RVA: 0x003DF080 File Offset: 0x003DD280
		public IRollBlockGridGoalT AsIRollBlockGridGoal()
		{
			return this.As<IRollBlockGridGoalT>();
		}

		// Token: 0x0601B2E0 RID: 111328 RVA: 0x003DF088 File Offset: 0x003DD288
		public static TRollBlockGridUnion FromIRollBlockGridGoal(IRollBlockGridGoalT _irollblockgridgoal)
		{
			return new TRollBlockGridUnion
			{
				Type = TRollBlockGrid.IRollBlockGridGoal,
				Value = _irollblockgridgoal
			};
		}

		// Token: 0x0601B2E1 RID: 111329 RVA: 0x003DF09D File Offset: 0x003DD29D
		public IRollBlockGridJumpFloorT AsIRollBlockGridJumpFloor()
		{
			return this.As<IRollBlockGridJumpFloorT>();
		}

		// Token: 0x0601B2E2 RID: 111330 RVA: 0x003DF0A5 File Offset: 0x003DD2A5
		public static TRollBlockGridUnion FromIRollBlockGridJumpFloor(IRollBlockGridJumpFloorT _irollblockgridjumpfloor)
		{
			return new TRollBlockGridUnion
			{
				Type = TRollBlockGrid.IRollBlockGridJumpFloor,
				Value = _irollblockgridjumpfloor
			};
		}

		// Token: 0x0601B2E3 RID: 111331 RVA: 0x003DF0BA File Offset: 0x003DD2BA
		public IRollBlockGridLaserT AsIRollBlockGridLaser()
		{
			return this.As<IRollBlockGridLaserT>();
		}

		// Token: 0x0601B2E4 RID: 111332 RVA: 0x003DF0C2 File Offset: 0x003DD2C2
		public static TRollBlockGridUnion FromIRollBlockGridLaser(IRollBlockGridLaserT _irollblockgridlaser)
		{
			return new TRollBlockGridUnion
			{
				Type = TRollBlockGrid.IRollBlockGridLaser,
				Value = _irollblockgridlaser
			};
		}

		// Token: 0x0601B2E5 RID: 111333 RVA: 0x003DF0D7 File Offset: 0x003DD2D7
		public IRollBlockGridLinkGoalT AsIRollBlockGridLinkGoal()
		{
			return this.As<IRollBlockGridLinkGoalT>();
		}

		// Token: 0x0601B2E6 RID: 111334 RVA: 0x003DF0DF File Offset: 0x003DD2DF
		public static TRollBlockGridUnion FromIRollBlockGridLinkGoal(IRollBlockGridLinkGoalT _irollblockgridlinkgoal)
		{
			return new TRollBlockGridUnion
			{
				Type = TRollBlockGrid.IRollBlockGridLinkGoal,
				Value = _irollblockgridlinkgoal
			};
		}

		// Token: 0x0601B2E7 RID: 111335 RVA: 0x003DF0F4 File Offset: 0x003DD2F4
		public IRollBlockGridQuantumT AsIRollBlockGridQuantum()
		{
			return this.As<IRollBlockGridQuantumT>();
		}

		// Token: 0x0601B2E8 RID: 111336 RVA: 0x003DF0FC File Offset: 0x003DD2FC
		public static TRollBlockGridUnion FromIRollBlockGridQuantum(IRollBlockGridQuantumT _irollblockgridquantum)
		{
			return new TRollBlockGridUnion
			{
				Type = TRollBlockGrid.IRollBlockGridQuantum,
				Value = _irollblockgridquantum
			};
		}

		// Token: 0x0601B2E9 RID: 111337 RVA: 0x003DF114 File Offset: 0x003DD314
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
