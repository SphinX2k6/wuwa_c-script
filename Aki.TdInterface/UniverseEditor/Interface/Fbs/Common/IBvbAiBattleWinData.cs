using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006353 RID: 25427
	public struct IBvbAiBattleWinData : IFlatbufferObject
	{
		// Token: 0x1700BC08 RID: 48136
		// (get) Token: 0x0602B219 RID: 176665 RVA: 0x005E0B3C File Offset: 0x005DED3C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B21A RID: 176666 RVA: 0x005E0B49 File Offset: 0x005DED49
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B21B RID: 176667 RVA: 0x005E0B50 File Offset: 0x005DED50
		public static IBvbAiBattleWinData GetRootAsIBvbAiBattleWinData(ByteBuffer _bb)
		{
			return IBvbAiBattleWinData.GetRootAsIBvbAiBattleWinData(_bb, default(IBvbAiBattleWinData));
		}

		// Token: 0x0602B21C RID: 176668 RVA: 0x005E0B6C File Offset: 0x005DED6C
		public static IBvbAiBattleWinData GetRootAsIBvbAiBattleWinData(ByteBuffer _bb, IBvbAiBattleWinData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B21D RID: 176669 RVA: 0x005E0B89 File Offset: 0x005DED89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B21E RID: 176670 RVA: 0x005E0B98 File Offset: 0x005DED98
		public IBvbAiBattleWinData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC09 RID: 48137
		// (get) Token: 0x0602B21F RID: 176671 RVA: 0x005E0BA8 File Offset: 0x005DEDA8
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

		// Token: 0x0602B220 RID: 176672 RVA: 0x005E0BE4 File Offset: 0x005DEDE4
		public static Offset<IBvbAiBattleWinData> CreateIBvbAiBattleWinData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution)
		{
			builder.StartTable(1);
			IBvbAiBattleWinData.AddType(builder, Type);
			return IBvbAiBattleWinData.EndIBvbAiBattleWinData(builder);
		}

		// Token: 0x0602B221 RID: 176673 RVA: 0x005E0BFA File Offset: 0x005DEDFA
		public static void StartIBvbAiBattleWinData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B222 RID: 176674 RVA: 0x005E0C03 File Offset: 0x005DEE03
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B223 RID: 176675 RVA: 0x005E0C0E File Offset: 0x005DEE0E
		public static Offset<IBvbAiBattleWinData> EndIBvbAiBattleWinData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbAiBattleWinData>(builder.EndTable());
		}

		// Token: 0x0602B224 RID: 176676 RVA: 0x005E0C1C File Offset: 0x005DEE1C
		public IBvbAiBattleWinDataT UnPack()
		{
			IBvbAiBattleWinDataT bvbAiBattleWinDataT = new IBvbAiBattleWinDataT();
			this.UnPackTo(bvbAiBattleWinDataT);
			return bvbAiBattleWinDataT;
		}

		// Token: 0x0602B225 RID: 176677 RVA: 0x005E0C37 File Offset: 0x005DEE37
		public void UnPackTo(IBvbAiBattleWinDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B226 RID: 176678 RVA: 0x005E0C48 File Offset: 0x005DEE48
		public static Offset<IBvbAiBattleWinData> Pack(FlatBufferBuilder builder, IBvbAiBattleWinDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbAiBattleWinData>);
			}
			return IBvbAiBattleWinData.CreateIBvbAiBattleWinData(builder, _o.Type);
		}

		// Token: 0x0401041C RID: 66588
		private Table __p;
	}
}
