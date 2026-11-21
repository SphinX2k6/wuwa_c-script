using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A83 RID: 19075
	public class TRollBlockItemUnion
	{
		// Token: 0x170085B2 RID: 34226
		// (get) Token: 0x0601CACE RID: 117454 RVA: 0x0040B67C File Offset: 0x0040987C
		// (set) Token: 0x0601CACF RID: 117455 RVA: 0x0040B684 File Offset: 0x00409884
		public TRollBlockItem Type { get; set; }

		// Token: 0x170085B3 RID: 34227
		// (get) Token: 0x0601CAD0 RID: 117456 RVA: 0x0040B68D File Offset: 0x0040988D
		// (set) Token: 0x0601CAD1 RID: 117457 RVA: 0x0040B695 File Offset: 0x00409895
		public object Value { get; set; }

		// Token: 0x0601CAD2 RID: 117458 RVA: 0x0040B69E File Offset: 0x0040989E
		public TRollBlockItemUnion()
		{
			this.Type = TRollBlockItem.NONE;
			this.Value = null;
		}

		// Token: 0x0601CAD3 RID: 117459 RVA: 0x0040B6B4 File Offset: 0x004098B4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601CAD4 RID: 117460 RVA: 0x0040B6C6 File Offset: 0x004098C6
		public IRollBlockItemBreakableObstacleT AsIRollBlockItemBreakableObstacle()
		{
			return this.As<IRollBlockItemBreakableObstacleT>();
		}

		// Token: 0x0601CAD5 RID: 117461 RVA: 0x0040B6CE File Offset: 0x004098CE
		public static TRollBlockItemUnion FromIRollBlockItemBreakableObstacle(IRollBlockItemBreakableObstacleT _irollblockitembreakableobstacle)
		{
			return new TRollBlockItemUnion
			{
				Type = TRollBlockItem.IRollBlockItemBreakableObstacle,
				Value = _irollblockitembreakableobstacle
			};
		}

		// Token: 0x0601CAD6 RID: 117462 RVA: 0x0040B6E3 File Offset: 0x004098E3
		public IRollBlockItemLaserEmitterT AsIRollBlockItemLaserEmitter()
		{
			return this.As<IRollBlockItemLaserEmitterT>();
		}

		// Token: 0x0601CAD7 RID: 117463 RVA: 0x0040B6EB File Offset: 0x004098EB
		public static TRollBlockItemUnion FromIRollBlockItemLaserEmitter(IRollBlockItemLaserEmitterT _irollblockitemlaseremitter)
		{
			return new TRollBlockItemUnion
			{
				Type = TRollBlockItem.IRollBlockItemLaserEmitter,
				Value = _irollblockitemlaseremitter
			};
		}

		// Token: 0x0601CAD8 RID: 117464 RVA: 0x0040B700 File Offset: 0x00409900
		public IRollBlockItemQuantumObstacleT AsIRollBlockItemQuantumObstacle()
		{
			return this.As<IRollBlockItemQuantumObstacleT>();
		}

		// Token: 0x0601CAD9 RID: 117465 RVA: 0x0040B708 File Offset: 0x00409908
		public static TRollBlockItemUnion FromIRollBlockItemQuantumObstacle(IRollBlockItemQuantumObstacleT _irollblockitemquantumobstacle)
		{
			return new TRollBlockItemUnion
			{
				Type = TRollBlockItem.IRollBlockItemQuantumObstacle,
				Value = _irollblockitemquantumobstacle
			};
		}

		// Token: 0x0601CADA RID: 117466 RVA: 0x0040B720 File Offset: 0x00409920
		public static int Pack(FlatBufferBuilder builder, TRollBlockItemUnion _o)
		{
			switch (_o.Type)
			{
			case TRollBlockItem.IRollBlockItemBreakableObstacle:
				return IRollBlockItemBreakableObstacle.Pack(builder, _o.AsIRollBlockItemBreakableObstacle()).Value;
			case TRollBlockItem.IRollBlockItemLaserEmitter:
				return IRollBlockItemLaserEmitter.Pack(builder, _o.AsIRollBlockItemLaserEmitter()).Value;
			case TRollBlockItem.IRollBlockItemQuantumObstacle:
				return IRollBlockItemQuantumObstacle.Pack(builder, _o.AsIRollBlockItemQuantumObstacle()).Value;
			default:
				return 0;
			}
		}
	}
}
