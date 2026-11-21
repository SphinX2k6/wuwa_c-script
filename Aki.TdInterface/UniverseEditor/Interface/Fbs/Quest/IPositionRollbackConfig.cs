using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043EE RID: 17390
	public struct IPositionRollbackConfig : IFlatbufferObject
	{
		// Token: 0x170077D0 RID: 30672
		// (get) Token: 0x06018B57 RID: 101207 RVA: 0x00385B0B File Offset: 0x00383D0B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018B58 RID: 101208 RVA: 0x00385B18 File Offset: 0x00383D18
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018B59 RID: 101209 RVA: 0x00385B20 File Offset: 0x00383D20
		public static IPositionRollbackConfig GetRootAsIPositionRollbackConfig(ByteBuffer _bb)
		{
			return IPositionRollbackConfig.GetRootAsIPositionRollbackConfig(_bb, default(IPositionRollbackConfig));
		}

		// Token: 0x06018B5A RID: 101210 RVA: 0x00385B3C File Offset: 0x00383D3C
		public static IPositionRollbackConfig GetRootAsIPositionRollbackConfig(ByteBuffer _bb, IPositionRollbackConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018B5B RID: 101211 RVA: 0x00385B59 File Offset: 0x00383D59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018B5C RID: 101212 RVA: 0x00385B68 File Offset: 0x00383D68
		public IPositionRollbackConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170077D1 RID: 30673
		// (get) Token: 0x06018B5D RID: 101213 RVA: 0x00385B78 File Offset: 0x00383D78
		public IVectorInfo? CheckPoint
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170077D2 RID: 30674
		// (get) Token: 0x06018B5E RID: 101214 RVA: 0x00385BD8 File Offset: 0x00383DD8
		public int CheckRange
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170077D3 RID: 30675
		// (get) Token: 0x06018B5F RID: 101215 RVA: 0x00385C14 File Offset: 0x00383E14
		public Aki.UniverseEditor.Interface.Fbs.Action.IPosA? Position
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new Aki.UniverseEditor.Interface.Fbs.Action.IPosA?(default(Aki.UniverseEditor.Interface.Fbs.Action.IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06018B60 RID: 101216 RVA: 0x00385C71 File Offset: 0x00383E71
		public static Offset<IPositionRollbackConfig> CreateIPositionRollbackConfig(FlatBufferBuilder builder, Offset<IVectorInfo> CheckPointOffset = default(Offset<IVectorInfo>), int CheckRange = 0, Offset<Aki.UniverseEditor.Interface.Fbs.Action.IPosA> PositionOffset = default(Offset<Aki.UniverseEditor.Interface.Fbs.Action.IPosA>))
		{
			builder.StartTable(3);
			IPositionRollbackConfig.AddPosition(builder, PositionOffset);
			IPositionRollbackConfig.AddCheckRange(builder, CheckRange);
			IPositionRollbackConfig.AddCheckPoint(builder, CheckPointOffset);
			return IPositionRollbackConfig.EndIPositionRollbackConfig(builder);
		}

		// Token: 0x06018B61 RID: 101217 RVA: 0x00385C95 File Offset: 0x00383E95
		public static void StartIPositionRollbackConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06018B62 RID: 101218 RVA: 0x00385C9E File Offset: 0x00383E9E
		public static void AddCheckPoint(FlatBufferBuilder builder, Offset<IVectorInfo> checkPointOffset)
		{
			builder.AddOffset(0, checkPointOffset.Value, 0);
		}

		// Token: 0x06018B63 RID: 101219 RVA: 0x00385CAE File Offset: 0x00383EAE
		public static void AddCheckRange(FlatBufferBuilder builder, int checkRange)
		{
			builder.AddInt(1, checkRange, 0);
		}

		// Token: 0x06018B64 RID: 101220 RVA: 0x00385CB9 File Offset: 0x00383EB9
		public static void AddPosition(FlatBufferBuilder builder, Offset<Aki.UniverseEditor.Interface.Fbs.Action.IPosA> positionOffset)
		{
			builder.AddOffset(2, positionOffset.Value, 0);
		}

		// Token: 0x06018B65 RID: 101221 RVA: 0x00385CC9 File Offset: 0x00383EC9
		public static Offset<IPositionRollbackConfig> EndIPositionRollbackConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPositionRollbackConfig>(builder.EndTable());
		}

		// Token: 0x06018B66 RID: 101222 RVA: 0x00385CD8 File Offset: 0x00383ED8
		public IPositionRollbackConfigT UnPack()
		{
			IPositionRollbackConfigT positionRollbackConfigT = new IPositionRollbackConfigT();
			this.UnPackTo(positionRollbackConfigT);
			return positionRollbackConfigT;
		}

		// Token: 0x06018B67 RID: 101223 RVA: 0x00385CF4 File Offset: 0x00383EF4
		public void UnPackTo(IPositionRollbackConfigT _o)
		{
			_o.CheckPoint = ((this.CheckPoint != null) ? this.CheckPoint.Value.UnPack() : null);
			_o.CheckRange = this.CheckRange;
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
		}

		// Token: 0x06018B68 RID: 101224 RVA: 0x00385D6C File Offset: 0x00383F6C
		public static Offset<IPositionRollbackConfig> Pack(FlatBufferBuilder builder, IPositionRollbackConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPositionRollbackConfig>);
			}
			Offset<IVectorInfo> checkPointOffset = (_o.CheckPoint == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.CheckPoint);
			Offset<Aki.UniverseEditor.Interface.Fbs.Action.IPosA> positionOffset = (_o.Position == null) ? default(Offset<Aki.UniverseEditor.Interface.Fbs.Action.IPosA>) : Aki.UniverseEditor.Interface.Fbs.Action.IPosA.Pack(builder, _o.Position);
			return IPositionRollbackConfig.CreateIPositionRollbackConfig(builder, checkPointOffset, _o.CheckRange, positionOffset);
		}

		// Token: 0x0400C3FB RID: 50171
		private Table __p;
	}
}
