using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006389 RID: 25481
	public struct IBvbPlayerBattleWinData : IFlatbufferObject
	{
		// Token: 0x1700BC69 RID: 48233
		// (get) Token: 0x0602B466 RID: 177254 RVA: 0x005E6957 File Offset: 0x005E4B57
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B467 RID: 177255 RVA: 0x005E6964 File Offset: 0x005E4B64
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B468 RID: 177256 RVA: 0x005E696C File Offset: 0x005E4B6C
		public static IBvbPlayerBattleWinData GetRootAsIBvbPlayerBattleWinData(ByteBuffer _bb)
		{
			return IBvbPlayerBattleWinData.GetRootAsIBvbPlayerBattleWinData(_bb, default(IBvbPlayerBattleWinData));
		}

		// Token: 0x0602B469 RID: 177257 RVA: 0x005E6988 File Offset: 0x005E4B88
		public static IBvbPlayerBattleWinData GetRootAsIBvbPlayerBattleWinData(ByteBuffer _bb, IBvbPlayerBattleWinData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B46A RID: 177258 RVA: 0x005E69A5 File Offset: 0x005E4BA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B46B RID: 177259 RVA: 0x005E69B4 File Offset: 0x005E4BB4
		public IBvbPlayerBattleWinData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC6A RID: 48234
		// (get) Token: 0x0602B46C RID: 177260 RVA: 0x005E69C4 File Offset: 0x005E4BC4
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

		// Token: 0x0602B46D RID: 177261 RVA: 0x005E6A00 File Offset: 0x005E4C00
		public static Offset<IBvbPlayerBattleWinData> CreateIBvbPlayerBattleWinData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution)
		{
			builder.StartTable(1);
			IBvbPlayerBattleWinData.AddType(builder, Type);
			return IBvbPlayerBattleWinData.EndIBvbPlayerBattleWinData(builder);
		}

		// Token: 0x0602B46E RID: 177262 RVA: 0x005E6A16 File Offset: 0x005E4C16
		public static void StartIBvbPlayerBattleWinData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B46F RID: 177263 RVA: 0x005E6A1F File Offset: 0x005E4C1F
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B470 RID: 177264 RVA: 0x005E6A2A File Offset: 0x005E4C2A
		public static Offset<IBvbPlayerBattleWinData> EndIBvbPlayerBattleWinData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbPlayerBattleWinData>(builder.EndTable());
		}

		// Token: 0x0602B471 RID: 177265 RVA: 0x005E6A38 File Offset: 0x005E4C38
		public IBvbPlayerBattleWinDataT UnPack()
		{
			IBvbPlayerBattleWinDataT bvbPlayerBattleWinDataT = new IBvbPlayerBattleWinDataT();
			this.UnPackTo(bvbPlayerBattleWinDataT);
			return bvbPlayerBattleWinDataT;
		}

		// Token: 0x0602B472 RID: 177266 RVA: 0x005E6A53 File Offset: 0x005E4C53
		public void UnPackTo(IBvbPlayerBattleWinDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B473 RID: 177267 RVA: 0x005E6A64 File Offset: 0x005E4C64
		public static Offset<IBvbPlayerBattleWinData> Pack(FlatBufferBuilder builder, IBvbPlayerBattleWinDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbPlayerBattleWinData>);
			}
			return IBvbPlayerBattleWinData.CreateIBvbPlayerBattleWinData(builder, _o.Type);
		}

		// Token: 0x04010471 RID: 66673
		private Table __p;
	}
}
