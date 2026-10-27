using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004594 RID: 17812
	public class IRollBlockItemBase_UnionUnion
	{
		// Token: 0x17007E88 RID: 32392
		// (get) Token: 0x0601AE7B RID: 110203 RVA: 0x003D6B71 File Offset: 0x003D4D71
		// (set) Token: 0x0601AE7C RID: 110204 RVA: 0x003D6B79 File Offset: 0x003D4D79
		public IRollBlockItemBase_Union Type { get; set; }

		// Token: 0x17007E89 RID: 32393
		// (get) Token: 0x0601AE7D RID: 110205 RVA: 0x003D6B82 File Offset: 0x003D4D82
		// (set) Token: 0x0601AE7E RID: 110206 RVA: 0x003D6B8A File Offset: 0x003D4D8A
		public object Value { get; set; }

		// Token: 0x0601AE7F RID: 110207 RVA: 0x003D6B93 File Offset: 0x003D4D93
		public IRollBlockItemBase_UnionUnion()
		{
			this.Type = IRollBlockItemBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601AE80 RID: 110208 RVA: 0x003D6BA9 File Offset: 0x003D4DA9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AE81 RID: 110209 RVA: 0x003D6BBB File Offset: 0x003D4DBB
		public IRollBlockItemBaseT AsIRollBlockItemBase()
		{
			return this.As<IRollBlockItemBaseT>();
		}

		// Token: 0x0601AE82 RID: 110210 RVA: 0x003D6BC3 File Offset: 0x003D4DC3
		public static IRollBlockItemBase_UnionUnion FromIRollBlockItemBase(IRollBlockItemBaseT _irollblockitembase)
		{
			return new IRollBlockItemBase_UnionUnion
			{
				Type = IRollBlockItemBase_Union.IRollBlockItemBase,
				Value = _irollblockitembase
			};
		}

		// Token: 0x0601AE83 RID: 110211 RVA: 0x003D6BD8 File Offset: 0x003D4DD8
		public IRollBlockItemBreakableObstacleT AsIRollBlockItemBreakableObstacle()
		{
			return this.As<IRollBlockItemBreakableObstacleT>();
		}

		// Token: 0x0601AE84 RID: 110212 RVA: 0x003D6BE0 File Offset: 0x003D4DE0
		public static IRollBlockItemBase_UnionUnion FromIRollBlockItemBreakableObstacle(IRollBlockItemBreakableObstacleT _irollblockitembreakableobstacle)
		{
			return new IRollBlockItemBase_UnionUnion
			{
				Type = IRollBlockItemBase_Union.IRollBlockItemBreakableObstacle,
				Value = _irollblockitembreakableobstacle
			};
		}

		// Token: 0x0601AE85 RID: 110213 RVA: 0x003D6BF5 File Offset: 0x003D4DF5
		public IRollBlockItemQuantumObstacleT AsIRollBlockItemQuantumObstacle()
		{
			return this.As<IRollBlockItemQuantumObstacleT>();
		}

		// Token: 0x0601AE86 RID: 110214 RVA: 0x003D6BFD File Offset: 0x003D4DFD
		public static IRollBlockItemBase_UnionUnion FromIRollBlockItemQuantumObstacle(IRollBlockItemQuantumObstacleT _irollblockitemquantumobstacle)
		{
			return new IRollBlockItemBase_UnionUnion
			{
				Type = IRollBlockItemBase_Union.IRollBlockItemQuantumObstacle,
				Value = _irollblockitemquantumobstacle
			};
		}

		// Token: 0x0601AE87 RID: 110215 RVA: 0x003D6C12 File Offset: 0x003D4E12
		public IRollBlockItemLaserEmitterT AsIRollBlockItemLaserEmitter()
		{
			return this.As<IRollBlockItemLaserEmitterT>();
		}

		// Token: 0x0601AE88 RID: 110216 RVA: 0x003D6C1A File Offset: 0x003D4E1A
		public static IRollBlockItemBase_UnionUnion FromIRollBlockItemLaserEmitter(IRollBlockItemLaserEmitterT _irollblockitemlaseremitter)
		{
			return new IRollBlockItemBase_UnionUnion
			{
				Type = IRollBlockItemBase_Union.IRollBlockItemLaserEmitter,
				Value = _irollblockitemlaseremitter
			};
		}

		// Token: 0x0601AE89 RID: 110217 RVA: 0x003D6C30 File Offset: 0x003D4E30
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
