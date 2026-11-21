using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007213 RID: 29203
	public struct IMonsterMoveSplineConfig : IFlatbufferObject
	{
		// Token: 0x1700D5BE RID: 54718
		// (get) Token: 0x06032CFC RID: 208124 RVA: 0x006DCA51 File Offset: 0x006DAC51
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032CFD RID: 208125 RVA: 0x006DCA5E File Offset: 0x006DAC5E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032CFE RID: 208126 RVA: 0x006DCA68 File Offset: 0x006DAC68
		public static IMonsterMoveSplineConfig GetRootAsIMonsterMoveSplineConfig(ByteBuffer _bb)
		{
			return IMonsterMoveSplineConfig.GetRootAsIMonsterMoveSplineConfig(_bb, default(IMonsterMoveSplineConfig));
		}

		// Token: 0x06032CFF RID: 208127 RVA: 0x006DCA84 File Offset: 0x006DAC84
		public static IMonsterMoveSplineConfig GetRootAsIMonsterMoveSplineConfig(ByteBuffer _bb, IMonsterMoveSplineConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032D00 RID: 208128 RVA: 0x006DCAA1 File Offset: 0x006DACA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032D01 RID: 208129 RVA: 0x006DCAB0 File Offset: 0x006DACB0
		public IMonsterMoveSplineConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D5BF RID: 54719
		// (get) Token: 0x06032D02 RID: 208130 RVA: 0x006DCAC0 File Offset: 0x006DACC0
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

		// Token: 0x1700D5C0 RID: 54720
		// (get) Token: 0x06032D03 RID: 208131 RVA: 0x006DCAFC File Offset: 0x006DACFC
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

		// Token: 0x1700D5C1 RID: 54721
		// (get) Token: 0x06032D04 RID: 208132 RVA: 0x006DCB38 File Offset: 0x006DAD38
		public bool IsStrict
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D5C2 RID: 54722
		// (get) Token: 0x06032D05 RID: 208133 RVA: 0x006DCB78 File Offset: 0x006DAD78
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032D06 RID: 208134 RVA: 0x006DCBB5 File Offset: 0x006DADB5
		public static Offset<IMonsterMoveSplineConfig> CreateIMonsterMoveSplineConfig(FlatBufferBuilder builder, int TargetEntityId = 0, int SplineEntityId = 0, bool IsStrict = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IMonsterMoveSplineConfig.AddSplineEntityId(builder, SplineEntityId);
			IMonsterMoveSplineConfig.AddTargetEntityId(builder, TargetEntityId);
			IMonsterMoveSplineConfig.AddNullMask(builder, NullMask);
			IMonsterMoveSplineConfig.AddIsStrict(builder, IsStrict);
			return IMonsterMoveSplineConfig.EndIMonsterMoveSplineConfig(builder);
		}

		// Token: 0x06032D07 RID: 208135 RVA: 0x006DCBE1 File Offset: 0x006DADE1
		public static void StartIMonsterMoveSplineConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06032D08 RID: 208136 RVA: 0x006DCBEA File Offset: 0x006DADEA
		public static void AddTargetEntityId(FlatBufferBuilder builder, int targetEntityId)
		{
			builder.AddInt(0, targetEntityId, 0);
		}

		// Token: 0x06032D09 RID: 208137 RVA: 0x006DCBF5 File Offset: 0x006DADF5
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(1, splineEntityId, 0);
		}

		// Token: 0x06032D0A RID: 208138 RVA: 0x006DCC00 File Offset: 0x006DAE00
		public static void AddIsStrict(FlatBufferBuilder builder, bool isStrict)
		{
			builder.AddBool(2, isStrict, false);
		}

		// Token: 0x06032D0B RID: 208139 RVA: 0x006DCC0B File Offset: 0x006DAE0B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06032D0C RID: 208140 RVA: 0x006DCC16 File Offset: 0x006DAE16
		public static Offset<IMonsterMoveSplineConfig> EndIMonsterMoveSplineConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterMoveSplineConfig>(builder.EndTable());
		}

		// Token: 0x06032D0D RID: 208141 RVA: 0x006DCC24 File Offset: 0x006DAE24
		public IMonsterMoveSplineConfigT UnPack()
		{
			IMonsterMoveSplineConfigT monsterMoveSplineConfigT = new IMonsterMoveSplineConfigT();
			this.UnPackTo(monsterMoveSplineConfigT);
			return monsterMoveSplineConfigT;
		}

		// Token: 0x06032D0E RID: 208142 RVA: 0x006DCC3F File Offset: 0x006DAE3F
		public void UnPackTo(IMonsterMoveSplineConfigT _o)
		{
			_o.TargetEntityId = this.TargetEntityId;
			_o.SplineEntityId = this.SplineEntityId;
			_o.IsStrict = this.IsStrict;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032D0F RID: 208143 RVA: 0x006DCC74 File Offset: 0x006DAE74
		public static Offset<IMonsterMoveSplineConfig> Pack(FlatBufferBuilder builder, IMonsterMoveSplineConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterMoveSplineConfig>);
			}
			return IMonsterMoveSplineConfig.CreateIMonsterMoveSplineConfig(builder, _o.TargetEntityId, _o.SplineEntityId, _o.IsStrict, _o.NullMask);
		}

		// Token: 0x0401223C RID: 74300
		private Table __p;
	}
}
