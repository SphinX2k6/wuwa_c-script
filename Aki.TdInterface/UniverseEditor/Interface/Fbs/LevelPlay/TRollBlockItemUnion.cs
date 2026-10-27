using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200461B RID: 17947
	public class TRollBlockItemUnion
	{
		// Token: 0x17007F71 RID: 32625
		// (get) Token: 0x0601B2F9 RID: 111353 RVA: 0x003DF3E0 File Offset: 0x003DD5E0
		// (set) Token: 0x0601B2FA RID: 111354 RVA: 0x003DF3E8 File Offset: 0x003DD5E8
		public TRollBlockItem Type { get; set; }

		// Token: 0x17007F72 RID: 32626
		// (get) Token: 0x0601B2FB RID: 111355 RVA: 0x003DF3F1 File Offset: 0x003DD5F1
		// (set) Token: 0x0601B2FC RID: 111356 RVA: 0x003DF3F9 File Offset: 0x003DD5F9
		public object Value { get; set; }

		// Token: 0x0601B2FD RID: 111357 RVA: 0x003DF402 File Offset: 0x003DD602
		public TRollBlockItemUnion()
		{
			this.Type = TRollBlockItem.NONE;
			this.Value = null;
		}

		// Token: 0x0601B2FE RID: 111358 RVA: 0x003DF418 File Offset: 0x003DD618
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B2FF RID: 111359 RVA: 0x003DF42A File Offset: 0x003DD62A
		public IRollBlockItemBreakableObstacleT AsIRollBlockItemBreakableObstacle()
		{
			return this.As<IRollBlockItemBreakableObstacleT>();
		}

		// Token: 0x0601B300 RID: 111360 RVA: 0x003DF432 File Offset: 0x003DD632
		public static TRollBlockItemUnion FromIRollBlockItemBreakableObstacle(IRollBlockItemBreakableObstacleT _irollblockitembreakableobstacle)
		{
			return new TRollBlockItemUnion
			{
				Type = TRollBlockItem.IRollBlockItemBreakableObstacle,
				Value = _irollblockitembreakableobstacle
			};
		}

		// Token: 0x0601B301 RID: 111361 RVA: 0x003DF447 File Offset: 0x003DD647
		public IRollBlockItemLaserEmitterT AsIRollBlockItemLaserEmitter()
		{
			return this.As<IRollBlockItemLaserEmitterT>();
		}

		// Token: 0x0601B302 RID: 111362 RVA: 0x003DF44F File Offset: 0x003DD64F
		public static TRollBlockItemUnion FromIRollBlockItemLaserEmitter(IRollBlockItemLaserEmitterT _irollblockitemlaseremitter)
		{
			return new TRollBlockItemUnion
			{
				Type = TRollBlockItem.IRollBlockItemLaserEmitter,
				Value = _irollblockitemlaseremitter
			};
		}

		// Token: 0x0601B303 RID: 111363 RVA: 0x003DF464 File Offset: 0x003DD664
		public IRollBlockItemQuantumObstacleT AsIRollBlockItemQuantumObstacle()
		{
			return this.As<IRollBlockItemQuantumObstacleT>();
		}

		// Token: 0x0601B304 RID: 111364 RVA: 0x003DF46C File Offset: 0x003DD66C
		public static TRollBlockItemUnion FromIRollBlockItemQuantumObstacle(IRollBlockItemQuantumObstacleT _irollblockitemquantumobstacle)
		{
			return new TRollBlockItemUnion
			{
				Type = TRollBlockItem.IRollBlockItemQuantumObstacle,
				Value = _irollblockitemquantumobstacle
			};
		}

		// Token: 0x0601B305 RID: 111365 RVA: 0x003DF484 File Offset: 0x003DD684
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
