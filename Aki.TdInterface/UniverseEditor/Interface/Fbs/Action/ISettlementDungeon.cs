using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007866 RID: 30822
	public struct ISettlementDungeon : IFlatbufferObject
	{
		// Token: 0x1700E211 RID: 57873
		// (get) Token: 0x06036350 RID: 222032 RVA: 0x00742DE3 File Offset: 0x00740FE3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036351 RID: 222033 RVA: 0x00742DF0 File Offset: 0x00740FF0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036352 RID: 222034 RVA: 0x00742DF8 File Offset: 0x00740FF8
		public static ISettlementDungeon GetRootAsISettlementDungeon(ByteBuffer _bb)
		{
			return ISettlementDungeon.GetRootAsISettlementDungeon(_bb, default(ISettlementDungeon));
		}

		// Token: 0x06036353 RID: 222035 RVA: 0x00742E14 File Offset: 0x00741014
		public static ISettlementDungeon GetRootAsISettlementDungeon(ByteBuffer _bb, ISettlementDungeon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036354 RID: 222036 RVA: 0x00742E31 File Offset: 0x00741031
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036355 RID: 222037 RVA: 0x00742E40 File Offset: 0x00741040
		public ISettlementDungeon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06036356 RID: 222038 RVA: 0x00742E50 File Offset: 0x00741050
		public static void StartISettlementDungeon(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06036357 RID: 222039 RVA: 0x00742E59 File Offset: 0x00741059
		public static Offset<ISettlementDungeon> EndISettlementDungeon(FlatBufferBuilder builder)
		{
			return new Offset<ISettlementDungeon>(builder.EndTable());
		}

		// Token: 0x06036358 RID: 222040 RVA: 0x00742E68 File Offset: 0x00741068
		public ISettlementDungeonT UnPack()
		{
			ISettlementDungeonT settlementDungeonT = new ISettlementDungeonT();
			this.UnPackTo(settlementDungeonT);
			return settlementDungeonT;
		}

		// Token: 0x06036359 RID: 222041 RVA: 0x00742E83 File Offset: 0x00741083
		public void UnPackTo(ISettlementDungeonT _o)
		{
		}

		// Token: 0x0603635A RID: 222042 RVA: 0x00742E88 File Offset: 0x00741088
		public static Offset<ISettlementDungeon> Pack(FlatBufferBuilder builder, ISettlementDungeonT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISettlementDungeon>);
			}
			ISettlementDungeon.StartISettlementDungeon(builder);
			return ISettlementDungeon.EndISettlementDungeon(builder);
		}

		// Token: 0x04012AF2 RID: 76530
		private Table __p;
	}
}
