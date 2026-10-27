using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D52 RID: 23890
	public struct IBvbPlayerBattleWinData : IFlatbufferObject
	{
		// Token: 0x1700B308 RID: 45832
		// (get) Token: 0x06028DFC RID: 167420 RVA: 0x0059DEE7 File Offset: 0x0059C0E7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028DFD RID: 167421 RVA: 0x0059DEF4 File Offset: 0x0059C0F4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028DFE RID: 167422 RVA: 0x0059DEFC File Offset: 0x0059C0FC
		public static IBvbPlayerBattleWinData GetRootAsIBvbPlayerBattleWinData(ByteBuffer _bb)
		{
			return IBvbPlayerBattleWinData.GetRootAsIBvbPlayerBattleWinData(_bb, default(IBvbPlayerBattleWinData));
		}

		// Token: 0x06028DFF RID: 167423 RVA: 0x0059DF18 File Offset: 0x0059C118
		public static IBvbPlayerBattleWinData GetRootAsIBvbPlayerBattleWinData(ByteBuffer _bb, IBvbPlayerBattleWinData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028E00 RID: 167424 RVA: 0x0059DF35 File Offset: 0x0059C135
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028E01 RID: 167425 RVA: 0x0059DF44 File Offset: 0x0059C144
		public IBvbPlayerBattleWinData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B309 RID: 45833
		// (get) Token: 0x06028E02 RID: 167426 RVA: 0x0059DF54 File Offset: 0x0059C154
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

		// Token: 0x06028E03 RID: 167427 RVA: 0x0059DF90 File Offset: 0x0059C190
		public static Offset<IBvbPlayerBattleWinData> CreateIBvbPlayerBattleWinData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution)
		{
			builder.StartTable(1);
			IBvbPlayerBattleWinData.AddType(builder, Type);
			return IBvbPlayerBattleWinData.EndIBvbPlayerBattleWinData(builder);
		}

		// Token: 0x06028E04 RID: 167428 RVA: 0x0059DFA6 File Offset: 0x0059C1A6
		public static void StartIBvbPlayerBattleWinData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06028E05 RID: 167429 RVA: 0x0059DFAF File Offset: 0x0059C1AF
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028E06 RID: 167430 RVA: 0x0059DFBA File Offset: 0x0059C1BA
		public static Offset<IBvbPlayerBattleWinData> EndIBvbPlayerBattleWinData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbPlayerBattleWinData>(builder.EndTable());
		}

		// Token: 0x06028E07 RID: 167431 RVA: 0x0059DFC8 File Offset: 0x0059C1C8
		public IBvbPlayerBattleWinDataT UnPack()
		{
			IBvbPlayerBattleWinDataT bvbPlayerBattleWinDataT = new IBvbPlayerBattleWinDataT();
			this.UnPackTo(bvbPlayerBattleWinDataT);
			return bvbPlayerBattleWinDataT;
		}

		// Token: 0x06028E08 RID: 167432 RVA: 0x0059DFE3 File Offset: 0x0059C1E3
		public void UnPackTo(IBvbPlayerBattleWinDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06028E09 RID: 167433 RVA: 0x0059DFF4 File Offset: 0x0059C1F4
		public static Offset<IBvbPlayerBattleWinData> Pack(FlatBufferBuilder builder, IBvbPlayerBattleWinDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbPlayerBattleWinData>);
			}
			return IBvbPlayerBattleWinData.CreateIBvbPlayerBattleWinData(builder, _o.Type);
		}

		// Token: 0x0400F71F RID: 63263
		private Table __p;
	}
}
