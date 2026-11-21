using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063A1 RID: 25505
	public struct IBvbStartRoundData : IFlatbufferObject
	{
		// Token: 0x1700BC80 RID: 48256
		// (get) Token: 0x0602B4F2 RID: 177394 RVA: 0x005E74E5 File Offset: 0x005E56E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B4F3 RID: 177395 RVA: 0x005E74F2 File Offset: 0x005E56F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B4F4 RID: 177396 RVA: 0x005E74FC File Offset: 0x005E56FC
		public static IBvbStartRoundData GetRootAsIBvbStartRoundData(ByteBuffer _bb)
		{
			return IBvbStartRoundData.GetRootAsIBvbStartRoundData(_bb, default(IBvbStartRoundData));
		}

		// Token: 0x0602B4F5 RID: 177397 RVA: 0x005E7518 File Offset: 0x005E5718
		public static IBvbStartRoundData GetRootAsIBvbStartRoundData(ByteBuffer _bb, IBvbStartRoundData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B4F6 RID: 177398 RVA: 0x005E7535 File Offset: 0x005E5735
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B4F7 RID: 177399 RVA: 0x005E7544 File Offset: 0x005E5744
		public IBvbStartRoundData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC81 RID: 48257
		// (get) Token: 0x0602B4F8 RID: 177400 RVA: 0x005E7554 File Offset: 0x005E5754
		public EBvbEventName Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBvbEventName.AIEvolution;
				}
				return (EBvbEventName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B4F9 RID: 177401 RVA: 0x005E7590 File Offset: 0x005E5790
		public static Offset<IBvbStartRoundData> CreateIBvbStartRoundData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution)
		{
			builder.StartTable(1);
			IBvbStartRoundData.AddType(builder, Type);
			return IBvbStartRoundData.EndIBvbStartRoundData(builder);
		}

		// Token: 0x0602B4FA RID: 177402 RVA: 0x005E75A6 File Offset: 0x005E57A6
		public static void StartIBvbStartRoundData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B4FB RID: 177403 RVA: 0x005E75AF File Offset: 0x005E57AF
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B4FC RID: 177404 RVA: 0x005E75BA File Offset: 0x005E57BA
		public static Offset<IBvbStartRoundData> EndIBvbStartRoundData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbStartRoundData>(builder.EndTable());
		}

		// Token: 0x0602B4FD RID: 177405 RVA: 0x005E75C8 File Offset: 0x005E57C8
		public IBvbStartRoundDataT UnPack()
		{
			IBvbStartRoundDataT bvbStartRoundDataT = new IBvbStartRoundDataT();
			this.UnPackTo(bvbStartRoundDataT);
			return bvbStartRoundDataT;
		}

		// Token: 0x0602B4FE RID: 177406 RVA: 0x005E75E3 File Offset: 0x005E57E3
		public void UnPackTo(IBvbStartRoundDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B4FF RID: 177407 RVA: 0x005E75F4 File Offset: 0x005E57F4
		public static Offset<IBvbStartRoundData> Pack(FlatBufferBuilder builder, IBvbStartRoundDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbStartRoundData>);
			}
			return IBvbStartRoundData.CreateIBvbStartRoundData(builder, _o.Type);
		}

		// Token: 0x04010486 RID: 66694
		private Table __p;
	}
}
