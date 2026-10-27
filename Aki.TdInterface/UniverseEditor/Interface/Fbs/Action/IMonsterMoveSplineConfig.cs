using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ADC RID: 27356
	public struct IMonsterMoveSplineConfig : IFlatbufferObject
	{
		// Token: 0x1700CAF3 RID: 51955
		// (get) Token: 0x0602FF30 RID: 196400 RVA: 0x006854B5 File Offset: 0x006836B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FF31 RID: 196401 RVA: 0x006854C2 File Offset: 0x006836C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FF32 RID: 196402 RVA: 0x006854CC File Offset: 0x006836CC
		public static IMonsterMoveSplineConfig GetRootAsIMonsterMoveSplineConfig(ByteBuffer _bb)
		{
			return IMonsterMoveSplineConfig.GetRootAsIMonsterMoveSplineConfig(_bb, default(IMonsterMoveSplineConfig));
		}

		// Token: 0x0602FF33 RID: 196403 RVA: 0x006854E8 File Offset: 0x006836E8
		public static IMonsterMoveSplineConfig GetRootAsIMonsterMoveSplineConfig(ByteBuffer _bb, IMonsterMoveSplineConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FF34 RID: 196404 RVA: 0x00685505 File Offset: 0x00683705
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FF35 RID: 196405 RVA: 0x00685514 File Offset: 0x00683714
		public IMonsterMoveSplineConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CAF4 RID: 51956
		// (get) Token: 0x0602FF36 RID: 196406 RVA: 0x00685524 File Offset: 0x00683724
		public int TargetEntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CAF5 RID: 51957
		// (get) Token: 0x0602FF37 RID: 196407 RVA: 0x00685560 File Offset: 0x00683760
		public int SplineEntityId
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

		// Token: 0x0602FF38 RID: 196408 RVA: 0x0068559C File Offset: 0x0068379C
		public static Offset<IMonsterMoveSplineConfig> CreateIMonsterMoveSplineConfig(FlatBufferBuilder builder, int TargetEntityId = 0, int SplineEntityId = 0)
		{
			builder.StartTable(2);
			IMonsterMoveSplineConfig.AddSplineEntityId(builder, SplineEntityId);
			IMonsterMoveSplineConfig.AddTargetEntityId(builder, TargetEntityId);
			return IMonsterMoveSplineConfig.EndIMonsterMoveSplineConfig(builder);
		}

		// Token: 0x0602FF39 RID: 196409 RVA: 0x006855B9 File Offset: 0x006837B9
		public static void StartIMonsterMoveSplineConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602FF3A RID: 196410 RVA: 0x006855C2 File Offset: 0x006837C2
		public static void AddTargetEntityId(FlatBufferBuilder builder, int targetEntityId)
		{
			builder.AddInt(0, targetEntityId, 0);
		}

		// Token: 0x0602FF3B RID: 196411 RVA: 0x006855CD File Offset: 0x006837CD
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(1, splineEntityId, 0);
		}

		// Token: 0x0602FF3C RID: 196412 RVA: 0x006855D8 File Offset: 0x006837D8
		public static Offset<IMonsterMoveSplineConfig> EndIMonsterMoveSplineConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterMoveSplineConfig>(builder.EndTable());
		}

		// Token: 0x0602FF3D RID: 196413 RVA: 0x006855E8 File Offset: 0x006837E8
		public IMonsterMoveSplineConfigT UnPack()
		{
			IMonsterMoveSplineConfigT monsterMoveSplineConfigT = new IMonsterMoveSplineConfigT();
			this.UnPackTo(monsterMoveSplineConfigT);
			return monsterMoveSplineConfigT;
		}

		// Token: 0x0602FF3E RID: 196414 RVA: 0x00685603 File Offset: 0x00683803
		public void UnPackTo(IMonsterMoveSplineConfigT _o)
		{
			_o.TargetEntityId = this.TargetEntityId;
			_o.SplineEntityId = this.SplineEntityId;
		}

		// Token: 0x0602FF3F RID: 196415 RVA: 0x00685620 File Offset: 0x00683820
		public static Offset<IMonsterMoveSplineConfig> Pack(FlatBufferBuilder builder, IMonsterMoveSplineConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterMoveSplineConfig>);
			}
			return IMonsterMoveSplineConfig.CreateIMonsterMoveSplineConfig(builder, _o.TargetEntityId, _o.SplineEntityId);
		}

		// Token: 0x0401132B RID: 70443
		private Table __p;
	}
}
