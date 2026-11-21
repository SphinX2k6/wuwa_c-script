using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049FC RID: 18940
	public class IRollBlockItemBase_UnionUnion
	{
		// Token: 0x170084C9 RID: 33993
		// (get) Token: 0x0601C650 RID: 116304 RVA: 0x00402E0D File Offset: 0x0040100D
		// (set) Token: 0x0601C651 RID: 116305 RVA: 0x00402E15 File Offset: 0x00401015
		public IRollBlockItemBase_Union Type { get; set; }

		// Token: 0x170084CA RID: 33994
		// (get) Token: 0x0601C652 RID: 116306 RVA: 0x00402E1E File Offset: 0x0040101E
		// (set) Token: 0x0601C653 RID: 116307 RVA: 0x00402E26 File Offset: 0x00401026
		public object Value { get; set; }

		// Token: 0x0601C654 RID: 116308 RVA: 0x00402E2F File Offset: 0x0040102F
		public IRollBlockItemBase_UnionUnion()
		{
			this.Type = IRollBlockItemBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601C655 RID: 116309 RVA: 0x00402E45 File Offset: 0x00401045
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601C656 RID: 116310 RVA: 0x00402E57 File Offset: 0x00401057
		public IRollBlockItemBaseT AsIRollBlockItemBase()
		{
			return this.As<IRollBlockItemBaseT>();
		}

		// Token: 0x0601C657 RID: 116311 RVA: 0x00402E5F File Offset: 0x0040105F
		public static IRollBlockItemBase_UnionUnion FromIRollBlockItemBase(IRollBlockItemBaseT _irollblockitembase)
		{
			return new IRollBlockItemBase_UnionUnion
			{
				Type = IRollBlockItemBase_Union.IRollBlockItemBase,
				Value = _irollblockitembase
			};
		}

		// Token: 0x0601C658 RID: 116312 RVA: 0x00402E74 File Offset: 0x00401074
		public IRollBlockItemBreakableObstacleT AsIRollBlockItemBreakableObstacle()
		{
			return this.As<IRollBlockItemBreakableObstacleT>();
		}

		// Token: 0x0601C659 RID: 116313 RVA: 0x00402E7C File Offset: 0x0040107C
		public static IRollBlockItemBase_UnionUnion FromIRollBlockItemBreakableObstacle(IRollBlockItemBreakableObstacleT _irollblockitembreakableobstacle)
		{
			return new IRollBlockItemBase_UnionUnion
			{
				Type = IRollBlockItemBase_Union.IRollBlockItemBreakableObstacle,
				Value = _irollblockitembreakableobstacle
			};
		}

		// Token: 0x0601C65A RID: 116314 RVA: 0x00402E91 File Offset: 0x00401091
		public IRollBlockItemQuantumObstacleT AsIRollBlockItemQuantumObstacle()
		{
			return this.As<IRollBlockItemQuantumObstacleT>();
		}

		// Token: 0x0601C65B RID: 116315 RVA: 0x00402E99 File Offset: 0x00401099
		public static IRollBlockItemBase_UnionUnion FromIRollBlockItemQuantumObstacle(IRollBlockItemQuantumObstacleT _irollblockitemquantumobstacle)
		{
			return new IRollBlockItemBase_UnionUnion
			{
				Type = IRollBlockItemBase_Union.IRollBlockItemQuantumObstacle,
				Value = _irollblockitemquantumobstacle
			};
		}

		// Token: 0x0601C65C RID: 116316 RVA: 0x00402EAE File Offset: 0x004010AE
		public IRollBlockItemLaserEmitterT AsIRollBlockItemLaserEmitter()
		{
			return this.As<IRollBlockItemLaserEmitterT>();
		}

		// Token: 0x0601C65D RID: 116317 RVA: 0x00402EB6 File Offset: 0x004010B6
		public static IRollBlockItemBase_UnionUnion FromIRollBlockItemLaserEmitter(IRollBlockItemLaserEmitterT _irollblockitemlaseremitter)
		{
			return new IRollBlockItemBase_UnionUnion
			{
				Type = IRollBlockItemBase_Union.IRollBlockItemLaserEmitter,
				Value = _irollblockitemlaseremitter
			};
		}

		// Token: 0x0601C65E RID: 116318 RVA: 0x00402ECC File Offset: 0x004010CC
		public static int Pack(FlatBufferBuilder builder, IRollBlockItemBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IRollBlockItemBase_Union.IRollBlockItemBase:
				return IRollBlockItemBase.Pack(builder, _o.AsIRollBlockItemBase()).Value;
			case IRollBlockItemBase_Union.IRollBlockItemBreakableObstacle:
				return IRollBlockItemBreakableObstacle.Pack(builder, _o.AsIRollBlockItemBreakableObstacle()).Value;
			case IRollBlockItemBase_Union.IRollBlockItemQuantumObstacle:
				return IRollBlockItemQuantumObstacle.Pack(builder, _o.AsIRollBlockItemQuantumObstacle()).Value;
			case IRollBlockItemBase_Union.IRollBlockItemLaserEmitter:
				return IRollBlockItemLaserEmitter.Pack(builder, _o.AsIRollBlockItemLaserEmitter()).Value;
			default:
				return 0;
			}
		}
	}
}
