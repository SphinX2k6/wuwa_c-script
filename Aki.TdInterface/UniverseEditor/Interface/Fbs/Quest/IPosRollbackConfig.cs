using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043F1 RID: 17393
	public struct IPosRollbackConfig : IFlatbufferObject
	{
		// Token: 0x170077D7 RID: 30679
		// (get) Token: 0x06018B71 RID: 101233 RVA: 0x00385EA2 File Offset: 0x003840A2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018B72 RID: 101234 RVA: 0x00385EAF File Offset: 0x003840AF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018B73 RID: 101235 RVA: 0x00385EB8 File Offset: 0x003840B8
		public static IPosRollbackConfig GetRootAsIPosRollbackConfig(ByteBuffer _bb)
		{
			return IPosRollbackConfig.GetRootAsIPosRollbackConfig(_bb, default(IPosRollbackConfig));
		}

		// Token: 0x06018B74 RID: 101236 RVA: 0x00385ED4 File Offset: 0x003840D4
		public static IPosRollbackConfig GetRootAsIPosRollbackConfig(ByteBuffer _bb, IPosRollbackConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018B75 RID: 101237 RVA: 0x00385EF1 File Offset: 0x003840F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018B76 RID: 101238 RVA: 0x00385F00 File Offset: 0x00384100
		public IPosRollbackConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170077D8 RID: 30680
		// (get) Token: 0x06018B77 RID: 101239 RVA: 0x00385F10 File Offset: 0x00384110
		public int RangeEntityId
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

		// Token: 0x170077D9 RID: 30681
		// (get) Token: 0x06018B78 RID: 101240 RVA: 0x00385F4C File Offset: 0x0038414C
		public int PositionEntityId
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

		// Token: 0x170077DA RID: 30682
		// (get) Token: 0x06018B79 RID: 101241 RVA: 0x00385F88 File Offset: 0x00384188
		public bool GravityFlip
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170077DB RID: 30683
		// (get) Token: 0x06018B7A RID: 101242 RVA: 0x00385FC8 File Offset: 0x003841C8
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

		// Token: 0x06018B7B RID: 101243 RVA: 0x00386005 File Offset: 0x00384205
		public static Offset<IPosRollbackConfig> CreateIPosRollbackConfig(FlatBufferBuilder builder, int RangeEntityId = 0, int PositionEntityId = 0, bool GravityFlip = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IPosRollbackConfig.AddPositionEntityId(builder, PositionEntityId);
			IPosRollbackConfig.AddRangeEntityId(builder, RangeEntityId);
			IPosRollbackConfig.AddNullMask(builder, NullMask);
			IPosRollbackConfig.AddGravityFlip(builder, GravityFlip);
			return IPosRollbackConfig.EndIPosRollbackConfig(builder);
		}

		// Token: 0x06018B7C RID: 101244 RVA: 0x00386031 File Offset: 0x00384231
		public static void StartIPosRollbackConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06018B7D RID: 101245 RVA: 0x0038603A File Offset: 0x0038423A
		public static void AddRangeEntityId(FlatBufferBuilder builder, int rangeEntityId)
		{
			builder.AddInt(0, rangeEntityId, 0);
		}

		// Token: 0x06018B7E RID: 101246 RVA: 0x00386045 File Offset: 0x00384245
		public static void AddPositionEntityId(FlatBufferBuilder builder, int positionEntityId)
		{
			builder.AddInt(1, positionEntityId, 0);
		}

		// Token: 0x06018B7F RID: 101247 RVA: 0x00386050 File Offset: 0x00384250
		public static void AddGravityFlip(FlatBufferBuilder builder, bool gravityFlip)
		{
			builder.AddBool(2, gravityFlip, false);
		}

		// Token: 0x06018B80 RID: 101248 RVA: 0x0038605B File Offset: 0x0038425B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06018B81 RID: 101249 RVA: 0x00386066 File Offset: 0x00384266
		public static Offset<IPosRollbackConfig> EndIPosRollbackConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPosRollbackConfig>(builder.EndTable());
		}

		// Token: 0x06018B82 RID: 101250 RVA: 0x00386074 File Offset: 0x00384274
		public IPosRollbackConfigT UnPack()
		{
			IPosRollbackConfigT posRollbackConfigT = new IPosRollbackConfigT();
			this.UnPackTo(posRollbackConfigT);
			return posRollbackConfigT;
		}

		// Token: 0x06018B83 RID: 101251 RVA: 0x0038608F File Offset: 0x0038428F
		public void UnPackTo(IPosRollbackConfigT _o)
		{
			_o.RangeEntityId = this.RangeEntityId;
			_o.PositionEntityId = this.PositionEntityId;
			_o.GravityFlip = this.GravityFlip;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06018B84 RID: 101252 RVA: 0x003860C4 File Offset: 0x003842C4
		public static Offset<IPosRollbackConfig> Pack(FlatBufferBuilder builder, IPosRollbackConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPosRollbackConfig>);
			}
			return IPosRollbackConfig.CreateIPosRollbackConfig(builder, _o.RangeEntityId, _o.PositionEntityId, _o.GravityFlip, _o.NullMask);
		}

		// Token: 0x0400C3FF RID: 50175
		private Table __p;
	}
}
