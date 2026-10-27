using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200709A RID: 28826
	public struct ISettlementDungeon : IFlatbufferObject
	{
		// Token: 0x1700D62E RID: 54830
		// (get) Token: 0x060330AE RID: 209070 RVA: 0x006E27D7 File Offset: 0x006E09D7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060330AF RID: 209071 RVA: 0x006E27E4 File Offset: 0x006E09E4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060330B0 RID: 209072 RVA: 0x006E27EC File Offset: 0x006E09EC
		public static ISettlementDungeon GetRootAsISettlementDungeon(ByteBuffer _bb)
		{
			return ISettlementDungeon.GetRootAsISettlementDungeon(_bb, default(ISettlementDungeon));
		}

		// Token: 0x060330B1 RID: 209073 RVA: 0x006E2808 File Offset: 0x006E0A08
		public static ISettlementDungeon GetRootAsISettlementDungeon(ByteBuffer _bb, ISettlementDungeon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060330B2 RID: 209074 RVA: 0x006E2825 File Offset: 0x006E0A25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060330B3 RID: 209075 RVA: 0x006E2834 File Offset: 0x006E0A34
		public ISettlementDungeon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060330B4 RID: 209076 RVA: 0x006E2844 File Offset: 0x006E0A44
		public static void StartISettlementDungeon(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x060330B5 RID: 209077 RVA: 0x006E284D File Offset: 0x006E0A4D
		public static Offset<ISettlementDungeon> EndISettlementDungeon(FlatBufferBuilder builder)
		{
			return new Offset<ISettlementDungeon>(builder.EndTable());
		}

		// Token: 0x060330B6 RID: 209078 RVA: 0x006E285C File Offset: 0x006E0A5C
		public ISettlementDungeonT UnPack()
		{
			ISettlementDungeonT settlementDungeonT = new ISettlementDungeonT();
			this.UnPackTo(settlementDungeonT);
			return settlementDungeonT;
		}

		// Token: 0x060330B7 RID: 209079 RVA: 0x006E2877 File Offset: 0x006E0A77
		public void UnPackTo(ISettlementDungeonT _o)
		{
		}

		// Token: 0x060330B8 RID: 209080 RVA: 0x006E287C File Offset: 0x006E0A7C
		public static Offset<ISettlementDungeon> Pack(FlatBufferBuilder builder, ISettlementDungeonT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISettlementDungeon>);
			}
			ISettlementDungeon.StartISettlementDungeon(builder);
			return ISettlementDungeon.EndISettlementDungeon(builder);
		}

		// Token: 0x04011B04 RID: 72452
		private Table __p;
	}
}
